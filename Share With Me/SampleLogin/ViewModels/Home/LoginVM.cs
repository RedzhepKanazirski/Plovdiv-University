using System.ComponentModel.DataAnnotations;

namespace ShareWithMe.ViewModels.Home
{
    public class LoginVM
    {
        [Required(ErrorMessage = "*This field is required!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "*This field is required!")]
        public string Password { get; set; }
    }
}
