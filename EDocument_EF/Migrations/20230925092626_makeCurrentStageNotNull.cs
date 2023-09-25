using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeCurrentStageNotNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CurrentStage",
                table: "Request",
                type: "int",
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 1);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0d7e37f-ae99-441f-9d75-e98280c1cb6a", "929a3428-8682-4180-a57e-aa5d46ed8925" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f377f760-6463-4658-b4f8-7140f7d357d6", "d97a62e4-0773-4a1e-93c9-e93ab72a68f2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df4f4c36-558e-4749-b03c-7ff8667fff34", "31f8dfe5-d5aa-40fa-9683-99611af77c66" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6f3d61f-384c-48af-b570-9e3db5db83da", "471edf57-1d3f-4f95-bbcb-df69c15c95ac" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac7c9a81-89c6-46f7-8bb0-8fcdd8f7628c", "8455dc9a-5588-42e8-91cc-711b0572815d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6b8d11d4-84f6-491e-ab28-11253dd1df5a", "633aac24-9c22-4c6e-b9a8-edc8192bcd3d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2f9074f-b1b7-4b43-aea9-6325280e4aed", "e62416a7-5b4a-4659-a490-21f9f83c8628" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d90647c3-7731-4636-b9a3-7f15a54cdabd", "72e9de37-5348-40a1-beda-aac64df63d5a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7eb7505a-77ef-40f7-8a1f-2ef991337258", "8c6d2535-4dc5-4e42-a9db-fee1d0791def" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f84e152-5a46-466c-94ed-188d95f7a5e7", "a2693346-6f05-4679-9c1b-44b73b099b11" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "954a6d6f-9419-41fd-bc3b-8a0e261bebc6", "94855145-4a98-4970-bb4a-8c3b54871d90" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "71521dff-f482-449e-be6f-ca8f87e71295", "5df1c305-8991-4d8e-9082-246d749c1462" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3add5bf0-bd9a-474e-8438-793758daf7d7", "239af2dd-0f40-4595-adce-b10e8f6329a6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ee79919-662d-43a5-b33e-a1e24a143b1c", "d419d088-2f59-441c-be4a-fdee198fcdbb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "403bca7d-ee9d-42b8-9e40-b9a8a2983b9a", "f90f969c-d9c2-412d-993e-5f3d0c526508" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3e94bd3d-af99-4cad-bd5c-b7dd218b9473", "fe29c9f5-0421-4bf9-8773-75d4605d1947" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87453c7d-c914-422b-8d3a-2641e85c3e47", "f6f3dbe9-fc85-495f-b659-e6a1361d72ce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "247d73fa-4a1a-436b-b402-b5f472e06f97", "102b6d36-2822-4ebf-abc1-5823441981eb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51d1a1c7-9d9f-4919-8b37-90fb3dd99194", "5cb87a94-ab71-459f-b92b-24bc8917a89e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "261e2675-6a07-4a71-9727-fd7e7d16f2ec", "4f1607b0-35ff-43f7-81e6-9bee5e60d290" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a102b5e-bd31-4566-bfbe-8635a52d2dc5", "b164db8c-b967-4f61-8476-252d75aec692" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a5a6a414-fca6-4c9c-8225-020f8ccc7a98", "18dc249d-e5af-4955-bfd4-4ccd67414197" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7e8bcfa-f3a6-40c1-8dbb-d4de66f93432", "202b5d2f-42ed-42a9-ba80-991eeb9e662c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55b2b6fd-5844-4b45-807b-b41b2e982fde", "7e01698b-61b6-4b0e-9d84-3ac45335fbef" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12e3d42e-3fad-4e12-8fc5-a09954097a81", "50c64d7e-9378-4352-a3ec-28fb794e7afe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb4126a1-6bb5-47bc-9a5c-99d5de40789c", "81b02527-a92c-46f6-b7ba-88aee0cdcb36" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d064d839-d47b-495b-96be-825f5cb4ab3c", "2f0fd477-8f30-4443-89a5-a6e17698a342" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61242e5e-c4ad-4887-8a50-d54b23aa0ac0", "efa226a3-c690-4434-981f-b2b8afd8d76f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "469828b7-d86a-4269-aca2-4c42f6510c1f", "7ddc7bed-4403-416b-9666-dd0a19cc0e54" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6de54bba-c88e-417d-94d1-0184487a0a7a", "eea3627c-9e12-4cee-a2d1-4deda18e51ee" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e37199b8-65a5-4c42-ab44-fd0cdccb6aec", "e41d4ce4-ce9e-4a6f-ae0c-44495599e1e0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b429f014-1e45-4625-9666-e993b5796dbb", "5719f29a-a9f2-4fc4-9dd0-21d616b1368a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e41f767-3ecc-46c3-a63d-0a4ba4fbc5c3", "c8835324-c322-4be9-a762-696ba77795fd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c44f2a7c-82ba-46b9-92ee-b8509d1c3cb1", "9cb04793-6ee0-409b-b183-78ebf31c49c5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CurrentStage",
                table: "Request",
                type: "int",
                nullable: true,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 1);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "415ac13c-d780-4318-9424-6a16870ca3e1", "5404eefc-5367-49da-ad0a-203315db9bb4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1c601a1-b3b0-4632-8173-fddc49bfb5eb", "c05a0ebd-19f1-4a91-8553-b6028c01f163" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f0de81e4-d8b6-4d52-baf1-f016a36ce605", "8546f56b-ae0a-4ac1-9056-ab58d2979429" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "90452077-01f0-4697-95f0-ab7fedbc2e6e", "3949587e-1c45-447b-9e8d-c2043c262650" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4a964622-fdc1-4ea9-8c2f-d140c1d7d483", "f6cf3139-f280-4d83-990d-0d7be86c2a16" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab2d8ae7-4c66-48bc-acdb-1fd715ab3a0c", "e8b3ecee-aa4d-408e-ad7f-a5548c26b819" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bcdf7273-75ae-43cd-a855-64f7ffbdf18c", "a6366214-e85d-457f-9f80-ed41d3b095d5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6eb447e8-9bb9-4fa9-be85-096ee32abd5b", "185b397f-f92f-4ae7-b487-4726a0fda7a9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36a26bc9-287c-46ca-8cbd-a39f8073fda9", "7dd2ccfd-9532-4003-af72-2e5c5f589492" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9c48bab-0c21-404d-a138-beb1c5ba0e95", "a0710ab2-852c-4e5f-854a-1ddb7802d7d3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46b8e3e0-160f-4cc0-b45f-d1c9f7fcac96", "6ae05a40-a3de-49ea-bc59-7f0d60d35c08" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc2a8676-1ca9-49c0-a616-112b1f825f36", "3ec1f207-3b6e-4d55-a08a-dae34b67fd77" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fbe287f-ac60-4104-b3df-2d0bca7c764b", "48ae533a-a742-4958-8077-f0a6bbc30005" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99b551fb-4ddb-407a-95d4-42f0273d39d0", "b5dc4dc1-7acc-4e23-898b-62e4f3eae606" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8d6eb65-99c3-4b31-9eb9-160bb1850ed7", "0f3178d5-ae07-42a3-99dd-c34f62308585" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "175da42e-5bd5-4c93-9528-1d73eb90a0f0", "43bb94e1-adb5-4389-91de-2c50575e9c1b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "592ff426-a7c8-4d99-a2a5-5e7a83ca9b56", "cbc9ae0c-ac33-43f1-95a5-addbc11d3c4e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0109b40-9c06-4623-a6f4-02730052676e", "a0eb0784-cacf-4144-90f7-2237a14fba66" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb1fbb54-83b3-4d01-a58b-c91d8d7054f1", "8b069a44-7dcc-40f3-ab17-5ad91b03565f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57b3db4e-8bf6-4ef0-91aa-ebbd0a4e0cf5", "c8de2fe9-ee27-40d3-b38f-e9e57750ac5e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ce201f5-c8e8-4f7b-aaa7-36ef12be5ba7", "d0a67099-be25-4eae-8d35-b4aa5e1f5104" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d1afba8-667e-4212-a4aa-8a58a6114a6d", "1e0e6c53-09ab-4be4-b6cc-ef57a1a709b8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "028a419c-3585-43c1-a313-1dfa83dbc84e", "c5e086c4-6f9c-4b74-9fbb-fef1e3007c19" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d3fc84a-5411-4b92-ab79-bdf83a44eeb2", "6ac3640b-0ae1-49b5-adcf-8edc08876c6d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2efbf579-e5d2-4bee-8ea5-6e8436f2f22b", "9b9f1529-be24-44d1-ab7f-937399d41152" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df187abd-f2d1-40c3-9ef5-38f2f53070b5", "e67da7f6-1a89-4edb-a33f-b3f596c03bb6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5a67d6c-8d03-4eb2-81ff-9f4d50aeb77b", "929d403f-5441-4581-b034-c330d8687ba7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5c25325-c6fa-48e6-b4f1-299e80a5ad81", "38918190-ed70-4e33-9ffd-e4456753e548" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "933dff02-f832-4a02-8a56-43fb171927fc", "160b0689-4e04-4f4c-b5e8-62ebf7bd78da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c94ffde3-3092-45b1-85ed-45bb159a1885", "f157204d-f5b1-439e-b507-2b99604ad3ee" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5db676f4-205c-4b71-a8d3-8e0b015e0e26", "6c2be267-3790-4421-81a6-581935c601a9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2d41985-1b89-4885-baba-650073881a0c", "592c725d-4b7a-4c33-b79d-e3f51e1b0ced" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "646101af-2670-43da-9e09-d30ef0f87c22", "fb8b7cae-235c-4d80-bf01-d2932dbb40b9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "706a302b-f8ca-40d6-add9-e1011f8c8a7b", "1a18a2a4-e3da-4bfd-9cde-90b64a59d36c" });
        }
    }
}
