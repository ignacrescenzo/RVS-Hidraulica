using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RVSHidraulica.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult BombasYMotores()
        {
            return View();
        }

        public IActionResult ManguerasYAccesorios()
        {
            return View();
        }

        public IActionResult Cilindros()
        {
            return View();
        }

        public IActionResult Valvulas()
        {
            return View();
        }
    }
}