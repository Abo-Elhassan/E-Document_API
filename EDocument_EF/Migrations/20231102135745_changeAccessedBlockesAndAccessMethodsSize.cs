using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class changeAccessedBlockesAndAccessMethodsSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessMethod",
                table: "AccessControlRequest");

            migrationBuilder.AlterColumn<string>(
                name: "AccessedBlocks",
                table: "AccessControlRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccessMethods",
                table: "AccessControlRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessMethods",
                table: "AccessControlRequest");

            migrationBuilder.AlterColumn<string>(
                name: "AccessedBlocks",
                table: "AccessControlRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccessMethod",
                table: "AccessControlRequest",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
