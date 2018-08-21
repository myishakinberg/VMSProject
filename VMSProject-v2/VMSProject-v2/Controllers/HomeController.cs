using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VMSProjectV2.Models;

namespace VMSProject_v2.Controllers
{
    public class HomeController : Controller
    {
        AdminViewModel CurrentAdmin = new AdminViewModel();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginViewModel login)
        {
            if(login.Email != null && login.Password != null)
            {
                AdminViewModel admin = new AdminViewModel();
                CurrentAdmin.Email = login.Email;

                return RedirectToAction("AdminPageView", CurrentAdmin);
            }

            return View();
        }
        public IActionResult AdminPageView()
        {
            return View(CurrentAdmin);
        }
        public IActionResult ManageVolunteersView()
        {
            AdminViewModel admin = new AdminViewModel();

            if (TempData["NewVol"] != null)
            {
                admin = (AdminViewModel)TempData["NewVol"];
                return View(admin);
            }
            return View(admin);
        }
        public IActionResult ManageOpportunitiesView()
        {
            return View();
        }
        public IActionResult AddNewVolunteer(VolunteerViewModel vol)
        {

            if (vol.FirstName == null)
            {
                VolunteerViewModel newVolunteer = new VolunteerViewModel();
                return View(newVolunteer);
            }
            else
            {
                AdminViewModel admin = new AdminViewModel();
                CurrentAdmin.Volunteers.Add(vol);
                admin.Volunteers.Add(vol);

                TempData["NewVol"] = vol;
                return View("ManageVolunteersView");
            }

        }
        /*[HttpPost]
        public IActionResult AddNewVolunteer(VolunteerViewModel newVolunteer)
        {
                AdminViewModel admin = new AdminViewModel();
                admin.Volunteers.Add(newVolunteer);
                return RedirectToAction("Index");
            
        }*/
        public IActionResult ContactView()
        {
            ViewData["Message"] = "Use the information below to contact one of our Volunteer Opportunity specialists!";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public JsonResult AjaxCallToCreateNewVolunteer(string firstName, string lastName)
        {
            return (Json("Success"));
        }
    }
}
