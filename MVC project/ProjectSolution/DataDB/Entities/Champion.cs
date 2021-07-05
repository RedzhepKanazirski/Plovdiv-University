using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDB.Entities
{
   public class Champion: BaseEntity
    {
        public string Nickname { get; set; }
        public string Name { get; set; }
        public DateTime? DOB { get; set; }
        public string Gender { get; set; }

        public int AbilityID { get; set; }
        public virtual Ability Ability { get; set; }

        public int WeaponID { get; set; }
        public virtual Weapon Weapon { get; set; }

        public int ClanID { get; set; }
        public virtual Clan Clan { get; set; }
    }
}
