using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class renameRetrunDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RetrunDate",
                table: "VehicleRequest",
                newName: "ReturnDate");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b14e6a0b-ee9b-4ef9-966e-b0892f85e8fd", "6e9d176b-aa71-40bf-a06a-2e00e58a33e9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e2f8da5-141e-42bf-9b53-d9be40cc6013", "59bc49f5-b46d-4a78-a12f-a2d0b73fd4dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70750368-156e-45b3-913b-d3b3163c5131", "910eaee6-38ca-489d-b60d-5b0622a7704e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ae2f372-7df0-4695-862c-86e6df217f89", "91d9c541-36df-4000-bae5-6507067976a3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b92d63d8-9aac-46b6-ab66-f51f6a02e55d", "ef291c3c-bde2-4572-afa9-9eb89418652f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa69a541-259a-4d90-aedd-f6e1e1c7cada", "720dee6e-9ce0-44c6-896e-de3b27b8f0f0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bd3a195-9233-4c58-89e6-806e746cd18e", "6629e254-20ea-484b-a9e1-0db9ff90201c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e953674-c553-453f-9848-35465cd47d12", "f37f4f44-2a44-41d5-9fe6-672e5726c3f6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92bf77bf-fa73-4395-8035-a8e1adbf9efd", "a31ffa6f-f47a-4451-b5d0-ac4fd6107969" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df4da87d-8e6e-4b71-bd30-9e9cd01f0816", "fa95018f-2535-404e-b615-1f804e939c0b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa2ca4fb-0db3-43f8-8d55-7f5e69bafc44", "a7922a74-6776-471b-870c-cfdfc360d621" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bb417593-87d0-4660-be90-7c3c45c09ef2", "93f453c6-c1ec-47d2-9349-1914888c760b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93653a35-a9ad-4039-9160-81457185410a", "0652013c-5b56-438b-9c72-c957d66a2a63" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32a91531-711b-4e74-9d56-30bdf6a10454", "f6f6884b-95a6-4da1-a590-9f92bc1165b3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83bee5ad-fe87-4dfd-aabd-3271ba5ab8b7", "8ca6330a-b82e-4067-b0a3-41190fcb46f8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "817dc590-1b05-470f-bfdf-4b9b0c9faa56", "7dc56724-eaf3-4512-b466-706c72546973" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5ba69af-fe7e-46f3-a7df-1f6a4ce945ff", "dcd57e62-5132-47ce-9b6f-2728584dc561" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "123701f1-3655-4690-8d0b-58c38ccc6d1e", "7effaca0-c5e7-46ca-b02c-58f3a82a77bb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4ed4845-fdaf-429b-8a12-68dfdec5faae", "7401eb31-675d-4fba-b716-c938c6c2b094" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f6917f5a-7b68-4bfb-a02c-1d9a43fc78d2", "a371b9c3-5c57-42cf-926a-c1b462f692e1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e96c69d9-5013-4764-a27a-be1417058ccf", "b795ef20-bbc8-4166-ade9-fed9f2795664" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cab7b3f6-de61-4b4a-8107-662c473a2cdf", "77fd1cea-46f3-4bd9-86c5-ce711ab8d4f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5c33e8f-db38-4025-bc08-ba80064014f2", "4c9d5300-2d75-4302-8f2e-a9348a6b6159" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2c27c0e-9045-4e79-9133-b90f5c21eb0a", "5c51b088-f8c3-4400-84a8-4762f1c21da6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb0af30e-67f1-4c60-a02f-5b526f9d0667", "c11a76d0-01f5-4557-9a6a-e6acbbbf1db5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "07911962-8ad9-4307-b413-fb2475b2ff49", "f8743a33-ee48-4205-a53f-f1d56d43fdbc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2ee24b7-7204-49c9-957f-ff3c60e086f2", "d270528f-d846-4525-8e94-0c24bbdc00c3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0d4d642-775e-4c82-ac3e-fe53291936b3", "b5331ed1-2aa8-4594-9d49-00bbdc34c34e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a7359fcf-5751-4803-b703-ef65d2555ac7", "04cbbecb-a05c-4032-9da9-04040dbc7aa3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c1f43f7-02d7-4cb6-81e8-9ec59b40f1fc", "1cb30c7b-5348-449a-94e4-b3c5aed17bfa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "594ecc65-578e-4909-9d01-5126ede6c1a2", "47c921c9-2e5a-403b-bdc1-f6c2c00215f0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01f82178-a329-4de6-9304-9f4221a5262d", "033aa4b9-a8e1-40da-9f42-49e4b088b13e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb16bad4-f5bf-4f1f-a7ff-9c722c17211e", "d26b3165-8c86-4378-9e2d-9da5d1eb6bf1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff209810-9699-4ba7-bbc2-6b81460f5dca", "afd0f599-55d4-4525-aa34-453639884ca1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReturnDate",
                table: "VehicleRequest",
                newName: "RetrunDate");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85528b26-07e9-49f0-9d13-f646ff10c843", "7eee10ea-8eef-4611-8e05-783067b9f98a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e899a461-2b0d-46d0-9fab-06318dcdf7e5", "37b7266b-71ec-4049-850b-960edee8a67b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13c83822-f9c5-4121-9b6a-854b988b503f", "9472d027-33cb-496e-857e-b54bdb3e2c76" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6703513b-9871-404f-b59a-18383b3cb640", "b85b880c-2057-4319-90de-385b05e33928" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "361fcc21-42da-403b-bd00-44e46758d400", "4afc50aa-26df-495b-aa66-ffd826738004" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "174ce09e-78f7-4cff-afd3-ae83b59b4fc1", "95de0321-7280-4e44-a703-9edaa96a048c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d03cedb1-7e32-4964-bf0f-062d0502d910", "e1a445a8-64cf-49e6-823d-52aaabc20bc6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a107c6a-0bb5-4b7b-b28b-a523861aa5a1", "9aaae201-2244-4235-b8b5-a7a0ef36d069" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f84b9594-d684-4867-bb36-61ef7debe045", "2aa149ed-aab2-4893-b839-f852f02ce6e0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a41d14db-35bb-47f7-a672-00b4b4ecd70e", "0f4c54c7-bc6e-485b-8ecc-1310ab817480" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50d2c586-6352-4985-a27e-e63916910884", "d8dad8bc-d529-4b89-990d-ee7ce27c0e3b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1ef5bb2-d3d7-4b4d-b501-ee4faa301894", "7be6a43b-dc36-4447-b812-e8bc46aedf94" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "77ff67b4-3922-45c5-8e70-ef8475ecf047", "024a8cd0-868f-4990-85ef-9ac338379629" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd9e6f92-95f1-433a-bbd1-75c365e668b7", "45eadee2-a16b-4451-a026-d9c80085f1d3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46696dc8-026f-45ae-bdad-20f1c9e7fb7f", "336c823c-1bc8-4ba2-a564-d37542975cd1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88f8937a-9bd5-43df-9ff3-f40495d4a1c1", "4df6a990-91a9-42b7-aed4-b29841b5258f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d196de49-45ee-43a8-8857-1dfa171d2a54", "51e23f3a-3531-4826-ba06-eeb74c2d0b3e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ff27cde-a4fd-4a02-b86d-8f0d3c46dedb", "9b92d80b-e23a-435c-a3b1-ded3de307bda" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "907b5efe-c654-401e-853d-ec6c143724bd", "cef21d75-d95a-43fb-83ba-6bb69cb7705d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba27caf5-bc72-4dcb-adc7-ce682208ac72", "bb334606-2512-4c6e-a6d1-9e5796a6e2b5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5227d7c3-6422-4bf2-aec2-73c39890d9ee", "98af8cce-60e8-4fd1-8f06-588094598496" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bee3223-22ba-4d5c-a7cf-4c82e8aa18e3", "ac6dac3e-d850-4d28-9585-9fb4b9f2338f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e4c792c4-e95d-45dd-8d06-a108dfe8104a", "8d38b60b-26e5-4959-8288-eac4021d4e73" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "216c1ee3-f0ab-4ff8-9182-685922cb53c1", "e1741dbe-3490-4f4a-ac1c-69bed46d856d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e823f27d-ee8f-48be-94bb-3232639aec85", "62930730-bd32-4146-b8f4-41c6f6dfc9c6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f903b1f3-846d-4ed8-af95-a7eb4c29c6aa", "fda29c16-e58d-4702-82c8-b2296d795913" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b54683f-1fb3-4d7c-ac82-80f8e0f6844b", "5487e1b6-096e-46c3-adda-23a3e5edbc4c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c75fe25-93b5-4f76-9563-2e39423fec04", "dee1a5da-9f85-4936-a596-a33f7a2068f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c98a4805-0d8f-47f4-95df-218eb7f44772", "d355a26b-8dba-46aa-98a9-bb17d50e4afe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "925a4f7e-e19f-4938-bc93-8536a2cce0be", "11a6c905-0b0f-4cd9-85ff-dcbcd0c79e18" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c3c908b-ef13-4a39-9f77-96b45e81a5f8", "6a1e0669-cc87-4151-a497-df294d190ffe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "53ed7ed1-5511-48a0-be28-6c8ea9fb9f5a", "23b8e4ce-e1f0-4ccb-903e-8029939281b6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d7a0b33-b2a5-43b8-b85c-b654ae8a9425", "ed3da9f4-95e6-412e-b3f7-f1f977ab0267" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0987a2db-b8dd-4f35-b951-198717c01b4c", "b49c54e6-0270-4743-9aaa-3912148c9c7c" });
        }
    }
}
