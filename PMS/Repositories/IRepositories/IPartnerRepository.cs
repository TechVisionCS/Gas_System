using PMS.Models;
using PMS.ViewModels;
using System;
using System.Collections.Generic;

namespace PMS.Repositories.IRepositories
{
    public interface IPartnerRepository
    {
        IEnumerable<PartnerViewModel> GetAllPartner();
        PartnerViewModel GetByIdPartner(long id);
        PartnerDetailsViewModel GetPartnerDetails(long id);
        Partner GetByIdForUpdate(long id);
        Partner AddPartner(Partner partner);
        Partner UpdatePartner(Partner partner);
        bool DeletePartner(long partnerid);

        IEnumerable<PartnerLedgerViewModel> GetPartnerLedgers(long partnerId, DateTime? startDate, DateTime? endDate);

        IEnumerable<PartnerInvestment> GetAllPartnersInvestments();
        PartnerInvestment AddPartnerInvestment(PartnerInvestment partnerInvestment);
        PartnerInvestment GetPartnerInvestment(long id);
        PartnerInvestment EditPartnerInvestment(PartnerInvestment partnerInvestment);

        IEnumerable<PartnerPayment> GetAllPartnersPayments();
        PartnerPayment AddPartnerPayment(PartnerPayment partnerPayment);
        PartnerPayment GetPartnerPayment(long id);
        PartnerPayment EditPartnerPayment(PartnerPayment partnerPayment);


    }
}
