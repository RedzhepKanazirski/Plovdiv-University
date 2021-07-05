using System.ComponentModel.DataAnnotations;

namespace ShareWithMe.ViewModels.Books
{
    public class CreateVM
    {
        [Required(ErrorMessage = "*This field is required")]
        public int ISBN { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public int Year { get; set; }
    }
}
