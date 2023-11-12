using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class OperationsRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentRequestIn",
                columns: table => new
                {
                    RequestNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommunicationFacility = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    InConcessionArea = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    RequestedDateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedDateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcernedEmployeeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConcernedEmployeeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentRequestIn", x => x.RequestNumber);
                    table.ForeignKey(
                        name: "FK_EquipmentRequestIn_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentRequestOut",
                columns: table => new
                {
                    RequestNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CommunicationFacility = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    OutConcessionArea = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    RequestedDateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestedDateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcernedEmployeeId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConcernedEmployeeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentRequestOut", x => x.RequestNumber);
                    table.ForeignKey(
                        name: "FK_EquipmentRequestOut_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentRequestIn_RequestId",
                table: "EquipmentRequestIn",
                column: "RequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentRequestOut_RequestId",
                table: "EquipmentRequestOut",
                column: "RequestId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentRequestIn");

            migrationBuilder.DropTable(
                name: "EquipmentRequestOut");
        }
    }
}
