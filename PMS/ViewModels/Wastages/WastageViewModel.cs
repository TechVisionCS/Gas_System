using PMS.Models;
using System.Collections.Generic;

namespace PMS.ViewModels.Wastages
{
    public class WastageViewModel
    {
        public Wastage Wastage { get; set; }
        public IEnumerable<WastageDetailsViewModel> WastageDetails { get; set; }

    }
}
