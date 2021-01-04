using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ButonOrnek.Models;

namespace ButonOrnek.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        // Homepage
        public IActionResult Index()
        {
            return View();
        }

        // Buton Click action'u
        public IActionResult ButonClick(string button)
        {
            ViewBag.btnValue = button;
            return View("Index");
        }
        //////////////////
        

        // Sadece click veri gelmiyor
        public IActionResult ButtonClick2()
        {
            ViewBag.btnValue = "Buralar çok sıcak";
            return View("Index");
        }
        ////////////////


        // Form ile veri alma
        [HttpPost]
        public IActionResult Form(string gidenbox1)
        {
            ViewBag.btnValue = gidenbox1;
            return View("Index");
        }




        // Gereksiz ıvır zıvır

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
