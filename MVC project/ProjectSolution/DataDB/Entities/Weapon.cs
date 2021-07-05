using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDB.Entities
{
   public class Weapon : BaseEntity                              //Exdends BASEENTITY
    {
        public string   Name        { get; set; }
        public int      Range       { get; set; }
        public string   Description { get; set; }
        public string   Type        { get; set; }
        public int      Rarity      { get; set; }

        public virtual ICollection<Champion> Champions { get; set; }

    }
}
