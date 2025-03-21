using Factory.BLL;
using Factory.BLL.InterFaces;
using Factory.DAL;
using Factory.DAL.Models.Auth;
using Factory.DAL.Models.Settings;
using Factory.PL.Helper;
using Factory.PL.Options;
using Factory.PL.Services;
using Factory.PL.Services.AI;
using Factory.PL.Services.Background;
using Factory.PL.Services.Dashboard;
using Factory.PL.Services.DataExportImport;
using Factory.PL.Services.Email;
using Factory.PL.Services.Monitor;
using Factory.PL.Services.NavbarSettings;
using Factory.PL.Services.Notify;
using Factory.PL.Services.Order;
using Factory.PL.Services.Permissions;
using Factory.PL.Services.Permssions;
using Factory.PL.Services.Setting;
using Factory.PL.Services.UploadFile;
using Factory.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Serilog;
using Serilog.Events;
using System.Configuration;
using System.Globalization;

public static class ServiceConfiguration
{
    public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<Names>(configuration.GetSection("Application"));

        services.AddMvc()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString;
            });
        ConfigureSerilog(configuration, services);
        ConfigureLocalization(services);
        ConfigureApplicationServices(services, configuration);
        ConfigureDatabase(services, configuration);
        ConfigureIdentity(services);
        ConfigureSecurity(services);
    }
    private static void ConfigureLocalization(IServiceCollection services)
    {
        services.AddSingleton<IStringLocalizerFactory>(new JsonStringLocalizerFactory("Resources"));

        services.AddLocalization(options => options.ResourcesPath = "Resources");
        var supportedCultures = new[]
        {
            new CultureInfo("en-US"), 
            new CultureInfo("ar-SA"), 
            new CultureInfo("fr-FR"), 
        };

        services.AddControllersWithViews()
            .AddDataAnnotationsLocalization() 
            .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix); 
    }
    private static void ConfigureApplicationServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient<IAIChatService, FreeAIChatService>(client =>
        {
            client.Timeout = TimeSpan.FromSeconds(30);
        });

        services.AddHttpClient<FreeAIChatService>();
        services.AddScoped<IAIChatService>(sp =>
        {
            var config = sp.GetRequiredService<IConfiguration>();
            var useFreeTier = config.GetValue<bool>("AIService:UseFreeTier") || true;

            if (useFreeTier)
            {
                return sp.GetRequiredService<FreeAIChatService>();
            }
            else
            {
                return sp.GetRequiredService<HuggingFaceChatService>(); 
            }
        });      
        services.AddSingleton<SystemMonitoringService>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddSingleton(new ExportImportSettings());
        services.AddScoped<IExportService, ExportService>();
        services.AddScoped<IImportService, ImportService>();
        services.AddScoped<IDashboardService, DashboardService>();
        services.AddHostedService<AccountDeletionBackgroundService>();
        services.Configure<EmailConfiguration>(configuration.GetSection("MailConfigurations"));
        services.AddSingleton<EmailConfiguration>();
        services.Configure<CompanyDetails>(configuration.GetSection("CompanyDetails"));
        services.AddSingleton<CompanyDetails>();
        services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IFileService, FileService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<ISettingsService, SettingsService>();
        services.AddScoped<IVideoService, VideoService>();
        services.AddScoped<IModuleService, ModuleService>();
        services.AddScoped<INavigationService, NavigationService>();
        services.AddScoped<IEmailService, EmailSender>();
        services.AddAuthorization();
        services.AddSingleton<IAuthorizationPolicyProvider, CustomAuthorizationPolicyProvider>();
        services.AddResponseCompression(options =>
        {
            options.EnableForHttps = true; 
            options.Providers.Add<GzipCompressionProvider>(); 
        });

        services.Configure<GzipCompressionProviderOptions>(options =>
        {
            options.Level = System.IO.Compression.CompressionLevel.Optimal; 
        });
        services.AddScoped<INotificationService, NotificationService>();
        services.AddSignalR();
        services.AddAuthentication(options =>
        {
            options.DefaultScheme = "Cookies";
            options.DefaultChallengeScheme = "Facebook";
        })
        .AddCookie("Cookies")
        .AddGoogle("Google", options =>
        {
            var clientId = configuration["Authentication:Google:ClientId"];
            var clientSecret = configuration["Authentication:Google:ClientSecret"];

            if (string.IsNullOrEmpty(clientId))
            {
                throw new InvalidOperationException("Google ClientId is not configured properly.");
            }

            if (string.IsNullOrEmpty(clientSecret))
            {
                throw new InvalidOperationException("Google ClientSecret is not configured properly.");
            }

            options.ClientId = clientId;
            options.ClientSecret = clientSecret;
            options.CallbackPath = new PathString("/signin-google");
        })
        .AddFacebook("Facebook", options =>
        {
            var appId = configuration["Authentication:Facebook:AppId"];
            var appSecret = configuration["Authentication:Facebook:AppSecret"];

            if (string.IsNullOrEmpty(appId))
            {
                throw new InvalidOperationException("Facebook AppId is not configured properly.");
            }

            if (string.IsNullOrEmpty(appSecret))
            {
                throw new InvalidOperationException("Facebook AppSecret is not configured properly.");
            }

            options.AppId = appId;
            options.AppSecret = appSecret;
            options.CallbackPath = new PathString("/signin-facebook");
        })
        .AddMicrosoftAccount("Microsoft", options =>
        {
            var clientId = configuration["Authentication:Microsoft:ClientId"];
            var clientSecret = configuration["Authentication:Microsoft:ClientSecret"];

            if (string.IsNullOrEmpty(clientId))
            {
                throw new InvalidOperationException("Microsoft ClientId is not configured properly.");
            }

            if (string.IsNullOrEmpty(clientSecret))
            {
                throw new InvalidOperationException("Microsoft ClientSecret is not configured properly.");
            }

            options.ClientId = clientId;
            options.ClientSecret = clientSecret;
            options.CallbackPath = new PathString("/signin-microsoft");
        });

    }
    private static void ConfigureDatabase(IServiceCollection services, IConfiguration configuration)
    {
        var factoryName = configuration["Factory:Name"];
        var domain = configuration["Factory:Domain"];
        var baseConnectionString = configuration.GetConnectionString("DefaultConnection");

        if (string.IsNullOrEmpty(factoryName) || string.IsNullOrEmpty(domain) || string.IsNullOrEmpty(baseConnectionString))
        {
            throw new InvalidOperationException("Factory name, domain, or default connection string is not configured.");
        }

        var dynamicConnectionString = ConnectionStringBuilder.Build(baseConnectionString, factoryName, domain);

        services.AddDbContext<FactDdContext>((serviceProvider, options) =>
        {
            options.UseLazyLoadingProxies();
            options.UseSqlServer(dynamicConnectionString, sqlOptions =>
            {
                sqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(10),
                    errorNumbersToAdd: null);
            });

            options.EnableSensitiveDataLogging();
        }, ServiceLifetime.Scoped); 
    }
    private static void ConfigureIdentity(IServiceCollection services)
    {
        services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<FactDdContext>()
            .AddDefaultTokenProviders();
    }
    private static void ConfigureSecurity(IServiceCollection services)
    {
        services.ConfigureApplicationCookie(options =>
        {
            options.Cookie.Name = "FactoryAuthCookie";
            options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            options.Cookie.SameSite = SameSiteMode.Strict;
            options.LoginPath = "/Auth/Login";
            options.LogoutPath = "/Auth/LogOut";
            options.AccessDeniedPath = "/Auth/AccessDenied";
            options.ExpireTimeSpan = TimeSpan.FromDays(2);
        });

        services.AddSession(options =>
        {
            options.Cookie.Name = "FactorySessionCookie";
            options.IdleTimeout = TimeSpan.FromDays(2);
            options.Cookie.HttpOnly = true;
            options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
            options.Cookie.SameSite = SameSiteMode.Strict;
        });
    }
    public static void ConfigureSerilog(IConfiguration configuration, IServiceCollection services)
    {
        Log.Logger = new LoggerConfiguration()
                    .ReadFrom.Configuration(configuration)
                    .Enrich.WithCorrelationId()  
                    .Enrich.WithMachineName()  
                    .Enrich.WithThreadId()      
                    .Enrich.WithProperty("Application", "MasterCopy") 
                    .MinimumLevel.Error()
                    .WriteTo.Console(Serilog.Events.LogEventLevel.Information,
                        outputTemplate: "{Timestamp:HH:mm:ss} [{Level}] ({ThreadId}) {Message}{NewLine}{Exception}") // Custom console output format
                    //.WriteTo.Seq("http://localhost:5341", restrictedToMinimumLevel: LogEventLevel.Information) 
                    .CreateLogger();
        services.AddSerilog();
    }
}



