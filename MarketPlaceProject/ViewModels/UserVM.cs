using System.ComponentModel.DataAnnotations;
using System.Web;

namespace MarketPlaceProject.ViewModels
{
    public class UserVM
    {
        public int UserID { get; set; }
        [Display(Name = "UserName: ")]
        [Required(ErrorMessage = "UserName is required!")]
        [MinLength(6, ErrorMessage = "Username must be at least 6 characters!")]
        public string Username { get; set; }
        [Display(Name = "Email Address: ")]
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Invalid email format!")]
        public string Email { get; set; }
        [Display(Name = "Password: ")]
        [Required(ErrorMessage = "Password is required!")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters!")]
        public string Password { get; set; }
        [Display(Name = "Confirmed Password: ")]
        [Required(ErrorMessage = "Confirm Password is required!")]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string ConfirmedPassword { get; set; }

        public HttpPostedFileBase ProfilePictureFile { get; set; }
        public string ProfilePictureUrl { get; set; }
    }
}