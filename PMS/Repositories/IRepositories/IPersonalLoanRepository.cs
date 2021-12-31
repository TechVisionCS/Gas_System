using PMS.Models.PersonalLoan;
using PMS.ViewModels.Finance;
using PMS.ViewModels.PersonalLoanViewModels;
using System;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IPersonalLoanRepository
    {
        // Releted to person and it's lederger

        IEnumerable<PersonViewModel> GetAllPerson();
        PersonViewModel GetByIdPerson(long id);
        PersonalLoanDetailsViewModel GetPersonDetails(long id);
        IEnumerable<PersonLedgerViewModel> GetPersonLedgers(long personId, DateTime? startDate, DateTime? endDate);
        Person GetByIdForUpdate(long id);
        Person AddPerson(Person person);
        Person UpdatePerson(Person person);
        bool DeletePerson(long personId);


        // Loan Payment To Person
        IEnumerable<PersonalLoanPayment> GetPersonPayments();
        IEnumerable<PersonalLoanPayment> GetPersonPayments(long personId, DateTime? startDate, DateTime? endDate);
        PersonalLoanPayment GetPersonPaymentbyId(long id);
        PersonalLoanPayment AddPersonPayment(PersonalLoanPayment personalLoanPayment);
        PersonalLoanPayment EditPersonPayment(PersonalLoanPayment personalLoanPayment);
        bool DeletePersonPayment(long personId);


        //Loan Receive From Person
        IEnumerable<PersonalLoanReceive> GetPersonLoanReceives();
        IEnumerable<PersonalLoanReceive> GetPersonLoanReceives(long personId, DateTime? startDate, DateTime? endDate);
        PersonalLoanReceive GetPersonLoanReceivesById(long id);
        PersonalLoanReceive AddPersonLoanReceive(PersonalLoanReceive personalLoan);
        PersonalLoanReceive EditPersonLoanReceives(PersonalLoanReceive personalLoan);
    }
}
