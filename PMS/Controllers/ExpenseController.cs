using AspNetCore.Reporting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;
using PMS.Models;
using PMS.Repositories.IRepositories;
using PMS.ViewModels;
using System;
using System.Collections.Generic;

namespace PMS.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IToastNotification toastNotification;
        private readonly IExpenseRepository expenseRepository;
        private readonly IHelperRepository helperRepository;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IShopRepository shopRepository;

        public ExpenseController(IToastNotification toastNotification,
            IExpenseRepository expenseRepository,
            IHelperRepository helperRepository, IWebHostEnvironment webHostEnvironment, IShopRepository shopRepository)
        {
            this.toastNotification = toastNotification;
            this.expenseRepository = expenseRepository;
            this.shopRepository = shopRepository;
            this.helperRepository = helperRepository;
            this.webHostEnvironment = webHostEnvironment;

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        // GET: ExpenseController
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.ExpenseCategory = new SelectList(helperRepository.GetExpenseCategory(), "Id", "Name");
            return View(expenseRepository.GetAllExpense());
        }

        // GET: ExpenseController/Create
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.ExpenseCategory = new SelectList(helperRepository.GetExpenseCategory(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");
            return View(new Expense());
        }

        // POST: ExpenseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Expense expense, int sbm_flg)
        {
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.ExpenseCategory = new SelectList(helperRepository.GetExpenseCategory(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            if (ModelState.IsValid)
            {
                try
                {
                    var res = expenseRepository.AddExpensePayment(expense);
                    if (res != 0)
                    {
                        helperRepository.SuccessMessage();

                        if (sbm_flg == 0)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                        else
                        {
                            return RedirectToAction("PrintDivSave", "Expense", new { Id = res });
                        }
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(expense);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(expense);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(expense);
            }
        }

        // GET: ExpenseController/Edit/5
        [HttpGet]
        public ActionResult Edit(long id)
        {
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.ExpenseCategory = new SelectList(helperRepository.GetExpenseCategory(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            var model = expenseRepository.GetExpense(id);
            return View(model);
        }

        // POST: ExpenseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Expense expense)
        {
            ViewBag.Employee = new SelectList(helperRepository.GetEmployees(), "Id", "Name");
            ViewBag.ExpenseCategory = new SelectList(helperRepository.GetExpenseCategory(), "Id", "Name");
            ViewBag.Banks = new SelectList(helperRepository.GetBanks(), "Id", "BankName");

            if (ModelState.IsValid)
            {
                try
                {
                    var res = expenseRepository.EditExpensePayment(expense);
                    if (res != null)
                    {
                        helperRepository.SuccessMessage();
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        helperRepository.ErrorMessage();
                        return View(expense);
                    }
                }
                catch
                {
                    helperRepository.ErrorMessage();
                    return View(expense);
                }
            }
            else
            {
                helperRepository.WarningMessage("Please check your form and then submit it!");
                return View(expense);
            }
        }

        // POST: SupplierController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long Id)
        {
            try
            {
                bool isDeleted = false;

                if (ModelState.IsValid)
                {
                    try
                    {
                        var res = expenseRepository.DeleteExpense(Id);
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
            catch
            {
                toastNotification.AddErrorToastMessage("Please enter correct data and try again!");
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult ExpensePaymentSearchByCategory(long expenseCategoryId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.ExpenseCategory = new SelectList(helperRepository.GetExpenseCategory(), "Id", "Name");
            var models = expenseRepository.GetExpenseBySearch(expenseCategoryId, startDate, endDate);
            return View(models);
        }

        [HttpGet]
        public ActionResult ExpenseStatement()
        {
            ViewBag.Category = "";
            ViewBag.StartDate = "";
            ViewBag.EndDate = "";
            ViewBag.flg = 0;
            ViewBag.ExpenseCategory = new SelectList(helperRepository.GetExpenseCategory(), "Id", "Name");
            List<ExpenseViewModel> models = new List<ExpenseViewModel>();
            return View(models);
        }

        [HttpPost]
        public ActionResult ExpenseStatement(long expenseCategoryId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.flg = 1;
            ViewBag.Category = helperRepository.getExpenseCategoryName(expenseCategoryId);
            ViewBag.StartDate = startDate;
            ViewBag.EndDate = endDate;

            ViewBag.ExpenseCategory = new SelectList(helperRepository.GetExpenseCategory(), "Id", "Name");
            var models = expenseRepository.GetExpenseBySearch(expenseCategoryId, startDate, endDate);
            return View(models);
        }

        // Bill Print  in Divs...
        public ActionResult PrintDiv(long Id)
        {

            return View(expenseRepository.GetByIdExpense(Id));
        }

        public ActionResult PrintDivSave(long Id)
        {
            return View(expenseRepository.GetByIdExpense(Id));
        }

        public ActionResult PrintExpneseDivStatment(long expenseCategoryId, DateTime? startDate, DateTime? endDate)
        {
            ViewBag.Category = helperRepository.getExpenseCategoryName(expenseCategoryId);

            return View(expenseRepository.GetExpenseBySearchStatment(expenseCategoryId, startDate, endDate));
        }

        //Print by perviuse 
        public ActionResult PrintSaveSlip(long Id)
        {
            string mimeType = "";
            int extension = 1;
            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\Expense.rdlc";
            var shop = shopRepository.GetShop();
            var expense = expenseRepository.GetExpensePrint(Id);
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);
            parameters.Add("Id", expense.Id.ToString());
            parameters.Add("Date", expense.Date.ToString());
            parameters.Add("EmployeeName", expense.EmployeeName.ToString());
            parameters.Add("ExpenseCategoryName", expense.ExpenseCategoryName.ToString());
            parameters.Add("Amount", expense.Amount.ToString());
            parameters.Add("Description", expense.Description.ToString());
            parameters.Add("BillNumber", expense.BillNumber.ToString());

            LocalReport localReport = new LocalReport(path);
            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);
            return File(res.MainStream, "application/pdf");
        }

        public ActionResult PrintSlip(long id, long Maxid)
        {
            string mimeType = "";
            int extension = 1;
            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\Expense.rdlc";
            var shop = shopRepository.GetShop();
            var expense = expenseRepository.GetByIdExpense(id);
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);

            parameters.Add("Id", expense.Id.ToString());
            parameters.Add("Date", expense.Date.ToString());
            parameters.Add("EmployeeName", expense.EmployeeName.ToString());
            parameters.Add("ExpenseCategoryName", expense.ExpenseCategoryName.ToString());
            parameters.Add("Amount", expense.Amount.ToString());
            parameters.Add("Description", expense.Description.ToString());
            parameters.Add("BillNumber", expense.BillNumber.ToString());

            LocalReport localReport = new LocalReport(path);
            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);
            return File(res.MainStream, "application/pdf");
        }

        public ActionResult PrintExpenseStatment(long expenseCategoryId, DateTime? startDate, DateTime? endDate)
        {
            string mimeType = "";

            int extension = 1;

            var path = $"{webHostEnvironment.WebRootPath}\\Reports\\ExpenseStatment.rdlc";

            var shop = shopRepository.GetShop();

            var expense = expenseRepository.GetExpenseBySearchStatment(expenseCategoryId, startDate, endDate);

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters.Add("shopName", shop.Name_en);
            parameters.Add("shopAddress", shop.Address_en);
            parameters.Add("shopPhone", shop.Phone1);
            parameters.Add("shopEmail", shop.Email1);

            parameters.Add("startDate", startDate.ToString());
            parameters.Add("endDate", endDate.ToString());
            parameters.Add("expenseCategoryId", expenseCategoryId.ToString());

            //parameters.Add("Id", expense.Id.ToString());
            //parameters.Add("Date", expense.Date.ToString());
            //parameters.Add("EmployeeName", expense.EmployeeName.ToString());
            //parameters.Add("ExpenseCategoryName", expense.ExpenseCategoryName.ToString());
            //parameters.Add("Amount", expense.Amount.ToString());
            //parameters.Add("Description", expense.Description.ToString());
            //parameters.Add("BillNumber", expense.BillNumber.ToString());

            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("ExpenseLedger", expense);

            var res = localReport.Execute(RenderType.Pdf, extension, parameters, mimeType);

            return File(res.MainStream, "application/pdf");
        }


    }
}
