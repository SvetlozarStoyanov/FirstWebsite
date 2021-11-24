using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrysisWalkthroughs.Models;
using CrysisWalkthroughs.Services;

namespace CrysisWalkthroughs.Controllers
{
    public class Weapons : Controller
    {
        HardCodedWeapons HardCodedWeapons = new HardCodedWeapons();
        public IActionResult Index()
        {

            return View(HardCodedWeapons.GetAllWeapons());
        }
        public IActionResult ShowWeaponStats(int Id)
        {
            return View(HardCodedWeapons.GetWeaponById(Id));
        }
    }
}
