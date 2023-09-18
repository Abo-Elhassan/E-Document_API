using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addSection : Migration
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

            migrationBuilder.InsertData(
                table: "Section",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DepartmentId", "HeadId", "ModifiedAt", "ModifiedBy", "SectionName" },
                values: new object[,]
                {
                    { 1L, null, null, 1L, null, null, null, "Administration" },
                    { 2L, null, null, 2L, null, null, null, "Freight Forwarding" },
                    { 3L, null, null, 3L, null, null, null, "Business Transformation" },
                    { 4L, null, null, 4L, "51509", null, null, "Commercial / Containers" },
                    { 5L, null, null, 4L, "51583", null, null, "Commercial Bulk / GC" },
                    { 6L, null, null, 5L, null, null, null, "Communications" },
                    { 7L, null, null, 6L, null, null, null, "Customer Service" },
                    { 8L, null, null, 7L, null, null, null, "Executive Management" },
                    { 9L, null, null, 8L, null, null, null, "Finance" },
                    { 10L, null, null, 9L, null, null, null, "Governmental Relation" },
                    { 11L, null, null, 10L, "90015", null, null, "Samsung SDS project" },
                    { 12L, null, null, 11L, "90008", null, null, "DUBUY- Sales" },
                    { 13L, null, null, 12L, null, null, null, "IT" },
                    { 14L, null, null, 13L, "51449", null, null, "OPS-Cargo & Bulk" },
                    { 15L, null, null, 13L, "50844", null, null, "OPS- DRI" },
                    { 16L, null, null, 15L, "50670", null, null, "OPS-Containers" },
                    { 17L, null, null, 14L, "50128", null, null, "OPS-CFS" },
                    { 18L, null, null, 15L, null, null, null, "People" },
                    { 19L, null, null, 16L, null, null, null, "Procurement" },
                    { 20L, null, null, 17L, null, null, null, "Projects" },
                    { 21L, null, null, 18L, "51520", null, null, "Safety" },
                    { 22L, null, null, 18L, null, null, null, "Clinic" },
                    { 23L, null, null, 19L, null, null, null, "Security" },
                    { 24L, null, null, 20L, null, null, null, "Store" },
                    { 25L, null, null, 21L, "51090", null, null, "TEC-Crane" },
                    { 26L, null, null, 21L, "51529", null, null, "Projects" },
                    { 27L, null, null, 21L, "50562", null, null, "TEC-Planning" },
                    { 28L, null, null, 21L, "51126", null, null, "TEC-Workshop" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "deb15826-6c52-4a57-a336-034c9bf2a5aa", "d5dbdb19-18fd-42c1-b00f-6fe2f9ca2166" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "285f733e-574e-4311-b879-a98499e22b73", "8c2b1521-3c66-4c63-bd59-be74b30bc181" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "999c351e-2a82-409c-beec-1863c77e953a", "81da0fe2-ae3f-422b-86ff-e854cfc70450" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d8f4458-ce2d-4909-8408-90a1aac5710e", "29874614-52cf-48c3-97a9-8b381d9a08bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ba2559a-cd52-4288-8ff8-a50f018484a7", "674257b8-dd44-4207-97b4-90d573473f0a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f61563b8-058f-4d41-8d0e-4fde043dc4a9", "ffab755f-8b58-4255-bd97-5aa5fd066fd2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3983488-7db3-4a80-82fe-31d219addbd8", "adad3f15-16ac-443a-a558-20cae69db074" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25695195-ecc9-46dc-8d8b-c3db4dc3f7fc", "f2a53f2a-e15f-4a13-b07b-ba489550476a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01b94a3c-ba0f-4c33-80df-5c24ddebc666", "5f2e20a4-177c-4320-88da-1315da2506f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "73d4acbf-13c6-48e6-addc-2fef827bb87c", "72f39435-5584-4e63-92dd-0844d13866b8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57b7c284-0686-419f-ac23-9e744f54a3cc", "b57d2680-fb8e-4ead-aab7-62f9b17f784e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10a3066d-7809-407a-95c7-b04a35dfb27f", "e4d83a8a-8cda-43b8-839a-5ceb23f6ca5f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e651060-314f-42d5-80d7-09fe061c9072", "84765c36-0ef4-44c9-9229-edb1ff3c292e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5bbaee6-6674-4a4f-9aba-a0d61f73c58c", "9bb6cf5f-81e7-4399-b173-864d718548f8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fcc1b836-0db2-4315-bb64-43a00ebad8c4", "bddd4b22-1b7a-448c-b1c2-d4b1d5dbf9ab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08581069-a419-4b67-8139-9f2bc47a1430", "c3cdc786-c198-409c-9589-e581f2e50936" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "77c396a8-69af-4fed-94a4-1c6dd01f3027", "1db62b92-edaa-4f47-8c83-12008a452b11" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7719bd8e-1046-4b16-9381-c0cd0cabc418", "6c3caad8-f270-4966-89e3-5eba712d5f51" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16174d63-fcdf-4989-a9ba-54754a7d6858", "8abb6017-f0ed-4639-bee8-66765787fa91" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7181c85d-4a2a-4566-98b3-820b9795df8a", "0b07768a-4642-4cc3-b54a-199d5f707b9a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "825bddc7-3fdb-409a-883b-e64f1c73c50c", "cb25ed1c-f498-42a5-b2c4-30dd418a9f16" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c41d9df-0f89-4fb9-ae74-1aa7a403b9f1", "e75606c9-4025-4367-8db2-c92208d12bdc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7eeb6fe7-5c40-46a2-a915-294514b1e862", "c0faafcd-895d-4288-bdc6-3d91667cbc08" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6184b327-e0c8-45cc-aee4-47a54df30452", "2e881afe-da06-4068-9437-673542713601" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0990aa9-9408-4bb4-9af7-48bef751ea93", "65be7f5f-3f73-4b77-9c69-24cabf3e4d0d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4ee388c-1e41-473d-8291-9584fbc9b3d1", "604d1cc3-ecfb-4cbd-b2d5-4e9050f24426" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aea1f28c-6d56-413a-b1f9-65a591bf45fe", "4f120746-0130-44b9-b9ec-2d176f2761ae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0fdb864f-49f3-471e-9fec-5fc3f7a4fdbb", "c664e1b0-8354-442d-a7d1-6a5cbb1f715a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ad7dc40-3cf1-4947-b954-c689eb052ce0", "377eecd5-149b-42a9-9841-0c33ccd4a021" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a287ef41-4ce3-447d-bb68-62425877619f", "ad3a28b8-2b46-4f26-87ca-7b6a9ebf3707" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c19f29eb-85b5-4d5a-b2b5-e49175bb01b5", "053e0eb9-46b5-44c4-8225-2ed10d207e30" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5eaaec1-c540-4885-9322-bf3b8c3443cb", "544b0d01-01c7-4934-848f-a78cbf4b1fd3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ef6f472-f336-4fe9-ba67-adaded6622d9", "eec4ba4a-d5e6-4edc-b21f-6187a55d29a2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd3dc03b-1b8f-448c-8c11-e8d8cab9ac4f", "f870add3-4b49-48cd-a9d9-453e67e337e7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "36cd5bb1-60b2-4d44-bc79-ac5f4e882a9e");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ea0e4bd4-0ac2-4f16-9673-7890dfc0d412");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "10",
                column: "ConcurrencyStamp",
                value: "2543e92e-ac3f-4b13-96a1-7426e5421704");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "11",
                column: "ConcurrencyStamp",
                value: "4dcc2619-0042-4c0c-b9ce-697c298ad01c");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "12",
                column: "ConcurrencyStamp",
                value: "e1036148-7921-4352-9c5e-4aef2b1855c4");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a78e382c-f10e-4150-976f-954d82f2b3b7");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "59b33b87-4e29-48c3-bf76-08f51a958483");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "f3f35d87-697b-42d0-80ef-26caa4cd047a");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "4d2c5c4f-2044-4960-b1a0-d50a37691acc");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "99347c41-3b3c-40a5-b938-cdb9e185615b");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "b71fe61d-c3f7-46b5-9820-3ad407824641");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8",
                column: "ConcurrencyStamp",
                value: "5833df24-56e2-49c9-aced-08bb670bf904");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9",
                column: "ConcurrencyStamp",
                value: "e0336eb7-fac9-4430-8540-d3c68233aba4");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06fa178b-16de-4eee-b2a2-24d875917a0d", "c5e0ea5b-9228-4d55-84e4-c7d78198bf93" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42c90554-5a49-453f-866e-ad2802e4e20e", "357dd2fd-ee46-4c0f-a804-c01a645c29b2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a68557b-4799-4669-a249-0b95cfd85fbe", "f59b4f7a-21ef-4ddf-b562-13d7cf87017d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b265af56-9781-4741-aac5-bc0b01ac6dd6", "ff21bf69-4a09-48cf-9b2c-41b1bcbffd7c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79d8824f-8fcf-493c-b627-11ab4308ca58", "e3d18d2c-c5ca-4955-a62c-ae73a1262e31" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e756d327-e4f6-4349-ad28-e3430257dbd7", "54e9d2c6-2e70-48c4-b0bf-67b5101ec123" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9922f4b-d0f8-47b0-be0c-5fef5a4b3c8b", "540d3177-85b6-4450-a505-9f6ef7eac5c5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bce0d7b3-9565-4ad4-8719-855de3b57ec2", "0d4414d9-3b03-4854-835d-fa0b583e7434" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e824109a-e450-469d-b102-7fe4c0d4f1e5", "1855b5e2-7488-4d91-99f1-3e21ae311fd0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13809916-8b63-4b40-a013-edd9155d8b7b", "7231edf4-8cf8-4e78-b0f1-eda243dc4bae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0475cf30-5e2a-4144-a5c1-7bb729db59ff", "998b3e0b-5e96-402b-b777-6c43d90bbf46" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "174787ba-5abb-4d8f-9721-8d235116acc4", "d9671a14-2baf-48fb-a48c-8315e5169e71" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4352df45-f1d1-4bd2-942c-b9f6e69e139c", "1c1bbe34-64f3-4eb4-b8b3-274b8e33d657" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a394fb69-79de-49f7-aa91-714836276833", "7248baa8-1238-45f0-9956-a188d9df96cc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d10cb85d-78e8-4228-8c2d-c4116458d04b", "c552dc31-02b7-4931-b883-397998886ca8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7adcdf52-51fe-4a4e-b17f-d428645fc8b0", "27dcbe95-188b-4096-95a7-01e3c4a39c98" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "af500cec-d3ae-4fa0-aabe-dc50fef653cd", "c593604a-ddc2-4f1b-b7db-434a615396c8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8af91302-a3b0-422a-a628-22b9184fe739", "777d6b91-ccaa-48b4-a8ae-741f7efa7830" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d21d352a-32bf-487c-ab09-badd0dc86e9c", "bd4529c0-9752-45e0-8972-026bd20702da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6d65360-e06d-4764-8689-380cb86f5a96", "62b0343d-9617-417d-b0b8-bc48d638c747" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad759ec2-d49f-426a-a307-da1f648503c9", "f83ef5d5-9f0d-4cba-9b8e-8e14ef76bd3f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "65c63929-2270-4308-a302-84aee1358c68", "904de1ae-5f24-4791-9fb3-ab1c13d7799e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c29ba916-335b-4e20-91b1-3130d338ebfd", "9840fe22-c443-485c-b2c5-c677373b146e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df7b2248-bd25-4456-b144-053cf655dc2d", "d7de3089-a463-451b-8bdd-296e7a65c28a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "73c81969-f0cd-47fd-b3a6-8462555b1ae4", "d11e29df-7cfe-4572-960a-6f4a98bcb4e6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "341cec5f-4441-4c6b-b34c-bd382fed7cea", "0931f13d-b687-4d45-b2ae-7575b627ce06" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "226ffaf4-4192-4524-a869-dd299a0f03e3", "f47f79ee-5b81-4502-941a-27d6e0307ced" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2be8d64-8145-4deb-9263-e9566c76b43f", "0ddf4ccd-8991-4108-89c8-9938e4b3188f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "528fd53d-803b-4341-8083-300066bf8423", "c582158f-f7bc-4a6c-ad55-7de5faae44dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7dd1ab0-946d-4114-b045-8915a3c26e56", "cf5e4ab3-bf16-418d-a323-8b2236acd5dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d2ca0ff4-35c0-4089-ad18-ab150a899956", "dde4266b-92db-4d05-a856-b9d825bf74aa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91114fc5-8359-4a1d-95d2-f7acbc369b8f", "f6b02e69-62d7-4630-8364-47559c80a45a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3263199-dacc-4534-9f51-e13def0da683", "20dcc7dc-a0f1-49f6-a61a-8d60dfd3553f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93199ceb-5180-4405-acf4-c4625f00cd72", "ef8a472c-dba7-4555-8c7b-d583c552005e" });
        }
    }
}
