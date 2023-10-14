using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeDocumentNbrAndInvoiceNumberUniquinDiscount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DiscountRequest_DocumentNumber",
                table: "DiscountRequest",
                column: "DocumentNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiscountRequest_InvoiceNumber",
                table: "DiscountRequest",
                column: "InvoiceNumber",
                unique: true,
                filter: "[InvoiceNumber] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DiscountRequest_DocumentNumber",
                table: "DiscountRequest");

            migrationBuilder.DropIndex(
                name: "IX_DiscountRequest_InvoiceNumber",
                table: "DiscountRequest");
        }
    }
}
