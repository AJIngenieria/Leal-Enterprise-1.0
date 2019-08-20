using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Usuarios
    {
        public static DataTable Login(string usuario, string contraseña)
        {
            Conexion_Sistema_Usuarios Obj = new Conexion_Sistema_Usuarios();
            Obj.Usuario = usuario;
            Obj.Contraseña = contraseña;
            return Obj.Login(Obj);
        }

        public static string Guardar_DatosBasicos
            (
                //Llaves Primarias
                int idempelado,

                //Datos Basicos
                string empleado, string usuario, string contraseña, string descripcion,

                //Niveles
                string almacen, string gestionhumana, string productos,
                string remision, string reporte, string ventas, string sistema,

                //Permisos
                string guardar, string eliminar, string editar, string consultar,

                //Filtros y Metodo
                int estado, int auto
            )
        {
            Conexion_Sistema_Usuarios Obj = new Conexion_Sistema_Usuarios();

            //Llaves Primarias
            Obj.Idempleado = idempelado;

            //Datos Basicos
            Obj.Empleado = empleado;
            Obj.Usuario = usuario;
            Obj.Contraseña = contraseña;
            Obj.Descripcion = descripcion;

            //Niveles
            Obj.Almacen = almacen;
            Obj.GestionHumana = gestionhumana;
            Obj.Productos = productos;
            Obj.Remision = remision;
            Obj.Reportes = reporte;
            Obj.Ventas = ventas;
            Obj.Sistema = sistema;

            //Permisos
            Obj.Guardar = guardar;
            Obj.Eliminar = eliminar;
            Obj.Editar = editar;
            Obj.Consultar = consultar;

            //Metodos y Filtros

            Obj.Auto = auto;
            Obj.Estado = estado;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                //Llaves Primarias
                int idusuario, int idempelado,

                //Datos Basicos
                string empleado, string usuario, string contraseña, string descripcion,

                //Niveles
                string almacen, string gestionhumana, string productos,
                string remision, string reporte, string ventas, string sistema,

                //Permisos
                string guardar, string eliminar, string editar, string consultar,

                //Filtros y Metodo
                int estado, int auto
            )
        {
            Conexion_Sistema_Usuarios Obj = new Conexion_Sistema_Usuarios();

            //Llaves Primarias
            Obj.Idempleado = idempelado;
            Obj.Idusuario = idusuario;

            //Datos Basicos
            Obj.Empleado = empleado;
            Obj.Usuario = usuario;
            Obj.Contraseña = contraseña;
            Obj.Descripcion = descripcion;

            //Niveles
            Obj.Almacen = almacen;
            Obj.GestionHumana = gestionhumana;
            Obj.Productos = productos;
            Obj.Remision = remision;
            Obj.Reportes = reporte;
            Obj.Ventas = ventas;
            Obj.Sistema = sistema;

            //Permisos
            Obj.Guardar = guardar;
            Obj.Eliminar = eliminar;
            Obj.Editar = editar;
            Obj.Consultar = consultar;

            //Metodos y Filtros

            Obj.Auto = auto;
            Obj.Estado = estado;

            return Obj.Editar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Usuario(string filtro)
        {
            Conexion_Sistema_Usuarios Obj = new Conexion_Sistema_Usuarios();
            Obj.Filtro = filtro;
            return Obj.Buscar_Usuario(Obj);
        }
    }
}
