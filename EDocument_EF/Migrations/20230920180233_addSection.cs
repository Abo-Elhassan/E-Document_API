using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addSection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Section",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DepartmentId", "HeadId", "ModifiedAt", "ModifiedBy", "SectionName" },
                values: new object[,]
                {
                    { 1L, null, null, 1L, null, null, null, "Administration" },
                    { 2L, null, null, 2L, null, null, null, "Freight Forwarding" },
                    { 3L, null, null, 3L, null, null, null, "Business Transformation" },
                    { 4L, null, null, 4L, "51509", null, null, "Commercial / Containers" },
                    { 5L, null, null, 4L, "51583", null, null, "Commercial Bulk / GC" },
                    { 6L, null, null, 5L, null, null, null, "Communications" },
                    { 7L, null, null, 6L, null, null, null, "Customer Service" },
                    { 8L, null, null, 7L, null, null, null, "Executive Management" },
                    { 9L, null, null, 8L, null, null, null, "Finance" },
                    { 10L, null, null, 9L, null, null, null, "Governmental Relation" },
                    { 11L, null, null, 10L, "90015", null, null, "Samsung SDS project" },
                    { 12L, null, null, 11L, "90008", null, null, "DUBUY- Sales" },
                    { 13L, null, null, 12L, null, null, null, "IT" },
                    { 14L, null, null, 13L, "51449", null, null, "OPS-Cargo & Bulk" },
                    { 15L, null, null, 13L, "50844", null, null, "OPS- DRI" },
                    { 16L, null, null, 14L, "50670", null, null, "OPS-Containers" },
                    { 17L, null, null, 14L, "50128", null, null, "OPS-CFS" },
                    { 18L, null, null, 15L, null, null, null, "People" },
                    { 19L, null, null, 16L, null, null, null, "Procurement" },
                    { 20L, null, null, 17L, null, null, null, "Projects" },
                    { 21L, null, null, 18L, "51520", null, null, "Safety" },
                    { 22L, null, null, 18L, null, null, null, "Clinic" },
                    { 23L, null, null, 19L, null, null, null, "Security" },
                    { 24L, null, null, 20L, null, null, null, "Store" },
                    { 25L, null, null, 21L, "51090", null, null, "TEC-Crane" },
                    { 26L, null, null, 21L, "51529", null, null, "Projects" },
                    { 27L, null, null, 21L, "50562", null, null, "TEC-Planning" },
                    { 28L, null, null, 21L, "51126", null, null, "TEC-Workshop" }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d1abc70-8a6c-4f26-9c4c-126685f65d86", "ff3bb853-45ed-4d65-8d29-b380033e47a9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7abe63f9-6731-4ab7-b881-4dff737d8d0e", "334f295b-1dd5-497c-9d63-6872d5528bf0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8de2cfa5-6c68-44a9-a866-41f56acaf2f8", "91e7c47f-60fd-46cb-96fa-1c15cffb457d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3b4d5c8-fc41-4569-874b-3b9f37415499", "d411144a-3277-42e8-a2cd-06a25b2ff7fd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b478f8a7-68a9-4b06-8ecb-58d886df53c2", "9faf75a0-c5c9-46e8-8b9e-c7ea13a2dd0b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "35373efe-73a4-4f20-a46e-8e2c3a946803", "16d9e21a-1b63-4351-8fe0-05cbc8c4aad3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b9f20cd-ba4c-4b09-b3f6-0850d0c81a46", "7a6e55a6-e326-4fb4-a500-380fa7bbc6c8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d46544a0-8a35-4411-9e4c-28c7338cdfaa", "abb21ecd-f7f5-40c5-ad73-78eb2a34e248" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff2752eb-1e87-45ac-988a-2c4cee312729", "d5fc0c2b-22eb-4d8c-b191-8da934adb3ec" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "705daa73-840e-4e39-a726-1630a2abeca4", "3ee2709e-8d8a-493c-9583-513a69b9ff65" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad44cf85-dfbd-44bc-a108-c7b13808b050", "03c7f3a0-cabf-4481-94cd-5fceb2422fcd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43d385ea-3b7f-4caf-a4b7-eb2f41bb900e", "10b8bda3-6331-4219-9f0c-5b6562d47a44" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "202c25ed-3005-4fc7-8db6-83e23a77ee8a", "d15de935-ffd0-459a-a78c-b0bdf31cd9bd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2c4a8a01-cdfb-412a-9d78-b32955da3feb", "321b5e1f-998c-44a3-9213-b12969a90d8e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45d11ce1-fc6a-41bc-8a2d-8e231423f219", "be166ee0-9751-44e2-af66-3c23227bac37" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80d546a6-b552-43b1-aa46-6bbbfac4f314", "349c1b93-6e5d-47b3-a921-cb37da275070" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "04bd8642-24d8-40cb-9918-be932bc36e23", "1ef9f365-ca5d-413c-b787-80483f8bcf6d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca1a29f8-c2a3-43b3-97c4-d146328b85d1", "54573ef9-7668-41db-8b9f-7140b7a172cd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c661f70b-54fe-475c-9704-f98b61badc67", "c1ff6d37-48ec-435e-b0e3-9d73924a9e11" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08b1ce91-51be-4309-9509-efd24ec97e48", "bb576675-4234-455d-92a0-39adede8c446" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4376c123-b93c-452b-aeb9-93899fcf2dd7", "4c70a0e9-205e-42ed-b31e-640d528eb2ee" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3140f395-9654-44fd-95df-9d757991ee6e", "ab3cf619-f8ab-41f6-997f-8215040a987d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93b570ad-299f-42b6-866c-a3553d5c3460", "b09725ea-4e5f-4650-ac60-dee514425974" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "16fd54c8-6263-4e86-bd1b-cc461f7f64cf", "0ba3dd98-ca2e-4058-9408-77f60694c61b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1acb3599-ca68-4092-b1d8-b898c7427f0a", "73cf51e6-b5e8-4b73-8b16-34a63d51e35b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1623bf2-e87d-4aa2-8f54-9a58f20407a7", "291845e0-17dc-4091-8b10-a465ec860a85" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4de04f20-dfd6-46a5-9d6a-1c084f64a922", "af5bcecc-6ec6-4a37-bdb8-38d5b367c981" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e47b95e9-8bab-4451-8670-0438129b72d1", "a04b0922-a866-402c-85bd-cbd5d15e870a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39550e08-77ed-4c2f-9b3b-ff4e3e1f90d3", "3295ee9a-d024-4755-8725-8ec4d0d21785" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "777092e3-93b7-44c5-8b37-8635dfd0cc00", "b8966e5b-7c32-4c50-be7d-62eb0d85ad99" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab908554-1f8b-455e-accb-fbef15124224", "edd676cb-c2df-481f-a982-f03d45e45d58" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "740ef736-4b93-415b-a6d6-71c6ef1e7c5a", "cdc55a2c-d686-4be8-bf85-8011793fe4ba" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "062c6c5a-9c76-4414-b3db-5eb20ad97479", "f5967a57-654c-4917-9d1d-5885b0b2bb87" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "32ccb475-37f2-443d-a1fe-14d2bcf7b257", "1582434c-77a0-41cd-8898-db6a8f679dcf" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Section",
                keyColumn: "Id",
                keyValue: 28L);

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
    }
}
