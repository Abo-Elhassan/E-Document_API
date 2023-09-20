using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class updateRequestsRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VoucherRequest_RequestId",
                table: "VoucherRequest");

            migrationBuilder.DropIndex(
                name: "IX_TravelDeskRequest_RequestId",
                table: "TravelDeskRequest");

            migrationBuilder.DropIndex(
                name: "IX_DomainAccountRequest_RequestId",
                table: "DomainAccountRequest");

            migrationBuilder.DropIndex(
                name: "IX_CarRequest_RequestId",
                table: "CarRequest");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserRequest_RequestId",
                table: "ApplicationUserRequest");

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

            migrationBuilder.CreateIndex(
                name: "IX_VoucherRequest_RequestId",
                table: "VoucherRequest",
                column: "RequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelDeskRequest_RequestId",
                table: "TravelDeskRequest",
                column: "RequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DomainAccountRequest_RequestId",
                table: "DomainAccountRequest",
                column: "RequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarRequest_RequestId",
                table: "CarRequest",
                column: "RequestId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRequest_RequestId",
                table: "ApplicationUserRequest",
                column: "RequestId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VoucherRequest_RequestId",
                table: "VoucherRequest");

            migrationBuilder.DropIndex(
                name: "IX_TravelDeskRequest_RequestId",
                table: "TravelDeskRequest");

            migrationBuilder.DropIndex(
                name: "IX_DomainAccountRequest_RequestId",
                table: "DomainAccountRequest");

            migrationBuilder.DropIndex(
                name: "IX_CarRequest_RequestId",
                table: "CarRequest");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUserRequest_RequestId",
                table: "ApplicationUserRequest");

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

            migrationBuilder.CreateIndex(
                name: "IX_VoucherRequest_RequestId",
                table: "VoucherRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelDeskRequest_RequestId",
                table: "TravelDeskRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_DomainAccountRequest_RequestId",
                table: "DomainAccountRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_CarRequest_RequestId",
                table: "CarRequest",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRequest_RequestId",
                table: "ApplicationUserRequest",
                column: "RequestId");
        }
    }
}
