using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicationService.DTOs;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class WeaponController : Controller
    {
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        // GET: Weapon
        public ActionResult Index(string search)
        {
            List<WeaponVM> weaponsVM = new List<WeaponVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetWeapons())
                {
                    weaponsVM.Add(new WeaponVM(item));   // пълним листа             //   cast from AbilityDTO to AbilityVM
                }
                if (search != null)
                {
                    Object wpn = weaponsVM.Where(x => x.Type == search);
                    return View(wpn);
                }
            }
            return View(weaponsVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //Get by ID DETAILS
        public ActionResult Details(int id)
        {
            WeaponVM weaponVM = new WeaponVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var weaponDTO = service.GetWeaponByID(id);
                weaponVM = new WeaponVM(weaponDTO);
            }
            return View(weaponVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        // POST: Weapon
        public ActionResult Create(WeaponVM weaponVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        WeaponDTO weaponDTO = new WeaponDTO     //прехвърляне на данните от АbilityVM към  AbilityDTO и после от AbilityDTO към Аbility
                        {
                            Name = weaponVM.Name,
                            Range = weaponVM.Range,
                            Description = weaponVM.Description,
                            Type = weaponVM.Type,
                            Rarity = weaponVM.Rarity
                        };
                        service.PostWeapon(weaponDTO);

                        return RedirectToAction("Index");
                    }
                }

                return View();

            }
            catch
            {
                return View();
            }

        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //DELETE Weapon
        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeletWeapon(id);
            }
            return RedirectToAction("Index");
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    }
}