using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddDesriptionandtitleandcontentcolumnsforarabiclanguage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContentEn",
                table: "Documentation",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Documentation",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TitleEn",
                table: "Documentation",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "054d6a45c74f4dbc8afef3bec222272d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "0bb53f0ae5da41a697f884e4745237b0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "1d03d4d39f5d436990c48dc6e083e152");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "b5fb1e9e021b44bb98fd77ab74c0035f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "a30cc83a8d1f4570a6f0163d69b26704");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "ce09e377b95f48ffa8e6475e9d5278a7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "2b292468ba4046b7bb9721ba7a69677d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SecureUrlKey",
                value: "76190741230a4321896cf791f96efc1c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "7a158e329a5243ebb39d577e6e72db04");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "ba5bb109d1c8480fbf71a8214e38cd7c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "29bd1d42b6c6432a955f5daba08c58db");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "f2e097fcb9e04f6a934757015b43b90f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "ce38af2d06a145cf82d4ee2e8b36814b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "b1410420c4fb474da13d9595de0baf25");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "45720ccef76b4b928cf857da4f83dcdc");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "df1b7f589e544ecca860e24be19a12af");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "5146208a354d4455be05f28224bf314a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "888aa571327e4130a74c675af44a7bac");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "89fd3d6a8bbc46739ca869b399a6b313");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "bc49ec2f4f9448fba3b95ee698ba608a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "bb8254a687f44e6291972a8fa3d212a1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "9980e5b5c3f54c8f9fce395be48a2ed4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "6249b37e9a7345438448581b09478c9d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "02143e246fda440fafcdd255027f7d70");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "07c603a6b4474b26b7a155b593a318e1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "d83bdb2df97340259bb073a278c1aca2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "b30a4911a99941d290e25451c6182040");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "3c4bc19cd60947e6a101459975485e53");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "458a125d8ca940ca80955c9495d0f402");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "0b9e3c4d273041208977bf0e1342c81e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "33ca822acd544cf797484a3de39ad0d9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "aaed1d4a7eb5474d830953228d3de834");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "50c4b4e8f59e482da182bc7f5e6afec7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "b40b35e5cbb441c5a45399424da5bf2a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "82b04df520464561a24e49167f5fa9d7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "6f593fc64cc340c9ac78be12c5f23a39");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "aceb57aa4bc14642bf130e9483330f21");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "1c0f4396bd7246f29f958c87091acc4e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "88d7058ce2874e77b1aa08455bcafccb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "8a2810479cfd499ab00d29f2ee7df32b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "5d3c8b3639924e73bfe7cfd76aa91376");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "ae12c516ef83446f8c6a6420d7b2abc7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "7849beaae2ff420cbe349c96f45c961c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "33ee81999b2d43c29375cea3205c44fb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "2025e891027d48e3ba09a060e9bc88a9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "c78b2dce67364453bd38d6e5273df34a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "76f94d95bad7428f96d1a58836c7be6b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "3395d23fc8ef4c509bbce5a8b04d36ae");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "c39f953246a4437ab3dbbf9ced660b3b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "1965acee6d63473f983375e4bd94cd90");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "3ca38beabae64f89b94e21d9fbe2b3e3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "bd11333cd5c84cc486933252d7730c80");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "d3b462a958e5444d9890d99317ca1dc6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "eec9eb4425b841009a96fbb7636228be");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "64e0c3bda38d4fcbad75b33f3911cfbd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SecureUrlKey",
                value: "c22ebe39a52645359b9a970f497ef97c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "4b95b0c565c4490892150522b6745a24");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "33d82bf124dd47c5a0ff181f05acd54a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "52b53feb16954c6b86c65952fe4cb247");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SecureUrlKey",
                value: "8c0f1f2ff08b49159aa6fa3e428ffcc9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SecureUrlKey",
                value: "c2e2dda6a24e4ad1bc326869452494f8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SecureUrlKey",
                value: "f5de3780e4064fda9ab64bb89153fa73");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SecureUrlKey",
                value: "9fcd026d5338435aa13391401a44e523");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SecureUrlKey",
                value: "57d585389707437694b2aa46bd7e4af4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SecureUrlKey",
                value: "459820709c1848e2ab2670b26f65cfd2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SecureUrlKey",
                value: "a3d0f8c1fc604a06b78bc8de859c6b10");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SecureUrlKey",
                value: "3d4d4d7d44fa4ff6b580a807a5b43c5d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SecureUrlKey",
                value: "3a73318269c6406d95a1464748c4c588");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SecureUrlKey",
                value: "cec843f217694708b27892a5c5aa5b92");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SecureUrlKey",
                value: "2eb6c57e028d40f7a158a88c8ce1096a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SecureUrlKey",
                value: "bf17d675faeb41599794bd1259288863");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SecureUrlKey",
                value: "fb30a8e7a30a42d99a061392f107252c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SecureUrlKey",
                value: "0af90862cce44c27850c296e1e8cd55f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SecureUrlKey",
                value: "9b2e4a6df5ff4f9b93dcfe3441c51556");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SecureUrlKey",
                value: "e120a90566714b0c9a1672760b90d9a3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SecureUrlKey",
                value: "5e3f55e560d3457ebb3eb866e0a812d7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SecureUrlKey",
                value: "8f4c9e90426a48aaa77cef3740fb4162");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SecureUrlKey",
                value: "8dcc8665bf7b448cb7cd5aba8675f211");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SecureUrlKey",
                value: "88d058ce3b69412bad7a2174c20cf3af");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SecureUrlKey",
                value: "d7452f67768148ee944007e2ea306ebf");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SecureUrlKey",
                value: "5c98c58e37f14877898a25fa41272718");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SecureUrlKey",
                value: "f683db2dffe047a2b7f0158790649ca3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SecureUrlKey",
                value: "87e9466563c14bf09a9bcd38b60fc7fb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SecureUrlKey",
                value: "1b693442764c4f1b8587984512ca14a7");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContentEn",
                table: "Documentation");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Documentation");

            migrationBuilder.DropColumn(
                name: "TitleEn",
                table: "Documentation");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "833d61fc45e2489cb6b0b66fc13d4c98");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "0eac7056b74c43319806d02281572db7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "e2ccb9d47cd94ceaaca40e6d13d39fd3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "eec20ffe9dc14c3e92e6b2c1fd40b32f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "b83879205a3d48e0a071211b751dfdf0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "0d128df5326149bca1b54c78875cd51c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "c8f40903c65b493d8d5f77e78654743e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SecureUrlKey",
                value: "74d0a00e8dbe40ad89a8bd6fa7f1bfb2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "f1c7a3feb385405981aacf83069c8f07");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "686bcbeac6cd419fb4e56f83d70d8fbb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "f7c071ab6b12484482b525f8e68e66d7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "37cb555ca5bd410a96991f1e0aecf250");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "566054147fb04742b14a7e23a95455e3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "ac37b21af15a4e339f443f17831589e1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "087a14e5594246ecb95c240d03d4fe1c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "36142882a1f64bb99c70062aa76f5815");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "657b2aac3734405d8c2d76eba4f41928");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "f9b2ca0645ba408fa6d7424adb772ec7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "a62ad390a4424d53af8f11b37d0cf753");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "bb4ac19f9af64fab88b3857cc9a61c3f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "c25aa79406304c939d5ee4b3dbb7f6fe");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "8f0489280f13441d8df5c02a9d5b5dd7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "2c61c896d5ce460f895daed56ae8c0c4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "10bec790350d4822bc8c359d7226c4a3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "770be59fc2c248c48345fda53cb96c0d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "984fc5ec463048cd901e260b00fac9d3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "5c81184847e348298f989c9113dd614e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "47bf112640e946ad93dba9f8ba3e155c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "5d35b24c7b5c4b0ca1ea20859b56168f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "b44aa3c2cac849e2a199fda391c9b3be");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "aa7811bd93924a7c86d578aac8c3edd5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "d0ea453d24094389bce14b7bedeef907");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "4e5f521163d2479283f0a305f9feb761");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "07320e568aea499ab03a27e1be3db495");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "a4d596fd3b5f413fba941648cf687e9e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "9ac202ca98154d5b9e91c0992163a867");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "3add0eefd5c34ef380ff2aea735b97b0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "afd4f8c24d164dc09b5731507c7f05eb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "68cb1e7458904b1cbea2da28bdb10587");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "a0a979da37604f3ab2d2e759badaceaf");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "644947e6031144c29f8d7370008cdd28");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "ca06f6702d25476c9b2ef182d074b361");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "20400497dee74ef4a183682fe99586c1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "3fdcd22dbcc14076944f5755327514fb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "2e4e62b85c7d4f85a1fd7e38addc097e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "bcf2c6e38a224613be9b2636234fa596");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "9f4da237b01b4f8a8ac2d8a2e545064a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "cc78807d03954acfa3e26b6a2ee2ff71");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "814d7ab85d814e9696363682368b1d4d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "bc59bf7fa7764ad69aaca221b4a2fbf4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "bf113df970cc4036a0fc22a733d22ac0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "2ffb489be2d44495b564a29ee3f300b9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "faea70637508456e9d261d16f76cc22c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "047d1ba8517c44b98a1a3a077473c2fc");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "07eab15cca4747518e678dd432809a3d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SecureUrlKey",
                value: "b1ae6b8414ee47adba569c34eec663ff");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "ef96051e4f434c26be3f20dea52fb8a5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "96af3637d87640eab26a6c1e26e74400");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "3e97f7b1f48d41e19fe9edb538d4ac78");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SecureUrlKey",
                value: "62dc85626e484f2f9be0ef39f1732de1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SecureUrlKey",
                value: "54e1c1022a8d4317bfe5191098729d5f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SecureUrlKey",
                value: "47dfbbf865ce4f4d880c1d6e6d7e8aed");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SecureUrlKey",
                value: "5a746eb46f2f4d4886251a8c61c7083e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SecureUrlKey",
                value: "638c40f8b00645ac8a94e471f44dc2a4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SecureUrlKey",
                value: "1815261caa894a3b818122d3b148124a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SecureUrlKey",
                value: "8423d56f7f96423493920c476bc5e485");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SecureUrlKey",
                value: "4d5083823a3f49c9b505442e63cd29ac");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SecureUrlKey",
                value: "cf16bf715ac4420bbbfaf61df351d636");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SecureUrlKey",
                value: "677b80adf351474ab76c206338416e91");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SecureUrlKey",
                value: "566b0cc408d14d079d08ff0bc0b9c660");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SecureUrlKey",
                value: "5ca4ccbfd6da463fb8273d5958cbb234");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SecureUrlKey",
                value: "025663d694674394a7bef3d46840398c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SecureUrlKey",
                value: "2e863a52b5814943a5e119fca9e5db3a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SecureUrlKey",
                value: "b7fb8ca245354ffc82b7fe81ef133459");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SecureUrlKey",
                value: "8078e157f3b94dd58026fab162414f18");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SecureUrlKey",
                value: "efd8c4e13589404186f3727511915c65");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SecureUrlKey",
                value: "ab1203fe0ec64e64af13c7117793d01d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SecureUrlKey",
                value: "383a5e4e1bc247d2be34c9815e356a4a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SecureUrlKey",
                value: "313812c4da60428daaf0bef6b7161ce0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SecureUrlKey",
                value: "b076d9c4389c46ac865b6bcaa72e0c1f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SecureUrlKey",
                value: "44758529d553454cbf678bc143ca5f0c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SecureUrlKey",
                value: "a11f74e622a1445cb1c31d01e585eb32");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SecureUrlKey",
                value: "1108ea976c4f44eb9e626755e3c3014e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SecureUrlKey",
                value: "bd3a1cf10471444d857178058e94a16e");
        }
    }
}
