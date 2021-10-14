using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using TP3_LunaClaraso.Models;

namespace TP3_LunaClaraso.Controllers
{
    public class PedidoController : Controller
    {
        static int id = 0;
        private readonly ILogger<PedidoController> _logger;
        private readonly BDTemporal _BD;

        public PedidoController(ILogger<PedidoController> logger, BDTemporal BD)
        {
            _logger = logger;
            _BD = BD;
        }

        // GET: PedidoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PedidoController/Details/5
        public ActionResult AltaPedido()
        {
            return View(_BD.Cadeteria.Cadetes);
        }

        // GET: PedidoController/Create
        public ActionResult VerClientes()
        {
            return View(_BD.Cadeteria.Clientes);
        }

        public IActionResult VerPedidos()
        {
            
            return View(_BD.Cadeteria);
        }
        public IActionResult DarAlta(int nro, string observacion, int idCliente, string nombre, string direccion, long telefono)
        {/*
            Pedidos nuevoPedido = new(++nro,observacion, idCliente, nombre,direccion,telefono);
            _BD.Cadeteria.Pedidos.Add(nuevoPedido);
            Cliente nuevoCliente = new(++nro, nombre,  direccion,  telefono);
            _BD.Cadeteria.Clientes.Add(nuevoCliente);
            
            return View("VerPedidos", _BD.Cadeteria);
            */
            int ultimoNum = 100;
            if (_BD.Cadeteria.Pedidos.Count() > 0)
            {
                ultimoNum = _BD.Cadeteria.Pedidos.Max(x => x.Nro);
            }
            ultimoNum++;
            Pedidos nuevoPedido = new Pedidos(ultimoNum, observacion, idCliente, nombre, direccion, telefono);
            _BD.Cadeteria.Pedidos.Add(nuevoPedido);
            _BD.GuardarPedido(_BD.Cadeteria.Pedidos);
            return View("VerPedidos", _BD.Cadeteria);
        }
        public IActionResult BorrarCadete(int idpedido)
        {
            _BD.Cadeteria.Pedidos.RemoveAll(pedido => pedido.Nro == idpedido);

            _BD.EliminarCadete();

            return View("Index", _BD.Cadeteria.Pedidos);
        }
        public IActionResult AsignarCadete(int idPedido, int idCadete)
        {
            //QuitarPedidoDeCadete(idPedido);

            if (idCadete != 0)
            {
                Cadete cadete = _BD.Cadeteria.Cadetes.Where(a => a.Id == idCadete).First();
                Pedidos pedido = _BD.Cadeteria.Pedidos.Where(b => b.Nro == idPedido).First();
                cadete.ListadoDePedidos1.Add(pedido);
            }

            return View("VerPedidos", _BD.Cadeteria);
        }

        public IActionResult EliminarPedido(int idPedido)
        {
            eliminarUnPedido(idPedido);
            
            return View("VerPedidos", _BD.Cadeteria);
        }

        public void eliminarUnPedido(int id)
        {
            Pedidos pedido = _BD.Cadeteria.Pedidos.Where(a => a.Nro == id).First();
            _BD.Cadeteria.Pedidos.Remove(pedido);

            quitarPedidoCadete(pedido);
        }

        public void quitarPedidoCadete(Pedidos pedido)
        {
            _BD.Cadeteria.Cadetes.ForEach(cad => cad.ListadoDePedidos1.Remove(pedido));
        }

        // POST: PedidoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PedidoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PedidoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PedidoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
