using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class updateUsersDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "6081e33a-3e1e-491e-ad77-5252ebbfec01");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "19cb41df-c4f6-4104-8291-3e928f1ca1e9");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "10",
                column: "ConcurrencyStamp",
                value: "c38ef1b7-40d6-4636-a6c2-2d6ef748f28b");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "11",
                column: "ConcurrencyStamp",
                value: "869dbd17-c62e-45aa-be2d-1e6c9260a059");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "12",
                column: "ConcurrencyStamp",
                value: "3ac48a26-bb24-4637-9c3a-f5be3258f2f0");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a69bf47c-1425-4940-ba1c-64332d1c4d53");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "7a3c811c-7035-4c51-9f5a-4e8d152f96fd");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "ca6f6b1f-4867-4a18-8edf-0480d521b196");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "6125de1a-5c68-4f09-8f49-534f09f024b3");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "306169ea-bee3-4f58-8cb0-9612c32b5db9");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "ccd03a53-895a-4ea1-8d9b-0a2a56acfd8a");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8",
                column: "ConcurrencyStamp",
                value: "d3c70f64-1fcb-4cc2-8da5-b243cb06c3ef");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9",
                column: "ConcurrencyStamp",
                value: "d37923ba-d564-4447-a8da-864ac388ccfe");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "8e7dff19-067e-4b13-820d-67680c8a6a7d", 20L, "07963c3d-0af9-4a5a-bce0-c652e3f7e088" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "cbf10b61-4fd8-46a8-900e-7dce8990dfc8", 14L, "90cadb47-d8a1-4c2a-afdd-02ab8a1bcbe3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "56f26aab-c252-4572-b9fe-dc5cd277c37b", 21L, "c017beb8-7e5e-4afd-8b55-d7feb5caef4d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "57709cd5-6494-4f9b-bb90-aec2e6a70969", 11L, "344395a3-adfb-4c29-9213-103a2172a02a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "f32574c5-880b-428b-b24a-3d165ee37db6", 14L, "42035649-a95c-4443-8461-d3bb7d936017" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "dc022b61-d188-4dff-97fb-3624074a5ef2", 19L, "d5547d60-d23b-47e3-adfc-dfa484163f9f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "0350d5ef-86b3-4f72-a79d-ab826bfa6582", 1L, "43ef352f-0676-4111-9a82-86c24897f63e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "7a812790-144c-400c-a3ba-a185e609663a", 15L, "fe62849e-5cb5-4dac-bbdb-d4c4d9c54ffb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "7c4bed13-f4e6-47cf-9010-6d32dd18805e", 13L, "25168321-4de6-443b-8c46-64908293277c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "a42a9987-f611-4716-950c-3b18995d5f49", 21L, "bae93d84-e817-4d78-b1b5-47ddf62b0241" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "9d07c6c8-a649-4337-ad1c-e14e05f7f284", 14L, "aa578934-d8e5-454e-a8c0-0dc8d63d11b4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "68151fe2-dcb6-48f3-83f3-17cbf970dc58", 13L, "53132ae9-1d6e-45ab-83c6-0b2a50325c37" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "2ed82a3f-83eb-43e6-a605-13f504443821", 18L, "acbbd2bd-59d9-42d5-be6b-1ec900ff58e3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "0973bb54-6fbd-4a91-adde-8d6b4522d177", 9L, "683225c3-a8ed-40c3-a3d8-d2c60a865370" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "5e975249-7f3e-4e2b-9d29-db9c66c17d8c", 21L, "1c3d13ae-7680-4954-901f-b25289b93c5a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "58553545-3c95-4964-8ae7-31cba9623f16", 8L, "1ff386bf-a4ae-4284-b026-45a06d8c5cd1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "38dd8837-dd11-4e6c-a320-8a7eb118312b", 21L, "c3f6e9e0-df59-4c90-8cd1-4c754afaa0b1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "3669e54f-1187-4836-94c0-5f13f280bcb0", 16L, "304b062a-839e-45a6-b234-66d696c177de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "ecf259a3-b872-4056-9349-63cb85fb1347", 6L, "cadb5f96-a017-4bd5-95d3-bb450afafaa5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "fadc0add-36fc-4d5a-bbd5-0a05595f29e4", 3L, "0686a839-4f96-4cfa-ac97-8125d65e2544" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "4d843edb-f112-47f0-a2f0-0ee490eaf006", 12L, "cde61c48-2643-4834-a1fe-8dbefd264dd1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "ea0e4014-805c-4d4f-8361-19822c9a16ce", 13L, "37392a8c-f7fe-48cf-a685-2c45e34363a0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "a95536b2-9ee1-438c-9750-4f319e71a1d9", 4L, "fea55a2b-4785-4c15-877f-59811d7ce252" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "da64804f-695a-4952-8bfe-d75a4cb42e86", 18L, "80942a33-c850-4691-92b9-97465298e05a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "c782d13a-44af-42de-bd58-4befcdac2730", 21L, "15e7c0df-3e09-469c-9236-545e5ae2c4d3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "b5886498-cb3c-4d74-a287-d5b5ff8cb332", 10L, "030bb6e2-9109-4964-88bf-f31c361bcf66" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "fe20bd80-2bc5-44ff-a5c6-52f29b387a83", 4L, "8bec993b-354f-4133-b735-49dcf0cf4358" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "6bfe8cea-840b-4fbf-92e4-c83f6ca0999a", 4L, "0d4a211a-4cd3-4dbb-bf9b-b435e0cfc4bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "7539510f-957a-4f3c-a641-6320472a2c4c", 17L, "24cbb6e6-8825-4b6a-ba53-698b67b5aa89" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "8aa0e3d7-58a8-4e65-aaf4-420b17d8e03c", 5L, "3f6958ba-4ec1-4f67-8212-a017bffafadc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "e6f7065f-3496-4c29-9062-03a5ba86f9d8", 11L, "1e7a64fc-4c7b-43e8-9ac5-dd507ceacd0c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "38a2a7fe-2e12-4f86-bceb-30243190c8a1", 2L, "acc05dd0-c119-4766-b5c2-01a635b0ca30" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "8d6c31ca-6b87-4963-93cb-80c0390adf47", 10L, "e8126543-572a-480e-9b27-46e76dab03a5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "fcaf19ee-937b-4e5b-b4a0-9882903d18cf", 7L, "a0517324-941b-4e51-a028-a99bac3fb336" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "b4525d24-f87b-4d42-848e-45bf534abacc");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "e2af89cc-fafc-437f-aa13-c7127efc42d8");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "10",
                column: "ConcurrencyStamp",
                value: "b84bc2c2-9481-47d2-94ad-37f6abfda664");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "11",
                column: "ConcurrencyStamp",
                value: "3a5a9962-8817-48ab-baf2-577d6e818741");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "12",
                column: "ConcurrencyStamp",
                value: "727237b9-e613-4825-ad3b-c5f2276066ae");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d9391d7b-a7f8-4250-a597-7b1199567c1a");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "360c8c1b-744d-426f-8bf8-4dfa1e9e1626");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "e92b1586-b3fe-4e03-9158-afd73920b26f");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "e3f32d07-79a4-4595-a935-cf34a29522fe");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "14f2345f-2647-47ec-b8ef-a939b8958a1b");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "64bd9f3c-a896-43c3-a9b0-ed142779e3aa");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8",
                column: "ConcurrencyStamp",
                value: "c3ddfe05-9a98-44ef-92e5-6e1451752287");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9",
                column: "ConcurrencyStamp",
                value: "73f4dad6-2ebb-4335-a647-d1719deefcae");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "deb15826-6c52-4a57-a336-034c9bf2a5aa", null, "d5dbdb19-18fd-42c1-b00f-6fe2f9ca2166" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "285f733e-574e-4311-b879-a98499e22b73", null, "8c2b1521-3c66-4c63-bd59-be74b30bc181" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "999c351e-2a82-409c-beec-1863c77e953a", null, "81da0fe2-ae3f-422b-86ff-e854cfc70450" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "1d8f4458-ce2d-4909-8408-90a1aac5710e", null, "29874614-52cf-48c3-97a9-8b381d9a08bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "4ba2559a-cd52-4288-8ff8-a50f018484a7", null, "674257b8-dd44-4207-97b4-90d573473f0a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "f61563b8-058f-4d41-8d0e-4fde043dc4a9", null, "ffab755f-8b58-4255-bd97-5aa5fd066fd2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "f3983488-7db3-4a80-82fe-31d219addbd8", null, "adad3f15-16ac-443a-a558-20cae69db074" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "25695195-ecc9-46dc-8d8b-c3db4dc3f7fc", null, "f2a53f2a-e15f-4a13-b07b-ba489550476a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "01b94a3c-ba0f-4c33-80df-5c24ddebc666", null, "5f2e20a4-177c-4320-88da-1315da2506f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "73d4acbf-13c6-48e6-addc-2fef827bb87c", null, "72f39435-5584-4e63-92dd-0844d13866b8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "57b7c284-0686-419f-ac23-9e744f54a3cc", null, "b57d2680-fb8e-4ead-aab7-62f9b17f784e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "10a3066d-7809-407a-95c7-b04a35dfb27f", null, "e4d83a8a-8cda-43b8-839a-5ceb23f6ca5f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "1e651060-314f-42d5-80d7-09fe061c9072", null, "84765c36-0ef4-44c9-9229-edb1ff3c292e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "c5bbaee6-6674-4a4f-9aba-a0d61f73c58c", null, "9bb6cf5f-81e7-4399-b173-864d718548f8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "fcc1b836-0db2-4315-bb64-43a00ebad8c4", null, "bddd4b22-1b7a-448c-b1c2-d4b1d5dbf9ab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "08581069-a419-4b67-8139-9f2bc47a1430", null, "c3cdc786-c198-409c-9589-e581f2e50936" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "77c396a8-69af-4fed-94a4-1c6dd01f3027", null, "1db62b92-edaa-4f47-8c83-12008a452b11" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "7719bd8e-1046-4b16-9381-c0cd0cabc418", null, "6c3caad8-f270-4966-89e3-5eba712d5f51" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "16174d63-fcdf-4989-a9ba-54754a7d6858", null, "8abb6017-f0ed-4639-bee8-66765787fa91" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "7181c85d-4a2a-4566-98b3-820b9795df8a", null, "0b07768a-4642-4cc3-b54a-199d5f707b9a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "825bddc7-3fdb-409a-883b-e64f1c73c50c", null, "cb25ed1c-f498-42a5-b2c4-30dd418a9f16" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "6c41d9df-0f89-4fb9-ae74-1aa7a403b9f1", null, "e75606c9-4025-4367-8db2-c92208d12bdc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "7eeb6fe7-5c40-46a2-a915-294514b1e862", null, "c0faafcd-895d-4288-bdc6-3d91667cbc08" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "6184b327-e0c8-45cc-aee4-47a54df30452", null, "2e881afe-da06-4068-9437-673542713601" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "b0990aa9-9408-4bb4-9af7-48bef751ea93", null, "65be7f5f-3f73-4b77-9c69-24cabf3e4d0d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "f4ee388c-1e41-473d-8291-9584fbc9b3d1", null, "604d1cc3-ecfb-4cbd-b2d5-4e9050f24426" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "aea1f28c-6d56-413a-b1f9-65a591bf45fe", null, "4f120746-0130-44b9-b9ec-2d176f2761ae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "0fdb864f-49f3-471e-9fec-5fc3f7a4fdbb", null, "c664e1b0-8354-442d-a7d1-6a5cbb1f715a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "9ad7dc40-3cf1-4947-b954-c689eb052ce0", null, "377eecd5-149b-42a9-9841-0c33ccd4a021" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "a287ef41-4ce3-447d-bb68-62425877619f", null, "ad3a28b8-2b46-4f26-87ca-7b6a9ebf3707" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "c19f29eb-85b5-4d5a-b2b5-e49175bb01b5", null, "053e0eb9-46b5-44c4-8225-2ed10d207e30" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "e5eaaec1-c540-4885-9322-bf3b8c3443cb", null, "544b0d01-01c7-4934-848f-a78cbf4b1fd3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "0ef6f472-f336-4fe9-ba67-adaded6622d9", null, "eec4ba4a-d5e6-4edc-b21f-6187a55d29a2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "fd3dc03b-1b8f-448c-8c11-e8d8cab9ac4f", null, "f870add3-4b49-48cd-a9d9-453e67e337e7" });
        }
    }
}
