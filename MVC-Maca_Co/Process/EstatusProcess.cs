using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using MVC_Maca_Co.Models;
using System.Data.SqlClient;

namespace MVC_Maca_Co.Process
{
    public class EstatusProcess
    {
        public void CrearEstatus(Estatus estatus)
        {
            try
            {
                ///DateTime Fecha = Convert.ToDateTime(empleado.Fecha);

                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Estetica"].ConnectionString))
                {

                    string query = Query.INSERT_Estatus;
                    string Estatus = "Activo";
            
                    string Descripcion = "El usuario esta activo";
                 

                    var result = db.Execute(query, new { Estatus, Descripcion });
                    string Estatusss = "Activo";


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}