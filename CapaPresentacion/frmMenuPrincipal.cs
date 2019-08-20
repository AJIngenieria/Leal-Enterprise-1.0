using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMenuPrincipal : Form
    {
        //Parametros Basicos
        public string Idempleado = "";
        public string Empleado = "";
        public string Cede = "";
        public string UsuarioLogueado = "";
        public string Idusuario = "";

        //Menu Principal
        public string Menu_Almacen = "";
        public string Menu_GestionHumana = "";
        public string Menu_Productos = "";
        public string Menu_Reportes = "";
        public string Menu_Remision = "";
        public string Menu_Sistema = "";
        public string Menu_Ventas = "";

        //Permisos de Operacion Que Vienen de la Base de Datos

        public string SQL_Guardar = "";
        public string SQL_Editar = "";
        public string SQL_Eliminar = "";
        public string SQL_Consultar = "";

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void EmpleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGestionHumana_Empleados frmGestionHumana_Empleados = new frmGestionHumana_Empleados();
            frmGestionHumana_Empleados.MdiParent = this;
            frmGestionHumana_Empleados.Show();

            frmGestionHumana_Empleados.Guardar = Convert.ToString(this.SQL_Guardar);
            frmGestionHumana_Empleados.Editar = Convert.ToString(this.SQL_Editar);
            frmGestionHumana_Empleados.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmGestionHumana_Empleados.Consultar = Convert.ToString(this.SQL_Consultar);
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistema_Usuarios frmSistema_Usuarios = frmSistema_Usuarios.GetInstancia();
            frmSistema_Usuarios.MdiParent = this;
            frmSistema_Usuarios.Show();

            frmSistema_Usuarios.Guardar = Convert.ToString(this.SQL_Guardar);
            frmSistema_Usuarios.Editar = Convert.ToString(this.SQL_Editar);
            frmSistema_Usuarios.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmSistema_Usuarios.Consultar = Convert.ToString(this.SQL_Consultar);
        }
    }
}
