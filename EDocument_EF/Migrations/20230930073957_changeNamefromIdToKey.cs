using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class changeNamefromIdToKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DefinedRequestReviewer",
                newName: "Key");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6e833270-334f-497d-84f6-9a0230479385", "effdbefb-b420-4eb3-a210-937a8d14418b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d02b74a8-cd31-47d0-a6a0-568f9080381b", "11dfd60f-fa1f-415f-bead-b3ada92a02c8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9763194e-7a83-4ca6-ade2-057cfce3ac88", "46f1865c-1c0b-4ba8-9a63-a59b0e71b5bf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c0f2ace4-44d9-4825-96e2-fed338f58765", "b5f91818-9330-47dd-bc48-5ef91cbf0a1a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0817d1c4-4a5d-4217-b20a-eb031af93d50", "b5d665b6-7898-4361-b4f9-61c50ea9057c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d4e3c581-fa12-4c14-93be-dded021c4f18", "37aedeff-ed8e-497c-a0a6-a766c69f9c07" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "365f5ba9-746f-4d4b-859b-1d9948662e0b", "cf988fe4-959e-42e2-995d-331b435cdd2b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c7dbf5d4-856f-4d77-977a-d6af522c0941", "db9344c9-615c-44f8-8b1a-ce31c2f32ef2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b28f30f-9ba5-4229-8af8-fe82d746a44b", "a1633cf7-c5df-4f92-910c-7696f1926d5e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b48a73c1-d164-4ba2-8316-bee7e15306bb", "6e1ef730-640d-4e44-879c-35db7c023e10" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb1bf4c7-845b-4d22-90df-af5f7de3a07b", "71736f2a-cb6a-4c0c-abbe-45481c0c0719" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1aa3e95e-8986-4da3-8103-46b9b3f88a72", "1a13259c-6592-4f8e-a9ad-f3ce393e865b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "80b9ada1-f6d3-4e18-9636-1a09772534a8", "f2048106-4bc8-4126-9062-abc2b779e905" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "840ce4ae-3114-47a2-a4fe-687042f00f81", "765903e6-b009-4c5b-8d2d-214eb575818b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dddcb8e6-a012-44bd-8fba-2d02dc11db69", "bcb6cd08-bbbb-497d-ae70-c750ae9ece98" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e6866f4-b560-42ca-8a4a-ea9441e3be5a", "4a5fedcf-3a1b-4327-982a-2398fd5f6601" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "696d6fc2-29f7-4c6b-8bd2-f412a6bddc48", "fcb480b5-7f09-49b7-b257-a9e7cbd99389" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29c6f27c-758e-4bdc-a495-f7ba3a933cb2", "c3625f05-7e93-4f00-8d16-824b5510104c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "783e5e6c-3cc8-4d24-b0f6-5c86af5595b4", "4d61514b-10e8-456b-a364-9236fb864dca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ea472237-19b0-4924-9548-45fed826548b", "b6dc0b07-efd3-47f5-ab2a-b0105e7b8cf7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6053bb81-c485-4a51-aae0-09cb3ab00b4f", "163ac9a6-5883-44a8-92e5-2eceb4177181" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "601f18ae-8ac6-41eb-afe6-3231b47a0bc9", "524cfd37-7e68-4552-8832-a7ae73dbae87" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e1801ffc-0792-405e-b66f-4a66b34bb486", "5d68b9d1-b698-4c68-8421-40ec1ffc4f7a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f91b40e-bca8-4f1a-a901-00bb36aa0bc8", "1a526b08-81ee-4741-b126-2d78e7035016" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10b98a2c-53d3-4a58-b046-7273e320a293", "3a4cf9d3-2f1c-4891-931b-f9a30d4133fe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3a33a368-8dda-4239-af99-bcc664051cc1", "0544074d-f11f-4cd3-99e0-1d6b183f4d57" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "533a0f04-2991-4a09-a077-eb0ea2953492", "8e7c25aa-75b9-47a9-9f0e-ad1d69a362da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac048eb1-3b72-44bb-b526-ccb0184c5adc", "1d730c87-e30d-4a83-b133-81585ea0497d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9fcecc5-6ab9-421a-a9d4-025747f011e6", "34b2c43a-8113-47ed-9336-17f750e456a9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a33fc55-6058-4a77-b433-a6c0cfede61b", "5eb2735c-3382-4ce9-8310-08037d6bea18" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8b22c1f8-8c2d-4b83-99ec-a82a73c2f017", "830e8fdc-479d-438d-ad04-e65acc8c70a3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b87e84a1-92e1-4e06-925b-09be7b8117c3", "fdd0b23d-03db-455f-883c-456a8d4e52a7" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4453ab6e-3700-4421-983f-9895760fd3b3", "c2ea7429-216c-4fe7-83cb-d3d1872fbefe" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b75ab0ac-bdd3-46a3-80a0-615dca596b26", "04d99087-1643-4113-bec9-c4a1ea4da742" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                table: "DefinedRequestReviewer",
                newName: "Id");

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
    }
}
