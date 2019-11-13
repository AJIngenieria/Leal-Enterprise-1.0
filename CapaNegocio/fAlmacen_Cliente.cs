using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class fAlmacen_Cliente
    {
        public static string Guardar_DatosBasicos
            (

                //Datos Basicos
                string nombre, string documento, string telefono, string movil,
                string correo, string pais, string ciudad, string departamento,

                //Datos de Envio
                string pais_DE, string ciudad_DE, string direccion_P, string direccion01,
                string direccion02, string receptor, string descripcion,

                //Datos Financieros
                string bancoPrincipal, string bancoauxiliar, string cuenta01,
                string cuenta02, string creditoMin, string creditoMax, string ultimoCredito,
                string mora, string creditoTotal,

                //Datos Auxiliares
                int auto
            )
        {
            Conexion_Almacen_Clientes Obj = new Conexion_Almacen_Clientes();

            //Datos Basicos
            Obj.Nombre = nombre;
            Obj.Documento = documento;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Correo = correo;
            Obj.Pais = pais;
            Obj.Ciudad = ciudad;
            Obj.Departamento = departamento;

            //Datos de Envio
            Obj.Pais_DE = pais_DE;
            Obj.Ciudad_DE = ciudad_DE;
            Obj.Direccion_P = direccion_P;
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;
            Obj.Receptor = receptor;
            Obj.Descripcion = descripcion;

            //Datos Financieros
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
                int idcliente,

                //Datos Basicos
                string nombre, string documento, string telefono, string movil,
                string correo, string pais, string ciudad, string departamento,

                //Datos de Envio
                string pais_DE, string ciudad_DE, string direccion_P, string direccion01,
                string direccion02, string receptor, string descripcion,

                //Datos Financieros
                string bancoPrincipal, string banco02, string cuenta01,
                string cuenta02, string creditoMin, string creditoMax, string ultimoCredito,
                string mora, string creditoTotal,

                //Datos Auxiliares
                int auto
            )
        {
            Conexion_Almacen_Clientes Obj = new Conexion_Almacen_Clientes();

            //Llave primaria
            Obj.Idcliente = idcliente;

            //Datos Basicos
            Obj.Nombre = nombre;
            Obj.Documento = documento;
            Obj.Telefono = telefono;
            Obj.Movil = movil;
            Obj.Correo = correo;
            Obj.Pais = pais;
            Obj.Ciudad = ciudad;
            Obj.Departamento = departamento;
            
            //Datos de Envio
            Obj.Pais_DE = pais_DE;
            Obj.Ciudad_DE = ciudad_DE;
            Obj.Direccion_P = direccion_P;
            Obj.Direccion01 = direccion01;
            Obj.Direccion02 = direccion02;
            Obj.Receptor = receptor;
            Obj.Descripcion = descripcion;

            //Datos Financieros
            Obj.BancoPrincipal = bancoPrincipal;
            Obj.BancoAuxiliar = banco02;
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

        public static string Eliminar_DatosBasicos(int auto, int idcliente)
        {
            Conexion_Almacen_Clientes Obj = new Conexion_Almacen_Clientes();
            Obj.Auto = auto;
            Obj.Idcliente = idcliente;
            return Obj.Eliminar_DatosBasicos(Obj);
        }

        public static DataTable Buscar_Cliente(int auto, string filtro)
        {
            Conexion_Almacen_Clientes Obj = new Conexion_Almacen_Clientes();
            Obj.Auto = auto;
            Obj.Filtro = filtro;
            return Obj.Buscar_Cliente(Obj);
        }
    }
}
