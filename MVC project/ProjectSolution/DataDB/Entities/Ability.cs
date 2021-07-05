using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDB.Entities
{
   public class Ability:BaseEntity                              //Exdends BASEENTITY
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Champion> Champions { get; set; }
    }
}

