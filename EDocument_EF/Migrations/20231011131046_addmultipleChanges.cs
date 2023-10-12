using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addmultipleChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "audit",
                table: "AuditUser");

            migrationBuilder.RenameColumn(
                name: "IsEmployee",
                schema: "security",
                table: "User",
                newName: "HasLDAP");

            migrationBuilder.RenameColumn(
                name: "IsEmployee",
                schema: "audit",
                table: "AuditUser",
                newName: "HasLDAP");

            migrationBuilder.AddColumn<string>(
                name: "Roles",
                schema: "security",
                table: "User",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "RequestReviewer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Roles",
                schema: "audit",
                table: "AuditUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                schema: "audit",
                table: "AuditRequestReviewer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Key",
                schema: "audit",
                table: "AuditDefinedRequestReviewer",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "AuditDiscountRequest",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_AuditDiscountRequest", x => x.AuditId);
                    table.ForeignKey(
                        name: "FK_AuditDiscountRequest_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiscountRequest",
                columns: table => new
                {
                    RequestNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasCommercialAgreement = table.Column<bool>(type: "bit", nullable: false),
                    AgreementName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountRequest", x => x.RequestNumber);
                    table.ForeignKey(
                        name: "FK_DiscountRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditDiscountRequest_RequestId",
                schema: "audit",
                table: "AuditDiscountRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountRequest_RequestId",
                table: "DiscountRequest",
                column: "RequestId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditDiscountRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "Roles",
                schema: "security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "RequestReviewer");

            migrationBuilder.DropColumn(
                name: "Roles",
                schema: "audit",
                table: "AuditUser");

            migrationBuilder.DropColumn(
                name: "Key",
                schema: "audit",
                table: "AuditRequestReviewer");

            migrationBuilder.DropColumn(
                name: "Key",
                schema: "audit",
                table: "AuditDefinedRequestReviewer");

            migrationBuilder.RenameColumn(
                name: "HasLDAP",
                schema: "security",
                table: "User",
                newName: "IsEmployee");

            migrationBuilder.RenameColumn(
                name: "HasLDAP",
                schema: "audit",
                table: "AuditUser",
                newName: "IsEmployee");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "audit",
                table: "AuditUser",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
