using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addReschedulePmWoRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditReschedulePmWoRequest",
                schema: "audit",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionOfChange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForRescheduling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RescheduleFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RescheduleTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WoNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AuditReschedulePmWoRequest", x => x.AuditId);
                });

            migrationBuilder.CreateTable(
                name: "ReschedulePmWoRequest",
                columns: table => new
                {
                    RequestNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DescriptionOfChange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReasonForRescheduling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RescheduleFrom = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    RescheduleTo = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    WoNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReschedulePmWoRequest", x => x.RequestNumber);
                    table.ForeignKey(
                        name: "FK_ReschedulePmWoRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReschedulePmWoRequest_RequestId",
                table: "ReschedulePmWoRequest",
                column: "RequestId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditReschedulePmWoRequest",
                schema: "audit");

            migrationBuilder.DropTable(
                name: "ReschedulePmWoRequest");
        }
    }
}
