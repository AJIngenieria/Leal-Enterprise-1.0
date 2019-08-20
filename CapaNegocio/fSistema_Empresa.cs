using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fSistema_Empresa
    {
        public static string Guardar_DatosBasicos
            (
                //Datos Basicos
                string empresa, string eslogan, string documento,
                string dirreccion, string movil, string telefono, string correo,

                //Metodos de Operacion
                int auto

            )
        {
            Conexion_Sistema_Empresa Obj = new Conexion_Sistema_Empresa();
            Obj.Empresa = empresa;
            Obj.Eslogan = eslogan;
            Obj.Documento = documento;
            Obj.Direccion = dirreccion;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Correo = correo;

            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        //Metodo Editar
        public static string Editar_DatosBasicos
            (
                //Llaves Primarias
                int idempresa,

                string empresa, string eslogan, string documento,
                string dirreccion, string movil, string telefono, string correo,

                //Metodos de Operacion
                int auto
            )
        {
            Conexion_Sistema_Empresa Obj = new Conexion_Sistema_Empresa();

            Obj.Idempresa = idempresa;
            Obj.Empresa = empresa;
            Obj.Eslogan = eslogan;
            Obj.Documento = documento;
            Obj.Direccion = dirreccion;
            Obj.Movil = movil;
            Obj.Telefono = telefono;
            Obj.Correo = correo;

            Obj.Auto = auto;

            return Obj.Editar_DatosBasicos(Obj);
        }

        public static string Eliminar_DatosBasicos(int idempresa)
        {
            Conexion_Sistema_Empresa Obj = new Conexion_Sistema_Empresa();
            Obj.Idempresa = idempresa;
            return Obj.Eliminar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Empleado(string filtro)
        {
            Conexion_Sistema_Empresa Obj = new Conexion_Sistema_Empresa();
            Obj.Filtro = filtro;
            return Obj.Buscar_Empleado(Obj);
        }
    }
}
