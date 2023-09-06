using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class testTrigger : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_DefinedRequest",
                table: "Request");

            migrationBuilder.AlterColumn<long>(
                name: "DefinedRequestId",
                table: "Request",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Request_DefinedRequest",
                table: "Request",
                column: "DefinedRequestId",
                principalTable: "DefinedRequest",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Request_DefinedRequest",
                table: "Request");

            migrationBuilder.AlterColumn<long>(
                name: "DefinedRequestId",
                table: "Request",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_DefinedRequest",
                table: "Request",
                column: "DefinedRequestId",
                principalTable: "DefinedRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
