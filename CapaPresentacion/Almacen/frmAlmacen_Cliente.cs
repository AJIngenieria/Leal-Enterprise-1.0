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
        private string Campo = "Campo Obligatorio - Leal Enterprise";

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
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos  
            //this.TBCodigo.Enabled = false;

            this.TBNombre.ReadOnly = false;
            this.TBNombre.BackColor = Color.FromArgb(3, 155, 229);
            this.TBNombre.Text = Campo;
            this.TBDocumento.ReadOnly = false;
            this.TBDocumento.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDocumento.Text = Campo;
            this.TBCiudad.ReadOnly = false;
            this.TBCiudad.BackColor = Color.FromArgb(3, 155, 229);
            this.TBTelefono.ReadOnly = false;
            this.TBTelefono.BackColor = Color.FromArgb(3, 155, 229);
            this.TBMovil.ReadOnly = false;
            this.TBMovil.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCorreo.ReadOnly = false;
            this.TBCorreo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDepartamento.ReadOnly = false;
            this.TBDepartamento.BackColor = Color.FromArgb(3, 155, 229);

            this.TBPais.ReadOnly = false;
            this.TBPais.BackColor = Color.FromArgb(3, 155, 229);


            //Panel - Otros Datos
            this.TBPais_01.ReadOnly = false;
            this.TBPais_01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCiudad_01.ReadOnly = false;
            this.TBCiudad_01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDireccionPrincipal.ReadOnly = false;
            this.TBDireccionPrincipal.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDireccion01.ReadOnly = false;
            this.TBDireccion01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDireccion02.ReadOnly = false;
            this.TBDireccion02.BackColor = Color.FromArgb(3, 155, 229);
            this.TBReceptor.ReadOnly = false;
            this.TBReceptor.BackColor = Color.FromArgb(3, 155, 229);
            this.TBDescripcion.ReadOnly = false;
            this.TBDescripcion.BackColor = Color.FromArgb(3, 155, 229);

            //
            this.TBBancoPrincipal.ReadOnly = false;
            this.TBBancoPrincipal.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCuenta01.ReadOnly = false;
            this.TBCuenta01.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCuenta02.ReadOnly = false;
            this.TBCuenta02.BackColor = Color.FromArgb(3, 155, 229);
            this.TBBancoAuxiliar.ReadOnly = false;
            this.TBBancoAuxiliar.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCreditoMinimo.ReadOnly = false;
            this.TBCreditoMinimo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCreditoMaximo.ReadOnly = false;
            this.TBCreditoMaximo.BackColor = Color.FromArgb(3, 155, 229);
            this.TBUltimoCredito.ReadOnly = false;
            this.TBUltimoCredito.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCreditoMora.ReadOnly = false;
            this.TBCreditoMora.BackColor = Color.FromArgb(3, 155, 229);
            this.TBCreditoTotal.ReadOnly = false;
            this.TBCreditoTotal.BackColor = Color.FromArgb(3, 155, 229);
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

        private void Guardar_SQL()
        {
            try
            {
                string rptaDatosBasicos = "";

                // <<<<<<------ Panel Datos Basicos ------>>>>>

                if (this.TBNombre.Text == Campo)
                {
                    MensajeError("Debe ingresar el nombre del cliente a registrar");
                }
                else if (this.TBDocumento.Text == Campo)
                {
                    MensajeError("Por favor el numero de documento del cliente a registrar");
                }
                else if (this.TBCiudad.Text == Campo)
                {
                    MensajeError("Por favor ingrese una Ciudad");
                }
                else if (this.TBPais.Text == Campo)
                {
                    MensajeError("Por favor ingrese un Pais");
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
                                 Convert.ToInt32(this.TBIdcliente.Text), this.TBNombre.Text, this.TBDocumento.Text, this.TBTelefono.Text, this.TBMovil.Text,
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


        private void TBIdcliente_TextChanged(object sender, EventArgs e)
        {
            try
            //SE REALIZA LA CONSULTA A LA BASE DE DATOS POR MEDIO DEL Idcliente
            //Y ASI AUTOCOMPLETAR LOS CAMPOS DE TEXTOS NECESARIOS O CONSULTADOS
            {

                // ENVIAN LOS DATOS A LA BASE DE DATOS Y SE EVALUAN QUE EXISTEN O ESTEN REGISTRADOS

                DataTable Datos = CapaNegocio.fAlmacen_Cliente.Buscar_Cliente(2, this.TBIdcliente.Text);
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
                    this.TBIdcliente.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
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
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    this.Digitar = false;

                    if (Editar == "1")
                    {
                        //
                        this.TBIdcliente.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
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
                            this.TBDocumento.Select();
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
                            this.TBDocumento.Select();
                        }
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
                            this.TBTelefono.Select();
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
                            this.TBTelefono.Select();
                        }
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

                    this.TBCorreo.Select();
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
                            this.TBMovil.Select();
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
                            this.TBMovil.Select();
                        }
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

                    this.TBPais.Select();
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
                            this.TBCorreo.Select();
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
                            this.TBCorreo.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBPais_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCiudad.Select();
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
                            this.TBPais.Select();
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
                            this.TBPais.Select();
                        }
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

                    this.TBDepartamento.Select();
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
                            this.TBCiudad.Select();
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
                            this.TBCiudad.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBDepartamento_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBNombre.Select();
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
                            this.TBDepartamento.Select();
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
                            this.TBDepartamento.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBPais_01_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCiudad_01.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBBancoPrincipal.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBPais_01.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBPais_01.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCiudad_01_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBDireccionPrincipal.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBBancoPrincipal.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBCiudad_01.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBCiudad_01.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBDireccionPrincipal_KeyUp(object sender, KeyEventArgs e)
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

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBBancoPrincipal.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBDireccionPrincipal.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBDireccionPrincipal.Select();
                        }
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

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBBancoPrincipal.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBDireccion01.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBDireccion01.Select();
                        }
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

                    this.TBReceptor.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBBancoPrincipal.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBDireccion02.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBDireccion02.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBReceptor_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBDescripcion.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBBancoPrincipal.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBReceptor.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBReceptor.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBDescripcion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBPais_01.Focus();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 2;
                    this.TBBancoPrincipal.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBDescripcion.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBDescripcion.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBBancoPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCuenta01.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBBancoPrincipal.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBBancoPrincipal.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCuenta01_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBBancoAuxiliar.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBCuenta01.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBCuenta01.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBBancoAuxiliar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCuenta02.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBBancoAuxiliar.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBBancoAuxiliar.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCuenta02_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCreditoMinimo.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBCuenta02.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBCuenta02.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCreditoMinimo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCreditoMaximo.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBCreditoMinimo.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBCreditoMinimo.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCreditoMaximo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBUltimoCredito.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBCreditoMaximo.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBCreditoMaximo.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBUltimoCredito_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCreditoMora.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBUltimoCredito.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBUltimoCredito.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCreditoMora_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBCreditoTotal.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBCreditoMora.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBCreditoMora.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBCreditoTotal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Enter))
                {
                    //Al precionar la tecla Enter se realiza Focus al Texboxt Siguiente

                    this.TBBancoPrincipal.Select();
                }

                else if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.Tab))
                {
                    //Al precionar la tecla Control+TAB Se cambia las pestaña del TapControl
                    //Y se realiza Focus al primer Texboxt de la segunda pestaña del TapControl

                    this.TCPrincipal.SelectedIndex = 0;
                    this.TBNombre.Select();
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

                                this.TCPrincipal.SelectedIndex = 0;
                            }
                            else
                            {
                                MessageBox.Show("El usuario iniciado no contiene permisos para Guardar datos en el sistema datos en el sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            this.TBCreditoTotal.Select();
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

                            this.TCPrincipal.SelectedIndex = 0;
                        }
                        else
                        {
                            this.TBCreditoTotal.Select();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void TBNombre_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio 
            //Porque debe estar con datos digitados
            //Y es obligatorio en la base de datos
            if (TBNombre.Text == Campo)
            {
                this.TBNombre.BackColor = Color.Azure;
                this.TBNombre.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBNombre.Clear();
            }
        }

        private void TBDocumento_Enter(object sender, EventArgs e)
        {
            //Se evalua si el campo de texto esta vacio 
            //Porque debe estar con datos digitados
            //Y es obligatorio en la base de datos
            if (TBDocumento.Text == Campo)
            {
                this.TBDocumento.BackColor = Color.Azure;
                this.TBDocumento.ForeColor = Color.FromArgb(0, 0, 0);
                this.TBDocumento.Clear();
            }
        }

        private void TBTelefono_Enter(object sender, EventArgs e)
        {
            this.TBTelefono.BackColor = Color.Azure;
        }

        private void TBMovil_Enter(object sender, EventArgs e)
        {
            this.TBMovil.BackColor = Color.Azure;
        }

        private void TBCorreo_Enter(object sender, EventArgs e)
        {
            this.TBCorreo.BackColor = Color.Azure;
        }

        private void TBPais_Enter(object sender, EventArgs e)
        {
            this.TBPais.BackColor = Color.Azure;
        }

        private void TBCiudad_Enter(object sender, EventArgs e)
        {
            this.TBCiudad.BackColor = Color.Azure;
        }

        private void TBDepartamento_Enter(object sender, EventArgs e)
        {
            this.TBDepartamento.BackColor = Color.Azure;
        }

        private void TBNombre_Leave(object sender, EventArgs e)
        {
            this.TBNombre.BackColor = Color.FromArgb(3, 155, 229);

            //Si el campo de texto esta con su valor por defecto "Vacio"
            //Se realiza la primera validacion de lo contrario "Si esta lleno o digitador"
            //Se realiza toma estos datos para digitar en la Base de Datos
            if (TBNombre.Text == Campo)
            {
                this.TBNombre.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else if (TBNombre.Text == string.Empty)
            {
                this.TBNombre.Text = Campo;
                this.TBNombre.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void TBDocumento_Leave(object sender, EventArgs e)
        {
            this.TBDocumento.BackColor = Color.FromArgb(3, 155, 229);

            //Si el campo de texto esta con su valor por defecto "Vacio"
            //Se realiza la primera validacion de lo contrario "Si esta lleno o digitador"
            //Se realiza toma estos datos para digitar en la Base de Datos
            if (TBDocumento.Text == Campo)
            {
                this.TBDocumento.ForeColor = Color.FromArgb(255, 255, 255);
            }
            else if (TBDocumento.Text == string.Empty)
            {
                this.TBDocumento.Text = Campo;
                this.TBDocumento.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void TBTelefono_Leave(object sender, EventArgs e)
        {
            this.TBTelefono.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBMovil_Leave(object sender, EventArgs e)
        {
            this.TBMovil.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCorreo_Leave(object sender, EventArgs e)
        {
            this.TBCorreo.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBPais_Leave(object sender, EventArgs e)
        {
            this.TBPais.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCiudad_Leave(object sender, EventArgs e)
        {
            this.TBCiudad.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBDepartamento_Leave(object sender, EventArgs e)
        {
            this.TBDepartamento.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBPais_01_Enter(object sender, EventArgs e)
        {
            this.TBPais_01.BackColor = Color.Azure;
        }

        private void TBCiudad_01_Enter(object sender, EventArgs e)
        {
            this.TBCiudad_01.BackColor = Color.Azure;
        }

        private void TBDireccionPrincipal_Enter(object sender, EventArgs e)
        {
            this.TBDireccionPrincipal.BackColor = Color.Azure;
        }

        private void TBDireccion01_Enter(object sender, EventArgs e)
        {
            this.TBDireccion01.BackColor = Color.Azure;
        }

        private void TBDireccion02_Enter(object sender, EventArgs e)
        {
            this.TBDireccion02.BackColor = Color.Azure;
        }

        private void TBReceptor_Enter(object sender, EventArgs e)
        {
            this.TBReceptor.BackColor = Color.Azure;
        }

        private void TBDescripcion_Enter(object sender, EventArgs e)
        {
            this.TBDescripcion.BackColor = Color.Azure;
        }

        private void TBBancoPrincipal_Enter(object sender, EventArgs e)
        {
            this.TBBancoPrincipal.BackColor = Color.Azure;
        }

        private void TBCuenta01_Enter(object sender, EventArgs e)
        {
            this.TBCuenta01.BackColor = Color.Azure;
        }

        private void TBBancoAuxiliar_Enter(object sender, EventArgs e)
        {
            this.TBBancoAuxiliar.BackColor = Color.Azure;
        }

        private void TBCuenta02_Enter(object sender, EventArgs e)
        {
            this.TBCuenta02.BackColor = Color.Azure;
        }

        private void TBCreditoMinimo_Enter(object sender, EventArgs e)
        {
            this.TBCreditoMinimo.BackColor = Color.Azure;
        }

        private void TBCreditoMaximo_Enter(object sender, EventArgs e)
        {
            this.TBCreditoMaximo.BackColor = Color.Azure;
        }

        private void TBUltimoCredito_Enter(object sender, EventArgs e)
        {
            this.TBUltimoCredito.BackColor = Color.Azure;
        }

        private void TBCreditoMora_Enter(object sender, EventArgs e)
        {
            this.TBCreditoMora.BackColor = Color.Azure;
        }

        private void TBCreditoTotal_Enter(object sender, EventArgs e)
        {
            this.TBCreditoTotal.BackColor = Color.Azure;
        }

        private void TBPais_01_Leave(object sender, EventArgs e)
        {
            this.TBPais_01.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCiudad_01_Leave(object sender, EventArgs e)
        {
            this.TBCiudad_01.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBDireccionPrincipal_Leave(object sender, EventArgs e)
        {
            this.TBDireccionPrincipal.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBDireccion01_Leave(object sender, EventArgs e)
        {
            this.TBDireccion01.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBDireccion02_Leave(object sender, EventArgs e)
        {
            this.TBDireccion02.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBReceptor_Leave(object sender, EventArgs e)
        {
            this.TBReceptor.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBDescripcion_Leave(object sender, EventArgs e)
        {
            this.TBDescripcion.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBBancoPrincipal_Leave(object sender, EventArgs e)
        {
            this.TBBancoPrincipal.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCuenta01_Leave(object sender, EventArgs e)
        {
            this.TBCuenta01.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBBancoAuxiliar_Leave(object sender, EventArgs e)
        {
            this.TBBancoAuxiliar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCuenta02_Leave(object sender, EventArgs e)
        {
            this.TBCuenta02.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCreditoMinimo_Leave(object sender, EventArgs e)
        {
            this.TBCreditoMinimo.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCreditoMaximo_Leave(object sender, EventArgs e)
        {
            this.TBCreditoMaximo.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBUltimoCredito_Leave(object sender, EventArgs e)
        {
            this.TBUltimoCredito.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCreditoMora_Leave(object sender, EventArgs e)
        {
            this.TBCreditoMora.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBCreditoTotal_Leave(object sender, EventArgs e)
        {
            this.TBCreditoTotal.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void TBBuscar_Enter(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.Azure;
        }

        private void TBBuscar_Leave(object sender, EventArgs e)
        {
            this.TBBuscar.BackColor = Color.FromArgb(3, 155, 229);
        }

        private void frmAlmacen_Cliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
