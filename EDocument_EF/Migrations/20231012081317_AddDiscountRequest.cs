using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AddDiscountRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuditDiscountRequest_Request_RequestId",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropIndex(
                name: "IX_AuditDiscountRequest_RequestId",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "DiscountRequest");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "DiscountRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AgreementName",
                table: "DiscountRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContainerNumbers",
                table: "DiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerType",
                table: "DiscountRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "DiscountAmount",
                table: "DiscountRequest",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "DiscountReason",
                table: "DiscountRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DiscountType",
                table: "DiscountRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DocumentNumber",
                table: "DiscountRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DocumentType",
                table: "DiscountRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InvoiceNumber",
                table: "DiscountRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TaxId",
                table: "DiscountRequest",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "AgreementName",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContainerNumbers",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerType",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DiscountAmount",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "DiscountReason",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiscountType",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentNumber",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentType",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasCommercialAgreement",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceNumber",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxId",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContainerNumbers",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "CustomerType",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "DiscountReason",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "DiscountType",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "DocumentNumber",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "DiscountRequest");

            migrationBuilder.DropColumn(
                name: "AgreementName",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "ContainerNumbers",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "CustomerType",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "DiscountReason",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "DiscountType",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "DocumentNumber",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "HasCommercialAgreement",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "InvoiceNumber",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.DropColumn(
                name: "TaxId",
                schema: "audit",
                table: "AuditDiscountRequest");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "DiscountRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "AgreementName",
                table: "DiscountRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "DiscountRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                schema: "audit",
                table: "AuditDiscountRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuditDiscountRequest_RequestId",
                schema: "audit",
                table: "AuditDiscountRequest",
                column: "RequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_AuditDiscountRequest_Request_RequestId",
                schema: "audit",
                table: "AuditDiscountRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
