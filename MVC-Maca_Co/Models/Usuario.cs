using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Maca_Co.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string Privilegios { get; set; }

    }
}