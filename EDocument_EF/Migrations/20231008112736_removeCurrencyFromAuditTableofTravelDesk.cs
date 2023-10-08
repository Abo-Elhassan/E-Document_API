using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class removeCurrencyFromAuditTableofTravelDesk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                schema: "audit",
                table: "AuditTravelDeskRequest");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15dfd0ee-4089-4c87-9728-2e2977435c6d", "e0ee4559-a585-496a-8bc1-758f74d65263" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ece4034-fb0c-44fe-97d2-1de7144d8196", "2059821c-d394-42a2-a009-4aaea9e0dcb7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74686b96-a811-4670-8adb-46cef42e6eb1", "8c2d2024-a3ea-4480-8f8d-20d15aa2583f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36515b8a-07f6-453f-9eb8-1e85232ad6aa", "b5eba13f-8e73-4a74-987c-b1686f00ac15" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "abfdfb9e-8515-436d-8ec7-d025cae17271", "1d42bc82-65fe-4712-b0c2-77646589a1b7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e54df7a6-8be2-4308-b026-17302139984d", "5001970d-7892-429d-b043-923f5c2c4af1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2affdd20-0841-497e-b0fe-754f18a5d8b8", "38e9b254-5cc3-4bc1-8138-16187fd301d9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdd09999-59ff-4df5-a5d4-2b5e4d8cb8b7", "14de375f-c695-4384-ad12-03162319d455" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b414ab78-4a98-4e45-b7ff-ce8ce4653b58", "48fbbc79-70e4-4358-b129-5583817cd134" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd7c11b9-6d6b-4554-aaff-28790e6627a9", "12bf6efc-4a5d-47af-9e35-09628eea9744" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d3ab168-3d4d-4c8d-8705-4323d5a38f5e", "58046199-b21c-4fe1-80b9-24615e26bdb3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e0aebd7-88a5-4407-bf00-3a6407dd767a", "545a873d-2f3f-4b71-a36a-5a582c4d9249" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "18d353ce-28a0-440b-8d23-67688c93bcb9", "baf4143a-6732-48b9-8d4f-2739c08b0fd3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe4d2d70-7a52-438a-8e2a-9c34700fb288", "db8541c8-c8c0-460e-83eb-fb90ab25e054" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5cface5-2cfa-4094-aff1-a9dcd12e12ad", "3ce98a3c-17bf-4a92-a9d0-f1f0853afff0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87c0eb8b-4009-4fa9-97f2-2037c865c25d", "588a29b5-1e4b-4248-8c66-099edcbabfe8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2eabc1a2-2ace-476e-bed0-40a47423abd4", "96768642-2cf1-4bd8-8d7f-8ae98ed10ddf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9d6a0a41-86ec-4613-8a54-8d692d9b7438", "217c44e4-e9b2-4c88-8670-bf02e2caba19" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62f2ef9f-a8cc-4c26-adbd-28b8a599f582", "cf85675f-5fe7-481e-b914-22bab8e19b2f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e040d9a1-fc5b-4350-8ec3-5b65dc0e38e8", "2669dc9e-769a-4517-b280-96728bdaaf81" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c4bff47-142c-45f1-bd6a-93b08b406b1c", "c006959b-a843-4ecb-a4c4-5f3ee4c6485b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d1e1dd5-fe93-4248-aa35-7423c26050d3", "7dbbfb40-b028-4259-be88-29252dc576d6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7503c515-e1d5-4477-82cd-d25b7988fa29", "c3b465b0-023f-42c5-a867-9516bdc85d64" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d3f81331-8318-44e6-9f8c-b22bc1182310", "cefb9979-fc30-41b3-bd79-47374a216491" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "683c8f4a-8a1a-4206-84e0-defabd111df8", "50d5456e-92b4-4d65-bd1c-5befc68a4ad0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "308f115a-b3b9-4203-a5d8-e09784f37068", "a1c4b554-2d55-44db-a5e2-91ba285e2ab7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "161d3566-c148-45fe-a506-d7c722918e4f", "5e54f08c-2ddf-43b8-a159-2a415cd65111" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c83596c1-6ea9-4420-8aa7-fb9c993cdb33", "3e20d1de-879b-43de-99bc-b03926465f28" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3be7fc85-401f-462f-8f54-37ee1468159c", "27437bd9-ae83-44ad-abd7-bd1c800e5e6b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85e4b992-eb9d-41e7-aa43-ece133cf69af", "21ad56d2-4ed0-4b9f-a4eb-7ee1bae76c72" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bf3fdbe2-71ad-4386-a80f-b6297113be19", "56d6aa9f-b5ed-439b-a114-aeaf0acfe658" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9811cd6-7c11-4f3f-a9eb-e7c580caa1d1", "59e5f88e-e2c0-439c-a4e1-75415bdec2d9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55564a0e-5bb8-45a5-b642-910f6c1be2f9", "389eb520-d1b6-4bc5-8062-1808d5bb6aff" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdb41f41-dbac-4f3a-af80-7311868e646e", "021ed0be-76fb-4777-9a13-975111d9b66b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Currency",
                schema: "audit",
                table: "AuditTravelDeskRequest",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
