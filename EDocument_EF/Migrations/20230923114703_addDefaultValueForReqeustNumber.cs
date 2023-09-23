using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addDefaultValueForReqeustNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PoRequest_VendorName",
                table: "PoRequest");

            migrationBuilder.DropColumn(
                name: "CreatorFullName",
                table: "PoRequest");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "RequestReviewer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValue: "Pending",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Request",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                defaultValue: "Pending",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "CurrentStage",
                table: "Request",
                type: "int",
                nullable: true,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VendorName",
                table: "PoRequest",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<long>(
                name: "RequestNumber",
                table: "PoRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "PoRequest");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "RequestReviewer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValue: "Pending");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Request",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true,
                oldDefaultValue: "Pending");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentStage",
                table: "Request",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "VendorName",
                table: "PoRequest",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatorFullName",
                table: "PoRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "21c4ddf0-76b7-49d3-87c9-379ddd64dc80", "b570d449-7515-496b-b2e3-4c84db4ac3bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d37ab1e0-d3aa-454a-b667-2090e0f49c9f", "f349e610-4b1c-47d6-9f0a-ccc67417f706" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c2e765e-94d9-46eb-9701-b9eece2ff93b", "ae0ae260-052f-41dd-b67f-63819557ce9a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bdc7581-e2e6-4409-ae8d-9171967b16f1", "3bfa466e-4071-4a45-8fd8-24209bfe3999" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ce38ffc-2333-4cb5-b209-cf64841c3d33", "6defe349-d0d3-4e8c-8ad9-ae50498e84cf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b259618-06bf-444b-a15c-a001e7e460be", "91db88d8-119d-4014-8821-8723fdfaf8ad" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b9d852d4-cb84-4b25-a3dc-b5a839bcb9d4", "e4014d1a-0340-4a95-a4f7-7efe52345b75" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be82d127-b37a-4ae4-af7c-3d43b0ca4869", "7230af62-161f-47dc-990f-0da343cb10c2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bef3ba3e-94c2-4331-a29c-b5d434c48dbf", "5d6862df-025a-4508-9474-a6d11be6d1d6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24059a34-71d9-4904-8648-bd563bc9c370", "9260b1f8-8168-41db-afdf-3ecb5deb45ae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85e93ba4-f0d2-424d-9323-428116e431b4", "e9649468-7fe4-4ec2-b4cb-4636f4e7ae16" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fce6d2e1-fd4b-4b88-bf43-5a3b0e4c058f", "e8925143-62dc-46bf-a57e-c3483f66ee66" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93c352e6-5c1c-4446-8b24-2bc7960a4d3a", "e1dac8a9-31ac-47dd-98c7-ad3a8a0b2fc4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91b262a7-7339-411d-ae10-eb585471174d", "37521313-224f-4ded-a7d5-aa9783432158" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2c5b11d9-8986-48e7-add3-d9da8bcbb915", "05c1d406-a304-43f1-bd69-54df36e37dbb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e4facc0-e421-4514-9f14-d18bfe4c94a9", "8f919f43-06a7-436d-9052-9de1e1cf6d7b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "33decb38-1160-4ecc-9957-bbfc0d9eb4b9", "ce8665fd-3b06-4ab4-91a6-3a695e1d5524" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8204115-e216-4dff-aba9-087440797446", "b909ba21-0dce-44f4-9a49-d4222c3de751" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5bfdf33d-d652-4ea3-b4c0-5fcb176e4016", "d43c6a8c-880c-4112-a397-a04cc2ba384f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fcf42118-a72c-41b6-ae79-f98b8b6b9ee5", "9eb8e0f8-5a55-4b77-9aeb-26cb6df3582f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca14828f-a178-4ad3-9844-9d9cf16188df", "c3f74b4a-b6e4-4f23-b7d8-e5136894f394" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c912db4-93c1-4837-baab-69f2231159ae", "7b9763a1-1a9f-4217-9da9-35b6ad455733" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b10db795-cb8a-46df-be44-3771ac6d0fb8", "3abf75de-4b2d-41ef-9eaf-ec899a789e54" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a832ccc-6c9a-4e80-b150-07f3d1a3c863", "3f812f1e-e5c3-46f6-8ced-0c32aae2f953" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f17d1be-ce88-4fda-8492-056d1403b762", "07b58235-7872-4528-984c-e7f96cb1ff54" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "58678553-818d-4378-aac6-3f43eb16b2de", "a26bf1a5-7b04-45c4-8f2a-ee044d924cf7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a545c74-aaea-4a37-abbf-5a0db13f82ac", "0f28d6b1-4c72-4ea2-bb22-6ade7b2453f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "273c5818-ec4b-48d3-851e-f83ad8b61bce", "a2a052c3-0ce4-4ff7-a3f9-d1e596071166" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89257048-9872-4821-8c94-a65a1e1b9e78", "700fa36e-64bc-4fb3-b9a5-7954d1244ea1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86b93671-52ba-4d2b-bd5e-c89176414b76", "93e25ccc-ac4a-4548-a74a-ddffab6fa16b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5599ff9f-de0b-4d9a-a279-a154104ed834", "cf954039-bd53-4561-96cf-b31af25895dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f9f74fd-a475-488e-9951-30586fa42049", "99f1f201-a39e-4580-8277-c7caa6885eb0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6317a4a1-5d9a-4614-92f6-834d98630c62", "8c7d98b7-1f7f-4b51-8efc-7bbedeb60250" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17e405ed-0b10-4003-98b6-33fd3a0e0558", "35e4dc42-8c0b-409b-8756-96d78d14cb98" });

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_VendorName",
                table: "PoRequest",
                column: "VendorName");
        }
    }
}
