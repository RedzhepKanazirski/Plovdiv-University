﻿using System.ComponentModel.DataAnnotations;

namespace ShareWithMe.ViewModels.Musics
{
    public class EditVM
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public int Year { get; set; }
    }
}
