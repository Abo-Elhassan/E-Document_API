using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeExtentionNumberNullableInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                table: "VehicleRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                table: "TravelDeskRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                table: "DomainAccountRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                table: "CCTVAccessRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditVehicleRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditVehicleRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditTravelDeskRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditTravelDeskRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditDomainAccountRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditDomainAccountRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditCCTVAccessRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditCCTVAccessRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditApplicationUserRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditApplicationUserRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditAccessControlRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditAccessControlRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                table: "ApplicationUserRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BeneficiaryExtention",
                table: "AccessControlRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditVehicleRequest");

            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditTravelDeskRequest");

            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditDomainAccountRequest");

            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditCCTVAccessRequest");

            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditApplicationUserRequest");

            migrationBuilder.DropColumn(
                name: "BeneficiaryCompany",
                schema: "audit",
                table: "AuditAccessControlRequest");

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                table: "VehicleRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                table: "TravelDeskRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                table: "DomainAccountRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                table: "CCTVAccessRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditVehicleRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditTravelDeskRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditDomainAccountRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditCCTVAccessRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditApplicationUserRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                schema: "audit",
                table: "AuditAccessControlRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                table: "ApplicationUserRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryExtention",
                table: "AccessControlRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
