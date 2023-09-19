using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class assignRolesWithPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                schema: "security",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0", "3ef3ee55-3306-4ee8-b13d-7f59dd5dc112", "SuperAdmin", "SUPERADMIN" },
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
        }
    }
}
