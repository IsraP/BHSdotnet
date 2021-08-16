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
    public class ItemController : Controller
    {
        public IRepository _repo;

        public ItemController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult showItens([FromQuery] int page)
        {
            if (page <= 0)
                page = 1;

            ViewBag.page = page;

            var itens = _repo.getAllItens(page);


            return itens.Any() ? View(itens) : View(new List<Item>());
        }

        public IActionResult showNextPage(int page)
        {
            page++;
            return RedirectToAction("showItens", new { page = page });
        }

        public IActionResult showPreviousPage(int page)
        {
            page--;
            return RedirectToAction("showItens", new { page = page });
        }

        public IActionResult searchItens(string query, int page)
        {
            if (query == null || query == "")
                return RedirectToAction("showPedidos");

            if (page <= 0)
                page = 1;

            var results = _repo.getItensWithQuery(query, page);

            ViewBag.page = page;
            ViewBag.query = query;

            return View(results);
        }

        public IActionResult searchNextPage(string query, int page)
        {
            page++;
            return RedirectToAction("searchItens", new { query = query, page = page });
        }

        public IActionResult searchPreviousPage(string query, int page)
        {
            page--;
            return RedirectToAction("searchItens", new { query = query, page = page });
        }

        public IActionResult addItem()
        {
            return View();
        }


        [HttpPost]
        public IActionResult addItem(Item i)
        {
            i.Codigo = _repo.getLastCodigoItem() + 1;

            _repo.Add(i);

            _repo.SaveChanges();

            return RedirectToAction("showItens");
        }
    }
}