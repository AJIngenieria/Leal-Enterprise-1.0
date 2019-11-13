using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Almacen_Clientes
    {
        //Llave primaria
        private int _Idcliente;

        //Llaves Auxiliares
        private int _Iddatosdeenvio;
        private int _Iddatosfinancieros;

        //Datos Basicos
        private string _Nombre;
        private string _Documento;
        private string _Telefono;
        private string _Movil;
        private string _Correo;
        private string _Pais;
        private string _Ciudad;
        private string _Departamento;

        //Datos de Envio
        private string _Pais_DE;
        private string _Ciudad_DE;
        private string _Direccion_P;
        private string _Direccion01;
        private string _Direccion02;
        private string _Receptor;
        private string _Descripcion;

        //Datos Financieros
        private string _BancoPrincipal;
        private string _BancoAuxiliar;
        private string _Cuenta01;
        private string _Cuenta02;
        private string _CreditoMin;
        private string _CreditoMax;
        private string _UltimoCredito;
        private string _Mora;
        private string _CreditoTotal;

        //Datos Auxiliares
        private int _Auto;
        private int _Eliminar;
        private string _Filtro;

        public int Idcliente { get => _Idcliente; set => _Idcliente = value; }
        public int Iddatosdeenvio { get => _Iddatosdeenvio; set => _Iddatosdeenvio = value; }
        public int Iddatosfinancieros { get => _Iddatosfinancieros; set => _Iddatosfinancieros = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Pais { get => _Pais; set => _Pais = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Departamento { get => _Departamento; set => _Departamento = value; }
        public string Pais_DE { get => _Pais_DE; set => _Pais_DE = value; }
        public string Ciudad_DE { get => _Ciudad_DE; set => _Ciudad_DE = value; }
        public string Direccion_P { get => _Direccion_P; set => _Direccion_P = value; }
        public string Direccion01 { get => _Direccion01; set => _Direccion01 = value; }
        public string Direccion02 { get => _Direccion02; set => _Direccion02 = value; }
        public string Receptor { get => _Receptor; set => _Receptor = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string BancoPrincipal { get => _BancoPrincipal; set => _BancoPrincipal = value; }
        public string BancoAuxiliar { get => _BancoAuxiliar; set => _BancoAuxiliar = value; }
        public string Cuenta01 { get => _Cuenta01; set => _Cuenta01 = value; }
        public string Cuenta02 { get => _Cuenta02; set => _Cuenta02 = value; }
        public string CreditoMin { get => _CreditoMin; set => _CreditoMin = value; }
        public string CreditoMax { get => _CreditoMax; set => _CreditoMax = value; }
        public string UltimoCredito { get => _UltimoCredito; set => _UltimoCredito = value; }
        public string Mora { get => _Mora; set => _Mora = value; }
        public string CreditoTotal { get => _CreditoTotal; set => _CreditoTotal = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public int Eliminar { get => _Eliminar; set => _Eliminar = value; }

        public Conexion_Almacen_Clientes()
        {

        }

        public Conexion_Almacen_Clientes
            (

                //Llave primaria
                int idcliente,

                //Llaves Auxiliares
                int iddatosdeenvio,
                int iddatosfinancieros,

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
                int auto, int eliminar, string filtro
            )
        {
            //Llave primaria
            this.Idcliente = idcliente;

            //Llaves Auxiliares
            this.Iddatosdeenvio = iddatosdeenvio;
            this.Iddatosfinancieros = iddatosfinancieros;

            //Datos Basicos
            this.Nombre = nombre;
            this.Documento = documento;
            this.Telefono = telefono;
            this.Movil = movil;
            this.Correo = correo;
            this.Pais = pais;
            this.Ciudad = ciudad;
            this.Departamento = departamento;

            //Datos de Envio
            this.Pais_DE = pais_DE;
            this.Ciudad_DE = ciudad_DE;
            this.Direccion_P = direccion_P;
            this.Direccion01 = direccion01;
            this.Direccion02 = direccion02;
            this.Receptor = receptor;
            this.Descripcion = descripcion;

            //Datos Financieros
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
        public string Guardar_DatosBasicos(Conexion_Almacen_Clientes Cliente)
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
                SqlCmd.CommandText = "Cliente.LI_DatosBasicos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@Idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Cliente.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 20;
                ParDocumento.Value = Cliente.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 20;
                ParMovil.Value = Cliente.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 30;
                ParCorreo.Value = Cliente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = 20;
                ParPais.Value = Cliente.Pais;
                SqlCmd.Parameters.Add(ParPais);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = Cliente.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParDepartamento = new SqlParameter();
                ParDepartamento.ParameterName = "@Departamento";
                ParDepartamento.SqlDbType = SqlDbType.VarChar;
                ParDepartamento.Size = 20;
                ParDepartamento.Value = Cliente.Departamento;
                SqlCmd.Parameters.Add(ParDepartamento);

                //Registro de Otros Datos - Formulario frmAlmacen_Cliente

                SqlParameter ParIddatosdeenvio = new SqlParameter();
                ParIddatosdeenvio.ParameterName = "@Iddatosdeenvio";
                ParIddatosdeenvio.SqlDbType = SqlDbType.Int;
                ParIddatosdeenvio.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddatosdeenvio);

                SqlParameter ParPais_DE = new SqlParameter();
                ParPais_DE.ParameterName = "@Pais_DE";
                ParPais_DE.SqlDbType = SqlDbType.VarChar;
                ParPais_DE.Size = 20;
                ParPais_DE.Value = Cliente.Pais_DE;
                SqlCmd.Parameters.Add(ParPais_DE);

                SqlParameter ParCiudad_DE = new SqlParameter();
                ParCiudad_DE.ParameterName = "@Ciudad_DE";
                ParCiudad_DE.SqlDbType = SqlDbType.VarChar;
                ParCiudad_DE.Size = 20;
                ParCiudad_DE.Value = Cliente.Ciudad_DE;
                SqlCmd.Parameters.Add(ParCiudad_DE);

                SqlParameter ParDireccion_P = new SqlParameter();
                ParDireccion_P.ParameterName = "@Direccion_P";
                ParDireccion_P.SqlDbType = SqlDbType.VarChar;
                ParDireccion_P.Size = 50;
                ParDireccion_P.Value = Cliente.Direccion_P;
                SqlCmd.Parameters.Add(ParDireccion_P);

                SqlParameter ParDireccion01 = new SqlParameter();
                ParDireccion01.ParameterName = "@Direccion01";
                ParDireccion01.SqlDbType = SqlDbType.VarChar;
                ParDireccion01.Size = 50;
                ParDireccion01.Value = Cliente.Direccion01;
                SqlCmd.Parameters.Add(ParDireccion01);

                SqlParameter ParDireccion02 = new SqlParameter();
                ParDireccion02.ParameterName = "@Direccion02";
                ParDireccion02.SqlDbType = SqlDbType.VarChar;
                ParDireccion02.Size = 50;
                ParDireccion02.Value = Cliente.Direccion02;
                SqlCmd.Parameters.Add(ParDireccion02);

                SqlParameter ParReceptor = new SqlParameter();
                ParReceptor.ParameterName = "@Receptor";
                ParReceptor.SqlDbType = SqlDbType.VarChar;
                ParReceptor.Size = 50;
                ParReceptor.Value = Cliente.Receptor;
                SqlCmd.Parameters.Add(ParReceptor);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 100;
                ParDescripcion.Value = Cliente.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Registro de Otros Datos - Formulario frmAlmacen_Cliente

                SqlParameter ParIddatosfinancieros = new SqlParameter();
                ParIddatosfinancieros.ParameterName = "@Iddatosfinanciero";
                ParIddatosfinancieros.SqlDbType = SqlDbType.Int;
                ParIddatosfinancieros.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddatosfinancieros);

                SqlParameter ParBanco01 = new SqlParameter();
                ParBanco01.ParameterName = "@Banco01";
                ParBanco01.SqlDbType = SqlDbType.VarChar;
                ParBanco01.Size = 20;
                ParBanco01.Value = Cliente.BancoPrincipal;
                SqlCmd.Parameters.Add(ParBanco01);

                SqlParameter ParBanco02 = new SqlParameter();
                ParBanco02.ParameterName = "@Banco02";
                ParBanco02.SqlDbType = SqlDbType.VarChar;
                ParBanco02.Size = 20;
                ParBanco02.Value = Cliente.BancoAuxiliar;
                SqlCmd.Parameters.Add(ParBanco02);

                SqlParameter ParCuenta01 = new SqlParameter();
                ParCuenta01.ParameterName = "@Cuenta01";
                ParCuenta01.SqlDbType = SqlDbType.VarChar;
                ParCuenta01.Size = 20;
                ParCuenta01.Value = Cliente.Cuenta01;
                SqlCmd.Parameters.Add(ParCuenta01);

                SqlParameter ParCuenta02 = new SqlParameter();
                ParCuenta02.ParameterName = "@Cuenta02";
                ParCuenta02.SqlDbType = SqlDbType.VarChar;
                ParCuenta02.Size = 20;
                ParCuenta02.Value = Cliente.Cuenta02;
                SqlCmd.Parameters.Add(ParCuenta02);

                SqlParameter ParCreditoMin = new SqlParameter();
                ParCreditoMin.ParameterName = "@CreditoMin";
                ParCreditoMin.SqlDbType = SqlDbType.VarChar;
                ParCreditoMin.Size = 20;
                ParCreditoMin.Value = Cliente.CreditoMin;
                SqlCmd.Parameters.Add(ParCreditoMin);

                SqlParameter ParCreditoMax = new SqlParameter();
                ParCreditoMax.ParameterName = "@CreditoMax";
                ParCreditoMax.SqlDbType = SqlDbType.VarChar;
                ParCreditoMax.Size = 20;
                ParCreditoMax.Value = Cliente.CreditoMax;
                SqlCmd.Parameters.Add(ParCreditoMax);

                SqlParameter ParMora = new SqlParameter();
                ParMora.ParameterName = "@Mora";
                ParMora.SqlDbType = SqlDbType.VarChar;
                ParMora.Size = 20;
                ParMora.Value = Cliente.Mora;
                SqlCmd.Parameters.Add(ParMora);

                SqlParameter ParCreditoTotal = new SqlParameter();
                ParCreditoTotal.ParameterName = "@CreditoTotal";
                ParCreditoTotal.SqlDbType = SqlDbType.VarChar;
                ParCreditoTotal.Size = 20;
                ParCreditoTotal.Value = Cliente.CreditoTotal;
                SqlCmd.Parameters.Add(ParCreditoTotal);

                SqlParameter ParUltimoCredito = new SqlParameter();
                ParUltimoCredito.ParameterName = "@UltimoCredito";
                ParUltimoCredito.SqlDbType = SqlDbType.VarChar;
                ParUltimoCredito.Size = 20;
                ParUltimoCredito.Value = Cliente.UltimoCredito;
                SqlCmd.Parameters.Add(ParUltimoCredito);

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

        public string Editar_DatosBasicos(Conexion_Almacen_Clientes Cliente)
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
                SqlCmd.CommandText = "Bodega.LI_Bodega";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@Idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Cliente.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Cliente.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@Nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 20;
                ParDocumento.Value = Cliente.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 20;
                ParTelefono.Value = Cliente.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 20;
                ParMovil.Value = Cliente.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 30;
                ParCorreo.Value = Cliente.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParPais = new SqlParameter();
                ParPais.ParameterName = "@Pais";
                ParPais.SqlDbType = SqlDbType.VarChar;
                ParPais.Size = 20;
                ParPais.Value = Cliente.Pais;
                SqlCmd.Parameters.Add(ParPais);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = Cliente.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParDepartamento = new SqlParameter();
                ParDepartamento.ParameterName = "@Departamento";
                ParDepartamento.SqlDbType = SqlDbType.VarChar;
                ParDepartamento.Size = 20;
                ParDepartamento.Value = Cliente.Departamento;
                SqlCmd.Parameters.Add(ParDepartamento);

                //Registro de Otros Datos - Formulario frmAlmacen_Cliente

                SqlParameter ParIddatosdeenvio = new SqlParameter();
                ParIddatosdeenvio.ParameterName = "@Iddatosdeenvio";
                ParIddatosdeenvio.SqlDbType = SqlDbType.Int;
                ParIddatosdeenvio.Value = Cliente.Iddatosdeenvio;
                SqlCmd.Parameters.Add(ParIddatosdeenvio);

                SqlParameter ParPais_DE = new SqlParameter();
                ParPais_DE.ParameterName = "@Pais_DE";
                ParPais_DE.SqlDbType = SqlDbType.VarChar;
                ParPais_DE.Size = 20;
                ParPais_DE.Value = Cliente.Pais_DE;
                SqlCmd.Parameters.Add(ParPais_DE);

                SqlParameter ParCiudad_DE = new SqlParameter();
                ParCiudad_DE.ParameterName = "@Ciudad_DE";
                ParCiudad_DE.SqlDbType = SqlDbType.VarChar;
                ParCiudad_DE.Size = 20;
                ParCiudad_DE.Value = Cliente.Ciudad_DE;
                SqlCmd.Parameters.Add(ParCiudad_DE);

                SqlParameter ParDireccion_P = new SqlParameter();
                ParDireccion_P.ParameterName = "@Direccion_P";
                ParDireccion_P.SqlDbType = SqlDbType.VarChar;
                ParDireccion_P.Size = 50;
                ParDireccion_P.Value = Cliente.Direccion_P;
                SqlCmd.Parameters.Add(ParDireccion_P);

                SqlParameter ParDireccion01 = new SqlParameter();
                ParDireccion01.ParameterName = "@Direccion01";
                ParDireccion01.SqlDbType = SqlDbType.VarChar;
                ParDireccion01.Size = 50;
                ParDireccion01.Value = Cliente.Direccion01;
                SqlCmd.Parameters.Add(ParDireccion01);

                SqlParameter ParDireccion02 = new SqlParameter();
                ParDireccion02.ParameterName = "@Direccion02";
                ParDireccion02.SqlDbType = SqlDbType.VarChar;
                ParDireccion02.Size = 50;
                ParDireccion02.Value = Cliente.Direccion02;
                SqlCmd.Parameters.Add(ParDireccion02);

                SqlParameter ParReceptor = new SqlParameter();
                ParReceptor.ParameterName = "@Receptor";
                ParReceptor.SqlDbType = SqlDbType.VarChar;
                ParReceptor.Size = 50;
                ParReceptor.Value = Cliente.Receptor;
                SqlCmd.Parameters.Add(ParReceptor);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 100;
                ParDescripcion.Value = Cliente.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Registro de Otros Datos - Formulario frmAlmacen_Cliente

                SqlParameter ParIddatosfinancieros = new SqlParameter();
                ParIddatosfinancieros.ParameterName = "@Iddatosfinancieros";
                ParIddatosfinancieros.SqlDbType = SqlDbType.Int;
                ParIddatosfinancieros.Value = Cliente.Iddatosfinancieros;
                SqlCmd.Parameters.Add(ParIddatosfinancieros);

                SqlParameter ParBanco01 = new SqlParameter();
                ParBanco01.ParameterName = "@Banco01";
                ParBanco01.SqlDbType = SqlDbType.VarChar;
                ParBanco01.Size = 20;
                ParBanco01.Value = Cliente.BancoPrincipal;
                SqlCmd.Parameters.Add(ParBanco01);

                SqlParameter ParBanco02 = new SqlParameter();
                ParBanco02.ParameterName = "@Banco02";
                ParBanco02.SqlDbType = SqlDbType.VarChar;
                ParBanco02.Size = 20;
                ParBanco02.Value = Cliente.BancoAuxiliar;
                SqlCmd.Parameters.Add(ParBanco02);

                SqlParameter ParCuenta01 = new SqlParameter();
                ParCuenta01.ParameterName = "@Cuenta01";
                ParCuenta01.SqlDbType = SqlDbType.VarChar;
                ParCuenta01.Size = 20;
                ParCuenta01.Value = Cliente.Cuenta01;
                SqlCmd.Parameters.Add(ParCuenta01);

                SqlParameter ParCuenta02 = new SqlParameter();
                ParCuenta02.ParameterName = "@Cuenta02";
                ParCuenta02.SqlDbType = SqlDbType.VarChar;
                ParCuenta02.Size = 20;
                ParCuenta02.Value = Cliente.Cuenta02;
                SqlCmd.Parameters.Add(ParCuenta02);

                SqlParameter ParCreditoMin = new SqlParameter();
                ParCreditoMin.ParameterName = "@CreditoMin";
                ParCreditoMin.SqlDbType = SqlDbType.VarChar;
                ParCreditoMin.Size = 20;
                ParCreditoMin.Value = Cliente.CreditoMin;
                SqlCmd.Parameters.Add(ParCreditoMin);

                SqlParameter ParCreditoMax = new SqlParameter();
                ParCreditoMax.ParameterName = "@CreditoMax";
                ParCreditoMax.SqlDbType = SqlDbType.VarChar;
                ParCreditoMax.Size = 20;
                ParCreditoMax.Value = Cliente.CreditoMax;
                SqlCmd.Parameters.Add(ParCreditoMax);

                SqlParameter ParMora = new SqlParameter();
                ParMora.ParameterName = "@Mora";
                ParMora.SqlDbType = SqlDbType.VarChar;
                ParMora.Size = 20;
                ParMora.Value = Cliente.Mora;
                SqlCmd.Parameters.Add(ParMora);

                SqlParameter ParCreditoTotal = new SqlParameter();
                ParCreditoTotal.ParameterName = "@CreditoTotal";
                ParCreditoTotal.SqlDbType = SqlDbType.VarChar;
                ParCreditoTotal.Size = 20;
                ParCreditoTotal.Value = Cliente.CreditoTotal;
                SqlCmd.Parameters.Add(ParCreditoTotal);

                SqlParameter ParUltimoCredito = new SqlParameter();
                ParUltimoCredito.ParameterName = "@UltimoCredito";
                ParUltimoCredito.SqlDbType = SqlDbType.VarChar;
                ParUltimoCredito.Size = 20;
                ParUltimoCredito.Value = Cliente.UltimoCredito;
                SqlCmd.Parameters.Add(ParUltimoCredito);

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

        public String Eliminar_DatosBasicos(Conexion_Almacen_Clientes Cliente)
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
                SqlCmd.CommandText = "Consulta.Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@Idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Cliente.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Eliminar";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Cliente.Auto;
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

        public DataTable Buscar_Cliente(Conexion_Almacen_Clientes Cliente)
        {
            DataTable DtResultado = new DataTable("Historico.Cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Consulta.Cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Cliente.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Cliente.Filtro;
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
