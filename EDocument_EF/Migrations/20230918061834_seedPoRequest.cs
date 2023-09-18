using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class seedPoRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.AlterColumn<long>(
                name: "RequestId",
                table: "Attachment",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "DefinedRequest",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DepartmentId", "ModifiedAt", "ModifiedBy", "RequestName", "ReviewersNumber", "RouteName" },
                values: new object[] { 1L, null, null, 16L, null, null, "PO", 1, "/Procurement/PO/" });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 21L,
                column: "DepartmentName",
                value: "Engineering");

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
                table: "Section",
                keyColumn: "Id",
                keyValue: 16L,
                column: "DepartmentId",
                value: 14L);

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

            migrationBuilder.InsertData(
                table: "DefinedRequestReviewer",
                columns: new[] { "DefinedRequestId", "ReviewerId", "CreatedAt", "CreatedBy", "DelegatedReviewerId", "DelegatedUntil", "ModifiedAt", "ModifiedBy", "ReviewerType", "StageName", "StageNumber" },
                values: new object[] { 1L, "51124", null, null, null, null, null, null, "Basic", "Finance Reviewer", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DefinedRequestReviewer",
                keyColumns: new[] { "DefinedRequestId", "ReviewerId" },
                keyValues: new object[] { 1L, "51124" });

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

            migrationBuilder.DeleteData(
                table: "DefinedRequest",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.AlterColumn<long>(
                name: "RequestId",
                table: "Attachment",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 21L,
                column: "DepartmentName",
                value: "Technical");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "6081e33a-3e1e-491e-ad77-5252ebbfec01");

            migrationBuilder.InsertData(
                schema: "security",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "19cb41df-c4f6-4104-8291-3e928f1ca1e9", "HR", "HR" },
                    { "10", "c38ef1b7-40d6-4636-a6c2-2d6ef748f28b", "Engineering", "ENGINEERING" },
                    { "11", "869dbd17-c62e-45aa-be2d-1e6c9260a059", "Commercial", "COMMERCIAL" },
                    { "12", "3ac48a26-bb24-4637-9c3a-f5be3258f2f0", "InfoFort", "INFOFORT" },
                    { "2", "a69bf47c-1425-4940-ba1c-64332d1c4d53", "Finance", "FINANCE" },
                    { "3", "7a3c811c-7035-4c51-9f5a-4e8d152f96fd", "Procurement", "PROCUREMENT" },
                    { "4", "ca6f6b1f-4867-4a18-8edf-0480d521b196", "IT", "IT" },
                    { "5", "6125de1a-5c68-4f09-8f49-534f09f024b3", "Security", "SECURITY" },
                    { "6", "306169ea-bee3-4f58-8cb0-9612c32b5db9", "Adminstration", "ADMINSTRATION" },
                    { "7", "ccd03a53-895a-4ea1-8d9b-0a2a56acfd8a", "Stores", "STORES" },
                    { "8", "d3c70f64-1fcb-4cc2-8da5-b243cb06c3ef", "CustomerService", "CUSTOMERSERVICE" },
                    { "9", "d37923ba-d564-4447-a8da-864ac388ccfe", "OperationBGC", "OPERATIONBGC" }
                });

            migrationBuilder.UpdateData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 16L,
                column: "DepartmentId",
                value: 15L);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e7dff19-067e-4b13-820d-67680c8a6a7d", "07963c3d-0af9-4a5a-bce0-c652e3f7e088" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbf10b61-4fd8-46a8-900e-7dce8990dfc8", "90cadb47-d8a1-4c2a-afdd-02ab8a1bcbe3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56f26aab-c252-4572-b9fe-dc5cd277c37b", "c017beb8-7e5e-4afd-8b55-d7feb5caef4d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57709cd5-6494-4f9b-bb90-aec2e6a70969", "344395a3-adfb-4c29-9213-103a2172a02a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f32574c5-880b-428b-b24a-3d165ee37db6", "42035649-a95c-4443-8461-d3bb7d936017" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dc022b61-d188-4dff-97fb-3624074a5ef2", "d5547d60-d23b-47e3-adfc-dfa484163f9f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0350d5ef-86b3-4f72-a79d-ab826bfa6582", "43ef352f-0676-4111-9a82-86c24897f63e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a812790-144c-400c-a3ba-a185e609663a", "fe62849e-5cb5-4dac-bbdb-d4c4d9c54ffb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7c4bed13-f4e6-47cf-9010-6d32dd18805e", "25168321-4de6-443b-8c46-64908293277c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a42a9987-f611-4716-950c-3b18995d5f49", "bae93d84-e817-4d78-b1b5-47ddf62b0241" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9d07c6c8-a649-4337-ad1c-e14e05f7f284", "aa578934-d8e5-454e-a8c0-0dc8d63d11b4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "68151fe2-dcb6-48f3-83f3-17cbf970dc58", "53132ae9-1d6e-45ab-83c6-0b2a50325c37" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2ed82a3f-83eb-43e6-a605-13f504443821", "acbbd2bd-59d9-42d5-be6b-1ec900ff58e3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0973bb54-6fbd-4a91-adde-8d6b4522d177", "683225c3-a8ed-40c3-a3d8-d2c60a865370" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e975249-7f3e-4e2b-9d29-db9c66c17d8c", "1c3d13ae-7680-4954-901f-b25289b93c5a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "58553545-3c95-4964-8ae7-31cba9623f16", "1ff386bf-a4ae-4284-b026-45a06d8c5cd1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38dd8837-dd11-4e6c-a320-8a7eb118312b", "c3f6e9e0-df59-4c90-8cd1-4c754afaa0b1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3669e54f-1187-4836-94c0-5f13f280bcb0", "304b062a-839e-45a6-b234-66d696c177de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecf259a3-b872-4056-9349-63cb85fb1347", "cadb5f96-a017-4bd5-95d3-bb450afafaa5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fadc0add-36fc-4d5a-bbd5-0a05595f29e4", "0686a839-4f96-4cfa-ac97-8125d65e2544" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d843edb-f112-47f0-a2f0-0ee490eaf006", "cde61c48-2643-4834-a1fe-8dbefd264dd1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea0e4014-805c-4d4f-8361-19822c9a16ce", "37392a8c-f7fe-48cf-a685-2c45e34363a0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a95536b2-9ee1-438c-9750-4f319e71a1d9", "fea55a2b-4785-4c15-877f-59811d7ce252" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da64804f-695a-4952-8bfe-d75a4cb42e86", "80942a33-c850-4691-92b9-97465298e05a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c782d13a-44af-42de-bd58-4befcdac2730", "15e7c0df-3e09-469c-9236-545e5ae2c4d3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5886498-cb3c-4d74-a287-d5b5ff8cb332", "030bb6e2-9109-4964-88bf-f31c361bcf66" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe20bd80-2bc5-44ff-a5c6-52f29b387a83", "8bec993b-354f-4133-b735-49dcf0cf4358" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bfe8cea-840b-4fbf-92e4-c83f6ca0999a", "0d4a211a-4cd3-4dbb-bf9b-b435e0cfc4bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7539510f-957a-4f3c-a641-6320472a2c4c", "24cbb6e6-8825-4b6a-ba53-698b67b5aa89" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8aa0e3d7-58a8-4e65-aaf4-420b17d8e03c", "3f6958ba-4ec1-4f67-8212-a017bffafadc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6f7065f-3496-4c29-9062-03a5ba86f9d8", "1e7a64fc-4c7b-43e8-9ac5-dd507ceacd0c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38a2a7fe-2e12-4f86-bceb-30243190c8a1", "acc05dd0-c119-4766-b5c2-01a635b0ca30" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d6c31ca-6b87-4963-93cb-80c0390adf47", "e8126543-572a-480e-9b27-46e76dab03a5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fcaf19ee-937b-4e5b-b4a0-9882903d18cf", "a0517324-941b-4e51-a028-a99bac3fb336" });
        }
    }
}
