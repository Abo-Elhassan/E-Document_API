using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeInvoiceNumberUniqueForFuelOilReq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_FuelOilInvoiceRequest_InvoiceNumber",
                table: "FuelOilInvoiceRequest",
                column: "InvoiceNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FuelOilInvoiceRequest_InvoiceNumber",
                table: "FuelOilInvoiceRequest");
        }
    }
}
