using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class updateDefinedRequestRolessfas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DefinedRequestRole",
                columns: new[] { "DefinedRequestId", "Permission", "RoleId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy" },
                values: new object[,]
                {
                    { 3L, "Request", "04cd21f1-113b-477e-a517-7dcb1ea8a024", null, null, null, null },
                    { 3L, "Review", "04cd21f1-113b-477e-a517-7dcb1ea8a024", null, null, null, null },
                    { 1L, "Review", "121c1742-99e7-4b61-ab2f-f748876e2975", null, null, null, null },
                    { 1L, "Request", "6826ac7e-b4ae-47ff-8bf6-cc904db43d84", null, null, null, null }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "346e58ff-e590-42aa-9895-f0599d05097d", "5bc88064-3c1f-4419-9b03-96eb90dea982" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04043776-6bf6-4dfa-9529-489695aaf0ab", "d1e504b4-7afc-4705-97b9-ef80a76c4afa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d68baab9-4a9a-4274-87d5-c5c7dee52535", "78d6ff9a-11fa-4c42-9d67-f8728728ccd2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5517a5b4-9f3b-4e76-96c3-1dfa71a77a02", "9a1fd8a9-d8cf-4d1f-a473-590c639e7df3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aed894eb-c2a6-4dea-ae9b-858381b705e3", "96890bed-5012-4481-81a5-7a915321e290" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11a98c60-7f6e-496c-a813-717374355793", "9c99386c-5f8c-49ea-b863-7130df4a52ce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecde3f95-f37f-402c-8773-ae9e18a31583", "971d4c26-af61-49cc-b2ff-3d75e626fee5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b210af32-e6ad-4f19-9a18-cd6572e09331", "d453ebff-56ee-466f-86ed-e5184ba018ae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b908e6d-03c7-401b-95c6-7373ba382782", "6edbf3db-7993-4c8b-b310-4cf7c5282ff1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e908dc1c-f388-4cb6-b7ff-0b3a0648a9f4", "58fe4b9c-0d5b-4ff1-992a-84f955051bc4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "389c750f-9c14-4d25-b8d8-f7e63cc10e1d", "d91dc075-f8b7-4a2f-9f1f-0e0951960280" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12c7ab14-73cc-4e0a-9993-83ece0b30914", "0124286e-43d4-47d1-9fdb-0af81d6b18d9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e3e5833-5a4a-4d01-9a7f-9b0ebec73329", "6eb55f28-2eae-4527-badb-46ab3932eed1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1750e6e8-e66b-42bd-bbc7-00b5be58b547", "e1cd7e72-f636-4e58-8e19-0f90710f56b8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a8d4469-6c3b-4627-bef0-887f1c58b059", "67a8153f-e3ed-484c-89af-a0b70317dbee" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d16609e7-6d33-4f30-b2a6-b5a276abd736", "1eb9378f-b3bc-4f9e-ba64-0c772727c3f0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3491bf2e-9624-497b-881d-a0ed6f099dec", "b95dc573-ec3e-44d1-b9bc-10e322f513ab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d04fd33-8b37-4a2d-8fca-2c63265a766f", "8a927ce2-aa7d-462f-8c6f-b36528790e90" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44b3707b-28e2-4138-87a8-551bbd518ba6", "04791c0f-03e0-46d2-8c2c-fbd737d6cd51" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef87f5fb-407d-4fcb-97a0-14e33eae8a09", "a747fd5e-18d6-474f-8395-e97d3326d57a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "967a59f7-74e7-4eed-ba40-fed97296f547", "9dfed141-6172-4e94-9369-ef94a2e01c06" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d8fc753-e4fe-4b27-bc93-960bcb593d6b", "c0478894-e2bd-44fc-bbf7-804098e29cbb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f8e999d-20a3-4731-9588-b0097a0e7553", "4f512469-0c59-434e-8301-ca22e45d4f04" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b32a84ba-53b5-4ae8-b38a-ca19d5053e91", "f226d274-fbd0-44dd-947f-62a18b5a1dcd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8d90dba-c3e3-4497-8400-07538520955d", "f29f45d3-17bb-4fb5-8d96-f7c84ae5a591" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02ecaf60-e2cd-450d-b1ae-52263c3cede3", "0c9a585d-e6d1-4ff5-9666-a456beaffdda" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48829a8f-65f0-44d1-a55c-2f0a9328e66d", "d3dd3a17-25b7-4565-b0e2-493da4c831fb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b80ea7ff-d052-4d9c-9138-5e891c1371d6", "a1586f76-ca8e-45e4-b3bc-b09af9bff089" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3161b11e-9b97-4b11-847e-93788df8d084", "9ed795a9-3a89-4830-b11e-a22b30c36e94" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9c9a3f6-13f9-4c0e-b8f8-aeb1d047cf27", "70178e22-0ab3-46ae-9a06-4500078fc6c8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccb0ac79-d50b-4036-9f52-f1befce7990a", "b3553d8c-0863-4480-b577-a7d15f1fc62a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8cf76915-06b3-4c96-a293-7ef83b5e6b5e", "a4c36335-211e-43a6-b5e7-e342e712ca1f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "772211f1-9dc0-4594-921a-b6006cd3f7ab", "73e87959-61c8-42e6-8205-d547adf319fe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d6cdcb8-efef-4436-8a7f-ab16ee3a3c4e", "1b602629-c2d6-40d3-8942-aa2ee3a1ffcd" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "Permission", "RoleId" },
                keyValues: new object[] { 3L, "Request", "04cd21f1-113b-477e-a517-7dcb1ea8a024" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "Permission", "RoleId" },
                keyValues: new object[] { 3L, "Review", "04cd21f1-113b-477e-a517-7dcb1ea8a024" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "Permission", "RoleId" },
                keyValues: new object[] { 1L, "Review", "121c1742-99e7-4b61-ab2f-f748876e2975" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "Permission", "RoleId" },
                keyValues: new object[] { 1L, "Request", "6826ac7e-b4ae-47ff-8bf6-cc904db43d84" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2359398b-9ce2-4478-a949-c4f6fbc37e14", "975fa364-4e81-4d7e-b62e-818e775d965d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "357d4a3c-8feb-4192-ac99-9e4896c7cfa3", "b32548e4-1c28-41a9-8fad-a17f1e669a4b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d22118db-04e6-4c8d-b16f-3ee35661fee0", "68cacd64-ec7a-4e3d-876b-f703bf20d93b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "817ec0ec-2167-4c1e-9886-5c7ef844a244", "a599f386-a0d7-45df-8867-7d8752aca45c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56680f7e-674d-4355-8144-ca4030584a07", "4dff1050-c0ab-4c8f-b0ec-a63586562eec" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "619b45ff-cfce-401a-b86f-68f37d14ff66", "f1da8809-f9cb-4d74-8942-7685fd0fd71a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5917f80-12a2-4dc8-a83e-c33f07adb767", "71dcbf3b-e01d-48b8-b557-edce8d375e14" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0f9fd7e-b760-4e73-a370-3f5c35378298", "27dc05fb-8ed7-4c7c-9147-582b4797231a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92995107-d51e-47d1-9649-32436e976f96", "1cb6ced4-bedb-4d41-b786-26aefd0b8418" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba0ba501-014f-430c-b3f7-5734d01ad2d1", "ea0a52f3-ccbf-435d-8e0c-9352297a97d7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "361a5da2-14e6-44a7-817e-8b7ebf19620f", "9746f670-391c-43b8-a5d2-73d8e5838086" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04ea4607-4b4c-4c43-be88-9c85c82ca4f0", "8aac91f9-acbb-43ec-9ab1-dac1a6180456" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c66869c0-3a3d-4a13-a704-a63cf3f469ae", "5f0b6afb-ae48-4161-9477-870e4354518a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9cd1d0a7-67da-4267-803a-5429d70aa6bb", "48161972-985a-40af-a57f-44ee037205be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d039079-2d36-412a-90d7-fb993c26b9b3", "2bb209dc-032b-4654-b7c1-67001f741c2f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4205d91-6e88-4005-8583-2852ad1e4576", "3d8470fd-1330-44eb-b48c-f258800f9534" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "693c0d71-4656-4b53-9090-64dfb73f1669", "f3386a20-652b-44dd-9333-0da78f45413a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd8ca2fa-8180-40e7-8024-82dafa40c40e", "63d46eb1-8639-41e3-b825-d9c5000cab5e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6528d05-5c39-4f85-9f9b-7d7b147706a2", "a56f3781-5c9b-44a5-ba1e-547643609930" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "66590a49-646b-4eb6-836e-192f33d528a9", "25bade82-e9f4-47a9-99ee-d28043b10456" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a3f9a0a-6f08-44f8-aa05-8ecb5cc23078", "abdd71c7-3398-403d-817c-39fc2e087342" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f544d729-f241-4404-acec-deb3cc1d2780", "852fc3bb-462e-4f2f-bb0e-a46275ec659b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c44d4d9c-d2ac-4a3a-a85d-4000f2de6018", "5bd2ec8d-0b6d-485e-807a-40c99cda539b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef364a89-f79c-46be-85cc-4d81e9a6202b", "c2dc0ee6-dbd6-41a5-b2e0-a63c1a957f48" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "181b62f5-8b61-4ec3-b8c5-d2f276fc5650", "54794160-1e23-4896-bd0c-46d30a6311b6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ad42cbe-50ca-42e8-9e08-6dfeeacb2f7f", "8adcc5b2-834c-44b4-840b-d6a1ca65b055" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf5d2835-80ed-4dc3-9c24-8975ac521ec4", "5e7d5385-ba0c-4792-8449-eebac25884ab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bb1c81f-7fbb-4629-a83d-ebeb532257b9", "19d82b1c-6a5e-4c8f-a7e6-ce5a64a5ec83" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f77f7a35-20da-4209-be2b-0b42b0fbbd57", "97562ed5-012c-4253-92d1-361815f9c3f5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22a03692-2268-4279-be74-4028441e784e", "2152f6df-dc83-425e-a65e-e3e63078ea1a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79945de1-5886-4a07-8a2f-9a7d56246acd", "34c914e2-78aa-464c-880d-36e916dc059d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b473d9e-a34d-4381-8be0-c46f9a91133e", "8031eb5c-57c3-4553-831e-1230afc5e816" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0ffa75b2-7021-454e-8adb-cd06e21ae9c4", "46fc1d76-9f2e-467a-bae7-d283ad4fcd7d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e165dedd-f207-4e14-8c72-5506a38954ad", "14380949-ad3a-4d06-a2fe-bc83a74920f3" });
        }
    }
}
