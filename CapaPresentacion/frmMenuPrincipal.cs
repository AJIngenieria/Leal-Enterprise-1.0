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
            this.GestionDeUsuarios();
        }

        private void GestionDeUsuarios()
        {
            this.TSEmpleado.Text = Empleado;
            this.TSUsuario.Text = UsuarioLogueado;

            //Menus Principales

            if (Menu_Almacen == "Si")
            {
                this.MP_Almacen.Enabled = true;
            }
            if (Menu_Almacen == "No")
            {
                this.MP_Almacen.Enabled = false;
            }

            if (Menu_GestionHumana == "Si")
            {
                this.MP_GestionHumana.Enabled = true;
            }
            if (Menu_GestionHumana == "No")
            {
                this.MP_GestionHumana.Enabled = false;
            }

            if (Menu_Productos == "Si")
            {
                this.MP_Productos.Enabled = true;
            }
            if (Menu_Productos == "No")
            {
                this.MP_Productos.Enabled = false;
            }

            if (Menu_Reportes == "Si")
            {
                this.MP_Reporte.Enabled = true;
            }
            if (Menu_Reportes == "No")
            {
                this.MP_Reporte.Enabled = false;
            }

            if (Menu_Ventas == "Si")
            {
                this.MP_Ventas.Enabled = true;
            }
            if (Menu_Ventas == "No")
            {
                this.MP_Ventas.Enabled = false;
            }

            if (Menu_Sistema == "Si")
            {
                this.MP_Sistema.Enabled = true;
            }
            if (Menu_Sistema == "No")
            {
                this.MP_Sistema.Enabled = false;
            }
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

        private void EmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistema_Empresa frmSistema_Empresa = new frmSistema_Empresa();
            frmSistema_Empresa.MdiParent = this;
            frmSistema_Empresa.Show();

            frmSistema_Empresa.Guardar = Convert.ToString(this.SQL_Guardar);
            frmSistema_Empresa.Editar = Convert.ToString(this.SQL_Editar);
            frmSistema_Empresa.Eliminar = Convert.ToString(this.SQL_Eliminar);
            frmSistema_Empresa.Consultar = Convert.ToString(this.SQL_Consultar);
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ConfiguracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
