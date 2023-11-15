using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class migrateDelegationFromRequestReviewerToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DelegatedReviewerId",
                table: "DefinedRequestReviewer");

            migrationBuilder.DropColumn(
                name: "DelegatedUntil",
                table: "DefinedRequestReviewer");

            migrationBuilder.DropColumn(
                name: "DelegatedReviewerId",
                schema: "audit",
                table: "AuditDefinedRequestReviewer");

            migrationBuilder.DropColumn(
                name: "DelegatedUntil",
                schema: "audit",
                table: "AuditDefinedRequestReviewer");

            migrationBuilder.AddColumn<DateTime>(
                name: "DelegatedUntil",
                schema: "security",
                table: "User",
                type: "smalldatetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelegatedUserId",
                schema: "security",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DelegatedUntil",
                schema: "audit",
                table: "AuditUser",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelegatedUserId",
                schema: "audit",
                table: "AuditUser",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DelegatedUntil",
                schema: "security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DelegatedUserId",
                schema: "security",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DelegatedUntil",
                schema: "audit",
                table: "AuditUser");

            migrationBuilder.DropColumn(
                name: "DelegatedUserId",
                schema: "audit",
                table: "AuditUser");

            migrationBuilder.AddColumn<string>(
                name: "DelegatedReviewerId",
                table: "DefinedRequestReviewer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DelegatedUntil",
                table: "DefinedRequestReviewer",
                type: "smalldatetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelegatedReviewerId",
                schema: "audit",
                table: "AuditDefinedRequestReviewer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DelegatedUntil",
                schema: "audit",
                table: "AuditDefinedRequestReviewer",
                type: "datetime2",
                nullable: true);
        }
    }
}
