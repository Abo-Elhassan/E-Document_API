using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class renameAccessMethodsColumnInAccessControl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccessMethod",
                schema: "audit",
                table: "AuditAccessControlRequest",
                newName: "AccessMethods");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccessMethods",
                schema: "audit",
                table: "AuditAccessControlRequest",
                newName: "AccessMethod");
        }
    }
}
