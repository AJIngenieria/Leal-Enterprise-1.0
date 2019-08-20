using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fGestionHumana_Empleados
    {
        public static string Guardar_DatosBasicos
            (
                //Datos Basicos
                string empleado, string documento, string telefono, string movil, string email, string direccion,

                //Metodos de Operacion
                int auto

            )
        {
            Conexion_GestionHumana_Empleados Obj = new Conexion_GestionHumana_Empleados();
            Obj.Empleado = empleado;
            Obj.Documento = documento;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Direccion = direccion;

            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        //Metodo Editar
        public static string Editar_DatosBasicos
            (
                //Llaves Primarias
                int idempleado,

                //Datos Basicos
                string empleado, string documento, string telefono, string movil, string email, string direccion,
                
                //Metodos de Operacion
                int auto
            )
        {
            Conexion_GestionHumana_Empleados Obj = new Conexion_GestionHumana_Empleados();

            Obj.Idempleado = idempleado;
            Obj.Empleado = empleado;
            Obj.Documento = documento;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Direccion = direccion;

            Obj.Auto = auto;

            return Obj.Editar_DatosBasicos(Obj);
        }

        public static string Eliminar_DatosBasicos(int idempleado)
        {
            Conexion_GestionHumana_Empleados Obj = new Conexion_GestionHumana_Empleados();
            Obj.Idempleado = idempleado;
            return Obj.Eliminar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Empleado(string filtro)
        {
            Conexion_GestionHumana_Empleados Obj = new Conexion_GestionHumana_Empleados();
            Obj.Filtro = filtro;
            return Obj.Buscar_Empleado(Obj);
        }
    }
}
