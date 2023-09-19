using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class changePoRequetPk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest");

            migrationBuilder.DropIndex(
                name: "IX_PoRequest_PoDescription",
                table: "PoRequest");

            migrationBuilder.DropIndex(
                name: "IX_PoRequest_PoNumber",
                table: "PoRequest");

            migrationBuilder.DropIndex(
                name: "IX_PoRequest_RequestId",
                table: "PoRequest");

            migrationBuilder.DropIndex(
                name: "IX_PoRequest_VendorNumber",
                table: "PoRequest");

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "82cae434-a43f-4f98-86d2-4de5205a410f" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "9a8e4316-c998-4125-a9ef-af391a9f8243" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0d0f955e-f84d-442e-8676-d8c53839ba37");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "11a62722-df08-4ff6-aafc-773da482985d");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2e66a76e-9fc8-4c38-bdee-07f4e5761a40");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "31f60110-5331-43e3-afcc-86e25f285941");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "39171323-91f5-407c-88dc-67b657f3e966");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "53481cef-8380-4ebe-8ea5-0a73f7a0e6ff");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9b67cbc3-79b7-4225-a765-30f965cfe4ce");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "a249ad1e-f902-4f9d-9b61-e1f0a9158e7a");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c2fc304e-99e7-45f2-ae8e-4eb3db2a6a54");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c6211cfe-eee5-4aab-a1fa-8f546102fe2d");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "cb8fcbe1-2558-4a80-961f-6e683d5106ab");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "ce3f68df-61aa-4e06-9c2a-6f19889bee60");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "e5634c42-82d8-4889-be9d-89d92b77d426");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9a8e4316-c998-4125-a9ef-af391a9f8243", "51124" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "82cae434-a43f-4f98-86d2-4de5205a410f", "51188" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "82cae434-a43f-4f98-86d2-4de5205a410f");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9a8e4316-c998-4125-a9ef-af391a9f8243");

            migrationBuilder.AlterColumn<int>(
                name: "VendorNumber",
                table: "PoRequest",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "PoDescription",
                table: "PoRequest",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest",
                column: "PoNumber")
                .Annotation("SqlServer:Clustered", false);

            migrationBuilder.InsertData(
                schema: "security",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "003c94a9-2b22-44c9-91ec-6dd39dfc5087", "e03394d2-fb9f-405b-b8c0-270fcaa013f7", "IT", "IT" },
                    { "215fa3d9-3ffb-4f20-a593-c44c9459e549", "207c00a7-4fa6-4a39-84e1-db37cdade5a8", "CustomerService", "CUSTOMERSERVICE" },
                    { "3ad339c1-015f-4d91-b1cf-e52e52d7c224", "e439f57b-c170-450a-bc0b-777314080d6e", "Communications", "COMMUNICATIONS" },
                    { "82f0600d-246b-40a6-9e98-3b205bb9edea", "c2f65c5f-92ec-4fdd-abd6-66b50cfdbc49", "OperationCT", "OPERATIONCT" },
                    { "83446d32-9121-40c4-b9c7-04b3eebcebcc", "80ee29ad-2bcb-4e18-8507-8d1c0b430b47", "Procurement", "PROCUREMENT" },
                    { "8a3570b7-ed56-4856-9c67-5e429a2d1754", "e89ad7f8-6f4c-4e37-bbe4-8a7aef9e2b94", "InfoFort", "INFOFORT" },
                    { "9ca70fe6-4fea-4f95-9973-997d1faa9ea9", "db06f0f4-1ee7-4640-b86e-f36d6810fa4c", "Security", "SECURITY" },
                    { "a4baf533-b9c9-4418-a3c9-19073b35b08c", "31f38c8d-2f81-471e-8d12-4f129fb1559a", "Commercial", "COMMERCIAL" },
                    { "b858e94c-5f6a-432d-8b2a-f83ec6601269", "25d5935e-5b0b-4d3c-910c-97dadf8cae75", "Finance", "FINANCE" },
                    { "cddffd35-4b6b-4862-b9f1-c5a5b9f5d5e3", "56dc1184-7694-4cf4-8a4b-7eaa5090792b", "SuperAdmin", "SUPERADMIN" },
                    { "ee86eeac-6622-4d31-9a88-11cc339252bd", "f742626e-4158-4992-8692-ad1d503a324d", "Adminstration", "ADMINSTRATION" },
                    { "f8180bf0-7ea8-4591-8a03-e16788187ca0", "3d231c53-94f2-4e2e-b533-1b6552e3bde4", "HR", "HR" },
                    { "fa217a7d-bace-41c3-8167-0f31f1df1581", "f276fd9e-fe6c-4f66-8772-45b059b39a5c", "OperationBGC", "OPERATIONBGC" },
                    { "fd0bc933-37a2-4e73-a7a4-38e82e023bc2", "e53e72f3-c1e3-4b82-89a7-608fd89bfa6b", "Store", "STORE" },
                    { "ffe4f7d9-fcd6-4f5d-bbae-fc7e8ba920e9", "a3886c65-23a5-4ff4-8587-19886d3786e5", "Engineering", "ENGINEERING" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ea950f3-c201-47ac-8090-23a997aa7107", "c1a3519d-804a-4a27-835a-6416a6c3b98f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "116502a0-5a5c-4f30-b919-d6b3148034c4", "53efe725-f0f9-4e57-b1bb-60f2b49441b2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eedb7dbb-7e54-4b0c-98ea-74b96de93e9b", "c05f38d2-0bf6-406c-8e10-28e74c847c14" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2c76413b-36f7-461e-9eb8-d8d155eba357", "7561a930-a4d8-4ff3-90fa-9145c6ce9842" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b47290bc-95db-4183-bf43-140a993f41ec", "88568c73-4dfd-47f1-81fa-cd06cdeab7c9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70ab26cb-a5e8-4672-999b-0f34a58f5dc1", "a1329caf-a576-46d1-a5dc-d369cec50658" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5abc67e7-dbf3-4b6f-8545-21313c1b912b", "16520073-d3d0-4635-b014-4dee93421d93" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0bc1fd1c-4484-43dd-87fd-3b3a2cbf9446", "b3aa0129-5a15-4e22-94dc-3992389b7e3d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a49a420-9a14-4b68-8688-98f2711e9bd7", "6953c1af-370a-4410-a4e8-091ee5f8cad0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67c6938c-e19c-4756-85ca-cb815729e207", "56673859-e687-4694-a6e6-6c1783064371" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "799b7986-5ff4-463e-abb3-f76cf48f49a7", "bd2ebab7-7071-4388-93c3-7badb387df25" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df875a25-a081-4bae-b828-ab739b4a13a2", "54197663-cab8-4521-afb6-ae538ac69bbc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b27d6edd-bf27-49e1-8e29-99e8feeb4e93", "72021b07-20d4-42ad-80e7-6ffe37ee3987" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aba15c0c-27d8-4e17-9875-57032827489f", "4f262697-0ce2-4704-b61b-56a65163e505" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2ca1301a-0345-476f-bd4f-94fe61239e41", "64fbd760-acac-41fc-beba-71cc995a6369" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "775f0142-fc53-40b4-b779-d36e74535d85", "b07420fa-e981-479e-bbfe-8c154ebe891a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b91f3da9-5a4d-4a52-b94f-f3dc5cf3d9bc", "5e046c55-2d69-453c-af6b-ade2e066037c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45f3c89b-f7e9-4fad-8d76-43bf8fce003c", "c8e3d2e3-4c70-4a60-b9d0-c7a5790e04e2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1fff34a8-63b4-40f8-95ab-25e26ef10406", "6ed70016-15a0-4d56-8ecf-3e766591460d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0211a999-af73-4bae-9b35-5064225dfebc", "3b80451a-49df-4828-8014-7d84194bfb51" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ec59770-2597-4e0b-8cfe-0467859f0adc", "635c5210-a261-48cf-8e76-ed4b5ea102d9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "abd049ea-58be-418c-8bef-bce180aac155", "1cfb5332-4d14-4ed5-b852-6eaca3d4b11a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e8140f1-cccf-4c89-ac20-4e0e67089707", "d933662a-0f79-4d36-989d-0bb92c56a614" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "add20278-33d3-4153-8b5e-eef5bd9e4218", "9b7cfa23-5331-484d-b443-fc6183d980a8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f33addc4-b36d-4be6-a71f-85e8a5d909c1", "afbde168-e203-4745-964f-14cbab34585c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87c1d6ee-d7de-40ed-86eb-6a2d206eea7b", "16d42c54-0f0d-4f52-ad37-7f9c91813d04" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "feba4d9e-236f-4c7d-9438-0d960fdc043e", "c57f4a8e-4e57-4e3c-9b58-586d59e8bc40" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2f5b91a-1eb3-4571-967a-6d99677ff8fe", "3057f3d2-4692-4f24-bca0-92354d6d1d8c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eae524f4-14a6-4b2a-b618-e55ab5e08f90", "9ea7bca6-1457-4984-b3ac-d3bb3747fd03" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a7bde436-deca-43b6-b9db-015ed36df626", "d72f0ae9-f6ec-46ec-95aa-0905e8cff771" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72d94af7-3389-40e9-8523-ec35450b2e27", "2c2bcd75-9dea-4e4c-b4b8-0d3191968172" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99b4bf27-932e-45b5-bfa9-7e85377dd988", "02d28f33-f956-4d31-833b-006e6d3cd108" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "059e7cb7-09e3-4954-8de5-49efe885a1e4", "50d5e6d9-a82f-4042-8494-692d3c6e06c5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5cff551-52ef-40be-8bed-4deb84859fdb", "9c58d452-8ffd-4138-bf01-f62e01c63079" });

            migrationBuilder.InsertData(
                table: "DefinedRequestRole",
                columns: new[] { "DefinedRequestId", "RoleId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Permission" },
                values: new object[,]
                {
                    { 1L, "83446d32-9121-40c4-b9c7-04b3eebcebcc", null, null, null, null, "Request" },
                    { 1L, "b858e94c-5f6a-432d-8b2a-f83ec6601269", null, null, null, null, "Review" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b858e94c-5f6a-432d-8b2a-f83ec6601269", "51124" },
                    { "83446d32-9121-40c4-b9c7-04b3eebcebcc", "51188" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_RequestId",
                table: "PoRequest",
                column: "RequestId",
                unique: true)
                .Annotation("SqlServer:Clustered", true);
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

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "83446d32-9121-40c4-b9c7-04b3eebcebcc" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "b858e94c-5f6a-432d-8b2a-f83ec6601269" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "003c94a9-2b22-44c9-91ec-6dd39dfc5087");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "215fa3d9-3ffb-4f20-a593-c44c9459e549");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3ad339c1-015f-4d91-b1cf-e52e52d7c224");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "82f0600d-246b-40a6-9e98-3b205bb9edea");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8a3570b7-ed56-4856-9c67-5e429a2d1754");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9ca70fe6-4fea-4f95-9973-997d1faa9ea9");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "a4baf533-b9c9-4418-a3c9-19073b35b08c");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "cddffd35-4b6b-4862-b9f1-c5a5b9f5d5e3");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "ee86eeac-6622-4d31-9a88-11cc339252bd");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f8180bf0-7ea8-4591-8a03-e16788187ca0");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fa217a7d-bace-41c3-8167-0f31f1df1581");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fd0bc933-37a2-4e73-a7a4-38e82e023bc2");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "ffe4f7d9-fcd6-4f5d-bbae-fc7e8ba920e9");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b858e94c-5f6a-432d-8b2a-f83ec6601269", "51124" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "83446d32-9121-40c4-b9c7-04b3eebcebcc", "51188" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "83446d32-9121-40c4-b9c7-04b3eebcebcc");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "b858e94c-5f6a-432d-8b2a-f83ec6601269");

            migrationBuilder.AlterColumn<string>(
                name: "VendorNumber",
                table: "PoRequest",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PoDescription",
                table: "PoRequest",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PoRequest",
                table: "PoRequest",
                columns: new[] { "RequestId", "PoNumber" });

            migrationBuilder.InsertData(
                schema: "security",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d0f955e-f84d-442e-8676-d8c53839ba37", "fe9d811b-c9aa-4389-a060-8929730ea7b3", "Security", "SECURITY" },
                    { "11a62722-df08-4ff6-aafc-773da482985d", "2f1929b8-1954-4d30-ad15-65c1734d7d20", "CustomerService", "CUSTOMERSERVICE" },
                    { "2e66a76e-9fc8-4c38-bdee-07f4e5761a40", "5dc0e0cc-9462-4e1e-a16e-4705fd401d38", "IT", "IT" },
                    { "31f60110-5331-43e3-afcc-86e25f285941", "7daf0ee2-754b-4d4c-afe3-ecb09b47ed4f", "HR", "HR" },
                    { "39171323-91f5-407c-88dc-67b657f3e966", "1cb134e8-55ff-4edf-b87d-0e15c6da0b14", "SuperAdmin", "SUPERADMIN" },
                    { "53481cef-8380-4ebe-8ea5-0a73f7a0e6ff", "4bc04e25-6c7a-4e7c-8e9a-1ea9cedb007c", "Commercial", "COMMERCIAL" },
                    { "82cae434-a43f-4f98-86d2-4de5205a410f", "6c85c14b-574c-4c36-801c-82e7ebc6b1ff", "Procurement", "PROCUREMENT" },
                    { "9a8e4316-c998-4125-a9ef-af391a9f8243", "f5977670-a0e9-49cb-b748-7cb2f5e7d7dd", "Finance", "FINANCE" },
                    { "9b67cbc3-79b7-4225-a765-30f965cfe4ce", "091a6ff9-ab12-42aa-b4c2-884dbe807ccf", "Engineering", "ENGINEERING" },
                    { "a249ad1e-f902-4f9d-9b61-e1f0a9158e7a", "9852c06b-cade-481b-a21c-8a917378cfaf", "Store", "STORE" },
                    { "c2fc304e-99e7-45f2-ae8e-4eb3db2a6a54", "5879bf35-9a26-43ce-97fc-4ff951a2d5d9", "Communications", "COMMUNICATIONS" },
                    { "c6211cfe-eee5-4aab-a1fa-8f546102fe2d", "3fc914ef-ea2b-4110-ae4a-aba1e0c9ea29", "OperationCT", "OPERATIONCT" },
                    { "cb8fcbe1-2558-4a80-961f-6e683d5106ab", "244fef7c-057c-47d0-99f2-18180c04e198", "InfoFort", "INFOFORT" },
                    { "ce3f68df-61aa-4e06-9c2a-6f19889bee60", "75bcbb47-cd23-44b4-b9c3-f8ba0f1dccfb", "Adminstration", "ADMINSTRATION" },
                    { "e5634c42-82d8-4889-be9d-89d92b77d426", "6beda2c4-03dc-4c67-a303-583ae5c88806", "OperationBGC", "OPERATIONBGC" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "54cb22a6-d74f-40f8-b71d-39dfb14619aa", "f406fe59-7191-4787-9a0e-0afcca4185ad" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb7cad3e-efac-4c05-8a9d-ebc0cf2e6d58", "c4475a98-4a4e-4a0b-a424-e5a89c67480d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b62ec717-a1ef-49cf-a109-253f8b7f7750", "9cc8837d-749e-4e0a-b600-5044d3f7f096" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36a341e7-a702-42e2-9352-0266ba5455d2", "8ec2e516-35f5-413b-bce8-a6759027ffe8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37b8897b-4127-4fc1-be28-41b5fbcd0420", "d655543c-44cd-43d0-a508-23a75887b472" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0466ba8c-cf06-46a0-9565-211a77b1bec2", "6b0ec6c7-41f5-4e93-9784-5dd97952eaa0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "828df9e7-0582-412b-b7b9-aa3aec424ae2", "906cf3bc-b13e-44ab-b78b-108bbf432e9c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "284d918d-468a-42b9-94c8-b7d7bbce7063", "582f16f7-641f-49bf-9683-0653ba844397" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dcb04b45-656a-4908-b30d-65aba76a2216", "3ed59bbd-270e-42e5-936b-26c8ddbe1dce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52cf7432-5d12-45dc-a47e-221d93691258", "2ba149b7-1af7-4154-9377-7337b59c117b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dc18f47a-7ab9-402c-adc5-e3988de4b07f", "722a2e53-9983-4156-a2f1-0c45b3fd4c34" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c03cb0b0-eaf9-4a93-8b66-2958d6c57bba", "6ca921ee-9142-4e7a-adf6-08da0dba2ef7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e34aeb2-4945-408b-86a9-467a15b3926d", "48208b24-9560-431a-84f0-aaf68d330ef4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93f96003-4dfb-4f9b-80eb-b7e724fbf275", "d85ebfdf-0cf7-4687-a86c-d4d6d5e9553b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f7770fa3-5479-4873-97e5-30edd868367d", "3c2b1298-6d0a-4ee0-8309-9061b86b7f47" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d85d5c4-912a-4f6f-be91-66def5fcbb86", "02902e4b-51c5-485b-ae1a-edf217b6a984" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d74711fa-3050-4ad1-8744-c006c4c80681", "c18d44ca-d470-43c0-a030-a075e61c7246" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23bbbf22-8386-4c52-8f68-816f76070adf", "0fd8a249-8fcf-4242-b90c-c87d738660e4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8767fde3-e9f7-4247-a5bd-efeabe302efd", "2b1e5d66-2ab6-4045-98dd-dda12d001044" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bc1995de-17f7-4a47-9700-9b3b10496878", "2800f9db-a61a-4954-93f0-9607f490f03c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a85aa31e-b15f-4fe2-a696-c06ca29d5dbd", "0f3dbe28-81bc-49bb-b5be-96fddd81ddb0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36b4d7b5-7043-4df9-b9b5-dbdacb1309f7", "5d65e1b5-bb1d-468e-a051-ed6ae0c5c92e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdbfab75-01ca-4b2e-83fc-41ea7b9a2cfc", "165db91d-40c5-4b65-8b4e-c0e200df6a97" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f233a7f-8c99-473e-ade4-2fdffb1125ca", "b3b34ead-8443-461a-b522-0c0839df6248" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bef202f5-d621-4c30-89aa-045a15d3f798", "401ae2eb-9477-4c0e-ae6c-6e62427bfe8c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61327db4-47e2-42af-812d-99c337cb800c", "bf95f276-6ba8-4b18-a30d-dfd00459919e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9095685d-ccf7-4d77-aa39-7693431f741a", "d131c03f-32d4-4f6a-87b1-a49fe361a145" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1b09615-d136-483c-8cb2-d0e6d5d1b263", "b6ecc5f4-5926-4d82-9f8a-2db016a07a72" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8fe1cc25-a3e2-460b-b90f-c64790f2775a", "6999c5db-b468-4c3d-99c2-7aed907e86e1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0604f910-54d6-4519-a889-0d9e46817177", "155384a5-36d2-4cfa-9f6a-1995e036bf6c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "230f51f0-3db0-4154-ae6e-6f03073ca975", "b9c7edce-aa2c-4b0f-8348-862f1e20e121" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7ebaeac-11a5-4cba-b403-14c2c9bed4ac", "9fd24604-c8cb-4577-8a32-cc94a47da5cc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2bc4e8a0-7857-46cd-bef7-d9e4258e0261", "d9bcd931-2490-4a5f-878b-eb15c76c177e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc3b4114-3df9-4050-92b6-7a55d96d05cc", "b0df257d-5f2d-48b6-bab2-d59e0ca342ff" });

            migrationBuilder.InsertData(
                table: "DefinedRequestRole",
                columns: new[] { "DefinedRequestId", "RoleId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Permission" },
                values: new object[,]
                {
                    { 1L, "82cae434-a43f-4f98-86d2-4de5205a410f", null, null, null, null, "Request" },
                    { 1L, "9a8e4316-c998-4125-a9ef-af391a9f8243", null, null, null, null, "Review" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9a8e4316-c998-4125-a9ef-af391a9f8243", "51124" },
                    { "82cae434-a43f-4f98-86d2-4de5205a410f", "51188" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_PoDescription",
                table: "PoRequest",
                column: "PoDescription");

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_PoNumber",
                table: "PoRequest",
                column: "PoNumber");

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_RequestId",
                table: "PoRequest",
                column: "RequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PoRequest_VendorNumber",
                table: "PoRequest",
                column: "VendorNumber");
        }
    }
}
