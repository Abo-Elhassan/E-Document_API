using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addPmJpRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditPmJpRequest",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionOfChange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PmJpCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentInterval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewInterval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedMaterials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemovedMaterials = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedLaborCraft = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemovedLaborCraft = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedTask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemovedTask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedMeter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemovedMeter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PmPriority = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_AuditPmJpRequest", x => x.AuditId);
                });

            migrationBuilder.CreateTable(
                name: "PmJpRequest",
                columns: table => new
                {
                    RequestNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DescriptionOfChange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    EndDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    PmJpCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AssetType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AssetCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrentInterval = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NewInterval = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddedMaterials = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RemovedMaterials = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AddedLaborCraft = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RemovedLaborCraft = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AddedTask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RemovedTask = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddedMeter = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RemovedMeter = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PmPriority = table.Column<int>(type: "int", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PmJpRequest", x => x.RequestNumber);
                    table.ForeignKey(
                        name: "FK_PmJpRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PmJpRequest_RequestId",
                table: "PmJpRequest",
                column: "RequestId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditPmJpRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "PmJpRequest");
        }
    }
}
