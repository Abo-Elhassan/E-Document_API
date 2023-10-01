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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "security",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "security",
                table: "Role",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "security",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                schema: "security",
                table: "Role",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Transaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                values: new object[] { "79b9ada8-c09e-4713-878e-5c9103b605d5", "ef9566e4-c105-4471-ac59-c8f6c1513e60" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6c2365b-ed7e-4268-8aaf-e39a790ea025", "a8f772b2-47d2-4b45-95e6-4a0ff8d6c5be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "435bf1a4-b252-4988-92a5-e83a684fe5bb", "6cdf9a9f-2ed6-440d-a920-9ec6148107ce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50f6a7f5-4712-48e6-9e6a-a6bc79bf4029", "01549ccc-8930-4f56-b170-d60fb88879c0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "842884cc-7fd6-4f31-a326-ced177494353", "51cb3804-73b5-4c3d-81a5-53664f0b32f6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "543459e6-bae1-4108-a2e2-b85672b07081", "cac19094-e5ac-4a83-a4ac-c1b38e06b639" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e157227-0c71-437f-9fdd-735d5a65d157", "10363024-0a7f-4069-98cd-8a3d921324de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1d8a39b-bac6-472e-91de-fa3a28859273", "b7551f24-f790-4fb8-8159-04445b09b34d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd13bb0f-1260-4c77-97ec-37f35da9d159", "ec492cb3-c49b-43ba-8bb0-df87c10b6145" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c2e834e1-82b0-475c-b888-e3c75ca2f733", "c50c6994-56ff-4da1-b9fe-ec4ebefd731e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c38b4853-f15e-4c4b-8cd0-c448400c8079", "e3b982e5-3717-42c9-8ad4-dfb90950ae13" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "639f07de-3fec-409a-a748-9e6c459b2bce", "ed16b4ba-0dc1-4236-bc17-235bf6ba1b51" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e06ce94-2f95-40fc-a704-be3b580662a2", "ff7ebfcc-05e6-47be-a727-ada04682e5b4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "adc71158-0e48-4122-8383-f7a44ac0485a", "7783f836-5972-4b21-a1bb-d21612f052ca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e731e9f-0300-4a3c-9801-be6be76e65f2", "c4ef663b-c911-4534-b8cf-2094545e5f97" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5353b510-b1a8-4f39-b24f-c37813768a7a", "90394299-4d87-488b-b6c2-379a33bf9f72" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82ae1aff-0e94-4385-bca6-883b35e6d1e1", "71770385-7453-4591-bcdc-bc5b37d54a32" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb9d239b-6761-4e34-8d84-f6eb73d8dc9f", "86afe343-70ec-43e2-98ff-8711a95e6361" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7d017fa-6206-4031-9b2b-710bd5d8a374", "b1718289-6c3e-4343-bbed-f91fb260dfce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bc7a7474-be33-4330-bc5f-4b36c9a915ab", "cb02bc91-e1de-4e0a-9fae-285d23033fb1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31886f40-ebeb-4cff-b977-e5914f41ed1e", "ba297dab-1430-4036-a617-4fb7b7fab219" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1152b64-34f4-45d9-9e21-6f23e666b4de", "b11ebee6-81f8-4f76-bbbd-db02a3ef6c43" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f47dbd8-a2c3-4d89-9165-a3bdfea241a4", "91148a7f-f7d4-4b0f-90b8-6509b0cc928f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4bda5dc5-19dd-4872-8d55-47a6cf9f08f3", "cff9a1e4-2fc5-4a38-b782-3e97c861ee31" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee44b2bd-9bca-47a6-b0bf-ae269c9d5685", "b11e329b-482a-488c-b559-6b561a1ec64f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b589e5c3-711e-4f20-ad00-3b263c8dcf21", "184974d5-9a9b-44e3-90da-503dd9dc1e96" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81876c9e-927c-47b2-8313-bebe7452f8c4", "01002d77-cec3-4e68-89a9-51db129df5de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff43862f-b181-4bc8-8179-034f77b8924d", "b551a17d-6ae1-4807-8514-300ce8c8a9ad" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb996563-8897-487b-a55a-a65b98ea5630", "66c0b89a-aa18-41c7-95fd-ae3aed7b7ff2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3eb66f1d-0902-41ab-be20-81dbace9c196", "a14d8722-2652-4b6d-a550-c05f31177db7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "162d2e90-5a96-4f22-8afe-b91bad72df2f", "00bdd3bf-d287-49c7-ad91-ddadee1e86d0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f101204-9a51-45b5-a908-5b7913f02782", "5a663790-02e1-4451-996b-977f8d7beb97" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "402bf159-9deb-4c3c-add8-aeb2c4964f78", "4a99af8e-7d0c-4c4a-8897-26bea5c25b70" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80906d82-d129-4317-a68a-e533de33b6f5", "89b5c30c-1bf0-4bd2-b430-299f42e63fa0" });
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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                schema: "security",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "security",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "security",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "security",
                table: "Role");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e833270-334f-497d-84f6-9a0230479385", "effdbefb-b420-4eb3-a210-937a8d14418b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d02b74a8-cd31-47d0-a6a0-568f9080381b", "11dfd60f-fa1f-415f-bead-b3ada92a02c8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9763194e-7a83-4ca6-ade2-057cfce3ac88", "46f1865c-1c0b-4ba8-9a63-a59b0e71b5bf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c0f2ace4-44d9-4825-96e2-fed338f58765", "b5f91818-9330-47dd-bc48-5ef91cbf0a1a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0817d1c4-4a5d-4217-b20a-eb031af93d50", "b5d665b6-7898-4361-b4f9-61c50ea9057c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4e3c581-fa12-4c14-93be-dded021c4f18", "37aedeff-ed8e-497c-a0a6-a766c69f9c07" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "365f5ba9-746f-4d4b-859b-1d9948662e0b", "cf988fe4-959e-42e2-995d-331b435cdd2b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7dbf5d4-856f-4d77-977a-d6af522c0941", "db9344c9-615c-44f8-8b1a-ce31c2f32ef2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b28f30f-9ba5-4229-8af8-fe82d746a44b", "a1633cf7-c5df-4f92-910c-7696f1926d5e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b48a73c1-d164-4ba2-8316-bee7e15306bb", "6e1ef730-640d-4e44-879c-35db7c023e10" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb1bf4c7-845b-4d22-90df-af5f7de3a07b", "71736f2a-cb6a-4c0c-abbe-45481c0c0719" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1aa3e95e-8986-4da3-8103-46b9b3f88a72", "1a13259c-6592-4f8e-a9ad-f3ce393e865b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80b9ada1-f6d3-4e18-9636-1a09772534a8", "f2048106-4bc8-4126-9062-abc2b779e905" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "840ce4ae-3114-47a2-a4fe-687042f00f81", "765903e6-b009-4c5b-8d2d-214eb575818b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dddcb8e6-a012-44bd-8fba-2d02dc11db69", "bcb6cd08-bbbb-497d-ae70-c750ae9ece98" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e6866f4-b560-42ca-8a4a-ea9441e3be5a", "4a5fedcf-3a1b-4327-982a-2398fd5f6601" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "696d6fc2-29f7-4c6b-8bd2-f412a6bddc48", "fcb480b5-7f09-49b7-b257-a9e7cbd99389" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29c6f27c-758e-4bdc-a495-f7ba3a933cb2", "c3625f05-7e93-4f00-8d16-824b5510104c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "783e5e6c-3cc8-4d24-b0f6-5c86af5595b4", "4d61514b-10e8-456b-a364-9236fb864dca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea472237-19b0-4924-9548-45fed826548b", "b6dc0b07-efd3-47f5-ab2a-b0105e7b8cf7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6053bb81-c485-4a51-aae0-09cb3ab00b4f", "163ac9a6-5883-44a8-92e5-2eceb4177181" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "601f18ae-8ac6-41eb-afe6-3231b47a0bc9", "524cfd37-7e68-4552-8832-a7ae73dbae87" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1801ffc-0792-405e-b66f-4a66b34bb486", "5d68b9d1-b698-4c68-8421-40ec1ffc4f7a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f91b40e-bca8-4f1a-a901-00bb36aa0bc8", "1a526b08-81ee-4741-b126-2d78e7035016" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10b98a2c-53d3-4a58-b046-7273e320a293", "3a4cf9d3-2f1c-4891-931b-f9a30d4133fe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a33a368-8dda-4239-af99-bcc664051cc1", "0544074d-f11f-4cd3-99e0-1d6b183f4d57" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "533a0f04-2991-4a09-a077-eb0ea2953492", "8e7c25aa-75b9-47a9-9f0e-ad1d69a362da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac048eb1-3b72-44bb-b526-ccb0184c5adc", "1d730c87-e30d-4a83-b133-81585ea0497d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9fcecc5-6ab9-421a-a9d4-025747f011e6", "34b2c43a-8113-47ed-9336-17f750e456a9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a33fc55-6058-4a77-b433-a6c0cfede61b", "5eb2735c-3382-4ce9-8310-08037d6bea18" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b22c1f8-8c2d-4b83-99ec-a82a73c2f017", "830e8fdc-479d-438d-ad04-e65acc8c70a3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b87e84a1-92e1-4e06-925b-09be7b8117c3", "fdd0b23d-03db-455f-883c-456a8d4e52a7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4453ab6e-3700-4421-983f-9895760fd3b3", "c2ea7429-216c-4fe7-83cb-d3d1872fbefe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b75ab0ac-bdd3-46a3-80a0-615dca596b26", "04d99087-1643-4113-bec9-c4a1ea4da742" });
        }
    }
}
