using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace tl2_tp4_2022_agussarroyoo.Controllers
{
    [Route("[controller]")]
    public class Cadeteria : Controller
    {
        private readonly ILogger<Cadeteria> _logger;

        public Cadeteria(ILogger<Cadeteria> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public IActionResult ListarCadetes() {
            return View();
        }
    }
}