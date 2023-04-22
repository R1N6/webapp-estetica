using Dapper;
using MVC_Maca_Co.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_Maca_Co.Process
{
    public class CorteProcess
    {
        public void CrearCorte(Corte c)
        {
            try
            {

                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Estetica"].ConnectionString))
                {

                    string query = Query.INSERT_CORTE;

                    var result = db.Execute(query, new { c.NombreMascota, c.Fecha, c.Servicio, c.Hora, c.FK_Cliente});


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}