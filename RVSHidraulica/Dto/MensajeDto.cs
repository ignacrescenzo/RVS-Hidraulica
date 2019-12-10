using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RVSHidraulica.Dto
{
    public class MensajeDto
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int TipoMensaje { get; set; }
        public string Mensaje { get; set; }
    }
}
