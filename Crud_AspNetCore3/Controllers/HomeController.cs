using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crud_AspNetCore3.ContextBD;
using Microsoft.EntityFrameworkCore;
using Crud_AspNetCore3.Models;

namespace Crud_AspNetCore3.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataBaseContext _contextBD;

        public HomeController(DataBaseContext dataBaseContext)
        {
            _contextBD = dataBaseContext;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _contextBD.Produtos.ToListAsync());
        }
        [HttpGet]
        public IActionResult CreateProduto()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduto(Produto produto)
        {
            if (ModelState.IsValid)
            {
                _contextBD.Add(produto);
                await _contextBD.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(produto);
            }
        }

        [HttpGet]
        public IActionResult UpdateProduto(int? id)
        {
            if (id != null)
            {
                Produto produto = _contextBD.Produtos.Find(id);
                return View(produto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduto(int? id, Produto produto)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contextBD.Update(produto);
                    await _contextBD.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View(produto);
                }

            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult DeleteProduto(int? id)
        {
            if (id != null)
            {
                Produto produto = _contextBD.Produtos.Find(id);
                return View(produto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduto(int? id, Produto produto)
        {
            if (id != null)
            {
                _contextBD.Remove(produto);
                await _contextBD.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(produto);
            }
        }

        public IActionResult Privacy()
        {
            return View("Privacy");
        }
    }
}
