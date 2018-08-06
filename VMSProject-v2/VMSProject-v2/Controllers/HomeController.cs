﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VMSProject_v2.Models;

namespace VMSProject_v2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdminPageView()
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
    }
}
