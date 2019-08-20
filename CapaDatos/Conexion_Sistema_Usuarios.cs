using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion_Sistema_Usuarios
    {
        //Llaves Primarias
        private int _Idusuario;
        private int _Idempleado;
        private int _Idpermiso;
        private int _Idnivel;
        
        //Datos Basicos
        private string _Empleado;
        private string _Usuario;
        private string _Contraseña;
        private string _Descripcion;
        private int _Estado;

        //Niveles
        private string _Almacen;
        private string _GestionHumana;
        private string _Productos;
        private string _Remision;
        private string _Reportes;
        private string _Sistema;
        private string _Ventas;

        //Permisos
        private string _Consultar;
        private string _Guardar;
        private string _Eliminar;
        private string _Editar;

        //Filtros y Metodos
        private int _Auto;
        private string _Filtro;

        private int _Permisos;
        private int _Nivel;

        public int Idusuario { get => _Idusuario; set => _Idusuario = value; }
        public int Idempleado { get => _Idempleado; set => _Idempleado = value; }
        public int Idpermiso { get => _Idpermiso; set => _Idpermiso = value; }
        public int Idnivel { get => _Idnivel; set => _Idnivel = value; }
        public string Empleado { get => _Empleado; set => _Empleado = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Contraseña { get => _Contraseña; set => _Contraseña = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public string Almacen { get => _Almacen; set => _Almacen = value; }
        public string GestionHumana { get => _GestionHumana; set => _GestionHumana = value; }
        public string Productos { get => _Productos; set => _Productos = value; }
        public string Remision { get => _Remision; set => _Remision = value; }
        public string Reportes { get => _Reportes; set => _Reportes = value; }
        public string Sistema { get => _Sistema; set => _Sistema = value; }
        public string Ventas { get => _Ventas; set => _Ventas = value; }
        public string Consultar { get => _Consultar; set => _Consultar = value; }
        public string Guardar { get => _Guardar; set => _Guardar = value; }
        public string Eliminar { get => _Eliminar; set => _Eliminar = value; }
        public string Editar { get => _Editar; set => _Editar = value; }
        public int Auto { get => _Auto; set => _Auto = value; }
        public string Filtro { get => _Filtro; set => _Filtro = value; }
        public int Permisos { get => _Permisos; set => _Permisos = value; }
        public int Nivel { get => _Nivel; set => _Nivel = value; }

        public Conexion_Sistema_Usuarios()
        {

        }

        public Conexion_Sistema_Usuarios
            (
                //Llaves Primarias
                int idusuario, int idempelado, int idniveles, int idpermiso,

                //Datos Basicos
                string empleado, string usuario, string descripcion,

                //Niveles
                string almacen, string gestionhumana, string productos,
                string remision, string reporte, string ventas, string sistema,

                //Permisos
                string guardar, string eliminar, string editar, string consultar,

                //Filtros y Metodo
                int estado, int auto, string filtro, int permisos, int nivel
            )
        {
            //Llaves Primarias
            this.Idusuario = idusuario;
            this.Idempleado = idempelado;
            this.Idnivel = idniveles;

            //Datos Basicos
            this.Empleado = empleado;
            this.Usuario = usuario;
            this.Descripcion = descripcion;

            //Niveles
            this.Almacen = almacen;
            this.GestionHumana = gestionhumana;
            this.Productos = productos;
            this.Remision = remision;
            this.Reportes = reporte;
            this.Ventas = ventas;
            this.Sistema = sistema;

            //Permisos
            this.Guardar = guardar;
            this.Eliminar = eliminar;
            this.Editar = editar;
            this.Consultar = consultar;

            //Metodos y Filtros

            this.Auto = auto;
            this.Estado = estado;
            this.Filtro = filtro;

            this.Permisos = permisos;
            this.Nivel = nivel;

        }

        public DataTable Login(Conexion_Sistema_Usuarios Usuarios_Login)
        {
            DataTable DtResultado = new DataTable("Sistema.Usuarios");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Sistema.Login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@Usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Usuarios_Login.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@Password";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 20;
                ParContraseña.Value = Usuarios_Login.Contraseña;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Método Insertar
        public string Guardar_DatosBasicos(Conexion_Sistema_Usuarios DatosBasicos)
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
                SqlCmd.CommandText = "Sistema.LI_Usuarios";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos

                //Panel de Datos Basicos - Formulario frmProduccion_Productos
                SqlParameter ParIdusuario = new SqlParameter();
                ParIdusuario.ParameterName = "@Idusuario";
                ParIdusuario.SqlDbType = SqlDbType.Int;
                ParIdusuario.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdusuario);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@Idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = DatosBasicos.Idempleado;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@Usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = DatosBasicos.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@Contraseña";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 50;
                ParContraseña.Value = DatosBasicos.Contraseña;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 200;
                ParDescripcion.Value = DatosBasicos.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = DatosBasicos.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //Panel de Costos y Precios - Formulario frmProduccion_Productos

                SqlParameter ParIdpermiso = new SqlParameter();
                ParIdpermiso.ParameterName = "@Idpermiso";
                ParIdpermiso.SqlDbType = SqlDbType.Int;
                ParIdpermiso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdpermiso);

                SqlParameter ParGuardar = new SqlParameter();
                ParGuardar.ParameterName = "@Guardar";
                ParGuardar.SqlDbType = SqlDbType.VarChar;
                ParGuardar.Size = 2;
                ParGuardar.Value = DatosBasicos.Guardar;
                SqlCmd.Parameters.Add(ParGuardar);

                SqlParameter ParEliminar = new SqlParameter();
                ParEliminar.ParameterName = "@Eliminar";
                ParEliminar.SqlDbType = SqlDbType.VarChar;
                ParEliminar.Size = 2;
                ParEliminar.Value = DatosBasicos.Eliminar;
                SqlCmd.Parameters.Add(ParEliminar);

                SqlParameter ParEditar = new SqlParameter();
                ParEditar.ParameterName = "@Editar";
                ParEditar.SqlDbType = SqlDbType.VarChar;
                ParEditar.Size = 2;
                ParEditar.Value = DatosBasicos.Editar;
                SqlCmd.Parameters.Add(ParEditar);

                SqlParameter ParConsultar = new SqlParameter();
                ParConsultar.ParameterName = "@Consultar";
                ParConsultar.SqlDbType = SqlDbType.VarChar;
                ParConsultar.Size = 2;
                ParConsultar.Value = DatosBasicos.Consultar;
                SqlCmd.Parameters.Add(ParConsultar);

                //Niveles de Acceso 

                SqlParameter ParIdniveles = new SqlParameter();
                ParIdniveles.ParameterName = "@Idniveles";
                ParIdniveles.SqlDbType = SqlDbType.Int;
                ParIdniveles.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdniveles);

                SqlParameter ParAlmacen = new SqlParameter();
                ParAlmacen.ParameterName = "@Almacen";
                ParAlmacen.SqlDbType = SqlDbType.VarChar;
                ParAlmacen.Size = 2;
                ParAlmacen.Value = DatosBasicos.Almacen;
                SqlCmd.Parameters.Add(ParAlmacen);

                SqlParameter ParGestionHumana = new SqlParameter();
                ParGestionHumana.ParameterName = "@GestionHumana";
                ParGestionHumana.SqlDbType = SqlDbType.VarChar;
                ParGestionHumana.Size = 2;
                ParGestionHumana.Value = DatosBasicos.GestionHumana;
                SqlCmd.Parameters.Add(ParGestionHumana);

                SqlParameter ParProductos = new SqlParameter();
                ParProductos.ParameterName = "@Productos";
                ParProductos.SqlDbType = SqlDbType.VarChar;
                ParProductos.Size = 2;
                ParProductos.Value = DatosBasicos.Productos;
                SqlCmd.Parameters.Add(ParProductos);

                SqlParameter ParRemision = new SqlParameter();
                ParRemision.ParameterName = "@Remision";
                ParRemision.SqlDbType = SqlDbType.VarChar;
                ParRemision.Size = 2;
                ParRemision.Value = DatosBasicos.Remision;
                SqlCmd.Parameters.Add(ParRemision);

                SqlParameter ParReportes = new SqlParameter();
                ParReportes.ParameterName = "@Reportes";
                ParReportes.SqlDbType = SqlDbType.VarChar;
                ParReportes.Size = 2;
                ParReportes.Value = DatosBasicos.Reportes;
                SqlCmd.Parameters.Add(ParReportes);

                SqlParameter ParVentas = new SqlParameter();
                ParVentas.ParameterName = "@Ventas";
                ParVentas.SqlDbType = SqlDbType.VarChar;
                ParVentas.Size = 2;
                ParVentas.Value = DatosBasicos.Ventas;
                SqlCmd.Parameters.Add(ParVentas);

                SqlParameter ParSistema = new SqlParameter();
                ParSistema.ParameterName = "@Sistema";
                ParSistema.SqlDbType = SqlDbType.VarChar;
                ParSistema.Size = 2;
                ParSistema.Value = DatosBasicos.Sistema;
                SqlCmd.Parameters.Add(ParSistema);

                //Datos - Tipo de Envio y/o Proceso a realizar (Eliminar,Guardar,Editar)

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = DatosBasicos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "Error al Registrar";
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

        //Método Editar
        public string Editar_DatosBasicos(Conexion_Sistema_Usuarios DatosBasicos)
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
                SqlCmd.CommandText = "Sistema.LI_Usuarios";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Comienzo a mandar a la base de datos

                //Panel de Datos Basicos - Formulario frmProduccion_Productos
                SqlParameter ParIdusuario = new SqlParameter();
                ParIdusuario.ParameterName = "@Idusuario";
                ParIdusuario.SqlDbType = SqlDbType.Int;
                ParIdusuario.Value = DatosBasicos.Idusuario;
                SqlCmd.Parameters.Add(ParIdusuario);

                SqlParameter ParIdempleado = new SqlParameter();
                ParIdempleado.ParameterName = "@Idempleado";
                ParIdempleado.SqlDbType = SqlDbType.Int;
                ParIdempleado.Value = DatosBasicos.Idempleado;
                SqlCmd.Parameters.Add(ParIdempleado);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@Usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = DatosBasicos.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@Contraseña";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 50;
                ParContraseña.Value = DatosBasicos.Contraseña;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@Descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 200;
                ParDescripcion.Value = DatosBasicos.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@Estado";
                ParEstado.SqlDbType = SqlDbType.Int;
                ParEstado.Value = DatosBasicos.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                //Panel de Costos y Precios - Formulario frmProduccion_Productos

                SqlParameter ParIdpermiso = new SqlParameter();
                ParIdpermiso.ParameterName = "@Idpermiso";
                ParIdpermiso.SqlDbType = SqlDbType.Int;
                ParIdpermiso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdpermiso);

                SqlParameter ParGuardar = new SqlParameter();
                ParGuardar.ParameterName = "@Guardar";
                ParGuardar.SqlDbType = SqlDbType.VarChar;
                ParGuardar.Size = 2;
                ParGuardar.Value = DatosBasicos.Guardar;
                SqlCmd.Parameters.Add(ParGuardar);

                SqlParameter ParEliminar = new SqlParameter();
                ParEliminar.ParameterName = "@Eliminar";
                ParEliminar.SqlDbType = SqlDbType.VarChar;
                ParEliminar.Size = 2;
                ParEliminar.Value = DatosBasicos.Eliminar;
                SqlCmd.Parameters.Add(ParEliminar);

                SqlParameter ParEditar = new SqlParameter();
                ParEditar.ParameterName = "@Editar";
                ParEditar.SqlDbType = SqlDbType.VarChar;
                ParEditar.Size = 2;
                ParEditar.Value = DatosBasicos.Editar;
                SqlCmd.Parameters.Add(ParEditar);

                SqlParameter ParConsultar = new SqlParameter();
                ParConsultar.ParameterName = "@Consultar";
                ParConsultar.SqlDbType = SqlDbType.VarChar;
                ParConsultar.Size = 2;
                ParConsultar.Value = DatosBasicos.Consultar;
                SqlCmd.Parameters.Add(ParConsultar);

                //Niveles de Acceso 

                SqlParameter ParIdniveles = new SqlParameter();
                ParIdniveles.ParameterName = "@Idniveles";
                ParIdniveles.SqlDbType = SqlDbType.Int;
                ParIdniveles.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdniveles);

                SqlParameter ParAlmacen = new SqlParameter();
                ParAlmacen.ParameterName = "@Almacen";
                ParAlmacen.SqlDbType = SqlDbType.VarChar;
                ParAlmacen.Size = 2;
                ParAlmacen.Value = DatosBasicos.Almacen;
                SqlCmd.Parameters.Add(ParAlmacen);

                SqlParameter ParGestionHumana = new SqlParameter();
                ParGestionHumana.ParameterName = "@GestionHumana";
                ParGestionHumana.SqlDbType = SqlDbType.VarChar;
                ParGestionHumana.Size = 2;
                ParGestionHumana.Value = DatosBasicos.GestionHumana;
                SqlCmd.Parameters.Add(ParGestionHumana);

                SqlParameter ParProductos = new SqlParameter();
                ParProductos.ParameterName = "@Productos";
                ParProductos.SqlDbType = SqlDbType.VarChar;
                ParProductos.Size = 2;
                ParProductos.Value = DatosBasicos.Productos;
                SqlCmd.Parameters.Add(ParProductos);

                SqlParameter ParRemision = new SqlParameter();
                ParRemision.ParameterName = "@Remision";
                ParRemision.SqlDbType = SqlDbType.VarChar;
                ParRemision.Size = 2;
                ParRemision.Value = DatosBasicos.Remision;
                SqlCmd.Parameters.Add(ParRemision);

                SqlParameter ParReportes = new SqlParameter();
                ParReportes.ParameterName = "@Reportes";
                ParReportes.SqlDbType = SqlDbType.VarChar;
                ParReportes.Size = 2;
                ParReportes.Value = DatosBasicos.Reportes;
                SqlCmd.Parameters.Add(ParReportes);

                SqlParameter ParVentas = new SqlParameter();
                ParVentas.ParameterName = "@Ventas";
                ParVentas.SqlDbType = SqlDbType.VarChar;
                ParVentas.Size = 2;
                ParVentas.Value = DatosBasicos.Ventas;
                SqlCmd.Parameters.Add(ParVentas);

                SqlParameter ParSistema = new SqlParameter();
                ParSistema.ParameterName = "@Sistema";
                ParSistema.SqlDbType = SqlDbType.VarChar;
                ParSistema.Size = 2;
                ParSistema.Value = DatosBasicos.Sistema;
                SqlCmd.Parameters.Add(ParSistema);

                //Datos - Tipo de Envio y/o Proceso a realizar (Eliminar,Guardar,Editar)

                SqlParameter ParAuto = new SqlParameter();
                ParAuto.ParameterName = "@auto";
                ParAuto.SqlDbType = SqlDbType.Int;
                ParAuto.Value = DatosBasicos.Auto;
                SqlCmd.Parameters.Add(ParAuto);

                //ejecutamos el envio de datos

                rpta = SqlCmd.ExecuteNonQuery() != 0 ? "OK" : "Error al Registrar";
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

        public DataTable Buscar_Usuario(Conexion_Sistema_Usuarios Usuario)
        {
            DataTable DtResultado = new DataTable("Sistema.Usuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion_BaseDeDatos.Conexion_SQL;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Consulta.Buscar_Sistema";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@Filtro";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 100;
                ParTextoBuscar.Value = Usuario.Filtro;
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
