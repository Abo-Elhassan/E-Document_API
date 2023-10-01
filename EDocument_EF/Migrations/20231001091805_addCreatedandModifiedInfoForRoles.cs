using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addCreatedandModifiedInfoForRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                schema: "security",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "security",
                table: "Role",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                schema: "security",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                schema: "security",
                table: "Role",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");



        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
               name: "CreatedAt",
               schema: "security",
               table: "Role");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "security",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                schema: "security",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "security",
                table: "Role");
        }
    }
}
