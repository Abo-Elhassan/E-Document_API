using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class updatePermisions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "77e4a066-8690-4567-828e-92bebab64032" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "c55f00ec-b8b2-4d7e-84eb-85e40d44b944" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "117e4e1d-dfcb-48eb-87f2-67f79d080fa0");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "17eabe57-8333-4125-82c4-a3114dd570f8");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "244ede6e-4e0c-44c2-8442-93b696dfe3c0");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3ae17827-8afc-49dc-8db7-04e0d5b28fbc");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "461d1dbd-91bf-4511-ae69-b4493fd5a7e7");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5bc48309-23aa-46b1-989e-c8275ef0746a");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7e2c9731-2059-4e5e-8133-2d427c59a531");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7ff8f9b6-8843-4648-af06-c249eb189e73");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "bba22c98-f80d-4f2e-8cd3-2268b2f6a119");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "bee465c1-16f7-404f-a12f-2aa0549fc30e");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c6795103-158e-478d-8dd7-6e042dfbd687");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "d8afc429-c3c5-456e-9066-8c5432d41a3c");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "fc7cc3e9-a7de-44e0-96b8-70afeff8bc79");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77e4a066-8690-4567-828e-92bebab64032", "51124" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c55f00ec-b8b2-4d7e-84eb-85e40d44b944", "51188" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "77e4a066-8690-4567-828e-92bebab64032");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c55f00ec-b8b2-4d7e-84eb-85e40d44b944");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewedBy",
                table: "RequestReviewer",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "security",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04248c5e-d189-4455-827d-ca7aa09437c0", "4a1b56cd-7b1f-4d62-964e-f87cc7da1c12", "Engineering", "ENGINEERING" },
                    { "11468416-b959-44fb-bf1b-4f73a67321a5", "8e73010d-f0fb-4a31-976e-4dca65e5a31a", "Finance", "FINANCE" },
                    { "2f5a2a6a-7344-4e5f-8b54-02704beaa1b5", "bb9d4b59-86b7-48e5-b3f5-923109c9713c", "HR", "HR" },
                    { "43c2ba15-d34c-4df8-9afb-5334571c148d", "dbe9a66b-9ea8-4a90-bdd0-bb3a05a2dca7", "Security", "SECURITY" },
                    { "45d39c31-04c7-4909-a9dc-8265b05e9f40", "68944b4b-fae8-4fbc-8512-aa6f015d2f38", "CustomerService", "CUSTOMERSERVICE" },
                    { "49c568a1-03df-46ae-85b5-9828d75a5b2e", "1c0aa31c-12c8-438f-a529-cbfec241f4e3", "Communications", "COMMUNICATIONS" },
                    { "4e885b68-95a2-4aef-a96a-bed659423a7c", "dee7b735-eacd-457a-af48-7123a9d3304e", "Adminstration", "ADMINSTRATION" },
                    { "54210276-7619-49be-ab52-4e0498f9d4f6", "76415aef-8f58-499a-94eb-f2c3c0e1f97c", "Commercial", "COMMERCIAL" },
                    { "5f353a0a-ba58-4ca1-af57-aa3c1677c6d1", "71ae5c80-61e8-4e6f-9b1a-0da2cbac3618", "Procurement", "PROCUREMENT" },
                    { "8fe68556-f2bf-4f15-b760-d40fae9b6a34", "0e8b8c06-a44a-4adf-9834-b542b87a5a66", "SuperAdmin", "SUPERADMIN" },
                    { "a6c11fc1-535e-4e1a-a152-a48090f07f1f", "55a3585e-f14a-4804-8683-2f6af09c4698", "InfoFort", "INFOFORT" },
                    { "b3d2a6cd-b476-4a09-a851-5cd203d7fd0a", "ee62d3f7-b841-4dde-97c7-85fd3562f7b3", "OperationCT", "OPERATIONCT" },
                    { "c6d78074-7543-42fc-badd-2f9dee71da3f", "3157f19a-ca0c-4c34-914f-953c6ccee28c", "IT", "IT" },
                    { "e2603f70-7e97-403e-9842-33090a289f11", "69e890c5-4034-41b7-aefe-99d86ebd8eab", "Store", "STORE" },
                    { "e42799d5-8b2c-4138-b26d-5dd0bf008b2a", "008d6a74-2d1c-4d90-9a95-844da0d8bdb1", "OperationBGC", "OPERATIONBGC" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39b4c4b5-30fc-494c-995e-3da50b4c5b15", "487e72be-913e-4b3e-82fa-d3d30e64bf8b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a9300e5-e7fc-4a1c-9e5f-d9d376e22c53", "35e18a85-664f-460d-aed8-bc66563bb4d0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be05d6a0-4427-4678-a03d-6f8e38bc9b3d", "5d5db287-b9c1-4196-b2b3-fdeb4a480405" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bb7040b5-b7f2-476f-b387-ca8deb1fc68e", "919cee03-b499-4351-bc4f-c931d5ca79d8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "909a9648-adda-4b43-8d5a-ecb8e2a6841a", "8826bc87-f10b-4877-af59-60db3753dda1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cda05975-11a6-441a-8d84-8f905eac9fa8", "3f26bf97-45e2-49c1-849b-ea9c86b71636" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e8abf31-9110-4f9a-8610-c7542c72d2ce", "a2542268-2e80-407a-a155-c95af0bc07cb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bcfc3936-002c-4657-9039-c209b04c9d11", "e4bf63ff-7337-4107-936d-c2af37f78418" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f4acd469-6084-4f2f-8697-3cb0dcc803e3", "487fff00-0757-40f5-b390-ce9cdd3903df" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "648a5060-ef35-4e66-b2ac-79e2a465bebf", "58f669f0-7af6-4ced-a2e0-c575a6c5de58" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6b3ecc6-4b05-475c-86f5-047b6b94bc79", "1de6d312-15df-499f-bc92-12ec83d20c06" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02722cd8-af49-437c-a2af-10a916ebd335", "98e95358-91e0-438a-9ca3-c019a989f621" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1de8a5a6-7023-466a-9b89-163d43f00765", "e847664d-055e-4c35-a515-cba5de414d28" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc3cf1be-ed60-41da-a061-7b77aa8379fe", "2481cad7-a53e-415a-bfe6-edb83e77bcbc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3cb471bd-8333-4486-b880-d858db45685d", "2709b076-9d6f-45cd-9307-5a144c4de77e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f796d57-2d26-4cf6-b99a-d78afdcec62d", "2dfc2c22-3fb5-4e57-8b2e-2c39d7bbea72" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2bbbc099-9086-4151-a98f-63887ab9501c", "1a5b155f-67dc-40a9-8e2f-ce8dfc4400f3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe35b32d-90fb-42db-b22f-de8af6ec9cd5", "8a2e13bd-b2ac-4fad-9c09-8482a19c801a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7ff6c44-4f11-4834-abb1-5bd864cb8449", "7aaf131d-d347-41fe-bb8b-0cd8551e32f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ad32864-bb6d-40d4-bd05-200f3c6238cb", "b110781d-d87a-46d7-afff-4bc7976e16dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29cea944-174b-42b3-b52d-f30c2f9ad14a", "1e940cf5-87b4-4070-b875-f80c62e7f556" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a6b8534-ec68-4597-b125-d80adaec4b3c", "a34e9e53-66b6-414c-b6f3-d3b617f85ea3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea9cda80-b47a-430f-b194-5ee25b58822e", "e0684604-2b32-4f0b-ada1-1056abe19292" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00964c4d-f0d1-4f7d-bf41-4a69ea801b34", "554ab7e2-8498-4698-9114-cd368154b4fc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c3dcd1ae-0f76-4218-81af-ef6b5edf265f", "88a69d25-24f9-4c3a-b6a0-7010531dd996" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56a4314e-68fb-491e-827f-2042f8d7d99a", "6aeb9242-a33e-4c62-9986-b8ac1d22a9aa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46cdc64e-00f6-445c-8697-c6d0be05615d", "bfb09448-b60e-4193-95f4-48a23383d2d9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1816102b-cb1d-43e3-9fb3-8d8dad86044c", "f6367403-d655-48cd-a816-10a7dbeca4bd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3dce5f1e-4e49-4ba5-8e10-7cf98dafc71b", "f386258b-bee5-4e42-984e-741a8ee7c250" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99601ed8-7fbe-455c-b154-de50f80a7b67", "43bab557-59d0-4b59-aaf0-78cd1d9b05dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5480c613-79d9-4692-ada5-bdbff1b8c927", "78bb7fd5-cabd-4d61-b45a-065092d59a70" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c724d184-604d-4d65-9665-57fd89d89a28", "65427e25-50da-4012-bf5a-4c898252d3e6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "227bb161-1b7b-4144-be71-f9a4806a1e8b", "951af781-b495-481b-9b61-60895b3cb4d0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0784682a-e3cd-45a5-a1e3-138b524116a3", "615cd42f-e403-4c5d-a067-110ba915e3a1" });

            migrationBuilder.InsertData(
                table: "DefinedRequestRole",
                columns: new[] { "DefinedRequestId", "RoleId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Permission" },
                values: new object[,]
                {
                    { 1L, "11468416-b959-44fb-bf1b-4f73a67321a5", null, null, null, null, "Review" },
                    { 1L, "5f353a0a-ba58-4ca1-af57-aa3c1677c6d1", null, null, null, null, "Request" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "11468416-b959-44fb-bf1b-4f73a67321a5", "51124" },
                    { "5f353a0a-ba58-4ca1-af57-aa3c1677c6d1", "51188" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "11468416-b959-44fb-bf1b-4f73a67321a5" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "5f353a0a-ba58-4ca1-af57-aa3c1677c6d1" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "04248c5e-d189-4455-827d-ca7aa09437c0");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2f5a2a6a-7344-4e5f-8b54-02704beaa1b5");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "43c2ba15-d34c-4df8-9afb-5334571c148d");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "45d39c31-04c7-4909-a9dc-8265b05e9f40");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "49c568a1-03df-46ae-85b5-9828d75a5b2e");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4e885b68-95a2-4aef-a96a-bed659423a7c");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "54210276-7619-49be-ab52-4e0498f9d4f6");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8fe68556-f2bf-4f15-b760-d40fae9b6a34");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "a6c11fc1-535e-4e1a-a152-a48090f07f1f");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "b3d2a6cd-b476-4a09-a851-5cd203d7fd0a");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "c6d78074-7543-42fc-badd-2f9dee71da3f");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "e2603f70-7e97-403e-9842-33090a289f11");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "e42799d5-8b2c-4138-b26d-5dd0bf008b2a");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11468416-b959-44fb-bf1b-4f73a67321a5", "51124" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5f353a0a-ba58-4ca1-af57-aa3c1677c6d1", "51188" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "11468416-b959-44fb-bf1b-4f73a67321a5");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5f353a0a-ba58-4ca1-af57-aa3c1677c6d1");

            migrationBuilder.AlterColumn<string>(
                name: "ReviewedBy",
                table: "RequestReviewer",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "security",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "117e4e1d-dfcb-48eb-87f2-67f79d080fa0", "cb3acbf8-f247-4d79-81ba-2f0555c33607", "Communications", "COMMUNICATIONS" },
                    { "17eabe57-8333-4125-82c4-a3114dd570f8", "41ef4a42-0b6d-440c-9369-098719f942da", "SuperAdmin", "SUPERADMIN" },
                    { "244ede6e-4e0c-44c2-8442-93b696dfe3c0", "55deb855-9077-4a9f-9ff2-a6e9669ddf65", "HR", "HR" },
                    { "3ae17827-8afc-49dc-8db7-04e0d5b28fbc", "d5ef73ff-b3f5-4971-a0ab-94a8f3dda6a7", "OperationCT", "OPERATIONCT" },
                    { "461d1dbd-91bf-4511-ae69-b4493fd5a7e7", "96d2f171-a582-4feb-8f14-5e4f75afe613", "Commercial", "COMMERCIAL" },
                    { "5bc48309-23aa-46b1-989e-c8275ef0746a", "15bd297f-2b98-497f-ae9f-09df2b289737", "OperationBGC", "OPERATIONBGC" },
                    { "77e4a066-8690-4567-828e-92bebab64032", "083e0291-7c1d-4f1c-af86-93807c520971", "Finance", "FINANCE" },
                    { "7e2c9731-2059-4e5e-8133-2d427c59a531", "16582e65-2b9a-4f6d-a619-8c77ffa40358", "Security", "SECURITY" },
                    { "7ff8f9b6-8843-4648-af06-c249eb189e73", "747cea43-0cc8-497e-86c2-cd9ded9cd106", "Engineering", "ENGINEERING" },
                    { "bba22c98-f80d-4f2e-8cd3-2268b2f6a119", "c4a4c690-6e07-4de3-a298-579117947cf8", "CustomerService", "CUSTOMERSERVICE" },
                    { "bee465c1-16f7-404f-a12f-2aa0549fc30e", "053934f8-fead-445d-ab7e-b927d3eed66f", "Adminstration", "ADMINSTRATION" },
                    { "c55f00ec-b8b2-4d7e-84eb-85e40d44b944", "5a5c69ce-b29d-4295-9227-8ea820dce52a", "Procurement", "PROCUREMENT" },
                    { "c6795103-158e-478d-8dd7-6e042dfbd687", "b1bbae4e-cba2-4187-98bb-bb3eb9011607", "IT", "IT" },
                    { "d8afc429-c3c5-456e-9066-8c5432d41a3c", "f493d483-2b48-438e-b98a-83b4a6044a88", "InfoFort", "INFOFORT" },
                    { "fc7cc3e9-a7de-44e0-96b8-70afeff8bc79", "4de44b67-1e37-48ff-aef9-47be12b351b9", "Store", "STORE" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4aac87a-955c-400b-a9e4-a2e8eccab983", "1472d6fc-9734-4c6d-90ef-a06654ca5a48" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5676615e-2b61-4b94-8026-8db4386143ac", "5cbee8f7-ffc6-40a2-94ea-6b95869b992d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5deae0c4-2416-4977-be4b-31d91ad80507", "72215891-1e49-4616-ba47-213e06a97f63" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f0ff379f-7b62-48df-a349-fd78bcc41f03", "e4fe7287-a6a4-4b27-be87-2c697c3cffe7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67304fac-57b0-407e-83a2-25a0d36e8a88", "1c03d0b2-131c-4479-be55-46fb1483f285" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0a95c8b-7d84-413d-99e9-3e4550ac3714", "c43f439b-fcbb-478e-8c58-76f57441c134" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b485168-ac68-418a-9d21-d83e406b1baf", "44a00696-64c8-4631-9ad4-c15125bedb55" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00e2ed7d-d370-471e-a017-ec08b5c1bcea", "cf8a4e2c-5deb-4eb7-8f84-d6086d144ad4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26d96987-919a-489f-ac73-8fb021aa8066", "103759ad-ee43-4d88-94d1-7a89412b8983" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac5f714a-488e-432f-8f25-60018ee1106f", "3db213ca-cc15-403e-9f45-614b7d9fabca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78424653-cdf5-48d7-898e-f6737b456450", "744c90da-d969-419d-a86b-0b0376f6d81b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a1fc6bd-78d1-49cb-afa8-e90b10409762", "f5f53d66-0eac-4cca-b18b-cdf37f9ca1d5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "702b46f4-410b-4f2b-b392-6b10919cd38d", "119e6d2f-9aee-41a8-87ad-a011fa51c09d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1cca87c4-d3ea-44dd-9503-48774373e9d2", "67d70538-7a6a-4127-8ea4-863d83f4e77d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41674b50-c3d5-43d0-a4d3-388b3ded2c25", "0239f4c3-7ace-4a63-9f0a-35b18eb15503" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a013092d-7749-4fb8-a684-6759807407ef", "191cd698-bb24-462e-aa13-70d41f914a2c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1fe6eaa4-355a-403b-bf1d-1c271590088f", "4d594951-3955-46b4-89d5-90c6bea013a0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c8c9294-7d72-4b35-b6cf-d20cb270c03c", "fc762a98-f34b-4000-b2e7-e6621005c9f8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aba7fff8-52a8-459d-a3af-40e4ec3da579", "5ef390e5-f85e-453c-8e26-f07641ddbe7c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c63a11b-c6c9-4b24-a865-a83851dc0ab2", "ab22e4ae-3abc-4cca-ad92-b8d543a84fab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb9e0d01-343d-4a9e-8883-a9c426c8527f", "e2c537e1-f938-4da6-a76e-a62dc780746a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "149510fb-80d5-4ad8-833e-98de27d66c45", "4e03107b-db19-45af-bf2f-f4e4bfc81192" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5bb66dec-2993-4560-86cd-7d1e1bcb9ca5", "c5e67059-fe70-416b-b005-2372fe0f7387" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5cf9b115-78f8-4034-8cb1-8aa242eae6f7", "db8f2c94-d5af-4159-9aa5-7496e4a2110c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4aa0b63d-94c5-4a8c-8154-9509d111fd54", "494bb708-128f-4f1d-9aa4-c2811676c160" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50d43bf9-8c6c-44b2-ae5c-faf806278e96", "e036fac0-de8d-469d-a6fc-32bdf9cd3b85" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "230ef1d9-05cd-4921-a332-93d3c3a34a49", "12546dc0-72c6-4157-a79d-af73d18980f1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "244c0e0e-e451-417b-b2c3-a22b374e8c84", "e6793662-72ef-4aeb-b3f4-1eefe41b176d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7117fa67-c87a-4d3c-81a5-3197e4503cb9", "5ee82064-a788-4e23-8690-519077796baf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "18df0283-9454-42f2-9e1e-1bdbb68468d4", "43143caf-91e5-4f2f-8efa-f955dc733f70" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a693eb7-37f9-4be4-9146-cd444cdc7682", "73c32452-0792-4425-af4d-b1d2ce34e78e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88411f14-0e28-42ea-821b-53fa781af054", "b98a5319-b52a-4133-956a-5c5c86d6c87d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d493001f-de49-4f53-8c2c-3964f3b1284a", "8e214821-df30-412a-85b2-1249397e3f11" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0b7e3b2-e9e9-41f8-824d-35eb71fb7c4d", "23e88c26-bf53-4be6-8f2a-305d7535e0c6" });

            migrationBuilder.InsertData(
                table: "DefinedRequestRole",
                columns: new[] { "DefinedRequestId", "RoleId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Permission" },
                values: new object[,]
                {
                    { 1L, "77e4a066-8690-4567-828e-92bebab64032", null, null, null, null, "Review" },
                    { 1L, "c55f00ec-b8b2-4d7e-84eb-85e40d44b944", null, null, null, null, "Request" }
                });

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "77e4a066-8690-4567-828e-92bebab64032", "51124" },
                    { "c55f00ec-b8b2-4d7e-84eb-85e40d44b944", "51188" }
                });
        }
    }
}
