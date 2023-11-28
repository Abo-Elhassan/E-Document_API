using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class RemoveVoucherRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditVoucherRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "VoucherRequest");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditVoucherRequest",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherAmount = table.Column<float>(type: "real", nullable: false),
                    VoucherCurrency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditVoucherRequest", x => x.AuditId);
                });

            migrationBuilder.CreateTable(
                name: "VoucherRequest",
                columns: table => new
                {
                    BeneficiaryName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceDate = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoucherAmount = table.Column<float>(type: "real", nullable: false),
                    VoucherCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoucherType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherRequest", x => new { x.BeneficiaryName, x.RequestId });
                    table.ForeignKey(
                        name: "FK_VoucherRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VoucherRequest_RequestId",
                table: "VoucherRequest",
                column: "RequestId",
                unique: true);
        }
    }
}
