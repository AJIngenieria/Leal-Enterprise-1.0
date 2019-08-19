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
    public partial class frmLogin : Form
    {
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

        }

        private void TBContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
