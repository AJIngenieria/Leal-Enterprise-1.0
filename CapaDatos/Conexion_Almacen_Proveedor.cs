using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Almacen_Proveedor
    {
        //Llave primaria
        private int _Idproveedor;

        //Llaves Auxiliares
        private int _Iddatosdeenvio;
        private int _Iddatosfinancieros;

        //Datos Basicos
        private string _Tipo;
        private string _Nombre;
        private string _Documento;
        private string _Representante;
        private string _Pais;
        private string _Ciudad;
        private string _Nacionalidad;
        private string _Telefono;
        private string _Movil;
        private string _Correo;
        private DateTime _Fechadeinicio;

        //Datos de Envio
        private string _Pais_DE;
        private string _Ciudad_DE;
        private string _Direccion_P;
        private string _Direccion01;
        private string _Direccion02;
        private string _Receptor;
        private string _Observacion;

        //Datos Financieros
        private string _Retencion;
        private string _ValorRetencion;
        private string _Moneda;
        private string _BancoPrincipal;
        private string _BancoAuxiliar;
        private string _Cuenta01;
        private string _Cuenta02;
        private string _CreditoMin;
        private string _CreditoMax;
        private string _UltimoCredito;
        private string _Mora;
        private string _CreditoTotal;
        private string _Prorroga;

        //Datos Auxiliares
        private int _Auto;
        private int _Eliminar;
        private string _Filtro;

        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public int Iddatosdeenvio { get => _Iddatosdeenvio; set => _Iddatosdeenvio = value; }
        public int Iddatosfinancieros { get => _Iddatosfinancieros; set => _Iddatosfinancieros = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Representante { get => _Representante; set => _Representante = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Nacionalidad { get => _Nacionalidad; set => _Nacionalidad = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public DateTime Fechadeinicio { get => _Fechadeinicio; set => _Fechadeinicio = value; }
        public string Pais_DE { get => _Pais_DE; set => _Pais_DE = value; }
        public string Ciudad_DE { get => _Ciudad_DE; set => _Ciudad_DE = value; }
        public string Direccion_P { get => _Direccion_P; set => _Direccion_P = value; }
        public string Direccion01 { get => _Direccion01; set => _Direccion01 = value; }
        public string Direccion02 { get => _Direccion02; set => _Direccion02 = value; }
        public string Receptor { get => _Receptor; set => _Receptor = value; }
        public string Observacion { get => _Observacion; set => _Observacion = value; }
        public string Retencion { get => _Retencion; set => _Retencion = value; }
        public string Moneda { get => _Moneda; set => _Moneda = value; }
        public string BancoPrincipal { get => _BancoPrincipal; set => _BancoPrincipal = value; }
        public string BancoAuxiliar { get => _BancoAuxiliar; set => _BancoAuxiliar = value; }
        public string Cuenta01 { get => _Cuenta01; set => _Cuenta01 = value; }
        public string Cuenta02 { get => _Cuenta02; set => _Cuenta02 = value; }
        public string CreditoMin { get => _CreditoMin; set => _CreditoMin = value; }
        public string CreditoMax { get => _CreditoMax; set => _CreditoMax = value; }
        public string UltimoCredito { get => _UltimoCredito; set => _UltimoCredito = value; }
        public string Mora { get => _Mora; set => _Mora = value; }
        public string CreditoTotal { get => _CreditoTotal; set => _CreditoTotal = value; }
        public string Prorroga { get => _Prorroga; set => _Prorroga = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public int Eliminar { get => _Eliminar; set => _Eliminar = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string ValorRetencion { get => _ValorRetencion; set => _ValorRetencion = value; }

        public Conexion_Almacen_Proveedor()
        {

        }

        public Conexion_Almacen_Proveedor
            (

                //Llave primaria
                int idproveedor,

                //Llaves Auxiliares
                int iddatosdeenvio,
                int iddatosfinancieros,

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
                int auto, int eliminar, string filtro
            )
        {
            //Llave primaria
            this.Idproveedor = idproveedor;

            //Llaves Auxiliares
            this.Iddatosdeenvio = iddatosdeenvio;
            this.Iddatosfinancieros = iddatosfinancieros;

            //Datos Basicos
            this.Tipo = tipo;
            this.Nombre = nombre;
            this.Documento = documento;
            this.Representante = representante;
            this.Telefono = telefono;
            this.Movil = movil;
            this.Correo = correo;
            this.Pais = pais;
            this.Ciudad = ciudad;
            this.Nacionalidad = nacionalidad;
            this.Fechadeinicio = fechadeinicio;

            //Datos de Envio
            this.Pais_DE = pais_DE;
            this.Ciudad_DE = ciudad_DE;
            this.Direccion_P = direccion_P;
            this.Direccion01 = direccion01;
            this.Direccion02 = direccion02;
            this.Receptor = receptor;
            this.Observacion = observacion;

            //Datos Financieros
            this.Retencion = retencion;
            this.ValorRetencion = valorretencion;
            this.BancoPrincipal = bancoPrincipal;
            this.BancoAuxiliar = bancoauxiliar;
            this.Cuenta01 = cuenta01;
            this.Cuenta02 = cuenta02;
            this.CreditoMin = creditoMin;
            this.CreditoMax = creditoMax;
            this.UltimoCredito = ultimoCredito;
            this.Mora = mora;
            this.CreditoTotal = creditoTotal;

            //Datos Auxiliares
            this.Auto = auto;
            this.Eliminar = eliminar;
            this.Filtro = filtro;
        }

        //Metodo Insertar
        public string Guardar_DatosBasicos(Conexion_Almacen_Proveedor Proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Jalo la conexion de la base de datos 
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCon.Open();

                //Establecer la conexion para mandar a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Proveedor.LI_DatosBasicos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@IdProveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Proveedor.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 20;
                ParTipo.Value = Proveedor.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Proveedor.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 20;
                ParDocumento.Value = Proveedor.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParRepresentante = new SqlParameter();
                ParRepresentante.ParameterName = "@Representante";
                ParRepresentante.SqlDbType = SqlDbType.VarChar;
                ParRepresentante.Size = 50;
                ParRepresentante.Value = Proveedor.Representante;
                SqlCmd.Parameters.Add(ParRepresentante);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 20;
                ParMovil.Value = Proveedor.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 30;
                ParCorreo.Value = Proveedor.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = 20;
                ParPais.Value = Proveedor.Pais;
                SqlCmd.Parameters.Add(ParPais);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = Proveedor.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParFechadeinicio = new SqlParameter();
                ParFechadeinicio.ParameterName = "@Inicio";
                ParFechadeinicio.SqlDbType = SqlDbType.DateTime;
                ParFechadeinicio.Value = Proveedor.Fechadeinicio;
                SqlCmd.Parameters.Add(ParFechadeinicio);

                //Registro de Otros Datos - Formulario frmAlmacen_Proveedor

                SqlParameter ParIddatosdeenvio = new SqlParameter();
                ParIddatosdeenvio.ParameterName = "@Iddatosdeenvio";
                ParIddatosdeenvio.SqlDbType = SqlDbType.Int;
                ParIddatosdeenvio.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddatosdeenvio);

                SqlParameter ParPais_DE = new SqlParameter();
                ParPais_DE.ParameterName = "@Pais_DE";
                ParPais_DE.SqlDbType = SqlDbType.VarChar;
                ParPais_DE.Size = 20;
                ParPais_DE.Value = Proveedor.Pais_DE;
                SqlCmd.Parameters.Add(ParPais_DE);

                SqlParameter ParCiudad_DE = new SqlParameter();
                ParCiudad_DE.ParameterName = "@Ciudad_DE";
                ParCiudad_DE.SqlDbType = SqlDbType.VarChar;
                ParCiudad_DE.Size = 20;
                ParCiudad_DE.Value = Proveedor.Ciudad_DE;
                SqlCmd.Parameters.Add(ParCiudad_DE);

                SqlParameter ParDireccion_P = new SqlParameter();
                ParDireccion_P.ParameterName = "@Direccion_P";
                ParDireccion_P.SqlDbType = SqlDbType.VarChar;
                ParDireccion_P.Size = 50;
                ParDireccion_P.Value = Proveedor.Direccion_P;
                SqlCmd.Parameters.Add(ParDireccion_P);

                SqlParameter ParDireccion01 = new SqlParameter();
                ParDireccion01.ParameterName = "@Direccion01";
                ParDireccion01.SqlDbType = SqlDbType.VarChar;
                ParDireccion01.Size = 50;
                ParDireccion01.Value = Proveedor.Direccion01;
                SqlCmd.Parameters.Add(ParDireccion01);

                SqlParameter ParDireccion02 = new SqlParameter();
                ParDireccion02.ParameterName = "@Direccion02";
                ParDireccion02.SqlDbType = SqlDbType.VarChar;
                ParDireccion02.Size = 50;
                ParDireccion02.Value = Proveedor.Direccion02;
                SqlCmd.Parameters.Add(ParDireccion02);

                SqlParameter ParReceptor = new SqlParameter();
                ParReceptor.ParameterName = "@Receptor";
                ParReceptor.SqlDbType = SqlDbType.VarChar;
                ParReceptor.Size = 50;
                ParReceptor.Value = Proveedor.Receptor;
                SqlCmd.Parameters.Add(ParReceptor);

                SqlParameter ParObservacion = new SqlParameter();
                ParObservacion.ParameterName = "@Observacion";
                ParObservacion.SqlDbType = SqlDbType.VarChar;
                ParObservacion.Size = 100;
                ParObservacion.Value = Proveedor.Observacion;
                SqlCmd.Parameters.Add(ParObservacion);

                //Registro de Datos Financieros

                SqlParameter ParIddatosfinancieros = new SqlParameter();
                ParIddatosfinancieros.ParameterName = "@Iddatosfinanciero";
                ParIddatosfinancieros.SqlDbType = SqlDbType.Int;
                ParIddatosfinancieros.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddatosfinancieros);

                SqlParameter ParBanco01 = new SqlParameter();
                ParBanco01.ParameterName = "@Banco01";
                ParBanco01.SqlDbType = SqlDbType.VarChar;
                ParBanco01.Size = 20;
                ParBanco01.Value = Proveedor.BancoPrincipal;
                SqlCmd.Parameters.Add(ParBanco01);

                SqlParameter ParRetencion = new SqlParameter();
                ParRetencion.ParameterName = "@Retencion";
                ParRetencion.SqlDbType = SqlDbType.VarChar;
                ParRetencion.Size = 20;
                ParRetencion.Value = Proveedor.Retencion;
                SqlCmd.Parameters.Add(ParRetencion);

                SqlParameter ParValorRetencion = new SqlParameter();
                ParValorRetencion.ParameterName = "@ValorRetencion";
                ParValorRetencion.SqlDbType = SqlDbType.VarChar;
                ParValorRetencion.Size = 10;
                ParValorRetencion.Value = Proveedor.ValorRetencion;
                SqlCmd.Parameters.Add(ParValorRetencion);

                SqlParameter ParMoneda = new SqlParameter();
                ParMoneda.ParameterName = "@Moneda";
                ParMoneda.SqlDbType = SqlDbType.VarChar;
                ParMoneda.Size = 10;
                ParMoneda.Value = Proveedor.Moneda;
                SqlCmd.Parameters.Add(ParMoneda);

                SqlParameter ParBanco02 = new SqlParameter();
                ParBanco02.ParameterName = "@Banco02";
                ParBanco02.SqlDbType = SqlDbType.VarChar;
                ParBanco02.Size = 20;
                ParBanco02.Value = Proveedor.BancoAuxiliar;
                SqlCmd.Parameters.Add(ParBanco02);

                SqlParameter ParCuenta01 = new SqlParameter();
                ParCuenta01.ParameterName = "@Cuenta01";
                ParCuenta01.SqlDbType = SqlDbType.VarChar;
                ParCuenta01.Size = 20;
                ParCuenta01.Value = Proveedor.Cuenta01;
                SqlCmd.Parameters.Add(ParCuenta01);

                SqlParameter ParCuenta02 = new SqlParameter();
                ParCuenta02.ParameterName = "@Cuenta02";
                ParCuenta02.SqlDbType = SqlDbType.VarChar;
                ParCuenta02.Size = 20;
                ParCuenta02.Value = Proveedor.Cuenta02;
                SqlCmd.Parameters.Add(ParCuenta02);

                SqlParameter ParCreditoMin = new SqlParameter();
                ParCreditoMin.ParameterName = "@CreditoMin";
                ParCreditoMin.SqlDbType = SqlDbType.VarChar;
                ParCreditoMin.Size = 20;
                ParCreditoMin.Value = Proveedor.CreditoMin;
                SqlCmd.Parameters.Add(ParCreditoMin);

                SqlParameter ParCreditoMax = new SqlParameter();
                ParCreditoMax.ParameterName = "@CreditoMax";
                ParCreditoMax.SqlDbType = SqlDbType.VarChar;
                ParCreditoMax.Size = 20;
                ParCreditoMax.Value = Proveedor.CreditoMax;
                SqlCmd.Parameters.Add(ParCreditoMax);

                SqlParameter ParMora = new SqlParameter();
                ParMora.ParameterName = "@Mora";
                ParMora.SqlDbType = SqlDbType.VarChar;
                ParMora.Size = 20;
                ParMora.Value = Proveedor.Mora;
                SqlCmd.Parameters.Add(ParMora);

                SqlParameter ParCreditoTotal = new SqlParameter();
                ParCreditoTotal.ParameterName = "@CreditoTotal";
                ParCreditoTotal.SqlDbType = SqlDbType.VarChar;
                ParCreditoTotal.Size = 20;
                ParCreditoTotal.Value = Proveedor.CreditoTotal;
                SqlCmd.Parameters.Add(ParCreditoTotal);

                SqlParameter ParUltimoCredito = new SqlParameter();
                ParUltimoCredito.ParameterName = "@UltimoCredito";
                ParUltimoCredito.SqlDbType = SqlDbType.VarChar;
                ParUltimoCredito.Size = 20;
                ParUltimoCredito.Value = Proveedor.UltimoCredito;
                SqlCmd.Parameters.Add(ParUltimoCredito);

                SqlParameter ParProrroga = new SqlParameter();
                ParProrroga.ParameterName = "@Prorroga";
                ParProrroga.SqlDbType = SqlDbType.VarChar;
                ParProrroga.Size = 20;
                ParProrroga.Value = Proveedor.Prorroga;
                SqlCmd.Parameters.Add(ParProrroga);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() != 1 ? "OK" : "Error al Registrar";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public string Editar_DatosBasicos(Conexion_Almacen_Proveedor Proveedor)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Jalo la conexion de la base de datos 
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCon.Open();

                //Establecer la conexion para mandar a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Bodega.LI_Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@Idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Proveedor.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 20;
                ParTipo.Value = Proveedor.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Proveedor.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 20;
                ParDocumento.Value = Proveedor.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParRepresentante = new SqlParameter();
                ParRepresentante.ParameterName = "@Representante";
                ParRepresentante.SqlDbType = SqlDbType.VarChar;
                ParRepresentante.Size = 50;
                ParRepresentante.Value = Proveedor.Representante;
                SqlCmd.Parameters.Add(ParRepresentante);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Proveedor.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 20;
                ParMovil.Value = Proveedor.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 30;
                ParCorreo.Value = Proveedor.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = 20;
                ParPais.Value = Proveedor.Pais;
                SqlCmd.Parameters.Add(ParPais);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = Proveedor.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParFechadeinicio = new SqlParameter();
                ParFechadeinicio.ParameterName = "@Fechadeinicio";
                ParFechadeinicio.SqlDbType = SqlDbType.DateTime;
                ParFechadeinicio.Value = Proveedor.Fechadeinicio;
                SqlCmd.Parameters.Add(ParFechadeinicio);

                //Registro de Otros Datos - Formulario frmAlmacen_Proveedor

                SqlParameter ParIddatosdeenvio = new SqlParameter();
                ParIddatosdeenvio.ParameterName = "@Iddatosdeenvio";
                ParIddatosdeenvio.SqlDbType = SqlDbType.Int;
                ParIddatosdeenvio.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddatosdeenvio);

                SqlParameter ParPais_DE = new SqlParameter();
                ParPais_DE.ParameterName = "@Pais_DE";
                ParPais_DE.SqlDbType = SqlDbType.VarChar;
                ParPais_DE.Size = 20;
                ParPais_DE.Value = Proveedor.Pais_DE;
                SqlCmd.Parameters.Add(ParPais_DE);

                SqlParameter ParCiudad_DE = new SqlParameter();
                ParCiudad_DE.ParameterName = "@Ciudad_DE";
                ParCiudad_DE.SqlDbType = SqlDbType.VarChar;
                ParCiudad_DE.Size = 20;
                ParCiudad_DE.Value = Proveedor.Ciudad_DE;
                SqlCmd.Parameters.Add(ParCiudad_DE);

                SqlParameter ParDireccion_P = new SqlParameter();
                ParDireccion_P.ParameterName = "@Direccion_P";
                ParDireccion_P.SqlDbType = SqlDbType.VarChar;
                ParDireccion_P.Size = 50;
                ParDireccion_P.Value = Proveedor.Direccion_P;
                SqlCmd.Parameters.Add(ParDireccion_P);

                SqlParameter ParDireccion01 = new SqlParameter();
                ParDireccion01.ParameterName = "@Direccion01";
                ParDireccion01.SqlDbType = SqlDbType.VarChar;
                ParDireccion01.Size = 50;
                ParDireccion01.Value = Proveedor.Direccion01;
                SqlCmd.Parameters.Add(ParDireccion01);

                SqlParameter ParDireccion02 = new SqlParameter();
                ParDireccion02.ParameterName = "@Direccion02";
                ParDireccion02.SqlDbType = SqlDbType.VarChar;
                ParDireccion02.Size = 50;
                ParDireccion02.Value = Proveedor.Direccion02;
                SqlCmd.Parameters.Add(ParDireccion02);

                SqlParameter ParReceptor = new SqlParameter();
                ParReceptor.ParameterName = "@Receptor";
                ParReceptor.SqlDbType = SqlDbType.VarChar;
                ParReceptor.Size = 50;
                ParReceptor.Value = Proveedor.Receptor;
                SqlCmd.Parameters.Add(ParReceptor);

                SqlParameter ParObservacion = new SqlParameter();
                ParObservacion.ParameterName = "@Observacion";
                ParObservacion.SqlDbType = SqlDbType.VarChar;
                ParObservacion.Size = 100;
                ParObservacion.Value = Proveedor.Observacion;
                SqlCmd.Parameters.Add(ParObservacion);

                //Registro de Datos Financieros

                SqlParameter ParIddatosfinancieros = new SqlParameter();
                ParIddatosfinancieros.ParameterName = "@Iddatosfinanciero";
                ParIddatosfinancieros.SqlDbType = SqlDbType.Int;
                ParIddatosfinancieros.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddatosfinancieros);

                SqlParameter ParBanco01 = new SqlParameter();
                ParBanco01.ParameterName = "@Banco01";
                ParBanco01.SqlDbType = SqlDbType.VarChar;
                ParBanco01.Size = 20;
                ParBanco01.Value = Proveedor.BancoPrincipal;
                SqlCmd.Parameters.Add(ParBanco01);

                SqlParameter ParRetencion = new SqlParameter();
                ParRetencion.ParameterName = "@Retencion";
                ParRetencion.SqlDbType = SqlDbType.VarChar;
                ParRetencion.Size = 20;
                ParRetencion.Value = Proveedor.Retencion;
                SqlCmd.Parameters.Add(ParRetencion);

                SqlParameter ParValorRetencion = new SqlParameter();
                ParValorRetencion.ParameterName = "@ValorRetencion";
                ParValorRetencion.SqlDbType = SqlDbType.VarChar;
                ParValorRetencion.Size = 10;
                ParValorRetencion.Value = Proveedor.ValorRetencion;
                SqlCmd.Parameters.Add(ParValorRetencion);

                SqlParameter ParMoneda = new SqlParameter();
                ParMoneda.ParameterName = "@Moneda";
                ParMoneda.SqlDbType = SqlDbType.VarChar;
                ParMoneda.Size = 10;
                ParMoneda.Value = Proveedor.Moneda;
                SqlCmd.Parameters.Add(ParMoneda);

                SqlParameter ParBanco02 = new SqlParameter();
                ParBanco02.ParameterName = "@Banco02";
                ParBanco02.SqlDbType = SqlDbType.VarChar;
                ParBanco02.Size = 20;
                ParBanco02.Value = Proveedor.BancoAuxiliar;
                SqlCmd.Parameters.Add(ParBanco02);

                SqlParameter ParCuenta01 = new SqlParameter();
                ParCuenta01.ParameterName = "@Cuenta01";
                ParCuenta01.SqlDbType = SqlDbType.VarChar;
                ParCuenta01.Size = 20;
                ParCuenta01.Value = Proveedor.Cuenta01;
                SqlCmd.Parameters.Add(ParCuenta01);

                SqlParameter ParCuenta02 = new SqlParameter();
                ParCuenta02.ParameterName = "@Cuenta02";
                ParCuenta02.SqlDbType = SqlDbType.VarChar;
                ParCuenta02.Size = 20;
                ParCuenta02.Value = Proveedor.Cuenta02;
                SqlCmd.Parameters.Add(ParCuenta02);

                SqlParameter ParCreditoMin = new SqlParameter();
                ParCreditoMin.ParameterName = "@CreditoMin";
                ParCreditoMin.SqlDbType = SqlDbType.VarChar;
                ParCreditoMin.Size = 20;
                ParCreditoMin.Value = Proveedor.CreditoMin;
                SqlCmd.Parameters.Add(ParCreditoMin);

                SqlParameter ParCreditoMax = new SqlParameter();
                ParCreditoMax.ParameterName = "@CreditoMax";
                ParCreditoMax.SqlDbType = SqlDbType.VarChar;
                ParCreditoMax.Size = 20;
                ParCreditoMax.Value = Proveedor.CreditoMax;
                SqlCmd.Parameters.Add(ParCreditoMax);

                SqlParameter ParMora = new SqlParameter();
                ParMora.ParameterName = "@Mora";
                ParMora.SqlDbType = SqlDbType.VarChar;
                ParMora.Size = 20;
                ParMora.Value = Proveedor.Mora;
                SqlCmd.Parameters.Add(ParMora);

                SqlParameter ParCreditoTotal = new SqlParameter();
                ParCreditoTotal.ParameterName = "@CreditoTotal";
                ParCreditoTotal.SqlDbType = SqlDbType.VarChar;
                ParCreditoTotal.Size = 20;
                ParCreditoTotal.Value = Proveedor.CreditoTotal;
                SqlCmd.Parameters.Add(ParCreditoTotal);

                SqlParameter ParUltimoCredito = new SqlParameter();
                ParUltimoCredito.ParameterName = "@UltimoCredito";
                ParUltimoCredito.SqlDbType = SqlDbType.VarChar;
                ParUltimoCredito.Size = 20;
                ParUltimoCredito.Value = Proveedor.UltimoCredito;
                SqlCmd.Parameters.Add(ParUltimoCredito);

                SqlParameter ParProrroga = new SqlParameter();
                ParProrroga.ParameterName = "@Prorroga";
                ParProrroga.SqlDbType = SqlDbType.VarChar;
                ParProrroga.Size = 20;
                ParProrroga.Value = Proveedor.Prorroga;
                SqlCmd.Parameters.Add(ParProrroga);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() != 1 ? "OK" : "Error al Registrar";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public String Eliminar_DatosBasicos(Conexion_Almacen_Proveedor Proveedor)
        {

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Jalo la conexion de la base de datos 
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCon.Open();

                //Establecer la conexion para mandar a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Consulta.Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProveedor = new SqlParameter();
                ParIdProveedor.ParameterName = "@Idproveedor";
                ParIdProveedor.SqlDbType = SqlDbType.Int;
                ParIdProveedor.Value = Proveedor.Idproveedor;
                SqlCmd.Parameters.Add(ParIdProveedor);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Eliminar";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Proveedor.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al Eliminar el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        public DataTable Buscar_Proveedor(Conexion_Almacen_Proveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("Historico.Proveedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Consulta.Proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Proveedor.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Proveedor.Filtro;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
#pragma warning disable CS0168 // La variable está declarada pero nunca se usa
            catch (Exception ex)
#pragma warning restore CS0168 // La variable está declarada pero nunca se usa
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
