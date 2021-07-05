using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AplicationService.DTOs;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here

        //-------------------------------------------------------------Ability----------------------------------------------------------------------------
        [OperationContract]
        List<AbilityDTO> GetAbilities();

        [OperationContract]
        List<AbilityDTO> GetAbilitiesSearch(string filtering);

       [OperationContract]
        string PostAbility(AbilityDTO abilityDTO);

        [OperationContract]
        AbilityDTO GetAbilityByID(int id);

        [OperationContract]
        string DeletAbility(int id);

        [OperationContract]
        string UpdateUser(AbilityDTO abilityDTO);
        //-------------------------------------------------------------Weapon----------------------------------------------------------------------------
        [OperationContract]
        List<WeaponDTO> GetWeapons();

        [OperationContract]
        string PostWeapon(WeaponDTO weaponDTO);

        [OperationContract]
        WeaponDTO GetWeaponByID(int id);

        [OperationContract]
        string DeletWeapon(int id);

        //------------------------------------------------------------Clan-----------------------------------------------------------------------------
        [OperationContract]
        List<ClanDTO> GetClans();

        [OperationContract]
        string PostClan(ClanDTO clanDTO);

        [OperationContract]
        ClanDTO GetClanByID(int id);

        [OperationContract]
        string DeleteClan(int id);

        [OperationContract]
        string UpdateClan(ClanDTO clanDTO);
        //------------------------------------------------------------*Champion*-----------------------------------------------------------------------------
        [OperationContract]
        List<ChampionDTO> GetChampions();

        [OperationContract]
        string PostChampion(ChampionDTO championDTO);

        [OperationContract]
        ChampionDTO GetChampionByID(int id);

        [OperationContract]
        string DeleteChampion(int id);

        [OperationContract]
        string UpdateChampion(ChampionDTO championDTO);

        //-----------------------------------------------------------------------------------------------------------------------------------------

        //-----------------------------------------------------------------------------------------------------------------------------------------

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfService.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
