using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "security",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Company", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "DepartmentId", "Email", "EmailConfirmed", "FullName", "IsActive", "IsEmployee", "LastLogin", "LockoutEnabled", "LockoutEnd", "ManagerId", "ModifiedAt", "ModifiedBy", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Position", "SectionId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "50000", 0, "DP World", "972b65f0-691d-4789-9811-c54f1e743db8", null, null, null, "stores_manager@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "STORES_MANAGER@DPWORLD.COM", "STORES_MANAGER", null, "01002234498", false, "Head of Stores", null, "3ffd62a2-dbc3-4282-bab1-d53134a091d4", false, "stores_manager" },
                    { "50128", 0, "DP World", "715d44fb-0228-4034-8c95-a5d17190e030", null, null, null, "ops-cfs_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "OPS-CFS_SEC_HEAD@DPWORLD.COM", "OPS-CFS_SEC_HEAD", null, "01002234498", false, "OPS-CFS Section Head", null, "fbb09dd6-d5f4-493e-addd-e268bd5a860c", false, "ops-cfs_sec_head" },
                    { "50136", 0, "DP World", "51479dfb-001d-4a77-9f8c-cb87a778dd04", null, null, null, "engineering_manager@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "ENGINEERING_MANAGER@DPWORLD.COM", "ENGINEERING_MANAGER", null, "01002234498", false, "Head of Engineering", null, "2157ac66-9989-4cd4-8928-832ab727d2a7", false, "engineering_manager" },
                    { "50140", 0, "DP World", "a24227a8-d29e-4846-b9c2-1430a5b5ef4d", null, null, null, "hc-ssp_manager@dpworld.com", false, "Maged Mohsen", true, true, null, false, null, null, null, null, "HC-SSP_MANAGER@DPWORLD.COM", "HC-SSP_MANAGER", null, "01002234498", false, "Head of HC - Samsung SDS project", null, "748ce9e0-cdbe-42d7-8298-0a399ed8c4ed", false, "hc-ssp_manager" },
                    { "50141", 0, "DP World", "5472297b-4536-487c-81fd-6903e5e7fb42", null, null, null, "ops-ct_manager@dpworld.com", false, "Maged Mohsen", true, true, null, false, null, null, null, null, "OPS-CT_MANAGER@DPWORLD.COM", "OPS-CT_MANAGER", null, "01002234498", false, "Head of OPS-Containers", null, "91a57fe5-f7af-4aaa-805b-da484291cb09", false, "ops-ct_manager" },
                    { "50263", 0, "DP World", "c5e27ef9-c00c-4a19-a5b9-8f3f66ebebba", null, null, null, "security_manager@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "SECURITY_MANAGER@DPWORLD.COM", "SECURITY_MANAGER", null, "01002234498", false, "Head of Security", null, "560f936f-c0aa-4145-a044-43c042ed3506", false, "security_manager" },
                    { "50269", 0, "DP World", "d5539061-dd90-4af9-9b9f-e6d631858db3", null, null, null, "admin_manager@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "ADMIN_MANGER@DPWORLD.COM", "ADMIN_MANAGER", null, "01002234498", false, "Head of Administration", null, "526f7add-a1c2-4827-883b-f4e0b80e8aa0", false, "admin_manager" },
                    { "50279", 0, "DP World", "47a6226c-ee5e-40ea-bb21-d9e12cb1eabc", null, null, null, "people_manager@dpworld.com", false, "Waleed Aboelgadayl", true, true, null, false, null, null, null, null, "PEOPLE_MANAGER@DPWORLD.COM", "PEOPLE_MANAGER", null, "01002234498", false, "Head of People", null, "15522425-8b72-4883-900a-b2b5a2e4bc7c", false, "people_manager" },
                    { "50354", 0, "DP World", "dcdf3033-59b2-4ff4-9b43-9cd9e309760f", null, null, null, "ops-bgc_manager@dpworld.com", false, "Mohamed Radwan", true, true, null, false, null, null, null, null, "OPS-BGC_MANAGER@DPWORLD.COM", "OPS-BGC_MANAGER", null, "01002234498", false, "Head of OPS-Cargo & Bulk", null, "acb895c6-7afe-441e-a6af-e46f437f66da", false, "ops-bgc_manager" },
                    { "50562", 0, "DP World", "23aa6a00-1309-43b6-802f-197e22f4abcc", null, null, null, "tec-planning_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "TEC-PLANNING_SEC_HEAD@DPWORLD.COM", "TEC-PLANNING_SEC_HEAD", null, "01002234498", false, "TEC-Planning Section Head", null, "c4618284-b2cd-4749-acae-69a12a7884f8", false, "tec-planning_sec_head" },
                    { "50670", 0, "DP World", "a3d4d66e-1f2d-4935-bd9b-f640fcd1c4a3", null, null, null, "ops-ct_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "OPS-DRI_SEC_HEAD@DPWORLD.COM", "OPS-CT_SEC_HEAD", null, "01002234498", false, "OPS-Containers Section Head", null, "1bccf348-21b7-4f3d-87f3-653318fb2956", false, "ops-ct_sec_head" },
                    { "50844", 0, "DP World", "bea0f7a6-2acc-4a7b-aa29-c27229645dc0", null, null, null, "ops-dri_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "OPS-DRI_SEC_HEAD@DPWORLD.COM", "OPS-DRI_SEC_HEAD", null, "01002234498", false, "OPS-DRI Section Head", null, "5655fabd-cf06-46df-bdf5-bac5bb1fb096", false, "ops-dri_sec_head" },
                    { "50882", 0, "DP World", "a2d8beb0-f8d0-40cb-b560-926107d3aec8", null, null, null, "qhse_manager@dpworld.com", false, "Hassan Abdelghany", true, true, null, false, null, null, null, null, "QHSE_MANAGER@DPWORLD.COM", "QHSE_MANAGER", null, "01002234498", false, "Head of QHSE", null, "b7ce9d3d-87dc-473b-a4bb-7058aa7e1f28", false, "qhse_manager" },
                    { "50962", 0, "DP World", "be61dc10-de9d-496d-82e4-4d7f61815b86", null, null, null, "governmentalrelation_manager@dpworld.com", false, "Mohamed Tarek", true, true, null, false, null, null, null, null, "GOVERNMENTALRELATION_MANAGER@DPWORLD.COM", "GR_MANAGER", null, "01002234498", false, "Head of Governmental Relation", null, "a7b0a511-bfd8-4ee5-b593-fcfb90c66ddd", false, "gr_manager" },
                    { "51090", 0, "DP World", "c72df6df-dc11-4712-ac39-af062c24cc01", null, null, null, "tec-crane_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "TEC-CRANE_SEC_HEAD@DPWORLD.COM", "TEC-CRANE_SEC_HEAD", null, "01002234498", false, "TEC-Crane Section Head", null, "8f28ff1c-6a07-4ae3-a1ae-5cd88ad2862a", false, "tec-crane_sec_head" },
                    { "51124", 0, "DP World", "b80b5316-275c-497f-b618-4e92ce78daa6", null, null, null, "finance_manager@dpworld.com", false, "Mustafa Sultan", true, true, null, false, null, null, null, null, "FINANCE_MANAGER@DPWORLD.COM", "FINANCE_MANAGER", null, "01002234498", false, "Head of Finance", null, "c7c9b518-188a-4c63-80e8-0c2c3191ba61", false, "finance_manager" },
                    { "51126", 0, "DP World", "4465aaf7-2f7f-447d-88f4-645e24ad8038", null, null, null, "tec-workshop_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "TEC-WORKSHOP_SEC_HEAD@DPWORLD.COM", "TEC-WORKSHOP_SEC_HEAD", null, "01002234498", false, "TEC-Workshop Section Head", null, "42f61812-5090-47c6-bd6b-9a397d6fbef1", false, "tec-workshop_sec_head" },
                    { "51188", 0, "DP World", "6701aaa2-4f7a-457c-8fd2-0647a0bd3512", null, null, null, "procurement_manager@dpworld.com", false, "Tamer Elsayed", true, true, null, false, null, null, null, null, "PROCUREMENT_MANAGER@DPWORLD.COM", "PROCURMENT_MANAGER", null, "01002234498", false, "Head of Procurment", null, "87ea2a66-a8ec-4d66-bede-18f636a31583", false, "procurment_manager" },
                    { "51229", 0, "DP World", "84629739-d9d3-41f2-9175-80fa86c68dd3", null, null, null, "customerservice_manager@dpworld.com", false, "Hassan Nagah", true, true, null, false, null, null, null, null, "CUSTOMERSERVICE_MANAGER@DPWORLD.COM", "CS_MANAGER", null, "01002234498", false, "Head of Customer Service", null, "18341a46-59cc-4a57-a0cf-b2a38cb0fd8e", false, "cs_manager" },
                    { "51330", 0, "DP World", "562c5d28-4bb0-4f11-ac49-61aada72cd42", null, null, null, "businesstransformation_manager@dpworld.com", false, "Alaa Nasr", true, true, null, false, null, null, null, null, "BUSINESSTRANSFORMATION_MANAGER@DPWORLD.COM", "BT_MANAGER", null, "01002234498", false, "Head of Business Transformation", null, "ac4c3daf-0b06-4aa2-a771-5b30b588b32d", false, "bt_manager" },
                    { "51331", 0, "DP World", "297b44b1-1b8e-416a-9c62-8375cdf7b0b5", null, null, null, "it_manager@dpworld.com", false, "Alaa Nasr", true, true, null, false, null, null, null, null, "IT_MANAGER@DPWORLD.COM", "IT_MANAGER", null, "01002234498", false, "Head of IT", null, "c675b550-03cd-4369-903b-35e0da9d06c2", false, "it_manager" },
                    { "51449", 0, "DP World", "95df6ff4-25ab-487e-b056-a0521133eb1c", null, null, null, "ops-cg_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "OPS-CG_SEC_HEAD@DPWORLD.COM", "OPS-CG_SEC_HEAD", null, "01002234498", false, "OPS-Cargo & Bulk Section Head", null, "b85b7858-fa75-4237-ba4f-c8188ea035c2", false, "ops-cg_sec_head" },
                    { "51509", 0, "DP World", "4b3f40fa-5aba-4e43-b404-19937eda299c", null, null, null, "commercial-ct_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "ECOMMERCIAL-CT_SEC_HEAD@DPWORLD.COM", "COMMERCIAL-CT_SEC_HEAD", null, "01002234498", false, "Commercial / Containers Section Head", null, "8e9bf403-8514-4dd7-8304-18dda6aab048", false, "commercial-ct_sec_head" },
                    { "51520", 0, "DP World", "5fbb7cf1-204a-42d3-b2e0-250dd5e5a937", null, null, null, "qhse_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "QHSE_SEC_HEAD@DPWORLD.COM", "QHSE_SEC_HEAD", null, "01002234498", false, "QHSE Section HEad", null, "b44a04d0-64b9-4edc-bd90-02194ed0f6b0", false, "qhse_sec_head" },
                    { "51529", 0, "DP World", "8f89279e-77e1-4b1e-9064-2f387102e328", null, null, null, "projects_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "PROJECTS_SEC_HEAD@DPWORLD.COM", "PROJECTS_SEC_HEAD", null, "01002234498", false, "Projects Section Head", null, "42348360-b046-412e-8507-4a146033143b", false, "projects_sec_head" },
                    { "51572", 0, "DP World", "186a90c2-8c56-40f9-bbc5-a2c9d448899b", null, null, null, "hc-ds_manager@dpworld.com", false, "Aliaa Elgammal", true, true, null, false, null, null, null, null, "HC-DS_MANAGER@DPWORLD.COM", "HC-DS_MANAGER", null, "01002234498", false, "Head of HC - DUBUY Sales", null, "75997ffa-538e-4f65-9bbf-9f1a6132e7ac", false, "hc-ds_manager" },
                    { "51573", 0, "DP World", "b63f8874-bf67-4305-9376-79f47f15651f", null, null, null, "commercial_manager@dpworld.com", false, "Aliaa Elgammal", true, true, null, false, null, null, null, null, "COMMERCIAL_MANAGER@DPWORLD.COM", "COMMERCIAL_MANAGER", null, "01002234498", false, "Head of Commercial", null, "68b94b1b-e27f-4098-8b53-1d011f6c490f", false, "commercial_manager" },
                    { "51583", 0, "DP World", "427cfd7c-0bf1-4fcf-a92b-79a93859ffea", null, null, null, "commercial-bgc_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "ECOMMERCIAL-BGC_SEC_HEAD@DPWORLD.COM", "COMMERCIAL-BGC_SEC_HEAD", null, "01002234498", false, "CommercialBulk / GC Section Head", null, "9297fa06-b271-47e5-b9b4-909fc4b99b1c", false, "commercial-bgc_sec_head" },
                    { "51659", 0, "DP World", "b1e34d8a-d27f-4103-8ef7-be6776df490b", null, null, null, "projectsfacilitymanager_manager@dpworld.com", false, "Mohamed Mandour", true, true, null, false, null, null, null, null, "PROJECTSFACILITYMANAGER_MANAGER@DPWORLD.COM", "PROJECTS_MANAGER", null, "01002234498", false, "Head of Projects & Facility Management", null, "154b96ba-646f-49b9-b7cc-7096f89c56da", false, "projects_manager" },
                    { "51668", 0, "DP World", "022f52dc-e26b-4336-8f6a-9c8560757bf1", null, null, null, "communications_manager@dpworld.com", false, "Amina Hatem", true, true, null, false, null, null, null, null, "COMMUNICATIONS_MANAGER@DPWORLD.COM", "COMMUNICATIONS_MANAGER", null, "01002234498", false, "Head of Communications", null, "8e9ea6c7-a314-4edd-8e3c-3c75d92bdc24", false, "communications_manager" },
                    { "90008", 0, "DP World", "3b0aa359-2340-4f86-b11b-d041ec13e493", null, null, null, "hc-ds_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "HC-DS_SEC_HEAD@DPWORLD.COM", "HC-DS_SEC_HEAD", null, "01002234498", false, "HC - DUBUY Sales Section Head", null, "ff35b8ab-3f98-41c4-a568-d630b4197086", false, "hc-ds_sec_head" },
                    { "90010", 0, "DP World", "6029212d-198d-44e2-8863-68a1a41ce9a5", null, null, null, "freightforwarding_manager@dpworld.com", false, "Hanaa Mohamed", true, true, null, false, null, null, null, null, "FREIGHTFORWARDING_MANAGER@DPWORLD.COM", "FF_MANAGER", null, "01002234498", false, "Head of Freight Forwarding", null, "ba6866f4-f323-46c6-86ce-7763454458ea", false, "ff_manager" },
                    { "90015", 0, "DP World", "547c07e3-94f5-47c9-abb4-1f795fd0b853", null, null, null, "hc-ssp_sec_head@dpworld.com", false, "Ahmed Zaki", true, true, null, false, null, null, null, null, "HC-SSP_SEC_HEAD@DPWORLD.COM", "HC-SSP_SEC_HEAD", null, "01002234498", false, "HC - Samsung SDS project  Section Head", null, "0d782f9b-6db0-45b0-95e4-cca1c523fdb6", false, "hc-ssp_sec_head" },
                    { "Exp-16", 0, "DP World", "8269e4c6-7b65-4c2a-8d49-954725d8a870", null, null, null, "executivemanagement_manager@dpworld.com", false, "Urs Moll", true, true, null, false, null, null, null, null, "EXECUTIVEMANAGEMENT_MANAGER@DPWORLD.COM", "EM_MANAGER", null, "01002234498", false, "Head of Executive Management", null, "a80d9dfd-b444-4e21-96d0-69a9d4cfca7e", false, "em_manager" }
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
        }
    }
}
