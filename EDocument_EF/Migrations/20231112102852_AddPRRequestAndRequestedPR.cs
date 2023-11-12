using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AddPRRequestAndRequestedPR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ItemNumber",
                table: "RequestedItem",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AuditPRRequest",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AFENumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AuditPRRequest", x => x.AuditId);
                });

            migrationBuilder.CreateTable(
                name: "AuditRequestedPR",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestedPRId = table.Column<long>(type: "bigint", nullable: false),
                    PRNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PRDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BudgetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditRequestedPR", x => x.AuditId);
                });

            migrationBuilder.CreateTable(
                name: "PRRequest",
                columns: table => new
                {
                    RequestNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PRSubject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ItemNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AFENumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
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
                    table.PrimaryKey("PK_PRRequest", x => x.RequestNumber);
                    table.ForeignKey(
                        name: "FK_PRRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestedPR",
                columns: table => new
                {
                    RequestedPRId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequestNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequestType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PRDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BudgetType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    ModifiedBy = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestedPR", x => x.RequestedPRId);
                    table.ForeignKey(
                        name: "FK_RequestedPR_PRRequest",
                        column: x => x.RequestNumber,
                        principalTable: "PRRequest",
                        principalColumn: "RequestNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRRequest_RequestId",
                table: "PRRequest",
                column: "RequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestedPR_RequestNumber",
                table: "RequestedPR",
                column: "RequestNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditPRRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditRequestedPR",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "RequestedPR");

            migrationBuilder.DropTable(
                name: "PRRequest");

            migrationBuilder.AlterColumn<string>(
                name: "ItemNumber",
                table: "RequestedItem",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
