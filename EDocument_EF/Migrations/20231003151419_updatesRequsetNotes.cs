using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class updatesRequsetNotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Justification",
                schema: "audit",
                table: "AuditRequest",
                newName: "Notes");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef73efd2-ade3-4d82-bc15-9fe57154f5cb", "2a64f915-d62b-41c9-8605-56df746fa820" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0391a00-0dfc-499b-a13d-f8fc98c40715", "62d740b8-56ad-481b-b777-954a9a5fd50b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17e7de64-0560-49c3-91a8-46dc4c964214", "3911a78d-5343-43e5-9109-6ac8174031e8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "045e4eda-be08-4fcc-a8f8-98ec9cd23f18", "c984038b-4740-4a3b-9709-5d312b4fd183" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "305e7cc9-47a2-4df1-872a-efeab74b865c", "fc10c771-b860-4f88-b65c-81c61555774f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee324e2a-5ec1-4e98-9d2c-865ef56c2464", "613587d6-001c-4cd6-af1b-1b48203c4913" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a07e6269-c826-4825-8fde-1fbb44bcbee6", "d4e19d4c-d9ff-4ff7-9173-8119272c3193" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee7b89a2-8ebf-4f67-8c84-baf6791d5b7f", "6616bad2-5bb2-4bb3-8852-b6ee95844e46" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "acb580ff-2a71-4fc7-8854-a4a31cdd4666", "9931adec-066d-4c0c-b06c-2879b61514b5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01063d58-009c-4a87-94d4-15aca4cccb3a", "33b5c02b-f7bc-48ed-920b-fc4803a28632" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee5e81bf-f95e-478f-8271-67992cd23855", "a93da755-55b3-4f2a-81f2-96ffe6c83c62" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "77d11f73-a2ff-4f1c-814a-9d4e07ce6ffc", "a60b1831-72fb-41ef-94b6-3b8d3495efd6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7e91ad3-149e-4d53-915f-f8b6cc18e87c", "de6f5621-e4ca-4b77-bd1f-36a49915ac5f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "117af1ed-a1ef-4557-b3aa-52152111b277", "655f743a-4caa-4de0-ad6a-a8cf94da542c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9cf1f2e4-e227-42a7-8de5-014ceeb0735f", "6a011269-e18d-4308-a4e4-e882203801a2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2aef1a60-d40b-4069-bb11-1b66f61449e4", "33019e16-44d2-4600-b39b-af1050b6ee15" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b53d6a16-be18-4ca3-a65a-7ace284c52b4", "d32d13ef-6ae1-4861-9bdd-a02280010d70" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bb2a3afd-7f46-4b38-a4ec-33e209ef1da1", "1588ac72-c94e-4a96-ac71-795dfb64e467" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e76327fb-776e-40c0-9d43-8692895d21e0", "b1a7d09b-a111-49ea-9d0b-f1e6dc7bf052" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f805adad-e3ba-4812-bb9e-b1993a072b33", "f0ad6a33-891f-4482-837f-02c3cb3c5985" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80b038a6-aae4-4f88-a805-fff1b8bc79db", "d217392c-0507-4f87-a3df-73d03473eb73" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67cf08cf-618f-48d3-86df-96d6c14fa7fb", "ec349d39-b959-4cd2-a1b8-aa9c499bccae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83dd9dcf-df7f-4cb6-9fa1-f3c19d7c7835", "d7209a83-6656-4544-93d2-1d0f17f89cde" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d34a534c-5887-4543-a5b0-5383e21e7271", "7c234c0b-f265-470e-80a5-1f07ac226a0d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bfbddba-905b-4776-b842-953e34084d53", "a570634f-65ae-4bb2-a083-24ac87f50e01" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "071f4489-99b8-4654-90bf-282e5ff4c3f9", "0335dadc-ff25-4511-8a0b-e6965d42bbae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ac641c9-5c0e-42ba-bb34-9709f4886d39", "5d5ddf9b-bac4-4d20-9ff0-ae883b2cba00" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6b4dcd58-b0f7-43cf-869e-0a72f895947e", "d3a6d714-f401-4f01-aaa8-53d1ea56986f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b8b94ff-84b7-4fff-8b59-dc145db12054", "0689e7af-39fc-4f33-9211-a3103dcd1d98" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6578419f-7a90-4e79-8087-12350404a7b5", "a9b3ccad-959d-45f6-bce1-772655e6166e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e620f07-2e2a-41f3-b69d-cd1ae1ce6b13", "1c2ff3ac-b667-4eee-80f1-98dd6c18bf1d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f40dc25-bce9-4236-9cbb-a5dce5272db2", "156d1e07-faf4-446e-b982-fd482c6c7947" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ed23734-8cc6-423e-b196-7b3f45a4e0d3", "9a49a499-7bc8-4376-a435-acfb6facb072" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7970c5fd-6429-4794-b76b-fb6fb34e91e1", "4638a3b4-5b7e-4694-9f69-2211a0222bdc" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Notes",
                schema: "audit",
                table: "AuditRequest",
                newName: "Justification");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c892b922-1114-4871-9595-f3a91e2fa198", "97cf0488-b2ee-4fc3-b7fb-457bbfc2f3d2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed4185b8-7f96-4f7d-854d-d2e7ccd09842", "09372c07-dac3-4125-a89f-3d1291f5afd5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57e11b72-34bd-4e53-9c8a-47153cbc15fe", "6d185a7f-9280-4999-8c07-d8b79bd2a27c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88e67536-4e45-4694-9b51-888ebf9f235c", "ff0072a1-c364-4dd0-8b2d-1e5e9e03efc1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5689b5e-60b9-430e-8041-e3130c90297b", "13c81f23-7529-4316-9cf0-ae2ceefb9ed8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3cac095-514a-4e85-b13b-3bded761fd79", "f9c449fc-dde1-41e6-9b64-fa5416346790" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7d93035-ef7c-46c8-9403-48c300809654", "06cfac4d-3639-4ca1-8181-462ce8910498" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63c6211f-8bcb-4420-951f-41d4dba2138c", "46e0595f-9ddf-43db-9bf6-b0816d8bbc55" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37e6e03b-2ba3-469a-ac38-685ac160e970", "7594a8b5-1393-46d8-b0b9-35784994051d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e57ae815-e0a4-4a94-8b16-b334fc54420e", "03bae537-ea32-4c66-a9d3-f31bc1503b61" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b76fe82-a270-4821-ae29-5564cc7f4e35", "9f45f38b-7b92-4bfb-aa00-183a46b1cacc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf3f1376-6d03-4764-b999-f75428f3ba3e", "5868e0c8-b32a-4438-9775-b1d5542850e8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "513d00cb-ba7f-45d5-ba4e-2170e29bbe78", "04a8a100-349d-4dfc-867c-386bd4d8d683" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "012190b4-3ca1-4e50-aa12-ca40ff67ad67", "6e988903-fbb4-4955-a9a1-18301500f2d6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e3018c9-9066-46fa-a7bb-31b20e528f1c", "c0636cdd-e386-4170-873f-fe1329629808" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1100829f-701b-498a-95de-182c2b13474b", "4e6135dd-da90-4540-95ad-da6e71c0a28e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06852bb8-6975-4d25-af01-c95dfc55c2c4", "b44a2056-6caf-4b6c-b8a7-100b16d3d338" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0fea4ddc-b43d-44c1-9153-9e3bba950b45", "dd678f52-c772-49f1-80d9-49ac32fb7907" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff508124-4c23-4fef-9378-914702966a08", "26187e87-b50b-4140-968e-35c68b84a144" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "71fb04ce-8a93-43ee-ba14-81fccd2873d8", "a9146032-ca7e-4127-a193-c359b033de12" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d75db44-c452-4348-b09e-d4ec36e45af6", "02847043-41ad-4116-884f-a12e3201c7ab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ad93782-00dc-4b6e-ae47-3f039ff76fcb", "fb54d591-38e6-4537-a169-957723022cea" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5dc60947-1ac8-448e-8547-bea53ad977ef", "e332f397-1587-499d-ae42-b120995e10c9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1d1fe65-f004-4ec3-8262-c25414600a1a", "1db6c6ca-7595-4b7d-8a05-5103c2429345" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed843b00-20f9-430b-af69-92d7e4c57e56", "4f8ab3fd-6747-42d4-a39b-626a84f99fe4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1e79e78-8525-44cc-9701-3c169a2e0d79", "e70f5042-0be6-4728-801e-32aabb743efd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b2eb821-8929-4e61-91b9-fda7c70d3395", "8d4a9d37-4574-4b8a-9dfd-22f7f318aab7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "812284fc-8aba-45fa-8f06-870c027646bc", "af5c419b-14be-418f-9c7b-bf9db033dcca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e640ce4d-361a-465d-9e0b-a96e107a9a13", "4a2fa7ad-3721-41e1-98a2-94d774741ed9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6103074f-2099-4ec3-b303-567b91d01220", "52a9b499-1245-442e-a095-c8a9a70590cb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9b53199-cfd7-4f04-9d79-75d64c589f2d", "761e6f0a-ce5b-4576-a355-46d778a04bad" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "930af30d-3872-4bcd-856e-b0ace8e76feb", "bf75d7df-005d-4ca5-81cf-16e2c85b2e99" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a6a247d-d131-4826-b1e1-662897efe41f", "1fa1185c-5d90-4af9-85c7-660fd240877e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9df235d-b8db-4c1c-acb1-eb06701efe99", "8bf9d4a0-afb7-409e-92de-c8f762b0149c" });
        }
    }
}
