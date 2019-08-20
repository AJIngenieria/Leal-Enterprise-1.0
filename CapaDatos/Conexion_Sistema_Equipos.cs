using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_Equipos
    {
        private int _Idequipo;
        private string _Equipo;
        private string _HDD;
        private string _Tipo;
        private string _Mac_Seguridad;
        private int _Estado;

        //Metodos
        private int _Auto;
        private string _Filtro;

        public int Idequipo { get => _Idequipo; set => _Idequipo = value; }
        public string Equipo { get => _Equipo; set => _Equipo = value; }
        public string HDD { get => _HDD; set => _HDD = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Mac_Seguridad { get => _Mac_Seguridad; set => _Mac_Seguridad = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }

        public Conexion_Sistema_Equipos()
        {

        }

        public Conexion_Sistema_Equipos
            (
                //Llaves Primarias
                int idequipo,

                //Datos Basicos
                string equipo, string hdd, string tipo,
                string mac_seguridad, int estado,

                //Metodos
                int auto, string filtro
            )
        {
            //Llaves Primarias
            this.Idequipo = idequipo;

            //Datos Basicos
            this.Equipo = equipo;
            this.HDD = hdd;
            this.Tipo = tipo;
            this.Mac_Seguridad = mac_seguridad;
            this.Estado = estado;

            this.Auto = auto;
            this.Filtro = filtro;

        }

        //Metodo Insertar

        public string Guardar_DatosBasicos(Conexion_Sistema_Equipos Equipos)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Jalo la conexion de la base de datos 
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Seguridad_SQL;
                SqlCon.Open();

                //Establecer la conexion para mandar a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.LI_Empresa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdempresa = new SqlParameter();
                ParIdempresa.ParameterName = "@Idempresa";
                ParIdempresa.SqlDbType = SqlDbType.Int;
                ParIdempresa.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdempresa);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Empresa.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParEmpleado = new SqlParameter();
                ParEmpleado.ParameterName = "@Empresa";
                ParEmpleado.SqlDbType = SqlDbType.VarChar;
                ParEmpleado.Size = 50;
                ParEmpleado.Value = Empresa.Empresa;
                SqlCmd.Parameters.Add(ParEmpleado);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 20;
                ParDocumento.Value = Empresa.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 30;
                ParMovil.Value = Empresa.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 30;
                ParTelefono.Value = Empresa.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Correo";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Empresa.Correo;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Empresa.Direccion;
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

        public string Editar_DatosBasicos(Conexion_Sistema_Equipos Equipos)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Jalo la conexion de la base de datos 
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Seguridad_SQL;
                SqlCon.Open();

                //Establecer la conexion para mandar a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.LI_Empresa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@Idempresa";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Empresa.Idempresa;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Empresa.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParEmpleado = new SqlParameter();
                ParEmpleado.ParameterName = "@Empresa";
                ParEmpleado.SqlDbType = SqlDbType.VarChar;
                ParEmpleado.Size = 50;
                ParEmpleado.Value = Empresa.Empresa;
                SqlCmd.Parameters.Add(ParEmpleado);

                SqlParameter ParDocumento = new SqlParameter();
                ParDocumento.ParameterName = "@Documento";
                ParDocumento.SqlDbType = SqlDbType.VarChar;
                ParDocumento.Size = 20;
                ParDocumento.Value = Empresa.Documento;
                SqlCmd.Parameters.Add(ParDocumento);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 30;
                ParMovil.Value = Empresa.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 30;
                ParTelefono.Value = Empresa.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@Correo";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Empresa.Correo;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Empresa.Direccion;
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

        public String Eliminar_DatosBasicos(Conexion_Sistema_Equipos Equipos)
        {

            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Jalo la conexion de la base de datos 
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Seguridad_SQL;
                SqlCon.Open();

                //Establecer la conexion para mandar a la base de datos
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Eliminar.Empresa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdempresa = new SqlParameter();
                ParIdempresa.ParameterName = "@Idempresa";
                ParIdempresa.SqlDbType = SqlDbType.Int;
                ParIdempresa.Value = Empresa.Idempresa;
                SqlCmd.Parameters.Add(ParIdempresa);

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

        public DataTable Buscar_Equipos(Conexion_Sistema_Equipos Equipos)
        {
            DataTable DtResultado = new DataTable("Sistema.Empleado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Seguridad_SQL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Consulta.Empresa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Equipos.Filtro;
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
