using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class updateDefinedRequestRoless : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DefinedRequestRole",
                table: "DefinedRequestRole");

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "121c1742-99e7-4b61-ab2f-f748876e2975" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "6826ac7e-b4ae-47ff-8bf6-cc904db43d84" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DefinedRequestRole",
                table: "DefinedRequestRole",
                columns: new[] { "RoleId", "DefinedRequestId", "Permission" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DefinedRequestRole",
                table: "DefinedRequestRole");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DefinedRequestRole",
                table: "DefinedRequestRole",
                columns: new[] { "RoleId", "DefinedRequestId" });

            migrationBuilder.InsertData(
                table: "DefinedRequestRole",
                columns: new[] { "DefinedRequestId", "RoleId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Permission" },
                values: new object[,]
                {
                    { 1L, "121c1742-99e7-4b61-ab2f-f748876e2975", null, null, null, null, "Review" },
                    { 1L, "6826ac7e-b4ae-47ff-8bf6-cc904db43d84", null, null, null, null, "Request" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b64cd876-1c45-495d-92c2-e3b880e3a35f", "57cc8cf6-8002-4fe2-be64-407a12a48cf3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a3453ff3-96aa-4767-a871-02fa0456fe71", "769c6be4-5f3d-46c2-ae8d-bef085df59f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72fe4fe2-8c39-419b-a4c7-c0fd109eaf59", "545480b3-91e8-4a1d-bba5-1da1b842d378" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bedb4dfa-e049-49c6-a797-c4ae6c4a0618", "414550ba-3570-4220-98ba-6f306827c270" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f621a146-acd0-44d0-9410-df9525a37ded", "d0a2fa9e-728a-4591-9393-42bf087f1f3a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9315a4e8-89db-4811-8bea-48249f7d5388", "7208d1cb-a7e5-4c9f-b669-9d8d24735c4f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb73cba6-0218-4be0-a40e-fb4e5d045178", "42671951-3777-43e6-9d54-c5b410371628" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9d4b892c-7d6e-4db8-a386-c2904d38c7cf", "a48c0d25-1039-4152-8213-eb90fadc9437" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b52b1b7-6fc9-4ba3-aa86-5446b60c29d7", "fea8d233-f663-4f00-99d8-2e7c396b4e95" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4dfa519c-1474-48a4-9461-c401216109c8", "1ee197f6-0b4d-4dce-b136-6cdac45dff17" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e310503-fefc-42b8-9c20-177e83e18716", "5c5fef5c-dbe2-414f-b3df-d61f02ce2a1d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd973628-1ba4-4ca0-8e24-bf4d223ee47b", "c331891c-e76c-4da3-bb8e-6742f0cdd8ea" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e9f4b8f-031e-4d43-a44a-a3e6bef16537", "450b5767-d017-4c1c-86c9-656d8bafde05" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "95f7ce70-9148-4df1-b4a2-ab3093180646", "20c99c32-a1e5-4438-bebd-320087ce7349" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3f67ebb-ffa8-4960-9551-ed1719acb78b", "e05befbe-4c37-4804-8182-afe505ebff05" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6752b193-6c56-4ad0-8eec-b68c26f5216d", "9a16d8be-b2fe-4651-a96c-f7b446534baa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d98bc326-6579-44ee-81c6-50a049ecf162", "74766d08-3a0c-4a43-a0b2-1977cb876f1a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3fc01900-1cd8-4b54-8078-4a5885c7a834", "bc236061-b809-4f4f-817a-29e61d7a7066" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e16e40de-06db-4d8a-b41a-4a9755220262", "bba83c95-f16b-4cbe-ad85-1bc7064674bf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1e6b8b8-7229-4036-bb68-4f5ed05bebc8", "c04d2e99-a230-4c6b-860b-c9792f094c57" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "945244fc-5e06-45e0-ab7a-5003d1d583f4", "e79073dd-aedd-44f9-a566-8914f3f55718" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "887b8ba6-952e-4557-9783-22310efb92a7", "1424e0bf-cdf4-4759-9ea4-56f621c5faf8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "006bc202-a60f-421f-8985-0741af54a608", "775f7bdd-6396-40fb-a6ff-3470c67ea315" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e8b0cfa-f727-4bdc-9714-70039c4f60c0", "680287f0-6754-4a35-a8bf-880ef63a7c6b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fcf34187-1104-40bf-b360-e95155cdd73d", "8114d484-ef5e-4cd2-a8f7-c0a587a98ef9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91df0066-4d0a-499f-8541-3a5f010030d9", "e82ea497-6063-4c96-a947-7119f0dab3bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eada0e89-305a-4600-bddc-7ec15286a233", "27e1698c-9094-45ed-90e1-91c4815b19a3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7876409c-f1c8-436b-8795-028d255f0333", "c85dce3c-ca5f-453f-9e12-9a6a77f82e83" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87f146b5-ab27-413c-925f-f22385a306a0", "988bc572-5e31-4a1b-ab90-d824d4a69540" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dcb4ddaa-9848-4616-9760-d7c4b12e0aa0", "51d007c8-1971-4f23-ace3-ed964ba3696b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69f8001c-1a85-4aef-93b5-d1ff1ae561a2", "0085e4fc-2b9f-4596-bf19-d3b08b71a56f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a35ba98f-0e29-4936-8b0f-d52c4d37e9c9", "258727ad-5d38-45c5-a1e0-a3819e698105" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c84ca723-adf2-4862-9328-7266040ef79c", "294385d9-6070-4760-bd03-fc90363991dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4710776-35a1-43f4-978a-7e165df3637a", "366a1b91-06d1-4c88-b65a-62fc298f1112" });
        }
    }
}
