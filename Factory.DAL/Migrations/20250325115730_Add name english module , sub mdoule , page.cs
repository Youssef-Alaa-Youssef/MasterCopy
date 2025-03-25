using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Addnameenglishmodulesubmdoulepage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "SubModules",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Pages",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Modules",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "1995412861244c0291cbdcfa37be3865" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "8ec6c470286746beab4ee1e2e9c00abf" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "5f601ff3872f4c71a39363cf00fbc2b0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "fe74bdb7ecd74f8fa20f7c608209edfc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "10ab49f87c8540d7929a435dfe8af233" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "3cda0828ed5547fc809523706f454ab7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "55e1b2fa6d434cadb26500a1b409239c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "f9fb15a9bcdd45b5a2fceb3be00be6f6" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "950b7baa23e24657bfcf958dd7adb702" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "12de5f4b230140b2b98b343c5780b34c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "afb0b99f67f04f73a87827f1ff381b94" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "665629c1e01b49fd8389e982ef98a743" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "43a6842c7ffb447da0b1ce13a55ee2a8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "de084e2e3736445abfc698701ca6df11" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "074caac2cabb4cb88bca2eff3e8f4efc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "ea874983d2264ba9a21708f3aa281aeb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "a0747ea70b4048dd92b808ea34051086" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "441f8f8999d843e48a280d933e2bb358" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "3a226d93f904444b8b6d971ae042bf11" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "d7813623c9d14ed189e924c2202d1087" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "862bf0eaaf5544f0b9242972eac5e3ff" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "20ceadf9e04c492484b12d5a51f458aa" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "02d5fbbef3fe4716b2cb61a798b8874f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "18c12cba925e4ab49f0a529932cf0bd6" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "f1574c8bf96245a3bc6b9bdcc9c84d5a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "e8ee05180ed54448964daa9bbc250934" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "f8134f1f7b2b4b288a8503259af614e8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "5398a7864c10414192b04dff780eea19" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "11577e6d951c4bf0b2c167a6404cb1c4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "9dedba009d3a469395bffd174c7a0009" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "497c9d98b6754bf9908934d3e340b349" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "77974f35edbf4cdea39d9590cdf8fe89" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "8c55cf914d8d44c184322b925cf7b1cb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "9f0f00fad50a4231a1de8b591452001a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "8f3f2d878bc242d5adccb059c82eeb7a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "308d288e67f9480481022950d3feaaf7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "89c6de637d6c40528c4ebd80db43939f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "a26dda38cbfd4b3690b34b3f146aa74d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "9a8d6de28f06412db55700974916aa1f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "007419236c434dfcb2b5ff9234a5a319" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "c5f7b8ca54a649069257a07d87e75b07" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "beefc8f4e4074878a06a594846ed143c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "b70d3d520fb94e989ba08f5f593b6a97" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "3f8b60387e8d4d7f91a697ee64a2fc4e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "598b0d71fd42470f8ef43e20841e1732" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "bcf543f4f96d477690887368b9a13397" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "a2a6aba138fb41f6a954f9d02413bd0a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "80951403962449299385203678e539de" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "260bc65333b94a1ba5fdd71bbbe25176" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "b1eb7d82101d43a488961798bbe68b45" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "676524865fb9486591be9b81e39ef5a7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "50925173278a40829f6947f6fce5d14b" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "b828d6c9b3964999b7c301474adbe038" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "7dc9203cd68c4b8db92f3ab6da2526c8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "ac8e4fb201a847c98eecacfbbd6ca8ef" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "6ee4ed87664842d1943f067afc685e8e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "1a0a1e5ff67d47249c25150b5cf92fc7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "a45db2a3e1024217ad31ba024cd250cd" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "482c7882fbd940f99bfd141a3defb0d6" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "94ca17acd8334110808d9fb43577c4bc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "31fba01df8e543d39114a87d709e2ae8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "987cbf72547f4a11b2ceddfdc39baced" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "6ac59e1913904054a2389dab643a9306" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "9ed52f9b6628404e9bc35e6a8a7579e0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "3422fbf52fc94415b7cf0b50153914c2" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "fa4dcfa9698f455186526a44c06da791" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "47bb988a977c43ebb88ab5c8f7ddc528" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "d890af694d454e699a56fea83369f149" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "4c4d39b7333849b68eee07ea24093c94" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "cde8240f27154fb8895d7e0723502743" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "d8291f45b67e4ff7bba1c2d99a0d4699" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "38257889456d4e4c8428d8d806a73695" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "05cc8422f5b747218f5888d828801f96" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "ef025226cbec4ed9ada671696021f7b7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "88af98cb0d034db59ab49b2ba3f8ed5d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "92205f09df5e4f7195169a6d75182fee" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "c01ca9cc7c524dd0b9326295a5226d06" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "11257e8bbaca450a95dec8b328687b48" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "15690e6f6dba4a99b88f7fbf9f7a0593" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "96e6e5994fcd4224b57ee2a16c5e5fc0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "f081fda9662647c1840fd2b0d9e90924" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "3c8ddb8614f94bdbb268f3779e7342fb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "16c70abd225e4c428263bbbf55afea65" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "f5f7c3ab156c43ce84bdf5945163447d" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 1,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 2,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 3,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 4,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 5,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 6,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 7,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 8,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 9,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 10,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 11,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 12,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 13,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 14,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 15,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 16,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 17,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 18,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 19,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 20,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 21,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 22,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 23,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 24,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 25,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 26,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 27,
                column: "NameEn",
                value: "");

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 28,
                column: "NameEn",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "SubModules");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Modules");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "fe8cab76723e4c54bd7f3ea28dfd01c5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "fa8a2c87aa0847a0be0e743be624d771");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "306ead00374b4a34b8a365256c53c3e4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "7e38f4cc5606431fb26ba3b1b96c8970");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "3a126a697aaa415c83b15cb6c3c64ea3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "ab2c23766d814d51a31c60dc0d0a88cd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "ea554a2914434e27acf02b8c60da601b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SecureUrlKey",
                value: "f12dbdd813e14460835d7bcbefbf2ebf");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "821ebe14704c4a53867770308c5cd432");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "e4535ac8b6e24662805120895c0b5013");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "7b798fc6f3e14451a0a6311f16a24dc9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "41e269ce5c7b43dda59aa97945d59f6c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "cbc6e75346e94316bbb19079928611ee");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "e3442c63ae8a4633b4c47f64fd32ecd8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "3676993075d742ad98c0ef9322fb252d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "3d1db1c339f04b51a3b27b387758c514");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "8158a3825958496cb90d8dd0880a6e5d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "71e72fefa5c54f718dbe7ec72c1ecaee");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "e1d929fca7a34277a09084a48b3763db");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "939e1818a16c4ee48885ef4218dbe5d4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "f31353a0477c46a89d127c44c3d097a9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "d2d5f65744c647ff8aa2725858deba66");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "25d5eaa7abfc4716b56f3803a1c68cad");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "6d973f10afa14514a36489b3b5c21c43");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "f84ba095826b40cdb1c3f9168f73c7ee");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "f420a9a42a224c3aa8c5a2d49469e14d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "72fc5d63dc89414bb84e342965255256");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "7dc1e37ccdde4136a8ee2d0e0b7e746b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "c040d31f3c254a4783ea942c2e6655ee");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "a6d7187180234a60aa98d117f121c09b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "54441e500e6140439b70df7488920865");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "e99bed12101947c6b80f61775d835f96");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "e05fac212d944f2bb2c5406379f766d7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "0071bb42a49e497c95387f1519274add");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "7d95a1abebb042fb85b069dd748a5565");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "8a159a42af5b4062a58c73f00b6927a1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "6a7240c899804d1bb5c3a114001e034c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "bd738642b86942cf828019b078489188");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "bb8124d8158b433da9a45522f14e396e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "bf66f11676e74be7b87617968981f62a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "9b9f93718f8f4fc8be6822c0e200fcc3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "59d6a2aaaa0f46108cf05f3787e3c45e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "6776e04566f64c7c8ff033750b5b73fd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "e400a96037f34cd7bc16b81583948d83");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "ec5cb319c3dc4d838f80f701c7bc1ac8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "a0d527f04ae04faeb70b5d5f877df348");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "58c797776e1d4d8cbcc74944fb183658");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "b5b447b34920474981b9fd67eacc1e4d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "3f7d9324c2674792897ea2641f570ab7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "f927e943d8a84cc984ab7a1b77f85637");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "92b7afcb17d24200a247042a8bffc26d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "acb944206d524cfeb7ac5d85894315fd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "f654329f34ad42c498044e8d126dd0d9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "780d88ad205e481dae5b2cfdbc2bc7d1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "826071417da349c2a71152289a499481");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SecureUrlKey",
                value: "a1475f34c9784e33a9f80d68cfabb9f5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "4ec304bfa0954ca38b9f9ac49d24646f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "fe4204547ef24c4197891fa641eb4438");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "73b922a8a3174f23a6ff72eafa4dcf0e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SecureUrlKey",
                value: "fa5de952f8b1469d821d0ace63486588");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SecureUrlKey",
                value: "b274eff82b514ef7a4f936ebd49cf2e7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SecureUrlKey",
                value: "f5cd3081e7ed4b8a989c7e557c9db74b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SecureUrlKey",
                value: "55488e60c7ce47c790de4c51e81f31dd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SecureUrlKey",
                value: "fc5b6f75cab44168bee3759db29112be");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SecureUrlKey",
                value: "8271da3cd2b340418790168cbdb74c32");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SecureUrlKey",
                value: "dfdfb0bd8670424691824714c8544a46");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SecureUrlKey",
                value: "4f1b518b2f8b430db85a9f4f6678e61e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SecureUrlKey",
                value: "6a8dae840f7e4673a29809d338d93215");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SecureUrlKey",
                value: "6a7afb57d6bf4195aba7ad39d3cea8f6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SecureUrlKey",
                value: "ecb76042870641e49b67aa319403fcec");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SecureUrlKey",
                value: "2fb65f3b69824b9294806cd7d5af038b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SecureUrlKey",
                value: "23a22c9116f144989005c20b7a7b9d07");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SecureUrlKey",
                value: "f8e77e9404fd4f7bb98408450fa1d1ec");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SecureUrlKey",
                value: "1af50f0d53b34320be7b3c712b188a7f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SecureUrlKey",
                value: "2ea8c23492a74cdf9b37005e138c7987");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SecureUrlKey",
                value: "3caca9bb665b487a86f41637b8227e18");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SecureUrlKey",
                value: "a0cf5cce1e5647afa0305f4f69bf7f38");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SecureUrlKey",
                value: "d2a6819e9fc24e46baf2a82a82aac857");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SecureUrlKey",
                value: "b54ae48e84c34dab85af1db39e534b04");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SecureUrlKey",
                value: "ccf446c212f9487f913b4c75c01057ab");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SecureUrlKey",
                value: "3d2f8ef18db642dd9e22c4634f4f7fab");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SecureUrlKey",
                value: "0cc2b2c7dfa54e78afbb84f4b3f73fce");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SecureUrlKey",
                value: "1fdd78b5e40d47789cf5ff5da290a308");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SecureUrlKey",
                value: "affe8d6317174f41a23949ee05de4b03");
        }
    }
}
