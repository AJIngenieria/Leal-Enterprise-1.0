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
    public partial class frmProductos_DatosBasicos : Form
    {
        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool Digitar = true;

        //Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar
        public string Guardar = "";
        public string Editar = "";
        public string Consultar = "";
        public string Eliminar = "";
        public string Imprimir = "";

        public frmProductos_DatosBasicos()
        {
            InitializeComponent();
        }

        private void FrmProductos_DatosBasicos_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Impuesto_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Proveedor_Click(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBBuscar_Impuesto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBBuscar_Proveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PB_Imagen_Click(object sender, EventArgs e)
        {

        }

        private void TBCodigo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBNombre_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBReferencia_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDescripcion01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDescripcion02_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBLotedeingreso_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBPresentacion_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBUltimovalor_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBValorFinal_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBValorPromedio_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBValor01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBValor02_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBValor03_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBOferta01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBOferta02_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBBuscar_Impuesto_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBBuscar_Proveedor_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBUbicacion_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBEstante_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBNivel_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBComision_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
