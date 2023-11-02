using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class trasnferCCTVAndAccessControlAuditTableToAuditScheme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditCCTVAccessRequests",
                table: "AuditCCTVAccessRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditAccessControlRequests",
                table: "AuditAccessControlRequests");

            migrationBuilder.RenameTable(
                name: "AuditCCTVAccessRequests",
                newName: "AuditCCTVAccessRequest",
                newSchema: "audit");

            migrationBuilder.RenameTable(
                name: "AuditAccessControlRequests",
                newName: "AuditAccessControlRequest",
                newSchema: "audit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditCCTVAccessRequest",
                schema: "audit",
                table: "AuditCCTVAccessRequest",
                column: "AuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditAccessControlRequest",
                schema: "audit",
                table: "AuditAccessControlRequest",
                column: "AuditId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditCCTVAccessRequest",
                schema: "audit",
                table: "AuditCCTVAccessRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditAccessControlRequest",
                schema: "audit",
                table: "AuditAccessControlRequest");

            migrationBuilder.RenameTable(
                name: "AuditCCTVAccessRequest",
                schema: "audit",
                newName: "AuditCCTVAccessRequests");

            migrationBuilder.RenameTable(
                name: "AuditAccessControlRequest",
                schema: "audit",
                newName: "AuditAccessControlRequests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditCCTVAccessRequests",
                table: "AuditCCTVAccessRequests",
                column: "AuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditAccessControlRequests",
                table: "AuditAccessControlRequests",
                column: "AuditId");
        }
    }
}
