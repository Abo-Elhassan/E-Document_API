using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class renameBeneficiaryPosition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BeneficiaryPostion",
                table: "VehicleRequest",
                newName: "BeneficiaryPosition");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPostion",
                table: "TravelDeskRequest",
                newName: "BeneficiaryPosition");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPostion",
                table: "DomainAccountRequest",
                newName: "BeneficiaryPosition");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPostion",
                table: "ApplicationUserRequest",
                newName: "BeneficiaryPosition");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7df970cb-ba13-47dc-9665-ea80a756b14c", "d465a375-1d3f-4ffb-af5a-ea1bb37c8c31" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0a83101-c00b-4ee6-9db1-1f33ca506c15", "bd0cbcf1-1be3-4bf1-a695-5be88e4e2a81" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60e778ff-a150-46e7-a72f-7e1076972a85", "bad31ad4-eb62-493c-9817-6f052b341f14" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab7ef85a-d93a-4a47-8f39-9798d8f3b59a", "6fc19690-5027-442c-9d8d-9e2362ce13d8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d839035-06c1-484f-aae6-4b581c1a1af8", "938100e6-87c7-46fc-acd5-20881bb1fe62" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b7fb2f5-7ee4-4365-bebb-471113c40684", "11f6d7d8-eb06-4308-b539-319c3b7cc381" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8fd70e2b-73cb-49c8-b24c-a2618b09a54b", "0105f18f-fb9c-4952-91b0-4ce35b896e4e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3da015d0-6f7f-49f8-92a4-c753905438d3", "dab8614a-752e-4966-99bf-5ada8a8aa3b8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2061e9c7-13bb-446f-b95c-66e12ae7d5a9", "14495723-4b78-4c47-b346-f8e26c67ec1d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f79ac023-aaba-4b9a-9634-cacea1c4ccf0", "55affb89-4e08-47de-8eea-869f3588a443" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0cc6dd65-e932-4ff4-ad42-7f94b892b273", "8d53729e-c023-4695-ad82-7583b4749e30" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3886a6d-579a-497d-a2d8-5d0ba7ac8f51", "4b181b44-b77c-4e5b-b400-2fa903d6c116" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b74e8c6-9a2c-42eb-9866-f9db7d9014a8", "ed3ffd17-f68e-4ca3-9ec7-e7297facbd62" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51fb88f2-a0ed-4641-8bdd-e113d76d0943", "6527904a-18de-4d50-9949-0e358a0c0c55" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c34e6140-08ae-4176-8a8e-477cb17327cc", "f5779c74-5b37-4678-a573-a4381bcd72e9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b80f5d8-4679-4c69-93c3-7ce6c9e61b54", "d81c63ff-6b83-444f-bd0d-a15f72152498" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4cb4c376-99e2-478a-9bff-38351affe24f", "7d15f7a8-11bd-43d4-92a7-84f83f371e50" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1598b4d-75bf-4d62-bb3c-b1f62843a97f", "59e5c10a-45a1-4821-88d2-4886c060b347" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b751ca3-a06c-4b35-b216-b5987a1d439a", "89a74a90-ec70-405a-bc19-0167bf0b939e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d8921b1-db7b-40f3-8911-fa8790263272", "a9a542fe-af03-474d-940a-2218991cf491" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d555040c-6d59-4d2f-a15c-fd7496307e62", "ba87fb29-0bbe-4b25-89a0-3f72ba167bf1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8196973d-5817-4025-8f8b-fc9bd1394222", "2ef10ab5-0dcc-4365-935a-968448208ecf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d82a7dc-634d-4ab7-b60e-a329021a0d80", "d8dcaf73-5cde-496b-9efe-1923175a7f4a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "732a487a-7ec6-4916-9d6a-66bf9ae907d9", "f35733e2-13fb-47c2-b495-d6c032c046d4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0bbf5e06-2cf0-48b6-bfa9-7f58d7aef538", "eef41535-2bf0-45a6-ae72-1f28b7d6b328" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0fe7fe16-4055-4c07-bf58-aa960dac1a67", "36efe743-7015-499a-aab7-694fd9522d89" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec5f6230-f7a2-4fa3-87ee-cb80c741ca5c", "ed6df363-7f45-4da0-94a5-2b3b00ca43a0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62471d64-1907-43ef-8dae-49f29c4e2d19", "7ac7d810-b1e2-4462-8e1b-84dbbf6bc09c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a58f6ccd-3fac-4cef-be84-67ce85cbea3a", "fa495f64-dcc4-4fff-b83d-389695182125" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d4af9de-b669-4d16-bf27-f36548802d3a", "a29e7657-fc53-46b1-9399-a1f3823e1eda" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50020860-a4f6-4cf8-87b2-3906dfec8bb2", "4bfff768-f3c3-4c47-9865-5a3db4d66201" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67824f15-3461-41fd-942b-f85472e860ca", "71a61fe8-8d4d-4047-85c2-fbd7e9b5baf1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45c33752-f03f-4322-8e79-8974899b54f8", "11be8bc4-6169-4c88-a8cf-f1f16e2b13e2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3820763e-b3d1-4e56-817e-687cf78fe080", "62631032-9ff3-4db8-8d79-ee2307267e3a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BeneficiaryPosition",
                table: "VehicleRequest",
                newName: "BeneficiaryPostion");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPosition",
                table: "TravelDeskRequest",
                newName: "BeneficiaryPostion");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPosition",
                table: "DomainAccountRequest",
                newName: "BeneficiaryPostion");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPosition",
                table: "ApplicationUserRequest",
                newName: "BeneficiaryPostion");

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
    }
}
