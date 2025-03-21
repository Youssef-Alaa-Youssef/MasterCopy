using Factory.DAL.Models.HR;
using Factory.PL.ViewModels.HR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using Factory.PL.Services.UploadFile;
using Factory.BLL.InterFaces;

namespace Factory.PL.Controllers.HR
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IFileService _fileService;

        public EmployeeController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
            _fileService = fileService;
        }

        [Authorize()]
        public async Task<IActionResult> Index()
        {
            var employees = await _unitOfWork.GetRepository<Employee>().GetAllAsync();
            return View(employees);
        }

        [Authorize()]
        public async Task<IActionResult> Details(int id)
        {
            var employee = await _unitOfWork.GetRepository<Employee>().GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [Authorize()]
        public async Task<IActionResult> Create()
        {
            await PopulateDropdownLists();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize()]
        public async Task<IActionResult> Create(EmployeeViewModel employeeViewModel)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                var employee = new Employee
                {
                    FirstName = employeeViewModel.FirstName,
                    LastName = employeeViewModel.LastName,
                    FirstNameEn = employeeViewModel.FirstNameEn,
                    LastNameEn = employeeViewModel.LastNameEn,
                    EmployeeCode = employeeViewModel.EmployeeCode,
                    Email = employeeViewModel.Email,
                    Phone = employeeViewModel.Phone,
                    DateOfBirth = employeeViewModel.DateOfBirth,
                    HireDate = employeeViewModel.HireDate,
                    TerminationDate = employeeViewModel.TerminationDate,
                    Address = employeeViewModel.Address,
                    DepartmentId = employeeViewModel.DepartmentId,
                    PositionId = employeeViewModel.PositionId,
                    BaseSalary = employeeViewModel.BaseSalary,
                    IsActive = employeeViewModel.IsActive,
                    CreatedAt = DateTime.UtcNow,
                    UserId = userId ?? string.Empty
                };

                if (employeeViewModel.ImageFile != null)
                {
                    try
                    {
                        var fileName = await _fileService.UploadFileAsync(employeeViewModel.ImageFile, "employees");
                        employee.ImagePath = fileName;
                    }
                    catch (Exception ex)
                    {
                        TempData["Error"] = $"حدث خطأ أثناء تحميل الصورة. الخطأ: {ex.Message}";
                        await PopulateDropdownLists();
                        return View(employeeViewModel);
                    }
                }

                try
                {
                    await _unitOfWork.GetRepository<Employee>().AddAsync(employee);
                    TempData["Success"] = "تم إضافة الموظف بنجاح!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = $"حدث خطأ أثناء إضافة الموظف. الخطأ: {ex.Message}";
                }
            }

            await PopulateDropdownLists();
            return View(employeeViewModel);
        }

        [Authorize()]
        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _unitOfWork.GetRepository<Employee>().GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            var employeeViewModel = new EmployeeViewModel
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                FirstNameEn = employee.FirstNameEn,
                LastNameEn = employee.LastNameEn,
                EmployeeCode = employee.EmployeeCode,
                Email = employee.Email,
                Phone = employee.Phone,
                DateOfBirth = employee.DateOfBirth,
                HireDate = employee.HireDate,
                TerminationDate = employee.TerminationDate,
                Address = employee.Address,
                ImagePath = employee.ImagePath,
                DepartmentId = employee.DepartmentId,
                PositionId = employee.PositionId,
                BaseSalary = employee.BaseSalary,
                IsActive = employee.IsActive,
                CreatedAt = employee.CreatedAt
            };

            await PopulateDropdownLists();
            return View(employeeViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize()]
        public async Task<IActionResult> Edit(int id, EmployeeViewModel employeeViewModel)
        {
            if (id != employeeViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var employee = await _unitOfWork.GetRepository<Employee>().GetByIdAsync(id);
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (employee == null)
                {
                    return NotFound();
                }

                employee.FirstName = employeeViewModel.FirstName;
                employee.LastName = employeeViewModel.LastName;
                employee.FirstNameEn = employeeViewModel.FirstNameEn;
                employee.LastNameEn = employeeViewModel.LastNameEn;
                employee.EmployeeCode = employeeViewModel.EmployeeCode;
                employee.Email = employeeViewModel.Email;
                employee.Phone = employeeViewModel.Phone;
                employee.DateOfBirth = employeeViewModel.DateOfBirth;
                employee.HireDate = employeeViewModel.HireDate;
                employee.TerminationDate = employeeViewModel.TerminationDate;
                employee.Address = employeeViewModel.Address;
                employee.DepartmentId = employeeViewModel.DepartmentId;
                employee.PositionId = employeeViewModel.PositionId;
                employee.BaseSalary = employeeViewModel.BaseSalary;
                employee.IsActive = employeeViewModel.IsActive;
                employee.UserId = userId ?? string.Empty;

                if (employeeViewModel.ImageFile != null)
                {
                    // Delete the old image if it exists
                    if (!string.IsNullOrEmpty(employee.ImagePath))
                    {
                        var oldImageFileName = Path.GetFileName(employee.ImagePath);
                        await _fileService.DeleteFileAsync("employees", oldImageFileName);
                    }

                    try
                    {
                        var fileName = await _fileService.UploadFileAsync(employeeViewModel.ImageFile, "employees");
                        employee.ImagePath =  fileName;
                    }
                    catch (Exception ex)
                    {
                        TempData["Error"] = $"حدث خطأ أثناء تحميل الصورة. الخطأ: {ex.Message}";
                        await PopulateDropdownLists();
                        return View(employeeViewModel);
                    }
                }

                try
                {
                    await _unitOfWork.GetRepository<Employee>().UpdateAsync(employee);
                    TempData["Success"] = "تم تحديث بيانات الموظف بنجاح!";
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    TempData["Error"] = $"حدث خطأ أثناء تحديث بيانات الموظف. الخطأ: {ex.Message}";
                }
            }

            await PopulateDropdownLists();
            return View(employeeViewModel);
        }

        [Authorize()]
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _unitOfWork.GetRepository<Employee>().GetByIdAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize()]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _unitOfWork.GetRepository<Employee>().GetByIdAsync(id);
            if (employee != null)
            {
                try
                {
                    // Delete the image if it exists
                    if (!string.IsNullOrEmpty(employee.ImagePath))
                    {
                        var imageFileName = Path.GetFileName(employee.ImagePath);
                        await _fileService.DeleteFileAsync("employees", imageFileName);
                    }

                    await _unitOfWork.GetRepository<Employee>().RemoveAsync(employee);
                    TempData["Success"] = "تم حذف الموظف بنجاح!";
                }
                catch (Exception ex)
                {
                    TempData["Error"] = $"حدث خطأ أثناء حذف الموظف. الخطأ: {ex.Message}";
                }
            }
            else
            {
                TempData["Error"] = "الموظف غير موجود.";
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateDropdownLists()
        {
            var departments = await _unitOfWork.GetRepository<Department>().GetAllAsync();
            ViewBag.Departments = new SelectList(departments, "Id", "Name");

            var positions = await _unitOfWork.GetRepository<Position>().GetAllAsync();
            ViewBag.Positions = new SelectList(positions, "Id", "Title");
        }
    }
}