using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeRequestNumberAsStringFirstStep : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                table: "TravelDeskRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                table: "DomainAccountRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                table: "ApplicationUserRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest");

            migrationBuilder.AlterColumn<long>(
                name: "RequestNumber",
                table: "VehicleRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "RequestNumber",
                table: "TravelDeskRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "RequestNumber",
                table: "DomainAccountRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "RequestNumber",
                table: "ApplicationUserRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
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
                values: new object[] { "981c5898-d8d9-4898-9555-e3fead2d83d4", "1faf8dd0-1bf8-49e8-8b65-8f00176e9144" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8c76a72-aac0-4eca-b5f0-e6c9e39b5faa", "af9609ad-b8ce-493b-9690-a431f0ef447f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99acc11d-2e55-4073-8374-265f6b7ad3b0", "cbfb82eb-274d-41c5-8d67-cd7925a4c316" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b28af7a-4d31-4a30-86e1-769f9bb074e0", "4288534e-ea7d-4c06-a801-dd39a06e3d36" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dedeebfb-526e-4e0a-bc08-2b2ef9e1b294", "e3d0fdf7-c15e-41e3-81cf-17ca05c23996" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0a468bf-6abe-4cd7-b971-ee16715a19b2", "8c569160-01a9-450a-9255-98467804b9d5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1cbf9a77-8429-4ac4-8c35-c135ba7c9305", "a58f1e8e-0b21-420e-944d-c7e3bca6bf45" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "617f84fe-eeaa-4d82-9a85-f0fbb88433f1", "3e8c0ef3-7cb8-42e5-aba4-9ebf032be857" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e44d143-5970-46a5-a2f6-8508f0d64dfd", "3b3fdcc9-a0a8-41b6-bae8-30f7bde7497b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f2c9468-3d66-4773-82ad-8122e652505d", "02ade4c0-cb2b-4275-81d7-e708360aaee4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7702b191-72bb-4ce4-bb88-e610da83a8c9", "dc76a56a-8c48-49d1-9ab1-8a2e1df0900a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3486829c-0444-460b-90ab-777145a7265e", "8338cbe9-f88a-4488-8c4a-fcd6b4ead41c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be95cf4f-e32b-4a27-be07-416c2a4e2aba", "1779ae13-43d2-4ca8-ba6c-e545765579a1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d14a2ae1-1dcc-428f-8a25-4c4c7f612c4d", "7fb19801-78ae-4c6f-a0ca-fedc94a83513" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "803224a3-24a0-4e3d-bef3-2d957f644a36", "e02bfefb-ab6b-4964-ab74-dc6bd6d05e07" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "329b35fc-dc27-48d1-9710-7ae6442d7dd8", "1ff8fd31-0534-4172-b9d7-b2ea1d34a5bd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94ff78d2-ebc2-453a-9fd3-8d5425f252aa", "543cd34f-8f60-4797-8193-f65a82955b99" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2072985a-f708-405b-9f97-149d45575373", "48aac5cc-9955-4510-8552-029ef3d62dae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd0346f3-273b-47a3-9824-5925fa26b084", "8bc7e661-ee7e-4d42-bb6e-72e9cdab13dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52df4930-2b6b-4a28-bf3b-ba064ba66d49", "b3b541f9-c473-4e60-a0d3-c8701ddc8747" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90cc86dd-c688-4e49-add4-e38606c94fd2", "a6afd6a7-7cf1-486f-91bf-1c4d0ee43179" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0238832-cef0-4300-b673-d8d48610112a", "465a0e81-3565-4c0f-83c3-cf034243c402" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1d8e7f7-114a-49e7-9264-dd04a5107686", "3b888d50-d51a-44fa-a799-6a840031674d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf7b9ece-0528-4bde-97c6-f5e53e919b56", "df4224cf-c14d-44cb-892e-948917ea7fd8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "967db40a-8fa8-4556-a030-850b1991119b", "47918816-da19-49be-a716-ae6f02295463" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46a51e11-7c80-41a5-8b9c-549b78fdb966", "f7195e8f-a79b-4a5f-b524-942bdf33aabc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c0333c9a-43d9-4ad1-a6a1-fc183c0cf837", "0286ad89-dd87-4459-9425-bcdc4213f50a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d33b6d20-2a01-4719-b698-599fe72acac9", "786bc2dc-aa60-4186-a355-6b195b5183aa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "223744fc-23b8-4c16-bd5c-999e185ec642", "40bb86e5-7b32-486e-bd8b-c22d6f993fb9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "caa4dd41-0b92-43dc-8163-64a82787420a", "4189af46-f5aa-4e95-9dde-1a948a1007be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b7c8470-851a-4991-8165-d6a84a02e022", "1dd510b5-4eb1-4863-9c3d-5601fe7ae98b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d5387d1-7bc8-41fe-ba95-e7bbd105ee6f", "fe3d6fc5-9d7d-4d35-8272-aa20653c00bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f6f92844-5710-4eac-8193-624202422d36", "2c000817-cc6f-4932-a242-9d438d9e4c11" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "baeeb86a-aa74-4642-b153-a76718ff70aa", "6f3349ac-1270-437f-82b4-bd09dbc9f462" });

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRequest_RequestId",
                table: "VehicleRequest",
                column: "RequestId",
                unique: true);
        }
    }
}
