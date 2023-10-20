using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIdentityKeyFromUserAndAudit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentityKey",
                schema: "security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdentityKey",
                schema: "audit",
                table: "AuditUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdentityKey",
                schema: "security",
                table: "User",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "IdentityKey",
                schema: "audit",
                table: "AuditUser",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
