using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeVehicleRequestPkLenghtequal50 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest");

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                table: "VehicleRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest",
                column: "RequestNumber");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRequest_RequestId",
                table: "VehicleRequest",
                column: "RequestId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRequest_RequestId",
                table: "VehicleRequest");

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                table: "VehicleRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest",
                column: "RequestId");
        }
    }
}
