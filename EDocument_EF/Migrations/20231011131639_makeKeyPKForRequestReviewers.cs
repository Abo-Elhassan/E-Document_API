using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeKeyPKForRequestReviewers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestReviewer",
                table: "RequestReviewer");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "RequestReviewer",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AssignedReviewerId",
                table: "RequestReviewer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestReviewer",
                table: "RequestReviewer",
                column: "Key");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReviewer_RequestId",
                table: "RequestReviewer",
                column: "RequestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestReviewer",
                table: "RequestReviewer");

            migrationBuilder.DropIndex(
                name: "IX_RequestReviewer_RequestId",
                table: "RequestReviewer");

            migrationBuilder.AlterColumn<string>(
                name: "AssignedReviewerId",
                table: "RequestReviewer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "RequestReviewer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestReviewer",
                table: "RequestReviewer",
                columns: new[] { "RequestId", "AssignedReviewerId" });
        }
    }
}
