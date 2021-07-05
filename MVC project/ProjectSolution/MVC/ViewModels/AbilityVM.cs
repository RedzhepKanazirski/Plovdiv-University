using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AplicationService.DTOs;

namespace MVC.ViewModels
{
    public class AbilityVM
    {
        public int Id { get; set; }
       
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }

        public AbilityVM() { }

        public AbilityVM(AbilityDTO abilityDTO)
        {
            Id = abilityDTO.Id;
            Title = abilityDTO.Title;
            Description = abilityDTO.Description;
        }
    }
}
