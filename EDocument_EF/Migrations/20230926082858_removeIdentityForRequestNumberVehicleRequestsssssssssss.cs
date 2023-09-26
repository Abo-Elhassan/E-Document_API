using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class removeIdentityForRequestNumberVehicleRequestsssssssssss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleRequest",
                table: "VehicleRequest");

            migrationBuilder.AddColumn<long>(
                name: "RequestNumber",
                table: "VehicleRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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
                values: new object[] { "a6e4248b-5f8d-4d2e-a238-66260d118a13", "7d0bf78d-cdf8-4078-a268-ea622e17c58a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dcfe8c1b-5316-4f67-85b0-25d26823cac1", "10e48b07-eaf5-4f7f-ac33-020051a5e3ec" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "700ffb00-d1fc-4255-82e0-1c5e8419b40f", "d4acf2e7-25ff-4435-a835-cb26903c6598" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a81ead16-0897-492e-b0c2-10b83ec800be", "7ef4d7c2-b79d-45ed-842a-44178ee1f5b6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e6c6bc1-3461-439f-9534-9a803521472b", "63ad2f86-3c0e-418b-8809-66e17d33c61d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9bcb88db-89ac-4163-aa49-b356313cf89d", "658a2707-562e-412f-8485-9b640e80369c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "353400ca-9614-4ee0-b29a-281af65afbe1", "8e194368-2495-4050-b4e8-58fa1914ac23" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b329d50-aa4d-4833-8859-0c6348a33efb", "315fcb6f-c279-4f37-9917-d4116d94de64" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70c9d499-3e0a-472b-8b37-7c8d0e21f4ae", "665fa04e-b444-476c-aa0c-2b099485e407" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62f9449e-2ca8-4c67-aa89-a1829fc2b81f", "03c0e540-52ce-46c8-8113-ecbb1e884b92" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c3c1b76-680e-43d4-8562-51d39e51c2c5", "2e64ae02-4377-4d39-a1bd-b4667da5533f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecccee68-6985-42ab-bd89-5491967e214a", "f4646df7-9568-45d0-95d2-09439acfbf12" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e4e4a49c-aefc-4718-b302-217da6684ee0", "39e60c44-fc07-4640-aa6b-134ef2f97883" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25575f88-803d-4ca4-86f7-089b3615c6fd", "405daea0-8448-4730-8cca-5af3a3c7170e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0cf8b718-9c0f-4441-98bc-039e9edfed62", "ce4fd13d-12c5-4114-a85d-6d08f92940a4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "60cc858e-ae67-45a9-ac98-f6344d9612c9", "77527fe7-73c6-4490-9fd9-ad2988f8e9d3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef2d9dab-8472-4b8e-b964-36b8fc0bd189", "bc61e68b-c4ce-4822-aac1-c3d96661695e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "35d99ef6-e54a-4bc3-91ab-5eb82f2e7668", "e5ee6e79-224e-44dc-bf11-10d800844c20" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e00c3fc-1996-4d3c-82c4-dc8b8e049c40", "1bfcd122-87a7-467e-b858-388565db938e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d486fcb5-f712-4886-b6db-b0d47875606e", "21095a59-901d-49ba-a03b-6792a096e588" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a3192eda-cc6e-4e6f-bb2c-b911535d92bc", "9af5e189-1665-4601-a37c-acd9c40f0674" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "95ee9675-8ae2-4eb7-be78-b789cc13fe2f", "d0c6b6c7-ca36-472c-806b-eedff7420f1d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "004ccc1e-3b23-40e0-a995-c9d6ddcf3d63", "a0064639-8bb1-4bf8-baec-d9091872c0da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70089776-c451-4318-9929-71be3e38531a", "9b6e486c-eb88-4bc8-a18b-8391cf332dd8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e269c67e-b083-4bf3-a374-1071922edbe1", "216f837f-6cdb-437d-b5f2-e923f68d1da4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "979558af-f903-4f44-a382-c519fbc9fe02", "5e7c7185-19b4-48b4-aa83-27743217a467" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "acd3c157-8eea-4133-b3d6-eda3d4ba53ea", "5b564a9c-381d-4ea8-9e1e-4495ecb1ace6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4b1e7d3-bdec-4fb1-a423-0bd463e94147", "88821331-eba4-4746-a076-860fd1035eeb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e894e37b-a807-4a65-8127-87edf1b498a8", "9ad1d85c-a32a-4a70-8fcd-fa5469ee4acb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b864a460-203b-4db2-bcb9-9e44ac2f5feb", "6eb52b58-83d2-4b02-8aa1-ae46751a5aff" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f7c4590-55a6-4afa-9b1a-9816b2971aec", "e8da31fe-735a-462f-9598-6afe634d8d2a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "788cabc3-8945-4b84-8fab-bd1a02126397", "52e94b06-d740-4916-a0ef-ece795ede09e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a1c1c00-1897-4a69-91fd-6fdf35242ebb", "768a69cb-b8b6-4e75-87cf-868e439a1905" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b21f1827-dddb-4c87-9248-6f8a916874fc", "c329874d-98a3-4f51-bfa5-4e078c31c531" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
