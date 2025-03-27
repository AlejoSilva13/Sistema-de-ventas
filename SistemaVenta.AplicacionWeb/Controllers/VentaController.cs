using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SistemaVenta.AplicacionWeb.Controllers
{
    public class VentaController : Controller
    {
        // GET: /<controller>/
        public IActionResult NuevaVenta()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult HistorialVenta()
        {
            return View();
        }
    }
}

