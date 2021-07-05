using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDB.Context;
using DataDB.Entities;

namespace Repository.Implementations
{
    public class UnitOfWork : IDisposable
    {
        private Student55SystemDBContext context = new Student55SystemDBContext();
       
        private GenericRepository<Ability> abilityRepository;
        private GenericRepository<Weapon> weaponRepository;
        private GenericRepository<Clan> clanRepository;
        private GenericRepository<Champion> championRepository;

        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&-------GET-----------&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&    
        public GenericRepository<Ability> AbilityRepository
        {
            get
            {

                if (this.abilityRepository == null)
                {
                    this.abilityRepository = new GenericRepository<Ability>(context);
                }
                return abilityRepository;
            }
        }

        public GenericRepository<Weapon> WeaponRepository
        {
            get
            {

                if (this.weaponRepository == null)
                {
                    this.weaponRepository = new GenericRepository<Weapon>(context);
                }
                return weaponRepository;
            }
        }

        public GenericRepository<Clan> ClanRepository
        {
            get
            {

                if (this.clanRepository == null)
                {
                    this.clanRepository = new GenericRepository<Clan>(context);
                }
                return clanRepository;
            }
        }

        public GenericRepository<Champion> ChampionRepository
        {
            get
            {

                if (this.championRepository == null)
                {
                    this.championRepository = new GenericRepository<Champion>(context);
                }
                return championRepository;
            }
        }
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&-----------------------&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
        public void Save()
        {
            context.SaveChanges();
        }
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&-----------disposed-------------&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        //&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
    }
}
