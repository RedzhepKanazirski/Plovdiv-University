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
    public class WeaponManagementServise
    {
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        private Student55SystemDBContext ctx = new Student55SystemDBContext(); //инстанция на "context"

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public List<WeaponDTO> Get()                                   //Get метод който извиквяа Context, взема всички от weapons  и ги връща като List
        {
            List<WeaponDTO> weaponsDTO = new List<WeaponDTO>();           //променлива за резултатите

            //foreach (var item in ctx.Weapons.ToList())                     //пълни ги
            // {

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                foreach (var item in unitOfWork.WeaponRepository.Get()) 
                { 
                weaponsDTO.Add(new WeaponDTO
                {
                    Id = item.Id,
                    Name = item.Name,
                    Range = item.Range,
                    Description = item.Description,
                    Type = item.Type,
                    Rarity = item.Rarity
                });
                }
            }

            return weaponsDTO;                                            //връща ги в листа
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public WeaponDTO GetById(int id)
        {
            WeaponDTO weaponDTO = new WeaponDTO();

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Weapon weapon = unitOfWork.WeaponRepository.GetByID(id);

                if (weapon != null)
                {
                    weaponDTO.Id = weapon.Id;
                    weaponDTO.Name = weapon.Name;
                    weaponDTO.Range = weapon.Range;
                    weaponDTO.Description = weapon.Description;
                    weaponDTO.Type = weapon.Type;
                    weaponDTO.Rarity = weapon.Rarity;
                }
            }

            // Weapon weapon = ctx.Weapons.Find(id);
           
            return weaponDTO;
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public bool Save(WeaponDTO weaponDTO)  //функция 
        {
            Weapon Weapon = new Weapon    //obekt ot Ability
            {
                Name = weaponDTO.Name,                 //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO
                Range = weaponDTO.Range,                //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO
                Description = weaponDTO.Description,  //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO
                Type = weaponDTO.Type,                   //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO
                Rarity = weaponDTO.Rarity             //преьвърляме информацията от "A"bilityDTO в "a"bilityDTO


            };       //инстанция на  обект Natioality

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.WeaponRepository.Insert(Weapon);
                    unitOfWork.Save();
                }

                 //ctx.Weapons.Add(Weapon); //konteksta/ tablicata/ podawame dannite
              //  ctx.SaveChanges();
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
                    Weapon weapon = unitOfWork.WeaponRepository.GetByID(id);
                    unitOfWork.WeaponRepository.Delete(weapon);
                    unitOfWork.Save();
                }

               // Weapon weapon = ctx.Weapons.Find(id);
              //  ctx.Weapons.Remove(weapon);
              //  ctx.SaveChanges();

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
