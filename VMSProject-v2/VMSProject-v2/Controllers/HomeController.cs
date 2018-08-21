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
        public AdminViewModel CurrentAdmin = new AdminViewModel();

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
                admin.Email = login.Email;

                return RedirectToAction("AdminPageView", admin);
            }

            return View();
        }
        public IActionResult AdminPageView(AdminViewModel admin)
        {
            return View(admin);
        }
        public IActionResult ManageVolunteersView(AdminViewModel admin)
        {
            return View(admin);
        }

        public IActionResult ManageOpportunitiesView()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddNewVolunteer()
        {
            VolunteerViewModel newVolunteer = new VolunteerViewModel();
            return View(newVolunteer);
        }
        [HttpPost]
        public IActionResult AddNewVolunteer(VolunteerViewModel newVolunteer)
        {
                AdminViewModel admin = new AdminViewModel();
                admin.Volunteers.Add(newVolunteer);
                return RedirectToAction("Index");
            
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
            return (Json("Success"));
        }
    }
}
