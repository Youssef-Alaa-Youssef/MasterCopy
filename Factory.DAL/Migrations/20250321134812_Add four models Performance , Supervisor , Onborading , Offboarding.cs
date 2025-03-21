using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddfourmodelsPerformanceSupervisorOnboradingOffboarding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Performances",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewPeriodStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewPeriodEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductivityScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QualityScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TeamworkScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CommunicationScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InitiativeScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OverallScore = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ManagerFeedback = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    EmployeeFeedback = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    GoalsForNextPeriod = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DevelopmentPlan = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ReviewStatus = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performances_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "HR",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Supervisors",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supervisors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offboardings",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    LastWorkingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitInterviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TerminationReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: true),
                    NoticeGivenDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReturnOfCompanyPropertyCompleted = table.Column<bool>(type: "bit", nullable: false),
                    AccessRevocationCompleted = table.Column<bool>(type: "bit", nullable: false),
                    KnowledgeTransferCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ExitInterviewCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FinalPaymentCompleted = table.Column<bool>(type: "bit", nullable: false),
                    BenefitsTerminationCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ReferenceArrangementCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FarewellEventCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FeedbackProvided = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offboardings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offboardings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "HR",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Offboardings_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalSchema: "HR",
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Onboardings",
                schema: "HR",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SupervisorId = table.Column<int>(type: "int", nullable: false),
                    OrientationCompleted = table.Column<bool>(type: "bit", nullable: false),
                    WorkspaceSetupCompleted = table.Column<bool>(type: "bit", nullable: false),
                    EquipmentProvidedCompleted = table.Column<bool>(type: "bit", nullable: false),
                    SystemAccessCompleted = table.Column<bool>(type: "bit", nullable: false),
                    TrainingCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IntroductionToTeamCompleted = table.Column<bool>(type: "bit", nullable: false),
                    PoliciesReviewedCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FirstAssignmentCompleted = table.Column<bool>(type: "bit", nullable: false),
                    FeedbackSessionCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Onboardings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Onboardings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "HR",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Onboardings_Supervisors_SupervisorId",
                        column: x => x.SupervisorId,
                        principalSchema: "HR",
                        principalTable: "Supervisors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Offboardings_EmployeeId",
                schema: "HR",
                table: "Offboardings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Offboardings_SupervisorId",
                schema: "HR",
                table: "Offboardings",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Onboardings_EmployeeId",
                schema: "HR",
                table: "Onboardings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Onboardings_SupervisorId",
                schema: "HR",
                table: "Onboardings",
                column: "SupervisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_EmployeeId",
                schema: "HR",
                table: "Performances",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offboardings",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Onboardings",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Performances",
                schema: "HR");

            migrationBuilder.DropTable(
                name: "Supervisors",
                schema: "HR");

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
                column: "SecureUrlKey",
                value: "b9c3f67754be4dc1a3e7eda960776110");

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
        }
    }
}
