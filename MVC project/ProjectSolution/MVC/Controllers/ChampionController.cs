using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AplicationService.DTOs;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class ChampionController : Controller
    {
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        // GET: Champion
        public ActionResult Index(string search)
        {
            List<ChampionVM> championsVM = new List<ChampionVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetChampions())
                {
                    championsVM.Add(new ChampionVM(item));   // пълним листа             //   cast from AbilityDTO to AbilityVM
                }
                if (search != null)
                {
                    Object chmp = championsVM.Where(x => x.Nickname == search);
                    return View(chmp);
                }
            }
            return View(championsVM);// и го връщаме  
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //Get by ID DETAILS
        public ActionResult Details(int id)
        {
            ChampionVM championVM = new ChampionVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var championDTO = service.GetChampionByID(id);
                championVM = new ChampionVM(championDTO);
            }
            return View(championVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public ActionResult Create()
        {
            ViewBag.Abilities = Helper.LoadDataUtilities.LoadAbilityData();
            ViewBag.Weapons = Helper.LoadDataUtilities.LoadWeaponData();
            ViewBag.Clans = Helper.LoadDataUtilities.LoadClanData();
            return View();
        }
    //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    // POST: Champion
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(ChampionVM championVM)
        {
            try
            { 
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        ChampionDTO championDTO = new ChampionDTO     //прехвърляне на данните от АbilityVM към  AbilityDTO и после от AbilityDTO към Аbility
                        {
                            Nickname = championVM.Nickname,
                            Name = championVM.Name,
                            DOB = championVM.DOB,
                            Gender = championVM.Gender,

                            AbilityID = championVM.AbilityID,
                            Ability = new AbilityDTO
                            {
                                Id = championVM.AbilityID,
                            },

                            WeaponID = championVM.WeaponID,
                            Weapon = new WeaponDTO
                            {
                                Id = championVM.WeaponID,
                            },

                            ClanID = championVM.ClanID,
                            Clan = new ClanDTO
                            {
                                Id = championVM.ClanID,

                            }
                        };
                        service.PostChampion(championDTO);

                    }
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Abilities = Helper.LoadDataUtilities.LoadAbilityData();
                ViewBag.Weapons = Helper.LoadDataUtilities.LoadWeaponData();
                ViewBag.Clans = Helper.LoadDataUtilities.LoadClanData();

                return View();
            }
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //DELETE Champion
        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteChampion(id);
            }
            return RedirectToAction("Index");
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //edit
        public ActionResult Edit(int id)
        {
            ChampionVM championVM = new ChampionVM();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                if (ModelState.IsValid)
                {
                    var championDTO = service.GetChampionByID(id);
                    championVM = new ChampionVM(championDTO);


                    // return RedirectToAction("Edit");
                }

                return View(championVM);
            }
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        [HttpPost]
        public ActionResult Edit(ChampionVM championVM)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                if (championVM.Name.Length < 30)
                {
                    ChampionDTO chmp = new ChampionDTO
                    {
                        Id = championVM.Id,
                        Nickname = championVM.Nickname,
                        Name = championVM.Name,
                        DOB = championVM.DOB,
                        Gender = championVM.Gender,
                        AbilityID = championVM.AbilityID,
                        Ability = new AbilityDTO
                        {
                            Id = championVM.AbilityID,
                        },

                        WeaponID = championVM.WeaponID,
                        Weapon = new WeaponDTO
                        {
                            Id = championVM.WeaponID,
                        },

                        ClanID = championVM.ClanID,
                        Clan = new ClanDTO
                        {
                            Id = championVM.ClanID,

                        }

                    };
                    service.UpdateChampion(chmp);
                }
            }

            return View(championVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    }
}