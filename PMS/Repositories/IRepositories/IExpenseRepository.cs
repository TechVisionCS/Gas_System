using PMS.Models;
using PMS.ViewModels;
using System;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IExpenseRepository
    {
        IEnumerable<ExpenseViewModel> GetAllExpense();
        IEnumerable<ExpenseViewModel> GetExpenseBySearch(long expenseCategoryId, DateTime? startDate, DateTime? endDate);
        IEnumerable<ExpenseViewModel> GetExpenseBySearchStatment(long expenseCategoryId, DateTime? startDate, DateTime? endDate);
        Expense GetExpense(long id);
        ExpenseViewModel GetByIdExpense(long id);
        ExpenseViewModel GetExpensePrint(long id);
        long AddExpensePayment(Expense expense);
        Expense EditExpensePayment(Expense expense);
        bool DeleteExpense(long expenseId);
    }
}
