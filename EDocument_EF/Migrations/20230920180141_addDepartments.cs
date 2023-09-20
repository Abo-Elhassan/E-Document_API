using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DepartmentIcon", "DepartmentName", "ManagerId", "ModifiedAt", "ModifiedBy" },
                values: new object[,]
                {
                    { 1L, null, null, "Administration.svg", "Administration", "50269", null, null },
                    { 2L, null, null, null, "Freight Forwarding", "90010", null, null },
                    { 3L, null, null, null, "Business Transformation", "51331", null, null },
                    { 4L, null, null, "Commercial.svg", "Commercial", "51573", null, null },
                    { 5L, null, null, "Communications.svg", "Communications", "51668", null, null },
                    { 6L, null, null, "Customer Service.svg", "Customer Service", "51229", null, null },
                    { 7L, null, null, null, "Executive Management", "Exp-16", null, null },
                    { 8L, null, null, null, "Finance", "51124", null, null },
                    { 9L, null, null, null, "Governmental Relation", "50962", null, null },
                    { 10L, null, null, null, "HC - DUBUY Sales", "51573", null, null },
                    { 11L, null, null, null, "HC - Samsung SDS project", "50140", null, null },
                    { 12L, null, null, "IT.svg", "IT", "51331", null, null },
                    { 13L, null, null, "OPS-BGC.svg", "OPS-Cargo & Bulk", "50354", null, null },
                    { 14L, null, null, null, "OPS-Containers", "50141", null, null },
                    { 15L, null, null, "People .svg", "People", "50279", null, null },
                    { 16L, null, null, "Procurement.svg", "Procurement", "51188", null, null },
                    { 17L, null, null, null, "Projects & Facility Management", "51659", null, null },
                    { 18L, null, null, null, "QHSE", "50882", null, null },
                    { 19L, null, null, "Security.svg", "Security", "50263", null, null },
                    { 20L, null, null, "Stores.svg", "Store", "50000", null, null },
                    { 21L, null, null, "Technical Engineering.svg", "Engineering", "50136", null, null }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6ae6c081-cf40-4e21-8804-b5eee4940fe1", "330fd6aa-be40-41f7-975e-78b614f3e228" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d6710feb-285e-47b2-b561-d1850fe83c40", "6ebdd9f6-23d5-440a-9e59-0a0dd7f8a277" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e822515-ee39-4b9c-886c-f8c81998fc99", "f47fae92-fcc6-4a96-ad1b-3102888fcca7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86ff9edc-5d6a-4a92-a626-5b1df4f92a1e", "e45d6cee-9c5a-4c1e-8acc-88fbda6c1112" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3289529-e284-4ed7-9d9b-13c43fdfe94f", "50649680-c764-44b7-8f08-7e4c5d40aede" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "34f25201-2b03-4726-b928-80e00656b005", "d0c83f3e-5665-4296-80ef-2d667adb4936" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4266726e-6c10-4702-8ec0-05391d9dc511", "a9dac4b2-ab24-4c00-bf12-6387c7d7a334" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "599f277d-bc23-4f4c-973a-991cada51ae5", "7b1c3231-2c6d-49bf-8b8a-3a5268466519" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b1a226e-e299-4189-b833-199c7a574325", "dc0222fa-8b04-4bf4-a2d8-1f2dca54e90b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74df0d29-45eb-4582-a1dd-f238a033a095", "4514540a-e160-4ceb-83c5-779ee67b44c1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72d6c75b-8fc8-4e97-a52c-2e8d297b7250", "d1441376-be77-47e9-b187-4c9946629672" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b46e4f61-e11d-42e8-8cc9-0dda529e5f1e", "655db9c8-4157-4555-adf5-c1eed4baaa56" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e15e551-c86e-46f8-b780-90dd28c15cb1", "6724b9e0-43c3-4d1f-a065-3d4d82e24786" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea621c49-3fbd-4ade-8dbf-32765b36b603", "4285a9a4-df74-4123-996f-8c283186d163" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d515d2a6-253c-4512-a5b3-14121a508634", "2287b33a-f1d3-46db-82e8-03d80acb153f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d344941c-fc73-41b8-a956-146a922b37db", "19393834-457e-4b44-a6fd-b2821a173933" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9e176da-04cc-4ef2-a95a-1c3dd9b91d89", "4e80996b-05f5-442c-8a46-6d1cfe72ef78" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1457b1c8-4261-4a39-8685-41e6f1fb8cb8", "429fbe5c-a1a3-49ff-b7f8-4c6d2318f3dc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9c23d5b-99ad-489d-82a9-320b27a6915f", "e15ec2cd-81d1-457c-b03b-3040855c8050" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "161e28d7-d307-49ab-ae19-3820934ccc9d", "49baa3aa-3c55-4a08-8cc5-d39c194031cd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bb3846ab-3682-45da-9d29-723445817488", "4459060e-a1ab-4904-8920-6dbb0a37e190" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "44351345-6b49-4288-9fb9-d76bcabc3450", "6acd1233-1715-49d5-9315-11c42b0f6ef9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c45e816-ec75-414b-be87-d128bba9fe72", "7e184290-608b-4885-9898-4a505fee4e11" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c70d2b02-0f67-42d5-853f-1f75419fa1ea", "832c7c1d-f7b0-4cf0-8cf8-ec7e4d14ad18" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41e3da31-73e3-4b7c-99a5-aaa3c100c161", "80d89861-d2e0-4d7e-9ccf-47b742b7209a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08a741d7-4de0-406d-85d7-e0b3f311278f", "a69ad7f5-b4a7-46c5-90a8-5e2380dbee04" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5bd77888-2a8d-4bad-8b9f-42c33391568d", "73fcd586-889e-40cd-92eb-81e751ebd565" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e0b2ab3-5339-45ca-9ce8-4aebf7f6530e", "f127556f-6e67-4cb8-ba5f-5d12610a2210" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ebd444a-63be-4b94-b9de-832cb008c3af", "cb8c9a09-9a46-49f9-8e0b-248bd288815b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5050732-d4db-41e9-bc00-a0aeca64d36d", "974f8a5e-5bb3-4d30-ad66-06a33a1516ee" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8b43065-4230-4f0f-ac6d-ecf2caa491f7", "35016433-ef0c-4809-a1ab-113086c7cc46" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9610b772-7efb-4232-b496-767c22906d57", "70d6542b-0e30-4a36-8e52-6c94dd7edadf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5edee41-7b32-47e8-9689-e6a4c74aed99", "83cce25e-39ba-4e69-a3f5-0800e5d7c6ba" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32428b77-f431-4245-9b11-76d013923822", "dbe0ea7a-0377-441c-890c-c92df3e9d907" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "972b65f0-691d-4789-9811-c54f1e743db8", "3ffd62a2-dbc3-4282-bab1-d53134a091d4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "715d44fb-0228-4034-8c95-a5d17190e030", "fbb09dd6-d5f4-493e-addd-e268bd5a860c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51479dfb-001d-4a77-9f8c-cb87a778dd04", "2157ac66-9989-4cd4-8928-832ab727d2a7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a24227a8-d29e-4846-b9c2-1430a5b5ef4d", "748ce9e0-cdbe-42d7-8298-0a399ed8c4ed" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5472297b-4536-487c-81fd-6903e5e7fb42", "91a57fe5-f7af-4aaa-805b-da484291cb09" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5e27ef9-c00c-4a19-a5b9-8f3f66ebebba", "560f936f-c0aa-4145-a044-43c042ed3506" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5539061-dd90-4af9-9b9f-e6d631858db3", "526f7add-a1c2-4827-883b-f4e0b80e8aa0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47a6226c-ee5e-40ea-bb21-d9e12cb1eabc", "15522425-8b72-4883-900a-b2b5a2e4bc7c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dcdf3033-59b2-4ff4-9b43-9cd9e309760f", "acb895c6-7afe-441e-a6af-e46f437f66da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23aa6a00-1309-43b6-802f-197e22f4abcc", "c4618284-b2cd-4749-acae-69a12a7884f8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a3d4d66e-1f2d-4935-bd9b-f640fcd1c4a3", "1bccf348-21b7-4f3d-87f3-653318fb2956" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bea0f7a6-2acc-4a7b-aa29-c27229645dc0", "5655fabd-cf06-46df-bdf5-bac5bb1fb096" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2d8beb0-f8d0-40cb-b560-926107d3aec8", "b7ce9d3d-87dc-473b-a4bb-7058aa7e1f28" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be61dc10-de9d-496d-82e4-4d7f61815b86", "a7b0a511-bfd8-4ee5-b593-fcfb90c66ddd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c72df6df-dc11-4712-ac39-af062c24cc01", "8f28ff1c-6a07-4ae3-a1ae-5cd88ad2862a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b80b5316-275c-497f-b618-4e92ce78daa6", "c7c9b518-188a-4c63-80e8-0c2c3191ba61" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4465aaf7-2f7f-447d-88f4-645e24ad8038", "42f61812-5090-47c6-bd6b-9a397d6fbef1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6701aaa2-4f7a-457c-8fd2-0647a0bd3512", "87ea2a66-a8ec-4d66-bede-18f636a31583" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84629739-d9d3-41f2-9175-80fa86c68dd3", "18341a46-59cc-4a57-a0cf-b2a38cb0fd8e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "562c5d28-4bb0-4f11-ac49-61aada72cd42", "ac4c3daf-0b06-4aa2-a771-5b30b588b32d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "297b44b1-1b8e-416a-9c62-8375cdf7b0b5", "c675b550-03cd-4369-903b-35e0da9d06c2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "95df6ff4-25ab-487e-b056-a0521133eb1c", "b85b7858-fa75-4237-ba4f-c8188ea035c2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4b3f40fa-5aba-4e43-b404-19937eda299c", "8e9bf403-8514-4dd7-8304-18dda6aab048" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5fbb7cf1-204a-42d3-b2e0-250dd5e5a937", "b44a04d0-64b9-4edc-bd90-02194ed0f6b0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f89279e-77e1-4b1e-9064-2f387102e328", "42348360-b046-412e-8507-4a146033143b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "186a90c2-8c56-40f9-bbc5-a2c9d448899b", "75997ffa-538e-4f65-9bbf-9f1a6132e7ac" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b63f8874-bf67-4305-9376-79f47f15651f", "68b94b1b-e27f-4098-8b53-1d011f6c490f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "427cfd7c-0bf1-4fcf-a92b-79a93859ffea", "9297fa06-b271-47e5-b9b4-909fc4b99b1c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1e34d8a-d27f-4103-8ef7-be6776df490b", "154b96ba-646f-49b9-b7cc-7096f89c56da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "022f52dc-e26b-4336-8f6a-9c8560757bf1", "8e9ea6c7-a314-4edd-8e3c-3c75d92bdc24" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b0aa359-2340-4f86-b11b-d041ec13e493", "ff35b8ab-3f98-41c4-a568-d630b4197086" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6029212d-198d-44e2-8863-68a1a41ce9a5", "ba6866f4-f323-46c6-86ce-7763454458ea" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "547c07e3-94f5-47c9-abb4-1f795fd0b853", "0d782f9b-6db0-45b0-95e4-cca1c523fdb6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8269e4c6-7b65-4c2a-8d49-954725d8a870", "a80d9dfd-b444-4e21-96d0-69a9d4cfca7e" });
        }
    }
}
