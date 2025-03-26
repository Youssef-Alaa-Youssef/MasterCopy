using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addnameandnameEnforpage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Permission List", "833d61fc45e2489cb6b0b66fc13d4c98" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Assign Permission", "0eac7056b74c43319806d02281572db7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Module List", "e2ccb9d47cd94ceaaca40e6d13d39fd3" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Add Module", "eec20ffe9dc14c3e92e6b2c1fd40b32f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Submodule List", "b83879205a3d48e0a071211b751dfdf0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Add Submodule", "0d128df5326149bca1b54c78875cd51c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "User List", "c8f40903c65b493d8d5f77e78654743e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Add User", "74d0a00e8dbe40ad89a8bd6fa7f1bfb2" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Role List", "f1c7a3feb385405981aacf83069c8f07" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Add Role", "686bcbeac6cd419fb4e56f83d70d8fbb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Warehouse List", "f7c071ab6b12484482b525f8e68e66d7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Add Warehouse", "37cb555ca5bd410a96991f1e0aecf250" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Item List", "566054147fb04742b14a7e23a95455e3" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Add Item", "ac37b21af15a4e339f443f17831589e1" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Create Order", "087a14e5594246ecb95c240d03d4fe1c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Order List", "36142882a1f64bb99c70062aa76f5815" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "General Settings", "657b2aac3734405d8c2d76eba4f41928" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Security Settings", "f9b2ca0645ba408fa6d7424adb772ec7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Payroll Dashboard", "a62ad390a4424d53af8f11b37d0cf753" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Employee Salaries", "bb4ac19f9af64fab88b3857cc9a61c3f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Salary Processing", "c25aa79406304c939d5ee4b3dbb7f6fe" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Payroll Reports", "8f0489280f13441d8df5c02a9d5b5dd7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Bonuses Management", "2c61c896d5ce460f895daed56ae8c0c4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Deductions", "10bec790350d4822bc8c359d7226c4a3" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Tax Calculations", "770be59fc2c248c48345fda53cb96c0d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Payslip Generation", "984fc5ec463048cd901e260b00fac9d3" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Overtime Payments", "5c81184847e348298f989c9113dd614e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Payroll History", "47bf112640e946ad93dba9f8ba3e155c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Financial Orders", "5d35b24c7b5c4b0ca1ea20859b56168f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Pre-Onboarding", "b44aa3c2cac849e2a199fda391c9b3be" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "IT Setup", "aa7811bd93924a7c86d578aac8c3edd5" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Training & Orientation", "d0ea453d24094389bce14b7bedeef907" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Exit Clearance", "4e5f521163d2479283f0a305f9feb761" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Access Revocation", "07320e568aea499ab03a27e1be3db495" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Final Payroll & Documents", "a4d596fd3b5f413fba941648cf687e9e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Employee Records", "9ac202ca98154d5b9e91c0992163a867" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Leave Management", "3add0eefd5c34ef380ff2aea735b97b0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Payroll Processing", "afd4f8c24d164dc09b5731507c7f05eb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Performance Reviews", "68cb1e7458904b1cbea2da28bdb10587" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "KPI Tracking", "a0a979da37604f3ab2d2e759badaceaf" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Feedback & Recognition", "644947e6031144c29f8d7370008cdd28" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Ticket Management", "ca06f6702d25476c9b2ef182d074b361" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "System Monitoring", "20400497dee74ef4a183682fe99586c1" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Hardware Inventory", "3fdcd22dbcc14076944f5755327514fb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Support Tickets", "2e4e62b85c7d4f85a1fd7e38addc097e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Live Chat", "bcf2c6e38a224613be9b2636234fa596" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "FAQ & Help Center", "9f4da237b01b4f8a8ac2d8a2e545064a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Financial Reports", "cc78807d03954acfa3e26b6a2ee2ff71" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Employee Insights", "814d7ab85d814e9696363682368b1d4d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Sales & Revenue", "bc59bf7fa7764ad69aaca221b4a2fbf4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Support Dashboard", "bf113df970cc4036a0fc22a733d22ac0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Orders Dashboard", "2ffb489be2d44495b564a29ee3f300b9" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Data Management", "faea70637508456e9d261d16f76cc22c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Data Export", "047d1ba8517c44b98a1a3a077473c2fc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Data Import", "07eab15cca4747518e678dd432809a3d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Order Dashboard", "b1ae6b8414ee47adba569c34eec663ff" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Stores", "ef96051e4f434c26be3f20dea52fb8a5" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Countries", "96af3637d87640eab26a6c1e26e74400" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Countries and Their Items", "3e97f7b1f48d41e19fe9edb538d4ac78" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Onboarding List", "62dc85626e484f2f9be0ef39f1732de1" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Create Onboarding", "54e1c1022a8d4317bfe5191098729d5f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Offboarding List", "47dfbbf865ce4f4d880c1d6e6d7e8aed" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Create Offboarding", "5a746eb46f2f4d4886251a8c61c7083e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Performance Reviews", "638c40f8b00645ac8a94e471f44dc2a4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Add Performance Review", "1815261caa894a3b818122d3b148124a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Supervisors List", "8423d56f7f96423493920c476bc5e485" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Add Supervisor", "4d5083823a3f49c9b505442e63cd29ac" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Employee Positions", "cf16bf715ac4420bbbfaf61df351d636" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Create Employee Position", "677b80adf351474ab76c206338416e91" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Departments List", "566b0cc408d14d079d08ff0bc0b9c660" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Add Department", "5ca4ccbfd6da463fb8273d5958cbb234" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Leave Requests", "025663d694674394a7bef3d46840398c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Submit Leave Request", "2e863a52b5814943a5e119fca9e5db3a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Employee List", "b7fb8ca245354ffc82b7fe81ef133459" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Add Employee", "8078e157f3b94dd58026fab162414f18" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Notification List", "efd8c4e13589404186f3727511915c65" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Create Notification", "ab1203fe0ec64e64af13c7117793d01d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Notification Settings", "383a5e4e1bc247d2be34c9815e356a4a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Edit Settings", "313812c4da60428daaf0bef6b7161ce0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Order Details", "b076d9c4389c46ac865b6bcaa72e0c1f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Order Optimization", "44758529d553454cbf678bc143ca5f0c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Order GlassLabel", "a11f74e622a1445cb1c31d01e585eb32" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Order Delete", "1108ea976c4f44eb9e626755e3c3014e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "Store Dashboard", "bd3a1cf10471444d857178058e94a16e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "b3f88c3d04b445ad993b379d74fadc72" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "0738cce05a2d4da09ebd9e4ee3ad640e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "10ea3e10ac5c49a69e0370a080301271" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "1a4fffa7b8004cd1ab64d5814a8aa708" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "5b4d751232df4b1692344e0e91b48e2c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "c0f4934e42a94f8ca7af99b6863a2137" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "e63730f8e86b4591948134d53cff04b0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "7d1a9a061c964a938965e6027892a5f8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "996a56d586224451b9c8948be4bdb2cd" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "7ea56351484948809a832f8f028fdab3" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "9d3772d26d754dfbb57703934f8a9c82" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "4b649d845643479995d333a2b2c3feec" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "bae2883e440d480d8dac34b422aa13f5" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "d87d990c76ab43d2b134c6df9156bb40" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "60cc242d512045609a420d996d6b89f0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "fc036e9524504bb18d50a22a1457d082" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "7096079084674b7cb6e636830a461deb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "e73304e3dcbe4c1e897676c870bffc88" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "24c8ec32043e43a3bb65d03bdaa4d92c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "141891920be048319aa0dbf6ffde9c22" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "a4f908ae7836422a8c01926a950c0190" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "8196e539485d44f8b026967b75d265b3" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "8857b91c2c0f4e23b5a683e539607883" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "e5906c3c661445c4898547683ec142c9" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "83a472b1b68a4ca1bd9894799c774859" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "9cb6dd86b0884203a764433e4f43e954" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "1efc95ce13b24d54ae7aba80e6cae9e4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "5ae70ad383fb42b4907ef657d2e3b924" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "9914d73a5e1f4ffeb56e68317f0d6288" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "06f937ff5034487781ea3aa10f233ebf" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "3701d2cb0d48466a98c158c85f7b56ac" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "c0691950b4b74cd0bb0a7feaf5396fc4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "f0c28ed8b30842bf94337de6412d7b64" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "58d46b4e0f1142419033c6de76d769bc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "41bb1fdcaf0240e28993aec13f222017" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "3fd5128d065643ff882cb6cd146f4e4d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "ba2eb7d79f754f398a55fac34d20387e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "1c3f7e5dd03e4b1796dead19ed63b269" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "998bda5da6d44cc8a2e9ae383b26e8e2" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "2d55216be10b489a8fddf6e04fe01f4d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "0aa158976faa4a02b9b188cb313b0b37" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "44ba5e457cc14d1194d81916cdb66aff" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "441c79954f364a43979f0675cbd39cd8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "e6f57f486a304d41a10e33af7733bf41" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "e775bffa914a4ef2a83d4189228f6e07" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "c717e00741484c0e86ca1f18ebe3f91f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "d4528f578d584981b660f0fa7151a12a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "1936f15595fb4fbcb3e395358849aa36" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "204ce2feb9494ee98f8ef382104eac5f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "a40b1fc5385e463bbe40bbd4af186125" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "477ee195ef1e4d3cbc677684f8df6e9a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "35f71886be204d4e8534a5b1cc6224f5" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "84d2cf59dc744dfe925c8eaa006d503a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "030acd90b34840f89690435422502249" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "fcf72d8cdb3c4f68bc6624a391b19408" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "dfed669abe254660971f126a63fe3e3e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "4ea68c9549f8497d9a97f893e448b42f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "4cc097cd126145f0821ea973f965ced2" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "f4a29d141e4440878d3801744353ef19" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "cd8026e671144cf3932a955da7ff4332" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "7a59e4699bc44433844a1dc13ca1b893" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "0a0b6d834f3f489ba2b6724bee5a6d95" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "21793eacde5c4726858913615fa0153f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "506507757278439d9f4c500671928213" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "1684a5015e224459a701f30cd70ea759" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "7e44f71f03264037a444f3c21f124e42" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "ecfc438651a148d8b1dbcbf6a0f7f062" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "f0d600fabd7b407e9b98cc49203ea4a8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "3434033cc3aa41cdb34003b22ba943ac" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "3e2326d5b5cf45849b11073b8e0656b5" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "dbf00471938745d8a4c47a20a560b2af" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "a95a2d6e10994e43b43ad97e615a1d93" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "c888f064d024427ea61576171c24cd1e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "58d1270f911348aa893100872f5a2428" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "aea5d8b0856249ec84ab192ca48c2d91" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "4743178c5ea544ebb131c71c9bc3b075" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "a08b376a3d884f55a8af8107942de2b3" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "965daca1cc114aacbc1c4207836b1363" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "d39d71b5523a47d48851bf196aa2105f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "dac232efaaf94e228709cfc612b32fe6" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "4ac45de0f2bf4270a870f85c2b7b9b18" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "f8efa388211446ee97dccf96a43ef075" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "06e78eb6908d4daf8b4d80533eae7b53" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "NameEn", "SecureUrlKey" },
                values: new object[] { "", "2e8c5ca5150743b0b6eec61b014e563d" });
        }
    }
}
