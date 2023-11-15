using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class LinkRequestedPR_RequestedItem_With_RequestId_Instead_Of_RequestNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequestedItem_NewItemRequest",
                table: "RequestedItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestedPR_PRRequest",
                table: "RequestedPR");

            migrationBuilder.DropIndex(
                name: "IX_RequestedPR_RequestNumber",
                table: "RequestedPR");

            migrationBuilder.DropIndex(
                name: "IX_RequestedItem_RequestNumber",
                table: "RequestedItem");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "RequestedPR");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "RequestedItem");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                schema: "audit",
                table: "AuditRequestedPR");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                schema: "audit",
                table: "AuditRequestedItem");


            migrationBuilder.AddColumn<long>(
                name: "RequestId",
                table: "RequestedPR",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);


            migrationBuilder.AddColumn<long>(
                name: "RequestId",
                table: "RequestedItem",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RequestId",
                schema: "audit",
                table: "AuditRequestedPR",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RequestId",
                schema: "audit",
                table: "AuditRequestedItem",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);



            migrationBuilder.CreateIndex(
                name: "IX_RequestedPR_RequestId",
                table: "RequestedPR",
                column: "RequestId");



            migrationBuilder.CreateIndex(
                name: "IX_RequestedItem_RequestId",
                table: "RequestedItem",
                column: "RequestId");



            migrationBuilder.AddForeignKey(
                name: "FK_RequestedItem_Request",
                table: "RequestedItem",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.DropForeignKey(
                name: "FK_RequestedItem_Request",
                table: "RequestedItem");



            migrationBuilder.DropForeignKey(
                name: "FK_RequestedPR_Request",
                table: "RequestedPR");



            migrationBuilder.DropIndex(
                name: "IX_RequestedPR_RequestId",
                table: "RequestedPR");



            migrationBuilder.DropIndex(
                name: "IX_RequestedItem_RequestId",
                table: "RequestedItem");


            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "RequestedPR");


            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "RequestedItem");

            migrationBuilder.DropColumn(
                name: "RequestId",
                schema: "audit",
                table: "AuditRequestedPR");

            migrationBuilder.DropColumn(
                name: "RequestId",
                schema: "audit",
                table: "AuditRequestedItem");

            migrationBuilder.AddColumn<string>(
                name: "RequestNumber",
                table: "RequestedPR",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestNumber",
                table: "RequestedItem",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestNumber",
                schema: "audit",
                table: "AuditRequestedPR",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RequestNumber",
                schema: "audit",
                table: "AuditRequestedItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestedPR_RequestNumber",
                table: "RequestedPR",
                column: "RequestNumber");

            migrationBuilder.CreateIndex(
                name: "IX_RequestedItem_RequestNumber",
                table: "RequestedItem",
                column: "RequestNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_RequestedItem_NewItemRequest",
                table: "RequestedItem",
                column: "RequestNumber",
                principalTable: "NewItemRequest",
                principalColumn: "RequestNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestedPR_PRRequest",
                table: "RequestedPR",
                column: "RequestNumber",
                principalTable: "PRRequest",
                principalColumn: "RequestNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
