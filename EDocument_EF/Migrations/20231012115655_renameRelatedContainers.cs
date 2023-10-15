using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class renameRelatedContainers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContainerNumbers",
                schema: "audit",
                table: "AuditDiscountRequest",
                newName: "RelatedContainers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RelatedContainers",
                schema: "audit",
                table: "AuditDiscountRequest",
                newName: "ContainerNumbers");
        }
    }
}
