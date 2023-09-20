using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class updatePoNumberIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest");

            migrationBuilder.DropIndex(
                name: "IX_PoRequest_RequestId",
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

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_RequestId",
                table: "PoRequest",
                column: "RequestId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest");

            migrationBuilder.DropIndex(
                name: "IX_PoRequest_RequestId",
                table: "PoRequest");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest",
                column: "PoNumber")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b296be3-e90f-435e-b9e8-bcfda9b38570", "fee28212-09b6-4a90-adb0-9a1a56f2204e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7dc84ddb-25b1-417e-bbc5-73e4859adf78", "c36a000e-964a-4a62-8650-1bf0419df9bd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b6786f9-4ab3-4cab-af81-407f00549f0f", "043df747-20e7-43c5-a3ea-d67554583572" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ea98ef4-79e1-42f1-9ef4-b7fb8093c8c1", "b66b6166-16e1-4581-9408-c2a4e0640d29" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37423a77-f9f7-4c4a-9429-d8cd7be8e91a", "e86550e4-38fb-489e-a3fa-df4bdfbcabe7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1085e140-1ebb-4f1d-a825-32b3f07c086a", "295acf0c-d4c4-487a-a16b-96d1a3416938" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f98f636-595a-4f1b-bf1a-d9ec23f2dd65", "7c4397eb-e0b0-44c4-852c-8ff2c298830e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a62be87-55d6-46fd-9b55-65c710f96d1e", "9ffe20a4-c4ff-40de-a15e-f23bb355ef26" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78c79334-2572-4455-8ac7-8ff27c783a9a", "e3a4a21e-dfa0-4409-a251-498fe8c08b6d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e17ee457-2bdc-4ffb-9880-fec23efba4a7", "a507cc6d-633f-4b76-a56c-4acba38b94b6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d28e1ffd-8831-42f8-bd56-883b96845d2e", "50ea8586-fe39-420c-b3ea-8e2cecf97d81" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0926140-798b-46f7-a5c0-80b155d6b290", "076d9550-6836-420c-95d0-10affc0d675a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0e30cbf-c2e3-45b1-bfab-5f48aa2bf5bc", "3f878dfb-fbb1-47aa-8ad3-3d427cb61985" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "446b35ce-27c3-493c-b832-ec43e5a5325c", "8634f444-b595-4832-ba26-cdc6044a0ec9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d67bc09-f67d-4123-9e7f-19c126d3aaa2", "c427842a-422e-419a-adb4-f0c6c8bd506c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1448a88e-4777-4e22-9951-3c814e38a6da", "2da24c41-9e30-4a0b-aba2-ededb6857d10" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff310e51-3a64-408a-9f07-bf23a94e6bc9", "9b67fef2-4d6b-41ff-bd94-6ac2d167b1b0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89563787-92a2-47d5-a5b3-713aa4a398f4", "2a4f1716-6bc1-428f-bbf2-5c4d9adabbe2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2234a08-b891-4dab-827f-84a19d91e1a2", "09ea0082-957b-421d-817f-b68f80159183" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "73f8d365-c650-4b6f-97a7-841dd9b6fa81", "dc0fe763-fa12-402c-ab63-54fd473eade6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fcc5eab-3a2a-4e4d-b44c-8f0b23d01451", "213d01c5-df20-45c7-8712-4aefe5dafad8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7261ddb-b792-48a0-b9f1-6b2db122fec9", "e1afcf2b-307f-4703-a6a8-1cb21e02dc4f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25ee194e-8d2d-4469-9e6e-7fc4469a5a2e", "1ec7cea5-3b94-4e51-af61-0d717e395430" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7cac9b91-2d8e-4414-b0b2-914309f1792c", "feb54c49-585a-4ee5-a06f-42c3888086cf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8470ff5e-364a-42b5-ae3f-7005d660b25f", "b8a30c24-4cad-4643-9760-3562f370d32b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6734c4bb-3d2a-4164-9898-b507a86a4e32", "72ad027f-7224-4140-9942-f5d2fadd417f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3651ef1a-2f11-4682-9b40-5e402115a88b", "caa031ff-e60c-4094-8757-8439b8edade4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5118b3f-6c0c-4ec4-9ec9-73e39dcf2f4c", "1b0d7b96-2280-47a3-9860-fcdb649a21ed" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "146474f2-ec03-4dec-9dca-f0fca2f19d57", "b637b62d-9cd7-4b87-947e-7cee23e733b7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78698334-03ab-4ff9-ad81-5111ed25f9a3", "6ca551c4-8ce9-44e9-86cd-1393f1f847be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7dee6aed-228a-4b55-81ca-ec788fdd1610", "70f0bdb0-038e-46c5-a8a5-7d06427c3727" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb99fee6-e3e0-480c-a95d-e6da568ee5e6", "fe4c378a-64a3-4154-a32f-793eeab26c27" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10c19ebc-54fc-45ad-8dbf-3b39bdc61cc8", "016c5977-00a0-4610-b346-0bb470940191" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d904e7f7-345a-42f6-8a63-a518c3d5f908", "eddb01af-d555-46e2-957b-281af8e8e3cb" });

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_RequestId",
                table: "PoRequest",
                column: "RequestId",
                unique: true)
                .Annotation("SqlServer:Clustered", true);
        }
    }
}
