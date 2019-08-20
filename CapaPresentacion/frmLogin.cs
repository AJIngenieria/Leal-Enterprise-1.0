using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        //Variable para Iniciar la Consulta de Permisos y Niveles de Operaciones
        private bool SQL_Niveles = true;
        private bool SQL_Permisos = true;
        private string SQL_Idsuario;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.TBUsuario.Focus();

            this.TBUsuario.ReadOnly = false;
            this.TBUsuario.BackColor = Color.FromArgb(32, 178, 170);
            this.TBContraseña.ReadOnly = false;
            this.TBContraseña.BackColor = Color.FromArgb(32, 178, 170);
                        

            //Informe de Sesion
            this.TBInicioDeSesion.ReadOnly = true;
            this.TBInicioDeSesion.BackColor = Color.FromArgb(255, 255, 255);
            this.TBCopyrigth.ReadOnly = true;
            this.TBCopyrigth.BackColor = Color.FromArgb(255, 255, 255);
            this.TBDesarrollo.ReadOnly = true;
            this.TBDesarrollo.BackColor = Color.FromArgb(255, 255, 255);

            //Reloj
            //this.lblHora.Enabled = false;
            //this.lblHora.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void TBUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.TBContraseña.Focus();
            }
        }

        private void TBContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    DataTable Datos = CapaNegocio.fSistema_Usuarios.Login(this.TBUsuario.Text, this.TBContraseña.Text);
                    //Evaluamos si  existen los Datos
                    if (Datos.Rows.Count == 0)
                    {
                        MessageBox.Show("Acceso Denegado al Sistema, Usuario o Contraseña Incorrecto. Si el Problema Persiste Contacte al Area de Sistemas", "Servi Lavado Las Brisas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        this.TBInicioDeSesion.Text = "Usuario Existente en la Base de Datos...";

                        frmMenuPrincipal frm = new frmMenuPrincipal();
                        frm.Idusuario = Datos.Rows[0][0].ToString();
                        frm.Idempleado = Datos.Rows[0][1].ToString();
                        frm.Empleado = Datos.Rows[0][2].ToString();
                        frm.UsuarioEstado = Datos.Rows[0][3].ToString();

                        this.TBInicioDeSesion.Text = "Capturando Datos de Acceso...";

                        //Captura de Valores en la Base de Datos

                        this.SQL_Idsuario = frm.Idusuario;

                        if (SQL_Permisos)
                        {
                            DataTable Permiso = CapaNegocio.fSistema_Usuarios.Permiso(Convert.ToInt32(SQL_Idsuario));
                            if (Datos.Rows.Count == 0)
                            {
                                MessageBox.Show("No se Encuentran Permisos de Operacion en el Sistema, Por Favor Contacte al Area de Sistema, ", "Servi Lavado Las Brisas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                this.TBInicioDeSesion.Text = "Iniciando Permisos de Operacion...";

                                frm.SQL_Consultar = Permiso.Rows[0][2].ToString();
                                frm.SQL_Guardar = Permiso.Rows[0][3].ToString();
                                frm.SQL_Eliminar = Permiso.Rows[0][4].ToString();
                                frm.SQL_Editar = Permiso.Rows[0][5].ToString();

                            }
                        }

                        if (SQL_Niveles)
                        {
                            DataTable Niveles = CapaNegocio.fSistema_Usuarios.Niveles(Convert.ToInt32(SQL_Idsuario));
                            if (Datos.Rows.Count == 0)
                            {
                                MessageBox.Show("No se Encuentran Niveles de Operacion en el Sistema, Por Favor Contacte al Area de Sistema, ", "Servi Lavado Las Brisas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                this.TBInicioDeSesion.Text = "Iniciando Niveles de Operacion...";

                                frm.Menu_Cliente = Niveles.Rows[0][3].ToString();
                                frm.Menu_Nomina = Niveles.Rows[0][4].ToString();
                                frm.Menu_Produccion = Niveles.Rows[0][5].ToString();
                                frm.Menu_Ventas = Niveles.Rows[0][6].ToString();
                                frm.Menu_Sistema = Niveles.Rows[0][7].ToString();

                                this.TBInicioDeSesion.Text = "Iniciando Aplicacion";

                            }
                        }

                        frm.Show();
                        this.Hide();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
