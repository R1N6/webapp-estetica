using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Maca_Co.Models
{
    public class Trabajador
    {
        public int ID { set; get; }
        public string Nombre {set; get; }
        public string Rol { get; set; }
        public int IDUsiario { get; set; }

    }
}