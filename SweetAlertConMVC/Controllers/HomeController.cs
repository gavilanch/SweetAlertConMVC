using Microsoft.AspNetCore.Mvc;
using SweetAlertConMVC.Models;
using System.Diagnostics;

namespace SweetAlertConMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Nombre)
        {
            return RedirectToAction("Completado", new { Nombre });
        }

        public IActionResult Completado(string Nombre)
        {
            return View("Completado", Nombre);
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