using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP3_LunaClaraso.Models;

namespace TP3_LunaClaraso.Controllers
{
    public class CadeteController : Controller
    {
        static int id = 0;
        private readonly ILogger<CadeteController> _logger;
        private readonly BDTemporal _BD;
        private readonly RepositorioCadete _cd;

        public CadeteController(ILogger<CadeteController> logger, RepositorioCadete cd)
        {
            _logger = logger;
            _cd = cd;

        }

        // GET: CadeteController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult AltaCadete()
        {
            return View();
        }
        public IActionResult VerCadetes()
        {
            return View(_cd.MostrarCadetes());
        }
        
        public IActionResult DarAlta(string nombre, string direccion, string telefono)
        {
            Cadete nuevoCadete = new (++id, nombre, direccion, telefono);
            //_BD.Cadeteria.Cadetes.Add(nuevoCadete);
            _cd.guardarCadete(nuevoCadete);
            return View("Index", _cd.MostrarCadetes());
        }/*
        public IActionResult BorrarCadete(int id)
        {
            int i = 0;
            foreach (var item in _BD.Cadeteria.Cadetes)
            {
                if (item.Id == id)
                {
                    _BD.EliminarCadete();
                    break;
                }
                i++;
            }
            return View("Index", _BD.Cadeteria.Cadetes);
        }
        */
        public IActionResult ModificarCadete(int id)
        {
            Cadete cadete =_cd.MostrarCadeteID(id);
            return View(cadete);
        }
        
        public IActionResult Modify(Cadete cd)
        {
            _cd.ModificarCadete(cd);

            return View("Index", _cd.MostrarCadetes());

        }
    }
}
