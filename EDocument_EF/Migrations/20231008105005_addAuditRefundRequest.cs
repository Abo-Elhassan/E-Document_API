using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addAuditRefundRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestType",
                table: "TravelDeskRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "MissionAddress",
                table: "TravelDeskRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CostAllocation",
                table: "TravelDeskRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "VendorName",
                table: "PoRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNumber",
                table: "PoRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "AuditPoRequests",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorNumber = table.Column<int>(type: "int", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoAttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceAttachmentPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AuditPoRequests", x => x.AuditId);
                });

            migrationBuilder.CreateTable(
                name: "AuditRefundRequests",
                columns: table => new
                {
                    AuditId = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefundSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefundDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefundType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShipmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedContainers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcernedEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcernedEmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AuditRefundRequests", x => x.AuditId);
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e1e3002-1710-4fe8-a299-d114bf9cd506", "27330278-e3e2-4e5f-8140-4cfd517420d6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "daa6bb5d-c4ab-4ba4-b429-627d565fead1", "9ba9c7cc-7b32-49fa-8597-3dac04bc8e56" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7be91d87-d998-4a9b-9627-f43444d2b00d", "feb20a7e-2112-4fae-9347-fcccf342b8b5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2195b094-dbe6-45c6-b9d1-d1bf0d69b6cb", "6c57406c-843c-4ab0-b85e-ff4b98291f61" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e289506-1967-4f0c-81f1-520a41ab7a84", "7d38c61d-953a-42ca-892e-40319fbb0ec3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea0c5dd4-fe14-4932-92e2-3e54d0ea7e9e", "0a9dff11-4b15-4120-b3b7-8a5cc73be4a9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "77cf5627-bab4-4744-aed4-e029fd51674f", "83116898-404b-4cd1-ab75-a10a4c7956d0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3154ec3f-91a4-4b31-8f84-ebe7b8ad0f85", "bd059540-1370-4c26-932b-29fba44ddb42" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecc4611a-c242-4890-9f6d-be2d55b3f6ad", "3508dee6-056e-4f3e-a4ef-b62a0979ede8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "732c3f5f-faff-4568-b1b7-395f13d48143", "7bce8218-b92b-4901-b540-224a5ab5030c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d092ffeb-3295-422d-bfbe-2eb1050bf9ac", "bcfcca3f-8ef1-4789-ae2c-05dac657296f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4be9165e-de1c-44c1-98fb-05204a3f3877", "5ddbb94c-3b8f-4571-b58e-e06f6900b443" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64842e5b-0393-43b3-ae8c-b76e6472a807", "debd96a0-6765-4216-aba7-5cdfea63426e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e4a121d8-c456-4b3c-9506-c06b67a49718", "4abc5563-593f-4bb0-8f82-bb5cfa749726" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ef2dddf-47c0-4e8c-bcf8-acd8df6164e2", "37419caf-5a3a-4119-a1b9-e06815dd6eb0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f6f07b3-d258-467c-b8c5-2c7fea410dc9", "01b46fc4-7587-44f7-9601-60ce6ff703de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fbbaf5ef-88dc-4aa5-a581-19883ca937f7", "5b4db75f-d0e6-4335-95ff-0a1583160c47" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8cace2f-8b51-4abd-8ad2-143b01125442", "906a4ceb-1a3a-4c99-84eb-7fe25d961121" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08b7aaec-2304-4cb5-8e65-82deb8869f53", "619ff9b1-692a-4964-956e-f2251e02a668" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4268d999-00ff-4661-b290-e794eed850c9", "32059d99-9d8e-4470-9d7a-e2e76c6c34df" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5cc719f-71f6-4ca3-8ec4-81d729a965b5", "6a12e1fe-31cb-47d9-a37a-8830419405f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8b3c3af-7e2f-4b12-bdf1-ecc703876924", "32df6263-0c55-41b7-be83-09d5b5e5d2ce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "935dd156-628f-40d3-83bf-6c0af087a402", "308f94eb-4b85-4555-bb8c-f2d36fbd922f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab2de35a-e235-41d4-bdb6-6862dbe91bcd", "7e4af483-2f28-46e1-b70a-17067044c064" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56b37b0e-7c9d-4fcd-8f32-4834e76526f7", "3c770202-8307-4929-ac74-4e9ab8edfd75" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "537f4d08-b405-4109-baba-d80ce55e822a", "0d9e4488-44aa-4a5f-9743-9e61b4ab1b38" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d15c7b73-271b-4f26-9844-edb320f9998e", "eecc72d7-87fb-4de9-8096-e3bf4688879b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c873420c-4571-4a7a-8f03-3504db01aa0e", "684a5ae7-e272-4c09-aae8-6cc2a2733d7d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f20bdc40-f830-47a5-88cc-d4c2fa168832", "6f45cc79-c275-4623-8aef-b94920731f5e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "305debc4-33d0-4eec-8a01-d80e209c6425", "84501f5a-8a35-4d77-9c8f-b66e2c180c33" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f17b8926-23b1-469a-8042-10cda11fe1af", "f2702a47-04b2-487a-9ca8-f6404e88bd6a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f39aec92-5bdb-48d7-9b67-cdc74fa2b5ea", "09cd6c8c-9bb6-4df6-951c-62d0c44a7606" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30a745f1-8d1b-4c50-ae56-55bc4787a210", "cc1c4609-67f7-4e18-a7a4-0c604a38f438" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d4a23dd-a852-497c-93d8-0df01a229dfd", "2500cef3-9ddc-4d1e-8bde-5f4c03ad8a43" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditPoRequests");

            migrationBuilder.DropTable(
                name: "AuditRefundRequests");

            migrationBuilder.AlterColumn<string>(
                name: "RequestType",
                table: "TravelDeskRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "MissionAddress",
                table: "TravelDeskRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CostAllocation",
                table: "TravelDeskRequest",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "VendorName",
                table: "PoRequest",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNumber",
                table: "PoRequest",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f1a5198-15b4-432e-a7df-398a6315c700", "ccae08fb-aa6b-4006-9164-1d62d68b8f2d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9969691-2e5f-4728-82fa-1902a6766ff1", "936b260a-dfc5-46eb-8a0f-9744e41253ab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5893211f-ad69-4233-a2bf-ef6be55d6ccc", "dfed7ec4-0500-4473-9442-f84658218077" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecfced50-78bf-4711-b761-ce6890345701", "ddf84de4-6261-4b8b-ab77-dccef1e97341" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02488f6f-05d4-45f1-bcaf-37be548fefce", "25207812-f939-46b2-94f4-f39775094d56" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8841c42d-9f59-4f08-9af6-6bc9776aacdd", "f29d505b-2c67-47be-b02b-8074ba2b0c5a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ea9547b-57ba-4d00-b95a-d375ff428c38", "2400160b-7cac-46ee-b269-02b0fd05aa14" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c25e6bd7-89bb-43db-9c9d-485428c5bfaa", "7b3d462c-782f-44ae-a11e-ad493f9a1601" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "075954d8-1d49-4a46-a142-399935f4cb4d", "0b29c08b-b96b-4c27-aa3d-fdcf05cac9f2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1bc0171-7c3d-4497-80b2-934fb2add0f7", "26845b98-876c-4458-ac39-511a6e7658b1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f61d8cb-6697-4e81-82a3-f44dfd174e60", "0c08e244-209e-4b6c-adc9-8e7f8199e0f3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92a24322-b40d-4f5e-a8c3-7ed732a800c0", "90ea25e1-e63a-4a59-8f6a-88ff8f38ab64" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9709419e-c4a6-4403-9aa2-d3b00ae6d7fc", "9903bd8f-cd5a-4b01-8d05-4c2c0f0d4575" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8098eca-5dc5-4851-9ce6-36bdc3bcb089", "f6d81fff-bc70-4297-95f2-5336bc387503" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63f9ac26-47d2-4b7d-94e2-2fda942778f7", "ac815506-1037-4ec3-8d5e-7f899f3cf0b2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b09a6d5-3d7e-4451-bc08-be943d25b2b6", "ecf10d86-fa79-472a-92fc-df7d9e084bbf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42fb68ea-c126-46d4-963c-64b5aa18d6d0", "36198217-4f73-4d7b-bd1a-e570564da0bf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ab42740-64fd-4a06-a051-21e1247081ab", "76025ec0-851a-4da6-8bb2-549d11f7a8a9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67558471-51d7-41d1-b2ae-4cc226471a0c", "9cd4208a-edc5-467a-a130-2e7b7093a1b4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8535588-d832-4459-a21c-c7c532fd8af3", "04f50e9b-8369-4b17-80a2-0d8db56ec90d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f00fe3c-ce60-4f97-b2d7-7187d2fcaba0", "7b834605-7925-4f71-87a7-b6eaa0bffee8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f25355d-8ca1-4e6e-8039-e6b15f440c90", "c0687894-04ad-4b2b-af15-19de8d672e41" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70e1faed-d5d4-4912-9ce1-bf63e244f338", "9a3c58cb-1957-412b-a3bf-e1a5bbd174b7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "65975ad3-b705-490c-be49-5b24b6da29f5", "4c772a39-4222-451a-98a7-f090dd0e2b93" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "691b7cb7-cc80-4894-b38e-abe84c4ff954", "f0f5828c-68e6-4b8b-829d-5e4bb28bf135" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2e1629a-4511-44e8-8948-be7f4d4c1d2a", "d1b1c5cd-c328-4a4b-8e7e-6b4305434334" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac5e348d-d9f9-48db-950f-4912c32aeb6b", "d621e171-fee4-4395-8e33-7fd4df12169c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f073fefe-2960-45d2-a5cf-86df0f4fd4fe", "b4123d9b-07dd-4c17-8119-5fad6218ffeb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20389da3-0f0a-4db5-b5fe-9a64cdf72011", "983ce519-2f1e-4739-b468-a4a9e40958da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a00585ba-8d10-48d6-bb3c-81d942735f48", "640aa347-dfdb-4a6d-b020-5bb86fb22446" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d71c3d3-1297-4cfe-9dcc-d67fe0953f1b", "f7b646c0-29e7-4573-be22-23f2304ee6cc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a46d9f3-acc6-49a9-b83a-3085bbff64bf", "06c0e67a-de82-4854-ac84-a7856e7795be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8084d68-7e77-4555-aeec-717acfbd5f5c", "bc0c362d-0b1b-4baa-9e27-15ab490b8d88" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3f85627-f449-43d8-af88-144057fb2e57", "f23ad7d8-cfb7-4fbc-b3f1-bc959b9731f0" });
        }
    }
}
