using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class tryToMakeVendorNumberNullable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VendorNumber",
                table: "PoRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VendorNumber",
                table: "PoRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ec0b0af-6341-4df5-9cd0-f96a1f3bd9f7", "b03fa70b-75f4-40a1-bd50-cad640652d7b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "18c0c270-8070-499a-acdb-4e83ecc217e4", "1e34312f-9069-4804-855e-1d85ff53dae7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b6026da-a413-4b76-a151-a21a52d6f1f1", "2d962e70-1cb9-465c-9f98-1b0e30e4401d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9199f703-1d11-4d9a-9fde-b0a851404bc1", "6c201421-02d8-49c4-a06d-bc340ad1a546" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7746032-c602-468a-89e9-5de94515775d", "1b16e20e-2ac9-4264-9f1c-fd343191c644" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe8f0acf-d6b9-4b14-985a-4e4a6be4f57f", "05425023-54f0-4c1f-977f-42f9744a994b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78c338f2-18b6-4421-bb34-11e744466c59", "ad4b5fb4-0343-4fcf-be7d-834cd7ffffe8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d92af03-4ad3-420c-976a-138df260530c", "43e560fc-9596-47f4-8a7c-4dd3ff95f5b8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51f3102b-dffa-4326-bc43-720fa8091725", "9219a36a-35ce-4ec6-849f-129a9aefcaaa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "20e54df4-b6c5-48ba-9901-5b67d1ac5dc4", "d44ff107-26de-49e6-b9e2-3f75b3e65145" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41ffdea2-6096-4d42-b39d-ed4aa9be2078", "69b05fb8-b970-446c-a969-0841d811a9f3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d621352b-7346-49bc-bb08-ff44fdc1e12b", "f70264fd-97b8-417f-b8e7-10a1e13abd36" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "746f3f3b-33e8-4fe3-ba47-ece73f29d367", "cddf63f2-4bff-4f55-870e-e1fdf5fde77f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c287a00c-5a48-4e49-b64a-e11b7b7a8eb5", "985a3d04-c9b1-4695-af27-0a7369c2f116" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "26d3b4c0-2ce8-4a8d-8e8f-554a5ef0c1bb", "62c8f3a7-72a4-4f18-8088-1006c6196885" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b16ce2df-1386-4076-bcd1-f056da82829f", "c153f501-63fb-4e3e-bb36-4b474017d2a1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10abed62-e7aa-4f90-8700-f3a9a28f6abc", "6d3289a5-0428-4029-bd2c-1aa4ddf4ddb7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e02925e9-f30e-47ef-84c5-decf16614dd7", "5ae09020-76da-4ecd-9dbd-8e22e1311310" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4649d7ad-4951-4a8c-96cf-0f8a05a720be", "0a4d7ae0-aa28-4d15-928c-a13da4784479" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c336a9f2-98bc-4ceb-bcf1-d4b6d2b21ba2", "d451f62f-8bfb-4a1d-b52c-a070d41c9477" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41b4002b-0863-4b37-aad2-c6406ef4ca57", "d4762f17-50e4-4491-b505-6cbca3c109dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "221926ac-57f9-4afd-bf87-cbeba6ed51b7", "03689246-06c6-45a1-8e7a-93f91e64d324" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c59c13c-8b11-4aaa-b3b1-a5987940b085", "e87010be-6911-48d2-9f0a-e596e754fd6d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "324bbb22-958b-4eb6-9a9f-fa6d7e62e40c", "c25bbd88-0735-48b4-99b8-936d9f058a92" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b6b06a5-2bd9-4a11-8e28-7694a2cba9bc", "7f3c227d-383e-4dbc-98d8-e97c5e8a7c4b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df50b825-1356-4f67-b03f-f0f655a1830b", "2692e701-5897-49ba-a0c1-3907b37d3300" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56bd94ed-aa4e-4de7-a10d-0147a685c3cc", "daa422c1-b89d-44fe-b2df-1251c2ec9128" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1ef862b-52df-4cd8-b199-17d2d1a46a20", "cdde0008-c899-4bed-b0d1-24d1748b2f01" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6da267f3-895a-4bce-9663-cdecccaa95be", "5fd2272d-97c3-474d-a3f6-051840e34201" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e359a605-962b-4dda-85fb-a9aafbdad6f9", "0edfef4d-01ad-4e90-bcaa-9824b8e2ef3d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "961bfd70-fd1c-4fe9-a84f-c5815e84cbb4", "58c96c4d-c5b3-4ecf-a84c-743028c283ac" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9eb284e8-ed37-4127-8d9a-6780031ff1fb", "18904765-b2bc-48f8-af68-70a6d74d2deb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87d86a86-00b7-40d5-a4cf-de777637bd13", "4b0a7a59-45e5-4ef8-9e7d-1672f2eee59e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11c4da94-db91-41e8-b242-3653f3600f19", "110874af-8285-46db-b6d9-765e7fecc5ad" });
        }
    }
}
