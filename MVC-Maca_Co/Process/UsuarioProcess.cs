﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using MVC_Maca_Co.Models;
using System.Data.SqlClient;

namespace MVC_Maca_Co.Process
{
    public class UsuarioProcess
    {
        public void CrearUsuario(Usuario usuario)
        {
            try
            {
                usuario.Contrasena = Base64Manager.Base64Encode(usuario.Contrasena); 

                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Estetica"].ConnectionString))
                {

                    string query = Query.INSERT_Usuario;

                    var result = db.Execute(query, new { usuario.Nombre, usuario.Apellido, usuario.Correo, usuario.Contrasena, usuario.Privilegios});

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Usuario RecuperarUsuario(string correo, string contra)
        {
            try
            {
                contra = Base64Manager.Base64Encode(contra);
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Estetica"].ConnectionString))
                {

                    string query = Query.LOGIN_Usuario;


                    Usuario result = (Usuario)db.QueryFirst<Usuario>(query, new {correo, contra});
                    return result;

                }
            }
            catch (Exception ex) {
                throw ex; 
            }
        }

    }
}