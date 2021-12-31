using PMS.Models.Service;
using System.Collections.Generic;

namespace PMS.ViewModels.Service
{
    public class CreateServiceViewModel
    {
        public Services Services { get; set; }
        public IEnumerable<ServiceDetails> ServiceDetails { get; set; }
    }
}
