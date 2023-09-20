using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addReviewedByColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "DeclinedBy",
                table: "Request");

            migrationBuilder.RenameColumn(
                name: "ReviewerId",
                table: "RequestReviewer",
                newName: "AssignedReviewerId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestReviewer_ReviewerId",
                table: "RequestReviewer",
                newName: "IX_RequestReviewer_AssignedReviewerId");

            migrationBuilder.AddColumn<string>(
                name: "ReviewedBy",
                table: "RequestReviewer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                schema: "security",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08c943f2-9de4-4fcf-bae6-e0914a085264", "fb4c0974-4a33-4ca8-a4f7-53edd635ef30", "CustomerService", "CUSTOMERSERVICE" },
                    { "222727bd-5404-4c72-9faf-5c07fbf9c6f3", "266c62aa-67fc-46aa-b61f-ac6a96e43658", "Engineering", "ENGINEERING" },
                    { "2b40d794-8c8e-4438-8d5d-b1c63748ad7e", "81bfb613-0e13-44da-80f6-cdcb1ff2265d", "IT", "IT" },
                    { "30ead12a-94f0-4e6a-9843-6f273a501ba8", "8c09ab4c-2f4d-4cf5-9b41-ddd2a6816c67", "Store", "STORE" },
                    { "4135de4e-b28a-43e1-a7c0-c47c45c9e204", "de716680-7698-4a2c-8316-22e48e9c6b60", "Adminstration", "ADMINSTRATION" },
                    { "6f44104f-8d89-4cbf-8074-50522f899c9c", "a9c256a7-5005-4856-9aa2-1bc58034e1bd", "HR", "HR" },
                    { "7dfa575c-0c26-4d2c-8e47-a8ea0f44ec00", "e40840d4-6c65-4867-ba6a-cede70adaf38", "Commercial", "COMMERCIAL" },
                    { "889f4f0a-0f8a-48b8-82b7-4132f53a1fed", "768130a4-9522-44f8-bee1-f8ca012a050a", "InfoFort", "INFOFORT" },
                    { "a688e8c8-2dd4-4711-b3c2-b7071103140f", "e3914134-39c2-430a-aa92-56eae5585248", "Communications", "COMMUNICATIONS" },
                    { "b3d4f0fb-49ac-4940-bb4d-d2217435d857", "7d3c8399-3c0a-4350-be1f-51ced53efdfe", "Procurement", "PROCUREMENT" },
                    { "ccfa0fb4-cf2e-4416-9f00-e6ed9595959c", "62ba6634-8007-4766-9996-3225a678d2d5", "Security", "SECURITY" },
                    { "d0e993b9-f63e-49c6-8077-2dafda5099ea", "17298674-5567-4854-b8db-bbecd0285e3f", "Finance", "FINANCE" },
                    { "d493bff1-6fe1-4fc2-99b7-3de053fe18d9", "f2ca5768-5de5-4cc8-9e97-50175138cfe1", "OperationBGC", "OPERATIONBGC" },
                    { "dec56611-3901-4f58-8544-27931cc01387", "bcb2ccf4-48d4-466c-a4f5-4f4015fcf1dd", "OperationCT", "OPERATIONCT" },
                    { "f411bbc1-0c06-4394-9abc-e844cb5c8bd6", "6c515b1e-889c-4316-8291-380bfd3da613", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70f00280-978d-4894-8848-cc4d64722da4", "ec0cc15b-2aa6-4a0a-a4d9-2740d181e4ae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba110a01-9af4-4ec1-a373-d8429cb2714d", "a641aa05-16fe-4601-a9a1-ffb7e8156d08" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "882806f5-205b-4f20-b5c0-701f03d5893f", "99fd12ae-9855-4dc3-aab0-2a2c61ec335a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a73b1477-0f2e-4f65-ba5d-9ff6b6f6ccc8", "0ce4f711-863c-4f5d-97f4-ac21c1d24897" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db60de3f-151d-493f-86a3-9109007f600e", "e3c85278-a3be-432b-8c77-100ed0da7d8d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c889bbed-5e8a-41ac-ab8e-8b9414f866a5", "cee25b6c-e2ab-4705-a6c9-0ab1b4b1b11b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6cb4ae9-b657-43f6-aa6e-e4146b947c62", "2d21dd46-ad48-4cdd-bf89-67984ee75af3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccc7d898-655e-4f91-bcfe-87851aef86e7", "9e3000b3-cd7a-4ea4-acc5-6e7a9b0943ab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c694610-5a1c-42e7-bae7-6f2280cba69d", "4b228241-3a3b-44e8-8c58-d718d034c106" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "828f9e63-aa99-4d8d-96cc-5a69050a3115", "650978dd-c4b7-4bb3-a0dd-ce37bfd030b4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba8b9fbb-2917-4c26-b606-390fe2781aed", "d99b19ef-156e-4f6e-a532-061717b7a125" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13d0cebf-4a21-414b-b98f-844424caf575", "3ffb8a78-6854-474c-9332-4c9c074baf82" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02dad6c0-15c5-4ec4-97d5-9ca714219b8e", "52f9ed62-08ae-45c4-a81f-25dbb8f8ae1c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02d7ddfc-e21c-454f-b438-43a430447275", "954ec9a6-c5cb-4e4a-87fa-e93c0edc7e69" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "decd74ef-e4bb-488d-a46d-a025d745fb68", "57666fec-01b3-440b-b1ee-b32f54e8c3c6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a2e21bd-34cd-47ae-90c0-1ef2c157300b", "f79896d2-fdc0-417f-888a-987efa37dcc9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84913ef8-7086-4999-9a62-2688cdcf5706", "57d8d776-1e5a-4f5a-b773-9a86201973ea" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e6e4238-0ece-49f2-8025-6c21372fb862", "cd375934-289e-4724-908d-c2077dd773c3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "37d42a83-163a-42fc-b9d8-0b6bd9396637", "bd4d5f1d-b958-4704-9f2b-bad879b583f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2793a3c-9cad-4a1c-bdd2-aea456133238", "d899972e-cb71-4680-bb18-faeff2d71bde" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5a9be62-66fa-4f04-a64e-9ccd7cffb705", "d9e887ae-1e8d-4e72-93ce-6abbb962a527" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdbff65d-912f-42ee-a2c7-34ba02362727", "fc2b4187-c2f1-4604-a2ad-8074b3a17925" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "239ddbed-3bde-42f0-8bd8-671ab8586d44", "7516177d-3697-4964-a2d5-013059dc0cd0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad0fef40-bcd7-4b83-a0cb-cd440b294169", "90f19c96-a5d5-4043-838b-85956c14c1f5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b34c58e-4bfa-429d-a68a-aa1fce299de6", "37bee79f-b301-4fee-a838-29ca9ef6f3f8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b5255de-0af2-4bfb-bb02-cfa6d219d09b", "e33a4e08-c4dc-4f2a-bf78-015453610edf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c78a7778-bd40-4216-9220-823970a89dcc", "6eacc0db-11e5-428a-a5da-d66f1e0cc79f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "66729a9a-1722-4c73-b420-a5d8a10c9239", "b826f86d-fb82-4542-82e6-b65095e63f33" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f6483e6-5e64-43e6-b26e-4ac956406472", "2e0f78f6-55ab-4e4b-8ec2-c212e65aba77" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2ab1399-1ae0-475a-96e5-9b2a623db39c", "f21b4cd4-4ff8-4851-96dc-114c7d0e5f07" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f73c9fc-d151-4062-b6cf-9e7355698f2f", "9690d437-7773-4a64-9403-9be959849f9b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7426a859-151b-4e13-b3a5-14bd09ede4cf", "d65a9945-b54e-4e1c-9d3d-a2ee5bfb25c6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a07a08a4-507e-43db-8a8b-c77fa54fa13e", "2b73f7f1-d281-4ce5-bd7e-e6398d1e362a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9d802e1-e9c4-49b5-b443-2aeb1d332ae7", "9465e6a2-8d4e-44e1-b3d9-c22a154d2f1a" });

            migrationBuilder.InsertData(
                table: "DefinedRequestRole",
                columns: new[] { "DefinedRequestId", "RoleId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Permission" },
                values: new object[,]
                {
                    { 1L, "b3d4f0fb-49ac-4940-bb4d-d2217435d857", null, null, null, null, "Request" },
                    { 1L, "d0e993b9-f63e-49c6-8077-2dafda5099ea", null, null, null, null, "Review" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d0e993b9-f63e-49c6-8077-2dafda5099ea", "51124" },
                    { "b3d4f0fb-49ac-4940-bb4d-d2217435d857", "51188" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "b3d4f0fb-49ac-4940-bb4d-d2217435d857" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "d0e993b9-f63e-49c6-8077-2dafda5099ea" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "08c943f2-9de4-4fcf-bae6-e0914a085264");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "222727bd-5404-4c72-9faf-5c07fbf9c6f3");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2b40d794-8c8e-4438-8d5d-b1c63748ad7e");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "30ead12a-94f0-4e6a-9843-6f273a501ba8");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4135de4e-b28a-43e1-a7c0-c47c45c9e204");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6f44104f-8d89-4cbf-8074-50522f899c9c");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7dfa575c-0c26-4d2c-8e47-a8ea0f44ec00");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "889f4f0a-0f8a-48b8-82b7-4132f53a1fed");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "a688e8c8-2dd4-4711-b3c2-b7071103140f");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "ccfa0fb4-cf2e-4416-9f00-e6ed9595959c");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "d493bff1-6fe1-4fc2-99b7-3de053fe18d9");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "dec56611-3901-4f58-8544-27931cc01387");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f411bbc1-0c06-4394-9abc-e844cb5c8bd6");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d0e993b9-f63e-49c6-8077-2dafda5099ea", "51124" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b3d4f0fb-49ac-4940-bb4d-d2217435d857", "51188" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "b3d4f0fb-49ac-4940-bb4d-d2217435d857");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "d0e993b9-f63e-49c6-8077-2dafda5099ea");

            migrationBuilder.DropColumn(
                name: "ReviewedBy",
                table: "RequestReviewer");

            migrationBuilder.RenameColumn(
                name: "AssignedReviewerId",
                table: "RequestReviewer",
                newName: "ReviewerId");

            migrationBuilder.RenameIndex(
                name: "IX_RequestReviewer_AssignedReviewerId",
                table: "RequestReviewer",
                newName: "IX_RequestReviewer_ReviewerId");

            migrationBuilder.AddColumn<string>(
                name: "DeclinedBy",
                table: "Request",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

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
        }
    }
}
