using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "DefinedRequest",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    RequestName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeptMgrApprove = table.Column<bool>(type: "bit", nullable: false),
                    DirectMgrApprove = table.Column<bool>(type: "bit", nullable: false),
                    StagesNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinedRequest", x => x.Id);
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
                name: " TravelDeskRequest",
                columns: table => new
                {
                    BeneficiaryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    RequestTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryNationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostAllocation = table.Column<float>(type: "real", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryPostion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequesterPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ TravelDeskRequest", x => new { x.BeneficiaryId, x.RequestId });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(50)", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "BiAccessRequest",
                columns: table => new
                {
                    BeneficiaryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryPostion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequesterPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiAccessRequest", x => new { x.BeneficiaryId, x.RequestId });
                });

            migrationBuilder.CreateTable(
                name: "CarRequest",
                columns: table => new
                {
                    BeneficiaryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    DepartureAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DestinationAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RetrunDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LuggageDescription = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttachmentPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryPostion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequesterPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRequest", x => new { x.BeneficiaryId, x.RequestId });
                });

            migrationBuilder.CreateTable(
                name: "DefinedRequestReviewer",
                columns: table => new
                {
                    DefinedRequestId = table.Column<long>(type: "bigint", nullable: false),
                    ReviewerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StageName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StageNumber = table.Column<int>(type: "int", nullable: false),
                    RequestedApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinedRequestReviewer", x => new { x.DefinedRequestId, x.ReviewerId });
                    table.ForeignKey(
                        name: "FK_DefinedRequestReviewer_DefinedRequest",
                        column: x => x.DefinedRequestId,
                        principalTable: "DefinedRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DefinedRequestRole",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DefinedRequestId = table.Column<long>(type: "bigint", nullable: false),
                    RequestedApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinedRequestRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DefinedRequestRole_DefinedRequest",
                        column: x => x.DefinedRequestId,
                        principalTable: "DefinedRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ManagerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false),
                    ManagerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Department",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_User",
                        column: x => x.ManagerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CurrentStage = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewerNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DefinedRequestId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_DefinedRequest",
                        column: x => x.DefinedRequestId,
                        principalTable: "DefinedRequest",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Request_User",
                        column: x => x.CreatorId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RequestedApplication",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationOwnerId = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestedApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestedApplication_User_ApplicationOwnerId",
                        column: x => x.ApplicationOwnerId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaim_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DomainAccountRequest",
                columns: table => new
                {
                    BeneficiaryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoginName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    OU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryPostion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequesterPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomainAccountRequest", x => new { x.BeneficiaryId, x.RequestId });
                    table.ForeignKey(
                        name: "FK_DomainAccountRequest_Department",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DomainAccountRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MenaPayAccessRequest",
                columns: table => new
                {
                    BeneficiaryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryPostion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequesterPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenaPayAccessRequest", x => new { x.BeneficiaryId, x.RequestId });
                    table.ForeignKey(
                        name: "FK_MenaPayAccessRequest_Department",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MenaPayAccessRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OracleFusionAccessRequest",
                columns: table => new
                {
                    BeneficiaryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryPostion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequesterPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OracleFusionAccessRequest", x => new { x.BeneficiaryId, x.RequestId });
                    table.ForeignKey(
                        name: "FK_OracleFusionAccessRequest_Department",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OracleFusionAccessRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestReviewer",
                columns: table => new
                {
                    ReviewerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestReviewer", x => new { x.ReviewerId, x.RequestId });
                    table.ForeignKey(
                        name: "FK_RequestReviewer_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequestReviewer_User",
                        column: x => x.ReviewerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestRole",
                columns: table => new
                {
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestRole", x => new { x.RoleId, x.RequestId });
                    table.ForeignKey(
                        name: "FK_RequestRole_DefinedRequestRole",
                        column: x => x.RoleId,
                        principalTable: "DefinedRequestRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequestRole_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TosAccessRequest",
                columns: table => new
                {
                    BeneficiaryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryPostion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequesterPurpose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TosAccessRequest", x => new { x.BeneficiaryId, x.RequestId });
                    table.ForeignKey(
                        name: "FK_TosAccessRequest_Department",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TosAccessRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ TravelDeskRequest_DepartmentId",
                table: " TravelDeskRequest",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ TravelDeskRequest_RequestId",
                table: " TravelDeskRequest",
                column: "RequestId");

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
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_BiAccessRequest_DepartmentId",
                table: "BiAccessRequest",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_BiAccessRequest_RequestId",
                table: "BiAccessRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_CarRequest_DepartmentId",
                table: "CarRequest",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CarRequest_RequestId",
                table: "CarRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinedRequestReviewer_RequestedApplicationId",
                table: "DefinedRequestReviewer",
                column: "RequestedApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinedRequestReviewer_ReviewerId",
                table: "DefinedRequestReviewer",
                column: "ReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinedRequestRole_DefinedRequestId",
                table: "DefinedRequestRole",
                column: "DefinedRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DefinedRequestRole_RequestedApplicationId",
                table: "DefinedRequestRole",
                column: "RequestedApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_ManagerId",
                table: "Department",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainAccountRequest_DepartmentId",
                table: "DomainAccountRequest",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainAccountRequest_RequestId",
                table: "DomainAccountRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_MenaPayAccessRequest_DepartmentId",
                table: "MenaPayAccessRequest",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_MenaPayAccessRequest_RequestId",
                table: "MenaPayAccessRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_OracleFusionAccessRequest_DepartmentId",
                table: "OracleFusionAccessRequest",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OracleFusionAccessRequest_RequestId",
                table: "OracleFusionAccessRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_CreatorId",
                table: "Request",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_DefinedRequestId",
                table: "Request",
                column: "DefinedRequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestedApplication_ApplicationOwnerId",
                table: "RequestedApplication",
                column: "ApplicationOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReviewer_RequestId",
                table: "RequestReviewer",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestRole_RequestId",
                table: "RequestRole",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_TosAccessRequest_DepartmentId",
                table: "TosAccessRequest",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TosAccessRequest_RequestId",
                table: "TosAccessRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_User_DepartmentId",
                table: "User",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ManagerId",
                table: "User",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaim_UserId",
                table: "UserClaim",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelDeskRequest_Department",
                table: " TravelDeskRequest",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelDeskRequest_Request",
                table: " TravelDeskRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_User_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_User_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_User_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BiAccessRequest_Department",
                table: "BiAccessRequest",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BiAccessRequest_Request",
                table: "BiAccessRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarRequest_Department",
                table: "CarRequest",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarRequest_Request",
                table: "CarRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DefinedRequestReviewer_EmployeeRequestedApplication",
                table: "DefinedRequestReviewer",
                column: "RequestedApplicationId",
                principalTable: "RequestedApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DefinedRequestReviewer_User",
                table: "DefinedRequestReviewer",
                column: "ReviewerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DefinedRequestRole_RequestedApplication",
                table: "DefinedRequestRole",
                column: "RequestedApplicationId",
                principalTable: "RequestedApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_User",
                table: "Department",
                column: "ManagerId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Department",
                table: "User");

            migrationBuilder.DropTable(
                name: " TravelDeskRequest");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BiAccessRequest");

            migrationBuilder.DropTable(
                name: "CarRequest");

            migrationBuilder.DropTable(
                name: "DefinedRequestReviewer");

            migrationBuilder.DropTable(
                name: "DomainAccountRequest");

            migrationBuilder.DropTable(
                name: "MenaPayAccessRequest");

            migrationBuilder.DropTable(
                name: "OracleFusionAccessRequest");

            migrationBuilder.DropTable(
                name: "RequestReviewer");

            migrationBuilder.DropTable(
                name: "RequestRole");

            migrationBuilder.DropTable(
                name: "TosAccessRequest");

            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DefinedRequestRole");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "RequestedApplication");

            migrationBuilder.DropTable(
                name: "DefinedRequest");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
