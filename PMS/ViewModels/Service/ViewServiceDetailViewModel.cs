using PMS.Models;
using System.Collections.Generic;

namespace PMS.ViewModels.Service
{
    public class ViewServiceDetailViewModel
    {
        public ServiceViewModel ServiceViewModel { get; set; }
        public IEnumerable<ServiceDetailViewModel> ServiceDetailViewModels { get; set; }
        public Shop ShopModelDetails { get; set; }
    }
}
