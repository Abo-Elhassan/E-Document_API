using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addRequestApplicationRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationItAdmin_RequestedApplication",
                table: "ApplicationItAdmin");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserRequest_RequestedApplication",
                table: "ApplicationUserRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_DefinedApplicationRole_RequestedApplication",
                table: "DefinedApplicationRole");

            migrationBuilder.DropTable(
                name: "ApplicationUserRequestRole");

            migrationBuilder.DropTable(
                name: "RequestedApplication");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserRequest_RequestedApplicationId",
                table: "ApplicationUserRequest");

            migrationBuilder.DropColumn(
                name: "RequestedApplicationId",
                table: "ApplicationUserRequest");

            migrationBuilder.CreateTable(
                name: "DefinedApplication",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ApplicationOwnerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefinedApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DefinedApplication_User",
                        column: x => x.ApplicationOwnerId,
                        principalSchema: "security",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestApplicationRole",
                columns: table => new
                {
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestApplicationRole", x => new { x.RequestId, x.ApplicationId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_RequestApplicationRole_DefinedApplication",
                        column: x => x.ApplicationId,
                        principalTable: "DefinedApplication",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequestApplicationRole_DefinedApplicationRole",
                        column: x => x.RoleId,
                        principalTable: "DefinedApplicationRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RequestApplicationRole_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DefinedApplication_ApplicationOwnerId",
                table: "DefinedApplication",
                column: "ApplicationOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApplicationRole_ApplicationId",
                table: "RequestApplicationRole",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestApplicationRole_RoleId",
                table: "RequestApplicationRole",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationItAdmin_DefinedApplication",
                table: "ApplicationItAdmin",
                column: "ApplicationId",
                principalTable: "DefinedApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DefinedApplicationRole_RequestedApplication",
                table: "DefinedApplicationRole",
                column: "RequestedApplicationId",
                principalTable: "DefinedApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationItAdmin_DefinedApplication",
                table: "ApplicationItAdmin");

            migrationBuilder.DropForeignKey(
                name: "FK_DefinedApplicationRole_RequestedApplication",
                table: "DefinedApplicationRole");

            migrationBuilder.DropTable(
                name: "RequestApplicationRole");

            migrationBuilder.DropTable(
                name: "DefinedApplication");

            migrationBuilder.AddColumn<long>(
                name: "RequestedApplicationId",
                table: "ApplicationUserRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "ApplicationUserRequestRole",
                columns: table => new
                {
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    ApplicationRoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserRequestRole", x => new { x.RequestId, x.ApplicationRoleId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserRequestRole_DefinedApplicationRole",
                        column: x => x.ApplicationRoleId,
                        principalTable: "DefinedApplicationRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationUserRequestRole_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestedApplication",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationOwnerId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApplicationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestedApplication", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestedApplication_User",
                        column: x => x.ApplicationOwnerId,
                        principalSchema: "security",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRequest_RequestedApplicationId",
                table: "ApplicationUserRequest",
                column: "RequestedApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRequestRole_ApplicationRoleId",
                table: "ApplicationUserRequestRole",
                column: "ApplicationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestedApplication_ApplicationOwnerId",
                table: "RequestedApplication",
                column: "ApplicationOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationItAdmin_RequestedApplication",
                table: "ApplicationItAdmin",
                column: "ApplicationId",
                principalTable: "RequestedApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserRequest_RequestedApplication",
                table: "ApplicationUserRequest",
                column: "RequestedApplicationId",
                principalTable: "RequestedApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DefinedApplicationRole_RequestedApplication",
                table: "DefinedApplicationRole",
                column: "RequestedApplicationId",
                principalTable: "RequestedApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
