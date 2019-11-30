using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RVSHidraulica.Dto;
using RVSHidraulica.Helper;

namespace RVSHidraulica.Controllers
{
    public class ContactoController : Controller
    {
        private readonly IConfiguration _config;

        public ContactoController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            return View("Contacto");
        }

        [HttpPost]
        public JsonResult EnviarMensaje([FromBody] MensajeDto mensaje)
        {
            MailHelper.EnviarMail(mensaje.Nombre,mensaje.TipoMensaje,mensaje.Mensaje,mensaje.Email);
            return Json("");
        }
    }
}