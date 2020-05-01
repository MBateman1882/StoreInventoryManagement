using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreInventoryManagement.Models;

namespace StoreInventoryManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        StoreInventoryManagementContext db = new StoreInventoryManagementContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Residual()
        {
            return View();
        }

        public IActionResult LowEmpty()
        {
            return View();
        }

        public IActionResult Markdown()
        {
            return View();
        }

        public IActionResult Remove()
        {
            return View();
        }

        public IActionResult ItemInfo()
        {
            return View(db);
        }

        public IActionResult OrderMenu()
        {
            return View();
        }

        public IActionResult NewOrder()
        {
            return View();
        }

        public IActionResult EditOrder()
        {
            return View();
        }

        public IActionResult OrderHistory()
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
    }
}
