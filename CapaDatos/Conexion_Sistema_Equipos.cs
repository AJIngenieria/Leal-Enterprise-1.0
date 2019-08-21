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
                SqlCmd.CommandText = "Seguridad.LI_Equipos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdequipo = new SqlParameter();
                ParIdequipo.ParameterName = "@Idequipo";
                ParIdequipo.SqlDbType = SqlDbType.Int;
                ParIdequipo.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdequipo);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Equipos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParEmpleado = new SqlParameter();
                ParEmpleado.ParameterName = "@Equipo";
                ParEmpleado.SqlDbType = SqlDbType.VarChar;
                ParEmpleado.Size = 30;
                ParEmpleado.Value = Equipos.Equipo;
                SqlCmd.Parameters.Add(ParEmpleado);

                SqlParameter ParHDD = new SqlParameter();
                ParHDD.ParameterName = "@HDD";
                ParHDD.SqlDbType = SqlDbType.VarChar;
                ParHDD.Size = 50;
                ParHDD.Value = Equipos.HDD;
                SqlCmd.Parameters.Add(ParHDD);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 10;
                ParTipo.Value = Equipos.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParMac_Seguridad = new SqlParameter();
                ParMac_Seguridad.ParameterName = "@Mac_Seguridad";
                ParMac_Seguridad.SqlDbType = SqlDbType.VarChar;
                ParMac_Seguridad.Size = 50;
                ParMac_Seguridad.Value = Equipos.Mac_Seguridad;
                SqlCmd.Parameters.Add(ParMac_Seguridad);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Equipos.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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
                SqlCmd.CommandText = "Seguridad.LI_Equipos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdequipo = new SqlParameter();
                ParIdequipo.ParameterName = "@Idequipo";
                ParIdequipo.SqlDbType = SqlDbType.Int;
                ParIdequipo.Value = Equipos.Idequipo;
                SqlCmd.Parameters.Add(ParIdequipo);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Equipos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParEmpleado = new SqlParameter();
                ParEmpleado.ParameterName = "@Equipo";
                ParEmpleado.SqlDbType = SqlDbType.VarChar;
                ParEmpleado.Size = 30;
                ParEmpleado.Value = Equipos.Equipo;
                SqlCmd.Parameters.Add(ParEmpleado);

                SqlParameter ParHDD = new SqlParameter();
                ParHDD.ParameterName = "@HDD";
                ParHDD.SqlDbType = SqlDbType.VarChar;
                ParHDD.Size = 50;
                ParHDD.Value = Equipos.HDD;
                SqlCmd.Parameters.Add(ParHDD);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 10;
                ParTipo.Value = Equipos.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParMac_Seguridad = new SqlParameter();
                ParMac_Seguridad.ParameterName = "@Mac_Seguridad";
                ParMac_Seguridad.SqlDbType = SqlDbType.VarChar;
                ParMac_Seguridad.Size = 50;
                ParMac_Seguridad.Value = Equipos.Mac_Seguridad;
                SqlCmd.Parameters.Add(ParMac_Seguridad);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = Equipos.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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
                SqlCmd.CommandText = "Eliminar.Equipo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos
                SqlParameter ParIdequipo = new SqlParameter();
                ParIdequipo.ParameterName = "@Idequipo";
                ParIdequipo.SqlDbType = SqlDbType.Int;
                ParIdequipo.Value = Equipos.Idequipo;
                SqlCmd.Parameters.Add(ParIdequipo);

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
            DataTable DtResultado = new DataTable("Seguridad.Equipo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Seguridad_SQL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Consulta.Equipo";
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
