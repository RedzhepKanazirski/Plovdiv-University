using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AplicationService.DTOs;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class ClanController : Controller
    {
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        // GET: Clan
        public ActionResult Index(string search)
        {
            List<ClanVM> clansVM = new List<ClanVM>();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                foreach (var item in service.GetClans())
                {
                    clansVM.Add(new ClanVM(item));   // пълним листа             //   cast from AbilityDTO to AbilityVM
                }

                if (search != null)
                {
                    Object cln = clansVM.Where(x => x.Symbol == search);
                    return View(cln);
                }
            }
            return View(clansVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //Get by ID DETAILS
        public ActionResult Details(int id)
        {
            ClanVM clanVM = new ClanVM();
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                var clanDTO = service.GetClanByID(id);
                clanVM = new ClanVM(clanDTO);
            }
            return View(clanVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        // POST: Clan
        public ActionResult Create(ClanVM clanVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SOAPService.Service1Client service = new SOAPService.Service1Client())
                    {
                        ClanDTO clanDTO = new ClanDTO     //прехвърляне на данните от АbilityVM към  AbilityDTO и после от AbilityDTO към Аbility
                        {
                            Name = clanVM.Name,
                            Dating = clanVM.Dating,
                            Symbol = clanVM.Symbol,
                            Specificity = clanVM.Specificity
                        };
                        service.PostClan(clanDTO);

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
        //DELETE Clan
        public ActionResult Delete(int id)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                service.DeleteClan(id);
            }
            return RedirectToAction("Index");
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        //edit
        public ActionResult Edit(int id)
        {
            ClanVM clanVM = new ClanVM();

            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                if (ModelState.IsValid)
                {
                    var clanDTO = service.GetClanByID(id);
                    clanVM = new ClanVM(clanDTO);


                    // return RedirectToAction("Edit");
                }

                return View(clanVM);
            }
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        [HttpPost]
        public ActionResult Edit(ClanVM clanVM)
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                if (clanVM.Name.Length < 30)
                {
                    ClanDTO clan = new ClanDTO
                    {
                        Id = clanVM.Id,
                        Name = clanVM.Name,
                        Dating = clanVM.Dating,
                        Symbol = clanVM.Symbol,
                        Specificity = clanVM.Specificity

                    };
                    service.UpdateClan(clan);
                }
            }

            return View(clanVM);
        }
        //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    }
}