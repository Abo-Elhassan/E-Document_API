using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class restructureNewItemAndRequestedItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipmentType",
                table: "NewItemRequest");

            migrationBuilder.DropColumn(
                name: "ItemDescription",
                table: "NewItemRequest");

            migrationBuilder.DropColumn(
                name: "Manufacturing",
                table: "NewItemRequest");

            migrationBuilder.DropColumn(
                name: "PartNumber",
                table: "NewItemRequest");

            migrationBuilder.DropColumn(
                name: "EquipmentType",
                schema: "audit",
                table: "AuditNewItemRequest");

            migrationBuilder.DropColumn(
                name: "ItemDescription",
                schema: "audit",
                table: "AuditNewItemRequest");

            migrationBuilder.DropColumn(
                name: "Manufacturing",
                schema: "audit",
                table: "AuditNewItemRequest");

            migrationBuilder.DropColumn(
                name: "PartNumber",
                schema: "audit",
                table: "AuditNewItemRequest");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentType",
                table: "RequestedItem",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ItemDescription",
                table: "RequestedItem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturing",
                table: "RequestedItem",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNumber",
                table: "RequestedItem",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentType",
                schema: "audit",
                table: "AuditRequestedItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemDescription",
                schema: "audit",
                table: "AuditRequestedItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturing",
                schema: "audit",
                table: "AuditRequestedItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNumber",
                schema: "audit",
                table: "AuditRequestedItem",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipmentType",
                table: "RequestedItem");

            migrationBuilder.DropColumn(
                name: "ItemDescription",
                table: "RequestedItem");

            migrationBuilder.DropColumn(
                name: "Manufacturing",
                table: "RequestedItem");

            migrationBuilder.DropColumn(
                name: "PartNumber",
                table: "RequestedItem");

            migrationBuilder.DropColumn(
                name: "EquipmentType",
                schema: "audit",
                table: "AuditRequestedItem");

            migrationBuilder.DropColumn(
                name: "ItemDescription",
                schema: "audit",
                table: "AuditRequestedItem");

            migrationBuilder.DropColumn(
                name: "Manufacturing",
                schema: "audit",
                table: "AuditRequestedItem");

            migrationBuilder.DropColumn(
                name: "PartNumber",
                schema: "audit",
                table: "AuditRequestedItem");

            migrationBuilder.AddColumn<string>(
                name: "EquipmentType",
                table: "NewItemRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ItemDescription",
                table: "NewItemRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturing",
                table: "NewItemRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNumber",
                table: "NewItemRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EquipmentType",
                schema: "audit",
                table: "AuditNewItemRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemDescription",
                schema: "audit",
                table: "AuditNewItemRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturing",
                schema: "audit",
                table: "AuditNewItemRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNumber",
                schema: "audit",
                table: "AuditNewItemRequest",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
