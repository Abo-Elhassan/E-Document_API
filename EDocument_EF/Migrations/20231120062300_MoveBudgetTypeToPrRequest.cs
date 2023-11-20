using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class MoveBudgetTypeToPrRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BudgetType",
                table: "RequestedPr");

            migrationBuilder.DropColumn(
                name: "BudgetType",
                schema: "audit",
                table: "AuditRequestedPr");

            migrationBuilder.AddColumn<string>(
                name: "BudgetType",
                table: "PrRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BudgetType",
                schema: "audit",
                table: "AuditPrRequest",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BudgetType",
                table: "PrRequest");

            migrationBuilder.DropColumn(
                name: "BudgetType",
                schema: "audit",
                table: "AuditPrRequest");

            migrationBuilder.AddColumn<string>(
                name: "BudgetType",
                table: "RequestedPr",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BudgetType",
                schema: "audit",
                table: "AuditRequestedPr",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
