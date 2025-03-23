using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Factory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Addsomepagesintonotificationmodule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "IconClass", "IsActive", "Name", "Url" },
                values: new object[] { 11, "bi-bell", true, "Notifications", "" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "e1dd8fd821fe4e3d9332be20c8ed07cf");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "f210f8518d1a4ff385b52e8b6be07d23");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "7543443928c24fa2ba6788f64119bea6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "be154e5964a04ca8ac45d9ca81514907");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "eb8ae70169fa491c8372a8069e7ddcec");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "002a3a828ef442e3aa6cf838f7538ad8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "a00177c2497347af91b3bfff54bef9b2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SecureUrlKey",
                value: "f22bd8eb6e5a41ac984eaddcac0499be");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "54834fb79b684877a06c1ce5d4318389");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "4e3232044cc64cecbd3e5abf1a4cc586");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "5e6414ad468b40a6b67f9c1d56c3d218");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "9f857309b9514515b05721d422fd65de");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "48226b366ec94c25820caf601d93f1b7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "8b1f6ff03bc942789ca13f16b2895d57");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "40ca9addc6ae47b3906ad08b3a73d701");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "e0345587e942405886c9f80501b3a252");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "da49d9673c6d4fd19b113e59ead29263");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "7d8fe43ec4644d0591f8a0809b432332");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "eef8afde864a49839c94b3a43b91584c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "844f8a34666c4ab2b5b6e35c1ab4508a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "0754e9f549ef48c88da22d1ed29b6106");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "cdf0887c2cc741f28722da5fe8e81693");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "8e9f310be1664cb7a6eb83c16b0d8183");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "a1a191c661104d1c9c96221a4aa4b8c4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "b0ae741e2b674e1b981bfba13e2f03a9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "b99565868a2d447c803ead00bdaaec3d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "c9f28c4f8c1a4e6abe69d710b9f8e6fa");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "ea3f8ddea159499c9111d5841c1ffe00");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "13c9ebb2471145acbc229756aaa0ca8b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "70c43cd2b4c44e9cb52fd847afece67d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "d1c4399256e94ae29723a59fce276bc8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "2cef57b83391494da3cb9af8b84256ca");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "575cc93846bf46e6b23d0bd52c6e9567");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "5542a606f4bb48c5af6ed5eaed425615");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "ef60060775c8477d9d752e89ad3b00d9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "979bd62f6aab42fe8bddc335d45b494b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "5cea906901df44c48e290e7f41f9c8c4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "ea40c0743f904c3aadd89865d05eb46f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "4122ebf2f1bb4e55a90e9aaccea8069a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "48643c8227f2431dbc9228ef6e0486f7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "764af792f9534519b9ef187401117d09");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "beeccf07aeb544faa5a78e531032d8eb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "5b27432b572f46dba6b8b5ce6db67c4e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "119ca0b3246646219d1bb0f71f6bc176");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "ebe775abf3a94b80b5771c23d4bcf8a4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "201400b32a1a4c72a6ea283fdd6a4861");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "a280f277b75744d19b4e809081e07a0f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "5a28004f8e4f4ef8a8df64f94ccfda3c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "c2bb36330c834888ae69a350ef4e43d6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "2dcbc75f8fe34ebab3158d261685c678");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "82936ad031e94f648095ac1525a267de");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "fc2f53deb6b54d80bab43646e9a3e31b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "42d287e9766c40ffb56bc7ee3cb23a2a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "76d2ce7d46bc47ec876074ee4b71dc1a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "a624f5f5fa5343c7a4fb730b7382b4c1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SecureUrlKey",
                value: "2c85f99d18594f0a840cd1637fced821");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "55a65c00048346129a2d631499eeacce");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "9e1f9f0b91614259a8e4e03271b8abe6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "c9f0d1b0d94d442f8a1d666b328a8788");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SecureUrlKey",
                value: "ccb0b0373ee44ce59af9539f5443a7ec");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SecureUrlKey",
                value: "289fe855779044d49cf1b9e2a9796d05");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SecureUrlKey",
                value: "98b0d632eefc4969af1ee20f066f5be9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SecureUrlKey",
                value: "14482f02833444e68b3f15f71b2b17ff");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SecureUrlKey",
                value: "6d636e900173411cb687d9d67418dffd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SecureUrlKey",
                value: "d8dff33a122047b8a0701570bed6bd43");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SecureUrlKey",
                value: "89a035a67d914336af074802475cbe19");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SecureUrlKey",
                value: "4e764a30e3b445fe9103d8180939d722");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SecureUrlKey",
                value: "a368b309b1564f4c9812913939f25518");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SecureUrlKey",
                value: "857412518e544f928a32af0be317e007");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SecureUrlKey",
                value: "e16e6d3460b145a1b46a63c8f71e87f3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SecureUrlKey",
                value: "76873ed2af6c4f04855aa468f35d6f5a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SecureUrlKey",
                value: "7cbf6febcd51489491f92ef0de5da11b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SecureUrlKey",
                value: "6941d08bb79041fcaf93daff171a7d0b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SecureUrlKey",
                value: "4abaa0415db149ad96fa0bf9bf853eba");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SecureUrlKey",
                value: "3ec849466d5c41c789961758d2620907");

            migrationBuilder.UpdateData(
                table: "PermissionTyepe",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Read");

            migrationBuilder.UpdateData(
                table: "PermissionTyepe",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Create");

            migrationBuilder.InsertData(
                table: "SubModules",
                columns: new[] { "Id", "Action", "Controller", "IconClass", "ModuleId", "Name", "Title" },
                values: new object[,]
                {
                    { 27, "", "", "bi-megaphone", 11, "Notification Service", "" },
                    { 28, "", "", "bi-gear", 11, "Notification Settings", "" }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Action", "Controller", "IsActive", "Name", "SecureUrlKey", "SubmoduleId" },
                values: new object[,]
                {
                    { 76, "Index", "Notification", true, "Notification List", "65e331006b3042eaaa866f4a7ac29461", 27 },
                    { 77, "Add", "Notification", true, "Create Notification", "2f50dea083a745449c0dbe67d87e492b", 27 },
                    { 78, "Index", "Notification", true, "Notification Settings", "960b9a44d68145589a901d8d6282f005", 28 },
                    { 79, "Edit", "Notification", true, "Edit Settings", "f6eed4886b3e4f6891fe7b6d15096470", 28 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "a71074db38724b1abaa82120dac9ca1b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "7abc95df855240d9823370daad4014e8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "53f1fec99b0f42e18e60a846ad8a82f3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "ed960098a8cf47bba995962096110aa1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "f1d6c7c55c53487ca0f81ef337c3c1a3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "d0b9ebb3e1314b7295e70661eecff936");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "f8a9c4b1d3d94a0e8d99880fe0d60c3a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SecureUrlKey",
                value: "05fbcb0760ec41858fdf7492f456c02f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "350ee71bc85846d7b89f654ae3f3907b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "d0c7880383dc4f79920e8d990d4876fd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "d7a1ac963f38448f85f68d451ad6c4cd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "11a41f0e7df34ff0abd55f18f1fca66f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "9e88e465dd0a411bbd7c3fdf933ad2e3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "cfa5ded0373a458aafb237a04c8f99b2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "f4405b454cfd4003a39d5b5c6eae0150");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "35f6497bf9b44823a0b68fa1d8bfced9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "359542c0d4ae437aaf60b2a550e578f5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "d8b157d0ed2146e5828af25049a8d104");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "4229a99007294271a0cb6a0542b62559");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "3139bf6a634745d4ae0ff365e097ee0c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "dc7e8c6198524d13bb76a1fa4664e8ca");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "893563a22c104a9797838ca7581f9af9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "6961c9e1846d4f0f9b4a762a8ed7e934");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "9e6ba9373e694fd3aee232a0f4bd87da");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "c1809a0433e14900a43509d8bb7f6edd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "77ac24f9ce0f4fb9abefe6e4702f9eff");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "0495ce347cd84cd3afb0c00940197144");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "793d5b11ee3c439e8cea81215429e981");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "1096ded3d18b4280b407acf382944b97");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "3d45ce4bf117422dbfb48528070f7a9c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "93a4a72434bb49e3abb2aed0cde34b95");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "c8f0b7b29ec14c8d9553001e01128cd5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "2e3cc6f61c5d4761a35817983139af08");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "480e64c71bbe4f4795b30e2c3fda29af");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "40a258078d13410b9c5a5b1a9a925fcd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "b14cfef6816748fbac9995e80d30d2d9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "848a25d097cc4530a3b732bdb746c04d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "c09d640359e54fb6a97f4cf6687286fa");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "1a93c664f0df4340bad9cb3af96000a8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "063d0148395f4e6fb9de9a2f31f17a91");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "4a134956175944f38da63de2f2851480");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "23ec900d7de4433a8d94b46d4fc1735a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "9d0c9a2f45764faa8915e191311d05fe");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "c3119fc32f5244b5ab96717399a79e9f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "205100ad1f4541f9bd617e4a3d898a2a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "4c79dd55d58f4884b1d3787badbf5d01");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "39b85f96a9ec40eca17e9cf0d893c276");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "8386656a3f8244be9d7e60feb3c5d337");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "cf87ecb94a594b14b2067130116aec15");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "c970994cde63415e8e8f30333c153611");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "390d043aab5347d78cb21cf822d53a71");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "b598f4efff914b03a2c6c0bc21dbb3b0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "b2d4a67eaf06460d8c3659a30f1e9878");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "a8182c01664f45c3a9bb89273f68d755");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "dddda46145024e8bb8a19add9015736a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SecureUrlKey",
                value: "4661b43e1ee740cebdea8088bfdbbe1e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "0799663cc0e04ebcbe916411d52cbcca");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "cf1d53cb263341c89b1df2a48d022155");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "b576f9b616684b2cafe1f5108dd48582");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SecureUrlKey",
                value: "b038ff0d17da414988f46aeeb0067e68");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SecureUrlKey",
                value: "8b030d0a3d5a48019bf0e90299a10e20");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SecureUrlKey",
                value: "a5c44af338e24233a91245653e5a18e1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SecureUrlKey",
                value: "1e868cb3b5b94af895e42be9dad7b09a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SecureUrlKey",
                value: "08f4f82802f24b3380130c63e5ee547f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SecureUrlKey",
                value: "183391e0915a4a97ad365b87237343d4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SecureUrlKey",
                value: "ecaceeec9f574e3383ee43b89f86783f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SecureUrlKey",
                value: "0dbeeac9ad234aa799e82fd98adb2b9d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SecureUrlKey",
                value: "e56eb15af37341d2aeaaee3d10d6e9cd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SecureUrlKey",
                value: "49d0d74925c94a30b95eb86c9528252d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SecureUrlKey",
                value: "9039422c05e24e3c8fe8cee92023e98f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SecureUrlKey",
                value: "6a69a431720044ab974caa38f531aa86");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SecureUrlKey",
                value: "252e8201e7694da199e32260abe07539");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SecureUrlKey",
                value: "7789e378a246489786ee366acb23599f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SecureUrlKey",
                value: "b3e4cf4c241a4307b293e33be62c853d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SecureUrlKey",
                value: "c03243c4eefe416680423e8354f64cf7");

            migrationBuilder.UpdateData(
                table: "PermissionTyepe",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Create");

            migrationBuilder.UpdateData(
                table: "PermissionTyepe",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Read");
        }
    }
}
