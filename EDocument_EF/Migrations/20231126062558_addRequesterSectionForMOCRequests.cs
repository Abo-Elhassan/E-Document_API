using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addRequesterSectionForMOCRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WoNumber",
                table: "ReschedulePmWoRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequesterSection",
                table: "ReschedulePmWoRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequesterSection",
                table: "PmJpRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RequesterSection",
                schema: "audit",
                table: "AuditReschedulePmWoRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequesterSection",
                schema: "audit",
                table: "AuditPmJpRequest",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequesterSection",
                table: "ReschedulePmWoRequest");

            migrationBuilder.DropColumn(
                name: "RequesterSection",
                table: "PmJpRequest");

            migrationBuilder.DropColumn(
                name: "RequesterSection",
                schema: "audit",
                table: "AuditReschedulePmWoRequest");

            migrationBuilder.DropColumn(
                name: "RequesterSection",
                schema: "audit",
                table: "AuditPmJpRequest");

            migrationBuilder.AlterColumn<string>(
                name: "WoNumber",
                table: "ReschedulePmWoRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
