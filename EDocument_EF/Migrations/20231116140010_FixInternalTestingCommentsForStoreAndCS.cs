using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class FixInternalTestingCommentsForStoreAndCS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemNumber",
                table: "PRRequest");

            migrationBuilder.DropColumn(
                name: "ItemNumber",
                schema: "audit",
                table: "AuditPRRequest");

            migrationBuilder.AddColumn<string>(
                name: "ItemNumber",
                table: "RequestedPR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwiftNumber",
                table: "FuelOilInvoiceRequest",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemNumber",
                schema: "audit",
                table: "AuditRequestedPR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SwiftNumber",
                schema: "audit",
                table: "AuditFuelOilInvoiceRequest",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemNumber",
                table: "RequestedPR");

            migrationBuilder.DropColumn(
                name: "SwiftNumber",
                table: "FuelOilInvoiceRequest");

            migrationBuilder.DropColumn(
                name: "ItemNumber",
                schema: "audit",
                table: "AuditRequestedPR");

            migrationBuilder.DropColumn(
                name: "SwiftNumber",
                schema: "audit",
                table: "AuditFuelOilInvoiceRequest");

            migrationBuilder.AddColumn<string>(
                name: "ItemNumber",
                table: "PRRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemNumber",
                schema: "audit",
                table: "AuditPRRequest",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
