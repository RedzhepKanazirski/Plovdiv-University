using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDB.Entities;

namespace DataDB.Context
{
    public class Student55SystemDBContext: DbContext                             //   : DbContext   za da redactirame, zapavame i t.n
    {
        public DbSet<Ability> Abilities  { get; set; }
        public DbSet<Weapon>  Weapons    { get; set; }
        public DbSet<Clan>    Clans      { get; set; }
        public DbSet<Champion> Champions { get; set; }

        // public System.Data.Entity.DbSet<MVC.ViewModels.ChampionVM> ChampionVMs { get; set; }
    }
}
