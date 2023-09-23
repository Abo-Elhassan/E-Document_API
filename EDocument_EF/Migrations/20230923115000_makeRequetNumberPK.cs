using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeRequetNumberPK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest");

            migrationBuilder.AlterColumn<string>(
                name: "PoNumber",
                table: "PoRequest",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest",
                column: "RequestNumber");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac9939ec-68d7-48a2-85bc-e300cf876030", "43d2172f-490f-46c4-a666-344720ceae71" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0587a264-875b-4a3b-b975-08f17e93d8db", "63eafde4-01c1-49d6-8f50-69cb112bf495" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6c5b0fe-4009-493a-b851-1675ab734296", "ba935d74-fd91-4061-96a1-a4129597b668" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee05f7e3-13be-497a-b5a0-99bbafd02f64", "a30a26ed-0d5e-411b-bb67-17193c95210a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76e61436-de31-4be2-a9e1-bba39af64b02", "e907710d-ae80-4e50-b1d0-24355128699d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "284b62ed-a31e-4192-80e9-95804f9fd20b", "d53aa64f-362b-4891-bda7-3a4fba13e64c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "451f1a9d-04a8-4882-a365-29667b81875f", "6f8c880b-8282-400d-8aee-95421bff2eea" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20336c29-8446-4828-856b-8bb2ce4ac3da", "0ae36cae-a091-4e0f-bd02-a4251427c44a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0a5596e-7deb-44e6-9789-572bf6948c2f", "4dd255ea-7b84-4998-8880-13a0557e64e0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1d8e5cc-3810-47de-800d-8be3c7f09e8a", "94589006-1aae-4628-b514-f8ee31957c0d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04ef3823-1223-413f-af5d-4983747bf6ca", "bbd5b601-ea40-4391-a5bd-74b4c824911c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91e886de-dfa3-4d96-ace3-136040e1c7e6", "f9d31527-319a-40c4-9343-e88c827be967" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ffdb0af-f7c8-4eec-9c78-f7ddb465b028", "1a3a850d-279f-4c52-9aba-763476d2f405" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16ee4a45-4aa9-4ec4-b658-595f38e4d396", "d9f9a7d9-6f28-4f0a-9b88-656aad80f1d2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c90bdc66-3f07-48b0-910d-ad3e72965851", "d341acdd-bdb3-42aa-9760-34e5f963181b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9d979029-8094-4774-bd91-71edc8ba9e5f", "f3071713-de2d-419e-a5ff-94661b1be157" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "222e63c7-a779-4f53-8a72-732a56810b8d", "19b186ed-a57a-4adf-97f7-68df369f1ae4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd169bbe-9e25-4b66-998e-bf17d0ec3747", "e8f86d28-969f-4812-822d-36a56801d9c1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48295878-1da2-4b6d-81f9-2d8a971afeb7", "b92daad5-8940-49c3-8ded-6fbdcc70038b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "362eda44-44b8-49cb-8944-e414e9f2b54b", "e5301ce1-a3cc-4257-ab86-d5b7895abb36" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "beb78316-262d-4024-9f77-5994cd48ea8b", "dcfee656-6f02-4758-94f6-844f1d8ba98b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4d2a1ee-4149-4c3f-acd9-6820ded4e175", "b0f3eaa6-3c6f-41b1-89b1-770a54150350" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bcbaa3d4-fd62-4f8c-a5ce-2f413f15d05c", "5eb76e69-b66a-4ef4-bc7b-052fa3611d74" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6eb5b206-dacb-4369-837b-757495dc0282", "7676e4c0-1df6-4c74-907b-0f34836f1df5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5b09dda-a523-4418-9d25-198dcecc7b0f", "0778f1f3-9e54-452b-a4f0-eedbcffbb88b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e0cf261-da6a-4d8f-b16b-c166525cd1a9", "c06a08ad-5e79-4eaa-ba31-2e74c1f0ea90" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "037c6461-126f-4efa-8bd2-2eb2857cd726", "05421cbe-3999-417a-a4a5-9306ed994522" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e85efcd4-b9fb-4e44-9406-e8bc2ad80b41", "78ea6246-7f51-4f9a-86f7-d39daac4a7e6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c287025d-a07b-4e93-8471-d29d3da690c1", "6640ecb3-5109-4910-87bb-0665c7d60980" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "831537f3-1df9-42a0-b590-1522b1c2bf83", "38c07701-f785-43ae-9497-29dec1d894dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdf475d1-487c-49d9-8ef0-af68bc904854", "3b4372b5-fd04-4061-b471-09a995c6230a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54af1c0b-04b1-4193-966a-c8eac8ce5610", "cb6f01fc-62c0-4049-a5df-9387afbf0a78" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a50c6635-7731-4650-9146-2251382281d3", "ee31deb0-9f71-4a36-9bc8-ec1c27f72a93" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2bcdaeec-97dc-49e9-9d95-c02e71a922b5", "823c5cbe-4703-47b3-8643-01c34153c903" });

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_PoNumber",
                table: "PoRequest",
                column: "PoNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest");

            migrationBuilder.DropIndex(
                name: "IX_PoRequest_PoNumber",
                table: "PoRequest");

            migrationBuilder.AlterColumn<string>(
                name: "PoNumber",
                table: "PoRequest",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest",
                column: "PoNumber");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c85852cd-4a60-4ed1-8693-37c833c83890", "e5613c98-90cd-4cd5-aee5-935fa7964386" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0650c5d6-dc69-4542-9806-bd5ab6a32923", "28137324-04d7-4e1d-baaf-e9b50f160bab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4aa8454-65ca-4b26-9935-676d7355010a", "0e51c80a-f3df-4ce8-bd43-1c4901f0c992" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "21eca7a5-9a19-4d97-8e41-a373e276a31f", "a55e6c6e-f155-492a-b6e3-b148438fcfb2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec2cb970-a4d7-4711-bcfc-f81c5e637cf6", "21627821-029f-43f5-b924-0c0d3a0372ca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "09e6902d-3a37-4dcf-95e0-8835934e803c", "573c41a3-81c2-454f-b023-f98136e6ca31" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f6b0c6d6-f7a2-4737-9f01-c12f50e5b332", "01ccae7e-e309-4067-ac23-cf0b175a9e2c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee5f7c32-09d2-419a-8d04-15d6cebba1bb", "1a7912e8-f9bd-4516-8ce5-454d0f822233" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7fda5fcc-cf07-4666-a989-553de0c5d11a", "9986f6ea-08f0-49c2-8b86-0a86afe9d3d7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a2f0998-f73f-4eee-ad18-6225a7901178", "73e9274a-5828-4d05-9eca-c97c86180744" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "180ba251-80ee-4b6f-92e8-e9bfe35c3db4", "f7f0e788-0e27-474b-9ed7-264a82795c56" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3ad59d6-59b1-48d1-a8f4-8190a91187dd", "131a2307-d494-4395-a94a-59492c72fa52" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ea8456a-27bd-4eae-9d88-fe801fa9cbdc", "a904ba95-9f35-4bf1-aae2-7265e10025f3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f768218-a98e-49fc-8992-9f4c93adab50", "33908ebf-5a69-4b26-af50-84fc7529f9f3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54e78bdf-ab72-49e9-a4a1-6b38c3870228", "6d62e2e6-f71e-4dfb-8e29-bab839df5709" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e38c8ebc-6fbb-4914-836f-25e0adab3a93", "7202773a-f087-4084-b20b-392168d51a41" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "086f64bd-05ea-4d42-8d9b-1456d65cd836", "81e214b2-e721-4448-89bb-c51893f0d30a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5739976b-952e-49e6-a04b-79d1c728f84f", "ee38a1f6-67ad-49b3-b62e-a9ba503cd41e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "efdffaf0-07ca-4a48-b1fe-b10feb825ba5", "d77258e4-0ad8-4afb-9024-2d37a3a70092" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76ec2e2a-0328-4abd-95af-b0e761bee06d", "6c5cc8db-86ff-420c-930a-2ab8603ddeba" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9bf5a160-e325-478e-91a7-cd1944c42c04", "94030ac1-3f4a-4e6a-a0e8-a92eabddb17d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d041794-ad86-4bec-b7f1-18f9948d2216", "7ba70b1d-20e6-4076-9510-3c46ad54f640" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "96e40908-470a-47a4-858c-c671c1d12b4e", "e7279179-df87-4665-b715-82bf98ad8fed" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c89bac9e-c55a-4030-baf0-3c6e2abed930", "10b5ce10-532f-47d9-aa92-f255063638f4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bff6aafa-11f3-40c1-bfd8-9c4b6a4cf9cb", "839a9e5f-2a4f-4b4b-90e3-f068364456ae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d51d2624-6cff-47ea-92ca-20fc1921e9c8", "f3c2c55b-0237-4d82-bfa5-0c476df640e8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d4b83c8-cd78-466c-9a26-c8a355b540b7", "8aa262ea-b096-42e9-b9ea-b077ff663abe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e1c61bc-90aa-4a55-b82d-c58aa98113ae", "8a711d45-912b-4f9a-a246-05eab133ea8d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff2d3abd-b456-4e51-8eab-7bd86fa6cb42", "5cc1d1aa-29b9-4d0c-9756-87783a7222a6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c886888b-9d68-4182-ae3f-7633a1263170", "e2e3f535-8d02-42b7-87be-dcca4e0a93ff" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23379ce4-e0ef-46b8-91d3-b95d6b051ee5", "8855ed84-6019-4379-b2e8-437dca37ed6c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d6e72415-2745-4c09-97ae-a6fbbfa5b7d8", "5ff6edf2-3fbb-490a-bc18-147bb973b75e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9aa4d7b9-74ca-4a06-b514-961f6168d7b9", "27a3fab7-165a-4969-945e-6a990bc4763f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eedb80c3-44d7-4255-a479-968586f27789", "46de5c76-c14c-4579-b98f-2b918f849d6c" });
        }
    }
}
