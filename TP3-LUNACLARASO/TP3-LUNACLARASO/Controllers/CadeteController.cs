﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP3_LunaClaraso.Models;

namespace TP3_LunaClaraso.Controllers
{
    public class CadeteController : Controller
    {
        static int id = 0;
        private readonly ILogger<CadeteController> _logger;
        private readonly BDTemporal _BD;
        
        public CadeteController(ILogger<CadeteController> logger, BDTemporal BD)
        {
           _logger = logger;
           _BD = BD;
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
            return View(_BD.Cadeteria.Cadetes);
        }
        public IActionResult DarAlta(string nombre, string direccion, long telefono)
        {
            Cadete nuevoCadete = new (++id, nombre, direccion, Convert.ToInt64(telefono));
            _BD.Cadeteria.Cadetes.Add(nuevoCadete);
            return View("Index", _BD.Cadeteria.Cadetes);
        }
       
    }
}
