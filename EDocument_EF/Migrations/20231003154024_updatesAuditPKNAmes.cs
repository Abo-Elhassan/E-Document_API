using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class updatesAuditPKNAmes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditVoucherRequest",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditVehicleRequest",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditUser",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditTravelDeskRequest",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditSection",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditRole",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditRequestReviewer",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditRequestApplicationRole",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditRequest",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditDomainAccountRequest",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditDepartment",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditDefinedRequestRole",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditDefinedRequestReviewer",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditDefinedRequest",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditDefinedApplicationRole",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditDefinedApplication",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditAttachment",
                newName: "AuditId");

            migrationBuilder.RenameColumn(
                name: "Key",
                schema: "audit",
                table: "AuditApplicationUserRequest",
                newName: "AuditId");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42d855f1-897c-4d41-b59d-21a872f27d28", "2a797643-2a89-4e1b-935a-9819cae398b3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0fa2ec3-0fcd-41a9-9347-8a816428497b", "9494798f-024e-4138-9c7e-f84fe8a58231" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51005723-5be7-4673-9a3f-fca2496eab4f", "56bd2ae7-44cd-4fbe-9dd4-3689d9911da6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74aefc04-98f5-48b8-a628-24d766ac1a3a", "26b090f4-e539-4727-b580-39cf0d0bc1f8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fab383d-829c-475d-8405-40a3baffdc2c", "acedefb7-6914-4336-95b3-ccb971e87f2b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8681b71c-b5c0-4cff-a809-02db792be393", "a963ef91-af8a-4f46-8dea-6cb4dbae4213" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b69c8f0f-7544-4c1f-afe8-de2cf23fbb08", "36224828-0202-47e8-b0e7-33ba3fe31b07" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6114f1f-b360-4cdf-881f-745586ca6686", "377b0114-04c0-4828-b09f-b25d398481a0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26038e6c-68d7-40b9-b58f-7adce72b29c6", "e4b3000d-c10c-4e93-bfc0-aa26b0a563ef" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1a56051-e684-4ff3-8de9-29866a119c14", "83f52db6-19fa-443e-b820-a5244bdb3f7a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b8a2055-9224-456d-9aa1-fbcc59d0d48b", "dc8beb58-437c-4bdb-bbe3-d261e0cf8ee1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a7fc4acd-41b5-4b5a-b227-69e289e42966", "4433e65b-adfe-41f5-8278-5df164a591a6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "805977e2-f921-4cd4-9b31-1d9839755f04", "e2ca841b-5e65-4b9f-b03a-743f838938c0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99b4a48d-1c61-4c97-8966-401772cd8562", "bb4252e0-3c22-479a-9c1a-4cbdfa83c836" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "30c3a291-df51-411f-a280-0d3dd6c3c5f1", "4b4ae778-b7af-4f12-97a7-e02a3dbfd2f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d0a5e2e-4abb-401c-a6a1-1217e36ee2d1", "74220e20-f5b5-4f5d-b0ae-4e805541f301" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1c11ae5-27a2-472a-8a3a-65d9d6025bfb", "0c921f6b-8e96-48f8-9e74-3c6fdfb02e9f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39aefdae-5af0-4046-a668-78608ec59c0c", "4c67b70f-1e67-4381-a709-14158337d890" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43e220ee-23e5-4477-a7c8-178026e7ce66", "733b0eb1-1f9d-40a3-9957-308b121ff483" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26db4861-679e-484a-9e9b-9548c6870a70", "3cbdf685-0369-4b51-9edc-abbf481c13fb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "641aaffa-ca67-4897-ab6a-6ffe7c8aa895", "cb78a20b-556c-4e93-a933-23d37ef36373" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d36ea01f-485e-4274-8ee0-10ce6a830633", "ec69f875-b4c1-490e-ab88-b6300e10220f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "000c0ebd-8764-4fd6-9595-088bcebfd82a", "c4df83e9-3b86-4af6-8b02-e65298306ff6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43f3030e-7719-432b-8b0a-c7be3491c536", "ba38bda3-e797-4af6-8993-84ead8d38143" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe638755-1c2a-4722-89ad-21984fd3e19d", "45fa75fe-4d11-45c5-8edc-6dc785c512e2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5554e94b-1abb-49b1-beda-0443ee01b404", "414211ad-cf60-4503-b3c0-cdbfa45cc305" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "73e751d0-f050-4ba9-baaa-6b4f6725e4c4", "943b1ece-c867-43fd-82f8-e250f4c7d1c4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2caf6003-8b8b-46e2-9504-dfc49cc613f2", "f7500f04-3569-46b8-a482-25f82823d024" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc9eb3ef-0fb6-46b1-bf47-43ce05545145", "e7b3284a-9a0e-4ccb-a776-777e54bc4ca5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c042bbbf-c538-4747-9a6b-5bafa69a038a", "2d4aaea7-2337-449a-bd3f-536e82b77cff" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9a326d90-447a-4a53-a94e-a3b5cfff7c55", "e8734bf6-f7c2-4383-ba95-a13c515e8035" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "08080cfa-0a49-49d1-81f8-0b998be46a47", "a1e8ed85-7139-481c-8482-a18db5692d54" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4cc62ce6-217e-4482-a7cd-3793cb686e4d", "912c2e0d-63f4-494b-8e0e-80328d1ffd2e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fdc6bcb1-5285-4dcd-910a-f974ee66104a", "5a6c2815-f245-43d9-94fd-c538aef3e19b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditVoucherRequest",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditVehicleRequest",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditUser",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditTravelDeskRequest",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditSection",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditRole",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditRequestReviewer",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditRequestApplicationRole",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditRequest",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditDomainAccountRequest",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditDepartment",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditDefinedRequestRole",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditDefinedRequestReviewer",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditDefinedRequest",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditDefinedApplicationRole",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditDefinedApplication",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditAttachment",
                newName: "Key");

            migrationBuilder.RenameColumn(
                name: "AuditId",
                schema: "audit",
                table: "AuditApplicationUserRequest",
                newName: "Key");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef73efd2-ade3-4d82-bc15-9fe57154f5cb", "2a64f915-d62b-41c9-8605-56df746fa820" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a0391a00-0dfc-499b-a13d-f8fc98c40715", "62d740b8-56ad-481b-b777-954a9a5fd50b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17e7de64-0560-49c3-91a8-46dc4c964214", "3911a78d-5343-43e5-9109-6ac8174031e8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "045e4eda-be08-4fcc-a8f8-98ec9cd23f18", "c984038b-4740-4a3b-9709-5d312b4fd183" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "305e7cc9-47a2-4df1-872a-efeab74b865c", "fc10c771-b860-4f88-b65c-81c61555774f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee324e2a-5ec1-4e98-9d2c-865ef56c2464", "613587d6-001c-4cd6-af1b-1b48203c4913" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a07e6269-c826-4825-8fde-1fbb44bcbee6", "d4e19d4c-d9ff-4ff7-9173-8119272c3193" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee7b89a2-8ebf-4f67-8c84-baf6791d5b7f", "6616bad2-5bb2-4bb3-8852-b6ee95844e46" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "acb580ff-2a71-4fc7-8854-a4a31cdd4666", "9931adec-066d-4c0c-b06c-2879b61514b5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "01063d58-009c-4a87-94d4-15aca4cccb3a", "33b5c02b-f7bc-48ed-920b-fc4803a28632" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee5e81bf-f95e-478f-8271-67992cd23855", "a93da755-55b3-4f2a-81f2-96ffe6c83c62" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "77d11f73-a2ff-4f1c-814a-9d4e07ce6ffc", "a60b1831-72fb-41ef-94b6-3b8d3495efd6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7e91ad3-149e-4d53-915f-f8b6cc18e87c", "de6f5621-e4ca-4b77-bd1f-36a49915ac5f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "117af1ed-a1ef-4557-b3aa-52152111b277", "655f743a-4caa-4de0-ad6a-a8cf94da542c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9cf1f2e4-e227-42a7-8de5-014ceeb0735f", "6a011269-e18d-4308-a4e4-e882203801a2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2aef1a60-d40b-4069-bb11-1b66f61449e4", "33019e16-44d2-4600-b39b-af1050b6ee15" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b53d6a16-be18-4ca3-a65a-7ace284c52b4", "d32d13ef-6ae1-4861-9bdd-a02280010d70" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bb2a3afd-7f46-4b38-a4ec-33e209ef1da1", "1588ac72-c94e-4a96-ac71-795dfb64e467" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e76327fb-776e-40c0-9d43-8692895d21e0", "b1a7d09b-a111-49ea-9d0b-f1e6dc7bf052" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f805adad-e3ba-4812-bb9e-b1993a072b33", "f0ad6a33-891f-4482-837f-02c3cb3c5985" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80b038a6-aae4-4f88-a805-fff1b8bc79db", "d217392c-0507-4f87-a3df-73d03473eb73" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67cf08cf-618f-48d3-86df-96d6c14fa7fb", "ec349d39-b959-4cd2-a1b8-aa9c499bccae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83dd9dcf-df7f-4cb6-9fa1-f3c19d7c7835", "d7209a83-6656-4544-93d2-1d0f17f89cde" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d34a534c-5887-4543-a5b0-5383e21e7271", "7c234c0b-f265-470e-80a5-1f07ac226a0d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6bfbddba-905b-4776-b842-953e34084d53", "a570634f-65ae-4bb2-a083-24ac87f50e01" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "071f4489-99b8-4654-90bf-282e5ff4c3f9", "0335dadc-ff25-4511-8a0b-e6965d42bbae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ac641c9-5c0e-42ba-bb34-9709f4886d39", "5d5ddf9b-bac4-4d20-9ff0-ae883b2cba00" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6b4dcd58-b0f7-43cf-869e-0a72f895947e", "d3a6d714-f401-4f01-aaa8-53d1ea56986f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b8b94ff-84b7-4fff-8b59-dc145db12054", "0689e7af-39fc-4f33-9211-a3103dcd1d98" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6578419f-7a90-4e79-8087-12350404a7b5", "a9b3ccad-959d-45f6-bce1-772655e6166e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e620f07-2e2a-41f3-b69d-cd1ae1ce6b13", "1c2ff3ac-b667-4eee-80f1-98dd6c18bf1d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f40dc25-bce9-4236-9cbb-a5dce5272db2", "156d1e07-faf4-446e-b982-fd482c6c7947" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ed23734-8cc6-423e-b196-7b3f45a4e0d3", "9a49a499-7bc8-4376-a435-acfb6facb072" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7970c5fd-6429-4794-b76b-fb6fb34e91e1", "4638a3b4-5b7e-4694-9f69-2211a0222bdc" });
        }
    }
}
