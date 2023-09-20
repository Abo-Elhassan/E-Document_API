using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addrequestRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DefinedRequest",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DepartmentId", "ModifiedAt", "ModifiedBy", "RequestName", "ReviewersNumber", "RouteName" },
                values: new object[] { 1L, null, null, 16L, null, null, "PO", 1, "/Procurement/PO/" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d161f5f-5381-4f1d-9065-21b208a015ed", "30f47a6d-5251-468b-aeb2-d5cd0a0ac9c0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57f2fc44-ea87-4517-b62e-239917241e08", "15826936-4f3e-4523-ba0a-b2e79cfa24cb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2013ce3f-2cd3-4006-9b9d-a35de633bdee", "12932fdf-926e-4ba0-8316-6e1cd3d6f0a5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b85a756d-baf8-4a39-bf9a-59446e3d1130", "93af5de1-2d94-4cba-a487-ea42768c205a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d2705fd0-9943-4c8b-9b3e-b1748840e975", "fcbbe311-a454-4b07-8d7d-ce4a0e5d9982" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12c9b7c7-9a22-4cc6-9b28-ce650597c481", "6d8e1283-e10b-4e56-923e-53d493346da2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "96249025-f5bd-4bbf-8550-e7d1b226a4bb", "e8a324af-379a-43b1-8154-8a6a05c2905b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29a7c769-8d7a-407d-a1f8-c552200da8aa", "0a5d64ca-d905-410a-ba4a-cd2e2df3e5cd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ffe4ae33-b78a-476e-b3b7-edcf342c3eef", "64f9a053-a2f0-43a3-9016-104a0b4fa70d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "787345b1-7fb6-4ecc-a375-64e61962d149", "bc0ee811-d200-4613-bfad-a0a79b9325e9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "590b8722-90c0-4c65-9277-daf0fce32346", "7cc82dfc-c7b8-4d94-9f2b-02dca04262e7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15fa710e-f501-4057-9f62-02455d87f5f4", "c8efe19c-bf2c-48a0-9235-554c843da46f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3beb392-7ca9-4d3d-9ec7-64fe608cc278", "a0404f78-6909-4720-84f1-60a52b07f057" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec3bdb22-5403-4140-8b30-b1b583501a37", "4c142cc8-5cc5-449e-8e42-3f7c7b3bb221" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "591a4326-8f4c-40d0-98c6-a97c96e710e0", "b2cd6858-5115-490d-aac3-1fa1a6451016" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8744a929-6376-4f52-85e6-7d06822c20d6", "d303b35e-794f-4263-8d65-781435e3c1cf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e625caad-4a94-4b96-9e0b-621e7573158e", "52f36565-6077-4c73-ba59-ae67ec968272" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62d63599-2d41-4243-8c88-5a23301bbda9", "be6f9b8c-ca57-4e2f-9af2-ed1e2a8dea35" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23b07e04-ae3f-40d7-b5eb-9cb7d8928cb4", "4eb96cac-7224-4144-9595-2a9c5545d146" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87650691-1d9a-435f-b81d-eef8ab4846b4", "80f38429-9e5c-404f-b5ec-79833d75d3f1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "072174b8-9ea0-4a41-a6d0-50b27b2ba9da", "b8e25148-f2a8-4f81-ae7b-dc3e21596803" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "db4bb063-89a7-4534-a430-366bfb54c8e9", "d7de315e-260d-4b53-96f4-c6fbe90f1a2a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a241eb1f-e2f8-4b8a-abea-0c2c79c5a9cd", "0bfecbc9-ad55-471a-b453-73124e6cfbd0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd4cd44f-f368-49a0-ae58-58a0d636aeed", "e62e1c33-7c31-423a-8ebb-514a1c4df1ff" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "455297a6-c3ba-4bb6-a09e-b22eab2912f3", "08182379-f8b4-4f87-82d3-323460abcd5e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "679fbb7d-3157-4c58-a46c-ece8c9b035b4", "de043a40-b8ea-44b0-b397-0be8db9f54ce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "817ac000-288d-49f9-a230-f0973adebcc0", "bc4cd385-f1cd-4e21-9d0c-ef521dfb6d8f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9da58ad1-dd7c-4647-9d1e-f84f93addc41", "386728d6-c602-496c-9ae3-d0d5987e7cce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aa650205-bb07-4e68-9538-5694150e88e5", "365a0b24-f482-4291-a703-7dc2f0e87831" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8be66984-c960-48f4-aa7c-cb59cd46b9ef", "cb12cd87-288b-48f8-8c5c-c4f5ff13a63b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0e0e159-d26f-445b-b341-f9581120a958", "d755d772-3c2c-4cd1-8765-88f61f148e72" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06b3d438-f1c5-4ef7-b378-690a4c2247b1", "9e2fec07-e079-4290-b514-6f30956ca41a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bc28c9c-fdd7-4a6b-8479-e7907687a10f", "c7ee29c2-1a2f-43eb-ad4a-72599d02740f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "525a8bf3-0e6d-40fc-aa0b-19ad2e0b78f8", "52bf4cbb-5044-4087-b26b-f8c7795da341" });

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
                columns: new[] { "DefinedRequestId", "RoleId", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy", "Permission" },
                values: new object[,]
                {
                    { 1L, "121c1742-99e7-4b61-ab2f-f748876e2975", null, null, null, null, "Review" },
                    { 1L, "6826ac7e-b4ae-47ff-8bf6-cc904db43d84", null, null, null, null, "Request" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DefinedRequestReviewer",
                keyColumns: new[] { "AssignedReviewerId", "DefinedRequestId" },
                keyValues: new object[] { "51124", 1L });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "121c1742-99e7-4b61-ab2f-f748876e2975" });

            migrationBuilder.DeleteData(
                table: "DefinedRequestRole",
                keyColumns: new[] { "DefinedRequestId", "RoleId" },
                keyValues: new object[] { 1L, "6826ac7e-b4ae-47ff-8bf6-cc904db43d84" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "121c1742-99e7-4b61-ab2f-f748876e2975", "51124" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6826ac7e-b4ae-47ff-8bf6-cc904db43d84", "51188" });

            migrationBuilder.DeleteData(
                table: "DefinedRequest",
                keyColumn: "Id",
                keyValue: 1L);

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
    }
}
