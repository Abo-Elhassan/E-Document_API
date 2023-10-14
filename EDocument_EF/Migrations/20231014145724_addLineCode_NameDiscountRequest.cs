using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addLineCode_NameDiscountRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LineCode",
                table: "DiscountRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LineName",
                table: "DiscountRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LineCode",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LineName",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LineCode",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "LineName",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "LineCode",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "LineName",
                schema: "audit",
                table: "AuditDiscountRequest");
        }
    }
}
