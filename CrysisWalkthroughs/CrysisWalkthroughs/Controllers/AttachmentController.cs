using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrysisWalkthroughs.Models;
using CrysisWalkthroughs.Services;

namespace CrysisWalkthroughs.Controllers
{
    public class AttachmentController : Controller
    {
        HardCodedAttachments HardCodedAttachments = new HardCodedAttachments();
       
        public IActionResult ShowAttachment(string Name)
        {
            return View(HardCodedAttachments.GetAttachmentByName(Name));
        }
    }
}
