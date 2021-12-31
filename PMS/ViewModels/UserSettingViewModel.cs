using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PMS.ViewModels
{
    public class UserSettingViewModel
    {
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Enter the Current Password First!")]
        public string CurrentPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Enter New Password!")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please Enter the confirm password!")]
        [Compare("NewPassword", ErrorMessage = "New Password and Confirm Password do not match each other!")]
        public string ConfirmPassword { get; set; }
        //////////////////////////////////////////////////////////////////////////////////////
        ///
        public UserSettingViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }
        public string Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string FullName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public List<string> Claims { get; set; }
        public IList<string> Roles { get; set; }
    }
}
