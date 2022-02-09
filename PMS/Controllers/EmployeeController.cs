
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models;
using PMS.Repositories.IRepositories;
using System;
using System.IO;

namespace PMS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IToastNotification toastNotification;
        private readonly IHelperRepository helperRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        public EmployeeController(IEmployeeRepository employeeRepository,
            IToastNotification toastNotification,
            IHelperRepository helperRepository,
            IWebHostEnvironment webHostEnvironment)
        {
            this.employeeRepository = employeeRepository;
            this.toastNotification = toastNotification;
            this.helperRepository = helperRepository;
            this.webHostEnvironment = webHostEnvironment;
        }

        // GET: EmployeeController
        [HttpGet]
        public ActionResult Index()
        {
            return View(employeeRepository.GetAllEmployee());
        }

        // GET: EmployeeController/Details/5
        [HttpGet]
        public ActionResult Details(long id)
        {
            return View(employeeRepository.GetByIdEmployee(id));
        }

        public ActionResult FiredEmployeeList()
        {
            return View(employeeRepository.GetAllEmployeeFired());
        }

        // GET: EmployeeController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Designation = new SelectList(helperRepository.GetDesignations(), "Id", "Name");

            return View(new Employee());
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {

            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Designation = new SelectList(helperRepository.GetDesignations(), "Id", "Name");
            if (ModelState.IsValid)
            {
                try
                {

                    employee.Image = ProcessUploadedFile(employee);

                    var res = employeeRepository.AddEmployee(employee);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(employee);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(employee);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(employee);
            }
        }

        // GET: EmployeeController/Edit/5
        [HttpGet]
        public ActionResult Edit(long id)
        {
            ViewBag.Provinces = new SelectList(helperRepository.GetProvinces(), "Id", "Name");
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Designation = new SelectList(helperRepository.GetDesignations(), "Id", "Name");

            var Employee = employeeRepository.GetByIdForUpdate(id);
            return View(Employee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            ViewBag.Provinces = new SelectList(helperRepository.GetProvinces(), "Id", "Name");
            ViewBag.Countries = new SelectList(helperRepository.GetCountry(), "Id", "Name");
            ViewBag.Designation = new SelectList(helperRepository.GetDesignations(), "Id", "Name");

            if (ModelState.IsValid)
            {
                try
                {
                    if (employee.ImageFile != null)
                    {
                        if (employee.Image != null)
                        {
                            string filePath = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/employee-profile", employee.Image);
                            System.IO.File.Delete(filePath);
                        }
                        employee.Image = ProcessUploadedFile(employee);
                    }
                    var res = employeeRepository.UpdateEmployee(employee);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(employee);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(employee);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(employee);
            }
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            bool isDeleted = false;

            if (ModelState.IsValid)
            {
                try
                {
                    var res = employeeRepository.DeleteEmployee(id);
                    if (res)
                    {
                        isDeleted = true;
                    }
                }
                catch
                {
                    isDeleted = false;
                }
            }

            if (isDeleted)
            {
                helperRepository.SuccessMessage();
            }
            else
            {
                helperRepository.ErrorMessage();
            }
            return RedirectToAction(nameof(Index));
        }

        private string ProcessUploadedFile(Employee model)
        {
            string uniqueFileName = null;
            if (model.ImageFile != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Uploads/employee-profile");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageFile.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }

        //Salaries 

        public ActionResult EmployeeSalaries(int month, int year)
        {
            int y = DateTime.Now.Year;
            ViewBag.CurrenYear = y;
            if (month == 0)
                month = DateTime.Now.Month;
            if (year == 0)
                year = DateTime.Now.Year;

            ViewBag.Y = year;
            ViewBag.M = month;

            var employeeSalaries = employeeRepository.GetAllEmployeeSalaries(year, month);
            return View(employeeSalaries);
        }

        public ActionResult EmployeeSalaryDetails(long id) //EmployeeSalaryDetails
        {
            var empSalary = employeeRepository.GetByIdEmployeeSalary(id);
            return View(empSalary);
        }

        public ActionResult EmployeeSalaryDetailsEach(long id) // EmployeeSalaryDetailsEach
        {
            var employee = employeeRepository.GetByIdEmployee(id);
            ViewBag.Emp = employee;
            ViewBag.BaseSalary = employee.BaseSalary;
            ViewBag.Name = employee.Name;
            ViewBag.Fathername = employee.Fathername;
            ViewBag.DesignationName = employee.DesignationName;

            ViewBag.Phone = employee.Phone;
            ViewBag.Hidredate = employee.Hidredate;
            ViewBag.Address = employee.Address;

            ViewBag.Id = employee.Id;
            var employeeSalaries = employeeRepository.GetAllSalariesPerEachEmployee(id);
            return View(employeeSalaries);
        }

        public ActionResult EmployeeSalaryCreate(long id) //EmployeeSalaryCreate
        {
            var employee = employeeRepository.GetByIdEmployee(id);
            ViewBag.Emp = employee;
            ViewBag.BaseSalary = employee.BaseSalary;
            ViewBag.Name = employee.Name;
            ViewBag.Fathername = employee.Fathername;
            ViewBag.DesignationName = employee.DesignationName;

            ViewBag.Phone = employee.Phone;
            ViewBag.Hidredate = employee.Hidredate;
            ViewBag.Address = employee.Address;

            ViewBag.Id = employee.Id;

            int year = DateTime.Now.Year;
            ViewBag.CurrenYear = year;
            return View(new EmployeeSalary());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmployeeSalaryCreate(EmployeeSalary employeeSalary)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    employeeSalary.isPaid = true;
                    var res = employeeRepository.AddEmployeeSalary(employeeSalary);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(EmployeeSalaries));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(employeeSalary);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(employeeSalary);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(employeeSalary);
            }
        }

        public ActionResult EmployeeSalaryEdit(long id, long empId) //EmployeeSalaryEdit
        {
            var employee = employeeRepository.GetByIdEmployee(empId);
            ViewBag.BaseSalary = employee.BaseSalary;
            ViewBag.Name = employee.Name;
            ViewBag.Fathername = employee.Fathername;
            ViewBag.DesignationName = employee.DesignationName;

            ViewBag.Phone = employee.Phone;
            ViewBag.Hidredate = employee.Hidredate;
            ViewBag.Address = employee.Address;

            ViewBag.Id = employee.Id;
            int year = 2021;
            ViewBag.CurrenYear = year;

            var EmployeeEditRow = employeeRepository.GetSalaryByIdForUpdate(id);
            if (EmployeeEditRow == null)
            {
                return NotFound();
            }
            return View(EmployeeEditRow);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EmployeeSalaryEdit(EmployeeSalary employeeSalary)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    employeeSalary.isPaid = true;
                    //employeeSalary.CreatedAt = employeeSalary.CreatedAt;
                    var res = employeeRepository.UpdateEmployeeSalary(employeeSalary);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(EmployeeSalaries));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(employeeSalary);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(employeeSalary);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(employeeSalary);
            }
        }
        public ActionResult DeleteEmployeeSalary(long Id)//DeleteEmployeeSalary
        {
            try
            {
                bool isDeleted = false;

                if (ModelState.IsValid)
                {
                    try
                    {
                        var res = employeeRepository.DeleteEmployeeSalary(Id);
                        if (res)
                        {
                            isDeleted = true;
                        }
                    }
                    catch
                    {
                        isDeleted = false;
                    }
                }

                if (isDeleted)
                {
                    helperRepository.SuccessMessage();
                }
                else
                {
                    helperRepository.ErrorMessage();
                }
                return RedirectToAction(nameof(EmployeeSalaries));
            }
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return RedirectToAction("Index");
            }
        }

        //Ledger Action Methods
        public ActionResult GetAllLedgers()
        {
            int year = DateTime.Now.Year;
            ViewBag.CurrenYear = year;

            ViewBag.Employees = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            var employeeLedgers = employeeRepository.GetEmployeeLedgers(0, 0, 0);
            return View(employeeLedgers);
        }

        public ActionResult GetLedgerById(long employeeId, int month, int year)
        {
            int getyear = DateTime.Now.Year;
            ViewBag.CurrenYear = getyear;

            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            var employeeLedgers = employeeRepository.GetEmployeeLedgers(0, 0, 0);

            if (employeeId != 0 && month != 0 && year != 0)
            {
                employeeLedgers = employeeRepository.GetEmployeeLedgers(employeeId, month, year);
                var spp = employeeRepository.GetByIdEmployee(employeeId);
                ViewBag.EmployeeName = spp.Name;
                ViewBag.EmployeePhone = spp.Phone;
                ViewBag.EmployeeAddress = spp.Address;
                ViewBag.Month = month;
                ViewBag.Year = year;

                return View(employeeLedgers);
            }
            else if (employeeId == 0 && month != 0 && year != 0)
            {
                employeeLedgers = employeeRepository.GetEmployeeLedgers(0, month, year);
                ViewBag.SupplierName = null;
                ViewBag.SupplierPhone = null;
                ViewBag.SupplierAddress = null;
                ViewBag.StartDate = month;
                ViewBag.EndDate = year;

                return View(employeeLedgers);
            }
            else if (employeeId != 0 && month == 0 && year == 0)
            {
                employeeLedgers = employeeRepository.GetEmployeeLedgers(employeeId, 0, 0);
                var spp = employeeRepository.GetByIdEmployee(employeeId);
                ViewBag.EmployeeName = spp.Name;
                ViewBag.EmployeePhone = spp.Phone;
                ViewBag.EmployeeAddress = spp.Address;
                ViewBag.StartDate = null;
                ViewBag.EndDate = null;

                return View(employeeLedgers);
            }
            else
            {
                helperRepository.AlertMessage("Please enter correct filter details!");
                return View("GetAllLedgers", employeeLedgers);
            }
        }
    }
}
