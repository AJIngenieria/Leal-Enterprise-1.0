using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fAlmacen_Bodega
    {
        public static string Guardar_DatosBasicos
            (
                //Llaves Auxiliares
                int idsucurzal,

                //Datos Basicos
                string bodega, string tipo, string ciudad, string telefono,
                string movil, string responsable, string correo,

                //Otros Datos
                string direccion01, string direccion02, string mercancia,
                int numeroPC, int numeroimpresora, int numerocelulares,
                string observacion,

                //Datos Auxiliares
                int auto
            )
        {
            Conexion_Almacen_Bodega Obj = new Conexion_Almacen_Bodega();

            //Llaves Auxiliares
            Obj.Idsucurzal = idsucurzal;

            //Datos Basicos
            Obj.Bodega = bodega;
            Obj.Tipo = tipo;
            Obj.Ciudad = ciudad;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Responsable = responsable;
            Obj.Correo = correo;

            //Otros Datos
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;
            Obj.Mercancia = mercancia;
            Obj.NumeroPC = numeroPC;
            Obj.NumeroImpresora = numeroimpresora;
            Obj.NumeroCelulares = numerocelulares;
            Obj.Observacion = observacion;

            //Datos Auxiliares
            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                //Llave primaria
                int idbodega,

                //Llaves Auxiliares
                int idsucurzal,

                //Datos Basicos
                string bodega, string tipo, string ciudad, string telefono,
                string movil, string responsable, string correo,

                //Otros Datos
                string direccion01, string direccion02, string mercancia,
                int numeroPC, int numeroimpresora, int numerocelulares,
                string observacion,

                //Datos Auxiliares
                int auto
            )
        {
            Conexion_Almacen_Bodega Obj = new Conexion_Almacen_Bodega();

            //Llave primaria
            Obj.Idbodega = idbodega;

            //Llaves Auxiliares
            Obj.Idsucurzal = idsucurzal;

            //Datos Basicos
            Obj.Bodega = bodega;
            Obj.Tipo = tipo;
            Obj.Ciudad = ciudad;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Responsable = responsable;
            Obj.Correo = correo;

            //Otros Datos
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;
            Obj.Mercancia = mercancia;
            Obj.NumeroPC = numeroPC;
            Obj.NumeroImpresora = numeroimpresora;
            Obj.NumeroCelulares = numerocelulares;
            Obj.Observacion = observacion;

            //Datos Auxiliares
            Obj.Auto = auto;

            return Obj.Editar_DatosBasicos(Obj);
        }

        //Metodo eliminar

        public static string Eliminar_DatosBasicos(int auto, int idbodega)
        {
            Conexion_Almacen_Bodega Obj = new Conexion_Almacen_Bodega();
            Obj.Auto = auto;
            Obj.Idbodega = idbodega;
            return Obj.Eliminar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Bodega(int auto, string filtro)
        {
            Conexion_Almacen_Bodega Obj = new Conexion_Almacen_Bodega();
            Obj.Auto = auto;
            Obj.Filtro = filtro;
            return Obj.Buscar_Bodega(Obj);
        }
    }
}
