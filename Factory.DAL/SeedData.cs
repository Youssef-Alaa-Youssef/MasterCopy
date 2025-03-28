using Factory.DAL.Models.Permission;
using Microsoft.EntityFrameworkCore;
namespace Factory.DAL
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedModules(modelBuilder);
            SeedSubModules(modelBuilder);
            SeedPages(modelBuilder);
        }

        private static void SeedModules(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Module>().HasData(
                new Module { Id = 1, Name = "إدارة المستخدمين", NameEn = "User Management", IconClass = "bi-people", IsActive = true },
                new Module { Id = 2, Name = "إدارة الأدوار", NameEn = "Role Management", IconClass = "bi-person-badge", IsActive = true },
                new Module { Id = 3, Name = "إدارة المخزون", NameEn = "Inventory Management", IconClass = "bi-box-seam", IsActive = true },
                new Module { Id = 4, Name = "إدارة الطلبات", NameEn = "Order Management", IconClass = "bi-cart", IsActive = true },
                new Module { Id = 5, Name = "إدارة الرواتب", NameEn = "Payroll Management", IconClass = "bi-cash-stack", IsActive = true },
                new Module { Id = 6, Name = "إدارة النظام", NameEn = "System Management", IconClass = "bi-speedometer", IsActive = true },
                new Module { Id = 7, Name = "إدارة الدعم", NameEn = "Support Management", IconClass = "bi-headset", IsActive = true },
                new Module { Id = 8, Name = "التقارير", NameEn = "Reports", IconClass = "bi-file-earmark-bar-graph", IsActive = true },
                new Module { Id = 9, Name = "الإعدادات", NameEn = "Settings", IconClass = "bi-gear", IsActive = true },
                new Module { Id = 10, Name = "الموارد البشرية", NameEn = "HR", IconClass = "bi-people", IsActive = true },
                new Module { Id = 11, Name = "الإشعارات", NameEn = "Notifications", IconClass = "bi-bell", IsActive = true }
            );
        }

        private static void SeedSubModules(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubModule>().HasData(
                 new SubModule { Id = 1, Name = "المستخدمين", NameEn = "Users", IconClass = "bi-people", ModuleId = 1 },
                 new SubModule { Id = 2, Name = "الصلاحيات", NameEn = "Permissions", IconClass = "bi-shield-lock", ModuleId = 1 },
                 new SubModule { Id = 3, Name = "الأدوار", NameEn = "Roles", IconClass = "bi-person-badge", ModuleId = 2 },
                 new SubModule { Id = 4, Name = "تعيين الأدوار", NameEn = "Assign Roles", IconClass = "bi-person-check", ModuleId = 2 },
                 new SubModule { Id = 5, Name = "المخزون", NameEn = "Inventory", IconClass = "bi-box-seam", ModuleId = 3 },
                 new SubModule { Id = 6, Name = "مستويات المخزون", NameEn = "Stock Levels", IconClass = "bi-boxes", ModuleId = 3 },
                 new SubModule { Id = 7, Name = "طلب جديد", NameEn = "New Order", IconClass = "bi-cart-plus", ModuleId = 4 },
                 new SubModule { Id = 8, Name = "سجل الطلبات", NameEn = "Order History", IconClass = "bi-cart-check", ModuleId = 4 },
                 new SubModule { Id = 9, Name = "لوحة الرواتب", NameEn = "Payroll Dashboard", IconClass = "bi-cash-stack", ModuleId = 5 },
                 new SubModule { Id = 10, Name = "سجلات الموظفين", NameEn = "Employee Records", IconClass = "bi-file-earmark-person", ModuleId = 5 },
                 new SubModule { Id = 11, Name = "التذاكر", NameEn = "Tickets", IconClass = "bi-ticket-detailed", ModuleId = 6 },
                 new SubModule { Id = 12, Name = "مراقبة النظام", NameEn = "System Monitoring", IconClass = "bi-speedometer", ModuleId = 6 },
                 new SubModule { Id = 13, Name = "تذاكر الدعم", NameEn = "Support Tickets", IconClass = "bi-headset", ModuleId = 7 },
                 new SubModule { Id = 14, Name = "الدردشة المباشرة", NameEn = "Live Chat", IconClass = "bi-chat-dots", ModuleId = 7 },
                 new SubModule { Id = 15, Name = "التقارير", NameEn = "Reports", IconClass = "bi-file-earmark-bar-graph", ModuleId = 8 },
                 new SubModule { Id = 16, Name = "لوحات التحكم", NameEn = "Dashboards", IconClass = "bi-speedometer2", ModuleId = 8 },
                 new SubModule { Id = 17, Name = "الإعدادات العامة", NameEn = "General Settings", IconClass = "bi-gear", ModuleId = 9 },
                 new SubModule { Id = 18, Name = "الأمان", NameEn = "Security", IconClass = "bi-shield", ModuleId = 9 },
                 new SubModule { Id = 19, Name = "إدماج الموظفين", NameEn = "Onboarding", IconClass = "bi-person-plus", ModuleId = 10 },
                 new SubModule { Id = 20, Name = "إنهاء الخدمة", NameEn = "Offboarding", IconClass = "bi-person-dash", ModuleId = 10 },
                 new SubModule { Id = 21, Name = "الأداء", NameEn = "Performance", IconClass = "bi-bar-chart-line", ModuleId = 10 },
                 new SubModule { Id = 22, Name = "المشرفون", NameEn = "Supervisor", IconClass = "bi-person-badge", ModuleId = 10 },
                 new SubModule { Id = 23, Name = "منصب الموظف", NameEn = "Employee Position", IconClass = "bi-briefcase", ModuleId = 10 },
                 new SubModule { Id = 24, Name = "القسم", NameEn = "Department", IconClass = "bi-building", ModuleId = 10 },
                 new SubModule { Id = 25, Name = "طلب إجازة", NameEn = "Leave Request", IconClass = "bi-calendar-check", ModuleId = 10 },
                 new SubModule { Id = 26, Name = "الموظفون", NameEn = "Employees", IconClass = "bi-people", ModuleId = 10 },
                 new SubModule { Id = 27, Name = "خدمة الإشعارات", NameEn = "Notification Service", IconClass = "bi-megaphone", ModuleId = 11 },
                 new SubModule { Id = 28, Name = "إعدادات الإشعارات", NameEn = "Notification Settings", IconClass = "bi-gear", ModuleId = 11 }
             );
        }

        private static void SeedPages(ModelBuilder modelBuilder)
        {
            var pages = new List<Page>
            {
                CreatePage(1, "قائمة الصلاحيات", "Permission List", "Index", "PermissionManagement", true, 2),
                CreatePage(2, "تعيين الصلاحيات", "Assign Permission", "AssignPermissions", "PermissionManagement", true, 2),
                CreatePage(3, "قائمة الوحدات", "Module List", "Index", "Module", true, 3),
                CreatePage(4, "إضافة وحدة", "Add Module", "Create", "Module", true, 3),
                CreatePage(5, "قائمة الوحدات الفرعية", "Submodule List", "Index", "SubModule", true, 4),
                CreatePage(6, "إضافة وحدة فرعية", "Add Submodule", "Create", "SubModule", true, 4),
                CreatePage(7, "قائمة المستخدمين", "User List", "Index", "Auth", true, 1),
                CreatePage(8, "إضافة مستخدم", "Add User", "Add", "Auth", true, 1),
                CreatePage(9, "قائمة الأدوار", "Role List", "Index", "Role", true, 3),
                CreatePage(10, "إضافة دور", "Add Role", "Create", "Role", true, 3),
                CreatePage(11, "قائمة المستودعات", "Warehouse List", "Index", "Warehouse", true, 5),
                CreatePage(12, "إضافة مستودع", "Add Warehouse", "Create", "Warehouse", true, 5),
                CreatePage(13, "قائمة العناصر", "Item List", "Index", "Items", true, 6),
                CreatePage(14, "إضافة عنصر", "Add Item", "AddItem", "Items", true, 6),
                CreatePage(15, "إنشاء طلب", "Create Order", "Create", "Order", true, 7),
                CreatePage(16, "قائمة الطلبات", "Order List", "Index", "Order", true, 8),
                CreatePage(17, "الإعدادات العامة", "General Settings", "General", "Settings", true, 17),
                CreatePage(18, "إعدادات الأمان", "Security Settings", "Security", "Settings", true, 18),
                CreatePage(19, "لوحة الرواتب", "Payroll Dashboard", "Index", "Payroll", true, 9),
                CreatePage(20, "رواتب الموظفين", "Employee Salaries", "EmployeeSalaries", "Payroll", true, 10),
                CreatePage(21, "معالجة الرواتب", "Salary Processing", "ProcessSalaries", "Payroll", true, 9),
                CreatePage(22, "تقارير الرواتب", "Payroll Reports", "Reports", "Payroll", true, 15),
                CreatePage(23, "إدارة المكافآت", "Bonuses Management", "Bonuses", "Payroll", true, 9),
                CreatePage(24, "الخصومات", "Deductions", "Deductions", "Payroll", true, 9),
                CreatePage(25, "حسابات الضرائب", "Tax Calculations", "Tax", "Payroll", true, 9),
                CreatePage(26, "إنشاء إيصال الدفع", "Payslip Generation", "GeneratePayslip", "Payroll", true, 9),
                CreatePage(27, "مدفوعات العمل الإضافي", "Overtime Payments", "Overtime", "Payroll", true, 9),
                CreatePage(28, "سجل الرواتب", "Payroll History", "History", "Payroll", true, 9),
                CreatePage(29, "الطلبات المالية", "Financial Orders", "Index", "Accountant", true, 15),
                CreatePage(30, "ما قبل الإدماج", "Pre-Onboarding", "PreOnboarding", "Onboarding", true, 10),
                CreatePage(31, "إعدادات تكنولوجيا المعلومات", "IT Setup", "ITSetup", "Onboarding", true, 10),
                CreatePage(32, "التدريب والتوجيه", "Training & Orientation", "Training", "Onboarding", true, 10),
                CreatePage(33, "تصفية المغادرة", "Exit Clearance", "Clearance", "Offboarding", true, 10),
                CreatePage(34, "سحب الصلاحيات", "Access Revocation", "RevokeAccess", "Offboarding", true, 10),
                CreatePage(35, "الرواتب النهائية والمستندات", "Final Payroll & Documents", "FinalPayroll", "Offboarding", true, 10),
                CreatePage(36, "سجلات الموظفين", "Employee Records", "Records", "HR", true, 10),
                CreatePage(37, "إدارة الإجازات", "Leave Management", "Leave", "HR", true, 10),
                CreatePage(38, "معالجة الرواتب", "Payroll Processing", "Payroll", "HR", true, 9),
                CreatePage(39, "تقييمات الأداء", "Performance Reviews", "Reviews", "Performance", true, 10),
                CreatePage(40, "تتبع مؤشرات الأداء", "KPI Tracking", "KPIs", "Performance", true, 10),
                CreatePage(41, "التغذية الراجعة والتقدير", "Feedback & Recognition", "Feedback", "Performance", true, 10),
                CreatePage(42, "إدارة التذاكر", "Ticket Management", "Tickets", "ITService", true, 11),
                CreatePage(43, "مراقبة النظام", "System Monitoring", "Monitoring", "ITService", true, 12),
                CreatePage(44, "جرد الأجهزة", "Hardware Inventory", "Inventory", "ITService", true, 5),
                CreatePage(45, "تذاكر الدعم", "Support Tickets", "Tickets", "Support", true, 13),
                CreatePage(46, "الدردشة المباشرة", "Live Chat", "Chat", "Support", true, 14),
                CreatePage(47, "الأسئلة الشائعة ومركز المساعدة", "FAQ & Help Center", "FAQ", "Support", true, 13),
                CreatePage(48, "التقارير المالية", "Financial Reports", "Finance", "Reports", true, 15),
                CreatePage(49, "تحليلات الموظفين", "Employee Insights", "Employees", "Reports", true, 15),
                CreatePage(50, "المبيعات والإيرادات", "Sales & Revenue", "Sales", "Reports", true, 15),
                CreatePage(51, "لوحة الدعم", "Support Dashboard", "Index", "Support", true, 13),
                CreatePage(52, "لوحة الطلبات", "Orders Dashboard", "OrderDashboard", "Report", true, 8),
                CreatePage(53, "إدارة البيانات", "Data Management", "Settings", "ExportImport", true, 17),
                CreatePage(54, "تصدير البيانات", "Data Export", "Export", "ExportImport", true, 17),
                CreatePage(55, "استيراد البيانات", "Data Import", "Import", "ExportImport", true, 17),
                //CreatePage(56, "لوحة الطلبات", "Order Dashboard", "Index", "Report", true, 16),
                CreatePage(57, "المستودعات", "Stores", "WarehouseReport", "warehouse", true, 15),
                CreatePage(58, "الدول", "Countries", "Index", "Country", true, 17),
                CreatePage(59, "الدول وعناصرها", "Countries and Their Items", "countries", "items", true, 15),
                CreatePage(60, "قائمة الإدماج", "Onboarding List", "Index", "Onboarding", true, 19),
                CreatePage(61, "إنشاء إدماج", "Create Onboarding", "Create", "Onboarding", true, 19),
                CreatePage(62, "قائمة إنهاء الخدمة", "Offboarding List", "Index", "Offboarding", true, 20),
                CreatePage(63, "إنهاء خدمة", "Create Offboarding", "Create", "Offboarding", true, 20),
                CreatePage(64, "تقييمات الأداء", "Performance Reviews", "Index", "Performance", true, 21),
                CreatePage(65, "إضافة تقييم أداء", "Add Performance Review", "Create", "Performance", true, 21),
                CreatePage(66, "قائمة المشرفين", "Supervisors List", "Index", "Supervisor", true, 22),
                CreatePage(67, "إضافة مشرف", "Add Supervisor", "Create", "Supervisor", true, 22),
                CreatePage(68, "مناصب الموظفين", "Employee Positions", "Index", "Position", true, 23),
                CreatePage(69, "إنشاء منصب موظف", "Create Employee Position", "Create", "Position", true, 23),
                CreatePage(70, "قائمة الأقسام", "Departments List", "Index", "Department", true, 24),
                CreatePage(71, "إضافة قسم", "Add Department", "Create", "Department", true, 24),
                CreatePage(72, "طلبات الإجازة", "Leave Requests", "Index", "LeaveRequest", true, 25),
                CreatePage(73, "تقديم طلب إجازة", "Submit Leave Request", "Create", "LeaveRequest", true, 25),
                CreatePage(74, "قائمة الموظفين", "Employee List", "Index", "Employee", true, 26),
                CreatePage(75, "إضافة موظف", "Add Employee", "Create", "Employee", true, 26),
                CreatePage(76, "قائمة الإشعارات", "Notification List", "Index", "Notification", true, 27),
                CreatePage(77, "إنشاء إشعار", "Create Notification", "Add", "Notification", true, 27),
                CreatePage(78, "إعدادات الإشعارات", "Notification Settings", "Index", "Notification", true, 28),
                CreatePage(79, "تعديل الإعدادات", "Edit Settings", "Edit", "Notification", true, 28),
                CreatePage(80, "تفاصيل الطلب", "Order Details", "Details", "Order", false, 7),
                CreatePage(81, "تحسين الطلب", "Order Optimization", "Optimization", "Order", false, 7),
                CreatePage(82, "ملصق الزجاج", "Order GlassLabel", "GlassLabel", "Order", false, 7),
                CreatePage(83, "حذف الطلب", "Order Delete", "Delete", "Order", false, 7),
                CreatePage(84, "لوحة المتجر", "Store Dashboard", "WarehouseDashboard", "Report", true, 16)
            };

            modelBuilder.Entity<Page>().HasData(pages);
        }

        private static Page CreatePage(int id, string name, string nameEn, string action, string controller,
            bool isActive, int submoduleId)
        {
            return new Page
            {
                Id = id,
                Name = name,
                NameEn = nameEn,
                Action = action,
                Controller = controller,
                IsActive = isActive,
                SubmoduleId = submoduleId,
                SecureUrlKey = GenerateStaticSecureKey(id) // Deterministic based on ID
            };
        }

        private static string GenerateStaticSecureKey(int id)
        {
            return Guid.NewGuid().ToString("N");
        }

    }
}
