using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AplicationService.DTOs;

namespace MVC.ViewModels
{
    public class ClanVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Dating { get; set; }

        [Required]
        public string Symbol { get; set; }

        public string Specificity { get; set; }


        public ClanVM() { }

        public ClanVM(ClanDTO clanDTO)
        {
            Id = clanDTO.Id;
            Name = clanDTO.Name;
            Dating = clanDTO.Dating;
            Symbol = clanDTO.Symbol;
            Specificity = clanDTO.Specificity;
        }
    }
}