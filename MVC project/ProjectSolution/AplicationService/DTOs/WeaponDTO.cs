using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationService.DTOs
{
  public class WeaponDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Range { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int Rarity { get; set; }
    }
}
