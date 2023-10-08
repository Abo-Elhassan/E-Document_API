using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addAuditTablesTriggers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "178f12e7-09b5-4689-aae8-bf7997a1fdde", "5e69f267-86cc-4ff6-8e63-ee6ceef7c89e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e5a44a5-c0ad-44d1-b882-d050cecb7648", "514ccd67-b7c2-4302-ac88-8b0b9d104628" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e74bf8cb-9d71-47bb-ac3e-d61ef7839c48", "6e001d9b-27ba-472c-9807-58d72b68fe29" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2cf93471-2c8d-46ad-99f1-00855380513e", "c461d342-dfee-406c-be27-ee01284614fe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1be719ec-cf2e-4cba-9d9d-35f519315bb7", "1b633135-730c-4263-b544-5a6bc6bd60d7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5f2574d-d5f3-4925-a750-508ea61ca5f9", "a1b440ff-ac5d-4764-9a8b-ac9a63cdf3e7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5542a6dc-f7e2-4f7a-87a6-e9d7a0112d5f", "7b27b124-c7ed-42e9-b266-ae88eaa8e5a4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "56f4cc4c-7703-483f-992c-8b0b7ac6382e", "0d74b491-89d3-4895-b9b8-ad5028128f5a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5ad50bd3-577d-49bc-adca-773fb671b33d", "6b5a9423-77b6-4f01-92d4-b3cfec9495d6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "498a49d2-5e00-4f64-81fd-08ee9e14def8", "a3b052ed-9447-46c7-a05c-493233fbf88c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e73419de-495f-42ae-bdc5-0026c36be986", "253432cb-2fa4-4f37-b67f-9dee48b2e184" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5a517331-594e-450e-982e-5da926680ebc", "3cdcf1d6-cce1-4fcb-a297-f50815ee8192" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "756115b8-635d-48a9-92d7-482027fe5d66", "0fc8529e-4a1f-49a1-a0cf-2211063d5d22" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11ae98ea-12f5-443c-ab24-ff79e4fce2ba", "f6ec68f7-516b-415c-9717-1cd1ddb69574" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "81fb7b85-18f9-4d65-86ea-15e7922edd06", "955fac93-eedd-4aeb-bad6-48235a2a9011" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "53927848-9c53-4882-b9ee-e39a16a115e8", "716b4d1b-bf30-49c3-b766-7ead3f1f84ec" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5cff58b4-c383-4994-8a50-50ce3275a62e", "3f7c317f-309d-4082-aa4d-26c8b953bc4a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51611436-6c92-455d-b465-41fd7068e1e4", "525c17d2-7e8b-493f-bbe3-bc3210b52d18" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3265701e-a016-4273-a97e-f33acbb00b1a", "4ea44692-adb8-4ce9-8ebc-036f8ee4653e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1d39c0eb-a09b-4427-bbbd-efd2f5a2c0ec", "ecbbb291-9660-472e-8bdf-d28b3cd2579e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "913109e9-8de7-4335-99f5-2fab5ba6cba0", "59b160e6-4fd6-4d9b-bf69-4bbceb7b1002" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2ecca886-1581-43f1-b7b4-016284be20cd", "e06bd711-1487-4b60-8ead-73122ba8bef5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7dc2a24e-9f52-4bf7-93dc-d0e013bd48b8", "fa71d6e2-cec4-4321-a2b9-9e5d615a6eac" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f565f871-813c-47ab-99d6-9b34f5cbe991", "1838d9a4-e8d1-405d-aafb-c134f918dd27" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b79f7f77-be9c-442e-9086-df4c683264f8", "ffd54677-0592-4b55-95cd-d52fa3857287" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d69b79ef-8f47-44c5-b3f3-b54976235013", "46c30c46-1fd4-4a38-8b10-34d1aad1ec60" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10da2ffa-4e60-4e2c-b742-f08a45aa7719", "04d642a8-e1b9-4667-875f-b2106fde8855" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91cd0e78-0638-4fa1-9723-63a591d7a48b", "00727d52-6a09-41f4-ac15-a2590256f91c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "715cf0b8-68c7-4dfe-9b7d-1bdb75a76ed4", "b598dec3-fc54-483e-a087-1ab1fd6072a1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59a43b62-ccd7-4083-8537-2f0f90277955", "8f174879-06ed-48bf-b53a-243108428959" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "016ae30f-d325-4a8c-97de-301286d7fe55", "253ddc57-ea8a-463b-8d64-9da090d1813b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c8047a3-e5f5-4d1e-92dd-bb2f5f58457b", "3668c096-fc91-4c3d-aa2f-2bd33ee8ffc6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38a0de2e-d010-4f32-8bfc-4a1f03b5aa7e", "6aa6f428-5bc9-40ae-936e-f36aa2637b88" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94270486-6a62-4241-9723-ab71007a50de", "2665940e-d132-432a-a3a3-0e66db829382" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15dfd0ee-4089-4c87-9728-2e2977435c6d", "e0ee4559-a585-496a-8bc1-758f74d65263" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3ece4034-fb0c-44fe-97d2-1de7144d8196", "2059821c-d394-42a2-a009-4aaea9e0dcb7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74686b96-a811-4670-8adb-46cef42e6eb1", "8c2d2024-a3ea-4480-8f8d-20d15aa2583f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36515b8a-07f6-453f-9eb8-1e85232ad6aa", "b5eba13f-8e73-4a74-987c-b1686f00ac15" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "abfdfb9e-8515-436d-8ec7-d025cae17271", "1d42bc82-65fe-4712-b0c2-77646589a1b7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e54df7a6-8be2-4308-b026-17302139984d", "5001970d-7892-429d-b043-923f5c2c4af1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2affdd20-0841-497e-b0fe-754f18a5d8b8", "38e9b254-5cc3-4bc1-8138-16187fd301d9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdd09999-59ff-4df5-a5d4-2b5e4d8cb8b7", "14de375f-c695-4384-ad12-03162319d455" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b414ab78-4a98-4e45-b7ff-ce8ce4653b58", "48fbbc79-70e4-4358-b129-5583817cd134" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd7c11b9-6d6b-4554-aaff-28790e6627a9", "12bf6efc-4a5d-47af-9e35-09628eea9744" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d3ab168-3d4d-4c8d-8705-4323d5a38f5e", "58046199-b21c-4fe1-80b9-24615e26bdb3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e0aebd7-88a5-4407-bf00-3a6407dd767a", "545a873d-2f3f-4b71-a36a-5a582c4d9249" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "18d353ce-28a0-440b-8d23-67688c93bcb9", "baf4143a-6732-48b9-8d4f-2739c08b0fd3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe4d2d70-7a52-438a-8e2a-9c34700fb288", "db8541c8-c8c0-460e-83eb-fb90ab25e054" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d5cface5-2cfa-4094-aff1-a9dcd12e12ad", "3ce98a3c-17bf-4a92-a9d0-f1f0853afff0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87c0eb8b-4009-4fa9-97f2-2037c865c25d", "588a29b5-1e4b-4248-8c66-099edcbabfe8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2eabc1a2-2ace-476e-bed0-40a47423abd4", "96768642-2cf1-4bd8-8d7f-8ae98ed10ddf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9d6a0a41-86ec-4613-8a54-8d692d9b7438", "217c44e4-e9b2-4c88-8670-bf02e2caba19" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "62f2ef9f-a8cc-4c26-adbd-28b8a599f582", "cf85675f-5fe7-481e-b914-22bab8e19b2f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e040d9a1-fc5b-4350-8ec3-5b65dc0e38e8", "2669dc9e-769a-4517-b280-96728bdaaf81" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c4bff47-142c-45f1-bd6a-93b08b406b1c", "c006959b-a843-4ecb-a4c4-5f3ee4c6485b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d1e1dd5-fe93-4248-aa35-7423c26050d3", "7dbbfb40-b028-4259-be88-29252dc576d6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7503c515-e1d5-4477-82cd-d25b7988fa29", "c3b465b0-023f-42c5-a867-9516bdc85d64" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d3f81331-8318-44e6-9f8c-b22bc1182310", "cefb9979-fc30-41b3-bd79-47374a216491" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "683c8f4a-8a1a-4206-84e0-defabd111df8", "50d5456e-92b4-4d65-bd1c-5befc68a4ad0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "308f115a-b3b9-4203-a5d8-e09784f37068", "a1c4b554-2d55-44db-a5e2-91ba285e2ab7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "161d3566-c148-45fe-a506-d7c722918e4f", "5e54f08c-2ddf-43b8-a159-2a415cd65111" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c83596c1-6ea9-4420-8aa7-fb9c993cdb33", "3e20d1de-879b-43de-99bc-b03926465f28" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3be7fc85-401f-462f-8f54-37ee1468159c", "27437bd9-ae83-44ad-abd7-bd1c800e5e6b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85e4b992-eb9d-41e7-aa43-ece133cf69af", "21ad56d2-4ed0-4b9f-a4eb-7ee1bae76c72" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bf3fdbe2-71ad-4386-a80f-b6297113be19", "56d6aa9f-b5ed-439b-a114-aeaf0acfe658" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9811cd6-7c11-4f3f-a9eb-e7c580caa1d1", "59e5f88e-e2c0-439c-a4e1-75415bdec2d9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55564a0e-5bb8-45a5-b642-910f6c1be2f9", "389eb520-d1b6-4bc5-8062-1808d5bb6aff" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cdb41f41-dbac-4f3a-af80-7311868e646e", "021ed0be-76fb-4777-9a13-975111d9b66b" });
        }
    }
}
