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
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly PMSHelper pmsHelper;
        private readonly IHelperRepository helperRepository;
        private readonly ITransactionRepository transactionRepository;

        public ExpenseRepository(ApplicationDbContext dbContext,
            PMSHelper pmsHelper,
            IHelperRepository helperRepository,
            ITransactionRepository transactionRepository)
        {
            this.dbContext = dbContext;
            this.pmsHelper = pmsHelper;
            this.helperRepository = helperRepository;
            this.transactionRepository = transactionRepository;
        }


        public long AddExpensePayment(Expense expense)
        {
            if (dbContext != null)
            {


                var transCode = helperRepository.GetTransactionCode();
                expense.TransCode = transCode;

                //Add Expense... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    //dbContext.Expenses.Add(expense);

                    var expenseId = AddNewExpense(expense);

                    dbContext.SaveChanges();

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.ExpensePaymentMsg(expense.Amount),
                        Amount = expense.Amount,
                        Operation = Operation.Create
                    };

                    transactionRepository.AddTransactionLog(transaction1);

                    if (expense.PaymentType == 0)
                    {
                        //cash Transaction
                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = expense.Id,
                            EntityType = EntityType.Expense,
                            Date = DateTime.Now,
                            Description = helperRepository.ExpensePaymentMsg_Cash(expense.Amount),
                            VoucherNo = expense.BillNumber,
                            Debit = 0,
                            Credit = expense.Amount,
                            Balance = 0 - expense.Amount,
                            TransCode = transCode,
                            TransType = CashType.Expense
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.ExpensePaymentMsg_Cash(expense.Amount),
                            Amount = expense.Amount,
                            Operation = Operation.Create
                        };

                        if (transactionRepository.AddTransactionLog(transaction2))
                        {
                            var res = transactionRepository.AddCashLedger(cashLedger);
                            if (res == null)
                            {
                                return 0;
                            }
                        }
                    }

                    else if (expense.PaymentType == 1)
                    {
                        //bank Transaction ..
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = (long)expense.BankId,
                            EntityType = EntityType.Expense,
                            Date = DateTime.Now,
                            Description = helperRepository.ExpensePaymentMsg_Bank(expense.Amount),
                            VoucherNo = expense.BillNumber,
                            Debit = 0,
                            Credit = expense.Amount,
                            Balance = 0 - expense.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.ExpensePaymentMsg_Bank(expense.Amount),
                            Amount = expense.Amount,
                            Operation = Operation.Create
                        };

                        if (transactionRepository.AddTransactionLog(transaction3))
                        {
                            var res = transactionRepository.AddBankLedger(bankLedger);
                            if (res == null)
                            {
                                return 0;
                            }
                        }
                    }
                    else
                    {
                        return 0;
                    }

                    transaction.Commit();
                    return expenseId;
                }
                catch
                {
                    return 0;
                }
            }
            return 0;
        }

        public Expense EditExpensePayment(Expense expense)
        {
            if (dbContext != null)
            {
                expense.UserId = pmsHelper.GetCurrentUserId();
                expense.UserName = pmsHelper.GetUserName(expense.UserId);
                expense.CreatedAt = expense.CreatedAt;
                expense.UpdatedAt = DateTime.Now;

                var transCode = expense.TransCode;

                //Edit Expense... 
                using var transaction = dbContext.Database.BeginTransaction();
                try
                {
                    dbContext.Expenses.Update(expense);
                    dbContext.SaveChanges();

                    var cLedger = dbContext.CashLedgers.FirstOrDefault(x => x.TransCode == transCode);
                    var bLedger = dbContext.BankLedgers.FirstOrDefault(x => x.TransCode == transCode);

                    if (cLedger != null)
                    {
                        var res = transactionRepository.DeleteCashLedger(cLedger);
                    }

                    if (bLedger != null)
                    {
                        var res = transactionRepository.DeleteBankLedger(bLedger);
                    }

                    Transaction transaction1 = new Transaction
                    {
                        TransCode = transCode,
                        TransDate = DateTime.Now,
                        TransType = TType.Debit,
                        Description = helperRepository.ExpensePaymentMsg(expense.Amount),
                        Amount = expense.Amount,
                        Operation = Operation.Update
                    };

                    transactionRepository.AddTransactionLog(transaction1);

                    if (expense.PaymentType == 0)
                    {
                        //cash

                        CashLedger cashLedger = new CashLedger
                        {
                            EntityId = expense.Id,
                            EntityType = EntityType.Expense,
                            Date = expense.ExpenseDate,
                            Description = helperRepository.ExpensePaymentMsg_Cash(expense.Amount),
                            VoucherNo = expense.BillNumber,
                            Debit = 0,
                            Credit = expense.Amount,
                            Balance = 0 - expense.Amount,
                            TransCode = transCode,
                            TransType = CashType.Expense
                        };

                        Transaction transaction2 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.ExpensePaymentMsg_Cash(expense.Amount),
                            Amount = expense.Amount,
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
                    }

                    else if (expense.PaymentType == 1)
                    {
                        //bank
                        BankLedger bankLedger = new BankLedger
                        {
                            EntityId = (long)expense.BankId,
                            EntityType = EntityType.Bank,
                            Date = expense.ExpenseDate,
                            Description = helperRepository.ExpensePaymentMsg_Bank(expense.Amount),
                            Debit = 0,
                            VoucherNo = expense.BillNumber,
                            Credit = expense.Amount,
                            Balance = 0 - expense.Amount,
                            TransCode = transCode,
                            BankTransactionId = 0,
                        };

                        Transaction transaction3 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Credit,
                            Description = helperRepository.ExpensePaymentMsg_Bank(expense.Amount),
                            Amount = expense.Amount,
                            Operation = Operation.Update
                        };

                        if (transactionRepository.AddTransactionLog(transaction3))
                        {
                            var res = transactionRepository.AddBankLedger(bankLedger);
                            if (res == null)
                            {
                                return null;
                            }
                        }
                    }
                    else
                    {
                        return null;
                    }

                    transaction.Commit();
                    return expense;
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public bool DeleteExpense(long expenseId)
        {
            if (dbContext != null)
            {
                var m = dbContext.Expenses.FirstOrDefault(x => x.Id == expenseId);
                if (m != null)
                {
                    var transCode = m.TransCode;

                    m.UserId = pmsHelper.GetCurrentUserId();
                    m.UserName = pmsHelper.GetUserName(m.UserId);
                    m.DeletedAt = DateTime.Now;

                    using var transaction = dbContext.Database.BeginTransaction();
                    try
                    {
                        dbContext.Expenses.Update(m);
                        dbContext.SaveChanges();

                        var cLedger = dbContext.CashLedgers.FirstOrDefault(x => x.TransCode == transCode);

                        var bLedger = dbContext.BankLedgers.FirstOrDefault(x => x.TransCode == transCode);

                        if (cLedger != null)
                        {
                            var res = transactionRepository.DeleteCashLedger(cLedger);
                        }

                        if (bLedger != null)
                        {
                            var res = transactionRepository.DeleteBankLedger(bLedger);
                        }

                        Transaction transaction1 = new Transaction
                        {
                            TransCode = transCode,
                            TransDate = DateTime.Now,
                            TransType = TType.Debit,
                            Description = helperRepository.ExpenseTransactionDelete_Msg(m.Amount),
                            Amount = m.Amount,
                            Operation = Operation.Delete
                        };
                        transactionRepository.AddTransactionLog(transaction1);
                        if (m.PaymentType == 0)
                        {
                            //cash
                            CashLedger cashLedger = new CashLedger
                            {
                                EntityId = m.Id,
                                EntityType = EntityType.Expense,
                                Date = m.ExpenseDate,
                                Description = helperRepository.ExpenseDeletePaymentMsg_Cash(m.Amount),
                                VoucherNo = m.BillNumber,
                                Debit = m.Amount,
                                Credit = 0,
                                Balance = m.Amount - 0,
                                TransCode = transCode,
                                TransType = CashType.Expense
                            };

                            Transaction transaction2 = new Transaction
                            {
                                TransCode = transCode,
                                TransDate = DateTime.Now,
                                TransType = TType.Debit,
                                Description = helperRepository.ExpenseDeletePaymentMsg_Cash(m.Amount),
                                Amount = m.Amount,
                                Operation = Operation.Delete
                            };

                            if (transactionRepository.AddTransactionLog(transaction2))
                            {
                                var res = transactionRepository.AddCashLedger(cashLedger);
                                if (res == null)
                                {
                                    return false;
                                }
                            }
                        }
                        else if (m.PaymentType == 1)
                        {
                            //bank
                            BankLedger bankledger = new BankLedger
                            {
                                EntityId = (long)m.BankId,
                                EntityType = EntityType.Expense,
                                Date = DateTime.Now,
                                Description = helperRepository.ExpenseDeletePaymentMsg_Bank(m.Amount),
                                VoucherNo = m.BillNumber,
                                Debit = m.Amount,
                                Credit = 0,
                                Balance = m.Amount - 0,
                                TransCode = transCode,
                                BankTransactionId = 0,
                            };

                            Transaction transaction3 = new Transaction
                            {
                                TransCode = transCode,
                                TransDate = DateTime.Now,
                                TransType = TType.Debit,
                                Description = helperRepository.ExpenseDeletePaymentMsg_Cash(m.Amount),
                                Amount = m.Amount,
                                Operation = Operation.Delete
                            };

                            if (transactionRepository.AddTransactionLog(transaction3))
                            {
                                var res = transactionRepository.AddBankLedger(bankledger);
                                if (res == null)
                                {
                                    return false;
                                }
                            }

                        }
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

        public IEnumerable<ExpenseViewModel> GetAllExpense()
        {
            if (dbContext != null)
            {
                List<ExpenseViewModel> list = new List<ExpenseViewModel>();
                var ModelList = dbContext.Expenses.Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                var bankName = "";
                var ExpenseCategory = "";
                var EmployeeName = "";

                foreach (var expense in ModelList)
                {


                    if (expense.BankId == 0)
                    {
                        bankName = "";
                    }
                    else
                    {
                        bankName = dbContext.Banks.FirstOrDefault(x => x.Id == expense.BankId).BankName;
                    }

                    if (expense.ExpenseCategory == 0)
                    {
                        ExpenseCategory = "";
                    }
                    else
                    {
                        ExpenseCategory = dbContext.ExpensesCategories.FirstOrDefault(x => x.Id == expense.ExpenseCategory).Name;
                    }

                    if (expense.EmployeeId == 0)
                    {
                        EmployeeName = "";
                    }
                    else
                    {
                        EmployeeName = dbContext.Employees.FirstOrDefault(x => x.Id == expense.EmployeeId).Name;

                    }

                    ExpenseViewModel model = new ExpenseViewModel
                    {
                        Id = expense.Id,
                        SNO = sno++,
                        ExpenseCategoryId = expense.ExpenseCategory,
                        ExpenseCategoryName = ExpenseCategory,
                        EmployeeId = expense.EmployeeId,
                        EmployeeName = EmployeeName,
                        BankId = (long)expense.BankId,
                        BankName = bankName,
                        ExpenseDate = expense.ExpenseDate,
                        Amount = expense.Amount,
                        BillNumber = expense.BillNumber,
                        Description = expense.Description,
                        CreatedAt = expense.CreatedAt,
                        UpdatedAt = expense.UpdatedAt,
                        DeletedAt = expense.DeletedAt,
                        UserId = expense.UserId,
                        UserName = pmsHelper.GetUserName(expense.UserId)
                    };
                    list.Add(model);
                }
                return list;
            }
            return null;
        }
        public Expense GetExpense(long id)
        {
            if (dbContext != null)
            {
                var model = dbContext.Expenses.FirstOrDefault(x => x.Id == id);
                return model;
            }

            return null;
        }

        public ExpenseViewModel GetByIdExpense(long id)
        {
            //var id = GetMaxId();
            if (dbContext != null)
            {
                var expense = dbContext.Expenses.FirstOrDefault(x => x.Id == id);

                var BillNumber = "";
                var Description = "";
                var ExpenseCategory = "";
                var EmployeeName = "";

                if (expense.Description == null)
                {
                    Description = "";
                }
                else
                {
                    Description = expense.Description;
                }

                if (expense.BillNumber == null)
                {
                    BillNumber = "";
                }
                else
                {
                    BillNumber = expense.BillNumber;
                }

                if (expense.ExpenseCategory == 0)
                {
                    ExpenseCategory = "";
                }
                else
                {
                    ExpenseCategory = dbContext.ExpensesCategories.FirstOrDefault(x => x.Id == expense.ExpenseCategory).Name;
                }

                if (expense.EmployeeId == 0)
                {
                    EmployeeName = "";
                }
                else
                {
                    EmployeeName = dbContext.Employees.FirstOrDefault(x => x.Id == expense.EmployeeId).Name;
                }


                ExpenseViewModel model = new ExpenseViewModel
                {
                    Id = expense.Id,
                    ExpenseCategoryName = ExpenseCategory,
                    EmployeeName = EmployeeName,
                    ExpenseDate = expense.ExpenseDate,
                    Amount = expense.Amount,
                    BillNumber = BillNumber,
                    Description = Description
                };
                return model;
            }
            return null;
        }

        public ExpenseViewModel GetExpensePrint(long id)
        {

            if (dbContext != null)
            {
                var expense = dbContext.Expenses.FirstOrDefault(x => x.Id == id);

                var BillNumber = "";
                var Description = "";
                var ExpenseCategory = "";
                var EmployeeName = "";

                if (expense.Description == null)
                {
                    Description = "";
                }
                else
                {
                    Description = expense.Description;
                }

                if (expense.BillNumber == null)
                {
                    BillNumber = "";
                }
                else
                {
                    BillNumber = expense.BillNumber;
                }

                if (expense.ExpenseCategory == 0)
                {
                    ExpenseCategory = "";
                }
                else
                {
                    ExpenseCategory = dbContext.ExpensesCategories.FirstOrDefault(x => x.Id == expense.ExpenseCategory).Name;
                }

                if (expense.EmployeeId == 0)
                {
                    EmployeeName = "";
                }
                else
                {
                    EmployeeName = dbContext.Employees.FirstOrDefault(x => x.Id == expense.EmployeeId).Name;

                }

                ExpenseViewModel model = new ExpenseViewModel
                {
                    Id = expense.Id,
                    ExpenseCategoryName = ExpenseCategory,
                    EmployeeName = EmployeeName,
                    ExpenseDate = expense.ExpenseDate,
                    Amount = expense.Amount,
                    BillNumber = BillNumber,
                    Description = Description,
                };
                return model;
            }
            return null;
        }

        public IEnumerable<ExpenseViewModel> GetExpenseBySearch(long expenseCategoryId, DateTime? startDate, DateTime? endDate)
        {
            if (dbContext != null)
            {
                List<ExpenseViewModel> list = new List<ExpenseViewModel>();
                var ModelList = dbContext.Expenses.OrderBy(n => n.ExpenseDate).Where(x => x.DeletedAt == null).ToList();
                long sno = 1;
                var bankName = "";
                var ExpenseCategory = "";
                var EmployeeName = "";
                foreach (var expense in ModelList)
                {

                    if (expense.BankId == 0)
                    {
                        bankName = "";
                    }
                    else
                    {
                        bankName = dbContext.Banks.FirstOrDefault(x => x.Id == expense.BankId).BankName;
                    }
                    if (expense.ExpenseCategory == 0)
                    {
                        ExpenseCategory = "";
                    }
                    else
                    {
                        ExpenseCategory = dbContext.ExpensesCategories.FirstOrDefault(x => x.Id == expense.ExpenseCategory).Name;
                    }

                    if (expense.EmployeeId == 0)
                    {
                        EmployeeName = "";
                    }
                    else
                    {
                        EmployeeName = dbContext.Employees.FirstOrDefault(x => x.Id == expense.EmployeeId).Name;

                    }

                    ExpenseViewModel model = new ExpenseViewModel
                    {
                        Id = expense.Id,
                        SNO = sno++,
                        ExpenseCategoryId = expense.ExpenseCategory,
                        ExpenseCategoryName = ExpenseCategory,
                        EmployeeId = expense.EmployeeId,
                        EmployeeName = EmployeeName,
                        BankId = (long)expense.BankId,
                        BankName = bankName,
                        ExpenseDate = expense.ExpenseDate,
                        Amount = expense.Amount,
                        BillNumber = expense.BillNumber,
                        Description = expense.Description,
                        CreatedAt = expense.CreatedAt,
                        UpdatedAt = expense.UpdatedAt,
                        DeletedAt = expense.DeletedAt,
                        UserId = expense.UserId,
                        UserName = pmsHelper.GetUserName(expense.UserId)
                    };

                    list.Add(model);
                }
                if (expenseCategoryId > 0)
                {
                    list = list.Where(x => x.ExpenseCategoryId == expenseCategoryId).ToList();
                }

                if (startDate != null)
                {
                    list = list.Where(x => x.ExpenseDate >= startDate).ToList();
                }

                if (endDate != null)
                {
                    list = list.Where(x => x.ExpenseDate <= endDate).ToList();
                }

                return list;
            }

            return null;

        }

        public IEnumerable<ExpenseViewModel> GetExpenseBySearchStatment(long expenseCategoryId, DateTime? startDate, DateTime? endDate)
        {
            long sno = 1;
            if (dbContext != null)
            {
                List<ExpenseViewModel> list = new List<ExpenseViewModel>();

                var ModelList = dbContext.Expenses.Where(x => x.DeletedAt == null).ToList();

                if (expenseCategoryId > 0)
                {
                    ModelList = ModelList.Where(x => x.ExpenseCategory == expenseCategoryId).ToList();
                }

                if (startDate != null)
                {
                    ModelList = ModelList.Where(x => x.ExpenseDate >= startDate).ToList();
                }

                if (endDate != null)
                {
                    ModelList = ModelList.Where(x => x.ExpenseDate <= endDate).ToList();
                }

                foreach (var expense in ModelList)
                {
                    var BillNumber = "";

                    var Description = "";

                    if (expense.Description == null)
                    {
                        Description = "";
                    }

                    else
                    {
                        Description = expense.Description;
                    }

                    if (expense.BillNumber == null)
                    {
                        BillNumber = "";
                    }

                    else
                    {
                        BillNumber = expense.BillNumber;
                    }

                    ExpenseViewModel model = new ExpenseViewModel
                    {
                        SNO = sno++,
                        Id = expense.Id,
                        ExpenseCategoryName = dbContext.ExpensesCategories.FirstOrDefault(x => x.Id == expense.ExpenseCategory).Name,
                        EmployeeName = dbContext.Employees.FirstOrDefault(x => x.Id == expense.EmployeeId).Name,
                        ExpenseDate = expense.ExpenseDate,
                        Amount = expense.Amount,
                        BillNumber = BillNumber,
                        Description = Description,
                    };

                    list.Add(model);
                }
                return list;
            }
            return null;
        }

        private long AddNewExpense(Expense expense)
        {
            if (dbContext != null)
            {
                expense.CreatedAt = DateTime.Now;
                expense.UpdatedAt = DateTime.Now;
                expense.UserId = helperRepository.GetCurrentUserId();
                expense.UserName = helperRepository.GetUserName(helperRepository.GetCurrentUserId());

                dbContext.Expenses.Add(expense);
                dbContext.SaveChanges();

                var maxId = dbContext.Expenses.Max(x => x.Id);
                return maxId;
            }
            return 0;
        }
    }
}
