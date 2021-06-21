using KTB.Uygulama.Bll.Abstract;
using KTB.Uygulama.Bll.Concrete;
using KTB.Uygulama.Entities;
using KTB.Uygulama.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace KTB.Uygulama.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPersonelService _personelService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _personelService = new PersonelManager();
        }

        public IActionResult Index()
        {
            var personels = _personelService.GetAll();
            return View(personels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult SavePersonel(string Ad, string Soyad)
        {
            var personel = new Personel();
            personel.Ad = Ad;
            personel.Soyad = Soyad;
            _personelService.Add(personel);

            return RedirectToAction("Index", "Home");
        }
    }
}
