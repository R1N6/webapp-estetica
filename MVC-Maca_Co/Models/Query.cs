using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Maca_Co.Models
{
    public class Query
    {
        public static string INSERT_Estatus = "insert into Estatus(Estatus, Descripcion) values(@Estatus,@Descripcion)";
        public static string INSERT_Usuario = @"insert into 
            Usuario(Nombre, Apellido, Correo, Contrasena, Privilegios) 
            values (@Nombre, @Apellido, @Correo, @Contrasena, @Privilegios)";
        public static string LOGIN_Usuario = @"SELECT * FROM Usuario WHERE Correo = @correo AND Contrasena = @contra";
    }
}