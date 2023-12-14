using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCRehberUyg.Data;

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}