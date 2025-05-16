using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Industry_4._0.Models;

namespace Industry_4._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact_and_About()
        {
            

            return View();
        }

        public IActionResult Companies_and_Organisations()
        {
            

            return View();
        }
        public IActionResult Emerging_Technologies()
        {


            return View();
        }

        public IActionResult World_Map()
        {


            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
