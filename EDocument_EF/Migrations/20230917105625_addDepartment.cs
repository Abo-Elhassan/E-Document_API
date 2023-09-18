using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EDocument_EF.Migrations
{
    /// <inheritdoc />
    public partial class addDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DepartmentIcon", "DepartmentName", "ManagerId", "ModifiedAt", "ModifiedBy" },
                values: new object[,]
                {
                    { 1L, null, null, "Administration.svg", "Administration", "50269", null, null },
                    { 2L, null, null, null, "Freight Forwarding", "90010", null, null },
                    { 3L, null, null, null, "Business Transformation", "51331", null, null },
                    { 4L, null, null, "Commercial.svg", "Commercial", "51573", null, null },
                    { 5L, null, null, "Communications.svg", "Communications", "51668", null, null },
                    { 6L, null, null, "Customer Service.svg", "Customer Service", "51229", null, null },
                    { 7L, null, null, null, "Executive Management", "Exp-16", null, null },
                    { 8L, null, null, null, "Finance", "51124", null, null },
                    { 9L, null, null, null, "Governmental Relation", "50962", null, null },
                    { 10L, null, null, null, "HC - DUBUY Sales", "51573", null, null },
                    { 11L, null, null, null, "HC - Samsung SDS project", "50140", null, null },
                    { 12L, null, null, "IT.svg", "IT", "51331", null, null },
                    { 13L, null, null, "OPS-BGC.svg", "OPS-Cargo & Bulk", "50354", null, null },
                    { 14L, null, null, null, "OPS-Containers", "50141", null, null },
                    { 15L, null, null, "People .svg", "People", "50279", null, null },
                    { 16L, null, null, "Procurement.svg", "Procurement", "51188", null, null },
                    { 17L, null, null, null, "Projects & Facility Management", "51659", null, null },
                    { 18L, null, null, null, "QHSE", "50882", null, null },
                    { 19L, null, null, "Security.svg", "Security", "50263", null, null },
                    { 20L, null, null, "Stores.svg", "Store", "50000", null, null },
                    { 21L, null, null, "Technical Engineering.svg", "Technical", "50136", null, null }
                });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "36cd5bb1-60b2-4d44-bc79-ac5f4e882a9e");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ea0e4bd4-0ac2-4f16-9673-7890dfc0d412");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "10",
                column: "ConcurrencyStamp",
                value: "2543e92e-ac3f-4b13-96a1-7426e5421704");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "11",
                column: "ConcurrencyStamp",
                value: "4dcc2619-0042-4c0c-b9ce-697c298ad01c");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "12",
                column: "ConcurrencyStamp",
                value: "e1036148-7921-4352-9c5e-4aef2b1855c4");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a78e382c-f10e-4150-976f-954d82f2b3b7");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "59b33b87-4e29-48c3-bf76-08f51a958483");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "f3f35d87-697b-42d0-80ef-26caa4cd047a");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "4d2c5c4f-2044-4960-b1a0-d50a37691acc");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "99347c41-3b3c-40a5-b938-cdb9e185615b");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "b71fe61d-c3f7-46b5-9820-3ad407824641");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8",
                column: "ConcurrencyStamp",
                value: "5833df24-56e2-49c9-aced-08bb670bf904");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9",
                column: "ConcurrencyStamp",
                value: "e0336eb7-fac9-4430-8540-d3c68233aba4");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06fa178b-16de-4eee-b2a2-24d875917a0d", "c5e0ea5b-9228-4d55-84e4-c7d78198bf93" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42c90554-5a49-453f-866e-ad2802e4e20e", "357dd2fd-ee46-4c0f-a804-c01a645c29b2" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a68557b-4799-4669-a249-0b95cfd85fbe", "f59b4f7a-21ef-4ddf-b562-13d7cf87017d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b265af56-9781-4741-aac5-bc0b01ac6dd6", "ff21bf69-4a09-48cf-9b2c-41b1bcbffd7c" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "79d8824f-8fcf-493c-b627-11ab4308ca58", "e3d18d2c-c5ca-4955-a62c-ae73a1262e31" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e756d327-e4f6-4349-ad28-e3430257dbd7", "54e9d2c6-2e70-48c4-b0bf-67b5101ec123" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c9922f4b-d0f8-47b0-be0c-5fef5a4b3c8b", "540d3177-85b6-4450-a505-9f6ef7eac5c5" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bce0d7b3-9565-4ad4-8719-855de3b57ec2", "0d4414d9-3b03-4854-835d-fa0b583e7434" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e824109a-e450-469d-b102-7fe4c0d4f1e5", "1855b5e2-7488-4d91-99f1-3e21ae311fd0" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13809916-8b63-4b40-a013-edd9155d8b7b", "7231edf4-8cf8-4e78-b0f1-eda243dc4bae" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0475cf30-5e2a-4144-a5c1-7bb729db59ff", "998b3e0b-5e96-402b-b777-6c43d90bbf46" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "174787ba-5abb-4d8f-9721-8d235116acc4", "d9671a14-2baf-48fb-a48c-8315e5169e71" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4352df45-f1d1-4bd2-942c-b9f6e69e139c", "1c1bbe34-64f3-4eb4-b8b3-274b8e33d657" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a394fb69-79de-49f7-aa91-714836276833", "7248baa8-1238-45f0-9956-a188d9df96cc" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d10cb85d-78e8-4228-8c2d-c4116458d04b", "c552dc31-02b7-4931-b883-397998886ca8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7adcdf52-51fe-4a4e-b17f-d428645fc8b0", "27dcbe95-188b-4096-95a7-01e3c4a39c98" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "af500cec-d3ae-4fa0-aabe-dc50fef653cd", "c593604a-ddc2-4f1b-b7db-434a615396c8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8af91302-a3b0-422a-a628-22b9184fe739", "777d6b91-ccaa-48b4-a8ae-741f7efa7830" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d21d352a-32bf-487c-ab09-badd0dc86e9c", "bd4529c0-9752-45e0-8972-026bd20702da" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6d65360-e06d-4764-8689-380cb86f5a96", "62b0343d-9617-417d-b0b8-bc48d638c747" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad759ec2-d49f-426a-a307-da1f648503c9", "f83ef5d5-9f0d-4cba-9b8e-8e14ef76bd3f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "65c63929-2270-4308-a302-84aee1358c68", "904de1ae-5f24-4791-9fb3-ab1c13d7799e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c29ba916-335b-4e20-91b1-3130d338ebfd", "9840fe22-c443-485c-b2c5-c677373b146e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "df7b2248-bd25-4456-b144-053cf655dc2d", "d7de3089-a463-451b-8bdd-296e7a65c28a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "73c81969-f0cd-47fd-b3a6-8462555b1ae4", "d11e29df-7cfe-4572-960a-6f4a98bcb4e6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "341cec5f-4441-4c6b-b34c-bd382fed7cea", "0931f13d-b687-4d45-b2ae-7575b627ce06" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "226ffaf4-4192-4524-a869-dd299a0f03e3", "f47f79ee-5b81-4502-941a-27d6e0307ced" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2be8d64-8145-4deb-9263-e9566c76b43f", "0ddf4ccd-8991-4108-89c8-9938e4b3188f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "528fd53d-803b-4341-8083-300066bf8423", "c582158f-f7bc-4a6c-ad55-7de5faae44dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d7dd1ab0-946d-4114-b045-8915a3c26e56", "cf5e4ab3-bf16-418d-a323-8b2236acd5dd" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d2ca0ff4-35c0-4089-ad18-ab150a899956", "dde4266b-92db-4d05-a856-b9d825bf74aa" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "91114fc5-8359-4a1d-95d2-f7acbc369b8f", "f6b02e69-62d7-4630-8364-47559c80a45a" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3263199-dacc-4534-9f51-e13def0da683", "20dcc7dc-a0f1-49f6-a61a-8d60dfd3553f" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93199ceb-5180-4405-acf4-c4625f00cd72", "ef8a472c-dba7-4555-8c7b-d583c552005e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "0",
                column: "ConcurrencyStamp",
                value: "48951c2b-5424-49b2-bb11-59a322f0db59");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b173405f-5b62-4c3d-bb9c-b3048476a0d7");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "10",
                column: "ConcurrencyStamp",
                value: "01b71d52-6250-4e3c-9f8f-f952528e8a7b");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "11",
                column: "ConcurrencyStamp",
                value: "d866a4bc-4d70-43a0-8920-1d7a68503b50");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "12",
                column: "ConcurrencyStamp",
                value: "2ef5c223-3932-4a48-acf5-877d7ff8f851");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "a87fae3a-f708-4c30-9461-b7d6a45a0235");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "54e00492-e92f-4489-b896-3b776958021e");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "7fe48c76-a9d0-47be-9e7b-1998f1dbc8f2");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "5",
                column: "ConcurrencyStamp",
                value: "4566daf8-fc6d-4e02-beb0-9e227c125664");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "6",
                column: "ConcurrencyStamp",
                value: "b9d0c28a-85f5-4ca6-b543-e2049dc2eb83");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "7",
                column: "ConcurrencyStamp",
                value: "f3cccecc-38fe-4afe-9514-0812bba61bc2");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "8",
                column: "ConcurrencyStamp",
                value: "5ef33217-44cc-4336-9669-78e4d396e85f");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Role",
                keyColumn: "Id",
                keyValue: "9",
                column: "ConcurrencyStamp",
                value: "e4b0bdf5-b75e-4688-a826-730027085ae6");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50000",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c86cf659-0d0f-4baa-858a-7dec176f4bf9", "cf3f2dda-64ab-412e-bb0b-4b59702512f9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50128",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e36fc97b-43a6-4c52-9a68-ad6859fc9453", "38e2f95d-ab48-431f-894f-fc0a1ac6dcd8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50136",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d644f55-d8f4-4d50-8b2e-5a339ab16cce", "e1434e50-6681-4e1c-85d9-89bfd87aba41" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50140",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac3e8cb0-7d5d-4ef4-8025-f1272c13bc31", "92fafc66-b64e-459e-adf6-a94a56487be6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50141",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "23dfda75-d79c-494f-ad9a-66412e4dcfdb", "3e5d467f-1f8f-49f6-83ee-1628f14179bf" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50263",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "13bf6c69-72db-4e1e-8e12-6f64d1f468c3", "e6f4e702-1c71-4b25-af16-eb23aa9b6f1e" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50269",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7208214f-6033-4a8f-bc8a-255eabad47b1", "96f45b55-963b-4ae4-9efc-861af47f20c3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50279",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "119eded4-9bbd-4eb7-b51f-20fe2f3a1624", "d3e5b53f-5a5e-4f18-81ba-b758561fed37" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50354",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c707b8ff-4ac3-4010-9090-860f1e840c28", "ce53bfdf-cb42-417f-a959-7102bc50f317" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50562",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1290df9b-db7e-4b63-9890-b3246ec70623", "d8a601f1-61bc-471c-a315-7a9bd56211b3" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50670",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "214ecf28-89bf-4f20-9757-8f2538027b41", "2b7f0d4d-5fa3-4c9c-af37-3f5a385a82b9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50844",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e3763678-8e80-459b-96fa-ac70254688e0", "2df2e256-82f2-45c3-a314-311f78a277b6" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50882",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ebb4e62d-2064-46a2-b341-c3543645a972", "f8564abf-b1a7-43bc-9ed2-f1a38a4648ca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "50962",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cd202e23-df11-4c5e-a357-7f80133876a6", "34b02086-d6da-4ff1-bfdf-e91ccc86fde8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51090",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4f979eca-47c8-4f0f-a8df-0b4d7d8b3516", "f2376464-9c20-44e0-948f-71856fe3f67d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51124",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "17323c61-b4a9-4802-80af-864c1b275dd1", "fb481b1e-99aa-4847-8386-48f34243f4df" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51126",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "097e19b1-f82a-49c9-a1fb-df5796749e65", "a87cb57e-f174-4569-b9f8-eea8baa3c9ca" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51188",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c8f81500-078d-4e04-8493-8f37b596b165", "bd4e4698-f348-4c9d-8081-9d7eb1083650" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51229",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46b34b1b-d36e-4f76-8154-215b451e1378", "6707cc01-1942-4616-b608-a9862c7c0939" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51330",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ede9698d-bf4b-4a81-bae6-75c6fa6cad78", "318b5509-f5ac-4e69-8be4-875799958719" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51331",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "291e4edd-5d05-4cdc-a8e8-de5540f383e2", "a7864c75-38d6-48e4-9c8b-3489a7dbaa10" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51449",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab05d3fa-2272-4b2b-b063-a16698e1486d", "e3549a1a-0153-488d-a244-2ec67fc51c64" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51509",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "10eacc73-fe81-4d25-937f-f5845ffda1f5", "4efd8aab-01e8-45c9-896d-f725bb19376d" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51520",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d354ac5f-aa60-442f-ad8e-294d92257741", "20a60de7-4cfc-4e7f-9299-3ebc6158f078" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51529",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d11a3895-ecc4-4e43-9b2a-944c252cf0be", "6666ddbb-b410-4fd6-a962-0de53005bf34" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51572",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2f8c9cb-a9f1-4e00-8ef1-4fc83fcfff4d", "757f0244-d889-497a-9a4b-1b3fb7bad0b8" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51573",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "33b23c09-a0f0-45ea-8568-25e84a5fdc74", "aaa981fd-1279-46d2-b755-94f61b516904" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51583",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85fe4d90-cf3d-4700-87bf-c16b7349e830", "1cbaedc7-9b6b-48b9-ae97-f980f40c3fab" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51659",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8df4fa32-2910-4851-b146-8f68addf6966", "c810083c-b522-487a-8956-e37cc76a161b" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "51668",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eaf50fa3-437a-4865-bb5e-36135c543380", "da7a1ec4-aa1f-43b9-a0fe-9cb7ed908508" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90008",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6dc01719-0507-4a9d-bbb3-896024ea65c0", "d23e5916-4e69-4fd3-a9c4-8b32730064b9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90010",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ab2b87ea-8e6f-449a-b210-99efeed2f0c3", "9f9c6432-3a3b-4911-b09d-710f974c94e1" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "90015",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ccd7fc25-49b8-4df2-9418-7b7a7dde9346", "aea43f1a-4f59-4311-903b-9d445fc11bb9" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "User",
                keyColumn: "Id",
                keyValue: "Exp-16",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8d166554-bf39-4e08-beac-514cc78e70b3", "04eeb9a1-5a2d-48d7-9974-2619cd6d6cb1" });
        }
    }
}
