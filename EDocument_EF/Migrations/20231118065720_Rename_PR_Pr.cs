using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class Rename_PR_Pr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PRRequest_Request",
                table: "PRRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestedPR_Request",
                table: "RequestedPR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestedPR",
                table: "RequestedPR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PRRequest",
                table: "PRRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditRequestedPR",
                schema: "audit",
                table: "AuditRequestedPR");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditPRRequest",
                schema: "audit",
                table: "AuditPRRequest");

            migrationBuilder.RenameTable(
                name: "RequestedPR",
                newName: "RequestedPr");

            migrationBuilder.RenameTable(
                name: "PRRequest",
                newName: "PrRequest");

            migrationBuilder.RenameTable(
                name: "AuditRequestedPR",
                schema: "audit",
                newName: "AuditRequestedPr",
                newSchema: "audit");

            migrationBuilder.RenameTable(
                name: "AuditPRRequest",
                schema: "audit",
                newName: "AuditPrRequest",
                newSchema: "audit");

            migrationBuilder.RenameColumn(
                name: "PRNumber",
                table: "RequestedPr",
                newName: "PrNumber");

            migrationBuilder.RenameColumn(
                name: "PRDescription",
                table: "RequestedPr",
                newName: "PrDescription");

            migrationBuilder.RenameColumn(
                name: "RequestedPRId",
                table: "RequestedPr",
                newName: "RequestedPrId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestedPR_RequestId",
                table: "RequestedPr",
                newName: "IX_RequestedPr_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_PRRequest_RequestId",
                table: "PrRequest",
                newName: "IX_PrRequest_RequestId");

            migrationBuilder.RenameColumn(
                name: "RequestedPRId",
                schema: "audit",
                table: "AuditRequestedPr",
                newName: "RequestedPrId");

            migrationBuilder.RenameColumn(
                name: "PRNumber",
                schema: "audit",
                table: "AuditRequestedPr",
                newName: "PrNumber");

            migrationBuilder.RenameColumn(
                name: "PRDescription",
                schema: "audit",
                table: "AuditRequestedPr",
                newName: "PrDescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestedPr",
                table: "RequestedPr",
                column: "RequestedPrId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrRequest",
                table: "PrRequest",
                column: "RequestNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditRequestedPr",
                schema: "audit",
                table: "AuditRequestedPr",
                column: "AuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditPrRequest",
                schema: "audit",
                table: "AuditPrRequest",
                column: "AuditId");

            migrationBuilder.AddForeignKey(
                name: "FK_PrRequest_Request",
                table: "PrRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestedPr_Request",
                table: "RequestedPr",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrRequest_Request",
                table: "PrRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestedPr_Request",
                table: "RequestedPr");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestedPr",
                table: "RequestedPr");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrRequest",
                table: "PrRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditRequestedPr",
                schema: "audit",
                table: "AuditRequestedPr");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditPrRequest",
                schema: "audit",
                table: "AuditPrRequest");

            migrationBuilder.RenameTable(
                name: "RequestedPr",
                newName: "RequestedPR");

            migrationBuilder.RenameTable(
                name: "PrRequest",
                newName: "PRRequest");

            migrationBuilder.RenameTable(
                name: "AuditRequestedPr",
                schema: "audit",
                newName: "AuditRequestedPR",
                newSchema: "audit");

            migrationBuilder.RenameTable(
                name: "AuditPrRequest",
                schema: "audit",
                newName: "AuditPRRequest",
                newSchema: "audit");

            migrationBuilder.RenameColumn(
                name: "PrNumber",
                table: "RequestedPR",
                newName: "PRNumber");

            migrationBuilder.RenameColumn(
                name: "PrDescription",
                table: "RequestedPR",
                newName: "PRDescription");

            migrationBuilder.RenameColumn(
                name: "RequestedPrId",
                table: "RequestedPR",
                newName: "RequestedPRId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestedPr_RequestId",
                table: "RequestedPR",
                newName: "IX_RequestedPR_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_PrRequest_RequestId",
                table: "PRRequest",
                newName: "IX_PRRequest_RequestId");

            migrationBuilder.RenameColumn(
                name: "RequestedPrId",
                schema: "audit",
                table: "AuditRequestedPR",
                newName: "RequestedPRId");

            migrationBuilder.RenameColumn(
                name: "PrNumber",
                schema: "audit",
                table: "AuditRequestedPR",
                newName: "PRNumber");

            migrationBuilder.RenameColumn(
                name: "PrDescription",
                schema: "audit",
                table: "AuditRequestedPR",
                newName: "PRDescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestedPR",
                table: "RequestedPR",
                column: "RequestedPRId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PRRequest",
                table: "PRRequest",
                column: "RequestNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditRequestedPR",
                schema: "audit",
                table: "AuditRequestedPR",
                column: "AuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditPRRequest",
                schema: "audit",
                table: "AuditPRRequest",
                column: "AuditId");

            migrationBuilder.AddForeignKey(
                name: "FK_PRRequest_Request",
                table: "PRRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestedPR_Request",
                table: "RequestedPR",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
