using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Factory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ApplyAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMFAEnabled = table.Column<bool>(type: "bit", nullable: false),
                    IsDarkModeEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LastBackupDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteRequestedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsFirstLogin = table.Column<bool>(type: "bit", nullable: false),
                    HasCompletedTour = table.Column<bool>(type: "bit", nullable: false),
                    AccountCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthenticatorKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecoveryCodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactUs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documentation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documentation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExportImportSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnableExport = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    EnableImport = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SupportedExportFormats = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportedImportFormats = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxExportRows = table.Column<int>(type: "int", nullable: false, defaultValue: 10000),
                    MaxImportFileSize = table.Column<int>(type: "int", nullable: false, defaultValue: 10485760),
                    IncludeHeaders = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DateFormat = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValue: "yyyy-MM-dd"),
                    DefaultExportFormat = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValue: "XLSX"),
                    CsvDelimiter = table.Column<string>(type: "nvarchar(1)", nullable: false, defaultValue: ","),
                    AllowNullValues = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ValidateImportData = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExportImportSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialRecords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainWarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressEn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AddressAr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainWarehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IconClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IconClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnableEmailNotifications = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EnableSmsNotifications = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EnablePushNotifications = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Frequency = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OnboardingProcess",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnboardingProcess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CustomerReference = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SelectedMachines = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalSQM = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    TotalLM = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Rank = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissionTyepe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionTyepe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SquareFootage = table.Column<int>(type: "int", nullable: false),
                    Bedrooms = table.Column<int>(type: "int", nullable: false),
                    Bathrooms = table.Column<int>(type: "int", nullable: false),
                    PropertyType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ListedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoUrls = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    HasGarage = table.Column<bool>(type: "bit", nullable: false),
                    HasPool = table.Column<bool>(type: "bit", nullable: false),
                    IsFurnished = table.Column<bool>(type: "bit", nullable: false),
                    AgentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AgentEmail = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AgentPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsVisabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Supervisors",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMember",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProfileImageUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IpAddress = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsHidden = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    FacebookLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TwitterLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LinkedInLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    InstagramLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    YouTubeLink = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMember", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FAQS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Views = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    HelpfulVotes = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UnhelpfulVotes = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAQS_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupportTicket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Open"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Medium"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "General"),
                    ResolvedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignedToUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportTicket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportTicket_AspNetUsers_AssignedToUserId",
                        column: x => x.AssignedToUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "HR",
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GlassType = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    MainWarehouseId = table.Column<int>(type: "int", nullable: false),
                    HasDimensions = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DefaultWidth = table.Column<double>(type: "float", nullable: true),
                    DefaultHeight = table.Column<double>(type: "float", nullable: true),
                    DefaultThickness = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_MainWarehouses_MainWarehouseId",
                        column: x => x.MainWarehouseId,
                        principalTable: "MainWarehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubWarehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressEn = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AddressAr = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MainWarehouseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubWarehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubWarehouses_MainWarehouses_MainWarehouseId",
                        column: x => x.MainWarehouseId,
                        principalTable: "MainWarehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Controller = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconClass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubModules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubModules_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ITSetupModule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnboardingProcessId = table.Column<int>(type: "int", nullable: false),
                    EmailSetup = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    HardwareProvisioned = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SoftwareInstalled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    AccessGranted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITSetupModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITSetupModule_OnboardingProcess_OnboardingProcessId",
                        column: x => x.OnboardingProcessId,
                        principalTable: "OnboardingProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrientationModule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnboardingProcessId = table.Column<int>(type: "int", nullable: false),
                    CompanyOrientationCompleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DepartmentOrientationCompleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    MentorAssigned = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    FirstWeekCheckInCompleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrientationModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrientationModule_OnboardingProcess_OnboardingProcessId",
                        column: x => x.OnboardingProcessId,
                        principalTable: "OnboardingProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreboardingModule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnboardingProcessId = table.Column<int>(type: "int", nullable: false),
                    DocumentsReceived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    ContractSigned = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    BackgroundCheckCompleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    WelcomeEmailSent = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreboardingModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PreboardingModule_OnboardingProcess_OnboardingProcessId",
                        column: x => x.OnboardingProcessId,
                        principalTable: "OnboardingProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingModule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnboardingProcessId = table.Column<int>(type: "int", nullable: false),
                    ComplianceTraining = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SkillsTraining = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SystemsTraining = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SecurityTraining = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingModule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingModule_OnboardingProcess_OnboardingProcessId",
                        column: x => x.OnboardingProcessId,
                        principalTable: "OnboardingProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Width = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    Height = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    StepWidth = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: true),
                    StepHeight = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SQM = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    TotalLM = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: false),
                    CustomerReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Rank = table.Column<double>(type: "float(18)", precision: 18, scale: 2, nullable: true),
                    IsDelivered = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeliveredBy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupportResponse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResponseText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SupportTicketId = table.Column<int>(type: "int", nullable: false),
                    RespondedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportResponse_AspNetUsers_RespondedByUserId",
                        column: x => x.RespondedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupportResponse_SupportTicket_SupportTicketId",
                        column: x => x.SupportTicketId,
                        principalTable: "SupportTicket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstNameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastNameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    BaseSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "HR",
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionId",
                        column: x => x.PositionId,
                        principalSchema: "HR",
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameAr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MinimumStock = table.Column<int>(type: "int", nullable: false, defaultValue: 10),
                    CurrentStock = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Piece"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Thickness = table.Column<double>(type: "float", nullable: false, defaultValue: 4.0),
                    Width = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Height = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Clear"),
                    IsToughened = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsLaminated = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Rank = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    ManufacturingCountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Items_Country_ManufacturingCountryId",
                        column: x => x.ManufacturingCountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Action = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Controller = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SubmoduleId = table.Column<int>(type: "int", nullable: false),
                    SecureUrlKey = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_SubModules_SubmoduleId",
                        column: x => x.SubmoduleId,
                        principalTable: "SubModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalDays = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ApprovedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "HR",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offboardings",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastWorkingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitInterviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TerminationReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: true),
                    NoticeGivenDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnOfCompanyPropertyCompleted = table.Column<bool>(type: "bit", nullable: false),
                    AccessRevocationCompleted = table.Column<bool>(type: "bit", nullable: false),
                    KnowledgeTransferCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ExitInterviewCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FinalPaymentCompleted = table.Column<bool>(type: "bit", nullable: false),
                    BenefitsTerminationCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ReferenceArrangementCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FarewellEventCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FeedbackProvided = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offboardings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offboardings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "HR",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offboardings_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalSchema: "HR",
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Onboardings",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: false),
                    OrientationCompleted = table.Column<bool>(type: "bit", nullable: false),
                    WorkspaceSetupCompleted = table.Column<bool>(type: "bit", nullable: false),
                    EquipmentProvidedCompleted = table.Column<bool>(type: "bit", nullable: false),
                    SystemAccessCompleted = table.Column<bool>(type: "bit", nullable: false),
                    TrainingCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IntroductionToTeamCompleted = table.Column<bool>(type: "bit", nullable: false),
                    PoliciesReviewedCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FirstAssignmentCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FeedbackSessionCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Onboardings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Onboardings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "HR",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Onboardings_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalSchema: "HR",
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewPeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewPeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductivityScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QualityScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TeamworkScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommunicationScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InitiativeScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OverallScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ManagerFeedback = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    EmployeeFeedback = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    GoalsForNextPeriod = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DevelopmentPlan = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ReviewStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performances_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "HR",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    SubModuleId = table.Column<int>(type: "int", nullable: false),
                    PageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolePermissions_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Modules_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermissions_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermissions_PermissionTyepe_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "PermissionTyepe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RolePermissions_SubModules_SubModuleId",
                        column: x => x.SubModuleId,
                        principalTable: "SubModules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "IconClass", "IsActive", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "bi-people", true, "User Management", "" },
                    { 2, "bi-person-badge", true, "Role Management", "" },
                    { 3, "bi-box-seam", true, "Inventory Management", "" },
                    { 4, "bi-cart", true, "Order Management", "" },
                    { 5, "bi-cash-stack", true, "Payroll Management", "" },
                    { 6, "bi-speedometer", true, "System Management", "" },
                    { 7, "bi-headset", true, "Support Management", "" },
                    { 8, "bi-file-earmark-bar-graph", true, "Reports", "" },
                    { 9, "bi-gear", true, "Settings", "" },
                    { 10, "bi-people", true, "HR", "" },
                    { 11, "bi-bell", true, "Notifications", "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionTyepe",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Read" },
                    { 2, "Create" },
                    { 3, "Update" },
                    { 4, "Delete" }
                });

            migrationBuilder.InsertData(
                table: "SubModules",
                columns: new[] { "Id", "Action", "Controller", "IconClass", "ModuleId", "Name", "Title" },
                values: new object[,]
                {
                    { 1, "", "", "bi-people", 1, "Users", "" },
                    { 2, "", "", "bi-shield-lock", 1, "Permissions", "" },
                    { 3, "", "", "bi-person-badge", 2, "Roles", "" },
                    { 4, "", "", "bi-person-check", 2, "Assign Roles", "" },
                    { 5, "", "", "bi-box-seam", 3, "Inventory", "" },
                    { 6, "", "", "bi-boxes", 3, "Stock Levels", "" },
                    { 7, "", "", "bi-cart-plus", 4, "New Order", "" },
                    { 8, "", "", "bi-cart-check", 4, "Order History", "" },
                    { 9, "", "", "bi-cash-stack", 5, "Payroll Dashboard", "" },
                    { 10, "", "", "bi-file-earmark-person", 5, "Employee Records", "" },
                    { 11, "", "", "bi-ticket-detailed", 6, "Tickets", "" },
                    { 12, "", "", "bi-speedometer", 6, "System Monitoring", "" },
                    { 13, "", "", "bi-headset", 7, "Support Tickets", "" },
                    { 14, "", "", "bi-chat-dots", 7, "Live Chat", "" },
                    { 15, "", "", "bi-file-earmark-bar-graph", 8, "Reports", "" },
                    { 16, "", "", "bi-speedometer2", 8, "Dashboards", "" },
                    { 17, "", "", "bi-gear", 9, "General Settings", "" },
                    { 18, "", "", "bi-shield", 9, "Security", "" },
                    { 19, "", "", "bi-person-plus", 10, "Onboarding", "" },
                    { 20, "", "", "bi-person-dash", 10, "Offboarding", "" },
                    { 21, "", "", "bi-bar-chart-line", 10, "Performance", "" },
                    { 22, "", "", "bi-person-badge", 10, "Supervisor", "" },
                    { 23, "", "", "bi-briefcase", 10, "Employee Position", "" },
                    { 24, "", "", "bi-building", 10, "Department", "" },
                    { 25, "", "", "bi-calendar-check", 10, "Leave Request", "" },
                    { 26, "", "", "bi-people", 10, "Employees", "" },
                    { 27, "", "", "bi-megaphone", 11, "Notification Service", "" },
                    { 28, "", "", "bi-gear", 11, "Notification Settings", "" }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Action", "Controller", "IsActive", "Name", "SecureUrlKey", "SubmoduleId" },
                values: new object[,]
                {
                    { 1, "Index", "PermissionManagement", true, "Permission List", "fe8cab76723e4c54bd7f3ea28dfd01c5", 2 },
                    { 2, "AssignPermissions", "PermissionManagement", true, "Assign Permission", "fa8a2c87aa0847a0be0e743be624d771", 2 },
                    { 3, "Index", "Module", true, "Module List", "306ead00374b4a34b8a365256c53c3e4", 3 },
                    { 4, "Create", "Module", true, "Add Module", "7e38f4cc5606431fb26ba3b1b96c8970", 3 },
                    { 5, "Index", "SubModule", true, "Submodule List", "3a126a697aaa415c83b15cb6c3c64ea3", 4 },
                    { 6, "Create", "SubModule", true, "Add Submodule", "ab2c23766d814d51a31c60dc0d0a88cd", 4 },
                    { 7, "Index", "Auth", true, "User List", "ea554a2914434e27acf02b8c60da601b", 1 },
                    { 8, "Add", "Auth", true, "Add User", "f12dbdd813e14460835d7bcbefbf2ebf", 1 },
                    { 9, "Index", "Role", true, "Role List", "821ebe14704c4a53867770308c5cd432", 3 },
                    { 10, "Create", "Role", true, "Add Role", "e4535ac8b6e24662805120895c0b5013", 3 },
                    { 11, "Index", "Warehouse", true, "Warehouse List", "7b798fc6f3e14451a0a6311f16a24dc9", 5 },
                    { 12, "Create", "Warehouse", true, "Add Warehouse", "41e269ce5c7b43dda59aa97945d59f6c", 5 },
                    { 13, "Index", "Items", true, "Item List", "cbc6e75346e94316bbb19079928611ee", 6 },
                    { 14, "AddItem", "Items", true, "Add Item", "e3442c63ae8a4633b4c47f64fd32ecd8", 6 },
                    { 15, "Create", "Order", true, "Create Order", "3676993075d742ad98c0ef9322fb252d", 7 },
                    { 16, "Index", "Order", true, "Order List", "3d1db1c339f04b51a3b27b387758c514", 8 },
                    { 17, "General", "Settings", true, "General Settings", "8158a3825958496cb90d8dd0880a6e5d", 17 },
                    { 18, "Security", "Settings", true, "Security Settings", "71e72fefa5c54f718dbe7ec72c1ecaee", 18 },
                    { 19, "Index", "Payroll", true, "Payroll Dashboard", "e1d929fca7a34277a09084a48b3763db", 9 },
                    { 20, "EmployeeSalaries", "Payroll", true, "Employee Salaries", "939e1818a16c4ee48885ef4218dbe5d4", 10 },
                    { 21, "ProcessSalaries", "Payroll", true, "Salary Processing", "f31353a0477c46a89d127c44c3d097a9", 9 },
                    { 22, "Reports", "Payroll", true, "Payroll Reports", "d2d5f65744c647ff8aa2725858deba66", 15 },
                    { 23, "Bonuses", "Payroll", true, "Bonuses Management", "25d5eaa7abfc4716b56f3803a1c68cad", 9 },
                    { 24, "Deductions", "Payroll", true, "Deductions", "6d973f10afa14514a36489b3b5c21c43", 9 },
                    { 25, "Tax", "Payroll", true, "Tax Calculations", "f84ba095826b40cdb1c3f9168f73c7ee", 9 },
                    { 26, "GeneratePayslip", "Payroll", true, "Payslip Generation", "f420a9a42a224c3aa8c5a2d49469e14d", 9 },
                    { 27, "Overtime", "Payroll", true, "Overtime Payments", "72fc5d63dc89414bb84e342965255256", 9 },
                    { 28, "History", "Payroll", true, "Payroll History", "7dc1e37ccdde4136a8ee2d0e0b7e746b", 9 },
                    { 29, "Index", "Accountant", true, "Financial Orders", "c040d31f3c254a4783ea942c2e6655ee", 15 },
                    { 30, "PreOnboarding", "Onboarding", true, "Pre-Onboarding", "a6d7187180234a60aa98d117f121c09b", 10 },
                    { 31, "ITSetup", "Onboarding", true, "IT Setup", "54441e500e6140439b70df7488920865", 10 },
                    { 32, "Training", "Onboarding", true, "Training & Orientation", "e99bed12101947c6b80f61775d835f96", 10 },
                    { 33, "Clearance", "Offboarding", true, "Exit Clearance", "e05fac212d944f2bb2c5406379f766d7", 10 },
                    { 34, "RevokeAccess", "Offboarding", true, "Access Revocation", "0071bb42a49e497c95387f1519274add", 10 },
                    { 35, "FinalPayroll", "Offboarding", true, "Final Payroll & Documents", "7d95a1abebb042fb85b069dd748a5565", 10 },
                    { 36, "Records", "HR", true, "Employee Records", "8a159a42af5b4062a58c73f00b6927a1", 10 },
                    { 37, "Leave", "HR", true, "Leave Management", "6a7240c899804d1bb5c3a114001e034c", 10 },
                    { 38, "Payroll", "HR", true, "Payroll Processing", "bd738642b86942cf828019b078489188", 9 },
                    { 39, "Reviews", "Performance", true, "Performance Reviews", "bb8124d8158b433da9a45522f14e396e", 10 },
                    { 40, "KPIs", "Performance", true, "KPI Tracking", "bf66f11676e74be7b87617968981f62a", 10 },
                    { 41, "Feedback", "Performance", true, "Feedback & Recognition", "9b9f93718f8f4fc8be6822c0e200fcc3", 10 },
                    { 42, "Tickets", "ITService", true, "Ticket Management", "59d6a2aaaa0f46108cf05f3787e3c45e", 11 },
                    { 43, "Monitoring", "ITService", true, "System Monitoring", "6776e04566f64c7c8ff033750b5b73fd", 12 },
                    { 44, "Inventory", "ITService", true, "Hardware Inventory", "e400a96037f34cd7bc16b81583948d83", 5 },
                    { 45, "Tickets", "Support", true, "Support Tickets", "ec5cb319c3dc4d838f80f701c7bc1ac8", 13 },
                    { 46, "Chat", "Support", true, "Live Chat", "a0d527f04ae04faeb70b5d5f877df348", 14 },
                    { 47, "FAQ", "Support", true, "FAQ & Help Center", "58c797776e1d4d8cbcc74944fb183658", 13 },
                    { 48, "Finance", "Reports", true, "Financial Reports", "b5b447b34920474981b9fd67eacc1e4d", 15 },
                    { 49, "Employees", "Reports", true, "Employee Insights", "3f7d9324c2674792897ea2641f570ab7", 15 },
                    { 50, "Sales", "Reports", true, "Sales & Revenue", "f927e943d8a84cc984ab7a1b77f85637", 15 },
                    { 51, "Index", "Support", true, "Support Dashboard", "92b7afcb17d24200a247042a8bffc26d", 13 },
                    { 52, "OrderDashboard", "Report", true, "Orders Dashboard", "acb944206d524cfeb7ac5d85894315fd", 8 },
                    { 53, "Settings", "ExportImport", true, "Data Management", "f654329f34ad42c498044e8d126dd0d9", 17 },
                    { 54, "Export", "ExportImport", true, "Data Export", "780d88ad205e481dae5b2cfdbc2bc7d1", 17 },
                    { 55, "Import", "ExportImport", true, "Data Import", "826071417da349c2a71152289a499481", 17 },
                    { 56, "Index", "Report", true, "Order Dashboard", "a1475f34c9784e33a9f80d68cfabb9f5", 16 },
                    { 57, "WarehouseReport", "warehouse", true, "Stores", "4ec304bfa0954ca38b9f9ac49d24646f", 15 },
                    { 58, "Index", "Country", true, "Countries", "fe4204547ef24c4197891fa641eb4438", 17 },
                    { 59, "countries", "items", true, "Countries and Their Items", "73b922a8a3174f23a6ff72eafa4dcf0e", 15 },
                    { 60, "Index", "Onboarding", true, "Onboarding List", "fa5de952f8b1469d821d0ace63486588", 19 },
                    { 61, "Create", "Onboarding", true, "Create Onboarding", "b274eff82b514ef7a4f936ebd49cf2e7", 19 },
                    { 62, "Index", "Offboarding", true, "Offboarding List", "f5cd3081e7ed4b8a989c7e557c9db74b", 20 },
                    { 63, "Create", "Offboarding", true, "Create Offboarding", "55488e60c7ce47c790de4c51e81f31dd", 20 },
                    { 64, "Index", "Performance", true, "Performance Reviews", "fc5b6f75cab44168bee3759db29112be", 21 },
                    { 65, "Create", "Performance", true, "Add Performance Review", "8271da3cd2b340418790168cbdb74c32", 21 },
                    { 66, "Index", "Supervisor", true, "Supervisors List", "dfdfb0bd8670424691824714c8544a46", 22 },
                    { 67, "Create", "Supervisor", true, "Add Supervisor", "4f1b518b2f8b430db85a9f4f6678e61e", 22 },
                    { 68, "Index", "Position", true, "Employee Positions", "6a8dae840f7e4673a29809d338d93215", 23 },
                    { 69, "Create", "Position", true, "Create Employee Position", "6a7afb57d6bf4195aba7ad39d3cea8f6", 23 },
                    { 70, "Index", "Department", true, "Departments List", "ecb76042870641e49b67aa319403fcec", 24 },
                    { 71, "Create", "Department", true, "Add Department", "2fb65f3b69824b9294806cd7d5af038b", 24 },
                    { 72, "Index", "LeaveRequest", true, "Leave Requests", "23a22c9116f144989005c20b7a7b9d07", 25 },
                    { 73, "Create", "LeaveRequest", true, "Submit Leave Request", "f8e77e9404fd4f7bb98408450fa1d1ec", 25 },
                    { 74, "Index", "Employee", true, "Employee List", "1af50f0d53b34320be7b3c712b188a7f", 26 },
                    { 75, "Create", "Employee", true, "Add Employee", "2ea8c23492a74cdf9b37005e138c7987", 26 },
                    { 76, "Index", "Notification", true, "Notification List", "3caca9bb665b487a86f41637b8227e18", 27 },
                    { 77, "Add", "Notification", true, "Create Notification", "a0cf5cce1e5647afa0305f4f69bf7f38", 27 },
                    { 78, "Index", "Notification", true, "Notification Settings", "d2a6819e9fc24e46baf2a82a82aac857", 28 },
                    { 79, "Edit", "Notification", true, "Edit Settings", "b54ae48e84c34dab85af1db39e534b04", 28 },
                    { 80, "Details", "Order", false, "Order Details", "ccf446c212f9487f913b4c75c01057ab", 7 },
                    { 81, "Optimization", "Order", false, "Order Optimization", "3d2f8ef18db642dd9e22c4634f4f7fab", 7 },
                    { 82, "GlassLabel", "Order", false, "Order GlassLabel", "0cc2b2c7dfa54e78afbb84f4b3f73fce", 7 },
                    { 83, "Delete", "Order", false, "Order Delete", "1fdd78b5e40d47789cf5ff5da290a308", 7 },
                    { 84, "WarehouseDashboard", "Report", true, "Store Dashboard", "affe8d6317174f41a23949ee05de4b03", 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MainWarehouseId",
                table: "Categories",
                column: "MainWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_NameAr",
                table: "Categories",
                column: "NameAr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_NameEn",
                table: "Categories",
                column: "NameEn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Code",
                schema: "HR",
                table: "Departments",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                schema: "HR",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                schema: "HR",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeCode",
                schema: "HR",
                table: "Employees",
                column: "EmployeeCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                schema: "HR",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_FAQS_UserId",
                table: "FAQS",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialRecords_Date",
                table: "FinancialRecords",
                column: "Date");

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryId",
                table: "Items",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_ManufacturingCountryId",
                table: "Items",
                column: "ManufacturingCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ITSetupModule_OnboardingProcessId",
                table: "ITSetupModule",
                column: "OnboardingProcessId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeId",
                schema: "HR",
                table: "LeaveRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MainWarehouses_NameAr",
                table: "MainWarehouses",
                column: "NameAr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MainWarehouses_NameEn",
                table: "MainWarehouses",
                column: "NameEn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CreatedAt",
                table: "Notifications",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_IsRead",
                table: "Notifications",
                column: "IsRead");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Offboardings_EmployeeId",
                schema: "HR",
                table: "Offboardings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Offboardings_SupervisorId",
                schema: "HR",
                table: "Offboardings",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Onboardings_EmployeeId",
                schema: "HR",
                table: "Onboardings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Onboardings_SupervisorId",
                schema: "HR",
                table: "Onboardings",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrientationModule_OnboardingProcessId",
                table: "OrientationModule",
                column: "OnboardingProcessId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_SubmoduleId",
                table: "Pages",
                column: "SubmoduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Partners_Name",
                table: "Partners",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Performances_EmployeeId",
                schema: "HR",
                table: "Performances",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_Code",
                schema: "HR",
                table: "Positions",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DepartmentId",
                schema: "HR",
                table: "Positions",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PreboardingModule_OnboardingProcessId",
                table: "PreboardingModule",
                column: "OnboardingProcessId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_ModuleId",
                table: "RolePermissions",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PageId",
                table: "RolePermissions",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_RoleId",
                table: "RolePermissions",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_SubModuleId",
                table: "RolePermissions",
                column: "SubModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubModules_ModuleId",
                table: "SubModules",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_SubWarehouses_MainWarehouseId",
                table: "SubWarehouses",
                column: "MainWarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_SubWarehouses_NameAr",
                table: "SubWarehouses",
                column: "NameAr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubWarehouses_NameEn",
                table: "SubWarehouses",
                column: "NameEn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupportResponse_RespondedByUserId",
                table: "SupportResponse",
                column: "RespondedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportResponse_SupportTicketId",
                table: "SupportResponse",
                column: "SupportTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportTicket_AssignedToUserId",
                table: "SupportTicket",
                column: "AssignedToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingModule_OnboardingProcessId",
                table: "TrainingModule",
                column: "OnboardingProcessId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContactUs");

            migrationBuilder.DropTable(
                name: "ContractSettings");

            migrationBuilder.DropTable(
                name: "Documentation");

            migrationBuilder.DropTable(
                name: "ExportImportSettings");

            migrationBuilder.DropTable(
                name: "FAQS");

            migrationBuilder.DropTable(
                name: "FinancialRecords");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ITSetupModule");

            migrationBuilder.DropTable(
                name: "LeaveRequests",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "NotificationSettings");

            migrationBuilder.DropTable(
                name: "Offboardings",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Onboardings",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "OrientationModule");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Performances",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "PreboardingModule");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "RolePermissions");

            migrationBuilder.DropTable(
                name: "SubWarehouses");

            migrationBuilder.DropTable(
                name: "SupportResponse");

            migrationBuilder.DropTable(
                name: "TeamMember");

            migrationBuilder.DropTable(
                name: "TrainingModule");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Supervisors",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "PermissionTyepe");

            migrationBuilder.DropTable(
                name: "SupportTicket");

            migrationBuilder.DropTable(
                name: "OnboardingProcess");

            migrationBuilder.DropTable(
                name: "MainWarehouses");

            migrationBuilder.DropTable(
                name: "Positions",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "SubModules");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Modules");
        }
    }
}
