using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeFitnessFinal.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EquipmentPage()
        {
            return View();
        }
        public IActionResult WorkoutPage()
        {
            return View();
        }
    }
}
