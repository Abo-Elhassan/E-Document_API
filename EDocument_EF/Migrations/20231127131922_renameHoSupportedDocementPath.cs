using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class renameHoSupportedDocementPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HoSupportedDocementPath",
                table: "DiscountRequest",
                newName: "HoSupportedDocumentPath");

            migrationBuilder.RenameColumn(
                name: "HoSupportedDocementPath",
                schema: "audit",
                table: "AuditDiscountRequest",
                newName: "HoSupportedDocumentPath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HoSupportedDocumentPath",
                table: "DiscountRequest",
                newName: "HoSupportedDocementPath");

            migrationBuilder.RenameColumn(
                name: "HoSupportedDocumentPath",
                schema: "audit",
                table: "AuditDiscountRequest",
                newName: "HoSupportedDocementPath");
        }
    }
}
