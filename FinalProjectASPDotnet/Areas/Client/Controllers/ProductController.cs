using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProjectASPDotnet.Models;
using FinalProjectASPDotnet.Areas.Admin.Models;

namespace FinalProjectASPDotnet.Controllers
{
    [Area("Client")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Shop()
        {
            return View("Shop");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
