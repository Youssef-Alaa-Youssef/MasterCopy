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
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
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
                    { 10, "bi-people", true, "HR", "" }
                });

            migrationBuilder.InsertData(
                table: "PermissionTyepe",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Create" },
                    { 2, "Read" },
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
                    { 26, "", "", "bi-people", 10, "Employees", "" }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Action", "Controller", "IsActive", "Name", "SecureUrlKey", "SubmoduleId" },
                values: new object[,]
                {
                    { 1, "Index", "PermissionManagement", true, "Permission List", "a71074db38724b1abaa82120dac9ca1b", 2 },
                    { 2, "AssignPermissions", "PermissionManagement", true, "Assign Permission", "7abc95df855240d9823370daad4014e8", 2 },
                    { 3, "Index", "Module", true, "Module List", "53f1fec99b0f42e18e60a846ad8a82f3", 3 },
                    { 4, "Create", "Module", true, "Add Module", "ed960098a8cf47bba995962096110aa1", 3 },
                    { 5, "Index", "SubModule", true, "Submodule List", "f1d6c7c55c53487ca0f81ef337c3c1a3", 4 },
                    { 6, "Create", "SubModule", true, "Add Submodule", "d0b9ebb3e1314b7295e70661eecff936", 4 },
                    { 7, "Index", "Auth", true, "User List", "f8a9c4b1d3d94a0e8d99880fe0d60c3a", 1 },
                    { 8, "Add", "Auth", true, "Add User", "05fbcb0760ec41858fdf7492f456c02f", 1 },
                    { 9, "Index", "Role", true, "Role List", "350ee71bc85846d7b89f654ae3f3907b", 3 },
                    { 10, "Create", "Role", true, "Add Role", "d0c7880383dc4f79920e8d990d4876fd", 3 },
                    { 11, "Index", "Warehouse", true, "Warehouse List", "d7a1ac963f38448f85f68d451ad6c4cd", 5 },
                    { 12, "Create", "Warehouse", true, "Add Warehouse", "11a41f0e7df34ff0abd55f18f1fca66f", 5 },
                    { 13, "List", "Item", true, "Item List", "9e88e465dd0a411bbd7c3fdf933ad2e3", 6 },
                    { 14, "AddItem", "Item", true, "Add Item", "cfa5ded0373a458aafb237a04c8f99b2", 6 },
                    { 15, "Create", "Order", true, "Create Order", "f4405b454cfd4003a39d5b5c6eae0150", 7 },
                    { 16, "Index", "Order", true, "Order List", "35f6497bf9b44823a0b68fa1d8bfced9", 8 },
                    { 17, "General", "Settings", true, "General Settings", "359542c0d4ae437aaf60b2a550e578f5", 17 },
                    { 18, "Security", "Settings", true, "Security Settings", "d8b157d0ed2146e5828af25049a8d104", 18 },
                    { 19, "Index", "Payroll", true, "Payroll Dashboard", "4229a99007294271a0cb6a0542b62559", 9 },
                    { 20, "EmployeeSalaries", "Payroll", true, "Employee Salaries", "3139bf6a634745d4ae0ff365e097ee0c", 10 },
                    { 21, "ProcessSalaries", "Payroll", true, "Salary Processing", "dc7e8c6198524d13bb76a1fa4664e8ca", 9 },
                    { 22, "Reports", "Payroll", true, "Payroll Reports", "893563a22c104a9797838ca7581f9af9", 15 },
                    { 23, "Bonuses", "Payroll", true, "Bonuses Management", "6961c9e1846d4f0f9b4a762a8ed7e934", 9 },
                    { 24, "Deductions", "Payroll", true, "Deductions", "9e6ba9373e694fd3aee232a0f4bd87da", 9 },
                    { 25, "Tax", "Payroll", true, "Tax Calculations", "c1809a0433e14900a43509d8bb7f6edd", 9 },
                    { 26, "GeneratePayslip", "Payroll", true, "Payslip Generation", "77ac24f9ce0f4fb9abefe6e4702f9eff", 9 },
                    { 27, "Overtime", "Payroll", true, "Overtime Payments", "0495ce347cd84cd3afb0c00940197144", 9 },
                    { 28, "History", "Payroll", true, "Payroll History", "793d5b11ee3c439e8cea81215429e981", 9 },
                    { 29, "Index", "Accountant", true, "Financial Orders", "1096ded3d18b4280b407acf382944b97", 15 },
                    { 30, "PreOnboarding", "Onboarding", true, "Pre-Onboarding", "3d45ce4bf117422dbfb48528070f7a9c", 10 },
                    { 31, "ITSetup", "Onboarding", true, "IT Setup", "93a4a72434bb49e3abb2aed0cde34b95", 10 },
                    { 32, "Training", "Onboarding", true, "Training & Orientation", "c8f0b7b29ec14c8d9553001e01128cd5", 10 },
                    { 33, "Clearance", "Offboarding", true, "Exit Clearance", "2e3cc6f61c5d4761a35817983139af08", 10 },
                    { 34, "RevokeAccess", "Offboarding", true, "Access Revocation", "480e64c71bbe4f4795b30e2c3fda29af", 10 },
                    { 35, "FinalPayroll", "Offboarding", true, "Final Payroll & Documents", "40a258078d13410b9c5a5b1a9a925fcd", 10 },
                    { 36, "Records", "HR", true, "Employee Records", "b14cfef6816748fbac9995e80d30d2d9", 10 },
                    { 37, "Leave", "HR", true, "Leave Management", "848a25d097cc4530a3b732bdb746c04d", 10 },
                    { 38, "Payroll", "HR", true, "Payroll Processing", "c09d640359e54fb6a97f4cf6687286fa", 9 },
                    { 39, "Reviews", "Performance", true, "Performance Reviews", "1a93c664f0df4340bad9cb3af96000a8", 10 },
                    { 40, "KPIs", "Performance", true, "KPI Tracking", "063d0148395f4e6fb9de9a2f31f17a91", 10 },
                    { 41, "Feedback", "Performance", true, "Feedback & Recognition", "4a134956175944f38da63de2f2851480", 10 },
                    { 42, "Tickets", "ITService", true, "Ticket Management", "23ec900d7de4433a8d94b46d4fc1735a", 11 },
                    { 43, "Monitoring", "ITService", true, "System Monitoring", "9d0c9a2f45764faa8915e191311d05fe", 12 },
                    { 44, "Inventory", "ITService", true, "Hardware Inventory", "c3119fc32f5244b5ab96717399a79e9f", 5 },
                    { 45, "Tickets", "Support", true, "Support Tickets", "205100ad1f4541f9bd617e4a3d898a2a", 13 },
                    { 46, "Chat", "Support", true, "Live Chat", "4c79dd55d58f4884b1d3787badbf5d01", 14 },
                    { 47, "FAQ", "Support", true, "FAQ & Help Center", "39b85f96a9ec40eca17e9cf0d893c276", 13 },
                    { 48, "Finance", "Reports", true, "Financial Reports", "8386656a3f8244be9d7e60feb3c5d337", 15 },
                    { 49, "Employees", "Reports", true, "Employee Insights", "cf87ecb94a594b14b2067130116aec15", 15 },
                    { 50, "Sales", "Reports", true, "Sales & Revenue", "c970994cde63415e8e8f30333c153611", 15 },
                    { 51, "Index", "Support", true, "Support Dashboard", "390d043aab5347d78cb21cf822d53a71", 13 },
                    { 52, "Index", "OrderReport", true, "Orders Dashboard", "b598f4efff914b03a2c6c0bc21dbb3b0", 8 },
                    { 53, "Settings", "ExportImport", true, "Data Management", "b2d4a67eaf06460d8c3659a30f1e9878", 17 },
                    { 54, "Export", "ExportImport", true, "Data Export", "a8182c01664f45c3a9bb89273f68d755", 17 },
                    { 55, "Import", "ExportImport", true, "Data Import", "dddda46145024e8bb8a19add9015736a", 17 },
                    { 56, "Index", "OrderReport", true, "Order Dashboard", "4661b43e1ee740cebdea8088bfdbbe1e", 16 },
                    { 57, "WarehouseReport", "warehouse", true, "Stores", "0799663cc0e04ebcbe916411d52cbcca", 15 },
                    { 58, "Index", "Country", true, "Countries", "cf1d53cb263341c89b1df2a48d022155", 17 },
                    { 59, "countries", "items", true, "Countries and Their Items", "b576f9b616684b2cafe1f5108dd48582", 15 },
                    { 60, "Index", "Onboarding", true, "Onboarding List", "b038ff0d17da414988f46aeeb0067e68", 19 },
                    { 61, "Create", "Onboarding", true, "Create Onboarding", "8b030d0a3d5a48019bf0e90299a10e20", 19 },
                    { 62, "Index", "Offboarding", true, "Offboarding List", "a5c44af338e24233a91245653e5a18e1", 20 },
                    { 63, "Create", "Offboarding", true, "Create Offboarding", "1e868cb3b5b94af895e42be9dad7b09a", 20 },
                    { 64, "Index", "Performance", true, "Performance Reviews", "08f4f82802f24b3380130c63e5ee547f", 21 },
                    { 65, "Create", "Performance", true, "Add Performance Review", "183391e0915a4a97ad365b87237343d4", 21 },
                    { 66, "Index", "Supervisor", true, "Supervisors List", "ecaceeec9f574e3383ee43b89f86783f", 22 },
                    { 67, "Create", "Supervisor", true, "Add Supervisor", "0dbeeac9ad234aa799e82fd98adb2b9d", 22 },
                    { 68, "Index", "Position", true, "Employee Positions", "e56eb15af37341d2aeaaee3d10d6e9cd", 23 },
                    { 69, "Create", "Position", true, "Create Employee Position", "49d0d74925c94a30b95eb86c9528252d", 23 },
                    { 70, "Index", "Department", true, "Departments List", "9039422c05e24e3c8fe8cee92023e98f", 24 },
                    { 71, "Create", "Department", true, "Add Department", "6a69a431720044ab974caa38f531aa86", 24 },
                    { 72, "Index", "LeaveRequest", true, "Leave Requests", "252e8201e7694da199e32260abe07539", 25 },
                    { 73, "Create", "LeaveRequest", true, "Submit Leave Request", "7789e378a246489786ee366acb23599f", 25 },
                    { 74, "Index", "Employee", true, "Employee List", "b3e4cf4c241a4307b293e33be62c853d", 26 },
                    { 75, "Create", "Employee", true, "Add Employee", "c03243c4eefe416680423e8354f64cf7", 26 }
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
