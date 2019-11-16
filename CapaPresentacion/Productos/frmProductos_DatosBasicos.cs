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

        //Parametros para AutoCompletar los Texboxt

        //Panel Datos Basicos
        public string Idproveedor = "";
        public string Proveedor = "";
        public string Documento = "";
        public string Representante = "";
        public string Telefono = "";
        public string Movil = "";
        public string Correo = "";
        public string Pais = "";
        public string Ciudad = "";
        public string Nacionalidad = "";
        public string FechaDeInicio = "";

        //Panel Datos de Envio
        public string Pais_DE = "";
        public string Ciudad_DE = "";
        public string DireccionPrincipal = "";
        public string Direccion01 = "";
        public string Direccion02 = "";
        public string Receptor = "";
        public string Observacion = "";

        //Panel Datos Financiero
        public string Retencion = "";
        public string Valor_Retencion = "";
        public string Moneda = "";
        public string BancoPrincipal = "";
        public string BancoAuxiliar = "";
        public string Cuenta01 = "";
        public string Cuenta02 = "";
        public string CreditoMinimo = "";
        public string CreditoMaximo = "";
        public string UltimoCredito = "";
        public string Mora = "";
        public string TotalCredito = "";
        public string Prorroga = "";

        public frmProductos_DatosBasicos()
        {
            InitializeComponent();
        }

        private void FrmProductos_DatosBasicos_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();

            //Panel 01
            //this.CBMarca.SelectedIndex = 0;
            this.CBGrupo.SelectedIndex = 0;
            this.CBTipo.SelectedIndex = 0;
            this.CBBalanza.SelectedIndex = 0;
            this.CBVence.SelectedIndex = 0;

            //Panel 02
            this.CBUnidad.SelectedIndex = 0;
            this.CBVentaPublico.SelectedIndex = 0;

            //Panel 05
            //this.CBBodega.SelectedIndex = 0;
            this.CBOrigen.SelectedIndex = 0;
            this.CBEmpaque.SelectedIndex = 0;
            
            //Focus a Texboxt
            this.TBNombre.Select();

            //Ocultacion de Texboxt
            this.TBIdproducto.Visible = false;
            this.DGResultados.Enabled = false;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos  
            this.TBNombre.ReadOnly = false;
            this.TBNombre.BackColor = Color.FromArgb(32, 178, 170);
            this.TBReferencia.ReadOnly = false;
            this.TBReferencia.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDescripcion01.ReadOnly = false;
            this.TBDescripcion01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDescripcion02.ReadOnly = false;
            this.TBDescripcion02.BackColor = Color.FromArgb(32, 178, 170);
            this.TBLotedeingreso.ReadOnly = false;
            this.TBLotedeingreso.BackColor = Color.FromArgb(32, 178, 170);
            this.TBPresentacion.ReadOnly = false;
            this.TBPresentacion.BackColor = Color.FromArgb(32, 178, 170);

            //
            this.TBUltimovalor.ReadOnly = false;
            this.TBUltimovalor.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorFinal.ReadOnly = false;
            this.TBValorFinal.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValorPromedio.ReadOnly = false;
            this.TBValorPromedio.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValor01.ReadOnly = false;
            this.TBValor01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValor02.ReadOnly = false;
            this.TBValor02.BackColor = Color.FromArgb(32, 178, 170);
            this.TBValor03.ReadOnly = false;
            this.TBValor03.BackColor = Color.FromArgb(32, 178, 170);
            this.TBOferta01.ReadOnly = false;
            this.TBOferta01.BackColor = Color.FromArgb(32, 178, 170);
            this.TBOferta02.ReadOnly = false;
            this.TBOferta02.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBReceptor.ReadOnly = false;
            //this.TBReceptor.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBObservacion.ReadOnly = false;
            //this.TBObservacion.BackColor = Color.FromArgb(32, 178, 170);

            //
            //this.TBValorRetencion.ReadOnly = false;
            //this.TBValorRetencion.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBBancoPrincipal.ReadOnly = false;
            //this.TBBancoPrincipal.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBCuenta01.ReadOnly = false;
            //this.TBCuenta01.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBCuenta02.ReadOnly = false;
            //this.TBCuenta02.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBBancoAuxiliar.ReadOnly = false;
            //this.TBBancoAuxiliar.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBCreditoMinimo.ReadOnly = false;
            //this.TBCreditoMinimo.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBCreditoMaximo.ReadOnly = false;
            //this.TBCreditoMaximo.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBUltimoCredito.ReadOnly = false;
            //this.TBUltimoCredito.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBCreditoMora.ReadOnly = false;
            //this.TBCreditoMora.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBCreditoTotal.ReadOnly = false;
            //this.TBCreditoTotal.BackColor = Color.FromArgb(32, 178, 170);
            //this.TBDiasProrroga.ReadOnly = false;
            //this.TBDiasProrroga.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Limpiar()
        {
            //Panel - Datos Basicos
            this.TBIdproducto.Clear();
            this.CBTipo.SelectedIndex = 0;
            this.TBNombre.Clear();
            this.TBReferencia.Clear();
            this.TBDescripcion01.Clear();
            this.TBLotedeingreso.Clear();
            this.TBUltimovalor.Clear();
            this.TBValorFinal.Clear();
            this.TBDescripcion02.Clear();
            this.TBPresentacion.Clear();
            this.TBValorPromedio.Clear();

            //Panel - Datos de Envio
            this.TBValor01.Clear();
            this.TBValor02.Clear();
            this.TBValor03.Clear();
            this.TBOferta02.Clear();
            this.TBOferta01.Clear();
            //this.TBReceptor.Clear();
            //this.TBObservacion.Clear();


            //Datos Financieros
            //this.CBMoneda.SelectedIndex = 0;
            //this.CBRetencion.SelectedIndex = 0;
            //this.TBValorRetencion.Clear();
            //this.TBBancoPrincipal.Clear();
            //this.TBCuenta01.Clear();
            //this.TBCuenta02.Clear();
            //this.TBBancoAuxiliar.Clear();
            //this.TBCreditoMinimo.Clear();
            //this.TBCreditoMaximo.Clear();
            //this.TBCreditoMaximo.Clear();
            //this.TBUltimoCredito.Clear();
            //this.TBCreditoMora.Clear();
            //this.TBCreditoTotal.Clear();
            //this.TBDiasProrroga.Clear();
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
        //        this.TBDescripcion01.DataSource = fSistema_Sucurzal.Mostrar();
        //        this.TBDescripcion01.ValueMember = "Cliente";
        //        this.TBDescripcion01.DisplayMember = "Nombre";
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
                    MensajeError("Debe ingresar el nombre del proveedor");
                    TBNombre.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBReferencia.Text == string.Empty)
                {
                    MensajeError("Por favor el numero de documento del proveedor");
                    TBReferencia.BackColor = Color.FromArgb(250, 235, 215);
                }
                //else if (this.TBDescripcion01.Text == string.Empty)
                //{
                //    MensajeError("Por favor ingrese el nombre del representante del Proveedor");
                //    TBDescripcion01.BackColor = Color.FromArgb(250, 235, 215);
                //}

                else
                {
                    if (this.Digitar)
                    {
                        //rptaDatosBasicos = fAlmacen_Proveedor.Guardar_DatosBasicos

                        //    (
                        //        // //Panel Datos Basicos
                        //        // this.CBTipo.Text, this.TBNombre.Text, this.TBReferencia.Text, this.TBDescripcion01.Text, this.TBDescripcion02.Text,
                        //        // this.TBLotedeingreso.Text, this.TBPresentacion.Text, this.TBUltimovalor.Text, this.TBValorFinal.Text, this.TBValorPromedio.Text, this.DTFechadeinicio.Value,

                        //        // //Panel Datos De Envio
                        //        // this.TBValor01.Text, this.TBValor02.Text, this.TBValor03.Text, this.TBOferta01.Text,
                        //        // this.TBOferta02.Text, this.TBReceptor.Text, this.TBObservacion.Text,

                        //        ////Panel Datos Financieros
                        //        //this.CBRetencion.Text, this.TBValorRetencion.Text, this.TBBancoPrincipal.Text, this.TBBancoAuxiliar.Text, this.TBCuenta01.Text, this.TBCuenta02.Text,
                        //        //this.TBCreditoMinimo.Text, this.TBCreditoMaximo.Text, this.TBUltimoCredito.Text, this.TBCreditoMora.Text,
                        //        //this.TBCreditoTotal.Text, 1
                        //    );
                    }

                    else
                    {
                        //rptaDatosBasicos = fAlmacen_Proveedor.Editar_DatosBasicos

                        //    (
                        //        // //Panel llave principal
                        //        // Convert.ToInt32(this.TBIdproveedor.Text),

                        //        // //Panel Datos Basicos
                        //        // this.CBTipo.Text, this.TBNombre.Text, this.TBReferencia.Text, this.TBDescripcion01.Text, this.TBDescripcion02.Text,
                        //        // this.TBLotedeingreso.Text, this.TBPresentacion.Text, this.TBUltimovalor.Text, this.TBValorFinal.Text, this.TBValorPromedio.Text, this.DTFechadeinicio.Value,

                        //        // //Panel Datos De Envio
                        //        // this.TBValor01.Text, this.TBValor02.Text, this.TBValor03.Text, this.TBOferta01.Text,
                        //        // this.TBOferta02.Text, this.TBReceptor.Text, this.TBObservacion.Text,

                        //        ////Panel Datos Financieros
                        //        //this.CBRetencion.Text, this.TBValorRetencion.Text, this.TBBancoPrincipal.Text, this.TBBancoAuxiliar.Text, this.TBCuenta01.Text, this.TBCuenta02.Text,
                        //        //this.TBCreditoMinimo.Text, this.TBCreditoMaximo.Text, this.TBUltimoCredito.Text, this.TBCreditoMora.Text,
                        //        //this.TBCreditoTotal.Text, 2
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
                    this.Habilitar();
                    this.Botones();
                    this.Limpiar();

                    //
                    this.TCPanelPrincipal.SelectedIndex = 0;
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

        private void BtnCancelar_Click(object sender, EventArgs e)
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

        private void BtnEliminar_Click(object sender, EventArgs e)
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
                            Respuesta = CapaNegocio.fAlmacen_Proveedor.Eliminar_DatosBasicos(0, Eliminacion);
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
                        this.TCPanelPrincipal.SelectedIndex = 0;
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
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        this.DGResultados.DataSource = fAlmacen_Proveedor.Buscar_Proveedor(1, this.TBBuscar.Text);
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

        private void TBBuscar_Impuesto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        this.DGResultados.DataSource = fAlmacen_Proveedor.Buscar_Proveedor(1, this.TBBuscar.Text);
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

        private void TBBuscar_Proveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar == "1")
                {
                    if (TBBuscar.Text != "")
                    {
                        this.DGResultados.DataSource = fAlmacen_Proveedor.Buscar_Proveedor(1, this.TBBuscar.Text);
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
                    this.TBIdproducto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
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

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                //if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                //{
                //    this.Digitar = false;

                //    if (Editar == "1")
                //    {
                //        //
                //        this.TBIdproducto.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                //        this.TBNombre.Select();

                //        //Se procede Habilitar los campos de Textos y Botones
                //        //cuando se le realice el evento Clip del Boton Ediatar/Guardar

                //        this.Habilitar();
                //        this.btnGuardar.Enabled = true;
                //        this.btnCancelar.Enabled = true;

                //        //Se cambia la imagen del Boton la cual inicialmente es Guardar
                //        //Y se cambiar por la imagen Editar
                //        this.btnGuardar.Image = Properties.Resources.BV_Editar;
                //    }
                //    else
                //    {
                //        MessageBox.Show("Acceso denegado para actualizar registros", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void PB_Imagen_Click(object sender, EventArgs e)
        {

        }

        private void TBIdproducto_TextChanged(object sender, EventArgs e)
        {
            try
            //SE REALIZA LA CONSULTA A LA BASE DE DATOS POR MEDIO DEL Idcliente
            //Y ASI AUTOCOMPLETAR LOS CAMPOS DE TEXTOS NECESARIOS O CONSULTADOS
            {

                // ENVIAN LOS DATOS A LA BASE DE DATOS Y SE EVALUAN QUE EXISTEN O ESTEN REGISTRADOS

                DataTable Datos = CapaNegocio.fAlmacen_Proveedor.Buscar_Proveedor(2, this.TBIdproducto.Text);
                //Evaluamos si  existen los Datos
                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros en la base de datos", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //Panel Datos Basicos
                    Proveedor = Datos.Rows[0][0].ToString();
                    Documento = Datos.Rows[0][0].ToString();
                    Telefono = Datos.Rows[0][0].ToString();
                    Movil = Datos.Rows[0][0].ToString();
                    Correo = Datos.Rows[0][0].ToString();
                    Pais = Datos.Rows[0][0].ToString();
                    Ciudad = Datos.Rows[0][0].ToString();
                    Nacionalidad = Datos.Rows[0][0].ToString();

                    //Panel Datos de Envio
                    Pais_DE = Datos.Rows[0][0].ToString();
                    Ciudad_DE = Datos.Rows[0][0].ToString();
                    DireccionPrincipal = Datos.Rows[0][0].ToString();
                    Direccion01 = Datos.Rows[0][0].ToString();
                    Direccion02 = Datos.Rows[0][0].ToString();
                    Receptor = Datos.Rows[0][0].ToString();
                    Observacion = Datos.Rows[0][0].ToString();

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

                    this.TBNombre.Text = Proveedor;
                    this.TBReferencia.Text = Documento;
                    this.TBUltimovalor.Text = Telefono;
                    this.TBValorFinal.Text = Movil;
                    this.TBValorPromedio.Text = Correo;
                    this.TBDescripcion02.Text = Pais;
                    this.TBLotedeingreso.Text = Ciudad;
                    this.TBDescripcion01.Text = Representante;

                    //
                    this.TBValor01.Text = Pais_DE;
                    this.TBValor02.Text = Ciudad_DE;
                    this.TBOferta01.Text = Direccion01;
                    this.TBOferta02.Text = Direccion02;
                    //this.TBReceptor.Text = Receptor;
                    //this.TBObservacion.Text = Observacion;

                    ////
                    //this.TBBancoPrincipal.Text = BancoPrincipal;
                    //this.TBBancoAuxiliar.Text = BancoAuxiliar;
                    //this.TBCuenta01.Text = Cuenta01;
                    //this.TBCuenta02.Text = Cuenta02;
                    //this.TBCreditoMinimo.Text = CreditoMinimo;
                    //this.TBCreditoMaximo.Text = CreditoMaximo;
                    //this.TBUltimoCredito.Text = UltimoCredito;
                    //this.TBCreditoMora.Text = Mora;
                    //this.TBCreditoTotal.Text = TotalCredito;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void TBCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBReferencia.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPanelPrincipal.SelectedIndex = 1;
                    this.TBValor01.Select();
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
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValorFinal.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPanelPrincipal.SelectedIndex = 1;
                    this.TBUltimovalor.Select();
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
                            this.TBPresentacion.Select();
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
                            this.TBPresentacion.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBUltimovalor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBValorFinal.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPanelPrincipal.SelectedIndex = 2;
                    this.TBBuscar_Impuesto.Select();
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
                            this.TBUltimovalor.Select();
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
                            this.TBUltimovalor.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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
        private void CBMarca_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CBGrupo_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CBTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CBBalanza_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CBVence_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CBUnidad_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CBVentaPublico_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CBOrigen_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CBEmpaque_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
        
        private void CBBodega_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BtnGuardar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void BtnCancelar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BtnCancelar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void BtnEliminar_Impuesto_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BtnEliminar_Impuesto_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Impuesto_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void BtnEliminar_Proveedor_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BtnEliminar_Proveedor_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Proveedor_MouseMove(object sender, MouseEventArgs e)
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

        private void BtnImprimir_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BtnImprimir_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnImprimir_MouseMove(object sender, MouseEventArgs e)
        {

        }

    }
}
