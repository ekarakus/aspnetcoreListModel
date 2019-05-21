using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using listeYapma.Models;

namespace listeYapma.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<personel> personeller = new List<personel>();
            personeller.Add(new personel()
            {
                Ad = "Enes",
                Departman = "Bilgi İşlem",
                Maas = 7000
            });
            personeller.Add(new personel()
            {
                Ad = "Ceren",
                Departman = "İnsan Kaynakları",
                Maas = 5000.70
            });

            personeller.Add(new personel()
            {
                Ad = "Umut Can",
                Departman = "Muhasebe",
                Maas = 4000
            });
            personeller.Add(new personel()
            {
                Ad = "Merve",
                Departman = "Üretim",
                Maas = 4500
            });

            personeller.Add(new personel()
            {
                Ad = "Emre",
                Departman = "Pazarlama",
                Maas = 8000
            });
            personeller.Add(new personel()
            {
                Ad = "Ayşe",
                Departman = "Muhasebe",
                Maas = 3000
            });
            
                
            return View(personeller);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
    }
}
