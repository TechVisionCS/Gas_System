using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace PMS.ViewModels
{
    public class UploadImageViewModel
    {
        [Required]
        public IFormFile Picture { get; set; }
    }
}
