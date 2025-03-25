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
                new Module { Id = 1, Name = "User Management", IconClass = "bi-people", IsActive = true },
                new Module { Id = 2, Name = "Role Management", IconClass = "bi-person-badge", IsActive = true },
                new Module { Id = 3, Name = "Inventory Management", IconClass = "bi-box-seam", IsActive = true },
                new Module { Id = 4, Name = "Order Management", IconClass = "bi-cart", IsActive = true },
                new Module { Id = 5, Name = "Payroll Management", IconClass = "bi-cash-stack", IsActive = true },
                new Module { Id = 6, Name = "System Management", IconClass = "bi-speedometer", IsActive = true },
                new Module { Id = 7, Name = "Support Management", IconClass = "bi-headset", IsActive = true },
                new Module { Id = 8, Name = "Reports", IconClass = "bi-file-earmark-bar-graph", IsActive = true },
                new Module { Id = 9, Name = "Settings", IconClass = "bi-gear", IsActive = true },
                new Module { Id = 10, Name = "HR", IconClass = "bi-people", IsActive = true },
                new Module { Id = 11, Name = "Notifications", IconClass = "bi-bell", IsActive = true }
            );
        }

        private static void SeedSubModules(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubModule>().HasData(
                new SubModule { Id = 1, Name = "Users", IconClass = "bi-people", ModuleId = 1 },
                new SubModule { Id = 2, Name = "Permissions", IconClass = "bi-shield-lock", ModuleId = 1 },
                new SubModule { Id = 3, Name = "Roles", IconClass = "bi-person-badge", ModuleId = 2 },
                new SubModule { Id = 4, Name = "Assign Roles", IconClass = "bi-person-check", ModuleId = 2 },
                new SubModule { Id = 5, Name = "Inventory", IconClass = "bi-box-seam", ModuleId = 3 },
                new SubModule { Id = 6, Name = "Stock Levels", IconClass = "bi-boxes", ModuleId = 3 },
                new SubModule { Id = 7, Name = "New Order", IconClass = "bi-cart-plus", ModuleId = 4 },
                new SubModule { Id = 8, Name = "Order History", IconClass = "bi-cart-check", ModuleId = 4 },
                new SubModule { Id = 9, Name = "Payroll Dashboard", IconClass = "bi-cash-stack", ModuleId = 5 },
                new SubModule { Id = 10, Name = "Employee Records", IconClass = "bi-file-earmark-person", ModuleId = 5 },
                new SubModule { Id = 11, Name = "Tickets", IconClass = "bi-ticket-detailed", ModuleId = 6 },
                new SubModule { Id = 12, Name = "System Monitoring", IconClass = "bi-speedometer", ModuleId = 6 },
                new SubModule { Id = 13, Name = "Support Tickets", IconClass = "bi-headset", ModuleId = 7 },
                new SubModule { Id = 14, Name = "Live Chat", IconClass = "bi-chat-dots", ModuleId = 7 },
                new SubModule { Id = 15, Name = "Reports", IconClass = "bi-file-earmark-bar-graph", ModuleId = 8 },
                new SubModule { Id = 16, Name = "Dashboards", IconClass = "bi-speedometer2", ModuleId = 8 },
                new SubModule { Id = 17, Name = "General Settings", IconClass = "bi-gear", ModuleId = 9 },
                new SubModule { Id = 18, Name = "Security", IconClass = "bi-shield", ModuleId = 9 },
                new SubModule { Id = 19, Name = "Onboarding", IconClass = "bi-person-plus", ModuleId = 10 },
                new SubModule { Id = 20, Name = "Offboarding", IconClass = "bi-person-dash", ModuleId = 10 },
                new SubModule { Id = 21, Name = "Performance", IconClass = "bi-bar-chart-line", ModuleId = 10 },
                new SubModule { Id = 22, Name = "Supervisor", IconClass = "bi-person-badge", ModuleId = 10 },
                new SubModule { Id = 23, Name = "Employee Position", IconClass = "bi-briefcase", ModuleId = 10 },
                new SubModule { Id = 24, Name = "Department", IconClass = "bi-building", ModuleId = 10 },
                new SubModule { Id = 25, Name = "Leave Request", IconClass = "bi-calendar-check", ModuleId = 10 },
                new SubModule { Id = 26, Name = "Employees", IconClass = "bi-people", ModuleId = 10 },
                new SubModule { Id = 27, Name = "Notification Service", IconClass = "bi-megaphone", ModuleId = 11 },
                new SubModule { Id = 28, Name = "Notification Settings", IconClass = "bi-gear", ModuleId = 11 }
              
               );
        }

        private static void SeedPages(ModelBuilder modelBuilder)
        {
            var pages = new List<Page>
    {
        CreatePage(1, "Permission List", "Index", "PermissionManagement", true, 2),
        CreatePage(2, "Assign Permission", "AssignPermissions", "PermissionManagement", true, 2),
        CreatePage(3, "Module List", "Index", "Module", true, 3),
        CreatePage(4, "Add Module", "Create", "Module", true, 3),
        CreatePage(5, "Submodule List", "Index", "SubModule", true, 4),
        CreatePage(6, "Add Submodule", "Create", "SubModule", true, 4),
        CreatePage(7, "User List", "Index", "Auth", true, 1),
        CreatePage(8, "Add User", "Add", "Auth", true, 1),
        CreatePage(9, "Role List", "Index", "Role", true, 3),
        CreatePage(10, "Add Role", "Create", "Role", true, 3),
        CreatePage(11, "Warehouse List", "Index", "Warehouse", true, 5),
        CreatePage(12, "Add Warehouse", "Create", "Warehouse", true, 5),
        CreatePage(13, "Item List", "Index", "Items", true, 6),
        CreatePage(14, "Add Item", "AddItem", "Items", true, 6),
        CreatePage(15, "Create Order", "Create", "Order", true, 7),
        CreatePage(16, "Order List", "Index", "Order", true, 8),
        CreatePage(17, "General Settings", "General", "Settings", true, 17),
        CreatePage(18, "Security Settings", "Security", "Settings", true, 18),
        CreatePage(19, "Payroll Dashboard", "Index", "Payroll", true, 9),
        CreatePage(20, "Employee Salaries", "EmployeeSalaries", "Payroll", true, 10),
        CreatePage(21, "Salary Processing", "ProcessSalaries", "Payroll", true, 9),
        CreatePage(22, "Payroll Reports", "Reports", "Payroll", true, 15),
        CreatePage(23, "Bonuses Management", "Bonuses", "Payroll", true, 9),
        CreatePage(24, "Deductions", "Deductions", "Payroll", true, 9),
        CreatePage(25, "Tax Calculations", "Tax", "Payroll", true, 9),
        CreatePage(26, "Payslip Generation", "GeneratePayslip", "Payroll", true, 9),
        CreatePage(27, "Overtime Payments", "Overtime", "Payroll", true, 9),
        CreatePage(28, "Payroll History", "History", "Payroll", true, 9),
        CreatePage(29, "Financial Orders", "Index", "Accountant", true, 15),
        CreatePage(30, "Pre-Onboarding", "PreOnboarding", "Onboarding", true, 10),
        CreatePage(31, "IT Setup", "ITSetup", "Onboarding", true, 10),
        CreatePage(32, "Training & Orientation", "Training", "Onboarding", true, 10),
        CreatePage(33, "Exit Clearance", "Clearance", "Offboarding", true, 10),
        CreatePage(34, "Access Revocation", "RevokeAccess", "Offboarding", true, 10),
        CreatePage(35, "Final Payroll & Documents", "FinalPayroll", "Offboarding", true, 10),
        CreatePage(36, "Employee Records", "Records", "HR", true, 10),
        CreatePage(37, "Leave Management", "Leave", "HR", true, 10),
        CreatePage(38, "Payroll Processing", "Payroll", "HR", true, 9),
        CreatePage(39, "Performance Reviews", "Reviews", "Performance", true, 10),
        CreatePage(40, "KPI Tracking", "KPIs", "Performance", true, 10),
        CreatePage(41, "Feedback & Recognition", "Feedback", "Performance", true, 10),
        CreatePage(42, "Ticket Management", "Tickets", "ITService", true, 11),
        CreatePage(43, "System Monitoring", "Monitoring", "ITService", true, 12),
        CreatePage(44, "Hardware Inventory", "Inventory", "ITService", true, 5),
        CreatePage(45, "Support Tickets", "Tickets", "Support", true, 13),
        CreatePage(46, "Live Chat", "Chat", "Support", true, 14),
        CreatePage(47, "FAQ & Help Center", "FAQ", "Support", true, 13),
        CreatePage(48, "Financial Reports", "Finance", "Reports", true, 15),
        CreatePage(49, "Employee Insights", "Employees", "Reports", true, 15),
        CreatePage(50, "Sales & Revenue", "Sales", "Reports", true, 15),
        CreatePage(51, "Support Dashboard", "Index", "Support", true, 13),
        CreatePage(52, "Orders Dashboard", "OrderDashboard", "Report", true, 8),
        CreatePage(53, "Data Management", "Settings", "ExportImport", true, 17),
        CreatePage(54, "Data Export", "Export", "ExportImport", true, 17),
        CreatePage(55, "Data Import", "Import", "ExportImport", true, 17),
        CreatePage(56, "Order Dashboard", "Index", "Report", true, 16),
        CreatePage(57, "Stores", "WarehouseReport", "warehouse", true, 15),
        CreatePage(58, "Countries", "Index", "Country", true, 17),
        CreatePage(59, "Countries and Their Items", "countries", "items", true, 15),
        CreatePage(60, "Onboarding List", "Index", "Onboarding", true, 19),
        CreatePage(61, "Create Onboarding", "Create", "Onboarding", true, 19),
        CreatePage(62, "Offboarding List", "Index", "Offboarding", true, 20),
        CreatePage(63, "Create Offboarding", "Create", "Offboarding", true, 20),
        CreatePage(64, "Performance Reviews", "Index", "Performance", true, 21),
        CreatePage(65, "Add Performance Review", "Create", "Performance", true, 21),
        CreatePage(66, "Supervisors List", "Index", "Supervisor", true, 22),
        CreatePage(67, "Add Supervisor", "Create", "Supervisor", true, 22),
        CreatePage(68, "Employee Positions", "Index", "Position", true, 23),
        CreatePage(69, "Create Employee Position", "Create", "Position", true, 23),
        CreatePage(70, "Departments List", "Index", "Department", true, 24),
        CreatePage(71, "Add Department", "Create", "Department", true, 24),
        CreatePage(72, "Leave Requests", "Index", "LeaveRequest", true, 25),
        CreatePage(73, "Submit Leave Request", "Create", "LeaveRequest", true, 25),
        CreatePage(74, "Employee List", "Index", "Employee", true, 26),
        CreatePage(75, "Add Employee", "Create", "Employee", true, 26),
        CreatePage(76, "Notification List", "Index", "Notification", true, 27),
        CreatePage(77, "Create Notification", "Add", "Notification", true, 27),
        CreatePage(78, "Notification Settings", "Index", "Notification", true, 28),
        CreatePage(79, "Edit Settings", "Edit", "Notification", true, 28),
        CreatePage(80, "Order Details", "Details", "Order", false, 7),
        CreatePage(81, "Order Optimization", "Optimization", "Order", false, 7),
        CreatePage(82, "Order GlassLabel", "GlassLabel", "Order", false, 7),
        CreatePage(83, "Order Delete", "Delete", "Order", false, 7),
        CreatePage(84, "Store Dashboard", "WarehouseDashboard", "Report", true, 16)
    };

            modelBuilder.Entity<Page>().HasData(pages);
        }

        private static Page CreatePage(int id, string name, string action, string controller,
            bool isActive, int submoduleId)
        {
            return new Page
            {
                Id = id,
                Name = name,
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
