using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddfourmodelsEmployeeDeprtmentPositionLeaveRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HR");

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TitleEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Positions_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "HR",
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstNameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastNameEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    BaseSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "HR",
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Positions_PositionId",
                        column: x => x.PositionId,
                        principalSchema: "HR",
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalDays = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ApprovedById = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RejectionReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "HR",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "8e9fc96316ca414ea25670676fc64b91");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "512b46a5fec9467b9ad73cd9e67a3911");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "bb243e1f039a4359954033d3406a6268");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "6353593da953433a971fa3f02321246b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "d15b0744f32647d39c38e7e92cd5a306");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "e655390c42874058885a05c99d8e8e5f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "4fe30fb3001f4af08f756fed1c2f9458");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Action", "SecureUrlKey" },
                values: new object[] { "Add", "b9c3f67754be4dc1a3e7eda960776110" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "02bcca2322d645379bfccfa82e37f463");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "ff7e811e5c8044ea9f4ad0b801eaa887");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "650730d917114eb599e0fa250de274f5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "f1950ffaf08d41998d84406c71fb502c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "ccdff18aedb0496690b618cd53e265b7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "a8385bee6db54ae5adbe0b61a9cb813b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "34324b6eba184ab4a9a1d3825de670a5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "ef5f3f4a9db048f4a3ce6bfd9296c604");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "b869118b32d34e49a964434b74e8ed32");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "e0791ab0c6a54c7aa7753da0dd10772c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "2ba44e0a3ee044afbcc045a69a291578");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "72e2f21a80304a5e80306eb93e4cb337");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "0f2bb533cd314d60a022128843c0128b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "5d0232878f374ad8b1b45aaa62469e07");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "047b94b989424c89abb8ddb001d85c10");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "8380512b80054eb395d10f169f986fe6");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "193731a1db1a4c0288112d83e85d2e6c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "7175e27d3f0f43b9b0a7183c5e1acc08");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "be0bd166d15944c5985673c2affb9775");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "13d02d9006f644f2ab60f3a027bd7014");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "e7511c2d945d4623a4a48f0300c996d8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "f95fbcd1447a483f8e07fe6c2e5839e7");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "8a5e6e2c3eca45edbebd5c0f42043a1a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "444aabc3382545b5adc1d23b583efa58");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "c1ed79fcd82a499b8616627821972122");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "ba379ce0d1fb417abbd79862df6aab17");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "27083172190849c5823c73364a69c47c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "04ff1d69163d4007aa43e2b7bb0df7ee");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "8cf63b3c1386437baddc8cbf309eed98");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "9ed1f3409bea425e8a700de59d9b81ae");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "a9294796b7314bcba28cb167a0725e9e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "5a8020e692ca443d99d8296b742e99e3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "788a2662b85b4db5821f8e8deab9d628");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "52b8869a01fc4f6c832e8db4c0c579f3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "e7bee88685664eee87911ec7feff8b1d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "892f8e876e4c4b6c8db121f7f27cc003");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "fded617bd38d42a3a149a65bd7828321");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "b0d7abbfd120416a95241759e7a91e9f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "040e3fc83d96497fb2808f97f19acc1c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "ff32dee35f0045bb9c4bef04f1f17865");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "09dbff832072455c8c8e89b346ebccce");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "a4361885c28b4c22bff3781e92537bd2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "615733f27ed144d297a0c1e6962693bd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "e05f64ca646b469d8d228eb4cadb24e9");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "79a07be643964e0c8b5513b00c6a798f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "0b841ba9421e499395522db83209336e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "3d897674084945b8802a307794d29dc2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SecureUrlKey",
                value: "975f3d4ce9384198a69dde34ce88af1f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "0048a919d9c848b889278295139d295d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "702fac554c404d9c8d35f29087b198c0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "2fa6f459a9e24b8b8eed706a35146eef");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Code",
                schema: "HR",
                table: "Departments",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                schema: "HR",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                schema: "HR",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeCode",
                schema: "HR",
                table: "Employees",
                column: "EmployeeCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                schema: "HR",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeId",
                schema: "HR",
                table: "LeaveRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_Code",
                schema: "HR",
                table: "Positions",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DepartmentId",
                schema: "HR",
                table: "Positions",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Positions",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "HR");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                column: "SecureUrlKey",
                value: "c7dbbe638bfe4b118d79431947f3095c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                column: "SecureUrlKey",
                value: "273b4fcf767340059a3d6d0e084036ad");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                column: "SecureUrlKey",
                value: "0783c1e54a2244889f1dcef291d32e17");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                column: "SecureUrlKey",
                value: "01f4ef4447e84e9186b7b78e50152034");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                column: "SecureUrlKey",
                value: "f3284da5f9174f82bc7823b57d1e432d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                column: "SecureUrlKey",
                value: "d9d1455116574f859913a64aefa1d2fc");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                column: "SecureUrlKey",
                value: "33b4adb9d0124104b1e4eeab26ae1ae1");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Action", "SecureUrlKey" },
                values: new object[] { "Create", "2d88356608e04187a75f913d73e92ca4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                column: "SecureUrlKey",
                value: "57c7c34e59104c2d8e21575981f13666");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                column: "SecureUrlKey",
                value: "aa77543bca7e4012ba23b4d24e75709b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                column: "SecureUrlKey",
                value: "ac1799dd27cb4c448763f0f1b7a38f54");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                column: "SecureUrlKey",
                value: "199be72065f045ff9a6d97149b4bbe37");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                column: "SecureUrlKey",
                value: "79d5fbe319c3490fbb2ba041d93af621");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                column: "SecureUrlKey",
                value: "3b7dfe6b42174409851323c85f3dc565");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                column: "SecureUrlKey",
                value: "93d851f939bb42c89a9ea642937aebe8");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                column: "SecureUrlKey",
                value: "8ead7af434d542c3a356bfa4a8a30b41");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                column: "SecureUrlKey",
                value: "393ed41197424ace8047bcc33cfc2c59");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                column: "SecureUrlKey",
                value: "46e63e80604e4d6796a0cd46bb7de1c0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                column: "SecureUrlKey",
                value: "398cec674adf47e3a7a6d57fc816dedf");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                column: "SecureUrlKey",
                value: "c05a6b14d1ff498dbad22848686abb14");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                column: "SecureUrlKey",
                value: "d91c1a395a0c4f7f829a07f2bb57c05c");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                column: "SecureUrlKey",
                value: "3ce7b73f859542e4835a69d1e0c90c2f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                column: "SecureUrlKey",
                value: "24bb2b1813614f0aa24185657a490fc3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                column: "SecureUrlKey",
                value: "42dc4b7233284672858a9130701f96f0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                column: "SecureUrlKey",
                value: "6438dc649fe94747ad4bb0bab3592171");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                column: "SecureUrlKey",
                value: "b8d6109c69ab4c2d987c0cf9be032fcd");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                column: "SecureUrlKey",
                value: "54f004a505de41ecb44baa3429dd334f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                column: "SecureUrlKey",
                value: "9e84dcc0bf944523a830d4094eb87681");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                column: "SecureUrlKey",
                value: "ff40be4350334419bcca13bb9f755669");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                column: "SecureUrlKey",
                value: "fcca9643e0f244c589b1238db8237015");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                column: "SecureUrlKey",
                value: "35e669878439421dbcd025aa82c955f0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                column: "SecureUrlKey",
                value: "501da3c6146a4b9fbf75838ea5cb853d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                column: "SecureUrlKey",
                value: "93ce2446779a4f8c8ef62fe1e825b874");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                column: "SecureUrlKey",
                value: "c2dbf5f124b64766b489216f8756bbe5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                column: "SecureUrlKey",
                value: "f4b02d05ea6d4d37a6291ead9dfc9119");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                column: "SecureUrlKey",
                value: "688264de11594803848a46dc820545e3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                column: "SecureUrlKey",
                value: "a8564dac4d26411b9b79d58daf364d8b");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                column: "SecureUrlKey",
                value: "bdae0b8da37744c2a5275c16cd8c4531");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                column: "SecureUrlKey",
                value: "bc3acf26241a425d9d3a267e896571e5");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                column: "SecureUrlKey",
                value: "e15ab3e4c46f4132b7667beda0f100a2");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                column: "SecureUrlKey",
                value: "f3e1938cc7764933bad69b64907e6e51");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                column: "SecureUrlKey",
                value: "43c42e26425f44e98ec8517707edb088");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                column: "SecureUrlKey",
                value: "f2ddd4d3c34f4d9dbcda73d384d8601e");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                column: "SecureUrlKey",
                value: "da76278b2a3e4bda8acd21f51bfe0e45");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                column: "SecureUrlKey",
                value: "54a953b7c80444cbacc3ca46da2fe246");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                column: "SecureUrlKey",
                value: "72534d8eca6148faa6899b0e7e4bddd0");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                column: "SecureUrlKey",
                value: "a36069b5b1c341d7bc26384fcfaac91f");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                column: "SecureUrlKey",
                value: "f5d5791586274da9b54a809a2c4f5bab");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                column: "SecureUrlKey",
                value: "df3b711ddcd148f48d86a458d0ed0c88");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                column: "SecureUrlKey",
                value: "c14421df79ec4c14a60a81894ac8ec87");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                column: "SecureUrlKey",
                value: "1d5f3aca9e2c4f0fbcf00dc1d0ee12fe");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                column: "SecureUrlKey",
                value: "6e307a1dbd3e4200aae2f7ef3e529444");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                column: "SecureUrlKey",
                value: "9a7924317ed64d47b29ecc3997d60006");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                column: "SecureUrlKey",
                value: "567ff0c09940425e934aa78b67554dd4");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                column: "SecureUrlKey",
                value: "31568815aa5e4176af9055ff89fc5c5d");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                column: "SecureUrlKey",
                value: "b5f76d3803554b9984e95917f6033ca3");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                column: "SecureUrlKey",
                value: "db0625b196ad433884ec4c02ac26e95a");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                column: "SecureUrlKey",
                value: "346ad6eee38640e9ada10733f183bbed");

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                column: "SecureUrlKey",
                value: "f8b8bad4872e4befab76405c99ce7409");
        }
    }
}
