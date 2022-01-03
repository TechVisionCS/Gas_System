using PMS.Models;
using PMS.ViewModels;
using PMS.ViewModels.Finance;
using System;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface ISarafRepository
    {
        IEnumerable<SarafViewModel> GetAll();
        Saraf GetByIdSaraf(long id);
        SarafDetailsViewModel GetSarafDetails(long id);
        Saraf AddSaraf(Saraf saraf);
        Saraf UpdateSaraf(Saraf saraf);
        IEnumerable<SarafsLedgerViewModel> GetSarafLedgers(long sarafId, DateTime? startDate, DateTime? endDate);
        SarafTransaction AddSarafTransaction(SarafTransaction sarafTransaction);
        SarafTransaction AddSarafTransaction_Purchase(SarafTransaction sarafTransaction, string transCode);
    }
}
