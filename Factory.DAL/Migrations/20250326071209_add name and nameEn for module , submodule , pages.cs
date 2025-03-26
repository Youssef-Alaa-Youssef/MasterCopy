using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Factory.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addnameandnameEnformodulesubmodulepages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "إدارة المستخدمين", "User Management" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "إدارة الأدوار", "Role Management" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "إدارة المخزون", "Inventory Management" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "إدارة الطلبات", "Order Management" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "إدارة الرواتب", "Payroll Management" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "إدارة النظام", "System Management" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "إدارة الدعم", "Support Management" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "التقارير", "Reports" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "الإعدادات", "Settings" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "الموارد البشرية", "HR" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "الإشعارات", "Notifications" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة الصلاحيات", "170ec8c56ac84d07910556cc54dddb94" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تعيين الصلاحيات", "73a59748b8b642d180736d02ee1bed78" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة الوحدات", "29f2dca7c44b4c61a058607d777cbdc7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إضافة وحدة", "f5a09a633b5241d6a9d9b3d05e74cd51" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة الوحدات الفرعية", "d2de76d01ab2405da334403f328fbe90" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إضافة وحدة فرعية", "44dd6604a3a643fcb9e6160fb1a21780" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة المستخدمين", "f81fcf0a07a0422cb9dc62e887a23af5" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إضافة مستخدم", "e0d57d5b4a534479be48cb1ed6bdc424" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة الأدوار", "4d1d3a48ad244dd29eabf2e8c514c8bc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إضافة دور", "c389719dfddd48d6aac1acf046a86827" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة المستودعات", "df61a51897d9478b8d4f0e6aec24fc85" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إضافة مستودع", "445c937486284dc683ba4b2ddcd2dd27" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة العناصر", "25d1f6abca8b4d19bd85fa92e3b218aa" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إضافة عنصر", "22eb16b4c8db4b79a253857a8f3d0e22" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إنشاء طلب", "cf2ecbd613b442fcb065b6c601de5e43" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة الطلبات", "a8a8aeafdf2d40278f59bb83a75966be" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "الإعدادات العامة", "473848677d2d45eaa3ab1c1e42acac90" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إعدادات الأمان", "f11918cdfcb948e38a19b515c33114a9" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "لوحة الرواتب", "474abca342ae4796900848dfd75dab99" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "رواتب الموظفين", "87ec842da0484570813db03271b2664e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "معالجة الرواتب", "460be38f52594eb487b0fd3d97409693" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تقارير الرواتب", "305dbffe1c1c4f6ab4aa7a65fafdc2dc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إدارة المكافآت", "87094974cb0f4185ae45b05b43e2f702" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "الخصومات", "273896a9df49442f8be080555e801330" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "حسابات الضرائب", "c8c97d09f94e413aa59b76259adf91b3" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إنشاء إيصال الدفع", "33b99160f4d54421aa8702f79f318a25" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "مدفوعات العمل الإضافي", "abf4cabbd8fa46eda5205c4dd5be5a57" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "سجل الرواتب", "8e05ab0093b94e91a9585d1c9eac6db4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "الطلبات المالية", "705d6121cb294346859d7c4ad30f92ec" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "ما قبل الإدماج", "f7a8570b8fd64fc280ea3103f21baae2" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إعدادات تكنولوجيا المعلومات", "80ab12d1f57b4583a4edb61f649a47cc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "التدريب والتوجيه", "b003d89fc087439e987b422df8623dba" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تصفية المغادرة", "89edbb7dd1e64846afe4b5631b8dbd23" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "سحب الصلاحيات", "db1e9a083f29405f985ed2348cca5477" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "الرواتب النهائية والمستندات", "31f478bbfc354dbba56e5ba44c8d444e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "سجلات الموظفين", "ad147037c4e044eb841624a641d7e208" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إدارة الإجازات", "4baefa9bb699462ea4fa447f868040c6" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "معالجة الرواتب", "953e5b6be67e4613bad2d5376873ef9e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تقييمات الأداء", "a077abe08e6b42d49875c70fb3e048e9" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تتبع مؤشرات الأداء", "b3cede9a014146829decb388e8186b55" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "التغذية الراجعة والتقدير", "d4289de893524fa39befc73a9aa70a5d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إدارة التذاكر", "5ff0c4de7b424c598704416ad5ebdc13" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "مراقبة النظام", "1f8cb67aaa7c461bb38bc55dd6e26e98" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "جرد الأجهزة", "4bc6f96bcfb7489395db7f214fd3c355" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تذاكر الدعم", "d9490e2ccc934bc896d6dd0735bab2e6" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "الدردشة المباشرة", "e6555cffb6494223a3bd2154499e4265" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "الأسئلة الشائعة ومركز المساعدة", "82400ee3e63e4061abc30b55faf90754" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "التقارير المالية", "26e1cbf9578e438ba6ea8bb84a2520de" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تحليلات الموظفين", "cc9ae9b08e5d4a069177a325140f5ceb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "المبيعات والإيرادات", "9d394193fc1f462d9372540cebfcd301" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "لوحة الدعم", "1f1997a471e24136b1b1830864a6836c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "لوحة الطلبات", "f589668d37c343d0b8bbe0d23ceddd40" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إدارة البيانات", "43f4080a111c440fa2a2e6b9908b4cc6" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تصدير البيانات", "8344be59f9434a7d8680c61d0d7c46bc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "استيراد البيانات", "9b3027c1351c4e44b03642445fbb6043" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "لوحة الطلبات", "88906404204f4bc59efe55abd4f72fc3" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "المستودعات", "70e495bca3ac4aee980b8a330a5adff7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "الدول", "939ab8e09754488e9875ac7e7e412521" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "الدول وعناصرها", "51b57d95f3de4ee683b820c4e446fc0c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة الإدماج", "d6808e8fba9640b68d775f30744642f9" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إنشاء إدماج", "4a14f430139a44cab739bf4f3b12947c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة إنهاء الخدمة", "85736393fde74ad58c2f0145952b6dfd" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إنهاء خدمة", "9c06a7c45cd34f62a687f3450ab264b2" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تقييمات الأداء", "6865edb167f84c269d878faec7bd913c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إضافة تقييم أداء", "91c292d78aa449ac962b86036b463c7b" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة المشرفين", "784049232b354cd68b4e6ede5f9ab378" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إضافة مشرف", "da6be5f4515641efbf9406a8bd2b8f26" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "مناصب الموظفين", "d4a7602e8cfa4185a2f96d8639796148" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إنشاء منصب موظف", "7003554b3aa0490dbd66e292663c915f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة الأقسام", "c51472d0680a4aa6881e53d99f36ff7f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إضافة قسم", "04f1f1037226453c9c724b1c8965f904" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "طلبات الإجازة", "fc3b65d7981c466c97c768e8e9ff87c4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تقديم طلب إجازة", "590708793bf84053b95bb31c350af40f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة الموظفين", "bdd27f9f5aa94291956aa875c95dced1" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إضافة موظف", "3209056f2fb4430aa582f08f593e9cd9" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "قائمة الإشعارات", "7bc558d90d334b069025fa7e61480d97" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إنشاء إشعار", "53b6c58a617943a39c3a6e9ea26ed3d4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "إعدادات الإشعارات", "499e9cda7a9c46c8a66558a94f6aff8f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تعديل الإعدادات", "747828831e7547ac82fc829c0259ed4d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تفاصيل الطلب", "a6f10ff6b62f44b5a10b3d7d07519cc3" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "تحسين الطلب", "a24e92450d134ad59573f163a2a975bb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "ملصق الزجاج", "14f8c6ad6bd44654b7b8c9659d2ebc60" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "حذف الطلب", "66d38ce6f4a2407d8f327d3ca7eedcde" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "لوحة المتجر", "21f336fa7305482bb119c6e1e2c7b712" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "المستخدمين", "Users" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "الصلاحيات", "Permissions" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "الأدوار", "Roles" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "تعيين الأدوار", "Assign Roles" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "المخزون", "Inventory" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "مستويات المخزون", "Stock Levels" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "طلب جديد", "New Order" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "سجل الطلبات", "Order History" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "لوحة الرواتب", "Payroll Dashboard" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "سجلات الموظفين", "Employee Records" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "التذاكر", "Tickets" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "مراقبة النظام", "System Monitoring" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "تذاكر الدعم", "Support Tickets" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "الدردشة المباشرة", "Live Chat" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "التقارير", "Reports" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "لوحات التحكم", "Dashboards" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "الإعدادات العامة", "General Settings" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "الأمان", "Security" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "إدماج الموظفين", "Onboarding" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "إنهاء الخدمة", "Offboarding" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "الأداء", "Performance" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "المشرفون", "Supervisor" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "منصب الموظف", "Employee Position" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "القسم", "Department" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "طلب إجازة", "Leave Request" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "الموظفون", "Employees" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "خدمة الإشعارات", "Notification Service" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "إعدادات الإشعارات", "Notification Settings" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "User Management", "" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Role Management", "" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Inventory Management", "" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Order Management", "" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Payroll Management", "" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "System Management", "" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Support Management", "" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Reports", "" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Settings", "" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "HR", "" });

            migrationBuilder.UpdateData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Notifications", "" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Permission List", "1995412861244c0291cbdcfa37be3865" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Assign Permission", "8ec6c470286746beab4ee1e2e9c00abf" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Module List", "5f601ff3872f4c71a39363cf00fbc2b0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Add Module", "fe74bdb7ecd74f8fa20f7c608209edfc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Submodule List", "10ab49f87c8540d7929a435dfe8af233" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Add Submodule", "3cda0828ed5547fc809523706f454ab7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "User List", "55e1b2fa6d434cadb26500a1b409239c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Add User", "f9fb15a9bcdd45b5a2fceb3be00be6f6" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Role List", "950b7baa23e24657bfcf958dd7adb702" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Add Role", "12de5f4b230140b2b98b343c5780b34c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Warehouse List", "afb0b99f67f04f73a87827f1ff381b94" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Add Warehouse", "665629c1e01b49fd8389e982ef98a743" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Item List", "43a6842c7ffb447da0b1ce13a55ee2a8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Add Item", "de084e2e3736445abfc698701ca6df11" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Create Order", "074caac2cabb4cb88bca2eff3e8f4efc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Order List", "ea874983d2264ba9a21708f3aa281aeb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "General Settings", "a0747ea70b4048dd92b808ea34051086" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Security Settings", "441f8f8999d843e48a280d933e2bb358" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Payroll Dashboard", "3a226d93f904444b8b6d971ae042bf11" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Employee Salaries", "d7813623c9d14ed189e924c2202d1087" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Salary Processing", "862bf0eaaf5544f0b9242972eac5e3ff" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Payroll Reports", "20ceadf9e04c492484b12d5a51f458aa" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Bonuses Management", "02d5fbbef3fe4716b2cb61a798b8874f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Deductions", "18c12cba925e4ab49f0a529932cf0bd6" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Tax Calculations", "f1574c8bf96245a3bc6b9bdcc9c84d5a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Payslip Generation", "e8ee05180ed54448964daa9bbc250934" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Overtime Payments", "f8134f1f7b2b4b288a8503259af614e8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Payroll History", "5398a7864c10414192b04dff780eea19" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Financial Orders", "11577e6d951c4bf0b2c167a6404cb1c4" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Pre-Onboarding", "9dedba009d3a469395bffd174c7a0009" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "IT Setup", "497c9d98b6754bf9908934d3e340b349" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Training & Orientation", "77974f35edbf4cdea39d9590cdf8fe89" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Exit Clearance", "8c55cf914d8d44c184322b925cf7b1cb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Access Revocation", "9f0f00fad50a4231a1de8b591452001a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Final Payroll & Documents", "8f3f2d878bc242d5adccb059c82eeb7a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Employee Records", "308d288e67f9480481022950d3feaaf7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Leave Management", "89c6de637d6c40528c4ebd80db43939f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Payroll Processing", "a26dda38cbfd4b3690b34b3f146aa74d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Performance Reviews", "9a8d6de28f06412db55700974916aa1f" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "KPI Tracking", "007419236c434dfcb2b5ff9234a5a319" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Feedback & Recognition", "c5f7b8ca54a649069257a07d87e75b07" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Ticket Management", "beefc8f4e4074878a06a594846ed143c" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "System Monitoring", "b70d3d520fb94e989ba08f5f593b6a97" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Hardware Inventory", "3f8b60387e8d4d7f91a697ee64a2fc4e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Support Tickets", "598b0d71fd42470f8ef43e20841e1732" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Live Chat", "bcf543f4f96d477690887368b9a13397" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "FAQ & Help Center", "a2a6aba138fb41f6a954f9d02413bd0a" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Financial Reports", "80951403962449299385203678e539de" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Employee Insights", "260bc65333b94a1ba5fdd71bbbe25176" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Sales & Revenue", "b1eb7d82101d43a488961798bbe68b45" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Support Dashboard", "676524865fb9486591be9b81e39ef5a7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Orders Dashboard", "50925173278a40829f6947f6fce5d14b" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Data Management", "b828d6c9b3964999b7c301474adbe038" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Data Export", "7dc9203cd68c4b8db92f3ab6da2526c8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Data Import", "ac8e4fb201a847c98eecacfbbd6ca8ef" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Order Dashboard", "6ee4ed87664842d1943f067afc685e8e" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Stores", "1a0a1e5ff67d47249c25150b5cf92fc7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Countries", "a45db2a3e1024217ad31ba024cd250cd" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Countries and Their Items", "482c7882fbd940f99bfd141a3defb0d6" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Onboarding List", "94ca17acd8334110808d9fb43577c4bc" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Create Onboarding", "31fba01df8e543d39114a87d709e2ae8" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Offboarding List", "987cbf72547f4a11b2ceddfdc39baced" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Create Offboarding", "6ac59e1913904054a2389dab643a9306" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Performance Reviews", "9ed52f9b6628404e9bc35e6a8a7579e0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Add Performance Review", "3422fbf52fc94415b7cf0b50153914c2" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Supervisors List", "fa4dcfa9698f455186526a44c06da791" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Add Supervisor", "47bb988a977c43ebb88ab5c8f7ddc528" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Employee Positions", "d890af694d454e699a56fea83369f149" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Create Employee Position", "4c4d39b7333849b68eee07ea24093c94" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Departments List", "cde8240f27154fb8895d7e0723502743" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Add Department", "d8291f45b67e4ff7bba1c2d99a0d4699" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Leave Requests", "38257889456d4e4c8428d8d806a73695" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Submit Leave Request", "05cc8422f5b747218f5888d828801f96" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Employee List", "ef025226cbec4ed9ada671696021f7b7" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Add Employee", "88af98cb0d034db59ab49b2ba3f8ed5d" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Notification List", "92205f09df5e4f7195169a6d75182fee" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Create Notification", "c01ca9cc7c524dd0b9326295a5226d06" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Notification Settings", "11257e8bbaca450a95dec8b328687b48" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Edit Settings", "15690e6f6dba4a99b88f7fbf9f7a0593" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Order Details", "96e6e5994fcd4224b57ee2a16c5e5fc0" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Order Optimization", "f081fda9662647c1840fd2b0d9e90924" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Order GlassLabel", "3c8ddb8614f94bdbb268f3779e7342fb" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Order Delete", "16c70abd225e4c428263bbbf55afea65" });

            migrationBuilder.UpdateData(
                table: "Pages",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Name", "SecureUrlKey" },
                values: new object[] { "Store Dashboard", "f5f7c3ab156c43ce84bdf5945163447d" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Users", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Permissions", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Roles", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Assign Roles", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Inventory", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Stock Levels", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "New Order", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Order History", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Payroll Dashboard", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Employee Records", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Tickets", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "System Monitoring", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Support Tickets", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Live Chat", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Reports", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Dashboards", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "General Settings", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Security", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Onboarding", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Offboarding", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Performance", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Supervisor", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Employee Position", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Department", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Leave Request", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Employees", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Notification Service", "" });

            migrationBuilder.UpdateData(
                table: "SubModules",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "NameEn" },
                values: new object[] { "Notification Settings", "" });
        }
    }
}
