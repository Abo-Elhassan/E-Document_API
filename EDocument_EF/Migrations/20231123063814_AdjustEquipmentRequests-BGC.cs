using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AdjustEquipmentRequestsBGC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditEquipmentRequestIn",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "AuditEquipmentRequestOut",
                schema: "audit");

            migrationBuilder.RenameColumn(
                name: "OutConcessionArea",
                table: "EquipmentRequestOut",
                newName: "EquipmentType");

            migrationBuilder.RenameColumn(
                name: "Equipment",
                table: "EquipmentRequestOut",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "ConcernedEmployeeName",
                table: "EquipmentRequestOut",
                newName: "SupervisorName");

            migrationBuilder.RenameColumn(
                name: "ConcernedEmployeeId",
                table: "EquipmentRequestOut",
                newName: "SupervisorId");

            migrationBuilder.RenameColumn(
                name: "InConcessionArea",
                table: "EquipmentRequestIn",
                newName: "EquipmentType");

            migrationBuilder.RenameColumn(
                name: "Equipment",
                table: "EquipmentRequestIn",
                newName: "Area");

            migrationBuilder.RenameColumn(
                name: "ConcernedEmployeeName",
                table: "EquipmentRequestIn",
                newName: "SupervisorName");

            migrationBuilder.RenameColumn(
                name: "ConcernedEmployeeId",
                table: "EquipmentRequestIn",
                newName: "SupervisorId");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                table: "EquipmentRequestOut",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryDepartment",
                table: "EquipmentRequestOut",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryEmail",
                table: "EquipmentRequestOut",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BeneficiaryExtention",
                table: "EquipmentRequestOut",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryId",
                table: "EquipmentRequestOut",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryName",
                table: "EquipmentRequestOut",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryPhoneNumber",
                table: "EquipmentRequestOut",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryPosition",
                table: "EquipmentRequestOut",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisorPhoneNumber",
                table: "EquipmentRequestOut",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                table: "EquipmentRequestIn",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryDepartment",
                table: "EquipmentRequestIn",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryEmail",
                table: "EquipmentRequestIn",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BeneficiaryExtention",
                table: "EquipmentRequestIn",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryId",
                table: "EquipmentRequestIn",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryName",
                table: "EquipmentRequestIn",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryPhoneNumber",
                table: "EquipmentRequestIn",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryPosition",
                table: "EquipmentRequestIn",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupervisorPhoneNumber",
                table: "EquipmentRequestIn",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                table: "EquipmentRequestOut");

            migrationBuilder.DropColumn(
                name: "BeneficiaryDepartment",
                table: "EquipmentRequestOut");

            migrationBuilder.DropColumn(
                name: "BeneficiaryEmail",
                table: "EquipmentRequestOut");

            migrationBuilder.DropColumn(
                name: "BeneficiaryExtention",
                table: "EquipmentRequestOut");

            migrationBuilder.DropColumn(
                name: "BeneficiaryId",
                table: "EquipmentRequestOut");

            migrationBuilder.DropColumn(
                name: "BeneficiaryName",
                table: "EquipmentRequestOut");

            migrationBuilder.DropColumn(
                name: "BeneficiaryPhoneNumber",
                table: "EquipmentRequestOut");

            migrationBuilder.DropColumn(
                name: "BeneficiaryPosition",
                table: "EquipmentRequestOut");

            migrationBuilder.DropColumn(
                name: "SupervisorPhoneNumber",
                table: "EquipmentRequestOut");

            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                table: "EquipmentRequestIn");

            migrationBuilder.DropColumn(
                name: "BeneficiaryDepartment",
                table: "EquipmentRequestIn");

            migrationBuilder.DropColumn(
                name: "BeneficiaryEmail",
                table: "EquipmentRequestIn");

            migrationBuilder.DropColumn(
                name: "BeneficiaryExtention",
                table: "EquipmentRequestIn");

            migrationBuilder.DropColumn(
                name: "BeneficiaryId",
                table: "EquipmentRequestIn");

            migrationBuilder.DropColumn(
                name: "BeneficiaryName",
                table: "EquipmentRequestIn");

            migrationBuilder.DropColumn(
                name: "BeneficiaryPhoneNumber",
                table: "EquipmentRequestIn");

            migrationBuilder.DropColumn(
                name: "BeneficiaryPosition",
                table: "EquipmentRequestIn");

            migrationBuilder.DropColumn(
                name: "SupervisorPhoneNumber",
                table: "EquipmentRequestIn");

            migrationBuilder.RenameColumn(
                name: "SupervisorName",
                table: "EquipmentRequestOut",
                newName: "ConcernedEmployeeName");

            migrationBuilder.RenameColumn(
                name: "SupervisorId",
                table: "EquipmentRequestOut",
                newName: "ConcernedEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EquipmentType",
                table: "EquipmentRequestOut",
                newName: "OutConcessionArea");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "EquipmentRequestOut",
                newName: "Equipment");

            migrationBuilder.RenameColumn(
                name: "SupervisorName",
                table: "EquipmentRequestIn",
                newName: "ConcernedEmployeeName");

            migrationBuilder.RenameColumn(
                name: "SupervisorId",
                table: "EquipmentRequestIn",
                newName: "ConcernedEmployeeId");

            migrationBuilder.RenameColumn(
                name: "EquipmentType",
                table: "EquipmentRequestIn",
                newName: "InConcessionArea");

            migrationBuilder.RenameColumn(
                name: "Area",
                table: "EquipmentRequestIn",
                newName: "Equipment");

            migrationBuilder.CreateTable(
                name: "AuditEquipmentRequestIn",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    Additionaltools = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommunicationFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcernedEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcernedEmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InConcessionArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedDateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedDateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditEquipmentRequestIn", x => x.AuditId);
                    table.ForeignKey(
                        name: "FK_AuditEquipmentRequestIn_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuditEquipmentRequestOut",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    Additionaltools = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommunicationFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcernedEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcernedEmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutConcessionArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedDateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedDateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditEquipmentRequestOut", x => x.AuditId);
                    table.ForeignKey(
                        name: "FK_AuditEquipmentRequestOut_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditEquipmentRequestIn_RequestId",
                schema: "audit",
                table: "AuditEquipmentRequestIn",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditEquipmentRequestOut_RequestId",
                schema: "audit",
                table: "AuditEquipmentRequestOut",
                column: "RequestId");
        }
    }
}
