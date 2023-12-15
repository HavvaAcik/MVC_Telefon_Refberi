using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCRehberUyg.Data;
using MVCRehberUyg.Models;

namespace MVCRehberUyg.Controllers
{
    //[Route("[controller]")]
    public class RehberYonetimController : Controller
    {
        private readonly ILogger<RehberYonetimController> _logger;
        private readonly SanalVeritabani _context;

    

        public RehberYonetimController(ILogger<RehberYonetimController> logger,SanalVeritabani context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() // kişileri listeleme indexi ,home daki ındex sayfa indexi
        {
            return View(model:_context.Kisilers);
        }

        [HttpGet]
        public IActionResult Ekle() // ekleme formuna yönlendirecek 
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Kisiler yeniKisi) // formdan gelen kişiyi ekleyecek
        {
            _context.Kisilers.Add(yeniKisi);
            return RedirectToAction("Index");
        }

        public IActionResult Detaylar(int id)
        {
            // hangi id hangi personelin?
            var kisiler = _context.Kisilers.SingleOrDefault(k => k.KisiNo ==id);
            return View(model:kisiler);
        }
        [HttpGet]
        public IActionResult Duzenle(int id) // formu açıyor 
        {
            var kisiler = _context.Kisilers.SingleOrDefault(k => k.KisiNo ==id);
            return View(model:kisiler);
        }
        [HttpPost]
        public IActionResult Duzenle(Kisiler duzenlenmisKisiler) // formdan gelen veriyi açıyor.
        {
            var kisiler = _context.Kisilers.SingleOrDefault(k => k.KisiNo == duzenlenmisKisiler.KisiNo);
            kisiler.Ad= duzenlenmisKisiler.Ad;
            kisiler.Soyad=duzenlenmisKisiler.Soyad;
            kisiler.TelefonNo=duzenlenmisKisiler.TelefonNo;
            return RedirectToAction("Index");
        }
        
        
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}