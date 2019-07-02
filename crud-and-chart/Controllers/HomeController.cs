using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crud_and_chart.Models;

namespace crud_and_chart.Controllers
{
    public class HomeController : Controller
    {
        public static List<Item> _items = new List<Item>();
        public HomeController()
        {
            if (_items.Count == 0)
            {
                SeedItems();
            }
        }



        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult AddItem(Item item)
        {
            _items.Add(item);
            return base.RedirectToAction("Index");
        }

        public static List<Item> GetItemsInMemory() => _items;
 
        // Sembramos los items en memoria
        private void SeedItems()
        {
            _items = new List<Item>()
            {
                new Item { Nombre = "Pizza", Categoria = "Comida", Valor = 180 },
                new Item { Nombre = "Torta", Categoria = "Comida", Valor = 150 },
                new Item { Nombre = "Compras", Categoria = "Hogar", Valor = 3000 },
                new Item { Nombre = "Pantalón", Categoria = "Ropa", Valor = 1500 },
                new Item { Nombre = "Zapatos", Categoria = "Ropa", Valor = 2800 }
            };
        }
    }
}