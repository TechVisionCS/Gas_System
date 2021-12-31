using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class Shop : BaseEntity.BaseEntity
    {
        [Required]
        public string Name_en { get; set; }
        public string Name_ps { get; set; }
        public string Name_dr { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public string LogoUrl { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Address_en { get; set; }
        public string Address_ps { get; set; }
        public string Address_dr { get; set; }
        public string Responsible1 { get; set; }
        public string Responsible2 { get; set; }
        public string Slog_en { get; set; }
        public string Slog_ps { get; set; }
        public string Slog_dr { get; set; }
    }
}
