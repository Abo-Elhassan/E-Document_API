using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeAssignedReviewerIdInDefinedRequestReviewerNullables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DefinedRequestReviewer",
                table: "DefinedRequestReviewer");


            migrationBuilder.AlterColumn<string>(
                name: "AssignedReviewerId",
                table: "DefinedRequestReviewer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "DefinedRequestReviewer",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DefinedRequestReviewer",
                table: "DefinedRequestReviewer",
                column: "Id");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "981c5898-d8d9-4898-9555-e3fead2d83d4", "1faf8dd0-1bf8-49e8-8b65-8f00176e9144" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8c76a72-aac0-4eca-b5f0-e6c9e39b5faa", "af9609ad-b8ce-493b-9690-a431f0ef447f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99acc11d-2e55-4073-8374-265f6b7ad3b0", "cbfb82eb-274d-41c5-8d67-cd7925a4c316" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b28af7a-4d31-4a30-86e1-769f9bb074e0", "4288534e-ea7d-4c06-a801-dd39a06e3d36" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dedeebfb-526e-4e0a-bc08-2b2ef9e1b294", "e3d0fdf7-c15e-41e3-81cf-17ca05c23996" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0a468bf-6abe-4cd7-b971-ee16715a19b2", "8c569160-01a9-450a-9255-98467804b9d5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1cbf9a77-8429-4ac4-8c35-c135ba7c9305", "a58f1e8e-0b21-420e-944d-c7e3bca6bf45" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "617f84fe-eeaa-4d82-9a85-f0fbb88433f1", "3e8c0ef3-7cb8-42e5-aba4-9ebf032be857" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e44d143-5970-46a5-a2f6-8508f0d64dfd", "3b3fdcc9-a0a8-41b6-bae8-30f7bde7497b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f2c9468-3d66-4773-82ad-8122e652505d", "02ade4c0-cb2b-4275-81d7-e708360aaee4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7702b191-72bb-4ce4-bb88-e610da83a8c9", "dc76a56a-8c48-49d1-9ab1-8a2e1df0900a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3486829c-0444-460b-90ab-777145a7265e", "8338cbe9-f88a-4488-8c4a-fcd6b4ead41c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be95cf4f-e32b-4a27-be07-416c2a4e2aba", "1779ae13-43d2-4ca8-ba6c-e545765579a1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d14a2ae1-1dcc-428f-8a25-4c4c7f612c4d", "7fb19801-78ae-4c6f-a0ca-fedc94a83513" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "803224a3-24a0-4e3d-bef3-2d957f644a36", "e02bfefb-ab6b-4964-ab74-dc6bd6d05e07" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "329b35fc-dc27-48d1-9710-7ae6442d7dd8", "1ff8fd31-0534-4172-b9d7-b2ea1d34a5bd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94ff78d2-ebc2-453a-9fd3-8d5425f252aa", "543cd34f-8f60-4797-8193-f65a82955b99" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2072985a-f708-405b-9f97-149d45575373", "48aac5cc-9955-4510-8552-029ef3d62dae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd0346f3-273b-47a3-9824-5925fa26b084", "8bc7e661-ee7e-4d42-bb6e-72e9cdab13dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52df4930-2b6b-4a28-bf3b-ba064ba66d49", "b3b541f9-c473-4e60-a0d3-c8701ddc8747" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90cc86dd-c688-4e49-add4-e38606c94fd2", "a6afd6a7-7cf1-486f-91bf-1c4d0ee43179" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0238832-cef0-4300-b673-d8d48610112a", "465a0e81-3565-4c0f-83c3-cf034243c402" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1d8e7f7-114a-49e7-9264-dd04a5107686", "3b888d50-d51a-44fa-a799-6a840031674d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf7b9ece-0528-4bde-97c6-f5e53e919b56", "df4224cf-c14d-44cb-892e-948917ea7fd8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "967db40a-8fa8-4556-a030-850b1991119b", "47918816-da19-49be-a716-ae6f02295463" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46a51e11-7c80-41a5-8b9c-549b78fdb966", "f7195e8f-a79b-4a5f-b524-942bdf33aabc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c0333c9a-43d9-4ad1-a6a1-fc183c0cf837", "0286ad89-dd87-4459-9425-bcdc4213f50a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d33b6d20-2a01-4719-b698-599fe72acac9", "786bc2dc-aa60-4186-a355-6b195b5183aa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "223744fc-23b8-4c16-bd5c-999e185ec642", "40bb86e5-7b32-486e-bd8b-c22d6f993fb9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "caa4dd41-0b92-43dc-8163-64a82787420a", "4189af46-f5aa-4e95-9dde-1a948a1007be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b7c8470-851a-4991-8165-d6a84a02e022", "1dd510b5-4eb1-4863-9c3d-5601fe7ae98b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d5387d1-7bc8-41fe-ba95-e7bbd105ee6f", "fe3d6fc5-9d7d-4d35-8272-aa20653c00bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f6f92844-5710-4eac-8193-624202422d36", "2c000817-cc6f-4932-a242-9d438d9e4c11" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "baeeb86a-aa74-4642-b153-a76718ff70aa", "6f3349ac-1270-437f-82b4-bd09dbc9f462" });

            migrationBuilder.CreateIndex(
                name: "IX_DefinedRequestReviewer_DefinedRequestId",
                table: "DefinedRequestReviewer",
                column: "DefinedRequestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DefinedRequestReviewer",
                table: "DefinedRequestReviewer");

            migrationBuilder.DropIndex(
                name: "IX_DefinedRequestReviewer_DefinedRequestId",
                table: "DefinedRequestReviewer");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DefinedRequestReviewer");

            migrationBuilder.AlterColumn<string>(
                name: "AssignedReviewerId",
                table: "DefinedRequestReviewer",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DefinedRequestReviewer",
                table: "DefinedRequestReviewer",
                columns: new[] { "DefinedRequestId", "AssignedReviewerId" });



            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "346e58ff-e590-42aa-9895-f0599d05097d", "5bc88064-3c1f-4419-9b03-96eb90dea982" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04043776-6bf6-4dfa-9529-489695aaf0ab", "d1e504b4-7afc-4705-97b9-ef80a76c4afa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d68baab9-4a9a-4274-87d5-c5c7dee52535", "78d6ff9a-11fa-4c42-9d67-f8728728ccd2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5517a5b4-9f3b-4e76-96c3-1dfa71a77a02", "9a1fd8a9-d8cf-4d1f-a473-590c639e7df3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aed894eb-c2a6-4dea-ae9b-858381b705e3", "96890bed-5012-4481-81a5-7a915321e290" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11a98c60-7f6e-496c-a813-717374355793", "9c99386c-5f8c-49ea-b863-7130df4a52ce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecde3f95-f37f-402c-8773-ae9e18a31583", "971d4c26-af61-49cc-b2ff-3d75e626fee5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b210af32-e6ad-4f19-9a18-cd6572e09331", "d453ebff-56ee-466f-86ed-e5184ba018ae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b908e6d-03c7-401b-95c6-7373ba382782", "6edbf3db-7993-4c8b-b310-4cf7c5282ff1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e908dc1c-f388-4cb6-b7ff-0b3a0648a9f4", "58fe4b9c-0d5b-4ff1-992a-84f955051bc4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "389c750f-9c14-4d25-b8d8-f7e63cc10e1d", "d91dc075-f8b7-4a2f-9f1f-0e0951960280" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12c7ab14-73cc-4e0a-9993-83ece0b30914", "0124286e-43d4-47d1-9fdb-0af81d6b18d9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e3e5833-5a4a-4d01-9a7f-9b0ebec73329", "6eb55f28-2eae-4527-badb-46ab3932eed1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1750e6e8-e66b-42bd-bbc7-00b5be58b547", "e1cd7e72-f636-4e58-8e19-0f90710f56b8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a8d4469-6c3b-4627-bef0-887f1c58b059", "67a8153f-e3ed-484c-89af-a0b70317dbee" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d16609e7-6d33-4f30-b2a6-b5a276abd736", "1eb9378f-b3bc-4f9e-ba64-0c772727c3f0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3491bf2e-9624-497b-881d-a0ed6f099dec", "b95dc573-ec3e-44d1-b9bc-10e322f513ab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d04fd33-8b37-4a2d-8fca-2c63265a766f", "8a927ce2-aa7d-462f-8c6f-b36528790e90" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44b3707b-28e2-4138-87a8-551bbd518ba6", "04791c0f-03e0-46d2-8c2c-fbd737d6cd51" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef87f5fb-407d-4fcb-97a0-14e33eae8a09", "a747fd5e-18d6-474f-8395-e97d3326d57a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "967a59f7-74e7-4eed-ba40-fed97296f547", "9dfed141-6172-4e94-9369-ef94a2e01c06" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d8fc753-e4fe-4b27-bc93-960bcb593d6b", "c0478894-e2bd-44fc-bbf7-804098e29cbb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f8e999d-20a3-4731-9588-b0097a0e7553", "4f512469-0c59-434e-8301-ca22e45d4f04" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b32a84ba-53b5-4ae8-b38a-ca19d5053e91", "f226d274-fbd0-44dd-947f-62a18b5a1dcd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8d90dba-c3e3-4497-8400-07538520955d", "f29f45d3-17bb-4fb5-8d96-f7c84ae5a591" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02ecaf60-e2cd-450d-b1ae-52263c3cede3", "0c9a585d-e6d1-4ff5-9666-a456beaffdda" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48829a8f-65f0-44d1-a55c-2f0a9328e66d", "d3dd3a17-25b7-4565-b0e2-493da4c831fb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b80ea7ff-d052-4d9c-9138-5e891c1371d6", "a1586f76-ca8e-45e4-b3bc-b09af9bff089" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3161b11e-9b97-4b11-847e-93788df8d084", "9ed795a9-3a89-4830-b11e-a22b30c36e94" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9c9a3f6-13f9-4c0e-b8f8-aeb1d047cf27", "70178e22-0ab3-46ae-9a06-4500078fc6c8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccb0ac79-d50b-4036-9f52-f1befce7990a", "b3553d8c-0863-4480-b577-a7d15f1fc62a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8cf76915-06b3-4c96-a293-7ef83b5e6b5e", "a4c36335-211e-43a6-b5e7-e342e712ca1f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "772211f1-9dc0-4594-921a-b6006cd3f7ab", "73e87959-61c8-42e6-8205-d547adf319fe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d6cdcb8-efef-4436-8a7f-ab16ee3a3c4e", "1b602629-c2d6-40d3-8942-aa2ee3a1ffcd" });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "121c1742-99e7-4b61-ab2f-f748876e2975", "51124" },
                    { "6826ac7e-b4ae-47ff-8bf6-cc904db43d84", "51188" }
                });

            migrationBuilder.InsertData(
                table: "DefinedRequestReviewer",
                columns: new[] { "AssignedReviewerId", "DefinedRequestId", "CreatedAt", "CreatedBy", "DelegatedReviewerId", "DelegatedUntil", "ModifiedAt", "ModifiedBy", "ReviewerType", "StageName", "StageNumber" },
                values: new object[] { "51124", 1L, null, null, null, null, null, null, "Basic", "Finance Reviewer", 1 });

            migrationBuilder.InsertData(
                table: "DefinedRequestRole",
                columns: new[] { "DefinedRequestId", "Permission", "RoleId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy" },
                values: new object[,]
                {
                    { 1L, "Review", "121c1742-99e7-4b61-ab2f-f748876e2975", null, null, null, null },
                    { 1L, "Request", "6826ac7e-b4ae-47ff-8bf6-cc904db43d84", null, null, null, null }
                });
        }
    }
}
