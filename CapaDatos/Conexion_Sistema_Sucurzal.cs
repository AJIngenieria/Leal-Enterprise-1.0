using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_Sucurzal
    {
        //Llaves primarias
        private int _Idsucurzal;

        //Datos Basicos
        private string _Codigo;
        private string _Sucurzal;
        private string _Ciudad;
        private string _Direccion;
        private string _Ubicacion;

        //Datos Auxiliares
        private int _Auto;
        private int _Estado;
        private string _Filtro;

        public int Idsucurzal { get => _Idsucurzal; set => _Idsucurzal = value; }
        public string Sucurzal { get => _Sucurzal; set => _Sucurzal = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Ubicacion { get => _Ubicacion; set => _Ubicacion = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        
        public Conexion_Sistema_Sucurzal()
        {

        }

        public Conexion_Sistema_Sucurzal
            (

                //Llave primaria
                int idsucurzal,

                //Datos Basicos
                string codigo, string sucurzal, string ciudad, string ubicacion, string direccion,

                //Datos Auxiliares
                int auto, int estado, string filtro
            )
        {
            //Llave primaria
            this.Idsucurzal = idsucurzal;
            
            //Datos Basicos
            this.Codigo = codigo;
            this.Sucurzal = sucurzal;
            this.Ciudad = ciudad;
            this.Ubicacion = ubicacion;
            this.Direccion = direccion;
            
            //Datos Auxiliares
            this.Auto = auto;
            this.Estado = estado;
            this.Filtro = filtro;
        }

        //Metodo Insertar
        public string Guardar_DatosBasicos(Conexion_Sistema_Sucurzal Sucurzal)
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
                SqlCmd.CommandText = "Sistema.LI_Sucurzal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdSucurzal = new SqlParameter();
                ParIdSucurzal.ParameterName = "@IdSucurzal";
                ParIdSucurzal.SqlDbType = SqlDbType.Int;
                ParIdSucurzal.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdSucurzal);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Sucurzal.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParSucurzal = new SqlParameter();
                ParSucurzal.ParameterName = "@Sucurzal";
                ParSucurzal.SqlDbType = SqlDbType.VarChar;
                ParSucurzal.Size = 50;
                ParSucurzal.Value = Sucurzal.Sucurzal;
                SqlCmd.Parameters.Add(ParSucurzal);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@Codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Sucurzal.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 50;
                ParCiudad.Value = Sucurzal.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParUbicacion = new SqlParameter();
                ParUbicacion.ParameterName = "@Ubicacion";
                ParUbicacion.SqlDbType = SqlDbType.VarChar;
                ParUbicacion.Size = 20;
                ParUbicacion.Value = Sucurzal.Ubicacion;
                SqlCmd.Parameters.Add(ParUbicacion);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Sucurzal.Direccion;
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

        public string Editar_DatosBasicos(Conexion_Sistema_Sucurzal Sucurzal)
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
                SqlCmd.CommandText = "Sistema.LI_Sucurzal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdSucurzal = new SqlParameter();
                ParIdSucurzal.ParameterName = "@Idsucurzal";
                ParIdSucurzal.SqlDbType = SqlDbType.Int;
                ParIdSucurzal.Value = Sucurzal.Idsucurzal;
                SqlCmd.Parameters.Add(ParIdSucurzal);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Sucurzal.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParSucurzal = new SqlParameter();
                ParSucurzal.ParameterName = "@Sucurzal";
                ParSucurzal.SqlDbType = SqlDbType.VarChar;
                ParSucurzal.Size = 50;
                ParSucurzal.Value = Sucurzal.Sucurzal;
                SqlCmd.Parameters.Add(ParSucurzal);

                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@Codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Sucurzal.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParUbicacion = new SqlParameter();
                ParUbicacion.ParameterName = "@Ubicacion";
                ParUbicacion.SqlDbType = SqlDbType.VarChar;
                ParUbicacion.Size = 20;
                ParUbicacion.Value = Sucurzal.Ubicacion;
                SqlCmd.Parameters.Add(ParUbicacion);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@Direccion";
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Sucurzal.Direccion;
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

        public String Eliminar_DatosBasicos(Conexion_Sistema_Sucurzal Sucurzal)
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
                SqlCmd.CommandText = "Sistema.LI_Sucurzal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos

                //SqlParameter ParAuto = new SqlParameter();
                //ParAuto.ParameterName = "@Auto";
                //ParAuto.SqlDbType = SqlDbType.Int;
                //ParAuto.Value = Sucurzal.Auto;
                //SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParIdSucurzal = new SqlParameter();
                ParIdSucurzal.ParameterName = "@IdSucurzal";
                ParIdSucurzal.SqlDbType = SqlDbType.Int;
                ParIdSucurzal.Value = Sucurzal.Idsucurzal;
                SqlCmd.Parameters.Add(ParIdSucurzal);

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

        public DataTable Buscar_Sucurzal(Conexion_Sistema_Sucurzal Sucurzal)
        {
            DataTable DtResultado = new DataTable("Sistema.Sucurzal");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Consulta.Sucurzal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Sucurzal.Filtro;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Sucurzal.Auto;
                SqlCmd.Parameters.Add(ParAuto);

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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Sistema.Sucurzal");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Consulta.Sucurzal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

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
