using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Maca_Co.Models
{
    public class Corte
    {
        public int Id { get; set; }
        public int Id_Trabajador { get; set; }
        public int Id_Status { get; set; }
        public string NombreMascota { get; set; }
        public string Servicio { get; set; }
        public DateTime FechaCorte { get; set; }
    }
}