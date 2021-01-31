using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace NetAng.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    DataEventRecordsRole = table.Column<string>(type: "text", nullable: true),
                    SecuredFilesRole = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Cost = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Expiration = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Data = table.Column<string>(type: "character varying(50000)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "EmailTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FieldOfActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldOfActivities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    FileData = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeasurementUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementUnits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessangerUrlTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessangerUrlTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Text = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Expiration = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Data = table.Column<string>(type: "character varying(50000)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Phases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrlTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrlTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
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
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                name: "Money",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    CurrencyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Money_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MoneyFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ValueId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoneyFields_Money_ValueId",
                        column: x => x.ValueId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: true),
                    DetailsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NameOfTheBank = table.Column<string>(type: "text", nullable: true),
                    MFO = table.Column<int>(type: "integer", nullable: false),
                    CurrentAccount = table.Column<int>(type: "integer", nullable: false),
                    IBAN = table.Column<string>(type: "text", nullable: true),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    DetailsId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BooleanFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<bool>(type: "boolean", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooleanFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ImageLogoId = table.Column<int>(type: "integer", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    FieldOfActivities = table.Column<List<string>>(type: "text[]", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Permissions_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Phones_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Emails_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Sites_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_MessangerUrls_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Contacts_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Addresses_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Employees_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Details_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_BankDetails_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Description_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_StringFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_NumericFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_DateTimeFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_UrlsFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_FileFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Permissions_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_BooleanFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    OperationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name_FirstName = table.Column<string>(type: "text", nullable: true),
                    Name_LastName = table.Column<string>(type: "text", nullable: true),
                    Name_SurName = table.Column<string>(type: "text", nullable: true),
                    PhotoId = table.Column<int>(type: "integer", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: true),
                    FieldOfActivities = table.Column<List<string>>(type: "text[]", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    Source = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Permissions_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Photo_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_DateOfBirth_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Position_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Phones_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Emails_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Sites_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_MessangerUrls_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Companies_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Addresses_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Details_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_ContactType_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_ContactSource_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Description_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    OperationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyContact",
                columns: table => new
                {
                    ContactsId = table.Column<int>(type: "integer", nullable: false),
                    RelatedCompaniesId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyContact", x => new { x.ContactsId, x.RelatedCompaniesId });
                    table.ForeignKey(
                        name: "FK_CompanyContact_Companies_RelatedCompaniesId",
                        column: x => x.RelatedCompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyContact_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urls_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Urls_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DateTimeFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateTimeFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DateTimeFields_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: true),
                    AbbreviatedNameOfTheOrganization = table.Column<string>(type: "text", nullable: true),
                    USREOU = table.Column<int>(type: "integer", nullable: false),
                    GeneralDirector = table.Column<string>(type: "text", nullable: true),
                    ChiefAccountant = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    RNTRC = table.Column<string>(type: "text", nullable: true),
                    CertificateNumber = table.Column<int>(type: "integer", nullable: false),
                    IPN = table.Column<int>(type: "integer", nullable: false),
                    VATPayer = table.Column<bool>(type: "boolean", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Details_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Emails_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Position = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<string>(type: "text", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employes_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employes_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FileFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileId = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileFields_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileFields_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ImageFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FileId = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageFields_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateOfChange = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StartActivityDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StopActivityDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Goals = table.Column<string>(type: "text", nullable: true),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsSuccessfully = table.Column<bool>(type: "boolean", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    ProjectId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MessangerUrls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ValueId = table.Column<int>(type: "integer", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessangerUrls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MessangerUrls_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MessangerUrls_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MessangerUrls_Urls_ValueId",
                        column: x => x.ValueId,
                        principalTable: "Urls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NumericField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<decimal>(type: "numeric", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumericField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NumericField_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AmountId = table.Column<int>(type: "integer", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateOfChange = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Phase = table.Column<string>(type: "text", nullable: true),
                    OperationSource = table.Column<string>(type: "text", nullable: true),
                    TypeOfOperation = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    AvailableToEveryone = table.Column<bool>(type: "boolean", nullable: false),
                    IsAccount = table.Column<bool>(type: "boolean", nullable: false),
                    Permissions_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Amount_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_CreateDate_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_DateOfChange_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_EndDate_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Phase_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_TypeOfOperation_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Description_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_AvailableToEveryone_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Contacts_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Contractors_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Permissions_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operations_Money_AmountId",
                        column: x => x.AmountId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Value = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    ContactId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phones_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Phones_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PriceId = table.Column<int>(type: "integer", nullable: true),
                    Quantity = table.Column<decimal>(type: "numeric", nullable: false),
                    MeasurementUnitId = table.Column<int>(type: "integer", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateOfChange = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StartActivityDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StopActivityDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SortIndex = table.Column<int>(type: "integer", nullable: false, defaultValue: 1),
                    Permissions_IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Name_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Description_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Images_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Price_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Quantity_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_MeasurementUnit_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_CreateDate_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_DateOfChange_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_StartActivityDate_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_StopActivityDate_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_SortIndex_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_StringFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_NumericFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_DateTimeFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_UrlsFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_FileFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Permissions_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_MeasurementUnits_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "MeasurementUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Money_PriceId",
                        column: x => x.PriceId,
                        principalTable: "Money",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ImageData = table.Column<string>(type: "text", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CurrencyId = table.Column<int>(type: "integer", nullable: true),
                    ImageLogoId = table.Column<int>(type: "integer", nullable: true),
                    FieldOfActivities = table.Column<List<string>>(type: "text[]", nullable: true),
                    SiteId = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Permissions_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Currency_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Currency_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Products_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Products_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Projects_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Projects_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Jobs_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Jobs_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Companies_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Companies_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_ImageLogo_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_ImageLogo_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_FieldOfActivities_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_FieldOfActivities_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Phones_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Phones_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Emails_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Emails_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Sites_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Sites_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_MessangerUrls_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_MessangerUrls_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Contacts_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Contacts_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Addresses_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Addresses_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Employees_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Employees_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Details_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Details_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_BankDetails_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_BankDetails_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Description_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Descriptions_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_StringFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_StringFields_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_NumericFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_NumericFields_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_DateTimeFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_DateTimeFields_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_UrlsFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_UrlsFields_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_FileFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_FileFields_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_ImageFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_ImageFields_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_BooleanFields_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_BooleanFields_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Operations_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Operations_IsVisible = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Permissions_IsPublic = table.Column<bool>(type: "boolean", nullable: true),
                    Permissions_Permissions_IsVisible = table.Column<bool>(type: "boolean", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Images_ImageLogoId",
                        column: x => x.ImageLogoId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Accounts_Urls_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Urls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateOfChange = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StartActivityDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StopActivityDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    Goals = table.Column<string>(type: "text", nullable: true),
                    IsCompleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsSuccessfully = table.Column<bool>(type: "boolean", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StringFields",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    CompanyId = table.Column<int>(type: "integer", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StringFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StringFields_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StringFields_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StringFields_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ApplicationUserId",
                table: "Accounts",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CurrencyId",
                table: "Accounts",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ImageLogoId",
                table: "Accounts",
                column: "ImageLogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_SiteId",
                table: "Accounts",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_AccountId",
                table: "Addresses",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CompanyId",
                table: "Addresses",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ContactId",
                table: "Addresses",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DetailsId",
                table: "Addresses",
                column: "DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankDetails_AccountId",
                table: "BankDetails",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BankDetails_CompanyId",
                table: "BankDetails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BankDetails_DetailsId",
                table: "BankDetails",
                column: "DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanFields_AccountId",
                table: "BooleanFields",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanFields_CompanyId",
                table: "BooleanFields",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_AccountId",
                table: "Companies",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_ImageLogoId",
                table: "Companies",
                column: "ImageLogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_OperationId",
                table: "Companies",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyContact_RelatedCompaniesId",
                table: "CompanyContact",
                column: "RelatedCompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_AccountId",
                table: "Contacts",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_OperationId",
                table: "Contacts",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PhotoId",
                table: "Contacts",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_DateTimeFields_AccountId",
                table: "DateTimeFields",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_DateTimeFields_CompanyId",
                table: "DateTimeFields",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DateTimeFields_ProductId",
                table: "DateTimeFields",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_AccountId",
                table: "Details",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CompanyId",
                table: "Details",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_ContactId",
                table: "Details",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_AccountId",
                table: "Emails",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_CompanyId",
                table: "Emails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_ContactId",
                table: "Emails",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Employes_AccountId",
                table: "Employes",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Employes_CompanyId",
                table: "Employes",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employes_ContactId",
                table: "Employes",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_FileFields_AccountId",
                table: "FileFields",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_FileFields_CompanyId",
                table: "FileFields",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FileFields_FileId",
                table: "FileFields",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_FileFields_ProductId",
                table: "FileFields",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageFields_AccountId",
                table: "ImageFields",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageFields_CompanyId",
                table: "ImageFields",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageFields_FileId",
                table: "ImageFields",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_AccountId",
                table: "Jobs",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ProjectId",
                table: "Jobs",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_MessangerUrls_AccountId",
                table: "MessangerUrls",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_MessangerUrls_CompanyId",
                table: "MessangerUrls",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MessangerUrls_ContactId",
                table: "MessangerUrls",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_MessangerUrls_ValueId",
                table: "MessangerUrls",
                column: "ValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Money_CurrencyId",
                table: "Money",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyFields_ValueId",
                table: "MoneyFields",
                column: "ValueId");

            migrationBuilder.CreateIndex(
                name: "IX_NumericField_AccountId",
                table: "NumericField",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_NumericField_CompanyId",
                table: "NumericField",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_NumericField_ProductId",
                table: "NumericField",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_AccountId",
                table: "Operations",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_AmountId",
                table: "Operations",
                column: "AmountId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Phones_AccountId",
                table: "Phones",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_CompanyId",
                table: "Phones",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_ContactId",
                table: "Phones",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AccountId",
                table: "Products",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MeasurementUnitId",
                table: "Products",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PriceId",
                table: "Products",
                column: "PriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AccountId",
                table: "Projects",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_StringFields_AccountId",
                table: "StringFields",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_StringFields_CompanyId",
                table: "StringFields",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StringFields_ProductId",
                table: "StringFields",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Urls_CompanyId",
                table: "Urls",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Urls_ContactId",
                table: "Urls",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Accounts_AccountId",
                table: "Addresses",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Companies_CompanyId",
                table: "Addresses",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Contacts_ContactId",
                table: "Addresses",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Details_DetailsId",
                table: "Addresses",
                column: "DetailsId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BankDetails_Accounts_AccountId",
                table: "BankDetails",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BankDetails_Companies_CompanyId",
                table: "BankDetails",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BankDetails_Details_DetailsId",
                table: "BankDetails",
                column: "DetailsId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooleanFields_Accounts_AccountId",
                table: "BooleanFields",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BooleanFields_Companies_CompanyId",
                table: "BooleanFields",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Accounts_AccountId",
                table: "Companies",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Images_ImageLogoId",
                table: "Companies",
                column: "ImageLogoId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Operations_OperationId",
                table: "Companies",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Accounts_AccountId",
                table: "Contacts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Images_PhotoId",
                table: "Contacts",
                column: "PhotoId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Operations_OperationId",
                table: "Contacts",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DateTimeFields_Accounts_AccountId",
                table: "DateTimeFields",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DateTimeFields_Products_ProductId",
                table: "DateTimeFields",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Details_Accounts_AccountId",
                table: "Details",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Accounts_AccountId",
                table: "Emails",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employes_Accounts_AccountId",
                table: "Employes",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FileFields_Accounts_AccountId",
                table: "FileFields",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FileFields_Products_ProductId",
                table: "FileFields",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFields_Accounts_AccountId",
                table: "ImageFields",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageFields_Images_FileId",
                table: "ImageFields",
                column: "FileId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Accounts_AccountId",
                table: "Jobs",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Projects_ProjectId",
                table: "Jobs",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MessangerUrls_Accounts_AccountId",
                table: "MessangerUrls",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NumericField_Accounts_AccountId",
                table: "NumericField",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NumericField_Products_ProductId",
                table: "NumericField",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Accounts_AccountId",
                table: "Operations",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Accounts_AccountId",
                table: "Phones",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Accounts_AccountId",
                table: "Products",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_AspNetUsers_ApplicationUserId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Currencies_CurrencyId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Money_Currencies_CurrencyId",
                table: "Money");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Images_ImageLogoId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Images_ImageLogoId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Images_PhotoId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Urls_SiteId",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AddressTypes");

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
                name: "BankDetails");

            migrationBuilder.DropTable(
                name: "BooleanFields");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CompanyContact");

            migrationBuilder.DropTable(
                name: "CompanyTypes");

            migrationBuilder.DropTable(
                name: "ContactSources");

            migrationBuilder.DropTable(
                name: "ContactTypes");

            migrationBuilder.DropTable(
                name: "DateTimeFields");

            migrationBuilder.DropTable(
                name: "DetailsTypes");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "EmailTypes");

            migrationBuilder.DropTable(
                name: "Employes");

            migrationBuilder.DropTable(
                name: "FieldOfActivities");

            migrationBuilder.DropTable(
                name: "FileFields");

            migrationBuilder.DropTable(
                name: "ImageFields");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "MessangerUrls");

            migrationBuilder.DropTable(
                name: "MessangerUrlTypes");

            migrationBuilder.DropTable(
                name: "MoneyFields");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropTable(
                name: "NumericField");

            migrationBuilder.DropTable(
                name: "OperationSources");

            migrationBuilder.DropTable(
                name: "OperationTypes");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Phases");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "PhoneTypes");

            migrationBuilder.DropTable(
                name: "StringFields");

            migrationBuilder.DropTable(
                name: "UrlTypes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "MeasurementUnits");

            migrationBuilder.DropTable(
                name: "Urls");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Money");
        }
    }
}
