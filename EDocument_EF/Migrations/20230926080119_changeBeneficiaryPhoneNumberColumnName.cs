using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class changeBeneficiaryPhoneNumberColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BeneficiaryPhone",
                table: "VehicleRequest",
                newName: "BeneficiaryPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPhone",
                table: "TravelDeskRequest",
                newName: "BeneficiaryPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPhone",
                table: "DomainAccountRequest",
                newName: "BeneficiaryPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPhone",
                table: "ApplicationUserRequest",
                newName: "BeneficiaryPhoneNumber");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BeneficiaryPhoneNumber",
                table: "VehicleRequest",
                newName: "BeneficiaryPhone");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPhoneNumber",
                table: "TravelDeskRequest",
                newName: "BeneficiaryPhone");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPhoneNumber",
                table: "DomainAccountRequest",
                newName: "BeneficiaryPhone");

            migrationBuilder.RenameColumn(
                name: "BeneficiaryPhoneNumber",
                table: "ApplicationUserRequest",
                newName: "BeneficiaryPhone");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fcb034c8-85c7-4ce7-bb0f-65b09c9809df", "5508289f-7ef4-44bc-903e-a8912d04a11b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3b5b2353-f64b-467f-a68d-257f35a68916", "760f6cd4-8283-41eb-aa66-98d2b94a6fb8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59aacca1-309b-45f9-bdd1-e2cdb418a263", "69f80b3e-d9a9-4191-a0fa-b1a9b8c4a367" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b159c336-39b6-460a-8d41-64366b8ec835", "b3a4f4cd-60ad-48ac-9487-645f1a934721" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bbba0603-8f55-44e7-a283-491c1e88bf5e", "7aa3f1a0-d6b1-414c-aab7-3cfc75f21f6c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a27a2270-2a4e-4e1f-9bcb-1bb7ab679ca3", "84002b50-2e97-4e0c-82fb-b667ea2f214a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "737bea1e-eca5-4d89-9cb8-dc4e097c0178", "c0da2556-9635-40e2-8467-6bd3e251ed80" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "47bc9b0a-0233-4232-b965-d6dcb4d4078d", "fcf929e6-8e12-47cb-a57a-d1dfceeac12d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c5c06c2f-2428-495c-ae2e-d08589de8083", "5de7e5db-c4e5-457d-b22d-5609a248fa7c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d756daa2-561e-436c-a6a8-d29451f99566", "a7393485-1bf4-4462-8cec-f4832dccca3e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ef4a54b1-7935-49d0-b614-9bccc20d739e", "fdca9a1a-f6fc-4c82-8e8c-9607f027edd4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c3b43573-438f-4888-b63d-91aa555a331c", "b6a784b9-4f4f-4ce1-af9d-ea36fb327707" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a6548fd1-7ed7-416d-833b-aeff93abd2aa", "b09941a2-8f14-471c-ae06-ad58b1e59bc0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2decc18-3624-458f-913c-56505c2e574b", "845bf8a6-3c3b-400c-b7cf-abfc5905b036" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "378cbf8f-f839-4310-b759-7e44356ff53f", "69b7eb78-0eb0-4369-8863-e41b22dd6046" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2e4d23c-91d5-4681-9116-3b9bfea53886", "5490bfcc-a51c-466a-8556-a9d761d0e1b3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "330f4aee-ab3d-4b5c-a88f-01c76f7f77e6", "3889beb7-8e10-4480-865b-b24cd7aa856a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c38ee79-73f5-451a-a419-91a67f06a314", "2efe3cbc-19f7-4744-9172-1c35bd407f2c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e58f1a4-543b-459f-ac8e-ac747f765804", "0f1b0d40-9812-449c-9768-08b869db03ea" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e133a589-5c96-4a2e-88bb-c53156fa9db3", "587a923a-8e77-4b19-bad6-8345235ad947" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2f4c813-9fe1-4ac8-823a-77402203c1c0", "c838b1c4-c4a9-4c76-93fe-b20e305ae3b5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c0d6dba-74cc-4ef1-8eea-7b21c158b700", "1f0f6e93-52a5-4bda-828e-bffc330c25d9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c3e6fd87-5bda-4d2b-9f83-f1c83bcba5fe", "34d19473-a496-42f9-96cd-2ef5efbd2f2c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57a89e9d-9317-4836-a541-8877cde49fdf", "9cbd3ba5-d43b-4956-a718-107ae47bf586" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ddd3942-5348-4472-a526-53f21cde8339", "040ba872-8b3a-420b-9c3e-5749bcff6375" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9b1975c-b0cb-40eb-a356-f911ffbdcd51", "6086acec-8b9b-4e45-bf3d-20161d2aefa3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "21d011bf-d4be-402e-8d4d-98dd936db967", "e2eae1bb-f9b1-4e29-82ab-0dbadcb0173d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de28a26e-05ff-4971-bcf9-911714b1e9fb", "f6f4fa2a-7faf-49f6-a3fe-ac9e7bdc163f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8414d011-3c67-46e4-a51a-6f11e43b05f5", "dfa2c79e-0ec9-473f-8aef-b70ecc90688b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d21073e1-d6fb-443b-ac84-06cf8b8c1b63", "e13895d8-e854-454c-9cae-0782009919c2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00373808-d8f7-4b4f-a0a2-4f05ab4194da", "2664ffa7-8818-4f7a-8cec-3768a81fccba" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "57506acd-1ea7-460d-aa7e-208249ac4c78", "3c66140e-a36a-4797-9984-dea707f4bdbb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e6205e8-9a80-4f61-88b1-8a5c38792828", "d41a3607-a8c2-4307-8f46-3f27f75100be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f7df47ad-a130-4667-b909-5dcd59c1797b", "f3c6fc05-a61d-4bf9-a8c1-4cc1728eeadb" });
        }
    }
}
