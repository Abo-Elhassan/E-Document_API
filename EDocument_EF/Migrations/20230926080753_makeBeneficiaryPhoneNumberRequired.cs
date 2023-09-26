using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeBeneficiaryPhoneNumberRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryPhoneNumber",
                table: "VehicleRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryPhoneNumber",
                table: "DomainAccountRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryPhoneNumber",
                table: "ApplicationUserRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85528b26-07e9-49f0-9d13-f646ff10c843", "7eee10ea-8eef-4611-8e05-783067b9f98a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e899a461-2b0d-46d0-9fab-06318dcdf7e5", "37b7266b-71ec-4049-850b-960edee8a67b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13c83822-f9c5-4121-9b6a-854b988b503f", "9472d027-33cb-496e-857e-b54bdb3e2c76" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6703513b-9871-404f-b59a-18383b3cb640", "b85b880c-2057-4319-90de-385b05e33928" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "361fcc21-42da-403b-bd00-44e46758d400", "4afc50aa-26df-495b-aa66-ffd826738004" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "174ce09e-78f7-4cff-afd3-ae83b59b4fc1", "95de0321-7280-4e44-a703-9edaa96a048c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d03cedb1-7e32-4964-bf0f-062d0502d910", "e1a445a8-64cf-49e6-823d-52aaabc20bc6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a107c6a-0bb5-4b7b-b28b-a523861aa5a1", "9aaae201-2244-4235-b8b5-a7a0ef36d069" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f84b9594-d684-4867-bb36-61ef7debe045", "2aa149ed-aab2-4893-b839-f852f02ce6e0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a41d14db-35bb-47f7-a672-00b4b4ecd70e", "0f4c54c7-bc6e-485b-8ecc-1310ab817480" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50d2c586-6352-4985-a27e-e63916910884", "d8dad8bc-d529-4b89-990d-ee7ce27c0e3b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1ef5bb2-d3d7-4b4d-b501-ee4faa301894", "7be6a43b-dc36-4447-b812-e8bc46aedf94" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "77ff67b4-3922-45c5-8e70-ef8475ecf047", "024a8cd0-868f-4990-85ef-9ac338379629" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd9e6f92-95f1-433a-bbd1-75c365e668b7", "45eadee2-a16b-4451-a026-d9c80085f1d3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46696dc8-026f-45ae-bdad-20f1c9e7fb7f", "336c823c-1bc8-4ba2-a564-d37542975cd1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "88f8937a-9bd5-43df-9ff3-f40495d4a1c1", "4df6a990-91a9-42b7-aed4-b29841b5258f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d196de49-45ee-43a8-8857-1dfa171d2a54", "51e23f3a-3531-4826-ba06-eeb74c2d0b3e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ff27cde-a4fd-4a02-b86d-8f0d3c46dedb", "9b92d80b-e23a-435c-a3b1-ded3de307bda" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "907b5efe-c654-401e-853d-ec6c143724bd", "cef21d75-d95a-43fb-83ba-6bb69cb7705d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba27caf5-bc72-4dcb-adc7-ce682208ac72", "bb334606-2512-4c6e-a6d1-9e5796a6e2b5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5227d7c3-6422-4bf2-aec2-73c39890d9ee", "98af8cce-60e8-4fd1-8f06-588094598496" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1bee3223-22ba-4d5c-a7cf-4c82e8aa18e3", "ac6dac3e-d850-4d28-9585-9fb4b9f2338f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e4c792c4-e95d-45dd-8d06-a108dfe8104a", "8d38b60b-26e5-4959-8288-eac4021d4e73" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "216c1ee3-f0ab-4ff8-9182-685922cb53c1", "e1741dbe-3490-4f4a-ac1c-69bed46d856d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e823f27d-ee8f-48be-94bb-3232639aec85", "62930730-bd32-4146-b8f4-41c6f6dfc9c6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f903b1f3-846d-4ed8-af95-a7eb4c29c6aa", "fda29c16-e58d-4702-82c8-b2296d795913" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b54683f-1fb3-4d7c-ac82-80f8e0f6844b", "5487e1b6-096e-46c3-adda-23a3e5edbc4c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c75fe25-93b5-4f76-9563-2e39423fec04", "dee1a5da-9f85-4936-a596-a33f7a2068f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c98a4805-0d8f-47f4-95df-218eb7f44772", "d355a26b-8dba-46aa-98a9-bb17d50e4afe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "925a4f7e-e19f-4938-bc93-8536a2cce0be", "11a6c905-0b0f-4cd9-85ff-dcbcd0c79e18" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c3c908b-ef13-4a39-9f77-96b45e81a5f8", "6a1e0669-cc87-4151-a497-df294d190ffe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "53ed7ed1-5511-48a0-be28-6c8ea9fb9f5a", "23b8e4ce-e1f0-4ccb-903e-8029939281b6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d7a0b33-b2a5-43b8-b85c-b654ae8a9425", "ed3da9f4-95e6-412e-b3f7-f1f977ab0267" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0987a2db-b8dd-4f35-b951-198717c01b4c", "b49c54e6-0270-4743-9aaa-3912148c9c7c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryPhoneNumber",
                table: "VehicleRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryPhoneNumber",
                table: "DomainAccountRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BeneficiaryPhoneNumber",
                table: "ApplicationUserRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c1b6fc8-46d0-46c9-8f5b-5e43aa9dbd05", "e63b2643-be02-47da-b109-9a9a327deb1f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cec8355d-4326-4586-bf12-a864527304a5", "73e7b80e-a425-4006-b0d9-6b0233d7e0fe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3575f90a-dbf7-4602-9b2e-1b215c61d000", "f1e07843-eb78-4cdf-9462-bbdba86ed401" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "605f9c6f-2fc4-4ecb-9703-301e4f57a5e3", "92776a62-f195-44e5-be7f-78661e2d84f1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a3e5fcfd-b508-402d-8611-9a938264bd1a", "8ae2b03c-ec65-406f-aafa-5899db6a68d8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b05d85e-e565-4f3d-9688-622bef6e206e", "50a9f517-51e2-4469-be6c-08dcd1d0a52c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87e45a05-73c0-41dd-85e7-c9b23968455f", "26d710ea-5296-4181-a41b-3685e1411f86" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "95a21b8c-05cb-4898-90fd-f02d49210a70", "1810173e-7fda-4e35-be0e-bf239d621658" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d2f7c67-79a3-4f3c-8e7e-ea77410e570b", "0218cb15-2cbd-4e46-ac24-93d6e49cd26c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4b54454-3590-42c3-9e5a-229ecd5eedea", "e01cea46-0c88-4846-9ec6-2f19cce715aa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e211a6d0-f517-482e-94d6-8160e2fd1d94", "7eeaed24-e7a4-4fe0-af19-350d97d88f17" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "643c8169-2016-43da-977f-e52a1763d636", "bf0c90c0-9446-493a-951e-cc5fd6a5b255" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aba2e311-0afb-4850-bd17-f89ca81e28e6", "80f7876f-e172-4325-a957-a07ef0cd7f8d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d4fb68a-94b6-4f5c-91a9-b250afde1588", "05531efb-058b-4e1d-89f0-f510ffb69a82" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bb9bf3c0-9c7a-45ca-87b6-4396d18ab1b0", "5f476e10-0d00-4135-8491-7b85575a6a73" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a08c83b3-62dc-4628-b711-3431486e9de4", "8914ff33-db7c-4b28-ad8c-4ee42ef4c312" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "afa95d20-229e-417d-a3df-5bba3e369ab8", "00defd4e-7534-4843-bd84-3cdf82bc7f96" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9430644-c442-4749-9ac9-82dcff02a19b", "856f2450-b03d-4179-a60a-391f35975121" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b3ff904-6e33-4c19-a63b-0ff6c9aa1009", "8e809cf9-0e74-4c05-804b-ced0a90c2879" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51d5d55c-f037-4c04-be66-d482444e7f94", "77bd93df-9658-430f-a129-fd9845e46ce2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d214069-d359-44ee-a460-2d58c292be7f", "b6fef722-c875-4349-8df6-1478915fa5e1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "83aa5bcc-ac7a-4656-ba3d-3fe1484104fd", "41996241-4fe7-4714-b2ac-25121aab178d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5440300-ade6-419c-aee5-6057330513ea", "bc69d6d4-7981-4acf-975b-ff6f58eb5c31" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "acdc7617-8dcc-41e6-b3d8-77c42d4f84d0", "0cc85202-d0f8-4961-bca0-378930a3df57" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "898dbac2-0a04-4bc5-a14f-62f81e6f5b9f", "9b5489d3-02bf-4450-b5ff-f23df0c89e39" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e32cee53-8a0a-4550-ba9a-70c278f82da6", "0432b41f-08fb-489f-a678-7581b6423d5e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f87e9795-bbeb-43e5-afa0-04ca3cffd8cf", "6d03484e-b6c6-4196-b23c-b44d35acd73c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a9eae34-7388-4b07-8ec5-195db578bb97", "3ca2cb67-82ff-4882-8a67-3afc09b30e84" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "25a1fb34-f849-4ef3-99c4-dece5da64f03", "0e246f03-a369-4f74-b7af-5f9dfc937ed8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f55ac3fb-87a0-4df2-89e6-9eb421b5303b", "b28929bd-5f70-4d84-a3e0-cc2908057041" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89fe254a-62e5-4c9c-8c22-8b16f5a6eb26", "a148cf45-5858-4bb2-b335-dd23f9fd70c7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aefe2fee-9e65-4c1c-ba9c-daf0d086545d", "bfd753d1-f33f-4dec-a6a6-7d5374484ee6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc6ef51d-3347-4877-ba48-3774f57c60a2", "f1599c6a-1233-4769-9ce0-ebaea4dfa92a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8246ee05-603d-46fa-974e-cfe5911053fc", "6819ac31-48a2-426e-9f4a-03e57e8920e0" });
        }
    }
}
