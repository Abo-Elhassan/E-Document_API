using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class removeCurrency : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Currency",
                table: "TravelDeskRequest");

            migrationBuilder.AlterColumn<string>(
                name: "CostAllocation",
                table: "TravelDeskRequest",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a35df5d1-ca74-4867-b1ae-4ecb60f435a0", "e82848b9-7688-4bb9-8c60-99be1a084641" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6dcc0f30-5549-4536-bb53-fc17e9878ff4", "b548b893-83f7-445d-8e26-cd1809a2bd49" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "71f620f3-03c5-47eb-a270-c18622aecfc6", "d6e1724e-bbe3-442d-92dd-420d8c6dc80e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11925ec1-40f9-4f04-b65a-3af0d5624053", "c816957d-be57-4159-84d9-e160cbce6ce9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd254bcb-b096-4885-9ee0-daa5d85be604", "0ee40091-7bc8-4d24-b444-aa655769a21d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "641debf5-6b4d-4c3d-85ef-cfec1f78956a", "43964926-7fd4-48bf-b158-57a1f753c77c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61fe391b-b334-4535-944e-1c8317a03c73", "780f443a-ba81-4032-872a-114b286f2742" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56f451b0-5472-460a-a407-00ca297fd063", "41e064b2-a74b-4155-91cf-3c4b14daf213" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46a6617c-b4b5-43fa-960d-3a5fc921a1be", "d7d4343b-f085-46be-aa1c-3b40474ec77b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7acf357b-872b-49df-9269-f72f4033f086", "fc5be05c-bcb9-4525-8165-6b4978d7dc73" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d5d0fd0-7629-4faf-9bea-163583da9588", "e26ca3f7-4464-4a5d-8a94-d8ed6d8c3a3b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd860409-17c2-4a35-91f5-7eb7a3953cf0", "bc93f1f1-3eec-45e2-b44f-85cd24e759a4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5f2b154-089e-41e3-abac-f8d9e9d65672", "34768724-a84d-45b4-aa65-f681a27cbef9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9905469d-edff-4d68-8220-c1aae468ddc6", "7038192f-f69a-458d-97a0-ab7059c53216" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1827637-11f4-40d6-8f12-1e5080f6d978", "b5d7c4a6-56b0-4482-b366-7bcd41779d4b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b62ce76-eb43-48b1-afea-6b2fdc483240", "276a10e1-0ea6-40d1-9347-1c18730ae1cb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5fe8f454-4681-40ae-ace8-2c2d9ed419fb", "2e9b2c72-845a-4069-b9d4-1dce331c4354" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36f3a1bc-d990-4916-976c-08988ed75b3e", "9047dd71-8a2a-46d5-91e3-8b626fdadfda" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ef52389-ddeb-4b98-ae17-c3768a97a2ea", "cf67ab80-8741-431a-8adb-9d4eca445f76" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44af7b9d-48d6-4a28-8e4e-a910e0ee7666", "325b1d8c-2fe2-4c0a-9800-1ab0e4219d58" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63c9f19e-1426-4408-8788-46f1c8c93e83", "ff04993a-8681-4ce3-9959-3e05a69cf4df" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "98bd3099-c1cf-4ca4-b5f4-1d70b8b4647c", "36ece510-2a92-4a32-8385-c5c775de2066" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bae32e50-ea3a-4344-8e22-e0d2a7b6092c", "9d72ccac-db8b-4d66-9ce2-f64433fe08dc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8b4966e-3674-4b41-9694-20b25e96e57f", "55c51619-38bf-4d0d-b620-29a19739bee9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08157787-ba23-4376-b22a-0e2daf5a3aa9", "0e4c2132-c708-4998-94b4-923c22d94283" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89d7b451-677c-4dbe-88d3-f9ed1b815294", "6b237a1b-87a6-4bd9-bbf6-0378a623830b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f889d92b-a05a-467b-8909-f5068df1047d", "c3c6106d-b841-47e2-822d-02dcfba80840" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2700b61e-e50a-49dc-bb5a-5ccb66b4655a", "e132eab4-010c-4566-806c-4de335bed0da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd5c924f-893b-405e-8315-f1b6597cff80", "1c23f09d-85ee-44c0-8cb5-feeac84d8833" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47527223-690e-4d3f-8858-21569d5d44c3", "ffc33912-0dcc-4b1b-80b3-71d263de21e8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32e5e7af-f25a-457f-963d-466a573be9a4", "6d940719-76ca-4684-96ee-972e9c31d8e1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c60e0238-a973-4b1a-99f5-788e7b04a3db", "e231021d-f921-4d6a-b58a-43a13c55e29e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed62853c-2109-4c95-b52e-2d8d81e85f1a", "b0d34517-357b-48a9-a6a9-4380e3dc3083" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f0824d67-0b3e-4fb9-866a-cb294fe069bb", "d9a9ffc8-fc9d-4a4c-a45b-85686a71c5f1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "CostAllocation",
                table: "TravelDeskRequest",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "TravelDeskRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72b53996-52bf-4eac-a21d-67d19ef4aeeb", "6df73443-f2bd-4056-85a7-1f88065e2e65" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "195d20e5-6a8c-4726-9dc5-dfda6c43bf13", "9947368b-fc11-4199-a75e-82fa11acad79" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "874bbda4-0173-4f97-b636-021dee292ccc", "ff0ca49c-47e0-40b7-bff0-b72365cde75a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0214b525-962f-487a-ac38-518f543aabd0", "247052f0-4d7c-4599-993c-37690758812d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae8d581b-41b7-46a7-9578-37b5ff068c7b", "d3e2ea6b-a956-402e-bb29-41be15c675ec" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "246a3e4f-0d26-4bc1-b5de-ff27b03c6aa1", "5fb36a9a-6327-4505-af3b-94774cb5eaa4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ca94bf5-2d7c-4231-8f03-2716ae3993b3", "32257be6-01fd-41b8-ac8c-1fb60558ab37" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e8a3e8a-1b82-4472-8348-1c8456c0160f", "0243d367-c053-4d90-b87b-2d28eb970bb3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f42c2b7-3ef9-4168-81ab-80f66acc769b", "3c119d2a-f2f4-44b5-8df3-7ed782b98f65" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36525e02-9e57-4767-a187-3eceaa706a60", "9d47b51e-d593-4f72-afa6-c7c60cf42f40" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "957caaef-5b2d-42ef-9216-c3df9146fc4a", "d2cfe5f1-7d9f-4f25-addf-1aa5d0ef2bbe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84432180-1814-4a71-9121-58c1e68ab426", "a3a499ad-d0e8-4bf5-a16d-cfd5c1933907" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d734382-2c8e-4b02-8fbb-3b516a1bfd46", "fd18daa9-0a38-49c7-b423-9ed5664bd94c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e66c07b1-4b87-443f-b947-2a3e688456e1", "169a98af-18cc-4083-9711-232707ce5240" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "559c1d28-ac2f-40ed-9ae6-cacb903883b8", "14220913-fcfe-478c-b8b7-912a84351ab1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5af73eda-112b-419d-acf1-75dd4ed395c2", "b5ec2bd6-52ca-4772-8d84-4076f5a561ad" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a13d78e9-4340-4876-bb73-caf84a6ae3a5", "eda80ab2-8878-4ce2-9708-d3c35e289ead" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "986e3ef2-c76c-46f7-841c-54341ff03271", "c477d586-5a63-40fd-84f1-0a8d03778126" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28537318-daae-4141-9301-1760404321ce", "1e7a2010-e849-4759-bf2f-6c33115aa6e2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70d8dfbb-192d-4dce-9527-c1972ddf0fb5", "b8a41a7c-9746-42ec-8d74-ab4a46fbb0c3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0bdc2b84-83ec-4531-adfa-a5fc446c85ac", "ee7e3ff3-d939-4c14-94be-52e5587169b9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f360fb89-197e-4f6f-b223-da9042a1a9f7", "41798dcf-cf2a-4c66-9263-f9c7a874417e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed1a9eec-cd93-40bf-8e7e-504b95b4713d", "308a88e2-cccf-4ff4-8359-c392614a22a3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e203f830-5efd-4540-9f5b-261e988b989a", "4682ccd0-c7de-4f26-9e0d-93e7ce84bdad" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45ec8a43-753d-4708-b46d-c1da18348879", "e74dab16-076e-480a-af15-18358764f562" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c2a1b1a-9a01-4f67-acfd-a746ad9accb9", "97de5d6b-f4d7-426a-acaf-092a2f26d098" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3351bafb-90e0-4192-9d48-9b5533efc43b", "a9bb0347-54df-447e-84fd-6d6ba487aeb5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52bea0bd-eaca-4b66-af3c-962c8d2a83c3", "0005ada3-79a7-441b-ab11-e76feeb75ac3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "53998509-ed1b-4514-a2f4-40dfef83e531", "af91b53c-48ea-4fe1-9b37-334ef8173e54" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b478224b-ee3a-48bb-9898-22a799f8c86d", "6be55b91-d91a-4fa2-aaa6-bac9e5204e92" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74e303ae-0ba2-46e7-9d88-0c379ff22124", "481f9d71-f952-4991-9a6f-95a62c92b490" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e4c245f-b940-4355-bc43-953204bd4374", "f9dd221f-f084-4c4c-842f-7109664890d0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e83b0d5-0a82-4e4d-95bf-25867cc7ddb1", "c44a2b22-3488-4cc5-96b5-70004d5cfb21" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48be688d-4db3-4270-876a-b8fc9743e75d", "ce85945a-b063-4f2c-8f4e-4cbca361c8f7" });
        }
    }
}
