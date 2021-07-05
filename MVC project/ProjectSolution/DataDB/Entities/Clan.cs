using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDB.Entities
{
    public class Clan: BaseEntity                              //Exdends BASEENTITY
    {
        public string Name { get; set; }
        public string Dating { get; set; }
        public string Symbol { get; set; }
        public string Specificity { get; set; }

        public virtual ICollection<Champion> Champions { get; set; }

    }
}
