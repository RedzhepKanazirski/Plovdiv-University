using System.ComponentModel.DataAnnotations;

namespace ShareWithMe.ViewModels.Librarians
{
    public class EditVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string LastName { get; set; }
    }
}
