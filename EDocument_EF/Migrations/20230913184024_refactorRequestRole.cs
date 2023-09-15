using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class refactorRequestRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "DefinedRequestRole",
                type: "smalldatetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DefinedRequestRole",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "DefinedRequestRole",
                type: "smalldatetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "DefinedRequestRole",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Permission",
                table: "DefinedRequestRole",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "DefinedRequestRole");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DefinedRequestRole");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "DefinedRequestRole");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "DefinedRequestRole");

            migrationBuilder.DropColumn(
                name: "Permission",
                table: "DefinedRequestRole");
        }
    }
}
