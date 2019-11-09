using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Sucurzal
    {
        public static string Guardar_DatosBasicos
            (
                //Datos Basicos
                string codigo, string sucurzal, string ciudad, string ubicacion, string direccion,

                //Datos Auxiliares
                int auto
            )
        {
            Conexion_Sistema_Sucurzal Obj = new Conexion_Sistema_Sucurzal();

            //Datos Basicos
            Obj.Codigo = codigo;
            Obj.Sucurzal = sucurzal;
            Obj.Ciudad = ciudad;
            Obj.Ubicacion = ubicacion;
            Obj.Direccion = direccion;

            //Datos Auxiliares
            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                //Llave primaria
                int idsucurzal,

                //Datos Basicos
                string codigo, string sucurzal, string ciudad, string ubicacion, string direccion,

                //Datos Auxiliares
                int auto
            )
        {
            Conexion_Sistema_Sucurzal Obj = new Conexion_Sistema_Sucurzal();

            //Llave primaria
            Obj.Idsucurzal = idsucurzal;

            //Datos Basicos
            Obj.Codigo = codigo;
            Obj.Sucurzal = sucurzal;
            Obj.Ciudad = ciudad;
            Obj.Ubicacion = ubicacion;
            Obj.Direccion = direccion;

            //Datos Auxiliares
            Obj.Auto = auto;

            return Obj.Editar_DatosBasicos(Obj);
        }

        //Metodo eliminar

        public static string Eliminar_DatosBasicos(int idsucurzal)
        {
            Conexion_Sistema_Sucurzal Obj = new Conexion_Sistema_Sucurzal();
            Obj.Idsucurzal = idsucurzal;
            return Obj.Eliminar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Sucurzal(int auto, string filtro)
        {
            Conexion_Sistema_Sucurzal Obj = new Conexion_Sistema_Sucurzal();
            Obj.Auto = auto;
            Obj.Filtro = filtro;
            return Obj.Buscar_Sucurzal(Obj);
        }


        public static DataTable Mostrar()
        {
            return new Conexion_Sistema_Sucurzal().Mostrar();
        }
    }
}
