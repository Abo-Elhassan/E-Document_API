using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AuditTableOperationsRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditEquipmentRequestIns",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunicationFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InConcessionArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedDateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedDateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcernedEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcernedEmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_AuditEquipmentRequestIns", x => x.AuditId);
                    table.ForeignKey(
                        name: "FK_AuditEquipmentRequestIns_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuditEquipmentRequestOuts",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommunicationFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InConcessionArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedDateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedDateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcernedEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcernedEmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_AuditEquipmentRequestOuts", x => x.AuditId);
                    table.ForeignKey(
                        name: "FK_AuditEquipmentRequestOuts_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditEquipmentRequestIns_RequestId",
                table: "AuditEquipmentRequestIns",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditEquipmentRequestOuts_RequestId",
                table: "AuditEquipmentRequestOuts",
                column: "RequestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditEquipmentRequestIns");

            migrationBuilder.DropTable(
                name: "AuditEquipmentRequestOuts");
        }
    }
}
