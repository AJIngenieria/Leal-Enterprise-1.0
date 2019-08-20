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
    public partial class frmExaminar_Empleado : Form
    {
        public frmExaminar_Empleado()
        {
            InitializeComponent();
        }

        private void FrmExaminar_Empleado_Load(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.DGResultados.DataSource = fGestionHumana_Empleados.Buscar_Empleado(this.TBBuscar.Text);
                lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmSistema_Usuarios frmPE = frmSistema_Usuarios.GetInstancia();
                
                //Variables de frmSistema_Empleados
                string frmPE1, frmPE2;

                if (frmPE.Filtro)
                {
                    frmPE1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    frmPE2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Empleado"].Value);
                    frmPE.setEmpleado(frmPE1, frmPE2);
                    this.Hide();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    frmSistema_Usuarios frmPE = frmSistema_Usuarios.GetInstancia();

                    //Variables de frmSistema_Empleados
                    string frmPE1, frmPE2;

                    if (frmPE.Filtro)
                    {
                        frmPE1 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        frmPE2 = Convert.ToString(this.DGResultados.CurrentRow.Cells["Empleado"].Value);
                        frmPE.setEmpleado(frmPE1, frmPE2);
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
