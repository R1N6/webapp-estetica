using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Maca_Co.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public string Nusuario { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public int Privilegios { get; set; }

    }
}