using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicationService.DTOs;
using DataDB.Context;
using DataDB.Entities;
using Repository.Implementations;

namespace AplicationService.Implementations
{
    public class ClanManagementService
    {
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        private Student55SystemDBContext ctx = new Student55SystemDBContext(); //инстанция на "context"

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public List<ClanDTO> Get()                                   //Get метод който извиквяа Context, взема всички от weapons  и ги връща като List
        {
            List<ClanDTO> clansDTO = new List<ClanDTO>();           //променлива за резултатите

            //foreach (var item in ctx.Clans.ToList())                     //пълни ги
            //{

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.ClanRepository.Get())
                {
                    clansDTO.Add(new ClanDTO
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Dating = item.Dating,
                        Symbol = item.Symbol,
                        Specificity = item.Specificity
                    });
                }
            }

            return clansDTO;                                            //връща ги в листа
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public ClanDTO GetById(int id)
        {
            ClanDTO clanDTO = new ClanDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Clan clan = unitOfWork.ClanRepository.GetByID(id);

                if (clan != null)
                {
                    clanDTO.Id = clan.Id;
                    clanDTO.Name = clan.Name;
                    clanDTO.Dating = clan.Dating;
                    clanDTO.Symbol = clan.Symbol;
                    clanDTO.Specificity = clan.Specificity;
                }
            }



             //   Clan clan = ctx.Clans.Find(id);
            
            return clanDTO;
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public bool Save(ClanDTO clanDTO)  //функция 
        {
            Clan Clan = new Clan    //obekt ot Ability
            {
                Name = clanDTO.Name,                 //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO
                Dating = clanDTO.Dating,                //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO
                Symbol = clanDTO.Symbol,  //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO
                Specificity = clanDTO.Specificity                   //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO

            };       //инстанция на  обект Natioality

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.ClanRepository.Insert(Clan);
                    unitOfWork.Save();
                }


                   // ctx.Clans.Add(Clan); //konteksta/ tablicata/ podawame dannite
               // ctx.SaveChanges();
               
                return true;
            }
            catch
            {
                return false;
            }
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public bool Delete(int id)  //функция 
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    Clan clan = unitOfWork.ClanRepository.GetByID(id);
                    unitOfWork.ClanRepository.Delete(clan);
                    unitOfWork.Save();
                }

               // Clan clan = ctx.Clans.Find(id);
              //  ctx.Clans.Remove(clan);
              //  ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public bool Update(ClanDTO clanDTO)
        {
            Clan toUpdate = null;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                toUpdate = unitOfWork.ClanRepository.GetByID(clanDTO.Id);
            }
            if (toUpdate != null)
            {
                toUpdate.Name = clanDTO.Name;
                toUpdate.Dating = clanDTO.Dating;
                toUpdate.Symbol = clanDTO.Symbol;
                toUpdate.Specificity = clanDTO.Specificity;
            }
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.ClanRepository.Update(toUpdate);
                    unitOfWork.Save();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    }
}
