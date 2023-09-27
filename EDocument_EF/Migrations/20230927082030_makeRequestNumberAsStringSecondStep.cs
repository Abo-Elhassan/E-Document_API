using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeRequestNumberAsStringSecondStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest");

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                table: "VehicleRequest",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest",
                column: "RequestNumber");

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

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRequest_RequestId",
                table: "VehicleRequest",
                column: "RequestId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest");

            migrationBuilder.DropIndex(
                name: "IX_VehicleRequest_RequestId",
                table: "VehicleRequest");

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                table: "VehicleRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest",
                column: "RequestId");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "695a2f7b-9225-452b-8e88-66ef35d542f0", "72d45a18-6aa0-491d-adf6-24871155544e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41526476-ff40-4344-b732-6ba0c108ca72", "9021bc65-0f36-4254-8049-acd641b3fdea" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61d50154-eca9-4ef8-82b9-feee96fcd8cd", "b7ab3724-b8ef-477c-830e-317fc9d8244f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70729dcb-57f0-4643-ab92-ed9f32aa23d9", "0fac5d87-9f8c-49cd-b55e-f9db41b7c1de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6fc353e2-7fa0-43f5-8018-d33524077576", "71b172e8-87e3-462f-9c04-fac1bca82577" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "769b8436-72b4-498a-8bee-76813bb30ebc", "7733dd75-97c5-4d24-824d-d100ca0a7da1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a368813f-7c2f-4ee0-98e3-f637665e1284", "ed7be599-c361-43a6-baf0-fcd9509bebc0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c63d0a14-7782-4254-8612-0ff6fbbe9e2e", "d081a971-bcab-41d0-8862-6fde11ca0a26" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04ee2933-56b6-4d51-acb4-96568e4950f1", "6cd8c742-21ce-49ac-9d29-2cd35ec77122" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61f59bca-ccb6-4fde-aa83-45233e2da7b4", "3b21e687-2dc7-4fdc-afdb-7280eafc43b4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aadbe9e1-3330-4b51-b7c8-fb0f3d7254d6", "e6bfb0f8-9279-41a7-9387-96b7f96c9dd2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6763182-9261-4d3a-998c-fa2ffc9e439c", "e32e7989-52c0-45e6-b9ed-aebfb9d14ed7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f700be2e-8e2f-427d-bef4-c01663972aba", "957b0c8c-6cd5-4bcf-808b-53a8878944bb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0256f16-c8ea-4b13-8886-92325f96b809", "9077a5d5-3575-402b-9e51-a3948d21cc78" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d1ff3a5-b59a-4853-ab73-e875d545788c", "6e671b5f-8377-4aaf-a770-7969d19dd660" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "887b7b34-f74f-4648-8030-1b6e8f877591", "fc433740-27fb-4e53-9b87-4a3405db5678" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3eb6b876-1fc7-49b6-8f5f-912ffa00a5e0", "e57ad29f-ef2c-4947-aa38-efca3f2eef79" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd38121f-aae9-4d82-8b0b-1be952d0c455", "7dabc5f4-953f-4ace-b4fd-095ff00915bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eac0a788-135c-4c86-80e9-5cab6307b3c5", "08a04f2e-300a-4d80-94bf-58693d322720" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f271808-23ca-4e78-aa1b-72e35d59a809", "6b698aec-7f85-43ef-8ad0-60125e0a09b8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed4c060e-4215-464a-9335-6a0f933665fe", "e6682e20-626b-419f-b04f-df498a1ae95b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0770ecc7-9c6a-40b6-b8c9-61c5c531f548", "14c3c40a-bffe-40fd-bf15-cad98c415604" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d9bcea7-11d0-4cd5-b02c-9c85911904ad", "06f6d685-61c8-477f-84d1-6f0ec4ead739" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed163058-c98d-476d-b4d8-8a6aa616cab2", "f55959d0-3dce-4a28-802c-f5955fc41345" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f226206-c129-4755-85b3-7052a5a398cc", "f8c3ee89-c50b-49f1-a5ea-c8b6c3c8e311" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5975e3d-efb9-4634-94a0-520561d41f04", "4af910c5-7149-473e-8d9d-0d7af17ed3ee" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e44c295-8e9b-41c1-8ee7-2b13bfcddf19", "672faeca-947b-4797-8f03-31da7fca17eb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5e5f624-515c-4123-b9a9-cd32d3dd5b4f", "1b811efe-5be5-4bd0-838b-36f04a3a095e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61b7235b-9bd1-42c5-9233-876f5ecf6f9a", "8c8e7dbd-48c0-426f-8044-1bf889e326db" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d40a1575-2a4e-4852-a8a6-8f24c767a658", "32aaafa3-6ccb-4c38-859b-3a6441828439" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c9be90d-913f-4519-9e32-46f496a96085", "2d8a436b-b54c-40c0-b2e3-86990235f2a1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2bd01b1-13e6-4cd2-a914-8d3170bb75e6", "95d3b235-20ca-47e5-b68e-a12339232ac6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34b8b389-1d2a-4a61-987d-022c52c059f3", "9f7686c0-82ff-48d8-a859-c87dead3ef67" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e028090-4198-4a23-b2be-6a42f94dabeb", "13898d7a-7950-4e62-bf3d-77225e7af55d" });
        }
    }
}
