using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fAlmacen_Proveedor
    {
        public static string Guardar_DatosBasicos
            (

                //Datos Basicos
                string tipo, string nombre, string documento, string representante, string pais,
                string ciudad, string nacionalidad, string telefono, string movil, string correo,
                DateTime fechadeinicio,

                //Datos de Envio
                string pais_DE, string ciudad_DE, string direccion_P, string direccion01,
                string direccion02, string receptor, string observacion,

                //Datos Financieros
                string retencion, string valorretencion, string bancoPrincipal, string bancoauxiliar, string cuenta01,
                string cuenta02, string creditoMin, string creditoMax, string ultimoCredito,
                string mora, string creditoTotal,

                //Datos Auxiliares
                int auto
            )
        {
            Conexion_Almacen_Proveedor Obj = new Conexion_Almacen_Proveedor();

            //Datos Basicos
            Obj.Tipo = tipo;
            Obj.Nombre = nombre;
            Obj.Documento = documento;
            Obj.Representante = representante;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Correo = correo;
            Obj.Pais = pais;
            Obj.Ciudad = ciudad;
            Obj.Nacionalidad = nacionalidad;
            Obj.Fechadeinicio = fechadeinicio;

            //Datos de Envio
            Obj.Pais_DE = pais_DE;
            Obj.Ciudad_DE = ciudad_DE;
            Obj.Direccion_P = direccion_P;
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;
            Obj.Receptor = receptor;
            Obj.Observacion = observacion;

            //Datos Financieros
            Obj.Retencion = retencion;
            Obj.ValorRetencion = valorretencion;
            Obj.BancoPrincipal = bancoPrincipal;
            Obj.BancoAuxiliar = bancoauxiliar;
            Obj.Cuenta01 = cuenta01;
            Obj.Cuenta02 = cuenta02;
            Obj.CreditoMin = creditoMin;
            Obj.CreditoMax = creditoMax;
            Obj.UltimoCredito = ultimoCredito;
            Obj.Mora = mora;
            Obj.CreditoTotal = creditoTotal;

            //Datos Auxiliares
            Obj.Auto = auto;

            return Obj.Guardar_DatosBasicos(Obj);
        }

        public static string Editar_DatosBasicos
            (
                //Llave primaria
                int idproveedor,

                //Datos Basicos
                string tipo, string nombre, string documento, string representante, string pais,
                string ciudad, string nacionalidad, string telefono, string movil, string correo,
                DateTime fechadeinicio,

                //Datos de Envio
                string pais_DE, string ciudad_DE, string direccion_P, string direccion01,
                string direccion02, string receptor, string observacion,

                //Datos Financieros
                string retencion, string valorretencion, string bancoPrincipal, string bancoauxiliar, string cuenta01,
                string cuenta02, string creditoMin, string creditoMax, string ultimoCredito,
                string mora, string creditoTotal,

                //Datos Auxiliares
                int auto
            )
        {
            Conexion_Almacen_Proveedor Obj = new Conexion_Almacen_Proveedor();

            //Llave primaria
            Obj.Idproveedor = idproveedor;

            //Datos Basicos
            Obj.Tipo = tipo;
            Obj.Nombre = nombre;
            Obj.Documento = documento;
            Obj.Representante = representante;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Correo = correo;
            Obj.Pais = pais;
            Obj.Ciudad = ciudad;
            Obj.Nacionalidad = nacionalidad;
            Obj.Fechadeinicio = fechadeinicio;

            //Datos de Envio
            Obj.Pais_DE = pais_DE;
            Obj.Ciudad_DE = ciudad_DE;
            Obj.Direccion_P = direccion_P;
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;
            Obj.Receptor = receptor;
            Obj.Observacion = observacion;

            //Datos Financieros
            Obj.Retencion = retencion;
            Obj.ValorRetencion = valorretencion;
            Obj.BancoPrincipal = bancoPrincipal;
            Obj.BancoAuxiliar = bancoauxiliar;
            Obj.Cuenta01 = cuenta01;
            Obj.Cuenta02 = cuenta02;
            Obj.CreditoMin = creditoMin;
            Obj.CreditoMax = creditoMax;
            Obj.UltimoCredito = ultimoCredito;
            Obj.Mora = mora;
            Obj.CreditoTotal = creditoTotal;

            //Datos Auxiliares
            Obj.Auto = auto;

            return Obj.Editar_DatosBasicos(Obj);
        }

        //Metodo eliminar

        public static string Eliminar_DatosBasicos(int auto, int idproveedor)
        {
            Conexion_Almacen_Proveedor Obj = new Conexion_Almacen_Proveedor();
            Obj.Auto = auto;
            Obj.Idproveedor = idproveedor;
            return Obj.Eliminar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Proveedor(int auto, string filtro)
        {
            Conexion_Almacen_Proveedor Obj = new Conexion_Almacen_Proveedor();
            Obj.Auto = auto;
            Obj.Filtro = filtro;
            return Obj.Buscar_Proveedor(Obj);
        }
    }
}
