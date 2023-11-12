using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addMissingFieldsInNewItemRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemNumber",
                table: "RequestedItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemNumber",
                schema: "audit",
                table: "AuditRequestedItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RequestedItemId",
                schema: "audit",
                table: "AuditRequestedItem",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemNumber",
                table: "RequestedItem");

            migrationBuilder.DropColumn(
                name: "ItemNumber",
                schema: "audit",
                table: "AuditRequestedItem");

            migrationBuilder.DropColumn(
                name: "RequestedItemId",
                schema: "audit",
                table: "AuditRequestedItem");
        }
    }
}
