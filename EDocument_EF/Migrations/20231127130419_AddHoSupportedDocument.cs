using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AddHoSupportedDocument : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HoSupportedDocementPath",
                table: "DiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HoSupportedDocementPath",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HoSupportedDocementPath",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "HoSupportedDocementPath",
                schema: "audit",
                table: "AuditDiscountRequest");
        }
    }
}
