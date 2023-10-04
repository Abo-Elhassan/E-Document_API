using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addCreditNote_Amount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Amount",
                table: "RefundRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreditNote",
                table: "RefundRequest",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f1a5198-15b4-432e-a7df-398a6315c700", "ccae08fb-aa6b-4006-9164-1d62d68b8f2d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9969691-2e5f-4728-82fa-1902a6766ff1", "936b260a-dfc5-46eb-8a0f-9744e41253ab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5893211f-ad69-4233-a2bf-ef6be55d6ccc", "dfed7ec4-0500-4473-9442-f84658218077" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecfced50-78bf-4711-b761-ce6890345701", "ddf84de4-6261-4b8b-ab77-dccef1e97341" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02488f6f-05d4-45f1-bcaf-37be548fefce", "25207812-f939-46b2-94f4-f39775094d56" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8841c42d-9f59-4f08-9af6-6bc9776aacdd", "f29d505b-2c67-47be-b02b-8074ba2b0c5a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ea9547b-57ba-4d00-b95a-d375ff428c38", "2400160b-7cac-46ee-b269-02b0fd05aa14" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c25e6bd7-89bb-43db-9c9d-485428c5bfaa", "7b3d462c-782f-44ae-a11e-ad493f9a1601" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "075954d8-1d49-4a46-a142-399935f4cb4d", "0b29c08b-b96b-4c27-aa3d-fdcf05cac9f2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1bc0171-7c3d-4497-80b2-934fb2add0f7", "26845b98-876c-4458-ac39-511a6e7658b1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f61d8cb-6697-4e81-82a3-f44dfd174e60", "0c08e244-209e-4b6c-adc9-8e7f8199e0f3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92a24322-b40d-4f5e-a8c3-7ed732a800c0", "90ea25e1-e63a-4a59-8f6a-88ff8f38ab64" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9709419e-c4a6-4403-9aa2-d3b00ae6d7fc", "9903bd8f-cd5a-4b01-8d05-4c2c0f0d4575" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a8098eca-5dc5-4851-9ce6-36bdc3bcb089", "f6d81fff-bc70-4297-95f2-5336bc387503" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63f9ac26-47d2-4b7d-94e2-2fda942778f7", "ac815506-1037-4ec3-8d5e-7f899f3cf0b2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b09a6d5-3d7e-4451-bc08-be943d25b2b6", "ecf10d86-fa79-472a-92fc-df7d9e084bbf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42fb68ea-c126-46d4-963c-64b5aa18d6d0", "36198217-4f73-4d7b-bd1a-e570564da0bf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ab42740-64fd-4a06-a051-21e1247081ab", "76025ec0-851a-4da6-8bb2-549d11f7a8a9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67558471-51d7-41d1-b2ae-4cc226471a0c", "9cd4208a-edc5-467a-a130-2e7b7093a1b4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8535588-d832-4459-a21c-c7c532fd8af3", "04f50e9b-8369-4b17-80a2-0d8db56ec90d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f00fe3c-ce60-4f97-b2d7-7187d2fcaba0", "7b834605-7925-4f71-87a7-b6eaa0bffee8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f25355d-8ca1-4e6e-8039-e6b15f440c90", "c0687894-04ad-4b2b-af15-19de8d672e41" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70e1faed-d5d4-4912-9ce1-bf63e244f338", "9a3c58cb-1957-412b-a3bf-e1a5bbd174b7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "65975ad3-b705-490c-be49-5b24b6da29f5", "4c772a39-4222-451a-98a7-f090dd0e2b93" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "691b7cb7-cc80-4894-b38e-abe84c4ff954", "f0f5828c-68e6-4b8b-829d-5e4bb28bf135" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2e1629a-4511-44e8-8948-be7f4d4c1d2a", "d1b1c5cd-c328-4a4b-8e7e-6b4305434334" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac5e348d-d9f9-48db-950f-4912c32aeb6b", "d621e171-fee4-4395-8e33-7fd4df12169c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f073fefe-2960-45d2-a5cf-86df0f4fd4fe", "b4123d9b-07dd-4c17-8119-5fad6218ffeb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20389da3-0f0a-4db5-b5fe-9a64cdf72011", "983ce519-2f1e-4739-b468-a4a9e40958da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a00585ba-8d10-48d6-bb3c-81d942735f48", "640aa347-dfdb-4a6d-b020-5bb86fb22446" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d71c3d3-1297-4cfe-9dcc-d67fe0953f1b", "f7b646c0-29e7-4573-be22-23f2304ee6cc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0a46d9f3-acc6-49a9-b83a-3085bbff64bf", "06c0e67a-de82-4854-ac84-a7856e7795be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e8084d68-7e77-4555-aeec-717acfbd5f5c", "bc0c362d-0b1b-4baa-9e27-15ab490b8d88" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3f85627-f449-43d8-af88-144057fb2e57", "f23ad7d8-cfb7-4fbc-b3f1-bc959b9731f0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "RefundRequest");

            migrationBuilder.DropColumn(
                name: "CreditNote",
                table: "RefundRequest");

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
    }
}
