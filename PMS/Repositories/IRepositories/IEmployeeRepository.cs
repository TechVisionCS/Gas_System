using PMS.Models;
using PMS.ViewModels;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeViewModel> GetAllEmployee();
        IEnumerable<EmployeeViewModel> GetAllEmployeeFired();

        EmployeeViewModel GetByIdEmployee(long id);
        Employee GetByIdForUpdate(long id);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        bool DeleteEmployee(long employeeid);





        IEnumerable<EmployeeLedgerViewModel> GetEmployeeLedgers(long employeeId, int month, int year);
        IEnumerable<EmployeeSalaryViewModel> GetAllEmployeeSalaries(int year, int month);
        IEnumerable<EmployeeSalaryViewModel> GetAllSalariesPerEachEmployee(long id); //id is employee id
        EmployeeSalaryViewModel GetByIdEmployeeSalary(long id);

        EmployeeSalary AddEmployeeSalary(EmployeeSalary employeeSalary);
        EmployeeSalary UpdateEmployeeSalary(EmployeeSalary employeeSalary);
        EmployeeSalary GetSalaryByIdForUpdate(long id);

        bool DeleteEmployeeSalary(long id);
    }
}
