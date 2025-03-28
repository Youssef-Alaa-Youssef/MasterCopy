using Factory.BLL.InterFaces;
using Factory.Controllers;
using Factory.DAL.Enums;
using Factory.DAL.Models.Auth;
using Factory.DAL.Models.Home;
using Factory.PL.ViewModels.Home.Dashboard;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using System.Security.Claims;

namespace Factory.PL.Services.Dashboard
{
    public class DashboardService : IDashboardService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IStringLocalizer<HomeController> _localizer;

        public DashboardService(
            IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor,
            IStringLocalizer<HomeController> localizer)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _localizer = localizer;
        }

        public async Task<AdminDashboardViewModel> GetDashboardDataAsync()
        {
            var user = _httpContextAccessor.HttpContext.User;
            var userRole = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;

            var dashboardItems = new List<DashboardItem>();
            var recentActivities = new List<RecentActivity>();
            var quickActions = new List<QuickAction>();

            decimal financialSummary = 0;
            int invoiceCount = 0;
            decimal expenses = 0;
            decimal profit = 0;

            // Fetch common data
            var userCount = (await _unitOfWork.GetRepository<ApplicationUser>().GetAllAsync()).Count();
            var teamMemberCount = (await _unitOfWork.GetRepository<TeamMember>().GetAllAsync()).Count();
            var contactCount = (await _unitOfWork.GetRepository<ContactUs>().GetAllAsync()).Count();
            var roleCount = (await _unitOfWork.GetRepository<IdentityRole>().GetAllAsync()).Count();

            // Role-specific data
            switch (userRole)
            {
                case nameof(UserRole.MasterCopy):
                case nameof(UserRole.Owner):
                case nameof(UserRole.GM):
                    dashboardItems = new List<DashboardItem>
                    {
                        new DashboardItem
                        {
                            Title = _localizer["Users"],
                            Value = userCount,
                            IconClass = "bi-people-fill",
                            Description = _localizer["Active users in system"],
                            TrendText = _localizer["12% from last month"],
                            TrendClass = "text-success",
                            TrendIcon = "bi-arrow-up",
                            ChartId = "UserCount",
                            ChartTitle = _localizer["Users Over Time"]
                        },
                        new DashboardItem
                        {
                            Title = _localizer["Team Members"],
                            Value = teamMemberCount,
                            IconClass = "bi-person-badge-fill",
                            Description = _localizer["Managed team members"],
                            TrendText = _localizer["5% from last month"],
                            TrendClass = "text-danger",
                            TrendIcon = "bi-arrow-down",
                            ChartId = "TeamMemberCount",
                            ChartTitle = _localizer["Team Members Over Time"]
                        },
                        new DashboardItem
                        {
                            Title = _localizer["Contacts"],
                            Value = contactCount,
                            IconClass = "bi-envelope-fill",
                            Description = _localizer["Recent communications"],
                            TrendText = _localizer["8% from last month"],
                            TrendClass = "text-success",
                            TrendIcon = "bi-arrow-up",
                            ChartId = "ContactCount",
                            ChartTitle = _localizer["Contacts Over Time"]
                        },
                        new DashboardItem
                        {
                            Title = _localizer["Roles"],
                            Value = roleCount,
                            IconClass = "bi-shield-lock-fill",
                            Description = _localizer["System access roles"],
                            TrendText = _localizer["3% from last month"],
                            TrendClass = "text-success",
                            TrendIcon = "bi-arrow-up",
                            ChartId = "RoleCount",
                            ChartTitle = _localizer["Roles Over Time"]
                        }
                    };

                    recentActivities = new List<RecentActivity>
                    {
                        new RecentActivity
                        {
                            Title = _localizer["New user registered"],
                            Time = _localizer["2 mins ago"],
                            Description = _localizer["John Doe joined the system"]
                        },
                        new RecentActivity
                        {
                            Title = _localizer["System update"],
                            Time = _localizer["15 mins ago"],
                            Description = _localizer["Version 2.3.1 deployed"]
                        }
                    };

                    quickActions = new List<QuickAction>
                    {
                        new QuickAction
                        {
                            Title = _localizer["Add New User"],
                            IconClass = "bi-person-plus"
                        },
                        new QuickAction
                        {
                            Title = _localizer["Create Report"],
                            IconClass = "bi-file-earmark-plus"
                        }
                    };
                    break;

                case nameof(UserRole.Accountant):
                    financialSummary = 100000;
                    invoiceCount = 25;
                    expenses = 50000;
                    profit = 50000;

                    dashboardItems = new List<DashboardItem>
                    {
                        new DashboardItem
                        {
                            Title = _localizer["Financial Summary"],
                            Value = (int)financialSummary,
                            IconClass = "bi-cash-coin",
                            Description = _localizer["Total revenue this month"],
                            TrendText = _localizer["10% from last month"],
                            TrendClass = "text-success",
                            TrendIcon = "bi-arrow-up",
                            ChartId = "FinancialSummary",
                            ChartTitle = _localizer["Financial Summary Over Time"]
                        },
                        new DashboardItem
                        {
                            Title = _localizer["Invoices"],
                            Value = invoiceCount,
                            IconClass = "bi-receipt",
                            Description = _localizer["Invoices generated this month"],
                            TrendText = _localizer["5% from last month"],
                            TrendClass = "text-danger",
                            TrendIcon = "bi-arrow-down",
                            ChartId = "InvoiceCount",
                            ChartTitle = _localizer["Invoices Over Time"]
                        },
                        new DashboardItem
                        {
                            Title = _localizer["Expenses"],
                            Value = (int)expenses,
                            IconClass = "bi-currency-dollar",
                            Description = _localizer["Total expenses this month"],
                            TrendText = _localizer["8% from last month"],
                            TrendClass = "text-success",
                            TrendIcon = "bi-arrow-up",
                            ChartId = "Expenses",
                            ChartTitle = _localizer["Expenses Over Time"]
                        },
                        new DashboardItem
                        {
                            Title = _localizer["Profit"],
                            Value = (int)profit,
                            IconClass = "bi-graph-up",
                            Description = _localizer["Net profit this month"],
                            TrendText = _localizer["15% from last month"],
                            TrendClass = "text-success",
                            TrendIcon = "bi-arrow-up",
                            ChartId = "Profit",
                            ChartTitle = _localizer["Profit Over Time"]
                        }
                    };

                    recentActivities = new List<RecentActivity>
                    {
                        new RecentActivity
                        {
                            Title = _localizer["Invoice Paid"],
                            Time = _localizer["2 mins ago"],
                            Description = _localizer["Invoice #1234 paid by John Doe"]
                        },
                        new RecentActivity
                        {
                            Title = _localizer["Expense Recorded"],
                            Time = _localizer["15 mins ago"],
                            Description = _localizer["Office supplies purchase recorded"]
                        }
                    };

                    quickActions = new List<QuickAction>
                    {
                        new QuickAction
                        {
                            Title = _localizer["Create Invoice"],
                            IconClass = "bi-file-earmark-plus"
                        },
                        new QuickAction
                        {
                            Title = _localizer["Record Payment"],
                            IconClass = "bi-cash-coin"
                        }
                    };
                    break;

                case nameof(UserRole.Sales):
                    dashboardItems = new List<DashboardItem>
                    {
                        new DashboardItem
                        {
                            Title = _localizer["Leads"],
                            Value = 50,
                            IconClass = "bi-person-lines-fill",
                            Description = _localizer["Active leads in system"],
                            TrendText = _localizer["20% from last month"],
                            TrendClass = "text-success",
                            TrendIcon = "bi-arrow-up",
                            ChartId = "Leads",
                            ChartTitle = _localizer["Leads Over Time"]
                        },
                        new DashboardItem
                        {
                            Title = _localizer["Deals Closed"],
                            Value = 10,
                            IconClass = "bi-check-circle-fill",
                            Description = _localizer["Deals closed this month"],
                            TrendText = _localizer["15% from last month"],
                            TrendClass = "text-success",
                            TrendIcon = "bi-arrow-up",
                            ChartId = "DealsClosed",
                            ChartTitle = _localizer["Deals Closed Over Time"]
                        }
                    };

                    recentActivities = new List<RecentActivity>
                    {
                        new RecentActivity
                        {
                            Title = _localizer["New Lead Added"],
                            Time = _localizer["2 mins ago"],
                            Description = _localizer["John Doe added as a new lead"]
                        },
                        new RecentActivity
                        {
                            Title = _localizer["Deal Closed"],
                            Time = _localizer["15 mins ago"],
                            Description = _localizer["Deal #1234 closed with Client A"]
                        }
                    };

                    quickActions = new List<QuickAction>
                    {
                        new QuickAction
                        {
                            Title = _localizer["Add New Lead"],
                            IconClass = "bi-person-plus"
                        },
                        new QuickAction
                        {
                            Title = _localizer["Create Proposal"],
                            IconClass = "bi-file-earmark-plus"
                        }
                    };
                    break;

                default:
                    dashboardItems = new List<DashboardItem>();
                    recentActivities = new List<RecentActivity>();
                    quickActions = new List<QuickAction>();
                    break;
            }

            return new AdminDashboardViewModel
            {
                DashboardItems = dashboardItems,
                RecentActivities = recentActivities,
                QuickActions = quickActions,
                FinancialSummary = financialSummary,
                InvoiceCount = invoiceCount,
                Expenses = expenses,
                Profit = profit
            };
        }
    }
}