using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDB.Entities;

namespace AplicationService.DTOs
{
   public class ChampionDTO
    {
        public int Id { get; set; }

        [Required]
        public string Nickname { get; set; }
        public string Name { get; set; }
        public DateTime? DOB { get; set; }
        public string Gender { get; set; }

        public int AbilityID { get; set; }
        public virtual AbilityDTO Ability { get; set; }

        public int WeaponID { get; set; }
        public virtual WeaponDTO Weapon { get; set; }

        public int ClanID { get; set; }
        public virtual ClanDTO Clan { get; set; }
    }
}
