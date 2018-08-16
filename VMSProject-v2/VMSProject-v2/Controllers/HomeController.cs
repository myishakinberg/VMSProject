using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VMSProjectV2.Models;

namespace VMSProject_v2.Controllers
{
    public class HomeController : Controller
    {
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
                return RedirectToAction("AdminPageView");
            }

            return View();
        }
        public IActionResult AdminPageView()
        {
            AdminViewModel newAdmin = new AdminViewModel();
            return View(newAdmin);
        }
        public IActionResult ManageVolunteersView()
        {
            VolunteerViewModel newVolunteer = new VolunteerViewModel();
            newVolunteer.FName = "Myisha";
            newVolunteer.LName = "Kinberg";
            newVolunteer.Skills.Add("Organization");
            newVolunteer.Skills.Add("Planning");
            newVolunteer.Skills.Add("Technology");
            newVolunteer.VolunteerOpp = "UNF School of Computing";

            return View();
        }
        public IActionResult ManageOpportunitiesView()
        {
            return View();
        }
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
            VolunteerViewModel newVolunteer = new VolunteerViewModel();
            newVolunteer.FName = firstName;
            newVolunteer.LName = lastName;
            AdminViewModel newAdmin = new AdminViewModel();
            newAdmin.Volunteers.Add(newVolunteer);
            return (Json("Success"));
        }
    }
}
