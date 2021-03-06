using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Factura.Models;

namespace Factura.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Factura()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Productos()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Clientes()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EditarCliente()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult EliminarCliente()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ListarProducto()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
