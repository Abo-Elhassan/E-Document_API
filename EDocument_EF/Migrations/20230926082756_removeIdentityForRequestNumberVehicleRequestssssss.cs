using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class removeIdentityForRequestNumberVehicleRequestssssss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "VehicleRequest");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "TravelDeskRequest");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "DomainAccountRequest");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "ApplicationUserRequest");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest",
                column: "BeneficiaryId");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4df100be-53fd-41e2-aeb5-107329d9b697", "68456617-afce-4c61-88bf-0da53b456cb3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eaf259b3-d225-4baf-9806-edc140ba6b97", "0cb3a0d1-0571-4df8-80ec-bea4d8ee4462" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f1759fb-22b8-41c7-9897-5f22326de3a0", "62f78455-14f7-4e03-bf76-3aa176f2c424" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4e4b4a9-32a8-48be-beee-57742a511483", "b6831825-a80d-4e06-b110-59cef38750ea" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2a6d3d4-3659-43bd-abef-aea2b42ee692", "80f878ba-1ddb-4ab5-a351-3eb58f948b48" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b49c5dd0-0939-4ec2-abb7-fb2844ac438b", "4f444ff7-e85b-43ca-b65f-d9aab9bce5f3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81fecd62-6a37-4119-8802-4d7edeaa79a9", "e8b5f680-edf4-426d-8721-10cb8495c314" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ebd47a1-e0a2-4dbc-8237-eafe06c682e9", "8ae483a4-a341-4d2c-bd12-2b45800972b2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6db96c8d-f4cd-4c3b-b81c-2c5926334b46", "9de6400b-ef88-4c34-b7a5-1d5dc220da6b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec30e996-aafd-49b5-9513-a632563312e5", "1dc91808-e115-468e-98d0-2d7e8babb913" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e67e40a7-e2e5-46ab-baf4-064f7229a33c", "d0ee5772-99c9-4a80-885b-a9b97317d791" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f6f80cc-80e2-4a2f-bf4a-7fa7ffbd30e8", "7334f597-1840-48fa-948d-2b8c40c4efa5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8628ea5-0964-49c3-a26c-cc6d926e1845", "80b9aec9-9c1d-45f1-8120-5d04119f3436" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5d1a567-076a-4ca8-86f8-f233cc7438e6", "b2dd80c9-d57f-45f1-8ef1-a5d56b185d3e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d198bec-e9f0-4faa-85d0-45a7fab47724", "9c45ba15-cb64-45b1-b7d5-ee58afd42090" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf76947a-147b-4663-af07-4e4efe5b57fa", "cfa74401-0e32-4c31-ac7e-d5a1922d9a8f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d29c7733-53ec-45e4-9529-bb37f71c3e73", "4147a549-3a39-4ec6-b131-36c8bd4d5003" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b61af45-1643-4e96-ba6b-4cd6265d5cfe", "087d6b0d-78c7-4393-a126-1a5cf47c68bd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c3f7351a-9f6e-47ef-bc93-497a8b2db0de", "0d5c65f0-8c3c-4a11-90bb-a540c143ee3d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2bbf1886-7f8f-499c-b621-5d15bc964b99", "4c37289b-8300-4f7d-8afe-32594329e8c6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43deb372-9edf-4047-9604-f5361f3a398b", "66aedb77-8e0d-4a56-8340-b61808bdd32f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ae310dc-4b6e-4885-a83f-2a0293e52772", "aa50ff78-8240-4379-b724-aa8819069d8a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "701d038f-93bf-458b-aaed-a6c9ebfe3cf0", "1885885e-5ed3-4bfe-82c9-f5a28e7674df" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52c6573c-d385-48d5-85b4-c447f80c8700", "01b351bd-41ae-4150-a0d6-fe80f5976c2c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec04eb6e-2d36-4380-9e3a-bba11d420793", "fc5407c2-0366-4a49-83a8-1c51c3cd0fbc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "688921d6-42f1-4af2-b3f9-c106bf73ad34", "35724fcd-2928-42de-9e50-11313c251bed" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d9b7566-3b36-4d80-9944-90ad68b6bd91", "1713d16a-cccd-4ace-b425-945c94766321" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4a71564-ffc9-44c8-a606-d420d1d0d7fa", "58ae83cb-7ba9-42cd-a94f-001deb18264c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe9da897-2290-4208-9b2c-3b8b3b50abfc", "4eafcd55-4f9a-4450-98ae-d018d0d2036a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41ce1a68-6b66-4888-b989-fdba09aa0d53", "56c035a2-9721-4fe6-ae2b-08e82c7160b2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "caad5f6a-1faf-4aa4-b0d4-e770e7c40b84", "6c150439-6943-44c8-b624-fcf094aefdc4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0da45088-3415-43b1-8212-46c83c092e53", "1159f1de-3881-4b4c-975b-9331feb83852" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "75bc4268-d53d-4f95-9cc3-3f70a73361da", "f12f3724-f92a-4113-96a9-cdc423e8137c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1fb91fd-63de-44a0-9b17-436002339b4b", "4abcb1b5-3616-4cb0-ae9a-4080629d6aca" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest");

            migrationBuilder.AddColumn<long>(
                name: "RequestNumber",
                table: "VehicleRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<long>(
                name: "RequestNumber",
                table: "TravelDeskRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RequestNumber",
                table: "DomainAccountRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RequestNumber",
                table: "ApplicationUserRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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
    }
}
