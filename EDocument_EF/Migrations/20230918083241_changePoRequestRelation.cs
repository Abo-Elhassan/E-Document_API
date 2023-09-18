using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class changePoRequestRelation : Migration
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

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0937b70d-c7a7-4327-a4f0-09ad429cf649");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "13a997bf-b77d-4681-b54b-27101ed3e2bf");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "235cb6d0-773d-43ee-a834-d281af43df33");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "236458cc-bf69-48a1-8f0a-76bc7e7cabf5");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "25433038-31b4-4d31-8366-643474a97f30");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4fdca980-9f10-4f95-a201-b84d2bbbcdf0");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "68626d86-e0b9-47d9-922d-70fa9dab36ec");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6b75e509-d3c6-44a9-923e-88e5d3e4b127");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "80b35ea1-250c-4bc5-b33b-f066b6242822");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9f3f09e4-d757-4f4b-9fe1-ccb8e758527b");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "cced50a5-4872-4695-bf5b-3ceb8274b009");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f242ea9a-8cfd-47f0-9388-a2d5b1e6b890");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewerType",
                table: "RequestReviewer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest",
                columns: new[] { "RequestId", "PoNumber" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "3ef3ee55-3306-4ee8-b13d-7f59dd5dc112");

            migrationBuilder.InsertData(
                schema: "security",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0475d4bf-1c7c-4fe8-bcf1-2495320781d3", "ce07fe33-3a72-42bd-a3a8-1d644e7f494e", "Finance", "FINANCE" },
                    { "1ad54b5a-eaba-49ab-9fc2-b4a736555301", "16a7f9a5-ab6e-4774-bd4a-3d7fc9cf93cc", "Stores", "STORES" },
                    { "1b17dbf1-cf80-4eac-bc85-473e6e8fd9c2", "1873180e-e4c2-4856-9a24-17a32eef69b8", "Engineering", "ENGINEERING" },
                    { "6a64020a-3b1e-4192-bf0c-4c254612048a", "5fead976-aa56-4d10-a5b1-d0a9c970a96b", "HR", "HR" },
                    { "83f4f467-264c-4b73-8533-c18208ac707e", "3394ba54-c866-4231-912d-c8ff21e338e7", "Commercial", "COMMERCIAL" },
                    { "a934bbd8-7a05-4ae1-95a0-67991ae4ad02", "7d6477a1-07d6-49bf-bc6b-6f977033510f", "InfoFort", "INFOFORT" },
                    { "c4a2fc25-ebbd-453b-bb91-879f11200c51", "7d383d32-3422-488f-8902-3b41d9fb8350", "IT", "IT" },
                    { "c7ef0e0d-9a1f-4d93-9198-f7b55c57374b", "32ba5945-cc9f-4b69-8004-e23ef83fc4f4", "Adminstration", "ADMINSTRATION" },
                    { "c92e2572-43cd-4260-8684-242a72524ce9", "e2b67cb2-484f-4746-b22c-8a842fe09e9a", "OperationBGC", "OPERATIONBGC" },
                    { "e75506cf-91d9-45ef-892b-8d5632e6d756", "7f331050-c2f0-4bcb-bff7-2ff92c8aab78", "CustomerService", "CUSTOMERSERVICE" },
                    { "f2edfb76-0e1b-441a-a0b5-d977c54439c7", "dbf4588d-dbf5-45a1-84d3-3515ce29dd29", "Procurement", "PROCUREMENT" },
                    { "f6180899-b44a-4e68-826a-10d392baa20d", "21d3eb4d-4114-48c9-9c42-4e2a262434f3", "Security", "SECURITY" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d8763a3-74e5-45ef-aecf-22e8b80f04a5", "9d5c942d-759f-4390-bd9b-7e29f0e61225" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13cf9bac-0063-441f-85f8-a6e6d3ce72de", "97fc3a26-abd9-4409-b662-5ae241ad15f5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d24d86d1-71e5-4932-83ef-1405678a040b", "cb1c60b0-384b-4869-bff0-3f7e6c87420d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d74c97f-eb32-4bcd-8f79-c0ce6eae074f", "9be3f20a-331d-4236-aaa3-62168e768528" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "97faac78-adff-42db-be05-2822bd8ca523", "86008418-ea24-4479-8554-c3fad3765060" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7aa734de-c761-4391-b868-35c948c59941", "1edb1a28-4753-4b28-9ffd-878137b40141" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "818e9573-3be2-4a87-ae14-af44c3d22f9b", "db01825b-c127-4759-aea2-55a8deb20d57" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06955591-6afd-41ab-855c-62476672ad45", "a7fd45b0-d16c-4ddc-81b8-4227ca1be4e5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdc79f42-f9ee-46de-8728-7666ab22969f", "de114459-e05c-450d-a2f1-a29fa53be04a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6caf10fa-c60f-4576-9331-ae6df549700e", "d51eab43-cb28-4b69-b92f-4326f6939310" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "331ff344-34f3-4544-ad29-d480d8505d14", "5863a8d5-f3b5-4989-99e0-661a6c5274f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5c41028-a39d-4814-91c1-980a166fd0b4", "95499db6-1d01-4731-a662-e1e0d0bd210b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "070bc85e-592d-4081-a909-9bc1c1499cbc", "79cdc3bd-c639-4a5a-9f02-9234f3a5e196" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82101706-fbc5-4162-8dd5-98a8a9b82fae", "cd9c2f60-72bd-411f-9889-d947fca8b766" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3aa636b6-876a-43a9-aaca-6506f66dbbb0", "442a4a51-428c-4e52-a42c-9e8488a1fdc8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e9b702e-dda5-4e9b-9aa5-e58224255e73", "8bee3ffd-8ecd-43e2-8cbd-de36e0112b95" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32e852c1-f893-4cc0-a974-55ec6aa5f439", "632ea0de-4b53-4c64-b176-35eef86eba33" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89a9f8ef-2967-41b6-8bf4-91a8886d2bf8", "af8bfeb5-5357-445b-8a96-5e0693eb9944" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ddb3383-c9de-4e64-b868-120bf6392aa3", "776a7de3-c384-4157-b669-22e54f6706cc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c66a2c4-552d-4468-9c34-a71f8b366f30", "82ea2120-d7c6-4709-ad80-b13ad59837eb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e4abd47f-625c-4385-a47f-352818291660", "30f82829-5004-453e-ba60-4563ba6c73fd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4568f4db-b5c1-4144-b614-f95f14f5f6f1", "ea8d042e-2620-4c18-8a30-621fe67d52a8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd49a6e9-1d96-4e0f-b7f2-89c8cc1c0681", "811e1984-31d5-433a-ab09-2619833f490e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4b613c3-23ed-45e4-b3c4-d4c2e2502224", "3efc9109-7e6a-4bcf-b9e9-0a1de1377da9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ab6c9da-e62f-4bb7-874e-24e37e4f794d", "f9d0f8b6-4ab5-432d-92fe-e51128570cb0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c2b9d55d-c7ed-49f5-b2fe-2966b470abc4", "fcd585bc-035b-43e4-9be3-72597fe3f45e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa9a6674-42f7-4c1e-af5d-bb293885f8b6", "47ee76e5-1ff1-425a-a20c-ceba4302d5e4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f2c60cf-a5e0-4913-b585-092947059268", "742e9f77-e747-4800-8bdd-de06e1e29701" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8e4421c-e8f3-409d-b9ed-afa8af0f1065", "b0b23bcd-5b6c-4590-94ed-183cd1881f1c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81e4912a-3942-469d-a704-381ad5a8e446", "3aee8492-42b8-481b-a0c9-08322f624983" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6c7066b-c957-4bd9-a0bd-2059cd4917cd", "1c32d60e-4e47-4bbb-9f77-60df41be0f65" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56d43417-fbdb-4819-ae01-cd5592332b70", "a72950c1-b020-4631-a0e4-52dc4c0e2868" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f488dcfc-2fb1-484f-8b0a-e8a403140e8b", "41fcf23d-129b-4896-b97c-b001421e19c2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0147a7bd-a7f0-4f5b-8d8f-cbffcd59f367", "ed03d981-35e5-4894-a332-80590efe2f48" });

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_PoNumber",
                table: "PoRequest",
                column: "PoNumber");

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
                name: "IX_PoRequest_PoNumber",
                table: "PoRequest");

            migrationBuilder.DropIndex(
                name: "IX_PoRequest_RequestId",
                table: "PoRequest");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0475d4bf-1c7c-4fe8-bcf1-2495320781d3");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1ad54b5a-eaba-49ab-9fc2-b4a736555301");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1b17dbf1-cf80-4eac-bc85-473e6e8fd9c2");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6a64020a-3b1e-4192-bf0c-4c254612048a");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "83f4f467-264c-4b73-8533-c18208ac707e");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "a934bbd8-7a05-4ae1-95a0-67991ae4ad02");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c4a2fc25-ebbd-453b-bb91-879f11200c51");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c7ef0e0d-9a1f-4d93-9198-f7b55c57374b");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c92e2572-43cd-4260-8684-242a72524ce9");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "e75506cf-91d9-45ef-892b-8d5632e6d756");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f2edfb76-0e1b-441a-a0b5-d977c54439c7");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f6180899-b44a-4e68-826a-10d392baa20d");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewerType",
                table: "RequestReviewer",
                type: "nvarchar(max)",
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
                table: "Role",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "a7022658-8b47-4af3-b36b-972240269599");

            migrationBuilder.InsertData(
                schema: "security",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0937b70d-c7a7-4327-a4f0-09ad429cf649", "2c76ce62-0086-40d2-819f-ae9ce93f4c84", "Commercial", "COMMERCIAL" },
                    { "13a997bf-b77d-4681-b54b-27101ed3e2bf", "49c963b9-7bac-4a4e-a84a-638224b57928", "Stores", "STORES" },
                    { "235cb6d0-773d-43ee-a834-d281af43df33", "d95ea410-d668-4979-a691-8711015f2bb6", "Engineering", "ENGINEERING" },
                    { "236458cc-bf69-48a1-8f0a-76bc7e7cabf5", "4488de76-2476-42ba-b34f-77f92034f066", "CustomerService", "CUSTOMERSERVICE" },
                    { "25433038-31b4-4d31-8366-643474a97f30", "b49736b9-97d9-44f0-a77b-bb4767b3915b", "Adminstration", "ADMINSTRATION" },
                    { "4fdca980-9f10-4f95-a201-b84d2bbbcdf0", "1dab5fe5-c2a9-4a7f-9019-163ea59dec67", "InfoFort", "INFOFORT" },
                    { "68626d86-e0b9-47d9-922d-70fa9dab36ec", "14a64bd7-3fd3-460f-8200-e8cd1871a50a", "IT", "IT" },
                    { "6b75e509-d3c6-44a9-923e-88e5d3e4b127", "1da10d7f-2f8b-4b9a-9167-70ff0d173955", "Finance", "FINANCE" },
                    { "80b35ea1-250c-4bc5-b33b-f066b6242822", "7be272fa-ea4f-4a62-9c01-52321e57e4b7", "Procurement", "PROCUREMENT" },
                    { "9f3f09e4-d757-4f4b-9fe1-ccb8e758527b", "ba5456f1-5dcc-4ab7-94a3-1db255a9e1ac", "Security", "SECURITY" },
                    { "cced50a5-4872-4695-bf5b-3ceb8274b009", "8b77085b-af7c-42f2-b2c7-211d1c6099c9", "HR", "HR" },
                    { "f242ea9a-8cfd-47f0-9388-a2d5b1e6b890", "9385fe2a-1348-4d23-9097-030e38b238fa", "OperationBGC", "OPERATIONBGC" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3aab3242-59a8-40c5-a106-b771375139ad", "c09787ec-a29c-4f01-86be-0202e1d1412b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7cf2738-37c5-40ff-8a97-329fc1753f58", "deaf132c-3ab0-4855-b564-94852a4e616f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47237a8b-f699-45d4-8c65-48fbaf664d6f", "1b26fe7c-af7f-4fb7-8033-ee0d2c3fe222" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93db801c-3047-4dbb-a779-a714e1934b70", "7f7b0bc1-b57f-4b8b-a23c-e31bd7a4605f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa46e48d-926c-436c-bf7a-0b7851560839", "00e06926-3678-4d26-ad6c-b4cae5cb1498" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9b3d4cd-9dd4-41f3-b5fc-9b9529bff5f5", "e1805422-ea3d-48a9-9b11-f0f674ec66b1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0170d38a-d0a9-4ac1-b945-52b0ea0ba532", "7f3a4b82-6efd-4f6f-bb47-d34c67d5cc4a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4f6f8fa-ecd9-4d9d-8021-2622dc033a16", "c2f63ba0-ac51-440f-9134-ca50929ee5bd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a4e38b1c-b6a0-42a6-bcd4-6bf5fdd97e57", "0d686eb6-ed0c-441b-9e98-6bc1b507fd43" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b877ef59-66f7-4616-b120-5be93e127ead", "93f229bc-0e8a-49fb-a8bc-2fa4ab50f660" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a071f2c8-26be-46a1-a710-d47064c443d8", "eea2ba9f-6403-4de9-b74b-cda12f5c9e4c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38716e38-4812-4d60-ab8c-615b215d48e1", "9a1ba9a6-588a-4c0f-be07-a1c5bb3ea5a2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "efa0bb76-9d6f-4ea8-b6c8-0fd9de95590f", "ad3d64bd-eef4-4ff3-b16f-39d2a217281f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e462698-e804-4404-bcb2-8d3673114e7e", "8defb0c8-711a-4463-a170-15869cfab079" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "082865e7-2076-46c3-af85-54a05c932ddd", "a365f9af-5dbb-49fe-98b1-d0726de1f619" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30335d14-5675-4692-ae13-3a5011a807fa", "c93081f4-b0af-4aed-acea-73ade542ca90" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79c84e52-4a80-4599-b5ee-e19b748428fb", "b9f0a448-99d9-4438-b693-48c7e191b715" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdccea9d-040c-4fb5-8b38-b495d1ed923c", "9a2ca8c7-ab43-4f57-9188-e8994f86d4b1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b9f8910b-aad4-4c6f-a635-c8427d46d812", "d7be2b34-0fd1-4cb4-8100-d2aa6730fd7f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16d27ba6-6383-428e-9e15-82e7764dfb08", "a4c2bb42-4fc7-4dd5-a157-38c6e8c4e6eb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43f91def-e0d7-490e-bc94-f7bf82ffd387", "a0ddee45-fadc-43e3-b8e4-61ed1cfe1bc4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9f5e21c-04d8-4ab0-8235-680838bbc7c4", "6c0cff89-c898-45c0-9387-4af281ba6d2a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b22c6e6-5880-48af-a906-0a213c30ed93", "af70e15c-db9f-4311-ac80-75156bd586ae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7d4cdef-c633-4154-95a8-ef160daa5c8a", "a56de337-316d-4031-8d18-b2104c757a62" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8ae8533-b41a-4c62-b98f-55018ae24a20", "ef471b3f-fae1-4be9-874e-f809a2095b58" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "35ff0090-bdb6-4a2b-aa52-5a8d86046838", "251e2fe7-7841-48f8-9a46-1d370a7ba498" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89785dbb-d6ff-49eb-897e-a8f54b36240f", "0304979a-8d40-41a0-8ad4-cf05f9399256" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d78aa800-8eae-4427-a7fb-76afb1a4c66e", "8dac52b1-3c4d-453a-b4e8-09304fbe38f4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a003e4d-1ca1-4898-8e32-70427c420ff5", "799c4b16-ac6e-466f-b46b-e271c1f5ff79" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7195974-aba6-4809-8783-819ac33b689b", "7fca1ffe-a694-423a-be91-925bb6c58f72" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5947a61a-6cd4-4926-93c1-d4b96475e17d", "38fa6da5-54c9-48dd-b3df-08f84ed2f9bd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e10ba502-9909-4536-9db6-46196e831f97", "4c407d86-4944-4634-98c7-7b1e549b145f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f488338-1585-4a91-82e3-ebff18ad6daf", "8e2d8108-7cfc-432d-8ddf-22a94e084901" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0fb2550-4897-4a1f-8f32-5148fe29f270", "f5e2f3dd-7947-44a8-92b2-d700ea3b9b84" });

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_RequestId",
                table: "PoRequest",
                column: "RequestId");
        }
    }
}
