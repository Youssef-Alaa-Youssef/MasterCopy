using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddAPIDocsmodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "docs");

            migrationBuilder.CreateTable(
                name: "APIDocs",
                schema: "docs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Title of the API endpoint"),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false, defaultValue: false, comment: "Indicates if the API is publicly documented"),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Endpoint = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Method = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, comment: "HTTP method (GET, POST, PUT, etc.)"),
                    RequestExample = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponseExample = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Parameters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()", comment: "Timestamp when the documentation was created"),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APIDocs", x => x.Id);
                },
                comment: "Stores API documentation entries");

            migrationBuilder.CreateTable(
                name: "APIParameters",
                schema: "docs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Parameter name (primary language)"),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeEn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Required = table.Column<bool>(type: "bit", nullable: false, defaultValue: false, comment: "Indicates if the parameter is required"),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    APIDocId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APIParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_APIParameters_APIDocs",
                        column: x => x.APIDocId,
                        principalSchema: "docs",
                        principalTable: "APIDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Stores parameter definitions for API endpoints");

            migrationBuilder.CreateTable(
                name: "APIResponses",
                schema: "docs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusCode = table.Column<int>(type: "int", nullable: false, comment: "HTTP status code"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DescriptionEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Example = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    APIDocId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APIResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_APIResponses_APIDocs",
                        column: x => x.APIDocId,
                        principalSchema: "docs",
                        principalTable: "APIDocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Stores response definitions for API endpoints");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "460e660d7f914766906c683b4785dcd2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "a959b3c475e4466eaae52d2c091f14bb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "70ef06a57926495b9aae37553a95db77");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "1670a4dca4614aa6b3ca311a2bbd7280");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "f60cc6217e8d423ea01f826fd966da3f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "53ffe12f7205414da183e91bd4837b6c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "0529524886fc41e6af03f5c5612879de");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SecureUrlKey",
                value: "6e330faa35714a5988b4e8b81c44344e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "87ef7cda80d447e7902e5b37be4a207f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "1d4a28ff014f4f7a9319dea0079046fe");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "98a49da3cc1e4abfb0333b16fefbe5ab");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "9e59873e4e7a491caa7559af341f93b2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "b32e1e89ec614029823278cc2717db7d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "3a2606684f28403080fb129e9c9ed53b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "b96b2dc2eb2b4f428ae4a9099355d82e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "309a15f165ad46c895f8b26e04f7d51d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "7f213eff678840fe99c3960a10b432a9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "e87935871dd8448c874c3ccaa8150564");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "fbdbfc749592410db4843e4383d24746");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "b87ef58aaa474d3aa466d04888ca070e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "c8fdf54ff8e741dc8362f759ed29a6d8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "3d7e9d50d86742a685a51aacee0bf878");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "c6c59b6ea0054a9baeaf3b59a9870394");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "d10c1894ae424511b0565cc650ed25db");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "2c598888014d4615add3958f7d968ccb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "7b0fd10faf2a474ba29bc926249f5303");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "2a3f1513d4ec41039aff7eff39f1a71f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "2f3390d9b0f444bd9273e8fa20c22846");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "6b54172269f841e08e5388abbbdd1426");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "010a892db36e4ac5903d28c695e013fd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "b71b27c946c147c181379d89114a6c8f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "d7c896c1754b4d4d80fca94992fe94fd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "f91fddf520f64fe6a43f4072a106ab6d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "c5739fc63a8941c6968ee179547ae9b4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "13e9f75284de49bba85a392491fcc966");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "c106b13f7ac04d1c9cd13dee003c0949");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "83cfaef932774539a1fac7859caef4a3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "72fa335e56e1427585462adac4f316a9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "b83f8c933a59464bad249f49dc761c77");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "fa15714d462e4c78babe3988ed8e5fad");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "2cdeea45b79d4b0d963d7a0f07dcc43b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "4462b49ddb594fb39afbc5cfef0f2398");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "41475a2319e846c0ac7f983261adfac1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "9d3cdd1b9e7344ae94c4e13386944020");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "b051175a394c4eeaa666bef294dafc68");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "c553202ea0c843cdb02a9505bcb40fbf");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "f5d175e29ffc4461877d29ee0b18bcbe");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "f1d73705435142c2a8b7960851dd7b49");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "81aa49ac87074027b029969bb44bc742");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "21429f293feb4c15b33f1886c582960e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "f693a1fc3836433cbd9c4418da316142");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "f9c7dfe621184d5fa0501aa6bf0810c7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "4a660ac127a1408981e1df00307bc73c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "5f5db7aef5864cada6ffdc79f80932a9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "fdec11f0ed34400b995c96a1b0746b07");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "4f379d027bc4486baebabc05202e3e3f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "01913cdb4286456c933fd429c7d57a3b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "1298a076c21645f1bb83c814a89fee8b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SecureUrlKey",
                value: "2838b44e498a44469d3c50927f264a77");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SecureUrlKey",
                value: "03cc1070d5dd4155b8d67df5ba07a38c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SecureUrlKey",
                value: "77f1ccd45de7436ab8d7957e95f38b2f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SecureUrlKey",
                value: "100d234c61e4494387591d3ea8d90bdd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SecureUrlKey",
                value: "f95d79343e7842b287870d76fdc4addf");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SecureUrlKey",
                value: "cb25ca148664404d9b2ed9a7240e42c8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SecureUrlKey",
                value: "775cb973536c4db289f0f37c1d91f159");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SecureUrlKey",
                value: "2334e4dcb960450f9637284675f4dbd5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SecureUrlKey",
                value: "74059701ec88450295d13df4449b8fa5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SecureUrlKey",
                value: "9fc4fcdb4aa641eb8d2285c04bdac6bf");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SecureUrlKey",
                value: "22fea1fb7834404a88493bd91d6b7be8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SecureUrlKey",
                value: "4019806a88c2465b9710b7fc00d1db75");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SecureUrlKey",
                value: "4582f3068eb343bb96fb6b4fee66a7dc");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SecureUrlKey",
                value: "a289f63ada524e11a4f47b9f9a3c2e55");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SecureUrlKey",
                value: "a92ec692986c4315a4e32c70ab2597ce");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SecureUrlKey",
                value: "500a243409ee43f4b069c868f917d1d7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SecureUrlKey",
                value: "8ebece4fedce4941955a04d18b8b63ca");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SecureUrlKey",
                value: "7dbade920c1d4c28a589e1838ce7bb72");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SecureUrlKey",
                value: "ae8dbc798e044e33a4234a05168dd634");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SecureUrlKey",
                value: "7da5aa0e44e54fc183edb3e42d7c1f78");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SecureUrlKey",
                value: "358e759f0fc54f76a725a48faa9079a9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SecureUrlKey",
                value: "93d11ce1b7c1400d8bda7481ee7369bd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SecureUrlKey",
                value: "39a69f7db7094cd0b3887e538471037b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SecureUrlKey",
                value: "b5a15f0ff4b6424da1c17bd8664b89d3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SecureUrlKey",
                value: "f8205dd9129e48908a54df51114cefa4");

            migrationBuilder.CreateIndex(
                name: "IX_APIDocs_IsPublic",
                schema: "docs",
                table: "APIDocs",
                column: "IsPublic");

            migrationBuilder.CreateIndex(
                name: "IX_APIDocs_Title",
                schema: "docs",
                table: "APIDocs",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "UX_APIDocs_Method_Endpoint",
                schema: "docs",
                table: "APIDocs",
                columns: new[] { "Method", "Endpoint" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_APIParameters_APIId",
                schema: "docs",
                table: "APIParameters",
                column: "APIDocId");

            migrationBuilder.CreateIndex(
                name: "IX_APIResponses_APIId",
                schema: "docs",
                table: "APIResponses",
                column: "APIDocId");

            migrationBuilder.CreateIndex(
                name: "IX_APIResponses_StatusCode",
                schema: "docs",
                table: "APIResponses",
                column: "StatusCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APIParameters",
                schema: "docs");

            migrationBuilder.DropTable(
                name: "APIResponses",
                schema: "docs");

            migrationBuilder.DropTable(
                name: "APIDocs",
                schema: "docs");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "c384d29ffe1344bfbd4a739298cad9c7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "280d80d2fb2f447db7b5c0b15749ce66");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "ca1075f010fa4be094ec44eeceaa339c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "936a70741fc04ffabd26c8ffc99d23e9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "bd8bad31386b43c8a13b6f81e2840b30");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "5c7d8267d3254add91af78912a87825a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "cfedaca7410c490690aa3375a96ce925");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                column: "SecureUrlKey",
                value: "a2f4bf3b133c474ba28da678ae137637");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "fccc23dd6c104613ac706cbe39db160c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "427a6469300a432a86916319e95e38fe");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "5008303552d54e98982772f051bc52cb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "773f6708c6a049fc8fa57b5471d6ad22");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "26921da743fe4e029a4a12b59b7b1483");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "fe87862ca1834e43ba7ef56b98d243d8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "0e2da4c3b912493bab2f6a0114dff18e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "31338f0fd42040ff8e3732435d9c0c26");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "5def1fa84aed4717b07cf6b45bd07d20");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "c5eee7c1eeae49d09d77a3004542cc4a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "912788d5166d466592e0befbb9cfb745");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "e6632314da604dbeb1a84f63a8a375e3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "f9c22d6d82eb4adf85847b4042c9a696");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "d0d1991f24ec44bfa3f78286f316a817");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "25ed083ec214437b9ed7a8890bd52bdf");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "be17018d6700401aa09a216ea68bdfe9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "14b13d5af3684a019349954a1b2249a0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "27e5ffa854fc4620ba152aa8abe15472");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "03b4dd2118e04934b05e8d5b0900aacc");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "237cbd8a72ef43a694d47f3516eb4783");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "606fc9b305784bdab9f1a6a662e109e3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "20d25ee18f5e45daa11d62ebe945832f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "e4d843272e7c4a7a8e174b586568c27e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "7bcabbf6df3948d8b2303bb7f6a17f44");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "49e5b53df8fb4c359754079773b5a2ae");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "616671aa15ba440b9e0b12826b99b51f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "cb8ee58b830b4d8d8b9e477bbda15878");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "bf90391d31d646d58dbf9ac65c98d83a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "3325b8035f854f3e8b20b6abbb134711");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "46d2d939d67f40f2a85abc259eb08cd0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "c972aa089d4f47f3b33d7afa9c3f0775");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "e985658c87ec4de38714ba6eb8c34e5c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "6299e79fd540494f91ac6096456b4827");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "5f6a516ffe1248e8975ed657837a51bb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "f1ee52292b084d78bb8f3075a8c22edf");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "c74ac4e4bdfc412498ecf88ae9e70511");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "7883401b56b84b9fa6918f97ecf4ca52");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "32c48009c2d140a2bf72b19ca6fa725b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "a2b6fa4e62a941c0b866de101ec84c05");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "91f9a1d28ee6490a91fa0ffd9fbe5daa");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "a009bda9395f495aa1db054dabf7b27e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "12bb612d89fd467397e5bab10e79176a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "d06c27904b994714b2d342ccc932a2cb");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "5a681c75954749d9b2da0dfdfbdc24c5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "7715c9a7a591456d9fee9860b44248a6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "cabdaffe7eb7436bbeb32b7fe143cb33");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "b6bfc08274794441a708f086aa81356f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "b040ffd479554bfcbe4b36bf61512284");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "297c3901b7f040da9b9a255f5e90b051");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "4f628fa0ec6d442790c39d9787a8323f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                column: "SecureUrlKey",
                value: "544b230f2f5249d89152f5dd5105ad20");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                column: "SecureUrlKey",
                value: "44478fb75c074d1f8de4fa448ef493fc");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                column: "SecureUrlKey",
                value: "8d208a1c6b614416bd1f9e59f3443aad");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                column: "SecureUrlKey",
                value: "756e2c6c4b894c12b5126e50bf130b7a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                column: "SecureUrlKey",
                value: "1e6b534937254d2e91597843b86d0be5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                column: "SecureUrlKey",
                value: "88bb6db7a99d42cba8b9b65ddbd22484");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                column: "SecureUrlKey",
                value: "cac38561ce6640e3aefe39169147ae0d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                column: "SecureUrlKey",
                value: "b935c0e172c6479aa18087b37e695838");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                column: "SecureUrlKey",
                value: "a40588cc8ef44b43b2966f97df15b3b4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                column: "SecureUrlKey",
                value: "186ab48e7d194faaa3451896c4579d26");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                column: "SecureUrlKey",
                value: "f17f1c7894d441c9a0beea512e97ca7d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                column: "SecureUrlKey",
                value: "e182044f73aa414eb1b0eb102bff9b31");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                column: "SecureUrlKey",
                value: "fc4f627c24a5411792f00568a3a42cf3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                column: "SecureUrlKey",
                value: "7742bbe020e84174aa1b2261cbca8f19");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                column: "SecureUrlKey",
                value: "52d3b6d3c1784702aab2f4016b9cb257");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                column: "SecureUrlKey",
                value: "59f513ac36ef41048d2cdfbf1075b4d9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76,
                column: "SecureUrlKey",
                value: "9cc578fb3bcb41dcb8305f7a3b03163f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77,
                column: "SecureUrlKey",
                value: "ea347b1a9aa145d5b292bad043bad85f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78,
                column: "SecureUrlKey",
                value: "47ced5ed1b5241aeacf3b941e6ff3d0d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79,
                column: "SecureUrlKey",
                value: "5e4126e668864f9b81aa2cd35a4331b0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 80,
                column: "SecureUrlKey",
                value: "cff383e81597487fbb9cf907629f70a6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 81,
                column: "SecureUrlKey",
                value: "9cfd6363a1854616b52b97c95e6d3d65");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 82,
                column: "SecureUrlKey",
                value: "f822d03e2ae24bb2b8e760d18d5b794e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 83,
                column: "SecureUrlKey",
                value: "628e6af91a3844d9acb5cadcd83d0179");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 84,
                column: "SecureUrlKey",
                value: "087500ffe8ca49968b023b74c1760a89");
        }
    }
}
