using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class makeTravelDeskTypeString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestTypes",
                table: "TravelDeskRequest",
                newName: "RequestType");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17dbf89c-101b-4046-a972-e0328fd044b3", "00a0baac-8810-45ef-b023-6812b308f7bc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bad25b70-347f-4bad-8db0-b5e8984acc6f", "fe64594f-b2fc-42ae-992d-7b23a0bd65d5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a866c753-f4e8-440e-9e97-220a66fc28d3", "751988f4-81e6-4bf8-966b-1b937b707dee" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c2284c5-85aa-41f3-bba4-2123fab81881", "71dece52-bbb3-4c70-8ec4-2d813ff76db6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c1392a4a-d228-499d-a32b-401533a4c423", "9de804c8-19bb-43f3-bad7-7aecda8e6d2b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "28b77ae8-7255-44a2-a1bd-0ed6fdebbb41", "06a063ed-78ff-4064-bcc6-c475b933d172" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dbcd247c-69a3-4c35-8b1a-f68126874fb6", "014c1a53-64ae-4ee0-a737-b1fd31334184" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "871c560d-a3f4-4e8b-a52a-21d43734d1db", "8c05394b-3b56-4a92-ae11-ebab5f9811b2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "18dee832-5ce4-46a6-86b1-81eecb0f7ac5", "eb32c391-a959-42a4-a526-1bb903d06b14" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dbb48ad2-6864-4895-89c0-cc2dfaea3a64", "f5cc5831-eefb-4bd0-aed0-b01e5c737038" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "95eda762-41a6-4b78-8930-e6aeb2e6effd", "ff9c5d23-13e2-4e1e-b395-2284ff62913f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29a00c77-59d3-4112-b559-41aca49bac34", "43722527-e628-44bb-90e7-2ee04a6eda09" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80a78b87-3302-4b76-a47b-463355a37680", "84acb5d9-f75e-40ea-8604-b5c5ebd4452d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df27fe96-1be8-434e-a12b-939c1e90f4f4", "d5931d9b-203e-4b71-888f-9c0ca4037722" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "63c01eb4-1441-4126-b5fc-28f590605999", "58714666-42d4-445a-90ff-cbaf5f571d1d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c1575e1-e525-46a3-97d0-3cd051f60458", "8f35178c-a8e9-4c1f-83b3-4ba570db7668" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9114be7-96f0-4909-b00c-8fbdaa76d81c", "8b1c3ca5-c506-4bdc-853c-4cc3a5cc8ff2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e049d263-ea55-436a-b5cb-15d22c23e91e", "4da81af5-8251-485a-bd33-7b2584c169b1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8557555f-fb36-41a3-8fba-ae6173559a30", "b53eb5c7-3d7b-4feb-9a3d-d1b593d457b8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df250fa9-8522-414d-8cfb-40a3fdb5355e", "61f16e02-6611-43e0-8a3c-2ab0eda44cc0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3942a059-5c58-4a71-bcf9-419d6c54f574", "a60580b7-875f-469f-899c-3e89bf52a64a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29ac47d4-a286-4c3f-89d1-5b08bf8886f5", "bfc733d8-885d-4fcc-b848-1d87b106f482" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2b08fc09-fbf8-47a1-91ab-3433c7e09ab5", "ae0c4909-3fa1-4566-bd06-0e07cf8303c3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1b7dae53-52a1-4b19-a214-e934e0e36eba", "23eb131a-32d0-464f-a2ae-b0ed84f8d9e8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "18c1bace-5e85-4efb-822c-c27029b0279b", "d736660f-a494-4f4d-81a3-8e7ea5636e0c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aaf24558-8ddf-4f6d-b9a7-118218949e52", "0ae166a8-a3e5-4134-b56e-547581347495" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e1712d7-07d7-44f2-aabe-940b213fe66e", "4af82c13-2534-4116-a2f3-a23d3512a81e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "21f9f998-6eae-4510-b5c5-84bbef1a5bd2", "9fae756b-dcd7-4123-bd36-89e25d1e032f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6eab9963-1377-4b85-9467-33b03d953776", "e762dc53-d325-4d4c-a064-0c8895f11609" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d80bf8c-6c47-49a5-a821-94a740f4d438", "7821b5ae-15b5-423d-9ebf-1e63791a37de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c0919945-0480-43fc-9a55-486b6777be66", "4ae1fdd7-f58a-4ed3-b4ef-d353df72350c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7fdb2cc1-6f83-4e51-a459-1880fa43ae06", "43a988ed-0f2b-40d2-91a2-ed1d4cca322e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a2237fe-dde3-4637-ab32-728a044a0136", "876afd30-652d-4aa5-a10f-d5b598186abc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a19e5945-a68f-472a-8b75-170e8169c638", "639974e0-88d1-4112-9121-639d589aa6fa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RequestType",
                table: "TravelDeskRequest",
                newName: "RequestTypes");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c024158-e720-4e07-9a5f-c785d785e2e9", "e0330f61-f4fc-420a-9132-50b849604ff1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0da65189-b7f8-4898-8244-a9bc3abab0d2", "4aa20f58-5345-445f-8fca-b15910399d27" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "68847b79-64af-4a9c-8fdc-b2b5df1e7e37", "ce8886e3-6c08-4b4a-8d07-7acda63f48e4" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "51cd1a77-fa1e-4e3b-9d6e-41bcdecdfbcb", "cf15e4ea-7b9e-4964-8bfd-1482c4099741" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "323c8909-19c8-4be9-9160-3d7ebd4128b0", "e260807e-ca4b-4ed8-a302-d8718661ee36" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de12cc6f-ca51-41d3-9293-b57308ef0697", "a174a627-a5e8-4635-9a0f-9680b6572a55" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29969c51-e087-4ad8-a3de-5c0a5481e4f0", "7bdbb1ec-aa37-4013-bf84-d528ae00cb67" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fe63a207-2da0-4e8c-abe7-8c0961621f08", "82f5c8b8-3abf-46e5-afc1-6ac82060fcb2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d3552e2a-c8f4-4ed7-97a7-9b94e684f2b4", "780adfdc-9e21-45c0-a8db-6094a44424ca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b1c5d8c-d6de-494d-960a-9320e8763e18", "85592442-bdf1-42ca-b407-0de3ca50bdb3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "823d8f56-3a6e-4afd-b2fe-161c96ca2e9a", "95b475cf-3f19-43cd-a569-b5c915029e62" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cf327c0b-3ea4-4b28-8841-74329db51bbc", "c7b47bbf-71d0-4f27-bb33-23795e56cbe0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "84aff19f-71aa-4676-ace2-b7354e10d6df", "7fb10108-a998-46c6-9c2b-8d01bcdd3c63" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "58b613c1-648c-4c92-9cda-4d181f1ad0af", "42585205-c15b-4ab4-bb1f-b80432a26ed0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "080509f9-7ca4-4b1d-8203-ba78f6b394ad", "256ff565-5a77-4a38-beaa-48a51433503a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e534671-bb7f-4430-a540-9b86c38582e4", "0e227e65-d7a0-4139-a8d6-bd33bf9cc921" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd6a5019-e4ec-4cc1-8104-7a635245133a", "ffe8b965-c3b3-456b-979b-328941eab0fd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f177240-ba8e-4bd0-9ad0-c31770b70ac5", "ea0fa117-0a67-4a45-9125-705ba33ce157" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b2412304-1e71-4610-a208-dfe4b8454faa", "317c4ea5-9c0b-4e37-be40-5ee2929b3f44" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3436b661-e047-45b1-a707-04a2bdfbc2af", "7bc3c1fa-bed6-4694-be24-048c6ca06c0f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40208cb5-7439-4114-b8ab-6d6e05ec59e9", "2bc28346-3538-45e4-866a-64d5f2c192b5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e93cf429-7e97-4b4a-af76-422c476ee80c", "c329d907-4247-4a27-ab01-556c65777fcd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "932d3da8-144a-45cf-b27a-0ac7f8ac5a73", "8f559f72-654c-4738-a616-0f1be7f27b7e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0c97a2a4-021b-49d5-8532-e1a6c7e19fda", "b7df51d9-54b4-499a-b5ba-cb37feeeb5f1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6372d962-355f-4ea7-9985-5e53fe510c8d", "f00a0afe-57d9-4308-9a43-e83f08785a70" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9319e94-852f-41c9-be53-d4eb1f0e220a", "1b7c9ce9-9883-49a4-9fa1-8cf23b18dcf9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5c896cfa-8cf2-4ab7-9af4-8f565ce6c0c3", "efb2ca2b-10f2-46ae-92b7-550ea16d59de" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9021d030-1691-4e02-a78f-886c3baa7f77", "75c156de-253f-41d8-94d9-e9a7758f8a75" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6edf86f-1468-43bc-8e9e-a402e28f568f", "cf184ca6-8ae8-41b1-bada-d0b725030f9d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "789e4f7f-eb59-4327-8253-abd6795b5627", "1f8c1811-d532-4def-963f-fa7ed097e883" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8fa11db-eb38-4fb4-8521-955383d0c63a", "27ff80b2-9acc-4475-b1f7-dd4f48bbc92b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "347ead17-3211-4d52-9308-e189596eaf36", "fd61c02e-a494-498b-a451-188185bfbb89" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86af639b-dd3c-46d7-8081-638f9e437efa", "87121e00-de3f-4caf-b682-c8192a023427" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "11b105e4-e0e5-4df5-a31e-e4131f5946c3", "5ecf5d02-0bda-4863-adb2-78e5410cc00b" });
        }
    }
}
