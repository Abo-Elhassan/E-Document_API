using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class EditAuditTableOperationsRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InConcessionArea",
                schema: "audit",
                table: "AuditEquipmentRequestOut",
                newName: "OutConcessionArea");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OutConcessionArea",
                schema: "audit",
                table: "AuditEquipmentRequestOut",
                newName: "InConcessionArea");
        }
    }
}
