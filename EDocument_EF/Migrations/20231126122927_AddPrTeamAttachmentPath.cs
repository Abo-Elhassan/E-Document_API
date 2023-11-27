using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AddPrTeamAttachmentPath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PrTeamAttachmentPath",
                table: "MultimediaRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrTeamAttachmentPath",
                schema: "audit",
                table: "AuditMultimediaRequest",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrTeamAttachmentPath",
                table: "MultimediaRequest");

            migrationBuilder.DropColumn(
                name: "PrTeamAttachmentPath",
                schema: "audit",
                table: "AuditMultimediaRequest");
        }
    }
}
