using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Gestion_Empleados
    {
        //Llaves Primarias
        private int _Idempleado;

        //Datos Basicos
        private string _Empleado;
        private string _Documento;
        private string _Telefono;
        private string _Movil;
        private string _Email;
        private string _Direccion;

        //
        private int _Auto;
        private string _Filtro;

        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public string Empleado { get => _Empleado; set => _Empleado = value; }
        public string Documento { get => _Documento; set => _Documento = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        public Conexion_Gestion_Empleados()
        {

        }

        public Conexion_Gestion_Empleados
            (
                //Datos Basicos
                int idempleado, string empleado, string documento, string telefono, string movil, string email, string direccion,

                //
                int auto, string filtro
            )
        {
            this.Idempleado = idempleado;
            this.Empleado = empleado;
            this.Documento = documento;
            this.Movil = movil;
            this.Telefono = telefono;
            this.Email = email;
            this.Direccion = direccion;

            this.Filtro = filtro;
            this.Auto = auto;
        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Gestion_Empleados Empleado)
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
                SqlCmd.CommandText = "Sistema.LI_Empleados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@Idempleado";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Empleado.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParEmpleado = new SqlParameter();
                ParEmpleado.ParameterName = "@Empleado";
                ParEmpleado.SqlDbType = SqlDbType.VarChar;
                ParEmpleado.Size = 100;
                ParEmpleado.Value = Empleado.Empleado;
                SqlCmd.Parameters.Add(ParEmpleado);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 15;
                ParDocumento.Value = Empleado.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 50;
                ParMovil.Value = Empleado.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 100;
                ParEmail.Value = Empleado.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al Registrar";
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

        public string Editar_DatosBasicos(Conexion_Gestion_Empleados Empleado)
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
                SqlCmd.CommandText = "Sistema.LI_Empleados";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@Idempleado";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Empleado.Idempleado;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Empleado.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParEmpleado = new SqlParameter();
                ParEmpleado.ParameterName = "@Empleado";
                ParEmpleado.SqlDbType = SqlDbType.VarChar;
                ParEmpleado.Size = 100;
                ParEmpleado.Value = Empleado.Empleado;
                SqlCmd.Parameters.Add(ParEmpleado);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.Int;
                ParDocumento.Value = Empleado.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 50;
                ParMovil.Value = Empleado.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Empleado.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 100;
                ParEmail.Value = Empleado.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Empleado.Direccion;
                SqlCmd.Parameters.Add(ParDireccion);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al Registrar";
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

        public String Eliminar_DatosBasicos(Conexion_Gestion_Empleados Empleados)
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
                SqlCmd.CommandText = "Eliminar.Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@IdEmpleado";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Empleados.Idempleado;
                SqlCmd.Parameters.Add(ParIdcliente);

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

        public DataTable Buscar_Empleado(Conexion_Gestion_Empleados Empleado)
        {
            DataTable DtResultado = new DataTable("Sistema.Empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Consulta.Empleado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Empleado.Filtro;
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
