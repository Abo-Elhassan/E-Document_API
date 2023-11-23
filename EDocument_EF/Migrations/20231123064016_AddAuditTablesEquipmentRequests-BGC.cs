using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditTablesEquipmentRequestsBGC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditEquipmentRequestIn",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunicationFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedDateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedDateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Additionaltools = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AuditEquipmentRequestIn", x => x.AuditId);
                });

            migrationBuilder.CreateTable(
                name: "AuditEquipmentRequestOut",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunicationFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EquipmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedDateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedDateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Additionaltools = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupervisorPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AuditEquipmentRequestOut", x => x.AuditId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditEquipmentRequestIn",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditEquipmentRequestOut",
                schema: "audit");
        }
    }
}
