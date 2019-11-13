using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Almacen_Bodega
    {
        //Llave primaria
        private int _Idbodega;

        //Llaves Auxiliares
        private int _Idsucurzal;

        //Datos Basicos
        private string _Bodega;
        private string _Tipo;
        private string _Ciudad;
        private string _Telefono;
        private string _Movil;
        private string _Responsable;
        private string _Correo;

        //Otros Datos
        private string _Direccion01;
        private string _Direccion02;
        private string _Mercancia;
        private int _NumeroPC;
        private int _NumeroImpresora;
        private int _NumeroCelulares;
        private string _Observacion;

        //Datos Auxiliares
        private int _Auto;
        private int _Eliminar;
        private string _Filtro;

        public int Idbodega { get => _Idbodega; set => _Idbodega = value; }
        public int Idsucurzal { get => _Idsucurzal; set => _Idsucurzal = value; }
        public string Bodega { get => _Bodega; set => _Bodega = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Movil { get => _Movil; set => _Movil = value; }
        public string Responsable { get => _Responsable; set => _Responsable = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string Direccion01 { get => _Direccion01; set => _Direccion01 = value; }
        public string Direccion02 { get => _Direccion02; set => _Direccion02 = value; }
        public string Mercancia { get => _Mercancia; set => _Mercancia = value; }
        public int NumeroPC { get => _NumeroPC; set => _NumeroPC = value; }
        public int NumeroImpresora { get => _NumeroImpresora; set => _NumeroImpresora = value; }
        public int NumeroCelulares { get => _NumeroCelulares; set => _NumeroCelulares = value; }
        public string Observacion { get => _Observacion; set => _Observacion = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public int Eliminar { get => _Eliminar; set => _Eliminar = value; }

        public Conexion_Almacen_Bodega()
        {

        }

        public Conexion_Almacen_Bodega
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
                int auto, int eliminar, string filtro
            )
        {
            //Llave primaria
            this.Idbodega = idbodega;

            //Llaves Auxiliares
            this.Idsucurzal = idsucurzal;

            //Datos Basicos
            this.Bodega = bodega;
            this.Tipo = tipo;
            this.Ciudad = ciudad;
            this.Telefono = telefono;
            this.Movil = movil;
            this.Responsable = responsable;
            this.Correo = correo;

            //Otros Datos
            this.Direccion01 = direccion01;
            this.Direccion02 = direccion02;
            this.Mercancia = mercancia;
            this.NumeroPC = numeroPC;
            this.NumeroImpresora = numeroimpresora;
            this.NumeroCelulares = numerocelulares;
            this.Observacion = observacion;

            //Datos Auxiliares
            this.Auto = auto;
            this.Eliminar = eliminar;
            this.Filtro = filtro;
        }

        //Metodo Insertar
        public string Guardar_DatosBasicos(Conexion_Almacen_Bodega Bodega)
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
                SqlParameter ParIdbodega = new SqlParameter();
                ParIdbodega.ParameterName = "@Idbodega";
                ParIdbodega.SqlDbType = SqlDbType.Int;
                ParIdbodega.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdbodega);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Bodega.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParIdsucurzal = new SqlParameter();
                ParIdsucurzal.ParameterName = "@Idsucurzal";
                ParIdsucurzal.SqlDbType = SqlDbType.Int;
                ParIdsucurzal.Value = Bodega.Idsucurzal;
                SqlCmd.Parameters.Add(ParIdsucurzal);

                SqlParameter ParBodega = new SqlParameter();
                ParBodega.ParameterName = "@Nombre";
                ParBodega.SqlDbType = SqlDbType.VarChar;
                ParBodega.Size = 50;
                ParBodega.Value = Bodega.Bodega;
                SqlCmd.Parameters.Add(ParBodega);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.Value = Bodega.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = Bodega.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Bodega.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 50;
                ParMovil.Value = Bodega.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = Bodega.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParResponsable = new SqlParameter();
                ParResponsable.ParameterName = "@Responsable";
                ParResponsable.SqlDbType = SqlDbType.VarChar;
                ParResponsable.Size = 50;
                ParResponsable.Value = Bodega.Responsable;
                SqlCmd.Parameters.Add(ParResponsable);

                //Registro de Otros Datos - Formulario frmAlmacen_Bodega

                SqlParameter ParIdotros = new SqlParameter();
                ParIdotros.ParameterName = "@Idotros";
                ParIdotros.SqlDbType = SqlDbType.Int;
                ParIdotros.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdotros);

                SqlParameter ParDireccion01 = new SqlParameter();
                ParDireccion01.ParameterName = "@Direccion01";
                ParDireccion01.SqlDbType = SqlDbType.VarChar;
                ParDireccion01.Size = 50;
                ParDireccion01.Value = Bodega.Direccion01;
                SqlCmd.Parameters.Add(ParDireccion01);

                SqlParameter ParDireccion02 = new SqlParameter();
                ParDireccion02.ParameterName = "@Direccion02";
                ParDireccion02.SqlDbType = SqlDbType.VarChar;
                ParDireccion02.Size = 50;
                ParDireccion02.Value = Bodega.Direccion02;
                SqlCmd.Parameters.Add(ParDireccion02);

                SqlParameter ParMercancia = new SqlParameter();
                ParMercancia.ParameterName = "@Mercancia";
                ParMercancia.SqlDbType = SqlDbType.VarChar;
                ParMercancia.Size = 50;
                ParMercancia.Value = Bodega.Mercancia;
                SqlCmd.Parameters.Add(ParMercancia);

                SqlParameter ParNumeroPC = new SqlParameter();
                ParNumeroPC.ParameterName = "@PC";
                ParNumeroPC.SqlDbType = SqlDbType.Int;
                ParNumeroPC.Value = Bodega.NumeroPC;
                SqlCmd.Parameters.Add(ParNumeroPC);

                SqlParameter ParCelular = new SqlParameter();
                ParCelular.ParameterName = "@Celular";
                ParCelular.SqlDbType = SqlDbType.Int;
                ParCelular.Value = Bodega.NumeroCelulares;
                SqlCmd.Parameters.Add(ParCelular);

                SqlParameter ParImpresora = new SqlParameter();
                ParImpresora.ParameterName = "@Impresora";
                ParImpresora.SqlDbType = SqlDbType.Int;
                ParImpresora.Value = Bodega.NumeroImpresora;
                SqlCmd.Parameters.Add(ParImpresora);

                SqlParameter ParObservacion = new SqlParameter();
                ParObservacion.ParameterName = "@Observacion";
                ParObservacion.SqlDbType = SqlDbType.VarChar;
                ParObservacion.Size = 100;
                ParObservacion.Value = Bodega.Observacion;
                SqlCmd.Parameters.Add(ParObservacion);

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

        public string Editar_DatosBasicos(Conexion_Almacen_Bodega Bodega)
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
                SqlParameter ParIdbodega = new SqlParameter();
                ParIdbodega.ParameterName = "@Idbodega";
                ParIdbodega.SqlDbType = SqlDbType.Int;
                ParIdbodega.Value = Bodega.Idbodega;
                SqlCmd.Parameters.Add(ParIdbodega);

                SqlParameter ParIdsucurzal = new SqlParameter();
                ParIdsucurzal.ParameterName = "@Idsucurzal";
                ParIdsucurzal.SqlDbType = SqlDbType.Int;
                ParIdsucurzal.Value = Bodega.Idsucurzal;
                SqlCmd.Parameters.Add(ParIdsucurzal);

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Bodega.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParBodega = new SqlParameter();
                ParBodega.ParameterName = "@Nombre";
                ParBodega.SqlDbType = SqlDbType.VarChar;
                ParBodega.Size = 50;
                ParBodega.Value = Bodega.Bodega;
                SqlCmd.Parameters.Add(ParBodega);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@Tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.Value = Bodega.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParCiudad = new SqlParameter();
                ParCiudad.ParameterName = "@Ciudad";
                ParCiudad.SqlDbType = SqlDbType.VarChar;
                ParCiudad.Size = 20;
                ParCiudad.Value = Bodega.Ciudad;
                SqlCmd.Parameters.Add(ParCiudad);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@Telefono";
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 50;
                ParTelefono.Value = Bodega.Telefono;
                SqlCmd.Parameters.Add(ParTelefono);

                SqlParameter ParMovil = new SqlParameter();
                ParMovil.ParameterName = "@Movil";
                ParMovil.SqlDbType = SqlDbType.VarChar;
                ParMovil.Size = 50;
                ParMovil.Value = Bodega.Movil;
                SqlCmd.Parameters.Add(ParMovil);

                SqlParameter ParCorreo = new SqlParameter();
                ParCorreo.ParameterName = "@Correo";
                ParCorreo.SqlDbType = SqlDbType.VarChar;
                ParCorreo.Size = 50;
                ParCorreo.Value = Bodega.Correo;
                SqlCmd.Parameters.Add(ParCorreo);

                SqlParameter ParResponsable = new SqlParameter();
                ParResponsable.ParameterName = "@Responsable";
                ParResponsable.SqlDbType = SqlDbType.VarChar;
                ParResponsable.Size = 50;
                ParResponsable.Value = Bodega.Responsable;
                SqlCmd.Parameters.Add(ParResponsable);

                //Registro de Otros Datos - Formulario frmAlmacen_Bodega

                SqlParameter ParDireccion01 = new SqlParameter();
                ParDireccion01.ParameterName = "@Direccion01";
                ParDireccion01.SqlDbType = SqlDbType.VarChar;
                ParDireccion01.Size = 50;
                ParDireccion01.Value = Bodega.Direccion01;
                SqlCmd.Parameters.Add(ParDireccion01);

                SqlParameter ParDireccion02 = new SqlParameter();
                ParDireccion02.ParameterName = "@Direccion02";
                ParDireccion02.SqlDbType = SqlDbType.VarChar;
                ParDireccion02.Size = 50;
                ParDireccion02.Value = Bodega.Direccion02;
                SqlCmd.Parameters.Add(ParDireccion02);

                SqlParameter ParMercancia = new SqlParameter();
                ParMercancia.ParameterName = "@Mercancia";
                ParMercancia.SqlDbType = SqlDbType.VarChar;
                ParMercancia.Size = 50;
                ParMercancia.Value = Bodega.Mercancia;
                SqlCmd.Parameters.Add(ParMercancia);

                SqlParameter ParNumeroPC = new SqlParameter();
                ParNumeroPC.ParameterName = "@PC";
                ParNumeroPC.SqlDbType = SqlDbType.Int;
                ParNumeroPC.Value = Bodega.NumeroPC;
                SqlCmd.Parameters.Add(ParNumeroPC);

                SqlParameter ParCelular = new SqlParameter();
                ParCelular.ParameterName = "@Celular";
                ParCelular.SqlDbType = SqlDbType.Int;
                ParCelular.Value = Bodega.NumeroCelulares;
                SqlCmd.Parameters.Add(ParCelular);

                SqlParameter ParImpresora = new SqlParameter();
                ParImpresora.ParameterName = "@Impresora";
                ParImpresora.SqlDbType = SqlDbType.Int;
                ParImpresora.Value = Bodega.NumeroImpresora;
                SqlCmd.Parameters.Add(ParImpresora);

                SqlParameter ParObservacion = new SqlParameter();
                ParObservacion.ParameterName = "@Observacion";
                ParObservacion.SqlDbType = SqlDbType.VarChar;
                ParObservacion.Size = 100;
                ParObservacion.Value = Bodega.Observacion;
                SqlCmd.Parameters.Add(ParObservacion);

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

        public String Eliminar_DatosBasicos(Conexion_Almacen_Bodega Bodega)
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
                SqlCmd.CommandText = "Consulta.Bodega";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdbodega = new SqlParameter();
                ParIdbodega.ParameterName = "@Idbodega";
                ParIdbodega.SqlDbType = SqlDbType.Int;
                ParIdbodega.Value = Bodega.Idbodega;
                SqlCmd.Parameters.Add(ParIdbodega);

                SqlParameter ParEliminar = new SqlParameter();
                ParEliminar.ParameterName = "@Eliminar";
                ParEliminar.SqlDbType = SqlDbType.Int;
                ParEliminar.Value = Bodega.Eliminar;
                SqlCmd.Parameters.Add(ParEliminar);

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

        public DataTable Buscar_Bodega(Conexion_Almacen_Bodega Bodega)
        {
            DataTable DtResultado = new DataTable("Historico.Bodega");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Consulta.Bodega";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@Auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = Bodega.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Bodega.Filtro;
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
