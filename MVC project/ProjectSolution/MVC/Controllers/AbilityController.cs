using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicationService.DTOs;
using DataDB.Context;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class AbilityController : Controller
    {
 //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        // GET: Ability
        public ActionResult Index( string ability)
        {
            List<AbilityVM> abilitiesVM = new List<AbilityVM>();
          
            using(SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach(var item in service.GetAbilities())
                {
                    abilitiesVM.Add(new AbilityVM(item));   // пълним листа             //   cast from AbilityDTO to AbilityVM
                }
                if(ability != null)
                {
                    Object ablt = abilitiesVM.Where(x => x.Title == ability);
                    return View(ablt);
                }
            }
            return View(abilitiesVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //Get by ID DETAILS
        public ActionResult Details(int id)
        {
            AbilityVM abilityVM = new AbilityVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var abilityDTO = service.GetAbilityByID(id);
                abilityVM = new AbilityVM(abilityDTO);
            }
            return View(abilityVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        // POST: Ability
        public ActionResult Create(AbilityVM abilityVM)
        {
            try
            {
                if(ModelState.IsValid)
                { 
                using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                {
                    AbilityDTO abilityDTO = new AbilityDTO     //прехвърляне на данните от АbilityVM към  AbilityDTO и после от AbilityDTO към Аbility
                    {
                        Title = abilityVM.Title, 
                        Description = abilityVM.Description
                    };
                    service.PostAbility(abilityDTO);

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
        //DELETE
        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeletAbility(id);
            }
            return RedirectToAction("Index");
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //edit
        public ActionResult Edit(int id)
        {
            AbilityVM abilityVM = new AbilityVM();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                if (ModelState.IsValid)
                {
                    var abilityDTO = service.GetAbilityByID(id);
                    abilityVM = new AbilityVM(abilityDTO);


                   // return RedirectToAction("Edit");
                }

                return View(abilityVM);
            }
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        [HttpPost]
        public ActionResult Edit(AbilityVM abilityVM)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                if (abilityVM.Title.Length < 30)
                {
                    AbilityDTO abil = new AbilityDTO
                    {
                        Id = abilityVM.Id,
                        Title = abilityVM.Title,
                        Description = abilityVM.Description
                    };
                    service.UpdateUser(abil);
                }
            }
            
            return View(abilityVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%





















        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        private Student55SystemDBContext ctx = new Student55SystemDBContext(); //инстанция на "context"


        /*    public ActionResult Search(string searchString)
            {
                using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                {

                    var abilities = from m in ctx.Abilities
                                    select m;

                    if (!String.IsNullOrEmpty(searchString))
                    {
                        abilities = abilities.Where(s => s.Title.Contains(searchString));
                    }


                return View(abilities);
                }
            }*/
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public ActionResult Search(string SearchString)
        {
            List<AbilityVM> abilityVM = new List<AbilityVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                if (!String.IsNullOrEmpty(SearchString))
                {

                    foreach (var item in service.GetAbilitiesSearch(SearchString))
                    {
                        abilityVM.Add(new AbilityVM(item));
                    }
                }
                else
                {
                    foreach (var item in service.GetAbilities())
                    {
                        abilityVM.Add(new AbilityVM(item));
                    }
                }
                Session["Id"] = service.GetAbilities().Max(x => x.Id);
            }
            return View(abilityVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
      /*  public ActionResult Search(string SearchString = "")
        {
            List<AbilityVM> abilityVM = new List<AbilityVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetAbilitiesSearch(SearchString))
                {
                    abilityVM.Add(new AbilityVM(item));
                }
            }
            return View(abilityVM);
        }*/
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    }
}