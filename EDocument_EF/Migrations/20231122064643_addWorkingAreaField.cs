using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addWorkingAreaField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkingArea",
                table: "ManliftReservationRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkingArea",
                schema: "audit",
                table: "AuditManliftReservationRequest",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkingArea",
                table: "ManliftReservationRequest");

            migrationBuilder.DropColumn(
                name: "WorkingArea",
                schema: "audit",
                table: "AuditManliftReservationRequest");
        }
    }
}
