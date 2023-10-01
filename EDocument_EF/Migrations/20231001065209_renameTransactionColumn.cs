using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class renameTransactionColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditVoucherRequest",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditVehicleRequest",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditUser",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditTravelDeskRequest",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditSection",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditRole",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditRequestReviewer",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditRequestApplicationRole",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditRequest",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditDomainAccountRequest",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditDepartment",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditDefinedRequestRole",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditDefinedRequestReviewer",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditDefinedRequest",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditDefinedApplicationRole",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditDefinedApplication",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditAttachment",
                newName: "TransactionType");

            migrationBuilder.RenameColumn(
                name: "Transaction",
                schema: "audit",
                table: "AuditApplicationUserRequest",
                newName: "TransactionType");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2f3dcc4-b7b2-41e6-b87d-6ee3cb5dabb0", "f411b4cd-f08f-453a-bcf5-b69d9a77bc86" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f649a7cc-d82d-4e21-be82-b1a1074fa434", "0c6b2b22-b0c2-4cc2-b98c-23e4e24f9d02" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a97108b-929d-4fc4-85d8-7d95732f5c06", "1b46e5de-05aa-4f71-a30a-040696c7b564" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c827687-a1e1-4edd-90f2-8b2edd18073d", "07cde5ec-ea9b-4999-8e6c-e415d08946c7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b5724a81-138f-48ae-96c9-6e8c1307f2cc", "9eec858e-e0cb-4e71-9a39-c18b4b5f1db5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6aa3c4f7-bc0c-4865-a994-4994c7c6668b", "c18a8375-235c-4db2-997d-487918ec4dbe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "336e6eed-7cce-40d2-9adb-8b63b7ff1f33", "14e00e81-dfd2-446d-a8fd-5c35dab2405d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c446e475-7a02-47d7-9305-8df04486767b", "91764a9f-aa71-4929-86e1-0a5e86a3bf16" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42db05d2-abc7-4440-9310-46782bb1484f", "919d9a8b-f277-498d-a38f-90a8e8e815fe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9515aabe-adf9-44c0-b833-b20d35b65156", "e4cada1b-e7cc-4887-8822-aa7aae8efce8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63e49300-8c05-4301-ba26-e9a7eac2a50d", "8063db78-eb41-4934-a8af-094031bb207e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67b4cbfa-0022-4a5f-b7c6-2e91c39279e0", "aed8dc31-032d-4038-a2d0-234701512dd7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba237ec9-9048-49d5-9543-64b495ce8c19", "154906f0-3bcb-477a-aa5e-e6f88a9f8789" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "776e5ab9-2c6d-4065-8997-c39f43e4d1a5", "b798e70d-a871-4c31-b115-b3f8f1bfc677" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c25579d-dc66-4421-a602-60992433f26d", "eb9dcb9c-83ca-4667-a3d4-53d1f5481f9a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7b44f15-d8df-44d4-9e68-e69da6499149", "df193a9d-fcd3-40b3-a7fa-126c5368b660" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd817568-7232-4114-b151-4687579aea16", "9173e652-91b8-4811-8b93-47c73c36e9ae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbc4012f-a16c-4af7-913b-d39a10c6010c", "e6f55ae1-dd27-4e18-93cd-f9f286077eec" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "22c301a0-b7bf-4392-b737-de846b663028", "01d17b3d-2bf3-408d-b511-74461509353c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b74385c2-69cb-4293-a219-e8bb73575bfc", "36b8cf7b-823f-4f31-a36e-256953ac782c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1464badb-8720-4806-aceb-85ba3cf865ad", "e11e3b6a-e9e7-440c-8338-02c8005830b3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ce4f7c29-6323-4e4d-8c41-be4396f1d171", "e4f99629-78ab-4d86-9ad4-bb79704a44b7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f731001-4c9b-4117-94a1-43508244ad5c", "a661ee9b-91e2-4971-aebb-55082b56eb17" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28794ebb-0324-4a7a-9515-31620bb09fca", "5fda1d53-686d-4214-8ceb-2a019f038c75" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e9dc171-9ca8-43cf-a8ee-bd6218e39fb0", "019b939b-c8ad-453a-9e0b-68bf37dbfab5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "084e545a-a716-402f-9943-963d06e560f4", "b3bf96ff-82cc-482b-bd0b-fc501280dd41" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed70b31e-0101-43fa-a387-f96c006abdec", "5b6e5a65-b209-4df4-9f39-92d69542de97" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1007f7e-13e3-46f7-8ad1-3222cd2a6ccd", "3b20cc7f-bc7e-4365-893a-9bdf491fd7e2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "abfa2a94-ba55-4335-83aa-407e9adccd69", "cdcf9494-6419-4b12-8ceb-2ac026f5c379" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d1109ea2-2787-46fb-af51-cc55108b8950", "eeed3e2b-fd5e-4093-85ea-8069f3162de9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fc555293-b308-4c86-b27b-57c8c685e7e8", "33069eb0-1d3e-4f65-86fb-75d4e12d5ce2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "19486832-0e60-4c34-975e-5ae315a251e2", "004aa81a-7127-4fb1-b183-ac1dfd2d28f7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11188e8d-c9dc-4b89-8efc-290d236b68e3", "9bd076f3-8264-4fb5-bb76-87926f0ffa64" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70ac9e33-6edf-49e9-b61b-18bbb3e39906", "be1b410b-72ef-4799-9a6c-87104e2174f9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditVoucherRequest",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditVehicleRequest",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditUser",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditTravelDeskRequest",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditSection",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditRole",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditRequestReviewer",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditRequestApplicationRole",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditRequest",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditDomainAccountRequest",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditDepartment",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditDefinedRequestRole",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditDefinedRequestReviewer",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditDefinedRequest",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditDefinedApplicationRole",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditDefinedApplication",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditAttachment",
                newName: "Transaction");

            migrationBuilder.RenameColumn(
                name: "TransactionType",
                schema: "audit",
                table: "AuditApplicationUserRequest",
                newName: "Transaction");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79b9ada8-c09e-4713-878e-5c9103b605d5", "ef9566e4-c105-4471-ac59-c8f6c1513e60" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6c2365b-ed7e-4268-8aaf-e39a790ea025", "a8f772b2-47d2-4b45-95e6-4a0ff8d6c5be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "435bf1a4-b252-4988-92a5-e83a684fe5bb", "6cdf9a9f-2ed6-440d-a920-9ec6148107ce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50f6a7f5-4712-48e6-9e6a-a6bc79bf4029", "01549ccc-8930-4f56-b170-d60fb88879c0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "842884cc-7fd6-4f31-a326-ced177494353", "51cb3804-73b5-4c3d-81a5-53664f0b32f6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "543459e6-bae1-4108-a2e2-b85672b07081", "cac19094-e5ac-4a83-a4ac-c1b38e06b639" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e157227-0c71-437f-9fdd-735d5a65d157", "10363024-0a7f-4069-98cd-8a3d921324de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a1d8a39b-bac6-472e-91de-fa3a28859273", "b7551f24-f790-4fb8-8159-04445b09b34d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bd13bb0f-1260-4c77-97ec-37f35da9d159", "ec492cb3-c49b-43ba-8bb0-df87c10b6145" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c2e834e1-82b0-475c-b888-e3c75ca2f733", "c50c6994-56ff-4da1-b9fe-ec4ebefd731e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c38b4853-f15e-4c4b-8cd0-c448400c8079", "e3b982e5-3717-42c9-8ad4-dfb90950ae13" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "639f07de-3fec-409a-a748-9e6c459b2bce", "ed16b4ba-0dc1-4236-bc17-235bf6ba1b51" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e06ce94-2f95-40fc-a704-be3b580662a2", "ff7ebfcc-05e6-47be-a727-ada04682e5b4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "adc71158-0e48-4122-8383-f7a44ac0485a", "7783f836-5972-4b21-a1bb-d21612f052ca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9e731e9f-0300-4a3c-9801-be6be76e65f2", "c4ef663b-c911-4534-b8cf-2094545e5f97" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5353b510-b1a8-4f39-b24f-c37813768a7a", "90394299-4d87-488b-b6c2-379a33bf9f72" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "82ae1aff-0e94-4385-bca6-883b35e6d1e1", "71770385-7453-4591-bcdc-bc5b37d54a32" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb9d239b-6761-4e34-8d84-f6eb73d8dc9f", "86afe343-70ec-43e2-98ff-8711a95e6361" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7d017fa-6206-4031-9b2b-710bd5d8a374", "b1718289-6c3e-4343-bbed-f91fb260dfce" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bc7a7474-be33-4330-bc5f-4b36c9a915ab", "cb02bc91-e1de-4e0a-9fae-285d23033fb1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31886f40-ebeb-4cff-b977-e5914f41ed1e", "ba297dab-1430-4036-a617-4fb7b7fab219" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1152b64-34f4-45d9-9e21-6f23e666b4de", "b11ebee6-81f8-4f76-bbbd-db02a3ef6c43" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f47dbd8-a2c3-4d89-9165-a3bdfea241a4", "91148a7f-f7d4-4b0f-90b8-6509b0cc928f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4bda5dc5-19dd-4872-8d55-47a6cf9f08f3", "cff9a1e4-2fc5-4a38-b782-3e97c861ee31" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee44b2bd-9bca-47a6-b0bf-ae269c9d5685", "b11e329b-482a-488c-b559-6b561a1ec64f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b589e5c3-711e-4f20-ad00-3b263c8dcf21", "184974d5-9a9b-44e3-90da-503dd9dc1e96" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81876c9e-927c-47b2-8313-bebe7452f8c4", "01002d77-cec3-4e68-89a9-51db129df5de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff43862f-b181-4bc8-8179-034f77b8924d", "b551a17d-6ae1-4807-8514-300ce8c8a9ad" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cb996563-8897-487b-a55a-a65b98ea5630", "66c0b89a-aa18-41c7-95fd-ae3aed7b7ff2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3eb66f1d-0902-41ab-be20-81dbace9c196", "a14d8722-2652-4b6d-a550-c05f31177db7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "162d2e90-5a96-4f22-8afe-b91bad72df2f", "00bdd3bf-d287-49c7-ad91-ddadee1e86d0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f101204-9a51-45b5-a908-5b7913f02782", "5a663790-02e1-4451-996b-977f8d7beb97" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "402bf159-9deb-4c3c-add8-aeb2c4964f78", "4a99af8e-7d0c-4c4a-8897-26bea5c25b70" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80906d82-d129-4317-a68a-e533de33b6f5", "89b5c30c-1bf0-4bd2-b430-299f42e63fa0" });
        }
    }
}
