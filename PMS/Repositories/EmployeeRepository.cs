using PMS.Data;
using PMS.Data.Enums;
using PMS.Models;
using PMS.Models.Finance;
using PMS.Repositories.IRepositories;
using PMS.Utilities;
using PMS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMS.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;
        private readonly ITransactionRepository transactionRepository;

        public EmployeeRepository(ApplicationDbContext dbContext,
            PMSHelper pmsHelper,
            IHelperRepository helperRepository, ITransactionRepository transactionRepository)
        {
            this.dbContext = dbContext;
            this.pmsHelper = pmsHelper;
            this.helperRepository = helperRepository;
            this.transactionRepository = transactionRepository;
        }

        public Employee AddEmployee(Employee employee)
        {
            if (dbContext != null)
            {
                employee.UserId = pmsHelper.GetCurrentUserId();
                employee.UserName = pmsHelper.GetUserName(employee.UserId);
                employee.CreatedAt = DateTime.Now;
                employee.UpdatedAt = DateTime.Now;

                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();
                return employee;
            }
            return null;
        }



        public bool DeleteEmployee(long employeeid)
        {
            if (dbContext != null)
            {
                var DeleteQuerySelection = dbContext.Employees.FirstOrDefault(x => x.Id == employeeid);

                if (DeleteQuerySelection != null)
                {
                    DeleteQuerySelection.UserId = pmsHelper.GetCurrentUserId();
                    DeleteQuerySelection.UserName = pmsHelper.GetUserName(DeleteQuerySelection.UserId);
                    DeleteQuerySelection.DeletedAt = DateTime.Now;

                    dbContext.Employees.Update(DeleteQuerySelection);
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            return false;
        }

        public IEnumerable<EmployeeViewModel> GetAllEmployee()
        {
            if (dbContext != null)
            {
                List<EmployeeViewModel> list = new List<EmployeeViewModel>();
                var ModelList = dbContext.Employees.Where(x => x.DeletedAt == null && x.Leavedate == null).ToList();
                long sno = 1;
                var Country = "";
                var Province = "";
                var Designation = "";
                foreach (var employee in ModelList)
                {

                    if (employee.Countryid == 0)
                    {
                        Country = "";
                    }
                    else
                    {
                        Country = dbContext.Countries.FirstOrDefault(x => x.Id == employee.Countryid).Name;
                    }

                    if (employee.Provinceid == 0)
                    {
                        Province = "";
                    }
                    else
                    {
                        Province = dbContext.Provinces.FirstOrDefault(x => x.Id == employee.Provinceid).Name;
                    }

                    if (employee.DesignationId == 0)
                    {
                        Designation = "";
                    }
                    else
                    {
                        Designation = dbContext.Designations.FirstOrDefault(x => x.Id == employee.DesignationId).Name;
                    }

                    EmployeeViewModel model = new EmployeeViewModel
                    {
                        Id = employee.Id,
                        SNo = sno++,
                        Name = employee.Name,
                        Lastname = employee.Lastname,
                        Fathername = employee.Fathername,
                        NationalIdnumber = employee.NationalIdnumber,
                        Phone = employee.Phone,
                        Email = employee.Email,
                        Gender = (int)employee.Gender,
                        MaritalStatus = (int)employee.MaritalStatus,
                        EducationalDegree = (int)employee.EducationalDegree,
                        BaseSalary = employee.BaseSalary,
                        Birthdate = employee.Birthdate,
                        Hidredate = employee.Hiredate,
                        Leavedate = employee.Leavedate,
                        Details = employee.Details,
                        Provinceid = employee.Provinceid,
                        ProvinceName = Province,
                        Countryid = employee.Countryid,
                        CountryName = Country,
                        Address = employee.Address,
                        DesignationId = employee.DesignationId,
                        DesignationName = Designation,
                        Image = employee.Image,
                        //ImageFile = employee.ImageFile,
                        CreatedAt = employee.CreatedAt,
                        UpdatedAt = employee.UpdatedAt,
                        DeletedAt = employee.DeletedAt,
                        UserId = employee.UserId,
                        UserName = pmsHelper.GetUserName(employee.UserId)
                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }


        public IEnumerable<EmployeeViewModel> GetAllEmployeeFired()
        {
            if (dbContext != null)
            {
                List<EmployeeViewModel> list = new List<EmployeeViewModel>();
                var ModelList = dbContext.Employees.Where(x => x.DeletedAt == null && x.Leavedate != null).ToList();
                long sno = 1;
                var Country = "";
                var Province = "";
                var Designation = "";
                foreach (var employee in ModelList)
                {

                    if (employee.Countryid == 0)
                    {
                        Country = "";
                    }
                    else
                    {
                        Country = dbContext.Countries.FirstOrDefault(x => x.Id == employee.Countryid).Name;
                    }

                    if (employee.Provinceid == 0)
                    {
                        Province = "";
                    }
                    else
                    {
                        Province = dbContext.Provinces.FirstOrDefault(x => x.Id == employee.Provinceid).Name;
                    }

                    if (employee.DesignationId == 0)
                    {
                        Designation = "";
                    }
                    else
                    {
                        Designation = dbContext.Designations.FirstOrDefault(x => x.Id == employee.DesignationId).Name;
                    }
                    EmployeeViewModel model = new EmployeeViewModel
                    {
                        Id = employee.Id,
                        SNo = sno++,
                        Name = employee.Name,
                        Lastname = employee.Lastname,
                        Fathername = employee.Fathername,
                        NationalIdnumber = employee.NationalIdnumber,
                        Phone = employee.Phone,
                        Email = employee.Email,
                        Gender = (int)employee.Gender,
                        MaritalStatus = (int)employee.MaritalStatus,
                        EducationalDegree = (int)employee.EducationalDegree,
                        BaseSalary = employee.BaseSalary,
                        Birthdate = employee.Birthdate,
                        Hidredate = employee.Hiredate,
                        Leavedate = employee.Leavedate,
                        Details = employee.Details,
                        Provinceid = employee.Provinceid,
                        ProvinceName = Province,
                        Countryid = employee.Countryid,
                        CountryName = Country,
                        Address = employee.Address,
                        DesignationId = employee.DesignationId,
                        DesignationName = Designation,
                        Image = employee.Image,
                        //ImageFile = employee.ImageFile,
                        CreatedAt = employee.CreatedAt,
                        UpdatedAt = employee.UpdatedAt,
                        DeletedAt = employee.DeletedAt,
                        UserId = employee.UserId,
                        UserName = pmsHelper.GetUserName(employee.UserId)
                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public EmployeeViewModel GetByIdEmployee(long id)
        {
            if (dbContext != null)
            {
                var employee = dbContext.Employees.FirstOrDefault(x => x.Id == id);
                var Country = "";
                var Province = "";
                var Designation = "";
                if (employee.Countryid == 0)
                {
                    Country = "";
                }
                else
                {
                    Country = dbContext.Countries.FirstOrDefault(x => x.Id == employee.Countryid).Name;
                }

                if (employee.Provinceid == 0)
                {
                    Province = "";
                }
                else
                {
                    Province = dbContext.Provinces.FirstOrDefault(x => x.Id == employee.Provinceid).Name;
                }

                if (employee.DesignationId == 0)
                {
                    Designation = "";
                }
                else
                {
                    Designation = dbContext.Designations.FirstOrDefault(x => x.Id == employee.DesignationId).Name;
                }

                EmployeeViewModel model = new EmployeeViewModel
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Lastname = employee.Lastname,
                    Fathername = employee.Fathername,
                    NationalIdnumber = employee.NationalIdnumber,
                    Phone = employee.Phone,
                    Email = employee.Email,
                    Gender = (int)employee.Gender,
                    MaritalStatus = (int)employee.MaritalStatus,
                    EducationalDegree = (int)employee.EducationalDegree,
                    BaseSalary = employee.BaseSalary,
                    Birthdate = employee.Birthdate,
                    Hidredate = employee.Hiredate,
                    Leavedate = employee.Leavedate,
                    Details = employee.Details,
                    Provinceid = employee.Provinceid,
                    ProvinceName = Province,
                    Countryid = employee.Countryid,
                    CountryName = Country,
                    Address = employee.Address,
                    DesignationId = employee.DesignationId,
                    DesignationName = Designation,
                    ManagerName = dbContext.Employees.FirstOrDefault(x => x.Id == employee.Id).Name,
                    Image = employee.Image,
                    //ImageFile = employee.ImageFile,
                    CreatedAt = employee.CreatedAt,
                    UpdatedAt = employee.UpdatedAt,
                    DeletedAt = employee.DeletedAt,
                    UserId = employee.UserId,
                    UserName = pmsHelper.GetUserName(employee.UserId)
                };
                return model;
            }
            return null;
        }

        public Employee GetByIdForUpdate(long id)
        {
            if (dbContext != null)
            {
                return dbContext.Employees.FirstOrDefault(x => x.Id == id);
            }
            return null;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            if (dbContext != null)
            {
                employee.UserId = pmsHelper.GetCurrentUserId();
                employee.UserName = pmsHelper.GetUserName(employee.UserId);
                employee.UpdatedAt = DateTime.Now;

                dbContext.Employees.Update(employee);
                dbContext.SaveChanges();
                return employee;
            }
            return null;
        }


        //Salaries 
        public IEnumerable<EmployeeSalaryViewModel> GetAllEmployeeSalaries(int year, int month)
        {
            if (dbContext != null)
            {
                List<EmployeeSalaryViewModel> list = new List<EmployeeSalaryViewModel>();

                var employees = dbContext.Employees.ToList();

                foreach (var e in employees)
                {
                    EmployeeSalaryViewModel model = new EmployeeSalaryViewModel();

                    EmployeeSalary es = new EmployeeSalary();

                    if (year != 0 && month != 0)
                    {
                        var curDate = DateTime.Now;
                        int leaveMonth = 0;
                        if (e.Leavedate != null)
                        {
                            leaveMonth = DateTime.Parse(e.Leavedate.ToString()).Month;
                        }
                        es = dbContext.EmployeeSalaries.FirstOrDefault(x => x.EmployeeId == e.Id && (e.DeletedAt == null || leaveMonth == curDate.Month) && (x.SalaryYear == year && x.SalaryMonth == month));
                    }

                    else if (year != 0 && month == 0)
                    {
                        var curDate = DateTime.Now;
                        int leaveMonth = 0;
                        if (e.Leavedate != null)
                        {
                            leaveMonth = DateTime.Parse(e.Leavedate.ToString()).Month;
                        }
                        es = dbContext.EmployeeSalaries.FirstOrDefault(x => x.EmployeeId == e.Id && x.SalaryYear == year && (e.DeletedAt == null || leaveMonth == curDate.Month) && (x.SalaryYear == year));
                    }

                    else if (year == 0 && month != 0)
                    {

                        int leaveMonth = 0;
                        var curDate = DateTime.Now;

                        if (e.Leavedate != null)
                        {
                            leaveMonth = DateTime.Parse(e.Leavedate.ToString()).Month;
                        }
                        es = dbContext.EmployeeSalaries.FirstOrDefault(x => x.EmployeeId == e.Id && x.SalaryYear == year && (e.DeletedAt == null || leaveMonth == curDate.Month) && (x.SalaryMonth == month));
                    }

                    else
                    {
                        var curDate = DateTime.Now;
                        int leaveMonth = 0;
                        if (e.Leavedate != null)
                        {
                            leaveMonth = DateTime.Parse(e.Leavedate.ToString()).Month;
                        }
                        es = dbContext.EmployeeSalaries.FirstOrDefault(x => x.EmployeeId == e.Id && x.SalaryMonth == month && (e.DeletedAt == null || leaveMonth == curDate.Month) && (x.SalaryMonth == curDate.Month && x.SalaryYear == curDate.Year));
                    }

                    if (es != null)
                    {
                        model.Id = es.EmployeeId;
                        model.EmployeeId = e.Id;
                        model.EmployeeName = e.Name;
                        model.EmployeeFatherName = e.Fathername;
                        model.DesignationId = e.DesignationId;
                        model.Hiredate = e.Hiredate;
                        model.SalaryYear = es.SalaryYear;
                        model.SalaryMonth = es.SalaryMonth;
                        model.BasicSalary = e.BaseSalary;
                        model.TotalWorkDays = es.TotalWorkDays;
                        model.OverTime = es.OverTime;
                        model.Bounce = es.Bounce;
                        model.DesignationId = e.DesignationId;
                        model.DesignationName = dbContext.Designations.FirstOrDefault(x => x.Id == e.DesignationId).Name;
                        model.Tax = es.Tax;
                        model.NetSalary = es.NetSalary;
                        model.Paid = es.Paid;
                        model.Balanced = es.Balanced;
                        model.DueDate = es.DueDate;
                        model.UpdatedAt = es.UpdatedAt;
                        model.CreatedAt = es.CreatedAt;
                        model.UserName = helperRepository.GetUserName(es.UserId);
                        model.isPaid = es.isPaid;
                    }
                    else
                    {
                        model.Id = 0;
                        model.EmployeeId = e.Id;
                        model.EmployeeName = e.Name;
                        model.EmployeeFatherName = e.Fathername;
                        model.DesignationId = e.DesignationId;
                        model.DesignationName = dbContext.Designations.FirstOrDefault(x => x.Id == e.DesignationId).Name;
                        model.Hiredate = e.Hiredate;
                        model.BasicSalary = e.BaseSalary;
                        model.isPaid = false;
                    }
                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        public EmployeeSalaryViewModel GetByIdEmployeeSalary(long id)
        {
            if (dbContext != null)
            {
                var es = dbContext.EmployeeSalaries.FirstOrDefault(x => x.Id == id && x.DeletedAt == null);
                var e = dbContext.Employees.FirstOrDefault(x => x.Id == es.EmployeeId && x.DeletedAt == null);
                EmployeeSalaryViewModel model = new EmployeeSalaryViewModel();
                model.Id = es.Id;
                model.EmployeeId = es.EmployeeId;
                model.EmployeeName = e.Name;
                model.EmployeeFatherName = e.Fathername;
                model.DesignationId = e.DesignationId;
                model.DesignationName = dbContext.Designations.FirstOrDefault(x => x.Id == e.DesignationId).Name;
                model.Hiredate = e.Hiredate;
                model.SalaryYear = es.SalaryYear;
                model.SalaryMonth = es.SalaryMonth;
                model.BasicSalary = e.BaseSalary;
                model.TotalWorkDays = es.TotalWorkDays;
                model.OverTime = es.OverTime;
                model.Bounce = es.Bounce;
                model.Tax = es.Tax;
                model.NetSalary = es.NetSalary;
                model.Paid = es.Paid;
                model.Balanced = es.Balanced;
                model.DueDate = es.DueDate;
                model.UpdatedAt = es.UpdatedAt;
                model.UserName = helperRepository.GetUserName(es.UserId);
                model.isPaid = es.isPaid;
                return model;
            }
            return null;
        }
        public IEnumerable<EmployeeSalaryViewModel> GetAllSalariesPerEachEmployee(long id)
        {
            if (dbContext != null)
            {

                List<EmployeeSalaryViewModel> list = new List<EmployeeSalaryViewModel>();
                var e = dbContext.Employees.FirstOrDefault(x => x.Id == id);
                var employeeSalaries = dbContext.EmployeeSalaries.Where(x => x.EmployeeId == id && x.DeletedAt == null).ToList();
                if (employeeSalaries.Any())
                {
                    foreach (var es in employeeSalaries)
                    {
                        EmployeeSalaryViewModel model = new EmployeeSalaryViewModel
                        {
                            Id = es.Id,
                            EmployeeId = e.Id,
                            EmployeeName = e.Name,
                            EmployeeFatherName = e.Fathername,
                            DesignationId = e.DesignationId,
                            DesignationName = dbContext.Designations.FirstOrDefault(x => x.Id == e.DesignationId).Name,
                            Hiredate = e.Hiredate,
                            SalaryYear = es.SalaryYear,
                            SalaryMonth = es.SalaryMonth,
                            BasicSalary = e.BaseSalary,
                            TotalWorkDays = es.TotalWorkDays,
                            OverTime = es.OverTime,
                            Bounce = es.Bounce,
                            Tax = es.Tax,
                            NetSalary = es.NetSalary,
                            Paid = es.Paid,
                            Balanced = es.Balanced,
                            DueDate = es.DueDate,
                            UpdatedAt = es.UpdatedAt,
                            CreatedAt = es.CreatedAt,
                            UserName = helperRepository.GetUserName(es.UserId),
                            isPaid = es.isPaid
                        };
                        list.Add(model);
                    }
                    return list;
                }
                return list;
            }
            return null;
        }

        public IEnumerable<EmployeeLedgerViewModel> GetEmployeeLedgers(long employeeId = 0, int month = 0, int year = 0)
        {
            if (dbContext != null)
            {
                List<EmployeeLedgerViewModel> list = new List<EmployeeLedgerViewModel>();
                var models = dbContext.EmployeeLedgers.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                decimal pBalance = 0;
                string bFlg = "+";

                foreach (var m in models)
                {
                    pBalance = m.Debit - m.Credit;

                    long cid = dbContext.Employees.FirstOrDefault(x => x.Id == m.EntityId).Countryid;
                    long pid = dbContext.Employees.FirstOrDefault(x => x.Id == m.EntityId).Provinceid;
                    string address = "";
                    string country = "";
                    string province = "";
                    string addr = "";
                    int sMonth = 0;
                    int sYear = 0;
                    string entityName = "";
                    string entityPhone = "";

                    if (m.EntityId != 0)
                    {
                        cid = dbContext.Employees.FirstOrDefault(x => x.Id == m.EntityId).Countryid;
                        pid = dbContext.Employees.FirstOrDefault(x => x.Id == m.EntityId).Provinceid;
                        country = helperRepository.GetCountry().FirstOrDefault(x => x.Id == cid).Name;
                        province = helperRepository.GetProvinces().FirstOrDefault(x => x.Id == pid).Name;
                        addr = dbContext.Employees.FirstOrDefault(x => x.Id == m.EntityId).Address;
                        entityName = dbContext.Employees.FirstOrDefault(x => x.Id == m.EntityId).Name;
                        entityPhone = dbContext.Employees.FirstOrDefault(x => x.Id == m.EntityId).Phone;
                        sMonth = dbContext.EmployeeSalaries.FirstOrDefault(x => x.EmployeeId == m.EntityId).SalaryMonth;
                        sYear = dbContext.EmployeeSalaries.FirstOrDefault(x => x.EmployeeId == m.EntityId).SalaryYear;
                        address = addr + ", " + province + ", " + country;
                    }
                    else
                    {
                        address = "";
                        addr = "";
                        entityName = "";
                        entityPhone = "";
                    }

                    EmployeeLedgerViewModel model = new EmployeeLedgerViewModel
                    {
                        Id = m.Id,
                        SNo = sno++,
                        EntityId = m.EntityId,
                        EntityName = entityName,
                        EntityPhone = entityPhone,
                        EntityAddress = address,

                        SalaryMonth = sMonth,
                        SalaryYear = sYear,
                        Date = m.Date,
                        Description = m.Description,
                        Debit = m.Debit,
                        Credit = m.Credit,
                        VoucherNo = m.VoucherNo,
                        TransCode = m.TransCode,
                        isClosed = m.isClosed,
                        CreatedAt = m.CreatedAt,
                        UpdatedAt = m.UpdatedAt,
                        DeletedAt = m.DeletedAt,
                        Balance = pBalance,
                        BalanceFlag = bFlg,
                        UserId = m.UserId,
                        UserName = pmsHelper.GetUserName(m.UserId)
                    };
                    list.Add(model);
                }
                if (employeeId != 0 && month != 0 && year != 0)
                {
                    list = list.Where(x => x.EntityId == employeeId && x.SalaryMonth >= month && x.SalaryMonth <= year).ToList();

                }
                else if (employeeId == 0 && month != 0 && year != 0)
                {
                    list = list.Where(x => x.SalaryMonth >= month && x.SalaryYear <= year).ToList();
                }
                else if (employeeId != 0 && month == 0 && year == 0)
                {
                    list = list.Where(x => x.EntityId == employeeId).ToList();
                }
                else
                {
                    //do nothing
                }
                return list;
            }
            return null;
        }

        public EmployeeSalary AddEmployeeSalary(EmployeeSalary employeeSalary)
        {
            if (dbContext != null)
            {
                employeeSalary.UserId = pmsHelper.GetCurrentUserId();
                employeeSalary.UserName = pmsHelper.GetUserName(employeeSalary.UserId);
                employeeSalary.CreatedAt = DateTime.Now;
                employeeSalary.UpdatedAt = DateTime.Now;
                var transCode = helperRepository.GetTransactionCode();
                employeeSalary.TransCode = transCode;

                //Add Expense... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.EmployeeSalaries.Add(employeeSalary);

                    dbContext.SaveChanges();

                    long esId = dbContext.EmployeeSalaries.Max(x => x.Id);

                    EmployeeLedger employeeLedger = new EmployeeLedger
                    {
                        EntityId = employeeSalary.EmployeeId,
                        Date = DateTime.Now,
                        Description = helperRepository.EmployeeSalaryPaymentMsg(employeeSalary.Paid),
                        Debit = employeeSalary.Paid,
                        Credit = 0,
                        Balance = employeeSalary.Paid - 0,
                        TransCode = transCode,
                    };

                    Transaction transactions = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.EmployeeSalaryPaymentMsg(employeeSalary.Paid),
                        Amount = employeeSalary.Paid,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transactions))
                    {
                        var res = transactionRepository.AddEmployeeSalaryLedger(employeeLedger);
                    }

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.EmployeeSalaryTransictionMsg(employeeSalary.Paid),
                        Amount = employeeSalary.Paid,
                        Operation = Operation.Create
                    };

                    transactionRepository.AddTransactionLog(transaction1);

                    //cash Transaction
                    CashLedger cashLedger = new CashLedger
                    {
                        EntityId = employeeSalary.Id,
                        EntityType = EntityType.Employee,
                        Date = DateTime.Now,
                        Description = helperRepository.EmployeeSalaryPaymentMsg_Cash(employeeSalary.Paid),
                        VoucherNo = employeeSalary.TransCode,
                        Debit = 0,
                        Credit = employeeSalary.Paid,
                        Balance = 0 - employeeSalary.Paid,
                        TransCode = transCode,
                        TransType = CashType.EmployeeSalary
                    };

                    Transaction transaction2 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.EmployeeSalaryPaymentMsg_Cash(employeeSalary.Paid),
                        Amount = employeeSalary.Paid,
                        Operation = Operation.Create
                    };

                    if (transactionRepository.AddTransactionLog(transaction2))
                    {
                        var res = transactionRepository.AddCashLedger(cashLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }
                    transaction.Commit();
                    return employeeSalary;
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public EmployeeSalary UpdateEmployeeSalary(EmployeeSalary employeeSalary)
        {
            if (dbContext != null)
            {
                employeeSalary.UserId = pmsHelper.GetCurrentUserId();
                employeeSalary.UserName = pmsHelper.GetUserName(employeeSalary.UserId);
                employeeSalary.CreatedAt = employeeSalary.CreatedAt;
                employeeSalary.UpdatedAt = DateTime.Now;

                var transCode = employeeSalary.TransCode;

                //Edit Suppler... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.EmployeeSalaries.Update(employeeSalary);
                    dbContext.SaveChanges();

                    var cLedger = dbContext.CashLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    ////var employeeLeder = dbContext.EmployeeLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    if (cLedger != null)
                    {
                        var res = transactionRepository.DeleteCashLedger(cLedger);
                    }

                    //if (employeeLeder != null)

                    //{

                    //   // var res = transactionRepository.DeleteEmployeeSalaryLedger(employeeLeder);

                    //}

                    var eledger = dbContext.EmployeeLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    eledger.EntityId = employeeSalary.EmployeeId;
                    eledger.Debit = employeeSalary.Paid;
                    eledger.Balance = employeeSalary.Paid - 0;
                    eledger.Description = helperRepository.EmployeeSalaryPaymentMsg(employeeSalary.Paid);

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.SupplierPaymentMsg(employeeSalary.Paid),
                        Amount = employeeSalary.Paid,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction1))
                    {
                        var res = transactionRepository.UpdateEmployeeSalaryLedger(eledger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    CashLedger cashLedger = new CashLedger
                    {
                        EntityId = employeeSalary.EmployeeId,
                        EntityType = EntityType.Supplier,
                        Date = employeeSalary.DueDate,
                        Description = helperRepository.EmployeeSalaryPaymentMsg(employeeSalary.Paid),
                        VoucherNo = null,
                        Debit = 0,
                        Credit = employeeSalary.Paid,
                        Balance = 0 - employeeSalary.Paid,
                        TransCode = transCode,
                        TransType = CashType.SupplierPayment
                    };

                    Transaction transaction2 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Credit,
                        Description = helperRepository.SupplierPaymentMsg_Cash(employeeSalary.Paid),
                        Amount = employeeSalary.Paid,
                        Operation = Operation.Update
                    };

                    if (transactionRepository.AddTransactionLog(transaction2))
                    {
                        var res = transactionRepository.AddCashLedger(cashLedger);
                        if (res == null)
                        {
                            return null;
                        }
                    }

                    transaction.Commit();
                    return employeeSalary;
                }
                catch
                {
                    return null;
                }

            }
            return null;
        }

        public bool DeleteEmployeeSalary(long id)
        {
            if (dbContext != null)
            {
                var m = dbContext.EmployeeSalaries.FirstOrDefault(x => x.Id == id);

                if (m != null)
                {
                    var transCode = m.TransCode;
                    using var transaction = dbContext.Database.BeginTransaction();
                    try
                    {
                        var cLedger = dbContext.CashLedgers.FirstOrDefault(x => x.TransCode == transCode);
                        var ELedger = dbContext.EmployeeLedgers.FirstOrDefault(x => x.TransCode == transCode);

                        if (cLedger != null)
                        {
                            var res = transactionRepository.DeleteCashLedger(cLedger);
                        }

                        if (ELedger != null)
                        {
                            var res = transactionRepository.DeleteEmployeeSalaryLedger(ELedger);
                        }

                        dbContext.EmployeeSalaries.Remove(m);
                        dbContext.SaveChanges();

                        Transaction transaction1 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.EmployeeSalaryTransactionDelete_Msg(m.Paid),
                            Amount = m.Paid,
                            Operation = Operation.Delete
                        };
                        transactionRepository.AddTransactionLog(transaction1);
                        transaction.Commit();
                    }
                    catch
                    {
                        return false;
                    }

                    return true;
                }

                return false;
            }
            return false;
        }

        public EmployeeSalary GetSalaryByIdForUpdate(long id)
        {
            if (dbContext != null)
            {
                return dbContext.EmployeeSalaries.FirstOrDefault(x => x.Id == id);
            }
            return null;
        }
    }
}
