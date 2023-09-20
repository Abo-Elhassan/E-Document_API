using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class updatePoNumberIndex2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest",
                columns: new[] { "PoNumber", "RequestId" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57146219-a5c8-4f07-8387-e00ceeb34e26", "178fd040-7c93-459c-8371-018bc0984795" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b4fb7288-deb1-44a1-be16-6a6fbf492820", "199259fc-277f-4bee-9ba0-12c54ceae1dc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5fc73ae-6630-4bb4-9db2-7a8bf3f60d22", "b32b0283-fdd4-4ad6-b2c9-8910986a66f8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7b2a0d1-9ffd-4f46-9108-ea88339781e2", "c40ae2d5-e454-4059-9ed5-2f9449c8f53f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a8a8950-5739-44e9-8fc4-2cff2291926b", "81c6d860-b39d-48b5-ae0f-92cb7f083d32" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3e3763ef-620c-49f3-82e5-554691c89545", "ac5df369-14d8-42c7-8576-2dead277fe4f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86f79a4b-b095-4872-9c6d-9bf6afe47cb4", "504a12cf-571d-4cc2-9b4e-e6219e131ac3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e807ef7b-d5e0-4738-b8fa-2d94e24839bc", "873b59ac-362f-4a8d-8659-a906f0e4c999" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e70cf20c-9f2c-4d4c-ba25-cb02ae571481", "89c67fe0-2c2a-44e8-bbf0-4d6714603557" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89a32404-626d-4335-8208-4528a09a481e", "fb07f64e-2e82-42e6-ae61-e3054c9becc7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "581cfb9f-1890-4c92-a7f5-c464385bea34", "e7ec0ee7-29c8-4026-85ff-8d24662d7af0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "038986f0-8f37-419d-96c5-4fba59cb63b8", "d939afc0-dfba-471b-a991-d718327f102b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c36c6df-d8c3-449e-9237-8897445f6738", "d60f9d46-84f2-43e1-9206-3adb2b9a1d47" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62a0ff01-3d0d-41dc-b102-f8e321a80c4c", "72608bf1-ac62-4e41-83b4-a4ebcec08c99" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "614bc441-30df-43b8-bb50-1da511362234", "84330fa7-3ea3-4fd2-8425-beb2877e1943" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1dc6bc1b-6ed2-4188-ac3f-d44459bdce67", "9fddc06f-e1a4-4047-b88d-e2ec02db1e80" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f75aeae4-6bca-4b46-9869-2a6b61905c7a", "f0a9e500-307d-4ede-9a04-41950bb059cf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34acfd0c-3088-4e33-8a9e-287a95836734", "df89f325-8414-43a8-b531-6a9982bd2c2c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccfb31ae-76f8-436a-a6b5-f85f5b5fa052", "2ca19fca-1606-479e-9145-8a57e231b237" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1d6b61c-8efb-4278-8866-3bef7dc3a827", "928a0979-f5ca-40ac-bfa1-670a129d73e9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "326b00cc-5c0b-48a6-a97a-b7175008e354", "715f44c5-90cb-4f69-a3f2-ecd9c7b44e5a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12116f80-864f-4d7f-8595-97bb947c4355", "b1508ee7-8881-45c9-bb05-5c39c548f0d6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4aff2785-54b7-43a0-b1a8-ebb5ba189ca7", "9c95d0e3-6421-42e2-89a6-ed962dd98b7a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3744c1be-c114-4eb4-9f1e-a5323f42478b", "2486423f-f61d-4500-b968-2d7729199bc3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81dde6bd-0af0-4c9c-b82e-77994b5901ff", "7f6c2b06-05b2-40da-9842-e5d636e787cc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b68b4bc-bcae-4521-bd28-9638d75c64da", "cdd1ec32-dbd5-4d05-b4fe-2ca2a8c51394" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "98bceab3-b218-4c60-a9fe-0e1ab12b52e0", "ab9f9fe1-9627-4a20-8fce-829119330c90" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c9ba19e-e403-4b23-96ef-a80396dae935", "3d94815b-d4a9-4d25-a467-5d4500d832c0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "beaa6a7b-348e-47d3-b10c-0d574f50ff98", "7973e74e-1ba2-4fd5-9353-09e99936a3c7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83514573-6c85-4632-9e01-e83b5acfdbc6", "6fbfc747-2f71-47f7-9bc9-09e7d26a1706" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3dd19294-4780-4b43-afd5-ab1942ec46a0", "0885aa7f-ba2b-491d-addd-f5fc69662184" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3dc7e2de-7a36-4390-9122-150a2a7dc9a6", "78ac1e00-064d-415a-b346-0b300a4608ba" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bd463c8-f8d8-4d29-8aab-92525368b496", "82c68fe6-2785-44fa-aaae-538dbaa96f19" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df0f54b1-ed99-4904-b7c6-e8ee85bd18c9", "32e445c5-6082-4265-bb8d-73b72ef98063" });
        }
    }
}
