using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addAuditTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "audit");

            migrationBuilder.CreateTable(
                name: "AuditApplicationUserRequest",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditApplicationUserRequest", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditAttachment",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditAttachment", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditDefinedApplication",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationOwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditDefinedApplication", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditDefinedApplicationRole",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditDefinedApplicationRole", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditDefinedRequest",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    RequestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RouteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewersNumber = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditDefinedRequest", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditDefinedRequestReviewer",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DefinedRequestId = table.Column<long>(type: "bigint", nullable: false),
                    AssignedReviewerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DelegatedReviewerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageNumber = table.Column<int>(type: "int", nullable: false),
                    ReviewerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DelegatedUntil = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditDefinedRequestReviewer", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditDefinedRequestRole",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefinedRequestId = table.Column<long>(type: "bigint", nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditDefinedRequestRole", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditDepartment",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentIcon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditDepartment", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditDomainAccountRequest",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditDomainAccountRequest", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditRequest",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CurrentStage = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Justification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefinedRequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditRequest", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditRequestApplicationRole",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditRequestApplicationRole", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditRequestReviewer",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    AssignedReviewerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageNumber = table.Column<int>(type: "int", nullable: false),
                    ReviewerType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewerNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditRequestReviewer", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditRole",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditRole", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditSection",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: true),
                    HeadId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditSection", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditTravelDeskRequest",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryNationality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostAllocation = table.Column<float>(type: "real", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckIn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckOut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MissionAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlightDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DestinationCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedTravelTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditTravelDeskRequest", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditUser",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: true),
                    SectionId = table.Column<long>(type: "bigint", nullable: true),
                    ManagerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmployee = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AuditUser", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditVehicleRequest",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LuggageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditVehicleRequest", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "AuditVoucherRequest",
                schema: "audit",
                columns: table => new
                {
                    Key = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherAmount = table.Column<float>(type: "real", nullable: false),
                    VoucherCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditVoucherRequest", x => x.Key);
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08058637-5c78-4ee0-bf46-5289ce5a1d2a", "2115898c-b373-4dd3-942e-7afe6efbe475" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20fdd9e6-15fc-49a7-8b19-2448ed21bbf9", "227bba2b-b407-41be-9524-2b91048537af" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e4b7600-9e8e-4995-8294-d56d4ab91972", "9303e964-b5b0-4923-bf3b-1167d1a12567" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a343e06b-466d-4a56-b20b-0939f6bde527", "9a1ceef9-bb1f-41ca-a6eb-45bc95d8d757" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e69d77a-bece-4fd5-8353-a3ea90ce46c6", "0d694f20-68d4-474a-85f0-cad6e322aa11" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e837158-4181-4d63-b995-c2d0cfb14797", "2f383b06-7418-4b37-a4a9-09976907bdd9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a68c06e-2632-4056-8352-8c5f34dc88aa", "3022d57b-ee8f-4c90-b006-ab6f100ebdd0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c662483-b2b4-4303-93dc-d1ab8de84ff9", "f86c3b61-a8e8-4f5e-987a-c8a519c37284" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90855e54-a200-45c4-bab3-5f6194483d00", "b59c1a3c-1c63-4c6c-81ef-2e2bae14313f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ff6a734-6b38-4768-a2b8-5e1e28bd6152", "1ddabcbe-352b-4c7d-b2be-68dc73aef846" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1e43d6e-4aa9-4d1d-96b0-9de9d7e6f431", "eeeec46d-9eb7-4784-a1ba-bea2a0ef5826" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be4969d3-c125-47c8-8f61-a0f1729d6e84", "d1ebd188-8c51-4c0b-a362-03b0a79f6072" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9a0491f-51c9-426c-b544-83de16a80b36", "95875c11-ea31-4c7a-b846-53eca1eb23dc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a9d0231-c45e-4e32-b9dd-9348b1a7e541", "50a51e20-4c69-4f0d-97cc-cac4255ab84e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ca49d77-f2de-4240-95e5-d8c55f0fa1e9", "50603250-1867-4f4e-9b19-cb56e1520c84" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c83c4fd0-27db-4bfc-9136-3d509b449841", "55f99da3-494c-4c79-a982-f1b5cff02337" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f067707d-6738-4240-8e9f-365f92787e66", "af616dc1-3c87-4b8b-913e-7b1415a28312" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88074d8c-f0dc-49df-8767-9aadff185df4", "c8e88d79-8d90-488f-b5a4-2b0450658ab4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae93a9ef-ccf9-4ab3-ba05-ded041592bae", "d57f2a46-154a-4fd0-b57a-32ab5274a9ce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44a8dcb1-37d9-4139-9620-162be1b386b2", "4067c183-f52f-4dd7-a0da-7d9ad1ed1248" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8fa5f6e0-8cdc-4c43-a183-f3d33db6c65b", "48b01c3d-fe95-40b8-843e-99b2ce95444c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d215bffd-bfcd-4833-84ad-961c8205fbed", "203c9bad-ceba-443c-922d-df68c0fd7ae8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a0e33e4-eeb3-4aef-aaf8-ea2a158502f6", "b36e2663-69da-4d7b-a0ce-ee1820c8bbc4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "135c8667-b22c-4e8c-88f0-0debd0ff68e5", "1b3f1fd0-52ec-4013-93f8-842d3c59f009" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b02eab9-3fb0-46e6-a0ab-fa3d6757b9eb", "074fa243-fc73-4473-be60-d4d34c5166b6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9769687-7427-4632-921b-eb1271d59ab1", "1518219d-b054-4c2d-8b92-63628e66a31e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8faf76f3-4e71-4492-afcb-646dd49f796c", "6f8c9d1a-19af-4e10-b42f-00003a78393a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c62b0aa-d590-45d3-971b-596406232aaa", "7d16ac0e-5aac-4d72-9cf8-e42d41bf376e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4222d63c-2131-4e7a-9c32-b3486764bfd1", "6bf3f026-4fef-4778-873f-71a64f524371" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de3637c4-aefa-4be7-b079-bdadff880525", "01b5da8f-ca29-4f16-aa20-48f6a2f8f7f6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b237d382-049a-4ea2-a20d-6c25098df559", "ff4db77c-b9f9-4fba-aaa2-72fbe072ce01" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0239bebb-79ab-4447-bf2a-66592f1fd18c", "b536237a-795a-400c-82bb-e74f6841660e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9831840-2567-47aa-82fa-95c5160ba10e", "960f5d16-4130-4961-b4d6-041d71b3865e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d81d2d17-2897-4f1d-a693-65d4b9f7c3e7", "218e66d7-278e-42b0-871a-774b58a68da1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditApplicationUserRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditAttachment",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditDefinedApplication",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditDefinedApplicationRole",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditDefinedRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditDefinedRequestReviewer",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditDefinedRequestRole",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditDepartment",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditDomainAccountRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditRequestApplicationRole",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditRequestReviewer",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditRole",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditSection",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditTravelDeskRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditUser",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditVehicleRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditVoucherRequest",
                schema: "audit");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2f3dcc4-b7b2-41e6-b87d-6ee3cb5dabb0", "f411b4cd-f08f-453a-bcf5-b69d9a77bc86" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f649a7cc-d82d-4e21-be82-b1a1074fa434", "0c6b2b22-b0c2-4cc2-b98c-23e4e24f9d02" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a97108b-929d-4fc4-85d8-7d95732f5c06", "1b46e5de-05aa-4f71-a30a-040696c7b564" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c827687-a1e1-4edd-90f2-8b2edd18073d", "07cde5ec-ea9b-4999-8e6c-e415d08946c7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5724a81-138f-48ae-96c9-6e8c1307f2cc", "9eec858e-e0cb-4e71-9a39-c18b4b5f1db5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6aa3c4f7-bc0c-4865-a994-4994c7c6668b", "c18a8375-235c-4db2-997d-487918ec4dbe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "336e6eed-7cce-40d2-9adb-8b63b7ff1f33", "14e00e81-dfd2-446d-a8fd-5c35dab2405d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c446e475-7a02-47d7-9305-8df04486767b", "91764a9f-aa71-4929-86e1-0a5e86a3bf16" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42db05d2-abc7-4440-9310-46782bb1484f", "919d9a8b-f277-498d-a38f-90a8e8e815fe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9515aabe-adf9-44c0-b833-b20d35b65156", "e4cada1b-e7cc-4887-8822-aa7aae8efce8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63e49300-8c05-4301-ba26-e9a7eac2a50d", "8063db78-eb41-4934-a8af-094031bb207e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67b4cbfa-0022-4a5f-b7c6-2e91c39279e0", "aed8dc31-032d-4038-a2d0-234701512dd7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba237ec9-9048-49d5-9543-64b495ce8c19", "154906f0-3bcb-477a-aa5e-e6f88a9f8789" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "776e5ab9-2c6d-4065-8997-c39f43e4d1a5", "b798e70d-a871-4c31-b115-b3f8f1bfc677" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c25579d-dc66-4421-a602-60992433f26d", "eb9dcb9c-83ca-4667-a3d4-53d1f5481f9a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7b44f15-d8df-44d4-9e68-e69da6499149", "df193a9d-fcd3-40b3-a7fa-126c5368b660" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd817568-7232-4114-b151-4687579aea16", "9173e652-91b8-4811-8b93-47c73c36e9ae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbc4012f-a16c-4af7-913b-d39a10c6010c", "e6f55ae1-dd27-4e18-93cd-f9f286077eec" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22c301a0-b7bf-4392-b737-de846b663028", "01d17b3d-2bf3-408d-b511-74461509353c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b74385c2-69cb-4293-a219-e8bb73575bfc", "36b8cf7b-823f-4f31-a36e-256953ac782c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1464badb-8720-4806-aceb-85ba3cf865ad", "e11e3b6a-e9e7-440c-8338-02c8005830b3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce4f7c29-6323-4e4d-8c41-be4396f1d171", "e4f99629-78ab-4d86-9ad4-bb79704a44b7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f731001-4c9b-4117-94a1-43508244ad5c", "a661ee9b-91e2-4971-aebb-55082b56eb17" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28794ebb-0324-4a7a-9515-31620bb09fca", "5fda1d53-686d-4214-8ceb-2a019f038c75" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e9dc171-9ca8-43cf-a8ee-bd6218e39fb0", "019b939b-c8ad-453a-9e0b-68bf37dbfab5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "084e545a-a716-402f-9943-963d06e560f4", "b3bf96ff-82cc-482b-bd0b-fc501280dd41" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed70b31e-0101-43fa-a387-f96c006abdec", "5b6e5a65-b209-4df4-9f39-92d69542de97" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1007f7e-13e3-46f7-8ad1-3222cd2a6ccd", "3b20cc7f-bc7e-4365-893a-9bdf491fd7e2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "abfa2a94-ba55-4335-83aa-407e9adccd69", "cdcf9494-6419-4b12-8ceb-2ac026f5c379" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1109ea2-2787-46fb-af51-cc55108b8950", "eeed3e2b-fd5e-4093-85ea-8069f3162de9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc555293-b308-4c86-b27b-57c8c685e7e8", "33069eb0-1d3e-4f65-86fb-75d4e12d5ce2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "19486832-0e60-4c34-975e-5ae315a251e2", "004aa81a-7127-4fb1-b183-ac1dfd2d28f7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11188e8d-c9dc-4b89-8efc-290d236b68e3", "9bd076f3-8264-4fb5-bb76-87926f0ffa64" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70ac9e33-6edf-49e9-b61b-18bbb3e39906", "be1b410b-72ef-4799-9a6c-87104e2174f9" });
        }
    }
}
