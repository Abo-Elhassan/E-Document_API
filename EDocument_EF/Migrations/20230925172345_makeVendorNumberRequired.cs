using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeVendorNumberRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarRequest");

            migrationBuilder.AddColumn<long>(
                name: "RequestNumber",
                table: "TravelDeskRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<int>(
                name: "VendorNumber",
                table: "PoRequest",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RequestNumber",
                table: "DomainAccountRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RequestNumber",
                table: "ApplicationUserRequest",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "VehicleRequest",
                columns: table => new
                {
                    RequestNumber = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DestinationAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    RetrunDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    LuggageDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryPostion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RequestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleRequest", x => x.RequestNumber);
                    table.ForeignKey(
                        name: "FK_VehicleRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_VehicleRequest_RequestId",
                table: "VehicleRequest",
                column: "RequestId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicleRequest");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "TravelDeskRequest");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "DomainAccountRequest");

            migrationBuilder.DropColumn(
                name: "RequestNumber",
                table: "ApplicationUserRequest");

            migrationBuilder.AlterColumn<int>(
                name: "VendorNumber",
                table: "PoRequest",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "CarRequest",
                columns: table => new
                {
                    BeneficiaryId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RequestId = table.Column<long>(type: "bigint", nullable: false),
                    BeneficiaryDepartment = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BeneficiaryEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryExtention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BeneficiaryPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BeneficiaryPostion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DepartureAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartureDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    DestinationAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LuggageDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RetrunDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRequest", x => new { x.BeneficiaryId, x.RequestId });
                    table.ForeignKey(
                        name: "FK_CarRequest_Request",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3e81998a-758c-4241-9e04-55ab1b8f7a39", "5d347499-c643-4391-bdd6-d24e3cebe286" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f94be5f6-c66b-4744-b5b4-320dd72ee39c", "bf49c839-8aac-440c-baf0-4f342254220b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45d35848-ae50-4f4b-a36d-f60fcb48648c", "629fee88-7095-4f17-8d13-97f5882a74bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d5c3c31-bf90-43aa-a0ce-0b3e1dddab30", "86f3c803-9000-4a19-b111-f11691eabce3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca59a9ca-63e9-4d1c-b9d1-7c58ec9ee622", "e3c92d15-417a-4a20-9c57-684ed90398ca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a7981076-8791-454c-888f-78d79ecf71ea", "228cc0ca-1187-4dba-b53f-36820a95d876" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b95aa5c-76df-4d0f-a6b5-342a199b0edc", "2c55ec82-6145-40ae-936d-c5680500520a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b19a7c29-d34f-4846-92c0-4f8b759bdb9f", "5b1fc24b-8726-490c-9709-783c3903dfcc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "450438f2-a273-433e-897c-83607b2e3256", "3f4133fd-8784-48c9-a110-43006b9fb5d3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b3d00e4d-0f19-4734-8499-2b0f8122cdc8", "efbb4bda-c994-472b-bad0-f53358653bd2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3f411688-2486-401d-a924-940f56d3fdfa", "c12d5f9f-f91b-4c78-be20-e5d99161f591" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ba0664ba-3c6c-4011-85b0-d35a3c2940a9", "febbe284-4ba6-498e-b144-8f07deda2d6e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b1ec3e7-872e-4ae8-8be4-be3b5867b5f2", "28a65dce-f11d-465f-9816-179787767368" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf9c7ef5-a6ca-4d74-8532-29e31d8d5ce5", "9417618c-edf7-4630-9aa7-29a0ecbda9fe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2029407c-675a-481d-a929-f9d1c7da3324", "151133aa-aa7e-45c9-b2dc-9aa449023fcb" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7819dbf-fc17-458f-898d-c9395ba2ecf4", "d7f0673f-3342-45e0-b5de-d1ac923d10f5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4351e3a0-0973-487a-a733-45527e5b2cf0", "4adc27d1-4ab0-4e52-ab0d-3cbd2ab76b06" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a82ebba-328b-4058-b2f8-19b1bf791581", "7d3e1127-1df3-4433-a440-90b5a2843485" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "585f1058-6ee0-4387-8425-9f975929f9df", "fb4f32f6-d1c3-4105-a134-ed40957103f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f80059d1-2d38-42c1-b076-a6d83da2b9f6", "a70d1047-d7df-41dc-b604-88ea9f53c476" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e934509-f8db-4e33-a3ac-18e4bbf9290e", "97177a3c-17bb-4c8f-aa24-a9ab0858f3be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c273eb2-d519-41c0-a92c-acff32e7e39a", "4bd4bc61-2bb0-4d5d-8047-1304d6461733" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2afc51d1-89b7-4939-aacb-f11b3f76e698", "689dd17c-6aaf-4080-b772-6e30ac0608d3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3945f25d-1ede-47ce-b80e-11ecb8f95a1a", "1b24a9d7-3220-4e8b-9d52-8ff76562be61" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f31a2180-929e-4eaa-8fb3-cfb72ef273b1", "98d48fa3-fac2-4a10-8531-34ecdfd238bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8fdda5d6-c70e-4102-805b-23d216ed7d43", "b56edcb0-0a88-4693-af78-2b73110818be" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9099fe97-a8dd-4e5b-b1d8-03371a5106bd", "0ff6fd02-05fc-4cff-8d11-6bb761a4dc0f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79ad65db-f9c6-4987-8469-c9083f4420ef", "4c7a3df8-3c56-4e20-8588-f7a102abba26" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1c73d81-1421-4fc9-8a7b-ae0acead59e3", "b38b26bb-0f9b-4ce5-a54a-75330d3737b4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9d64ed5-5a43-4911-9ca7-05efc34a9f83", "30dd7c1e-80ab-48d4-ab06-1c57d8fa2536" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a7f00a5e-2c2b-4eb4-98c9-796c5d9ff6a7", "cb794b4b-0232-4b16-9633-0f9f935c1580" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59971b70-3110-4185-a5a6-30cf0c2a51c5", "836c1e5b-a9f4-475a-9cd9-7e1e3ca09e5a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "24d95b59-cdc8-4649-90dd-51f6ef001699", "d8cbad45-28f3-4c15-88f8-5bf1f961d5e2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "73fa49a4-43c0-464f-b493-4ea4eb49a1c5", "ec0bfd24-022b-4f35-83f9-6c7dc8b26720" });

            migrationBuilder.CreateIndex(
                name: "IX_CarRequest_RequestId",
                table: "CarRequest",
                column: "RequestId",
                unique: true);
        }
    }
}
