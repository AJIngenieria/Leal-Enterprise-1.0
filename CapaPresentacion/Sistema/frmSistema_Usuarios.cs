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
    public partial class frmSistema_Usuarios : Form
    {
        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public bool Filtro = true;

        //Variable para Metodo Eliminar
        private string Eliminacion = null;

        //Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar
        public string Guardar = "";
        public string Editar = "";
        public string Consultar = "";
        public string Eliminar = "";

        //Instancia Utilizadas para los metodos de Examinar
        private static frmSistema_Usuarios _Instancia;

        public static frmSistema_Usuarios GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmSistema_Usuarios();
            }
            return _Instancia;
        }
        public frmSistema_Usuarios()
        {
            InitializeComponent();
        }

        private void FrmSistema_Usuarios_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.DesHabilitar();

            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnEditar.Enabled = false;
            this.btnExaminar.Enabled = false;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);

            //Ocultacion de Textbox
            this.TBIdempleado.Visible = false;
        }
        
        private void Habilitar()
        {
            //Panel - Datos Basicos  
            this.TBUsuario.ReadOnly = false;
            this.TBUsuario.BackColor = Color.FromArgb(32, 178, 170);
            this.TBContraseña.ReadOnly = false;
            this.TBContraseña.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDescripcion.ReadOnly = false;
            this.TBDescripcion.BackColor = Color.FromArgb(32, 178, 170);

            //Panel - Permisos y/o Niveles

            this.CBGuardar.Enabled = true;
            this.CBGuardar.BackColor = Color.FromArgb(32, 178, 170);
            this.CBEditar.Enabled = true;
            this.CBEditar.BackColor = Color.FromArgb(32, 178, 170);
            this.CBEliminar.Enabled = true;
            this.CBEliminar.BackColor = Color.FromArgb(32, 178, 170);
            this.CBConsulta.Enabled = true;
            this.CBConsulta.BackColor = Color.FromArgb(32, 178, 170);

            this.CBAlmacen.Enabled = true;
            this.CBAlmacen.BackColor = Color.FromArgb(32, 178, 170);
            this.CBGestionHumana.Enabled = true;
            this.CBGestionHumana.BackColor = Color.FromArgb(32, 178, 170);
            this.CBProductos.Enabled = true;
            this.CBProductos.BackColor = Color.FromArgb(32, 178, 170);
            this.CBRemision.Enabled = true;
            this.CBRemision.BackColor = Color.FromArgb(32, 178, 170);
            this.CBReporte.Enabled = true;
            this.CBReporte.BackColor = Color.FromArgb(32, 178, 170);
            this.CBSistema.Enabled = true;
            this.CBSistema.BackColor = Color.FromArgb(32, 178, 170);

            this.btnExaminar.Enabled = true;
        }

        private void DesHabilitar()
        {
            //Panel - Datos Basicos

            this.TBEmpleado.ReadOnly = true;
            this.TBEmpleado.BackColor = Color.FromArgb(187, 222, 251);
            this.TBUsuario.ReadOnly = true;
            this.TBUsuario.BackColor = Color.FromArgb(187, 222, 251);
            this.TBContraseña.ReadOnly = true;
            this.TBContraseña.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDescripcion.ReadOnly = true;
            this.TBDescripcion.BackColor = Color.FromArgb(187, 222, 251);

            //Panel - Permisos y/o Niveles

            this.CBGuardar.Enabled = false;
            this.CBGuardar.BackColor = Color.FromArgb(187, 222, 251);
            this.CBEditar.Enabled = false;
            this.CBEditar.BackColor = Color.FromArgb(187, 222, 251);
            this.CBEliminar.Enabled = false;
            this.CBEliminar.BackColor = Color.FromArgb(187, 222, 251);
            this.CBConsulta.Enabled = false;
            this.CBConsulta.BackColor = Color.FromArgb(187, 222, 251);

            this.CBAlmacen.Enabled = false;
            this.CBAlmacen.BackColor = Color.FromArgb(187, 222, 251);
            this.CBGestionHumana.Enabled = false;
            this.CBGestionHumana.BackColor = Color.FromArgb(187, 222, 251);
            this.CBProductos.Enabled = false;
            this.CBProductos.BackColor = Color.FromArgb(187, 222, 251);
            this.CBRemision.Enabled = false;
            this.CBRemision.BackColor = Color.FromArgb(187, 222, 251);
            this.CBReporte.Enabled = false;
            this.CBReporte.BackColor = Color.FromArgb(187, 222, 251);
            this.CBSistema.Enabled = false;
            this.CBSistema.BackColor = Color.FromArgb(187, 222, 251);

        }

        private void Limpiar()
        {
            //Panel - Datos Basicos
            this.TBIdempleado.Clear();
            this.TBEmpleado.Clear();
            this.TBUsuario.Clear();
            this.TBContraseña.Clear();
            this.TBDescripcion.Clear();

            //Panel - Permisos y/o Niveles
            this.CBAlmacen.SelectedIndex = 0;
            this.CBGestionHumana.SelectedIndex = 0;
            this.CBProductos.SelectedIndex = 0;
            this.CBRemision.SelectedIndex = 0;
            this.CBSistema.SelectedIndex = 0;
            this.CBReporte.SelectedIndex = 0;
        }

        private void Guardar_SQL()
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBEmpleado.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBEmpleado.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBUsuario.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBUsuario.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBContraseña.Text == string.Empty)
                {
                    MensajeError("Faltan Ingresar Algunos Datos, Estos Seran Remarcados");
                    TBContraseña.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fSistema_Usuarios.Guardar_DatosBasicos
                            (
                                Convert.ToInt32(this.TBIdempleado.Text), this.TBEmpleado.Text, this.TBUsuario.Text, this.TBContraseña.Text, this.TBDescripcion.Text,
                                this.CBAlmacen.Text, this.CBGestionHumana.Text, this.CBProductos.Text,
                                this.CBRemision.Text, this.CBReporte.Text, this.CBVentas.Text,this.CBSistema.Text, 
                                
                                this.CBGuardar.Text, this.CBEliminar.Text, this.CBEditar.Text, this.CBConsulta.Text, 1, 1
                            );
                    }

                    else if (this.IsEditar)
                    {
                        rptaDatosBasicos = fSistema_Usuarios.Editar_DatosBasicos
                            (
                                Convert.ToInt32(this.TBIdusuario), Convert.ToInt32(this.TBIdempleado.Text), this.TBEmpleado.Text, this.TBUsuario.Text, this.TBContraseña.Text, this.TBDescripcion.Text,
                                this.CBAlmacen.Text, this.CBGestionHumana.Text, this.CBProductos.Text,
                                this.CBRemision.Text, this.CBReporte.Text, this.CBVentas.Text, this.CBSistema.Text,

                                this.CBGuardar.Text, this.CBEliminar.Text, this.CBEditar.Text, this.CBConsulta.Text, 1, 1
                            );
                    }

                    if (rptaDatosBasicos.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Registro Completado");
                        }
                        else if (this.IsEditar)
                        {
                            this.MensajeOk("Actualizacion Completada");
                        }
                    }

                    else
                    {
                        this.MensajeError(rptaDatosBasicos);
                    }

                    this.IsEditar = false;
                    this.IsNuevo = false;
                    this.DesHabilitar();
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        public void setEmpleado(string idempleado, string empleado)
        {
            this.TBIdempleado.Text = idempleado;
            this.TBEmpleado.Text = empleado;
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

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Guardar=="Si")
                {
                    // Se hace enfasis (Focus) Al Iniciar el Evento Click 
                    // sobre el Campo Con Nombre Proveedor

                    this.TBUsuario.Focus();
                    this.IsNuevo = true;

                    // Se procede habilitar los campos de textos
                    this.Habilitar();
                    this.Limpiar();

                    // Se procede habilitar los Botones Basicos
                    // Los Campos de Textos y Botones de Examinar

                    this.btnNuevo.Enabled = false;
                    this.btnGuardar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnEditar.Enabled = false;

                }

                else
                {
                    MessageBox.Show("El Usuario Iniciado Actualmente no Contiene Permisos Para Realizar Registros en el Sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            this.Guardar_SQL();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            this.Guardar_SQL();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
        
        private void BtnExaminar_Click(object sender, EventArgs e)
        {
            frmExaminar_Empleado frmExaminar_Empleado = new frmExaminar_Empleado();
            frmExaminar_Empleado.ShowDialog();
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Consultar != "No")
                {
                    //Se realiza una consulta General de los datos Registrados
                    //La cual se produce en la tabla Historico.Bodega
                    //Y el procedimiento Almacenado Produccion.Buscar_Bodega


                    if (this.TBBuscar.Text != "")
                    {
                        this.DGResultadoss.DataSource = fSistema_Usuarios.Buscar_Usuario(this.TBBuscar.Text);
                        //this.DGResultados.Columns[0].Visible = false;
                        this.lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultadoss.Rows.Count);


                        this.Limpiar();
                        this.DesHabilitar();

                        //Desabilitacion del Boton Eliminar
                        this.btnEliminar.Enabled = true;

                        //Variables de Procedimientos iniciadas en False
                        this.IsNuevo = false;
                        this.IsEditar = false;
                    }

                    else if (this.TBBuscar.Text == "")
                    {
                        this.Limpiar();
                        this.DesHabilitar();

                        //Desabilitacion del Boton Eliminar
                        this.btnEliminar.Enabled = true;

                        //Se Limpian las Filas y Columnas de la tabla
                        this.DGResultadoss.DataSource = null;
                        this.lblTotal.Text = "Datos Registrados: 0";

                        //Variables de Procedimientos iniciadas en False
                        this.IsNuevo = false;
                        this.IsEditar = false;
                    }
                }

                else
                {
                    MessageBox.Show("Acceso Denegado Para Realizar Consultas", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnNuevo_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnNuevo.Image = Properties.Resources.BV_Nuevo;
        }

        private void BtnNuevo_MouseLeave(object sender, EventArgs e)
        {
            this.btnNuevo.Image = Properties.Resources.BV_Nuevo;
        }

        private void BtnNuevo_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnNuevo.Image = Properties.Resources.BR_Nuevo;
        }

        private void BtnGuardar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnGuardar.Image = Properties.Resources.BV_Guardar;
        }

        private void BtnGuardar_MouseLeave(object sender, EventArgs e)
        {
            this.btnGuardar.Image = Properties.Resources.BV_Guardar;
        }

        private void BtnGuardar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnGuardar.Image = Properties.Resources.BR_Guardar;
        }

        private void BtnEditar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnEditar.Image = Properties.Resources.BV_Editar;
        }

        private void BtnEditar_MouseLeave(object sender, EventArgs e)
        {
            this.btnEditar.Image = Properties.Resources.BV_Editar;
        }

        private void BtnEditar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnEditar.Image = Properties.Resources.BR_Editar;
        }

        private void BtnEliminar_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void BtnEliminar_MouseLeave(object sender, EventArgs e)
        {
            this.btnEliminar.Image = Properties.Resources.BV_Eliminar;
        }

        private void BtnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnEliminar.Image = Properties.Resources.BR_Eliminar;
        }
        
        private void FrmSistema_Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

    }
}
