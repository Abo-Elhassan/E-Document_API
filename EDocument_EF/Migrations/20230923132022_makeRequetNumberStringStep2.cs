using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeRequetNumberStringStep2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest");

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                table: "PoRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

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
                values: new object[] { "b70668cc-0b32-422f-bb79-60699296a0d5", "6493e17c-dffc-4d04-aba3-f90238a09db2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec578a79-d3df-4fe8-a5e4-3a725ff97d95", "d9fa872e-55f0-4bdf-857a-4bcd2e21bc74" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "984406ed-af85-4613-ac76-0947cadc7cb1", "ebe203dd-c8ea-4281-a9f8-791c075d9a20" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11deeb10-bbb6-40a7-ba07-2710eb2367a4", "44b1b49c-c731-4d61-afb0-a1a0cd8e4075" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2eaa126-2e97-47ce-be16-16bac9207e89", "ea1dd9ed-8e3d-44a1-9939-ee19aa72844c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e35af47b-f22d-43dc-a688-b65fba9532d9", "e6c1b2e8-213b-4440-8a5d-3e9b86df1887" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d274613-785f-4443-b71c-9c8c459e704c", "c41855a1-2c2c-4824-a93f-4bcf491e1e30" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "010f10ad-4c88-4965-a712-573d306f2cb7", "bbc0b9fa-df59-46b5-aa47-dbc86af9a7bf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8563c714-926f-4014-b21b-b37b3ca615fa", "00da7cfd-a61d-4987-8362-1b4d71216bd4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6012b44-d8b4-4a6c-b190-a8ef3715c167", "eb29c313-a81f-46b0-ba18-7af2b2ccba46" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "317fa301-2be3-4620-8060-bddde2ce77f1", "144b5e18-6029-4645-9a20-5d53d4280a78" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57bd5dee-7162-4d73-9831-82f12b8f295b", "e485e64a-686e-44c3-bc53-eb2cd1d35a59" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed9e8a44-e7a4-47ec-92bd-bb5fc734daf2", "eae184e3-49d9-4c35-8b56-c2240ccdfbfb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e7ee5cb-faa7-4bf0-b28f-50344fd4ab5f", "e7ced51b-e936-44e7-9e72-b387a346eac2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d6eb33f8-a363-457a-8d1d-ce5ca97575a8", "853a7b25-2cc9-4c65-81e1-4a31db733461" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be32ea6c-830e-4346-929e-2a7e1b24a12d", "9504f49d-c96b-48d3-9eeb-c0a66b1167dc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c2635d7-5f78-4ae3-b9db-b21a6dd3b87e", "4da22b75-3f19-4071-bd9e-3257ec88b7ee" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b876b4df-15db-4271-b314-a262c1045056", "ec104e80-1af4-4552-96a0-025a92bea745" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7dd652d-cbbd-4cf6-bf16-b76c053f219e", "81f2a29e-2102-4128-a60a-34e28eddf9a2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f329f2e-a5a1-4311-b9a5-14c55d755371", "ad244b86-eefe-4593-9099-b59b32528e57" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b0f66a6-6027-43a2-a224-c840a7d5765d", "3095075d-4e48-49ac-8d17-69af77407a4b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1272a75a-acdb-4341-a394-50ba8f2de9f9", "dbb9c4a1-95bd-4b16-8316-6e2353293815" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "af1afa30-4081-45b9-9a8c-bd6bcf10aecb", "0505f12e-80e1-48bf-8460-b36d3594c808" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d644cfae-8f99-4e26-9712-2397a31e7b20", "096a68fd-07f2-4297-b926-8ece91d618e3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1cc319f-17a0-4f5b-b658-25623b0f5395", "edd23451-20c1-47b0-aa2b-e9b9d6923857" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ccba08b-135b-47a6-94ab-30f1139cbcc7", "1885e778-40a2-4a5e-97c4-ba1b560a8976" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d2dc780b-fdd6-4ef2-a680-7cd652225760", "7d15bc13-4956-400a-9fe4-ca373f30becf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd091b35-8222-4b40-a7c6-a9a91b1e90e5", "f4f151a6-03a0-4c2c-8004-1932519f217e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "257ae5c8-d2ac-45af-a4e6-c50cae29804a", "3bf04e2f-933f-49d1-9075-ecaef4f44029" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5fccab45-dcec-4d56-a6cb-69c368a8fce8", "6d277a1d-5ce7-4dac-897a-17d62a11c20a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40603a90-8d64-4f50-806f-196864ac2284", "4ce36478-b270-4e2c-beca-41b7d6fd6e36" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9282cd8e-bfba-4865-bec2-4935405a6349", "a68aaeb5-133f-46a0-a34b-a1190ba25d64" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f8e3ff9-205e-428a-8dee-365239dc4f86", "acab1d21-2158-44b6-93a4-a654d2d2643f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "58d07f13-205a-42da-9ceb-e6d6f1a14c8d", "e59ee736-7bb0-49c4-997c-4764cb7ef39f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PoRequest",
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

            migrationBuilder.AlterColumn<string>(
                name: "RequestNumber",
                table: "PoRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
                values: new object[] { "02660155-9504-4b49-bbd0-75e1924a71fd", "1f17ae02-4833-444f-ab80-0bef84020dd7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "64942102-f4df-4998-998d-7e2fea34d373", "c68ab939-9bd1-4159-bbe7-0cca28312bcf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d66a9be-5a70-4377-a2ac-8a18d83d9352", "e648b84e-766c-4879-b3be-bc5726522a36" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe680b6f-abd6-4f7e-a9b7-8dfb054e0ab7", "0b6d63f4-318b-44a9-b8a0-a9793614b898" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd2ef68c-f917-4735-9009-ff1bacef2293", "bc69e837-a9b9-4d02-a4be-ca8d0a5c0b08" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f06fe956-6355-492a-b5a5-be0baf14342c", "b354e439-11e3-4f0a-8686-22dbd31a8937" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8163f487-4c2a-46d6-82d5-a47e373f6284", "e6bce0da-8dd4-4f29-8e69-1af9699635fc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9dd5f9c-25b8-4eea-b08c-4dca693232c9", "d3b1c13d-9d6a-48b7-96eb-7679d891d2a4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52e0eefc-0ff9-42d8-9237-2ba5ae5a318d", "7700ef47-0541-41c4-9336-d2e09abc6679" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e22bed75-6fc0-4a88-a1ac-8b7b04f75b88", "0838813c-34d9-4a44-9ecc-474ad933f506" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e83859f-f909-44b9-9169-e8792bd40b35", "2dcf82b1-525b-4866-aac3-31dc7cdb032f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7f22b90-acce-4124-b841-f0c4a8d460e6", "cc290f7c-ec47-45ee-83f8-0c43f069db21" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ead02c5b-4d93-4b52-acf9-cf836e1c94e9", "ded49b44-09e3-4415-8e7c-24e5643be585" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "282de4d7-58d0-4bb1-9918-985e9b4cb003", "3b1ad62a-06ea-418e-97d2-0e6f5a7e15f1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c83e270-6b00-4ca6-a9a8-30b49a258bf6", "5608482c-34cb-483a-85a0-cd84822b1cd0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "335a5cbd-9af6-4ec4-af91-db07029aefe3", "7867857e-f741-4fee-8c2a-69f08a78f4c2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b4c0a243-748f-4361-8cae-dfbc8ed83416", "d6664c54-ee8f-45cb-9e15-64e444d5e111" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b6c469b-d058-4fe4-8524-a0c0dda32be8", "57d468c0-c33a-4bcf-bf0d-435ac5a59731" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10516454-5615-440d-8c48-b0bd56517916", "873b753d-3389-4751-bc1c-139f666591fe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "598065a9-968d-4e20-a591-2ea151fdb49b", "a4a0a5d6-ebcf-4cd0-aaf7-1bf5a0507149" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e4c2d6f-3f10-4ab8-8a16-3c5701f5a5fd", "4b676cea-aa22-4925-94e1-cab6f239319e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "970112fe-5277-4b21-85b1-f1f00982ef3d", "ead079d9-cfe6-4154-9940-9774298f007e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f888ca54-5045-4016-9d5f-5c54437dc864", "86a16185-9da7-468f-86f3-b95c4e6e1b12" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e01925c9-51c3-429d-ad15-bff0658eeef2", "f401fab3-5274-4b18-8608-0851f00cf3cb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b9da121-7e91-4621-8bd3-e007411b0d6b", "3f3084ba-f92a-4db3-9dcc-3f6ad8905244" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61102ccc-4fb4-4e7c-9f8f-bf31cbad19f7", "18cbc15d-95e4-4ccf-a153-0cea749c6787" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0685cf81-6007-48d9-ad68-ee09060c89a4", "87fb7fd7-96c8-4dfd-b275-3856e963d20d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5757a361-6c4d-4cb3-af66-6ebc03c51529", "3426d2d8-fefd-4e28-9fa9-c27a0d382931" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f8081b63-4526-4418-afd8-580707bf5015", "da45d5db-59bd-4ced-a260-066a79a659ec" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84b7d436-f5aa-4eaf-bd5f-137df01490ed", "e818b456-1c23-4aa9-8649-849d44df5d0d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3293cd17-9d96-4d7e-bae7-ffb6c0eb4610", "3f4660d7-71e4-41e8-b589-ce145298cfe0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7696243a-4a60-4be7-847e-b1196c77670c", "41425363-643c-4029-97b7-f1345feb7988" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32074e46-643d-4e33-8cfd-5ccb2fd5e999", "1633b729-dda7-4e73-99a6-988ce149bcac" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d179e96c-6153-43e4-92b1-39d31ff8444f", "9067904e-5e75-4c8c-a1ea-58845670436b" });
        }
    }
}
