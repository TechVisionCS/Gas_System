using PMS.Models.OfficeLoan;
using PMS.ViewModels.Finance;
using PMS.ViewModels.OfficeLoanViewModels;
using System;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IOfficeLoanRepository
    {
        // Releted to person and it's lederger
        IEnumerable<OfficePersonViewModel> GetAllOfficePerson();
        OfficePersonViewModel GetByIdOfficePerson(long id);
        OfficePersonLoanDetailsViewModel GetOfficePersonDetails(long id);
        IEnumerable<OfficePersonLedgerViewModel> GetOfficePersonLedgers(long personId, DateTime? startDate, DateTime? endDate);
        OfficePerson GetOfficePersonByIdForUpdate(long id);
        OfficePerson AddOfficePerson(OfficePerson person);
        OfficePerson UpdateOfficePerson(OfficePerson person);
        bool DeleteOfficePerson(long personId);


        // Loan Payment To Person
        IEnumerable<OfficeLoanPayment> GetOfficePersonPayments();
        IEnumerable<OfficeLoanPayment> GetOfficePersonPayments(long personId, DateTime? startDate, DateTime? endDate);
        OfficeLoanPayment GetOfficePersonPaymentbyId(long id);
        OfficeLoanPayment AddOfficePersonPayment(OfficeLoanPayment personalLoanPayment);
        OfficeLoanPayment EditOfficePersonPayment(OfficeLoanPayment personalLoanPayment);
        //bool DeletePersonPayment(long personId);



        //Loan Receive From Person
        IEnumerable<OfficeLoanReceive> GetOfficePersonLoanReceives();
        IEnumerable<OfficeLoanReceive> GetOfficePersonLoanReceives(long personId, DateTime? startDate, DateTime? endDate);
        OfficeLoanReceive GetOfficePersonLoanReceivesById(long id);
        OfficeLoanReceive AddOfficePersonLoanReceive(OfficeLoanReceive officeLoan);
        OfficeLoanReceive EditOfficePersonLoanReceives(OfficeLoanReceive officeLoan);
    }
}
