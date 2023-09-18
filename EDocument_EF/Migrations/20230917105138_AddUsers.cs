using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class AddUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "db3fce70-d4c2-4766-a989-fd43e27e9abc");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "cf902596-6ca6-47a6-bceb-ea113afec936");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "10",
                column: "ConcurrencyStamp",
                value: "5e051252-cbe6-43dc-8a59-1c90ed6a3d1c");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "11",
                column: "ConcurrencyStamp",
                value: "0b2d3501-6ccb-490f-83ea-67a7932c1666");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "12",
                column: "ConcurrencyStamp",
                value: "b9174117-38da-4957-bd45-a40f70be2005");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5f7980f2-35e3-4ad1-a402-78c0ce2c71bd");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "0301d2f0-5c45-4f1e-9782-98269b95c674");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "cc459410-5335-43c0-8d00-2459aa4bc8d9");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "302d83ba-9f0d-47ce-b1b2-7c1f72ba9503");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "5ecbf1d9-157d-4c20-b059-bdd9bdf9926e");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "ad30a23e-3767-44e9-845f-3fbc9cb13aac");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8",
                column: "ConcurrencyStamp",
                value: "b36a78e0-a6f6-4b2d-becf-53f9459f414c");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9",
                column: "ConcurrencyStamp",
                value: "df1649ed-50c3-45c7-815a-a7a98cfa7eab");

            migrationBuilder.InsertData(
                schema: "security",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Company", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DepartmentId", "Email", "EmailConfirmed", "FullName", "IsActive", "IsEmployee", "LastLogin", "LockoutEnabled", "LockoutEnd", "ManagerId", "ModifiedAt", "ModifiedBy", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SectionId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "50000", 0, "DP World", "fa4c3839-ea00-4fd0-a33b-6b4c84396d9a", null, null, null, "stores_manager@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "STORES_MANAGER@DPWORLD.COM", "STORES_MANAGER", null, "01002234498", false, "Head of Stores", null, "56665949-d853-4ca0-8667-900c0a871109", false, "stores_manager" },
                    { "50128", 0, "DP World", "e337230e-e66f-4745-bdb5-c45d70af7ff7", null, null, null, "ops-cfs_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "OPS-CFS_SEC_HEAD@DPWORLD.COM", "OPS-CFS_SEC_HEAD", null, "01002234498", false, "OPS-CFS Section Head", null, "da18fea5-d27a-488e-bd91-a8db53210f79", false, "ops-cfs_sec_head" },
                    { "50136", 0, "DP World", "d546579c-bbb1-4938-9680-ce006cb33248", null, null, null, "engineering_manager@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "ENGINEERING_MANAGER@DPWORLD.COM", "ENGINEERING_MANAGER", null, "01002234498", false, "Head of Engineering", null, "59a0f364-b1ab-4e2b-8555-51dccf7b4438", false, "engineering_manager" },
                    { "50140", 0, "DP World", "28cc7ef2-cd93-4271-968b-5ab1cbfd9036", null, null, null, "hc-ssp_manager@dpworld.com", false, "Maged Mohsen", true, true, null, false, null, null, null, null, "HC-SSP_MANAGER@DPWORLD.COM", "HC-SSP_MANAGER", null, "01002234498", false, "Head of HC - Samsung SDS project", null, "f58caaf2-9d1c-425a-96c8-d02be7118324", false, "hc-ssp_manager" },
                    { "50141", 0, "DP World", "5c98b432-0f18-4708-a867-701d08041b05", null, null, null, "ops-ct_manager@dpworld.com", false, "Maged Mohsen", true, true, null, false, null, null, null, null, "OPS-CT_MANAGER@DPWORLD.COM", "OPS-CT_MANAGER", null, "01002234498", false, "Head of OPS-Containers", null, "08ae52fe-c1d3-4fb6-a75e-808455c93311", false, "ops-ct_manager" },
                    { "50263", 0, "DP World", "682549fc-f790-4586-a584-2408196243d0", null, null, null, "security_manager@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "SECURITY_MANAGER@DPWORLD.COM", "SECURITY_MANAGER", null, "01002234498", false, "Head of Security", null, "c255943e-c967-4c9c-978d-fba488f095f8", false, "security_manager" },
                    { "50269", 0, "DP World", "ffebb77c-d53c-4a0a-97f0-9f546f515c55", null, null, null, "admin_manager@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "ADMIN_MANGER@DPWORLD.COM", "ADMIN_MANAGER", null, "01002234498", false, "Head of Administration", null, "182f61fa-aefe-450c-8ee9-8d171f4e993d", false, "admin_manager" },
                    { "50279", 0, "DP World", "487cf860-caf8-4ad9-82b8-99f2d44f3e29", null, null, null, "people_manager@dpworld.com", false, "Waleed Aboelgadayl", true, true, null, false, null, null, null, null, "PEOPLE_MANAGER@DPWORLD.COM", "PEOPLE_MANAGER", null, "01002234498", false, "Head of People", null, "97e4f9c5-6e20-4915-a1cd-7d9f12d6d982", false, "people_manager" },
                    { "50354", 0, "DP World", "615351b0-cb59-4534-9532-d2f14837f5f5", null, null, null, "ops-bgc_manager@dpworld.com", false, "Mohamed Radwan", true, true, null, false, null, null, null, null, "OPS-BGC_MANAGER@DPWORLD.COM", "OPS-BGC_MANAGER", null, "01002234498", false, "Head of OPS-Cargo & Bulk", null, "75c46354-76ca-4464-a787-7f017f815432", false, "ops-bgc_manager" },
                    { "50562", 0, "DP World", "c80458c8-1e85-42a1-8732-dea7a546ef58", null, null, null, "tec-planning_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "TEC-PLANNING_SEC_HEAD@DPWORLD.COM", "TEC-PLANNING_SEC_HEAD", null, "01002234498", false, "TEC-Planning Section Head", null, "a7d5e058-07b4-4119-b05f-8569bb64f95d", false, "tec-planning_sec_head" },
                    { "50670", 0, "DP World", "331ba7e9-bc9d-49fb-824f-acd8d2f3344a", null, null, null, "ops-ct_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "OPS-DRI_SEC_HEAD@DPWORLD.COM", "OPS-CT_SEC_HEAD", null, "01002234498", false, "OPS-Containers Section Head", null, "68c5b805-6cb3-4cc9-a160-25534b01371e", false, "ops-ct_sec_head" },
                    { "50844", 0, "DP World", "f7a0145e-5e0e-41ec-b4dc-c8d9045af7f3", null, null, null, "ops-dri_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "OPS-DRI_SEC_HEAD@DPWORLD.COM", "OPS-DRI_SEC_HEAD", null, "01002234498", false, "OPS-DRI Section Head", null, "a525449d-e6db-4728-80b3-65e1dc304312", false, "ops-dri_sec_head" },
                    { "50882", 0, "DP World", "61df1a1f-6a29-49e3-a3c2-8952d8f19b3c", null, null, null, "qhse_manager@dpworld.com", false, "Hassan Abdelghany", true, true, null, false, null, null, null, null, "QHSE_MANAGER@DPWORLD.COM", "QHSE_MANAGER", null, "01002234498", false, "Head of QHSE", null, "9666ffd1-f78a-45f3-a9ca-7b96b90ff7e7", false, "qhse_manager" },
                    { "50962", 0, "DP World", "23ec3422-3f35-4942-b748-d37a9adeb420", null, null, null, "governmentalrelation_manager@dpworld.com", false, "Mohamed Tarek", true, true, null, false, null, null, null, null, "GOVERNMENTALRELATION_MANAGER@DPWORLD.COM", "GR_MANAGER", null, "01002234498", false, "Head of Governmental Relation", null, "68048295-db7d-436a-abfb-c89d89c6d2bf", false, "gr_manager" },
                    { "51090", 0, "DP World", "0f931319-fa09-4ee3-a1f0-0494a4b07d67", null, null, null, "tec-crane_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "TEC-CRANE_SEC_HEAD@DPWORLD.COM", "TEC-CRANE_SEC_HEAD", null, "01002234498", false, "TEC-Crane Section Head", null, "6f65ca64-b1d0-4225-894b-dbaf602f0de2", false, "tec-crane_sec_head" },
                    { "51124", 0, "DP World", "cdf097d6-1f4a-4cb5-93f6-d81b8995354c", null, null, null, "finance_manager@dpworld.com", false, "Mustafa Sultan", true, true, null, false, null, null, null, null, "FINANCE_MANAGER@DPWORLD.COM", "FINANCE_MANAGER", null, "01002234498", false, "Head of Finance", null, "997b57ee-dbad-4b99-9fc0-8e0cc741ecb9", false, "finance_manager" },
                    { "51126", 0, "DP World", "1e752df6-6474-4eda-800f-5dc1a00a976c", null, null, null, "tec-workshop_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "TEC-WORKSHOP_SEC_HEAD@DPWORLD.COM", "TEC-WORKSHOP_SEC_HEAD", null, "01002234498", false, "TEC-Workshop Section Head", null, "2c33d312-fe5b-4dc8-b47b-1d9cf9cdc952", false, "tec-workshop_sec_head" },
                    { "51188", 0, "DP World", "e00d8f7b-1683-4120-a52c-106de1afae53", null, null, null, "procurement_manager@dpworld.com", false, "Tamer Elsayed", true, true, null, false, null, null, null, null, "PROCUREMENT_MANAGER@DPWORLD.COM", "PROCURMENT_MANAGER", null, "01002234498", false, "Head of Procurment", null, "b4d7597c-039e-4b1f-96ee-547f4627a39d", false, "procurment_manager" },
                    { "51229", 0, "DP World", "b9806c90-505c-4618-a07a-17b3cebb9f22", null, null, null, "customerservice_manager@dpworld.com", false, "Hassan Nagah", true, true, null, false, null, null, null, null, "CUSTOMERSERVICE_MANAGER@DPWORLD.COM", "CS_MANAGER", null, "01002234498", false, "Head of Customer Service", null, "60582441-53c5-418f-9698-4fded2673a3c", false, "cs_manager" },
                    { "51330", 0, "DP World", "719c50df-7ff8-40a5-b68f-10cf9d77bfcb", null, null, null, "businesstransformation_manager@dpworld.com", false, "Alaa Nasr", true, true, null, false, null, null, null, null, "BUSINESSTRANSFORMATION_MANAGER@DPWORLD.COM", "BT_MANAGER", null, "01002234498", false, "Head of Business Transformation", null, "bb081399-871e-4278-a02a-0a59679f7773", false, "bt_manager" },
                    { "51331", 0, "DP World", "5c3745a9-8189-4149-a7db-361070e4f017", null, null, null, "it_manager@dpworld.com", false, "Alaa Nasr", true, true, null, false, null, null, null, null, "IT_MANAGER@DPWORLD.COM", "IT_MANAGER", null, "01002234498", false, "Head of IT", null, "e37f0fbd-7b22-40e8-ae36-22b6ffcf50df", false, "it_manager" },
                    { "51449", 0, "DP World", "9bb57f71-edb4-4775-8458-295e20104302", null, null, null, "ops-cg_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "OPS-CG_SEC_HEAD@DPWORLD.COM", "OPS-CG_SEC_HEAD", null, "01002234498", false, "OPS-Cargo & Bulk Section Head", null, "ce96c350-6f1d-4c61-bfe4-14a1e9860632", false, "ops-cg_sec_head" },
                    { "51509", 0, "DP World", "4bc255b6-fe2f-433d-92c4-cd65c320cedc", null, null, null, "commercial-ct_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "ECOMMERCIAL-CT_SEC_HEAD@DPWORLD.COM", "COMMERCIAL-CT_SEC_HEAD", null, "01002234498", false, "Commercial / Containers Section Head", null, "60e9c6bd-8dd8-454c-9070-a885a26171b4", false, "commercial-ct_sec_head" },
                    { "51520", 0, "DP World", "1cb18a9c-f5a8-42b7-9a00-756ca8349c86", null, null, null, "qhse_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "QHSE_SEC_HEAD@DPWORLD.COM", "QHSE_SEC_HEAD", null, "01002234498", false, "QHSE Section HEad", null, "e89916fc-b6db-4e9d-9da7-9f58874a550e", false, "qhse_sec_head" },
                    { "51529", 0, "DP World", "4a6813a2-59f1-4a1f-b0a1-de965353e33d", null, null, null, "projects_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "PROJECTS_SEC_HEAD@DPWORLD.COM", "PROJECTS_SEC_HEAD", null, "01002234498", false, "Projects Section Head", null, "2ce2668a-225c-4afa-8e10-4bdabba814db", false, "projects_sec_head" },
                    { "51572", 0, "DP World", "a2ef8ded-fc89-474a-8347-738ce623a181", null, null, null, "hc-ds_manager@dpworld.com", false, "Aliaa Elgammal", true, true, null, false, null, null, null, null, "HC-DS_MANAGER@DPWORLD.COM", "HC-DS_MANAGER", null, "01002234498", false, "Head of HC - DUBUY Sales", null, "0b41c162-a7a6-4e8f-bfe7-b41246de267f", false, "hc-ds_manager" },
                    { "51573", 0, "DP World", "4ebd37b5-d473-43d5-b406-c002b4f5ea13", null, null, null, "commercial_manager@dpworld.com", false, "Aliaa Elgammal", true, true, null, false, null, null, null, null, "COMMERCIAL_MANAGER@DPWORLD.COM", "COMMERCIAL_MANAGER", null, "01002234498", false, "Head of Commercial", null, "f43db7db-63c9-4f18-b4fe-62d5b7545a5c", false, "commercial_manager" },
                    { "51583", 0, "DP World", "574dc5f1-9b7e-4ed0-88e4-64608fb48cde", null, null, null, "commercial-bgc_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "ECOMMERCIAL-BGC_SEC_HEAD@DPWORLD.COM", "COMMERCIAL-BGC_SEC_HEAD", null, "01002234498", false, "CommercialBulk / GC Section Head", null, "b5f4dc61-34a5-40ae-a491-2ece38658bfe", false, "commercial-bgc_sec_head" },
                    { "51659", 0, "DP World", "1c8469c8-ed96-4356-825b-1d78775fe35b", null, null, null, "projectsfacilitymanager_manager@dpworld.com", false, "Mohamed Mandour", true, true, null, false, null, null, null, null, "PROJECTSFACILITYMANAGER_MANAGER@DPWORLD.COM", "PROJECTS_MANAGER", null, "01002234498", false, "Head of Projects & Facility Management", null, "c77e3b88-91d3-4a32-889a-8458f0bab5ad", false, "projects_manager" },
                    { "51668", 0, "DP World", "bc8e9f93-614e-4227-9916-c8cc159fe893", null, null, null, "communications_manager@dpworld.com", false, "Amina Hatem", true, true, null, false, null, null, null, null, "COMMUNICATIONS_MANAGER@DPWORLD.COM", "COMMUNICATIONS_MANAGER", null, "01002234498", false, "Head of Communications", null, "01b7671e-db5a-43be-80da-f278c864f7d6", false, "communications_manager" },
                    { "90008", 0, "DP World", "463498e8-7494-426e-8968-0e8c5254d4fb", null, null, null, "hc-ds_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "HC-DS_SEC_HEAD@DPWORLD.COM", "HC-DS_SEC_HEAD", null, "01002234498", false, "HC - DUBUY Sales Section Head", null, "4d4b5498-eade-4352-8c18-2e38422eaaa8", false, "hc-ds_sec_head" },
                    { "90010", 0, "DP World", "75bfe473-c00f-48c0-92e0-e9132ae83d7b", null, null, null, "freightforwarding_manager@dpworld.com", false, "Hanaa Mohamed", true, true, null, false, null, null, null, null, "FREIGHTFORWARDING_MANAGER@DPWORLD.COM", "FF_MANAGER", null, "01002234498", false, "Head of Freight Forwarding", null, "fccdb0b7-43ce-4baf-82ab-5c40710b5ef1", false, "ff_manager" },
                    { "90015", 0, "DP World", "0b6d0cb5-9ea2-4fe4-bf63-4a2b4ea38675", null, null, null, "hc-ssp_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "HC-SSP_SEC_HEAD@DPWORLD.COM", "HC-SSP_SEC_HEAD", null, "01002234498", false, "HC - Samsung SDS project  Section Head", null, "5b65371e-ff78-4749-bcdc-d1eb7115a2ba", false, "hc-ssp_sec_head" },
                    { "Exp-16", 0, "DP World", "d48f00dd-643e-47f8-b9aa-aab5b422fd40", null, null, null, "executivemanagement_manager@dpworld.com", false, "Urs Moll", true, true, null, false, null, null, null, null, "EXECUTIVEMANAGEMENT_MANAGER@DPWORLD.COM", "EM_MANAGER", null, "01002234498", false, "Head of Executive Management", null, "ddb8b2bf-3870-4e53-bd19-40ef0d9956ac", false, "em_manager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015");

            migrationBuilder.DeleteData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "2747bff9-8ace-4b90-9169-e9659d36c0e0");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "1fdbe97b-3681-4002-9515-c0b82c8ec6fa");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "10",
                column: "ConcurrencyStamp",
                value: "0bf3009c-fb47-4d25-bf3a-61270eb0cfcb");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "11",
                column: "ConcurrencyStamp",
                value: "728ac55a-b327-41d9-8d2b-c62112610709");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "12",
                column: "ConcurrencyStamp",
                value: "f7367b0a-3f78-4c75-8d31-cfabf3b8743a");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2d344664-722d-4b1a-b7b2-a2eedc34e389");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "9d380fcf-d1ca-4801-b4d5-7b06721a7f7f");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "d308ad56-5be3-45ca-a62d-b404dda6f6d6");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "6257aae6-008b-4bda-bbb1-572e5a5e4d19");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "cd768ae5-f37e-4d87-a19c-f934761b847f");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "a10dbe86-b2ff-467b-bac4-bff48555d893");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8",
                column: "ConcurrencyStamp",
                value: "1d30553f-2d44-4789-889e-444c62484b9d");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9",
                column: "ConcurrencyStamp",
                value: "b6d6d252-6e57-4917-838f-66aa0ee07277");
        }
    }
}
