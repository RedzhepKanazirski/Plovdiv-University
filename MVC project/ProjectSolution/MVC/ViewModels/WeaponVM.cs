using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AplicationService.DTOs;

namespace MVC.ViewModels
{
    public class WeaponVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required. Set value from 1 to 10, as u know 10 is the greatest")]
        public int Range { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Type { get; set; }

        [Required(ErrorMessage = "This field is required. Set value from 1 to 10, as u know 10 is the greatest")]
        public int Rarity { get; set; }


        public WeaponVM() { }

        public WeaponVM(WeaponDTO weaponDTO)
        {
            Id = weaponDTO.Id;
            Name = weaponDTO.Name;
            Range = weaponDTO.Range;
            Description = weaponDTO.Description;
            Type = weaponDTO.Type;
            Rarity = weaponDTO.Rarity;
        }
    }
}