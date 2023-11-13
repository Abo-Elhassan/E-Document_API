using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AdditionaltoolsInAuditOperation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Additionaltools",
                schema: "audit",
                table: "AuditEquipmentRequestOut",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Additionaltools",
                schema: "audit",
                table: "AuditEquipmentRequestIn",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Additionaltools",
                schema: "audit",
                table: "AuditEquipmentRequestOut");

            migrationBuilder.DropColumn(
                name: "Additionaltools",
                schema: "audit",
                table: "AuditEquipmentRequestIn");
        }
    }
}
