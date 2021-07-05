using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AplicationService.DTOs;

namespace MVC.ViewModels
{
    public class ChampionVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Nickname { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Gender { get; set; }

        public int AbilityID { get; set; }
        public AbilityVM AbilityVM { get; set; }

        public int WeaponID { get; set; }
        public WeaponVM WeaponVM { get; set; }

        public int ClanID { get; set; }
        public ClanVM ClanVM { get; set; }

        public ChampionVM() { }
        public ChampionVM(ChampionDTO championDTO)
        {
            Id = championDTO.Id;
            Nickname = championDTO.Nickname;
            Name = championDTO.Name;
            DOB = championDTO.DOB;
            Gender = championDTO.Gender;
           
            AbilityID = championDTO.AbilityID;
            AbilityVM = new AbilityVM
            {
                Id = championDTO.AbilityID,
                Title = championDTO.Ability.Title,
                Description = championDTO.Ability.Description
            };
            WeaponID = championDTO.WeaponID;
            WeaponVM = new WeaponVM
            {
                Id = championDTO.WeaponID,
                Name = championDTO.Weapon.Name,
                Range = championDTO.Weapon.Range,
                Description = championDTO.Weapon.Description,
                Type = championDTO.Weapon.Type,
                Rarity = championDTO.Weapon.Rarity
            };
            ClanID = championDTO.ClanID;
            ClanVM = new ClanVM
            {
                Id = championDTO.ClanID,
                Name = championDTO.Clan.Name,
                Dating = championDTO.Clan.Dating,
                Symbol = championDTO.Clan.Symbol,
                Specificity = championDTO.Clan.Specificity
            };
        }
    }
}