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
    public partial class frmAlmacen_Cliente : Form
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

        //Parametros para AutoCompletar los Texboxt

        //Panel Datos Basicos
        //public string Idbodega = "";
        //public string Idsucurzal = "";
        //public string Nombre = "";
        //public string Tipo = "";
        //public string Ciudad = "";
        //public string Telefono = "";
        //public string Movil = "";
        //public string Correo = "";
        //public string Responsable = "";

        //Panel Otros Datos
        //public string Direccion01 = "";
        //public string Direccion02 = "";
        //public string Mercancia = "";
        //public string PC = "";
        //public string Celular = "";
        //public string Impresora = "";
        //public string Observacion = "";

        public frmAlmacen_Cliente()
        {
            InitializeComponent();
        }

        private void frmAlmacen_Cliente_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.Botones();
            this.Habilitar();

            //Focus a Texboxt
            this.TBNombre.Select();

            //Ocultacion de Texboxt
            this.TBIdcliente.Visible = false;
            this.DGResultados.Enabled = false;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos  
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
            this.TBIdcliente.Clear();
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
        //        this.TBDepartamento.ValueMember = "Idsucurzal";
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
                    MensajeError("Debe ingresar el nombre de la bodega a registrar");
                    TBNombre.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDocumento.Text == string.Empty)
                {
                    MensajeError("Por favor ingrese el tipo de bodega a registrar");
                    TBDocumento.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBCiudad.Text == string.Empty)
                {
                    MensajeError("Por favor ingrese la ciudad donde se encuentra la bodega");
                    TBCiudad.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBPais.Text == string.Empty)
                {
                    MensajeError("Por favor ingrese el nombre de la persona responsable de la bodega");
                    TBPais.BackColor = Color.FromArgb(250, 235, 215);
                }


                // <<<<<<------ Panel Datos Basicos ------>>>>>

                else if (this.TBDireccion01.Text == string.Empty)
                {
                    MensajeError("Debe ingresar la direccion principal de la bodega");
                    TBDireccion01.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBReceptor.Text == string.Empty)
                {
                    MensajeError("Por favor ingrese la cantidad de equipos celulares que son propiedad de la bodega a registrar");
                    TBReceptor.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDescripcion.Text == string.Empty)
                {
                    MensajeError("Por favor ingrese la cantidad de impresoras que son propiedad de la bodega a registrar");
                    TBDescripcion.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBNumeroPC.Text == string.Empty)
                {
                    MensajeError("Por favor ingrese la cantidad computadores que son propiedad de la bodega a registrar");
                    TBNumeroPC.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.Digitar)
                    {
                        rptaDatosBasicos = fAlmacen_Bodega.Guardar_DatosBasicos

                            (
                                 //Panel Datos Basicos
                                 Convert.ToInt32(this.TBDepartamento.SelectedValue), this.TBNombre.Text, this.TBDocumento.Text,
                                 this.TBCiudad.Text, this.TBTelefono.Text, this.TBMovil.Text, this.TBPais.Text,
                                 this.TBCorreo.Text,

                                 //Panel Otros Datos
                                 this.TBDireccion01.Text, this.TBDireccion02.Text, this.TBDireccionPrincipal.Text, Convert.ToInt32(this.TBNumeroPC.Text),
                                  Convert.ToInt32(this.TBDescripcion.Text), Convert.ToInt32(this.TBReceptor.Text), this.TBObservacion.Text, 1
                            );
                    }

                    else
                    {
                        rptaDatosBasicos = fAlmacen_Bodega.Editar_DatosBasicos

                            (
                                 //Panel Datos Basicos
                                 Convert.ToInt32(this.TBIdcliente.Text), Convert.ToInt32(this.TBDepartamento.SelectedValue), this.TBNombre.Text, this.TBDocumento.Text,
                                 this.TBCiudad.Text, this.TBTelefono.Text, this.TBMovil.Text, this.TBPais.Text,
                                 this.TBCorreo.Text,

                                 //Panel Otros Datos
                                 this.TBDireccion01.Text, this.TBDireccion02.Text, this.TBDireccionPrincipal.Text, Convert.ToInt32(this.TBNumeroPC.Text),
                                  Convert.ToInt32(this.TBDescripcion.Text), Convert.ToInt32(this.TBReceptor.Text), this.TBObservacion.Text, 2
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
                    this.TBNombre.Focus();

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
                            Respuesta = CapaNegocio.fAlmacen_c.Eliminar_DatosBasicos(0, Eliminacion);
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
    }
}
