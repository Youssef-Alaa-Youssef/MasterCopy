using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Factory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "IconClass", "IsActive", "Name", "Url" },
                values: new object[] { 10, "bi-people", true, "HR", "" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "bb361159e7824447a19cb92a7e87a4da");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "72bab28bc9f946199dc0d0af9f17e9d9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "1d6e55fd1a0442d7b77dcbfdcddbcc5d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "65bb3adef16a4640b898036916ca77ae");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "0a79a058c6f24aae8a5d99a248fd720e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "01b2f5c6e4084b4a896183f9e2508a09");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "e2b000e5aafc42ed9eb51cf6be023a6b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SecureUrlKey",
                value: "b7419ebd9b464381a350d3824410e336");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "7c73478de7ff4514a39f0ac3d7703d5b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "a5ebaaf9c4bc4e2faa5264f3eb0e1424");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "d767167f089447ddb0734f7a0c2394c4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "70ef420532514d4ba18c1a5f365889e1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "899f17cdf00c491aa909b6e549487096");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "7f28a1aae2a44899b9ae98c472f4d55c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "2774fb1edece47b5b311325f0d0529dd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "67b0d6e376ca4f1cbd9583a9db0c4d93");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "9bda9682e0f8490bb9d3a0b10343abae");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "5a2a839af7574eb889a2ba80dea0575d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "934888686089422e885cf54ad3ebf7ea");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "1e946a5d419e48118874d5123e925bbd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "60c8bdcda448481aad0a2e6aac47a9ca");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "f3168065c40647de8ea0cf32ab3040c7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "e12903d7b2f6428c9dcf9fdb9baffc06");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "b3c3ab1566da474ba61bfc4d5c5d2083");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "c4f18d5448974adabc9fb4f8b7249917");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "a7f454c1d9b14db0852beae27c73e2bc");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "08306429a4374dae9c34d26a71f1753f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "e96359fb6c7d4e3aba2df456c57b5970");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "b0a7bf6736b8476bb4c8497c1384a974");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "76c98c77a81743f4addf79d12dd70589");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "6d88bd729c40403987f96c6e115058d2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "1d8611c4a3e24d1dbbc57674b2770f6c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "157c74b8d2c843fd9ae3eccf54132753");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "d6b3101719864b808eb843f387c19166");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "6722d1b4909e4517a3ca1f9c799f5d1d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "b89f235e33a8436bb458668ce177051f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "f024ec8f4808439880b5c876e6fb5447");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "65b0a30c94664f82bbdd230b7d7f62b3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "0b3fef8f8baa4574879b4a248afb027b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "b84c61c2b06c43109eceb0da2b56eaa0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "bf6f51a1f3ad469d8f3a84c779e4d7e8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "f14347e2e7d64c078ef3dcfc553ecf7b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "701833c220a34a178ebccd59cb046a9b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "664fc5807b99486aa5c8ebb59646ca7e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "2d4c425a598c40d0a14630d27f9d18a0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "92bacb679c4848439f5ee4e62ab519d1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "402b28222d0b4de3abf4720c40579dea");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "4889bfd1a13e4ff6a4b1e302f7c0550f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "1590692044d44d8ab938ae4bc627936f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "0b53f650beb447e89d4f8cc14d8a7877");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "09c7d3aaf9b34eab905f5542d16f672e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "0937a5c9eb0d424a92bd9b21d17f919f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "c2d5a4c2cf31466a95390a196990498e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "9c7e4575faa746e79689c595f55a870f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "b9c237bfaeb84f7bb36a9034d2e58246");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SecureUrlKey",
                value: "0ecd49ebe75a4214aec523db53a85899");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "24207c8cfbd44eba9ceacacce0e93bd6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "ba3e8f1051144a0ba7d3844757d69528");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "f08b8fa9866d48d3aecd67d19c74adcd");

            migrationBuilder.InsertData(
                table: "SubModules",
                columns: new[] { "Id", "Action", "Controller", "IconClass", "ModuleId", "Name", "Title" },
                values: new object[,]
                {
                    { 19, "", "", "bi-person-plus", 10, "Onboarding", "" },
                    { 20, "", "", "bi-person-dash", 10, "Offboarding", "" },
                    { 21, "", "", "bi-bar-chart-line", 10, "Performance", "" },
                    { 22, "", "", "bi-person-badge", 10, "Supervisor", "" },
                    { 23, "", "", "bi-briefcase", 10, "Employee Position", "" },
                    { 24, "", "", "bi-building", 10, "Department", "" },
                    { 25, "", "", "bi-calendar-check", 10, "Leave Request", "" }
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Action", "Controller", "IsActive", "Name", "SecureUrlKey", "SubmoduleId" },
                values: new object[,]
                {
                    { 60, "Index", "Onboarding", true, "Onboarding List", "2936a72ffdf14c92a1fb61038b638186", 19 },
                    { 61, "Create", "Onboarding", true, "Create Onboarding", "02c8d8eacc9146fda1ed01a23c022e57", 19 },
                    { 62, "Index", "Offboarding", true, "Offboarding List", "c25b0831902744b88810161762629793", 20 },
                    { 63, "Create", "Offboarding", true, "Create Offboarding", "3da774b08c7f41308fcae245b77b3f8e", 20 },
                    { 64, "Index", "Performance", true, "Performance Reviews", "5e638d33535547afacc2b4c8d81a501f", 21 },
                    { 65, "Create", "Performance", true, "Add Performance Review", "b3fb940e4fec4e0d95d355fda8d8e074", 21 },
                    { 66, "Index", "Supervisor", true, "Supervisors List", "e5089ab6b9da45c2b52852365efc6087", 22 },
                    { 67, "Create", "Supervisor", true, "Add Supervisor", "8e552297f7854e519dea9d854ef592ab", 22 },
                    { 68, "Index", "EmployeePosition", true, "Employee Positions", "1ca86b277fcb43fdb4896adf352fb804", 23 },
                    { 69, "Create", "EmployeePosition", true, "Create Employee Position", "402dccf116ee44aea2a33d91d9f88540", 23 },
                    { 70, "Index", "Department", true, "Departments List", "4b1db9c8592f44ba8f4570716c01c65e", 24 },
                    { 71, "Create", "Department", true, "Add Department", "4e463f165d03469f97137778ad3bc811", 24 },
                    { 72, "Index", "LeaveRequest", true, "Leave Requests", "6d63d3a6e74f4e8784da30a519f66c2e", 25 },
                    { 73, "Create", "LeaveRequest", true, "Submit Leave Request", "39160977aac048e0a4fd64a6480ae15a", 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "74ceb219a1de4931aaeadeadc4f8b587");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "0be55e2eefa44f1381d7f7fe4a796b98");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "f507e9efa0a1486bbcb3bd0e49cd3e61");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "ed618d4864bc43308d47f32c2260548a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "6282aa38b3b34339b444e015bfb1ced7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "a5098db2910e4acb8590fd54f014ffff");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "323d3e4b11024b5e89a9f0ab7a5f0c69");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SecureUrlKey",
                value: "f536c0c97d864b9e8b04f5d77d25efff");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "c51e22541085469e9a07fa7ccdf340b9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "4c04a97043314a549efb85f7fea88f94");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "6822a5bab5ca4f11a2ee4f6a2580b368");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "90663f87b0414203b7784281894d95e6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "89c325b03f454318b4aa2031f52d2623");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "bbf54deff791486db9890ea42b2fb7f6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "983f6fbdeea84b35b33d6a4493b5a78b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "74052815dbbe4774b3cc73850d4c10c9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "9e6b7a9b3ee842b6b8569e22bf381b20");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "d2eda3adf04d4bd4a1063cd1883fb73d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "d517abbaeed843f19a24d6e2f1d2393a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "709c45fe8ad64e9d91864e3aab18364e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "36d11e08147d4d819a39b5c21d8730d3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "d7600d04d4b14975a5af5a5d2c51fc4f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "122de83fd16a4a95ad08aa4d7ea9dded");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "39a0411e5f4144b59a3378dad79fd6a1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "65acbab177d74739bd8583c1a1c53d63");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "7a5434eeb4e44105b66ab6ffb0517b73");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "2a9d343c13564986a189aa9c998de765");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "f3c8455d1807459eafe7283baca075e5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "26123cca9662416db6883b345a28d29f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "d11bd70ea55b4ec49a88cf8a25717869");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "cbeca4f6ed2b405db0e62a30f01f84ca");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "bbd1a63ecead49ddbf69d5b726942999");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "3cde620898024689972381b8fcd394e5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "66bf747d391b44a8847fc085243813c0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "0d223416e3a64211ac092d377be6fc46");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "1af7c32360c241a284da2fd0b14ff1f8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "7c6ff9643ecd44808cf323374cf819d8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "70a04c3642934b5289d0e3a9af701d52");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "49c4ba0d3a79432690918ea8bdeb6374");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "286697e2236849d28ff3f1966d889ce5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "9ecae7ebc8c242df9f09943177b43285");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "ad5d8dc4b8ac4429bf23488502c300fb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "6958743c8ca84dd8bbaf4aaa72074151");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "168c350c15f2461988e9bc9704f42ee9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "18e32269fd0b4aa0b92bcf6220f64a70");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "857204cc038346faa52d7deb68e9c6da");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "9bdaf4694ad64c68bb617711a016afaa");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "f8eae4cb6f6049a8a0e437278e8f5324");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "2d9ceb5ff43c40318bd603cb1a4f6799");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "35927534a9654f388b0dec3a5a2096da");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "7272629935444050b16fa2a8f2981d76");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "bafb013cb54040c6a01f5886b32f7a9f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "eb6893ab1d074e9ab3e86fb396fc72b5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "6040ff5b93fa4e638074fabc2ffc22e4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "547053519d1343bf9a76551bbb3d4f1d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SecureUrlKey",
                value: "74de07aac4684ee9b4375072f126648a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "b05447b26a4d44e5a40e1e8ab75070c1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "917f24bb51f04d07abb2a66f8bf51c23");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "57136dbd633d499492a9f83d3b395afe");
        }
    }
}
