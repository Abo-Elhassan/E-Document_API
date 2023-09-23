using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeRequetNumberStringStep1 : Migration
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
                oldClrType: typeof(long),
                oldType: "bigint");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest");

            migrationBuilder.AlterColumn<long>(
                name: "RequestNumber",
                table: "PoRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
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
        }
    }
}
