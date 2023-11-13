using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class FixfilterBugInPRRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PRSubject",
                table: "PRRequest",
                newName: "PrSubject");

            migrationBuilder.RenameColumn(
                name: "AFENumber",
                table: "PRRequest",
                newName: "AfeNumber");

            migrationBuilder.RenameColumn(
                name: "PRSubject",
                schema: "audit",
                table: "AuditPRRequest",
                newName: "PrSubject");

            migrationBuilder.RenameColumn(
                name: "AFENumber",
                schema: "audit",
                table: "AuditPRRequest",
                newName: "AfeNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrSubject",
                table: "PRRequest",
                newName: "PRSubject");

            migrationBuilder.RenameColumn(
                name: "AfeNumber",
                table: "PRRequest",
                newName: "AFENumber");

            migrationBuilder.RenameColumn(
                name: "PrSubject",
                schema: "audit",
                table: "AuditPRRequest",
                newName: "PRSubject");

            migrationBuilder.RenameColumn(
                name: "AfeNumber",
                schema: "audit",
                table: "AuditPRRequest",
                newName: "AFENumber");
        }
    }
}
