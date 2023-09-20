using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addCreatorFullName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserRequest_Request",
                table: "ApplicationUserRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_Request",
                table: "Attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_CarRequest_Request",
                table: "CarRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_DomainAccountRequest_Request",
                table: "DomainAccountRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_PoRequest_Request",
                table: "PoRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_DefinedRequest",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_User",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestApplicationRole_Request",
                table: "RequestApplicationRole");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestReviewer_Request",
                table: "RequestReviewer");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelDeskRequest_Request",
                table: "TravelDeskRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_VoucherRequest_Request",
                table: "VoucherRequest");

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

            migrationBuilder.AddColumn<string>(
                name: "CreatorFullName",
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
                    { "0f81f547-b096-4aa6-a495-e15252a555c5", "9f8e363d-a031-49e6-8a7b-4b03eec5564f", "InfoFort", "INFOFORT" },
                    { "1b7e5001-4ee8-4220-92a9-8459ad25561a", "a76a1c3d-ffe5-47cc-afde-160261fa8840", "Adminstration", "ADMINSTRATION" },
                    { "22a1054f-27fb-4e1e-a695-853570329f28", "e6c9a7e5-9574-4e28-853f-56bf22ee2cab", "OperationCT", "OPERATIONCT" },
                    { "2cf317d0-33e3-4f35-b071-fcca4b309a27", "b445d5bb-55df-44dc-a230-f84813cfabcf", "CustomerService", "CUSTOMERSERVICE" },
                    { "4676a63b-678b-4560-9ce0-e9915278b4d9", "efc83b31-9380-44f4-8ff5-60bf0b39065c", "Engineering", "ENGINEERING" },
                    { "572ffdd7-aa12-4985-9f30-fa9152fc29b6", "db5c5272-d966-4931-bd28-25c944d7cd18", "IT", "IT" },
                    { "599a22ab-4b4b-40ee-99ab-fc24cabb1af3", "146d8f3d-0dfd-4d84-b013-881ce88e06b2", "Security", "SECURITY" },
                    { "5ca1f5ac-8f21-4041-8f4d-13549c6cfe31", "c6ed859f-46ea-43c9-8181-203b0fdea5f6", "Communications", "COMMUNICATIONS" },
                    { "6488cb87-fc36-46dc-a06b-8e402641b102", "8b407876-6328-47ab-9d87-c8f3455efe6d", "Procurement", "PROCUREMENT" },
                    { "6848367e-2d9d-4e0c-858e-692d05ca26c8", "89693b12-4b17-4472-a816-f3c9613ed59e", "Commercial", "COMMERCIAL" },
                    { "6d9d6418-6154-494b-9967-23012e4bae19", "8ee952c7-76b7-473b-a2e4-cd22d650b084", "SuperAdmin", "SUPERADMIN" },
                    { "7d1c73e0-c319-4ebc-b108-9b6ed64c1efe", "78b2fda0-c9fb-416d-ab36-dff8ce34c980", "OperationBGC", "OPERATIONBGC" },
                    { "abddb48a-6657-429c-b9ba-1ad8f10fabca", "a46f4b26-e894-4f01-9bd7-e655b22b9edf", "Finance", "FINANCE" },
                    { "dc3c247b-3898-481e-bce2-adf700885973", "790a1b4e-96f6-496b-a79f-0831b01ebf1d", "Store", "STORE" },
                    { "f3b88eb3-33c1-4cad-af14-75fee309e9f1", "4a818dd2-ab3c-4330-9b4d-07137d6b96c2", "HR", "HR" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36daaee2-bf58-4ccb-a533-b2913a74f182", "fdd6843c-50bf-4bb3-84d6-b44f561e8bbe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81bc5b21-8f31-4ee8-86f5-21235015cf6b", "7a66359c-7f30-4756-83dc-b7b907b85566" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3dfd910a-25cf-468a-b7f1-80f31aa3e9e6", "e6e0548f-a7cb-43a3-8e07-23614fcf3eb5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "826045a0-8591-4015-aaca-7bf1c4bfdabc", "70585c6f-7a64-4133-a391-5f990539d020" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be557acc-6e00-4ba6-8b48-ec58d700eb5e", "e73c914c-93cb-4a14-868e-d8e92cec9a7b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4a647bb-b16a-4e42-9314-aba6e5a3f55c", "7e18018d-26c1-4226-a808-210f471dc2d3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6ddb1ffc-b20b-4bae-8c9a-8cf478133a08", "0bbe911e-2c7b-4fb3-8314-7157f2857250" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f146748-7ffe-4504-a181-6a36807fd955", "ddc2a107-f853-4994-ba4b-8a54f094d642" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "559bdc72-3ddf-4545-975c-f3c810647f20", "f1c38d8d-beee-4b72-bc3f-f876044d5d66" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c364649-c6a2-4df9-8cfd-18dbf4f47f98", "67808570-106a-44f9-a97b-c421ac459fea" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12d00d49-a156-43b5-8ca2-7b5e99801b95", "171c012e-c5a6-47ec-a5be-7f2b496d8d10" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2763047-a066-470f-8dd7-eda9ccceaed7", "d0e12e78-42e0-4320-a7ca-82baa0fb7e4c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dff3e883-0ca2-4f2e-8d99-e9587da4e419", "c3ac9e59-d9d5-4e71-aea2-8df923a9f7d5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56285206-e186-4cdf-aa9b-3fd8fbe9ed79", "df8ae3ee-60bb-4715-955d-a12f374cde32" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8bfc810f-0c36-46a3-9453-6c7296dd46f1", "f99382b1-3fa0-43ed-aebe-541014eec375" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4caaf349-1d57-49bb-af34-9557d4c6b31f", "cf9184ef-5167-4470-858b-fe56f6af32cc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ea02ab4-fca0-495a-9e49-e3e3554d7b6b", "128f871a-9110-4aa6-b776-30c3d8aed433" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99639859-51ea-473a-a643-f7dec220de25", "a7ba46ca-b9de-4204-a537-92682ca95cf1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8593c9b-760c-4279-a3e8-03796aa072a0", "5613fe12-c092-4825-9458-04e4f1da30cd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5202a5c-d47e-4307-b548-9b654aa18048", "3c86e99b-96f4-4f11-9ab1-09d379037a2d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ae898f0-d8d9-4c10-b982-ab1b741869a7", "42f3f858-30d1-4e74-8fc8-648eb49a4a6c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6112b8a9-672d-4739-8e09-f55d5407dd00", "f534f41b-35a4-4f89-95f7-37bf3221e84c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e637693b-4362-4221-be5f-2d565817e4e5", "3105de42-d76a-4bc3-9929-c4304df52516" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94515833-e967-4d88-9329-e6655fde7887", "4d51a202-7fe6-4f9f-a235-b5fdd9f6e478" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2fa42ff-549f-40ec-a17d-b4fa684ce680", "711d29c0-748a-4007-ab25-6a9061331ca2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6ce50568-06b3-417f-bb82-ae5c521bdca3", "b71cbc78-20ba-401f-b5f4-0da5486daad9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee2f602f-b9f3-4e03-a663-cb93ca2ca335", "8b4c3061-a30f-43db-820a-342992c4bb4d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c3ebfaf4-b8ac-411f-8bcf-672ef473b040", "99f1d282-3a28-41e4-a6ae-d6015038a671" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "033bfb48-ce8f-4fff-8af6-08e750d23b43", "5e2df340-8ee6-4ae9-804a-318fb3325157" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6ef6a7c8-22a9-42fc-a6fe-e388fcf5ada5", "c4ec59f4-1da3-4965-8a12-e5166745aea6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b9d5d7f-634c-4032-a718-4984103bd52e", "3320a9b4-52ac-44a6-9781-90223c1c83d7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "52f6fc39-ca36-4350-864f-d067d3472997", "fac207c6-e301-47a3-9895-73702cf32a07" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2da5a05c-5fe3-4d27-9bd6-488b66d32002", "3234dd4f-9f42-47c2-a723-2e49b098de8f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb5dada2-56bd-4a7c-91cb-1ffbbe8a309e", "955452f0-553e-48bc-b541-761c36b2867c" });

            migrationBuilder.InsertData(
                table: "DefinedRequestRole",
                columns: new[] { "DefinedRequestId", "RoleId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Permission" },
                values: new object[,]
                {
                    { 1L, "6488cb87-fc36-46dc-a06b-8e402641b102", null, null, null, null, "Request" },
                    { 1L, "abddb48a-6657-429c-b9ba-1ad8f10fabca", null, null, null, null, "Review" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "abddb48a-6657-429c-b9ba-1ad8f10fabca", "51124" },
                    { "6488cb87-fc36-46dc-a06b-8e402641b102", "51188" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserRequest_Request",
                table: "ApplicationUserRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_Request",
                table: "Attachment",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarRequest_Request",
                table: "CarRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DomainAccountRequest_Request",
                table: "DomainAccountRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PoRequest_Request",
                table: "PoRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_DefinedRequest",
                table: "Request",
                column: "DefinedRequestId",
                principalTable: "DefinedRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_User",
                table: "Request",
                column: "CreatorId",
                principalSchema: "security",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestApplicationRole_Request",
                table: "RequestApplicationRole",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestReviewer_Request",
                table: "RequestReviewer",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelDeskRequest_Request",
                table: "TravelDeskRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VoucherRequest_Request",
                table: "VoucherRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserRequest_Request",
                table: "ApplicationUserRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_Request",
                table: "Attachment");

            migrationBuilder.DropForeignKey(
                name: "FK_CarRequest_Request",
                table: "CarRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_DomainAccountRequest_Request",
                table: "DomainAccountRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_PoRequest_Request",
                table: "PoRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_DefinedRequest",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_User",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestApplicationRole_Request",
                table: "RequestApplicationRole");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestReviewer_Request",
                table: "RequestReviewer");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelDeskRequest_Request",
                table: "TravelDeskRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_VoucherRequest_Request",
                table: "VoucherRequest");

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "6488cb87-fc36-46dc-a06b-8e402641b102" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "abddb48a-6657-429c-b9ba-1ad8f10fabca" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0f81f547-b096-4aa6-a495-e15252a555c5");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1b7e5001-4ee8-4220-92a9-8459ad25561a");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "22a1054f-27fb-4e1e-a695-853570329f28");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2cf317d0-33e3-4f35-b071-fcca4b309a27");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4676a63b-678b-4560-9ce0-e9915278b4d9");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "572ffdd7-aa12-4985-9f30-fa9152fc29b6");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "599a22ab-4b4b-40ee-99ab-fc24cabb1af3");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5ca1f5ac-8f21-4041-8f4d-13549c6cfe31");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6848367e-2d9d-4e0c-858e-692d05ca26c8");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6d9d6418-6154-494b-9967-23012e4bae19");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7d1c73e0-c319-4ebc-b108-9b6ed64c1efe");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "dc3c247b-3898-481e-bce2-adf700885973");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "f3b88eb3-33c1-4cad-af14-75fee309e9f1");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "abddb48a-6657-429c-b9ba-1ad8f10fabca", "51124" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6488cb87-fc36-46dc-a06b-8e402641b102", "51188" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6488cb87-fc36-46dc-a06b-8e402641b102");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "abddb48a-6657-429c-b9ba-1ad8f10fabca");

            migrationBuilder.DropColumn(
                name: "CreatorFullName",
                table: "Request");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserRequest_Request",
                table: "ApplicationUserRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_Request",
                table: "Attachment",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarRequest_Request",
                table: "CarRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DomainAccountRequest_Request",
                table: "DomainAccountRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PoRequest_Request",
                table: "PoRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_DefinedRequest",
                table: "Request",
                column: "DefinedRequestId",
                principalTable: "DefinedRequest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_User",
                table: "Request",
                column: "CreatorId",
                principalSchema: "security",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestApplicationRole_Request",
                table: "RequestApplicationRole",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestReviewer_Request",
                table: "RequestReviewer",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TravelDeskRequest_Request",
                table: "TravelDeskRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VoucherRequest_Request",
                table: "VoucherRequest",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
