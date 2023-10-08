using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class renameRefundandPoAuditTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditRefundRequests",
                table: "AuditRefundRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditPoRequests",
                table: "AuditPoRequests");

            migrationBuilder.RenameTable(
                name: "AuditRefundRequests",
                newName: "AuditRefundRequest",
                newSchema: "audit");

            migrationBuilder.RenameTable(
                name: "AuditPoRequests",
                newName: "AuditPoRequest",
                newSchema: "audit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditRefundRequest",
                schema: "audit",
                table: "AuditRefundRequest",
                column: "AuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditPoRequest",
                schema: "audit",
                table: "AuditPoRequest",
                column: "AuditId");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef15f2fe-f60a-4300-8110-e1476e3d13c3", "0458ec97-1e2f-4e59-b344-ba56a5f64cd9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "adeb7b01-db38-47d2-8bfe-1826b1b29d04", "53da9c1f-b34f-49bf-9a37-c4269e05ee2e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5db390ac-e697-49b1-93b0-6b7fd7864ce4", "e0629849-d073-4172-b75b-78e90688a86f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8f80186-1cc7-43fa-ae4b-c8afe730e3f0", "60157d32-9138-4711-9420-0caa40e0bbbb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "315e3c4d-73e5-489b-a5ea-2281f95311c5", "a5753d16-c43d-4ccf-85c2-b63dfc26ca09" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f4555a9-7e9f-44bb-80f5-cbfde1816ec0", "c7d6bc1f-4558-4378-8b6d-641a765b480f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c4ae57f-b027-42f9-9b81-d3c5e91f97e8", "9b3bf15e-e225-4a04-bc77-196bba576821" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef808c26-964f-401b-a9d6-96d4ee4c2f6a", "153e5a05-f9e4-4194-ae7b-47e9dbf164b2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0680d753-a4cd-47eb-ad79-6ad255686610", "7a0acc50-d492-474d-ad13-1c19dd7cc0de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23832b7b-a48a-4487-8302-6a868aaf6cd8", "9e5966cb-cd57-4d92-88fa-43866a423e77" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1bad1e1-a6ba-4cbf-b016-d699f654dad4", "351b6b23-1112-44b6-ad58-8f63f216bb73" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42e65f3f-9e09-4bcf-a5a6-9ac69c4098ee", "fc12392e-7fc1-4fe2-a3ee-fb4352426237" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee976560-6300-4273-a129-5309f420869a", "6462ffea-0597-48e6-ba39-0f75cea31609" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "75e53524-572b-4188-8e7a-ed6cdd884a1d", "bc8e6f8d-9627-4065-989a-879ba8e7b4a0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eace6bb2-b420-4ff0-80fa-78e30fedb1a2", "df1d8a5b-4705-40d7-b894-6c7e7b3d0860" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e904ed8c-253c-429e-a284-63c9c11b224f", "f3453846-4a94-4a39-bec3-d239b60180fb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9e4224f-b1c7-4b80-b156-2545920e1c31", "c4db8263-67c0-41a0-8518-543b379612fd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec95eb6a-c665-45b2-be0b-298ac5094469", "f2a0f762-2168-49b9-91a9-5dc21f14da84" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c8d3c92-0442-442e-8a6c-e0c59c36860a", "2ca0c54f-685f-406a-9be7-28dcce1da525" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b84bc746-9c9e-4e97-bd36-9c96c9c736f1", "a69cd0c3-4989-47d8-a52e-b5102a5b711d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31847f3b-1e5f-4308-98ce-01f7bd31dfa7", "2e2f3262-e644-4a56-afc8-4657ca93aee5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1530b77-e7ac-4acd-832a-5f158b444e79", "d319dc48-883f-4979-bad0-8bbfa52dc815" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a9688dd-8490-4295-bd2d-c29501015985", "85a9e84b-2f33-4cf8-a7b5-7ba72e91cf18" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1525064a-a89c-4826-8d0a-98e191ed95d7", "4f5d0ca1-0059-4569-a445-21e9e9d85690" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1868fb8-06ff-4328-9316-30b1ecc4b7d4", "9c65abc5-cfc1-4cff-a150-76fabade6af4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69401608-e851-41c3-bd7a-820533c726e3", "f683c7a0-8968-4a7f-bebb-500340dc93a5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dc08b7dc-99b2-427b-a74f-ef2bc5803592", "dc371ba4-03c3-4054-8eb0-2b02350cc7d5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b52c7f1f-2978-434c-947a-d8a97ea867ae", "83b6d281-2c05-4ee9-a526-e7950d2d81b9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "234e9f04-9050-4be1-af9e-f383e989fc24", "d0fddf2e-af0b-4682-8b3b-d24ed205cde5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df89f09c-6ab4-4bb3-9e8a-9b7eb49375e5", "1a7970c5-bd33-428d-a696-d652ee364654" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "add5e14f-fa63-483f-9476-002158d756a1", "6d9e3ae2-ffbf-4f4d-b0de-6aefb5e06a86" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8d85ddd-8d3b-46a6-885c-05bc1cf9873c", "7ff4582c-f596-4d47-a42d-26b7a320d68f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "364e0d10-9d97-45b3-87f0-e9bbda926391", "f2b4f586-bf49-4f6a-a7ef-d2c8f686019d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c357e3f6-0662-4556-8f91-e45c3635a388", "1a318fef-66ef-4543-acd1-c59d25e10569" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditRefundRequest",
                schema: "audit",
                table: "AuditRefundRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AuditPoRequest",
                schema: "audit",
                table: "AuditPoRequest");

            migrationBuilder.RenameTable(
                name: "AuditRefundRequest",
                schema: "audit",
                newName: "AuditRefundRequests");

            migrationBuilder.RenameTable(
                name: "AuditPoRequest",
                schema: "audit",
                newName: "AuditPoRequests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditRefundRequests",
                table: "AuditRefundRequests",
                column: "AuditId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuditPoRequests",
                table: "AuditPoRequests",
                column: "AuditId");

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
    }
}
