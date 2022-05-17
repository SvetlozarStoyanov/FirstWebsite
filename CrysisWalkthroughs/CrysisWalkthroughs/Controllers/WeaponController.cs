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
        HardCodedAttachments HardCodedAttachments = new HardCodedAttachments();
        public IActionResult Index()
        {
            return View(HardCodedWeapons.GetAllWeapons());
        }
        public IActionResult ShowWeaponStats(string Name)
        {
            HardCodedAttachments.GetAllAttachments();
            return View(HardCodedWeapons.GetWeaponByName(Name));
        }
        public IActionResult FilterIndex()
        {
            return View(HardCodedAttachments.GetAllAttachments());
        }
        //[HttpPost]
        //public IActionResult FilterIndex(string attachmentName)
        //{
        //    return View();
        //}
        public IActionResult FilterWeaponsByAttachment(string attachmentName)
        {
            return View(HardCodedWeapons.GetAllWeaponsWithAttachment(attachmentName));
        }
    }
}
