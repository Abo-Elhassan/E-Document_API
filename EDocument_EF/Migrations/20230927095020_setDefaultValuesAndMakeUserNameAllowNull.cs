using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class setDefaultValuesAndMakeUserNameAllowNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "security",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "PhoneNumberConfirmed",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "LockoutEnabled",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                schema: "security",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c024158-e720-4e07-9a5f-c785d785e2e9", "e0330f61-f4fc-420a-9132-50b849604ff1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0da65189-b7f8-4898-8244-a9bc3abab0d2", "4aa20f58-5345-445f-8fca-b15910399d27" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "68847b79-64af-4a9c-8fdc-b2b5df1e7e37", "ce8886e3-6c08-4b4a-8d07-7acda63f48e4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51cd1a77-fa1e-4e3b-9d6e-41bcdecdfbcb", "cf15e4ea-7b9e-4964-8bfd-1482c4099741" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "323c8909-19c8-4be9-9160-3d7ebd4128b0", "e260807e-ca4b-4ed8-a302-d8718661ee36" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de12cc6f-ca51-41d3-9293-b57308ef0697", "a174a627-a5e8-4635-9a0f-9680b6572a55" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29969c51-e087-4ad8-a3de-5c0a5481e4f0", "7bdbb1ec-aa37-4013-bf84-d528ae00cb67" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe63a207-2da0-4e8c-abe7-8c0961621f08", "82f5c8b8-3abf-46e5-afc1-6ac82060fcb2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d3552e2a-c8f4-4ed7-97a7-9b94e684f2b4", "780adfdc-9e21-45c0-a8db-6094a44424ca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b1c5d8c-d6de-494d-960a-9320e8763e18", "85592442-bdf1-42ca-b407-0de3ca50bdb3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "823d8f56-3a6e-4afd-b2fe-161c96ca2e9a", "95b475cf-3f19-43cd-a569-b5c915029e62" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf327c0b-3ea4-4b28-8841-74329db51bbc", "c7b47bbf-71d0-4f27-bb33-23795e56cbe0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84aff19f-71aa-4676-ace2-b7354e10d6df", "7fb10108-a998-46c6-9c2b-8d01bcdd3c63" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "58b613c1-648c-4c92-9cda-4d181f1ad0af", "42585205-c15b-4ab4-bb1f-b80432a26ed0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "080509f9-7ca4-4b1d-8203-ba78f6b394ad", "256ff565-5a77-4a38-beaa-48a51433503a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e534671-bb7f-4430-a540-9b86c38582e4", "0e227e65-d7a0-4139-a8d6-bd33bf9cc921" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd6a5019-e4ec-4cc1-8104-7a635245133a", "ffe8b965-c3b3-456b-979b-328941eab0fd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f177240-ba8e-4bd0-9ad0-c31770b70ac5", "ea0fa117-0a67-4a45-9125-705ba33ce157" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2412304-1e71-4610-a208-dfe4b8454faa", "317c4ea5-9c0b-4e37-be40-5ee2929b3f44" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3436b661-e047-45b1-a707-04a2bdfbc2af", "7bc3c1fa-bed6-4694-be24-048c6ca06c0f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40208cb5-7439-4114-b8ab-6d6e05ec59e9", "2bc28346-3538-45e4-866a-64d5f2c192b5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e93cf429-7e97-4b4a-af76-422c476ee80c", "c329d907-4247-4a27-ab01-556c65777fcd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "932d3da8-144a-45cf-b27a-0ac7f8ac5a73", "8f559f72-654c-4738-a616-0f1be7f27b7e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c97a2a4-021b-49d5-8532-e1a6c7e19fda", "b7df51d9-54b4-499a-b5ba-cb37feeeb5f1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6372d962-355f-4ea7-9985-5e53fe510c8d", "f00a0afe-57d9-4308-9a43-e83f08785a70" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9319e94-852f-41c9-be53-d4eb1f0e220a", "1b7c9ce9-9883-49a4-9fa1-8cf23b18dcf9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c896cfa-8cf2-4ab7-9af4-8f565ce6c0c3", "efb2ca2b-10f2-46ae-92b7-550ea16d59de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9021d030-1691-4e02-a78f-886c3baa7f77", "75c156de-253f-41d8-94d9-e9a7758f8a75" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6edf86f-1468-43bc-8e9e-a402e28f568f", "cf184ca6-8ae8-41b1-bada-d0b725030f9d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "789e4f7f-eb59-4327-8253-abd6795b5627", "1f8c1811-d532-4def-963f-fa7ed097e883" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8fa11db-eb38-4fb4-8521-955383d0c63a", "27ff80b2-9acc-4475-b1f7-dd4f48bbc92b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "347ead17-3211-4d52-9308-e189596eaf36", "fd61c02e-a494-498b-a451-188185bfbb89" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86af639b-dd3c-46d7-8081-638f9e437efa", "87121e00-de3f-4caf-b682-c8192a023427" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11b105e4-e0e5-4df5-a31e-e4131f5946c3", "5ecf5d02-0bda-4863-adb2-78e5410cc00b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                schema: "security",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "TwoFactorEnabled",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "PhoneNumberConfirmed",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "LockoutEnabled",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                schema: "security",
                table: "User",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "AccessFailedCount",
                schema: "security",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c71b799a-b83d-439e-979a-dd6e528b724a", "71180512-5973-4827-a615-299fd81f3c71" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3869dbd8-3518-4f91-96c1-6f3db854de83", "8065ca96-b561-4a6f-8fcb-32d758b19a0c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1c25b3b-39ed-428b-953a-3cd911fc0cbc", "e453070e-8d30-4ff0-9a00-ac36378370a5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9be9c906-e77e-4f3f-9e0b-6700a224dc45", "37ce7b02-02b3-4629-a045-653f396def36" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8545b4ce-3d4a-4106-b670-68534daeae65", "5f5610e5-cc62-457c-b947-d6c0c1d9bbe9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8858670-a670-4d1a-81ab-9f060716d3c7", "2625adeb-0ce5-4c9f-a6ec-70f9e2b56d27" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd449675-3b0e-4e17-9436-1d9c6f99c1c4", "c6e73680-5ae5-4eff-8932-c664c3a99bba" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5df2bb2-accd-4e14-a77f-505cfd257f23", "0159ddad-9259-4b0e-a6be-9580dc00929c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b2bb052-f0f4-4035-b076-cdf9c71f1752", "c537abaf-fde1-4182-9831-c7e46fbe46ee" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5feabfc9-f593-4ce0-a8ee-5ddc7fd9bbac", "97172cb0-1459-454c-97f7-e26a06d6934b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80ba96c3-abb3-4ab6-af2f-35c956bde4b1", "7bb82781-3219-4371-83b9-258b34463fe2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86787ced-3f72-481e-ba82-7f0501c93e53", "7deb59d0-d3c9-4415-9a7a-b7dda9f88315" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "749ba55e-9ac6-4b17-8251-9667eea627ae", "d6005ca2-8e43-432b-8d25-5bf58d65b3f8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "176b9ccf-4fe1-4ac6-8439-e2118a67a6ce", "824a55f9-1d6a-4b2d-822b-e66f185e129d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8c936d4-b8ff-4650-9b70-c7df97694b1e", "0df780ab-113e-4e6e-8b2d-c6fcacc1583c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a505d7a8-e751-4bfd-9bbe-13e4b0a9af82", "9d7a3fe1-9aae-4e46-b9b4-7087c56d8349" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7edc4a89-5905-4670-ab20-ecc1517fc846", "dfb44871-0e66-445f-b2e4-7f4b76f87876" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a70c5994-4747-43ad-9539-53aa0850e614", "647ff251-cf67-4540-a3bc-0f120e225d6d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab2ecbf6-05ac-4a83-abcb-007c8290a77c", "cda634f7-9d3f-48e9-8133-05410abc4127" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6bf2327-0dea-4000-94ec-19eb6d2ed810", "2e0ebb53-9f85-4e46-8ba3-dfb0d6105b3d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f20dd95f-f400-4cab-9975-ea5205e7834b", "a8764b51-5edb-4424-9767-61f903b8cf46" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ac22a96-5d26-4ea4-ab78-1db7b691ee5f", "02994f98-3816-4202-9a26-ae7e779d0b3c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44fba3cd-833a-4a7c-9ce2-b9c697a38cc8", "52af9c2c-2ecd-4556-b571-bb833eea683b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd1cbbfa-f94c-46ac-96de-ab269a1c9f9f", "25e1af1d-aa14-40d8-92df-01b5368a8cdf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff589967-ad8f-4fab-a1de-2d2065d0aceb", "8413a948-318c-489a-8943-f4689cf5dc0b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c72217f4-29b3-477b-bea6-5124d6344076", "e30dd381-e30b-4366-a566-86d4aa6b8df3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac12a6a8-dc1c-421c-917f-2c2420b0fe27", "37e4e4bb-495b-4df4-856a-e1b9b2a3fb79" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6974c6b1-33c3-4dd5-ae43-e73a3c78a453", "36dc8808-3f55-4bde-b920-4f037c67ab4a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88b60ab5-c7b2-42b2-8bb7-de0685b6bf7d", "e0ac964a-2481-41fc-a11e-b02b7fe5bcda" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ec724e4-549b-43ec-b0e3-a14eea9d73bd", "0a651671-334d-4b65-971d-1d5c0418f0b2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8fbc7224-f374-4c86-8aee-754e5c10baab", "9644f7b2-92b4-4007-be73-2071fae47ab9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "af4fbac5-4a5b-4eff-8206-9de0f078af07", "42cf090d-72da-4cf9-b735-005e23100fed" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52e72ef8-4483-4e4b-bd66-32b1d4abab7e", "92b4b63b-e126-49dd-a3b7-144bdad21933" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7fe18bf7-2d19-4607-91c6-049a03b642eb", "ae4361b3-40a5-4097-81cf-8edc8039a137" });
        }
    }
}
