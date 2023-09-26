using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class updateDefinedRequestRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Permission",
                table: "DefinedRequestRole",
                type: "nvarchar(450)",
                maxLength: 450,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Permission",
                table: "DefinedRequestRole",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldMaxLength: 450);

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
    }
}
