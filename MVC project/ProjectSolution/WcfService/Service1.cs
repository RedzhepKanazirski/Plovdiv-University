using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AplicationService.DTOs;
using AplicationService.Implementations;
using DataDB.Context;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
        //####################################################################------------------ABILITY------------------###################################################################
        private AbilityManagementService abilityService = new AbilityManagementService();


        public List<AbilityDTO> GetAbilities()
        {
            return abilityService.Get();
        }

        public string PostAbility(AbilityDTO abilityDTO)
        {
            if(!abilityService.Save(abilityDTO))
            {
                return "Ability is not saved";
            }
            else
            {
                return "Ability is saved";
            }
        }

        public AbilityDTO GetAbilityByID(int id)
        {
            return abilityService.GetById(id);
        }

        public string DeletAbility(int id)
        {
            if (!abilityService.Delete(id))
            {
                return "Ability is not deleted";
            }
            else
            {
                return "Ability is deleted";
            }
        }
        public string UpdateUser(AbilityDTO abilityDTO)
        {
            if (abilityService.Update(abilityDTO))
            {
                return "Ability is updated!";
            }
            else
            {
                return "Ability is not updated!";
            }
        }

       public List<AbilityDTO> GetAbilitiesSearch(string filtering)
        {
            return abilityService.GetAbilitiesSearch(filtering);
       }


        //#######################################################################################-----------------WEAPON------------------#######################################################
        private WeaponManagementServise weaponService = new WeaponManagementServise();


        public List<WeaponDTO> GetWeapons()
        {
            return weaponService.Get();
        }

        public string PostWeapon(WeaponDTO weaponDTO)
        {
            if (!weaponService.Save(weaponDTO))
            {
                return "Weapon is not saved";
            }
            else
            {
                return "Weapon is saved";
            }
        }

        public WeaponDTO GetWeaponByID(int id)
        {
            return weaponService.GetById(id);
        }

        public string DeletWeapon(int id)
        {
            if (!weaponService.Delete(id))
            {
                return "Weapon is not deleted";
            }
            else
            {
                return "Weapon is deleted";
            }
        }

        //##################################################################################-----------------CLAN------------------############################################################
        private ClanManagementService clanService = new ClanManagementService();


        public List<ClanDTO> GetClans()
        {
            return clanService.Get();
        }

        public string PostClan(ClanDTO clanDTO)
        {
            if (!clanService.Save(clanDTO))
            {
                return "Clan is not saved";
            }
            else
            {
                return "Clan is saved";
            }
        }

        public ClanDTO GetClanByID(int id)
        {
            return clanService.GetById(id);
        }

        public string DeleteClan(int id)
        {
            if (!clanService.Delete(id))
            {
                return "Clan is not deleted";
            }
            else
            {
                return "Clan is deleted";
            }
        }


        public string UpdateClan(ClanDTO clanDTO)
        {
            if (clanService.Update(clanDTO))
            {
                return "Clan is updated!";
            }
            else
            {
                return "Clan is not updated!";
            }
        }

        //#####################################################################################-----------------*Champion*------------------###########################################
        private ChampionManagementService championService = new ChampionManagementService();


        public List<ChampionDTO> GetChampions()
        {
            return championService.Get();
        }

        public string PostChampion(ChampionDTO championDTO)
        {
            if (!championService.Save(championDTO))
            {
                return "Champion is not saved";
            }
            else
            {
                return "Champion is saved";
            }
        }

        public ChampionDTO GetChampionByID(int id)
        {
            return championService.GetById(id);
        }

        public string DeleteChampion(int id)
        {
            if (!championService.Delete(id))
            {
                return "Champion is not deleted";
            }
            else
            {
                return "Champion is deleted";
            }
        }

        public string EditAbility(int id)
        {
            throw new NotImplementedException();
        }

        public string UpdateChampion(ChampionDTO championDTO)
        {
            if (championService.Update(championDTO))
            {
                return "Champion is updated!";
            }
            else
            {
                return "Champion is not updated!";
            }
        }

        //##############################################################################################################################################

        //##############################################################################################################################################

        //##############################################################################################################################################
    }
}
