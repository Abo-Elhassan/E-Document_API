using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addBenificaryComapnyInVehicleAndTravelDesk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                table: "VehicleRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                table: "TravelDeskRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                table: "DomainAccountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                table: "ApplicationUserRequest",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                table: "VehicleRequest");

            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                table: "TravelDeskRequest");

            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                table: "DomainAccountRequest");

            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                table: "ApplicationUserRequest");
        }
    }
}
