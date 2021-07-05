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
    public class AbilityManagementService
    {
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        private Student55SystemDBContext ctx = new Student55SystemDBContext(); //инстанция на "context"

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public List<AbilityDTO> Get()                                         //Get метод който извиквяа Context, взема всички от абилитиес  и ги връща като List
        {
            List<AbilityDTO> abilitiesDTO = new List<AbilityDTO>();           //променлива за резултатите

           // foreach (var item in ctx.Abilities.ToList())                     //пълни ги
           // {
           using(UnitOfWork unitOfWork = new UnitOfWork() )
            {
                foreach (var item in unitOfWork.AbilityRepository.Get())
                {
                    abilitiesDTO.Add(new AbilityDTO
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Description = item.Description
                    });
                }
            }

            return abilitiesDTO;                                            //връща ги в листа
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
         public AbilityDTO GetById(int id)
          {
            AbilityDTO abilityDTO = new AbilityDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Ability ability = unitOfWork.AbilityRepository.GetByID(id);
                // Ability ability = ctx.Abilities.Find(id);

                if (ability != null)
                {
                    abilityDTO.Id = ability.Id;
                    abilityDTO.Title = ability.Title;
                    abilityDTO.Description = ability.Description;
                }

            }
              return abilityDTO;
          }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public bool Save(AbilityDTO abilityDTO)  //функция 
        {
            Ability Ability = new Ability    //obekt ot Ability
            {
                Title = abilityDTO.Title,             //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO
                Description = abilityDTO.Description  //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO

            };       //инстанция на  обект Natioality

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.AbilityRepository.Insert(Ability);
                    unitOfWork.Save();
                }
                    // ctx.Abilities.Add(Ability); //konteksta/ tablicata/ podawame dannite
                    //   ctx.SaveChanges();
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
                    Ability ability = unitOfWork.AbilityRepository.GetByID(id);
                    unitOfWork.AbilityRepository.Delete(ability);
                    unitOfWork.Save();
                }

                //Ability ability = ctx.Abilities.Find(id);     
                // ctx.Abilities.Remove(ability);
                //   ctx.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public bool Update(AbilityDTO abilityDTO)
        {
            Ability toUpdate = null;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                toUpdate = unitOfWork.AbilityRepository.GetByID(abilityDTO.Id);
            }
            if (toUpdate != null)
            {
                toUpdate.Title = abilityDTO.Title;
                toUpdate.Description = abilityDTO.Description;
            }
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.AbilityRepository.Update(toUpdate);
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


        //end
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%




















































        /*  public List<AbilityDTO> Search(string filtering)
          {
              List<AbilityDTO> abilityDTO = new List<AbilityDTO>();

              using (UnitOfWork unitOfWork = new UnitOfWork())
              {
                  foreach(var item in unitOfWork.AbilityRepository.Get())
                  {
                      if(item.Id != 0 && item.Title != null)
                      {
                          if(filtering == item.Title)
                          {
                              abilityDTO.Add(new AbilityDTO
                              {
                                  Id = item.Id,
                                  Title = item.Title,
                                  Description = item.Description
                              });
                          }
                      }
                      else
                      {
                          abilityDTO.Add(new AbilityDTO
                          {
                              Id = item.Id,
                              Title = item.Title,
                              Description = item.Description
                          });
                      }

                  }
              }
              return abilityDTO;
          }*/
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public List<AbilityDTO> GetAbilitiesSearch(string filtering)
         {
             List<AbilityDTO> abilityDTO = new List<AbilityDTO>();

             using (UnitOfWork unitOfWork = new UnitOfWork())
             {
                 foreach(var item in unitOfWork.AbilityRepository.Get())
                 {
                     if(item.Id != 0 && item.Title != null)
                     {
                         if(filtering == item.Title)
                         {
                             abilityDTO.Add(new AbilityDTO
                             {
                                 Id = item.Id,
                                 Title = item.Title,
                                 Description = item.Description
                             });
                         }
                     }
                     else
                     {
                         abilityDTO.Add(new AbilityDTO
                         {
                             Id = item.Id,
                             Title = item.Title,
                             Description = item.Description
                         });
                     }

                 }
             }
             return abilityDTO;
         }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        /*  public List<AbilityDTO> Search(string filtering)
        {
            List<AbilityDTO> abilityDTO = new List<AbilityDTO>();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach(var item in unitOfWork.AbilityRepository.Get(x => x.Title.Contains(filtering)))
                {
                    abilityDTO.Add(new AbilityDTO
                    {
                        Id = item.Id,
                        Title = item.Title,    
                        Description = item.Description
                    });
                }
            }
            return abilityDTO;
        }*/
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    }
}
