﻿using System;
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
                        frm.Idempleado = Datos.Rows[0][0].ToString();
                        frm.Idusuario = Datos.Rows[0][1].ToString();
                        frm.Empleado = Datos.Rows[0][2].ToString();
                        frm.UsuarioLogueado = Datos.Rows[0][3].ToString();

                        //this.TBInicioDeSesion.Text = "Capturando Datos de Acceso...";

                        //Captura de Valores en la Base de Datos

                        frm.SQL_Guardar = Datos.Rows[0][4].ToString();
                        frm.SQL_Editar = Datos.Rows[0][5].ToString();
                        frm.SQL_Eliminar = Datos.Rows[0][6].ToString();
                        frm.SQL_Consultar = Datos.Rows[0][7].ToString();

                        frm.Menu_Almacen = Datos.Rows[0][8].ToString();
                        frm.Menu_GestionHumana = Datos.Rows[0][9].ToString();
                        frm.Menu_Productos = Datos.Rows[0][10].ToString();
                        frm.Menu_Remision = Datos.Rows[0][11].ToString();
                        frm.Menu_Reportes = Datos.Rows[0][12].ToString();
                        frm.Menu_Sistema = Datos.Rows[0][13].ToString();
                        frm.Menu_Ventas = Datos.Rows[0][14].ToString();

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
