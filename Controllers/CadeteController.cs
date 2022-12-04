using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using tl2_tp4_2022_agussarroyoo.Models;

namespace tl2_tp4_2022_agussarroyoo.Controllers
{
    [Route("[controller]/[action]")]
    public class CadeteController : Controller
    {
        private readonly ILogger<Cadete> _logger;
        public static ICollection<Cadete> cadetes = new List<Cadete>();

        public CadeteController(ILogger<Cadete> logger)
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

        [HttpGet]
        public IActionResult Alta() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Alta(string nombre, string direc, long telefono) {
            Cadete cadete = new Cadete( nombre,  direc,  telefono);
            cadetes.Add(cadete);
            return View("Listar", cadetes);
        }

        [HttpGet]
        public IActionResult Baja(int Id) {
            try
            {
              cadetes.Remove(BuscarPorId(Id));
              return RedirectToAction("Listar");

            }
            catch (System.Exception)
            {
                
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public IActionResult Edit(int Id) {
            return RedirectToAction("Editar",BuscarPorId(Id));
        }

        public IActionResult Editar(int Id) {
            return View(BuscarPorId(Id));
        }

        [HttpPost] 
        public IActionResult Editar(int id,string nombre, string direc, long telefono) {
            try
            {
                Cadete cadete = BuscarPorId(id);
                cadete.Nombre = nombre;
                cadete.Direccion = direc;
                cadete.Telefono = telefono;
                return RedirectToAction("Listar");
            }
            catch (System.Exception)
            {
                
                return RedirectToAction("Index");
            }
            

        }
        public Cadete BuscarPorId(int id) {
            return cadetes.FirstOrDefault(x => x.ID == id);
        }

        public IActionResult Listar() {
            return View(cadetes);
        }

    }
}