using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AddVoucherRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditVoucherRequest",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorNumber = table.Column<int>(type: "int", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    AmountInWords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeneficiaryExtention = table.Column<int>(type: "int", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditVoucherRequest", x => x.AuditId);
                });

            migrationBuilder.CreateTable(
                name: "VoucherRequest",
                columns: table => new
                {
                    RequestNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VendorNumber = table.Column<int>(type: "int", nullable: false),
                    VendorName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    AmountInWords = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Currency = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryPosition = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryCompany = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryPhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryExtention = table.Column<int>(type: "int", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoucherRequest", x => x.RequestNumber);
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditVoucherRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "VoucherRequest");
        }
    }
}
