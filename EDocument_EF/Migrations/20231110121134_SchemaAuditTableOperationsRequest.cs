using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class SchemaAuditTableOperationsRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditEquipmentRequestIns_Request_RequestId",
                table: "AuditEquipmentRequestIns");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditEquipmentRequestOuts_Request_RequestId",
                table: "AuditEquipmentRequestOuts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditEquipmentRequestOuts",
                table: "AuditEquipmentRequestOuts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditEquipmentRequestIns",
                table: "AuditEquipmentRequestIns");

            migrationBuilder.RenameTable(
                name: "AuditEquipmentRequestOuts",
                newName: "AuditEquipmentRequestOut",
                newSchema: "audit");

            migrationBuilder.RenameTable(
                name: "AuditEquipmentRequestIns",
                newName: "AuditEquipmentRequestIn",
                newSchema: "audit");

            migrationBuilder.RenameIndex(
                name: "IX_AuditEquipmentRequestOuts_RequestId",
                schema: "audit",
                table: "AuditEquipmentRequestOut",
                newName: "IX_AuditEquipmentRequestOut_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditEquipmentRequestIns_RequestId",
                schema: "audit",
                table: "AuditEquipmentRequestIn",
                newName: "IX_AuditEquipmentRequestIn_RequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditEquipmentRequestOut",
                schema: "audit",
                table: "AuditEquipmentRequestOut",
                column: "AuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditEquipmentRequestIn",
                schema: "audit",
                table: "AuditEquipmentRequestIn",
                column: "AuditId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditEquipmentRequestIn_Request_RequestId",
                schema: "audit",
                table: "AuditEquipmentRequestIn",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditEquipmentRequestOut_Request_RequestId",
                schema: "audit",
                table: "AuditEquipmentRequestOut",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditEquipmentRequestIn_Request_RequestId",
                schema: "audit",
                table: "AuditEquipmentRequestIn");

            migrationBuilder.DropForeignKey(
                name: "FK_AuditEquipmentRequestOut_Request_RequestId",
                schema: "audit",
                table: "AuditEquipmentRequestOut");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditEquipmentRequestOut",
                schema: "audit",
                table: "AuditEquipmentRequestOut");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditEquipmentRequestIn",
                schema: "audit",
                table: "AuditEquipmentRequestIn");

            migrationBuilder.RenameTable(
                name: "AuditEquipmentRequestOut",
                schema: "audit",
                newName: "AuditEquipmentRequestOuts");

            migrationBuilder.RenameTable(
                name: "AuditEquipmentRequestIn",
                schema: "audit",
                newName: "AuditEquipmentRequestIns");

            migrationBuilder.RenameIndex(
                name: "IX_AuditEquipmentRequestOut_RequestId",
                table: "AuditEquipmentRequestOuts",
                newName: "IX_AuditEquipmentRequestOuts_RequestId");

            migrationBuilder.RenameIndex(
                name: "IX_AuditEquipmentRequestIn_RequestId",
                table: "AuditEquipmentRequestIns",
                newName: "IX_AuditEquipmentRequestIns_RequestId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditEquipmentRequestOuts",
                table: "AuditEquipmentRequestOuts",
                column: "AuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditEquipmentRequestIns",
                table: "AuditEquipmentRequestIns",
                column: "AuditId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditEquipmentRequestIns_Request_RequestId",
                table: "AuditEquipmentRequestIns",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuditEquipmentRequestOuts_Request_RequestId",
                table: "AuditEquipmentRequestOuts",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
