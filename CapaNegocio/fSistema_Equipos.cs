using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Equipos
    {
        public static DataTable Seguridad_SQL(string equipo, string hdd, string macseguridad)
        {
            Conexion_Sistema_Equipos Obj = new Conexion_Sistema_Equipos();
            Obj.Equipo = equipo;
            Obj.HDD = hdd;
            Obj.Mac_Seguridad = macseguridad;
            return Obj.Seguridad_SQL(Obj);
        }


        public static string Guardar_DatosBasicos
            (
                //Datos Basicos
                string equipo, string hdd, string tipo,
                string mac_seguridad, int estado,

                //Metodos de Operacion
                int auto

            )
        {
            Conexion_Sistema_Equipos Obj = new Conexion_Sistema_Equipos();
           
            //Datos Basicos
            Obj.Equipo = equipo;
            Obj.HDD = hdd;
            Obj.Tipo = tipo;
            Obj.Mac_Seguridad = mac_seguridad;
            Obj.Estado = estado;

            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        //Metodo Editar
        public static string Editar_DatosBasicos
            (
                //Llaves Primarias
                int idequipo,

                //Datos Basicos
                string equipo, string hdd, string tipo,
                string mac_seguridad, int estado,

                //Metodos de Operacion
                int auto
            )
        {
            Conexion_Sistema_Equipos Obj = new Conexion_Sistema_Equipos();

            Obj.Idequipo = idequipo;
            Obj.Equipo = equipo;
            Obj.HDD = hdd;
            Obj.Tipo = tipo;
            Obj.Mac_Seguridad = mac_seguridad;
            Obj.Estado = estado;

            Obj.Auto = auto;

            return Obj.Editar_DatosBasicos(Obj);
        }

        public static string Eliminar_DatosBasicos(int idequipo)
        {
            Conexion_Sistema_Equipos Obj = new Conexion_Sistema_Equipos();
            Obj.Idequipo = idequipo;
            return Obj.Eliminar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Equipos(string filtro)
        {
            Conexion_Sistema_Equipos Obj = new Conexion_Sistema_Equipos();
            Obj.Filtro = filtro;
            return Obj.Buscar_Equipos(Obj);
        }
    }
}
