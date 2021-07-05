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
   public class ChampionManagementService
    {
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         private Student55SystemDBContext ctx = new Student55SystemDBContext(); //инстанция на "context"

//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //GET Champion

        public List<ChampionDTO> Get()                                         //Get метод който извиквяа Context, взема всички от Champions  и ги връща като List
        {
            List<ChampionDTO> championsDTO = new List<ChampionDTO>();           //променлива за резултатите

            //foreach (var item in ctx.Champions.ToList())                     //пълни ги
            //{
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.ChampionRepository.Get())
                {
                    championsDTO.Add(new ChampionDTO
                    {
                        Id = item.Id,
                        Nickname = item.Nickname,
                        Name = item.Name,
                        DOB = item.DOB,
                        Gender = item.Gender,
                        AbilityID = item.AbilityID,
                        Ability = new AbilityDTO
                        {
                            Id = item.AbilityID,
                            Title = item.Ability.Title,
                            Description = item.Ability.Description,
                        },
                        WeaponID = item.WeaponID,
                        Weapon = new WeaponDTO
                        {
                            Id = item.WeaponID,
                            Name = item.Weapon.Name,
                            Range = item.Weapon.Range,
                            Description = item.Weapon.Description,
                            Type = item.Weapon.Type,
                            Rarity = item.Weapon.Rarity
                        },
                        ClanID = item.ClanID,
                        Clan = new ClanDTO
                        {
                            Id = item.ClanID,
                            Name = item.Clan.Name,
                            Dating = item.Clan.Dating,
                            Symbol = item.Clan.Symbol,
                            Specificity = item.Clan.Specificity
                        }
                    });
                }
            }

            return championsDTO;                                            //връща ги в листа
        }
//%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
       //Get By ID Champion
        public ChampionDTO GetById(int id)
        {

            using(UnitOfWork unitOfWork = new UnitOfWork())
            {
                //Champion item = ctx.Champions.Find(id);
                Champion item = unitOfWork.ChampionRepository.GetByID(id);

                ChampionDTO championDTO = new ChampionDTO
            {
                Id = item.Id,
                Nickname = item.Nickname,
                Name = item.Name,
                DOB = item.DOB,
                Gender = item.Gender,
                AbilityID = item.AbilityID,
                Ability = new AbilityDTO
                {
                    Id = item.AbilityID,
                    Title = item.Ability.Title,
                    Description = item.Ability.Description,
                },
                WeaponID = item.WeaponID,
                Weapon = new WeaponDTO
                {
                    Id = item.WeaponID,
                    Name = item.Weapon.Name,
                    Range = item.Weapon.Range,
                    Description = item.Weapon.Description,
                    Type = item.Weapon.Type,
                    Rarity = item.Weapon.Rarity
                },
                ClanID = item.ClanID,
                Clan = new ClanDTO
                {
                    Id = item.ClanID,
                    Name = item.Clan.Name,
                    Dating = item.Clan.Dating,
                    Symbol = item.Clan.Symbol,
                    Specificity = item.Clan.Specificity
                }
            };
                return championDTO;

            }
        }
 //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //CREATE Champion

        public bool Save(ChampionDTO championDTO)  //функция 
        {
           if(championDTO.Ability == null || championDTO.AbilityID == 0)
            {
                return false;
            }
            if (championDTO.Weapon == null || championDTO.WeaponID == 0)
            {
                return false;
            }
            if (championDTO.Clan == null || championDTO.ClanID == 0)
            {
                return false;
            }
            /*
            Ability abl = new Ability
            {
                Id = championDTO.AbilityID,
                Title = championDTO.Ability.Title,
                Description = championDTO.Ability.Description
            };

            Weapon wpn = new Weapon
            {
                Id = championDTO.WeaponID,
                Name = championDTO.Weapon.Name,
                Range = championDTO.Weapon.Range,
                Description = championDTO.Weapon.Description,
                Type = championDTO.Weapon.Type,
                Rarity = championDTO.Weapon.Rarity
            };

            Clan cl = new Clan
            {
                Id = championDTO.ClanID,
                Name = championDTO.Clan.Name,
                Dating = championDTO.Clan.Dating,
                Symbol = championDTO.Clan.Symbol,
                Specificity = championDTO.Clan.Specificity
            };
            */

            Champion champion = new Champion
            {
                Id = championDTO.Id,
                Nickname = championDTO.Nickname,
                Name = championDTO.Name,
                DOB = championDTO.DOB,
                Gender = championDTO.Gender,
                AbilityID = championDTO.AbilityID,
                WeaponID = championDTO.WeaponID,
                ClanID = championDTO.ClanID
            };
           
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.ChampionRepository.Insert(champion);
                    unitOfWork.Save();
                }



               // ctx.Champions.Add(champion);
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
                    Champion champion = unitOfWork.ChampionRepository.GetByID(id);
                    unitOfWork.ChampionRepository.Delete(champion);
                    unitOfWork.Save();
                }

               // Champion champion = ctx.Champions.Find(id);
             //  ctx.Champions.Remove(champion);
               // ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        
        public bool Update(ChampionDTO championDTO)
        {
            Champion toUpdate = null;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                toUpdate = unitOfWork.ChampionRepository.GetByID(championDTO.Id);
            }
            if (toUpdate != null)
            {
                toUpdate.Nickname = championDTO.Nickname;
                toUpdate.Name = championDTO.Name;
                toUpdate.DOB = championDTO.DOB;
                toUpdate.Gender = championDTO.Gender;
                toUpdate.AbilityID = championDTO.AbilityID;
                toUpdate.WeaponID = championDTO.WeaponID;
                toUpdate.ClanID = championDTO.ClanID;
            }
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.ChampionRepository.Update(toUpdate);
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
