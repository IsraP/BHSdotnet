using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Models;
using Data;
using Model;

namespace App.Controllers
{
    public class PedidoController : Controller
    {
        public IRepository _repo;

        public PedidoController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult showPedidos([FromQuery] int page)
        {
            if (page <= 0)
                page = 1;

            ViewBag.page = page;

            var pedidos = _repo.getAllPedidos(page);

            return pedidos.Any() ? View(pedidos) : View(new List<Pedido>());
        }

        public IActionResult showNextPage(int page)
        {
            page++;
            return RedirectToAction("showPedidos", new { page = page });
        }

        public IActionResult showPreviousPage(int page)
        {
            page--;
            return RedirectToAction("showPedidos", new { page = page });
        }

        public IActionResult addPedido()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addPedido(Pedido p)
        {
            p.Status = "A";
            p.Itens = new HashSet<Item>();
            p.Codigo = _repo.getLastCodigoPedido() + 1;

            _repo.Add(p);

            _repo.SaveChanges();

            return RedirectToAction("showPedidos");
        }


        public IActionResult removePedido(int id)
        {
            if (id == 0)
                return RedirectToAction("showPedidos");

            Pedido pRemove = _repo.getPedidoById(id);

            bool flag = _repo.RemovePedido(pRemove);

            if (flag)
                _repo.SaveChanges();

            return RedirectToAction("showPedidos");
        }

        public IActionResult restorePedido(int id)
        {
            if (id == 0)
                return RedirectToAction("showPedidos");

            Pedido pRestore = _repo.getPedidoById(id);

            bool flag = _repo.RestorePedido(pRestore);

            if (flag)
                _repo.SaveChanges();

            return RedirectToAction("showPedidos");
        }

        public IActionResult searchPedidos(string query, int page)
        {
            if (query == null || query == "")
                return RedirectToAction("showPedidos");

            if (page <= 0)
                page = 1;

            ViewBag.page = page;
            ViewBag.query = query;

            var results = _repo.getPedidosWithQuery(query, page);

            return View(results);
        }

        public IActionResult searchNextPage(string query, int page)
        {
            page++;
            return RedirectToAction("searchPedidos", new { query = query, page = page });
        }

        public IActionResult searchPreviousPage(string query, int page)
        {
            page--;
            return RedirectToAction("searchPedidos", new { query = query, page = page });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
