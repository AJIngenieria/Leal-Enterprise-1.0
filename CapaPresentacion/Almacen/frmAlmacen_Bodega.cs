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
    public partial class frmAlmacen_Bodega : Form
    {
        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool Digitar = true;
        public bool Filtro = true;

        //Variable para Metodo Eliminar
        private string Eliminacion = null;

        //Variable para Captura el Empleado Logueado
        public int Idempleado;

        //Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar
        public string Guardar = "";
        public string Editar = "";
        public string Consultar = "";
        public string Eliminar = "";
        public string Imprimir = "";

        public frmAlmacen_Bodega()
        {
            InitializeComponent();
        }

        private void FrmAlmacen_Bodega_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();
            this.Combobox_Sucurzal();

            //Focus a Texboxt
            this.TBBodega.Select();

            //Ocultacion de Texboxt
            this.TBIdbodega.Visible = false;
            this.DGResultados.Enabled = false;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos  
            this.TBBodega.ReadOnly = false;
            this.TBBodega.BackColor = Color.FromArgb(32, 178, 170);
            this.TBTipo.ReadOnly = false;
            this.TBTipo.BackColor = Color.FromArgb(32, 178, 170);
            this.CBSucurzal.Enabled = true;
            this.CBSucurzal.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCiudad.ReadOnly = false;
            this.TBCiudad.BackColor = Color.FromArgb(32, 178, 170);
            this.TBTelefono.ReadOnly = false;
            this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
            this.TBMovil.ReadOnly = false;
            this.TBMovil.BackColor = Color.FromArgb(32, 178, 170);
            this.TBResponsable.ReadOnly = false;
            this.TBResponsable.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCorreo.ReadOnly = false;
            this.TBCorreo.BackColor = Color.FromArgb(32, 178, 170);

            //Panel - Otros Datos
            this.TBDireccion01.ReadOnly = false;
            this.TBDireccion01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccion02.ReadOnly = false;
            this.TBDireccion02.BackColor = Color.FromArgb(32, 178, 170);
            this.TBMercancia.ReadOnly = false;
            this.TBMercancia.BackColor = Color.FromArgb(32, 178, 170);
            this.TBNumeroCelular.ReadOnly = false;
            this.TBNumeroCelular.BackColor = Color.FromArgb(32, 178, 170);
            this.TBNumeroImpresora.ReadOnly = false;
            this.TBNumeroImpresora.BackColor = Color.FromArgb(32, 178, 170);
            this.TBNumeroPC.ReadOnly = false;
            this.TBNumeroPC.BackColor = Color.FromArgb(32, 178, 170);
            this.TBObservacion.ReadOnly = false;
            this.TBObservacion.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Limpiar()
        {
            //Panel - Datos Basicos
            this.TBIdbodega.Clear();
            this.TBBodega.Clear();
            this.TBTipo.Clear();
            this.TBCiudad.Clear();
            this.TBTelefono.Clear();
            this.TBMovil.Clear();
            this.TBResponsable.Clear();
            this.TBCorreo.Clear();

            //Panel - Otros Datos
            this.TBDireccion01.Clear();
            this.TBDireccion02.Clear();
            this.TBMercancia.Clear();
            this.TBNumeroCelular.Clear();
            this.TBNumeroImpresora.Clear();
            this.TBNumeroPC.Clear();
            this.TBObservacion.Clear();
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

        private void Combobox_Sucurzal()
        {
            try
            {
                //this.CBSucurzal.DataSource = fs.Mostrar();
                //this.CBSucurzal.ValueMember = "Idcliente";
                //this.CBSucurzal.DisplayMember = "Cliente";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Guardar_SQL()
        {
            try
            {
                if (Guardar == "1")
                {
                    string rptaDatosBasicos = "";

                    // <<<<<<------ Panel Datos Basicos ------>>>>>

                    if (this.TBBodega.Text == string.Empty)
                    {
                        MensajeError("Debe ingresar el nombre de la bodega a registrar");
                        TBBodega.BackColor = Color.FromArgb(250, 235, 215);
                    }
                    else if (this.TBTipo.Text == string.Empty)
                    {
                        MensajeError("Por favor ingrese el tipo de bodega a registrar");
                        TBTipo.BackColor = Color.FromArgb(250, 235, 215);
                    }
                    else if (this.TBCiudad.Text == string.Empty)
                    {
                        MensajeError("Por favor ingrese la ciudad donde se encuentra la bodega");
                        TBCiudad.BackColor = Color.FromArgb(250, 235, 215);
                    }
                    else if (this.TBResponsable.Text == string.Empty)
                    {
                        MensajeError("Por favor ingrese el nombre de la persona responsable de la bodega");
                        TBResponsable.BackColor = Color.FromArgb(250, 235, 215);
                    }

                    // <<<<<<------ Panel Datos Basicos ------>>>>>

                    else if (this.TBDireccion01.Text == string.Empty)
                    {
                        MensajeError("Debe ingresar la direccion principal de la bodega");
                        TBDireccion01.BackColor = Color.FromArgb(250, 235, 215);
                    }

                    else
                    {
                        if (this.Digitar)
                        {
                            //rptaDatosBasicos = fClientes_Vehiculos.Guardar_DatosBasicos

                            //    (
                            //         //Panel Datos Basicos
                            //         Convert.ToInt32(this.TBIDClientes.Text), this.TBTipo.Text,
                            //         this.TBCiudad.Text, this.TBTelefono.Text, this.TBMovil.Text, 1
                            //    );
                        }

                        else
                        {
                            //rptaDatosBasicos = fClientes_Vehiculos.Editar_DatosBasicos

                            //    (
                            //         //Panel Datos Basicos
                            //         Convert.ToInt32(this.TBIdvehiculo.Text), Convert.ToInt32(this.TBIDClientes.Text), this.TBTipo.Text,
                            //         this.TBCiudad.Text, this.TBTelefono.Text, this.TBMovil.Text, 2
                            //    );
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
                        this.TBBodega.Focus();
                    }
                }

                else
                {
                    MessageBox.Show("El usuario iniciado actualmente no contiene permisos para guardar", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void BtnGuardar_Click(object sender, EventArgs e)
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

        private void BtnEliminar_Click(object sender, EventArgs e)
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
                        //if (DGResultados.SelectedRows.Count > 0)
                        //{
                        //    Eliminacion = DGResultados.CurrentRow.Cells["Codigo"].Value.ToString();
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
                        this.TBBodega.Focus();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Digitar = true;
                this.Botones();

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        //this.DGResultado.DataSource = fClientes_Vehiculos.Buscar_Vehiculo(this.TBBuscar.Text);
                        //this.DGResultado.Columns[0].Visible = false;
                        //this.DGResultado.Columns[1].Visible = false;
                        //this.DGResultado.Columns[6].Visible = false;
                        //this.DGResultado.Columns[7].Visible = false;

                        //lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultado.Rows.Count);

                        //this.btnEliminar.Enabled = true;
                        //this.btnImprimir.Enabled = true;
                        //this.DGResultado.Enabled = true;
                    }
                    else
                    {
                        //this.Limpiar();

                        ////Se Limpian las Filas y Columnas de la tabla
                        //DGResultado.DataSource = null;
                        //this.DGResultado.Enabled = false;
                        //this.lblTotal.Text = "Datos Registrados: 0";

                        //this.btnEliminar.Enabled = false;
                        //this.btnImprimir.Enabled = false;
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
                    //this.btnGuardar.Enabled = true;
                    //this.btnCancelar.Enabled = true;

                    ////
                    //this.TBIdvehiculo.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Idvehiculos"].Value);
                    //this.TBIDClientes.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Idcliente"].Value);
                    //this.CBCliente.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Cliente"].Value);
                    //this.TBBodega.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Documento"].Value);
                    //this.TBTipo.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Marca"].Value);
                    //this.TBCiudad.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Modelo"].Value);
                    //this.TBTelefono.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Placa"].Value);
                    //this.TBMovil.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Descripcion"].Value);

                    ////Se procede Habilitar los campos de Textos y Botones
                    ////cuando se le realice el evento Clip del Boton Ediatar/Guardar

                    //this.Habilitar();
                    //this.TBTipo.Focus();

                    ////Se cambia la imagen del Boton la cual inicialmente es Guardar
                    ////Y se cambiar por la imagen Editar
                    //this.btnGuardar.Image = Properties.Resources.BV_Editar;
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

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    this.Digitar = false;

                    if (Editar == "1")
                    {
                        //this.btnGuardar.Enabled = true;
                        //this.btnCancelar.Enabled = true;

                        ////
                        //this.TBIdvehiculo.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Idvehiculos"].Value);
                        //this.TBIDClientes.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Idcliente"].Value);
                        //this.CBCliente.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Cliente"].Value);
                        //this.TBBodega.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Documento"].Value);
                        //this.TBTipo.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Marca"].Value);
                        //this.TBCiudad.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Modelo"].Value);
                        //this.TBTelefono.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Placa"].Value);
                        //this.TBMovil.Text = Convert.ToString(this.DGResultado.CurrentRow.Cells["Descripcion"].Value);

                        ////Se procede Habilitar los campos de Textos y Botones
                        ////cuando se le realice el evento Clip del Boton Ediatar/Guardar

                        //this.Habilitar();
                        //this.TBTipo.Focus();

                        ////Se cambia la imagen del Boton la cual inicialmente es Guardar
                        ////Y se cambiar por la imagen Editar
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

        private void BtnGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            if (Digitar)
            {

            }
            this.btnGuardar.Image = Properties.Resources.BV_Guardar;
        }

        private void BtnGuardar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void BtnEliminar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnCancelar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnImprimir_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnImprimir_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnImprimir_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void TBBodega_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBTipo.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBDireccion01.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBBodega.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBTipo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.CBSucurzal.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBDireccion01.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBTipo.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CBSucurzal_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.TBCiudad.Select();
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

                    this.TBTelefono.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBDireccion01.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
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

        private void TBTelefono_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBMovil.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBDireccion01.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBTelefono.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBMovil_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBResponsable.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBDireccion01.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBMovil.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBResponsable_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCorreo.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBDireccion01.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBResponsable.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCorreo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBDireccion01.Select();
                    this.TCPrincipal.SelectedIndex = 1;
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBDireccion01.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBCorreo.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void TBDireccion01_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBDireccion02.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBBodega.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBDireccion01.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBDireccion02_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBMercancia.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBBodega.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBDireccion02.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBMercancia_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBNumeroPC.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBBodega.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBMercancia.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBNumeroPC_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBNumeroCelular.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBBodega.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBNumeroPC.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBNumeroCelular_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBNumeroImpresora.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBBodega.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBNumeroCelular.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBNumeroImpresora_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBObservacion.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBBodega.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBNumeroImpresora.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBObservacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBDireccion01.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBBodega.Select();
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
                            this.Guardar_SQL();

                            //Botones Comunes
                            this.Botones();
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBObservacion.Select();
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
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla TAP se realiza Focus al DataGriview

                    this.DGResultados.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Se procede a limpiar el campo de busqueda y el datagriview
                    this.TBBuscar.Clear();
                    this.DGResultados.DataSource = null;

                    //Seguidamente al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBBodega.Select();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void frmAlmacen_Bodega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
