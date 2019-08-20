using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion_BaseDeDatos
    {
        //Conexion Principal de la Base de Datos
        public static string Conexion_SQL = Properties.Settings.Default.Conexion_SQL;

        //Conexion de Seguridad Para Las Bases de Datos
        public static string Seguridad_SQL = Properties.Settings.Default.Seguridad_SQL;
    }
}
