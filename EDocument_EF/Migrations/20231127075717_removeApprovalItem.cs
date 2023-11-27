using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class removeApprovalItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApprovalItem",
                table: "MultimediaRequest");

            migrationBuilder.DropColumn(
                name: "ApprovalItem",
                schema: "audit",
                table: "AuditMultimediaRequest");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApprovalItem",
                table: "MultimediaRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApprovalItem",
                schema: "audit",
                table: "AuditMultimediaRequest",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
