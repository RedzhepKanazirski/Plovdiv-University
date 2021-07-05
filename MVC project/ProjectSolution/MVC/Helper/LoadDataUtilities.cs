using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Helper
{
    public class LoadDataUtilities
    {
        public static SelectList LoadAbilityData()
        {
            using(SOAPService.Service1Client service =new SOAPService.Service1Client())
            {
                return new SelectList(service.GetAbilities(), "Id", "Title","Description");
            }
        }

        public static SelectList LoadWeaponData()
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                return new SelectList(service.GetWeapons(), "Id", "Name");
            }
        }

        public static SelectList LoadClanData()
        {
            using (SOAPService.Service1Client service = new SOAPService.Service1Client())
            {
                return new SelectList(service.GetClans(), "Id", "Name");
            }
        }
    }
}