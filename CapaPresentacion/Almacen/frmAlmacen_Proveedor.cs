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
    public partial class frmAlmacen_Proveedor : Form
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

        //Parametros para AutoCompletar los Texboxt

        //Panel Datos Basicos
        public string Idcliente = "";
        public string Cliente = "";
        public string Documento = "";
        public string Telefono = "";
        public string Movil = "";
        public string Correo = "";
        public string Pais = "";
        public string Ciudad = "";
        public string Departamento = "";

        //Panel Datos de Envio
        public string Pais_DE = "";
        public string Ciudad_DE = "";
        public string DireccionPrincipal = "";
        public string Direccion01 = "";
        public string Direccion02 = "";
        public string Receptor = "";
        public string Descripcion = "";

        //Panel Datos Financiero
        public string BancoPrincipal = "";
        public string BancoAuxiliar = "";
        public string Cuenta01 = "";
        public string Cuenta02 = "";
        public string CreditoMinimo = "";
        public string CreditoMaximo = "";
        public string UltimoCredito = "";
        public string Mora = "";
        public string TotalCredito = "";
        public frmAlmacen_Proveedor()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Proveedor_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();

            //Focus a Texboxt
            this.TBNombre.Select();

            //Ocultacion de Texboxt
            this.TBIdproveedor.Visible = false;
            this.DGResultados.Enabled = false;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos  
            //this.TBCodigo.Enabled = false;

            this.TBNombre.ReadOnly = false;
            this.TBNombre.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDocumento.ReadOnly = false;
            this.TBDocumento.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCiudad.ReadOnly = false;
            this.TBCiudad.BackColor = Color.FromArgb(32, 178, 170);
            this.TBTelefono.ReadOnly = false;
            this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
            this.TBMovil.ReadOnly = false;
            this.TBMovil.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCorreo.ReadOnly = false;
            this.TBCorreo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDepartamento.ReadOnly = false;
            this.TBDepartamento.BackColor = Color.FromArgb(32, 178, 170);

            this.TBPais.ReadOnly = false;
            this.TBPais.BackColor = Color.FromArgb(32, 178, 170);


            //Panel - Otros Datos
            this.TBPais_01.ReadOnly = false;
            this.TBPais_01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCiudad_01.ReadOnly = false;
            this.TBCiudad_01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccionPrincipal.ReadOnly = false;
            this.TBDireccionPrincipal.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccion01.ReadOnly = false;
            this.TBDireccion01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccion02.ReadOnly = false;
            this.TBDireccion02.BackColor = Color.FromArgb(32, 178, 170);
            this.TBReceptor.ReadOnly = false;
            this.TBReceptor.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDescripcion.ReadOnly = false;
            this.TBDescripcion.BackColor = Color.FromArgb(32, 178, 170);

            //
            this.TBBancoPrincipal.ReadOnly = false;
            this.TBBancoPrincipal.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCuenta01.ReadOnly = false;
            this.TBCuenta01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCuenta02.ReadOnly = false;
            this.TBCuenta02.BackColor = Color.FromArgb(32, 178, 170);
            this.TBBancoAuxiliar.ReadOnly = false;
            this.TBBancoAuxiliar.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCreditoMinimo.ReadOnly = false;
            this.TBCreditoMinimo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCreditoMaximo.ReadOnly = false;
            this.TBCreditoMaximo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBUltimoCredito.ReadOnly = false;
            this.TBUltimoCredito.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCreditoMora.ReadOnly = false;
            this.TBCreditoMora.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCreditoTotal.ReadOnly = false;
            this.TBCreditoTotal.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Limpiar()
        {
            //Panel - Datos Basicos
            this.TBIdproveedor.Clear();
            this.TBNombre.Clear();
            this.TBDocumento.Clear();
            this.TBCiudad.Clear();
            this.TBTelefono.Clear();
            this.TBMovil.Clear();
            this.TBPais.Clear();
            this.TBCorreo.Clear();

            //Panel - Otros Datos
            this.TBDireccion01.Clear();
            this.TBDireccion02.Clear();
            this.TBDireccionPrincipal.Clear();
            this.TBReceptor.Clear();
            this.TBDescripcion.Clear();


            //
            this.TBBancoPrincipal.Clear();
            this.TBCuenta01.Clear();
            this.TBCuenta02.Clear();
            this.TBBancoAuxiliar.Clear();
            this.TBCreditoMinimo.Clear();
            this.TBCreditoMaximo.Clear();
            this.TBCreditoMaximo.Clear();
            this.TBUltimoCredito.Clear();
            this.TBCreditoMora.Clear();
            this.TBCreditoTotal.Clear();
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

        //private void Combobox_Sucurzal()
        //{
        //    try
        //    {
        //        this.TBDepartamento.DataSource = fSistema_Sucurzal.Mostrar();
        //        this.TBDepartamento.ValueMember = "Cliente";
        //        this.TBDepartamento.DisplayMember = "Nombre";
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message + ex.StackTrace);
        //    }
        //}

        private void Guardar_SQL()
        {
            try
            {
                string rptaDatosBasicos = "";

                // <<<<<<------ Panel Datos Basicos ------>>>>>

                if (this.TBNombre.Text == string.Empty)
                {
                    MensajeError("Debe ingresar el nombre del cliente a registrar");
                    TBNombre.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDocumento.Text == string.Empty)
                {
                    MensajeError("Por favor el numero de documento del cliente a registrar");
                    TBDocumento.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCiudad.Text == string.Empty)
                {
                    MensajeError("Por favor ingrese una Ciudad");
                    TBCiudad.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBPais.Text == string.Empty)
                {
                    MensajeError("Por favor ingrese un Pais");
                    TBPais.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.Digitar)
                    {
                        rptaDatosBasicos = fAlmacen_Cliente.Guardar_DatosBasicos

                            (
                                 //Panel Datos Basicos
                                 this.TBNombre.Text, this.TBDocumento.Text, this.TBTelefono.Text, this.TBMovil.Text,
                                 this.TBCorreo.Text, this.TBPais.Text, this.TBCiudad.Text, this.TBDepartamento.Text,

                                 //Panel Datos De Envio
                                 this.TBPais_01.Text, this.TBCiudad_01.Text, this.TBDireccionPrincipal.Text, this.TBDireccion01.Text,
                                 this.TBDireccion02.Text, this.TBReceptor.Text, this.TBDescripcion.Text,

                                //Panel Datos Financieros
                                this.TBBancoPrincipal.Text, this.TBBancoAuxiliar.Text, this.TBCuenta01.Text, this.TBCuenta02.Text,
                                this.TBCreditoMinimo.Text, this.TBCreditoMaximo.Text, this.TBUltimoCredito.Text, this.TBCreditoMora.Text,
                                this.TBCreditoTotal.Text, 1
                            );
                    }

                    else
                    {
                        rptaDatosBasicos = fAlmacen_Cliente.Editar_DatosBasicos

                            (
                                 //Panel Datos Basicos
                                 Convert.ToInt32(this.TBIdproveedor.Text), this.TBNombre.Text, this.TBDocumento.Text, this.TBTelefono.Text, this.TBMovil.Text,
                                 this.TBCorreo.Text, this.TBPais.Text, this.TBCiudad.Text, this.TBDepartamento.Text,

                                 //Panel Datos De Envio
                                 this.TBPais_01.Text, this.TBCiudad_01.Text, this.TBDireccionPrincipal.Text, this.TBDireccion01.Text,
                                 this.TBDireccion02.Text, this.TBReceptor.Text, this.TBDescripcion.Text,

                                //Panel Datos Financieros
                                this.TBBancoPrincipal.Text, this.TBBancoAuxiliar.Text, this.TBCuenta01.Text, this.TBCuenta02.Text,
                                this.TBCreditoMinimo.Text, this.TBCreditoMaximo.Text, this.TBUltimoCredito.Text, this.TBCreditoMora.Text,
                                this.TBCreditoTotal.Text, 2
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
                    this.Habilitar();
                    this.Botones();
                    this.Limpiar();

                    //
                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Eliminar == "1")
                {

                    DialogResult Opcion;
                    string Respuesta = "";
                    int Eliminacion;

                    Opcion = MessageBox.Show("Desea Eliminar el Registro Seleccionado", "Leal Enterprise", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        if (DGResultados.SelectedRows.Count > 0)
                        {
                            Eliminacion = Convert.ToInt32(DGResultados.CurrentRow.Cells["Codigo"].Value.ToString());
                            Respuesta = CapaNegocio.fAlmacen_Cliente.Eliminar_DatosBasicos(0, Eliminacion);
                        }

                        if (Respuesta.Equals("OK"))
                        {
                            this.MensajeOk("Registro Eliminado Correctamente");
                        }
                        else
                        {
                            this.MensajeError(Respuesta);
                        }

                        //Botones Comunes
                        this.Digitar = true;
                        this.TBBuscar.Clear();
                        this.Botones();

                        //Se regresa el focus al campo principal
                        this.TCPrincipal.SelectedIndex = 0;
                        this.TBNombre.Select();
                    }
                }
                else
                {
                    MessageBox.Show("Acceso Denegado Para Realizar Eliminaciones en el Sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        this.DGResultados.DataSource = fAlmacen_Cliente.Buscar_Cliente(1, this.TBBuscar.Text);
                        //this.DGResultados.Columns[1].Visible = false;

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
                    //
                    this.TBIdproveedor.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                    this.TBNombre.Select();

                    //Se procede Habilitar los campos de Textos y Botones
                    //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                    this.Habilitar();
                    this.btnGuardar.Enabled = true;
                    this.btnCancelar.Enabled = true;

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
                        //
                        this.TBIdproveedor.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        this.TBNombre.Select();

                        //Se procede Habilitar los campos de Textos y Botones
                        //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                        this.Habilitar();
                        this.btnGuardar.Enabled = true;
                        this.btnCancelar.Enabled = true;

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

        private void CBTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CBRetencion_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CBMoneda_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void TBIdproveedor_TextChanged(object sender, EventArgs e)
        {
            try
            //SE REALIZA LA CONSULTA A LA BASE DE DATOS POR MEDIO DEL Idcliente
            //Y ASI AUTOCOMPLETAR LOS CAMPOS DE TEXTOS NECESARIOS O CONSULTADOS
            {

                // ENVIAN LOS DATOS A LA BASE DE DATOS Y SE EVALUAN QUE EXISTEN O ESTEN REGISTRADOS

                DataTable Datos = CapaNegocio.fAlmacen_Cliente.Buscar_Cliente(2, this.TBIdproveedor.Text);
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //Panel Datos Basicos
                    Cliente = Datos.Rows[0][0].ToString();
                    Documento = Datos.Rows[0][0].ToString();
                    Telefono = Datos.Rows[0][0].ToString();
                    Movil = Datos.Rows[0][0].ToString();
                    Correo = Datos.Rows[0][0].ToString();
                    Pais = Datos.Rows[0][0].ToString();
                    Ciudad = Datos.Rows[0][0].ToString();
                    Departamento = Datos.Rows[0][0].ToString();

                    //Panel Datos de Envio
                    Pais_DE = Datos.Rows[0][0].ToString();
                    Ciudad_DE = Datos.Rows[0][0].ToString();
                    DireccionPrincipal = Datos.Rows[0][0].ToString();
                    Direccion01 = Datos.Rows[0][0].ToString();
                    Direccion02 = Datos.Rows[0][0].ToString();
                    Receptor = Datos.Rows[0][0].ToString();
                    Descripcion = Datos.Rows[0][0].ToString();

                    //Panel Datos Financiero
                    BancoPrincipal = Datos.Rows[0][0].ToString();
                    BancoAuxiliar = Datos.Rows[0][0].ToString();
                    Cuenta01 = Datos.Rows[0][0].ToString();
                    Cuenta02 = Datos.Rows[0][0].ToString();
                    CreditoMinimo = Datos.Rows[0][0].ToString();
                    CreditoMaximo = Datos.Rows[0][0].ToString();
                    UltimoCredito = Datos.Rows[0][0].ToString();
                    Mora = Datos.Rows[0][0].ToString();
                    TotalCredito = Datos.Rows[0][0].ToString();


                    //SE PROCEDE A LLENAR LOS CAMPOS DE TEXTO SEGUN LA CONSULTA REALIZADA

                    this.TBNombre.Text = Cliente;
                    this.TBDocumento.Text = Documento;
                    this.TBTelefono.Text = Telefono;
                    this.TBMovil.Text = Movil;
                    this.TBCorreo.Text = Correo;
                    this.TBPais.Text = Pais;
                    this.TBCiudad.Text = Ciudad;
                    this.TBDepartamento.Text = Departamento;

                    //
                    this.TBPais_01.Text = Pais_DE;
                    this.TBCiudad_01.Text = Ciudad_DE;
                    this.TBDireccion01.Text = Direccion01;
                    this.TBDireccion02.Text = Direccion02;
                    this.TBReceptor.Text = Receptor;
                    this.TBDescripcion.Text = Descripcion;

                    //
                    this.TBBancoPrincipal.Text = BancoPrincipal;
                    this.TBBancoAuxiliar.Text = BancoAuxiliar;
                    this.TBCuenta01.Text = Cuenta01;
                    this.TBCuenta02.Text = Cuenta02;
                    this.TBCreditoMinimo.Text = CreditoMinimo;
                    this.TBCreditoMaximo.Text = CreditoMaximo;
                    this.TBUltimoCredito.Text = UltimoCredito;
                    this.TBCreditoMora.Text = Mora;
                    this.TBCreditoTotal.Text = TotalCredito;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBNombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBDocumento.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 1;
                    this.TBPais_01.Select();
                }
                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar las teclas Control+Enter se realizara el registro en la base de datos
                    //Y se realizara las validaciones en el sistema

                    if (Digitar)
                    {
                        DialogResult result = MessageBox.Show("¿Desea registrar los campos digitados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            if (Guardar == "1")
                            {
                                //Clases y Focus
                                this.Guardar_SQL();
                                this.TBNombre.Select();
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBNombre.Select();
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Desea Actualizar los campos consultados?", "Leal Enterprise", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Clases y Focus
                            this.Guardar_SQL();
                            this.TBNombre.Select();
                        }
                        else
                        {
                            this.TBNombre.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBDocumento_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBResponsable_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBPais_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCiudad_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBNacionalidad_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBTelefono_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBMovil_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCorreo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBPais_01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCiudad_01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDireccionPrincipal_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDireccion01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDireccion02_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBReceptor_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox12_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBBancoPrincipal_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCuenta01_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBBancoAuxiliar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCuenta02_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCreditoMinimo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCreditoMaximo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBUltimoCredito_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCreditoMora_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBCreditoTotal_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void TBDiasProrroga_KeyUp(object sender, KeyEventArgs e)
        {

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
            this.btnEliminar.Image = Properties.Resources.BR_Eliminar;
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
    }
}
