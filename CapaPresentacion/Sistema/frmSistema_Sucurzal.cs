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
    public partial class frmSistema_Sucurzal : Form
    {
        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool Digitar = true;
        public bool Filtro = true;

        //Variable para Captura el Empleado Logueado
        public int Idempleado;

        //Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar
        public string Guardar = "";
        public string Editar = "";
        public string Consultar = "";
        public string Eliminar = "";
        public string Imprimir = "";
        public frmSistema_Sucurzal()
        {
            InitializeComponent();
        }

        private void frmSistema_Sucurzal_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();

            //Focus a Texboxt
            this.TBNombre.Select();

            //Ocultacion de Texboxt
            this.TBIdsucurzal.Visible = false;
            this.DGResultados.Enabled = false;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos  
            this.TBCodigo.ReadOnly = false;
            this.TBCodigo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNombre.ReadOnly = false;
            this.TBNombre.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCiudad.ReadOnly = false;
            this.TBCiudad.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDireccion.ReadOnly = false;
            this.TBDireccion.BackColor = Color.FromArgb(3, 155, 229);            
            this.TBUbicacion.ReadOnly = false;
            this.TBUbicacion.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Limpiar()
        {
            //Panel - Datos Basicos
            this.TBIdsucurzal.Clear();
            this.TBCodigo.Clear();
            this.TBNombre.Clear();
            this.TBDireccion.Clear();
            this.TBCiudad.Clear();
            this.TBUbicacion.Clear();
        }

        private void Botones()
        {
            if (Digitar)
            {
                this.btnGuardar.Enabled = true;
                this.btnEliminar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnImprimir.Enabled = false;
            }
            else
            {
                this.btnGuardar.Enabled = false;
                this.btnEliminar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnImprimir.Enabled = false;
            }
        }
        
        private void Guardar_SQL()
        {
            try
            {
                string rptaDatosBasicos = "";

                // <<<<<<------ Panel Datos Basicos ------>>>>>

                if (this.TBNombre.Text == string.Empty)
                {
                    MensajeError("Debe ingresar el nombre de la bodega a registrar");
                    TBNombre.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCiudad.Text == string.Empty)
                {
                    MensajeError("Por favor ingrese la ciudad donde se encuentra la sucurzal");
                    TBCiudad.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.Digitar)
                    {
                        rptaDatosBasicos = fSistema_Sucurzal.Guardar_DatosBasicos

                            (
                                 //Panel Datos Basicos
                                 this.TBCodigo.Text, this.TBNombre.Text,
                                 this.TBCiudad.Text, this.TBUbicacion.Text, this.TBDireccion.Text, 1
                            );
                    }

                    else
                    {
                        rptaDatosBasicos = fSistema_Sucurzal.Editar_DatosBasicos

                            (
                                 //Panel Datos Basicos
                                 Convert.ToInt32(this.TBIdsucurzal.Text), this.TBCodigo.Text, this.TBNombre.Text,
                                 this.TBCiudad.Text, this.TBUbicacion.Text, this.TBDireccion.Text, 2
                            );
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.Digitar)
                        {
                            this.MensajeOk("Registro Exitoso");
                        }

                        else
                        {
                            this.MensajeOk("Registro Actualizado");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    //Llamada de Clases y Focus
                    this.Digitar = true;
                    this.Botones();
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //Mensaje de confirmacion
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //Mensaje de Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Leal Enterprise - Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Digitar)
                {
                    if (Guardar == "1")
                    {
                        //Metodo Guardar y editar
                        this.Guardar_SQL();
                    }

                    else
                    {
                        MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Guardar", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                else
                {
                    if (Editar == "1")
                    {
                        //Metodo Guardar y editar
                        this.Guardar_SQL();
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado Para Editar los Registros", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                //Se restablece la imagen predeterminada del boton
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Eliminar == "1")
                {

                    DialogResult Opcion;
                    string Respuesta = "";

                    Opcion = MessageBox.Show("Desea Eliminar el Registro Seleccionado", "Leal Enterprise", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        //if (DGResultadoss.SelectedRows.Count > 0)
                        //{
                        //    Eliminacion = DGResultadoss.CurrentRow.Cells["Codigo"].Value.ToString();
                        //    Respuesta = CapaNegocio.fClientes_Vehiculos.Eliminar_DatosBasicos(Eliminacion);
                        //}

                        //if (Respuesta.Equals("OK"))
                        //{
                        //    this.MensajeOk("Registro Eliminado Correctamente");
                        //}
                        //else
                        //{
                        //    this.MensajeError(Respuesta);
                        //}

                        ////Botones Comunes
                        //this.Digitar = true;
                        //this.Botones();

                        ////Se regresa el focus al campo principal
                        this.TBNombre.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Acceso Denegado Para Realizar Eliminaciones en el Sistema", "Servi Lavado - Las Brisas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Digitar = true;
                this.Botones();
                this.TBNombre.Select();

                this.Limpiar();
                this.TBBuscar.Clear();

                //Se Limpian las Filas y Columnas de la tabla
                DGResultados.DataSource = null;
                this.DGResultados.Enabled = false;
                this.lblTotal.Text = "Datos Registrados: 0";

                //Se restablece la imagen predeterminada del boton
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        this.DGResultados.DataSource = fSistema_Sucurzal.Buscar_Sucurzal(1, this.TBBuscar.Text);
                        this.DGResultados.Columns[0].Visible = false;

                        lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);

                        this.btnEliminar.Enabled = true;
                        this.btnImprimir.Enabled = true;
                        this.DGResultados.Enabled = true;
                    }
                    else
                    {
                        this.Limpiar();

                        //Se Limpian las Filas y Columnas de la tabla
                        DGResultados.DataSource = null;
                        this.DGResultados.Enabled = false;
                        this.lblTotal.Text = "Datos Registrados: 0";

                        this.btnEliminar.Enabled = false;
                        this.btnImprimir.Enabled = false;
                    }
                }

                else
                {
                    MessageBox.Show("El usuario iniciado no tiene permisos para realizar consultas en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                this.Digitar = false;

                if (Editar == "1")
                {
                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;

                    //
                    this.TBIdsucurzal.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["ID"].Value);
                    this.TBCodigo.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    this.TBNombre.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Sucurzal"].Value);
                    this.TBDireccion.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Direccion"].Value);
                    this.TBCiudad.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Ciudad"].Value);
                    this.TBUbicacion.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Ubicacion"].Value);

                    //Se procede Habilitar los campos de Textos y Botones
                    //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                    this.Habilitar();
                    this.TBNombre.Focus();

                    //Se cambia la imagen del Boton la cual inicialmente es Guardar
                    //Y se cambiar por la imagen Editar
                    this.btnGuardar.Image = Properties.Resources.BV_Editar;
                }
                else
                {
                    MessageBox.Show("Acceso denegado para actualizar registros", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultados_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    this.Digitar = false;

                    if (Editar == "1")
                    {
                        this.btnGuardar.Enabled = true;
                        this.btnCancelar.Enabled = true;

                        //
                        this.TBIdsucurzal.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["ID"].Value);
                        this.TBCodigo.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        this.TBNombre.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Sucurzal"].Value);
                        this.TBDireccion.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Direccion"].Value);
                        this.TBCiudad.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Ciudad"].Value);
                        this.TBUbicacion.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Ubicacion"].Value);

                        //Se procede Habilitar los campos de Textos y Botones
                        //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                        this.Habilitar();
                        this.TBNombre.Focus();

                        //Se cambia la imagen del Boton la cual inicialmente es Guardar
                        //Y se cambiar por la imagen Editar
                        this.btnGuardar.Image = Properties.Resources.BV_Editar;
                    }
                    else
                    {
                        MessageBox.Show("Acceso denegado para actualizar registros", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCodigo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBNombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCiudad.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        if (Guardar == "1")
                        {
                            //Clases y Focus
                            this.Guardar_SQL();
                            this.TBNombre.Focus();
                        }
                    }
                    else
                    {
                        this.TBNombre.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCiudad_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBUbicacion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        if (Guardar == "1")
                        {
                            //Clases y Focus
                            this.Guardar_SQL();
                            this.TBNombre.Focus();
                        }
                    }
                    else
                    {
                        this.TBCiudad.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBUbicacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBDireccion.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        if (Guardar == "1")
                        {
                            //Clases y Focus
                            this.Guardar_SQL();
                            this.TBNombre.Focus();
                        }
                    }
                    else
                    {
                        this.TBUbicacion.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBDireccion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBNombre.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        if (Guardar == "1")
                        {
                            //Clases y Focus
                            this.Guardar_SQL();
                            this.TBNombre.Focus();
                        }
                    }
                    else
                    {
                        this.TBDireccion.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBBuscar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            if (Digitar)
            {
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
            }
            else
            {
                this.btnGuardar.Image = Properties.Resources.BV_Editar;
            }
        }

        private void btnGuardar_MouseLeave(object sender, EventArgs e)
        {
            if (Digitar)
            {
                this.btnGuardar.Image = Properties.Resources.BV_Guardar;
            }
            else
            {
                this.btnGuardar.Image = Properties.Resources.BV_Editar;
            }
        }

        private void btnGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            if (Digitar)
            {
                this.btnGuardar.Image = Properties.Resources.BR_Guardar;
            }
            else
            {
                this.btnGuardar.Image = Properties.Resources.BR_Editar;
            }
        }

        private void btnEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            this.btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void btnImprimir_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnImprimir.Image = Properties.Resources.BV_Imprimir;
        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {
            this.btnImprimir.Image = Properties.Resources.BV_Imprimir;
        }

        private void btnImprimir_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnImprimir.Image = Properties.Resources.BR_Imprimir;
        }

        private void btnCancelar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnCancelar.Image = Properties.Resources.BV_Cancelar;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            this.btnCancelar.Image = Properties.Resources.BV_Cancelar;
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnCancelar.Image = Properties.Resources.BR_Cancelar;
        }

        private void frmSistema_Sucurzal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
