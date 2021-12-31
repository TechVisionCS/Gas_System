using System.Collections.Generic;

namespace PMS.ViewModels.ReturnViewModels
{
    public class ReturnViewModel
    {
        public ReturnModelViewModel Return { get; set; }
        public IEnumerable<ReturnDetailsViewModel> ReturnDetails { get; set; }
    }
}
