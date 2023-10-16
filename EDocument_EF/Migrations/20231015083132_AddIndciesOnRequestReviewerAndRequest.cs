using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AddIndciesOnRequestReviewerAndRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestReviewer",
                table: "RequestReviewer");

            migrationBuilder.DropIndex(
                name: "IX_RequestReviewer_AssignedReviewerId",
                table: "RequestReviewer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestReviewer",
                table: "RequestReviewer",
                column: "Key")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.CreateIndex(
                name: "IX_RequestReviewer_AssignedReviewerId",
                table: "RequestReviewer",
                column: "AssignedReviewerId")
                .Annotation("SqlServer:Clustered", true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestReviewer",
                table: "RequestReviewer");

            migrationBuilder.DropIndex(
                name: "IX_RequestReviewer_AssignedReviewerId",
                table: "RequestReviewer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestReviewer",
                table: "RequestReviewer",
                column: "Key");

            migrationBuilder.CreateIndex(
                name: "IX_RequestReviewer_AssignedReviewerId",
                table: "RequestReviewer",
                column: "AssignedReviewerId");
        }
    }
}
