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
    public partial class frmGestionHumana_Empleados : Form
    {
        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public bool Filtro = true;

        //Variable para Captura el Empleado Logueado
        public int Idempleado;

        //Variable para Metodo SQL Guardar, Eliminar, Editar, Consultar
        public string Guardar = "";
        public string Editar = "";
        public string Consultar = "";
        public string Eliminar = "";

        //Variable para Metodo Eliminar
        private string Eliminacion = null;

        //Instancia Utilizadas para los metodos de Examinar
        private static frmGestionHumana_Empleados _Instancia;

        public static frmGestionHumana_Empleados GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmGestionHumana_Empleados();
            }
            return _Instancia;
        }
        public frmGestionHumana_Empleados()
        {
            InitializeComponent();
        }

        private void FrmSistema_Empleados_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.DesHabilitar();

            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;
            this.btnEditar.Enabled = false;

            //Ocultacion de Texbox ID
            this.TBIdempleado.Visible = false;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos
            // Los Campos de Textos se Habilitaran 
            this.TBEmpleado.ReadOnly = false;
            this.TBEmpleado.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDocumento.ReadOnly = false;
            this.TBDocumento.BackColor = Color.FromArgb(32, 178, 170);
            this.TBTelefono.ReadOnly = false;
            this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
            this.TBMovil.ReadOnly = false;
            this.TBMovil.BackColor = Color.FromArgb(32, 178, 170);
            this.TBEmail.ReadOnly = false;
            this.TBEmail.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccion.ReadOnly = false;
            this.TBDireccion.BackColor = Color.FromArgb(32, 178, 170);

        }

        private void DesHabilitar()
        {
            //Panel - Datos Basicos
            this.TBEmpleado.ReadOnly = true;
            this.TBEmpleado.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDocumento.ReadOnly = true;
            this.TBDocumento.BackColor = Color.FromArgb(187, 222, 251);
            this.TBTelefono.ReadOnly = true;
            this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);
            this.TBMovil.ReadOnly = true;
            this.TBMovil.BackColor = Color.FromArgb(187, 222, 251);
            this.TBEmail.ReadOnly = true;
            this.TBEmail.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDireccion.ReadOnly = true;
            this.TBDireccion.BackColor = Color.FromArgb(187, 222, 251);

            //Desabilitacion de Botones
            this.btnEditar.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;

        }

        private void Limpiar()
        {
            //Panel - Datos Basicos
            this.TBIdempleado.Clear();
            this.TBEmpleado.Clear();
            this.TBDocumento.Clear();
            this.TBTelefono.Clear();
            this.TBMovil.Clear();
            this.TBEmail.Clear();
            this.TBDireccion.Clear();
        }

        private void Guardar_SQL()
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBEmpleado.Text == string.Empty)
                {
                    MensajeError("Por Favor Ingrese el Nombre del Empleado");
                    TBEmpleado.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.TBDocumento.Text == string.Empty)
                {
                    MensajeError("Por Favor Ingrese un Numero de Documento");
                    TBDocumento.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fGestionHumana_Empleados.Guardar_DatosBasicos

                            (
                                //Panel de Datos Basicos
                                this.TBEmpleado.Text, this.TBDocumento.Text, this.TBTelefono.Text,
                                this.TBMovil.Text, this.TBEmail.Text, this.TBDireccion.Text, 1
                            );
                    }

                    else if (this.IsEditar)
                    {
                        rptaDatosBasicos = fGestionHumana_Empleados.Editar_DatosBasicos
                            
                            (
                                //Panel de Datos Basicos
                                Convert.ToInt32(this.TBIdempleado.Text), this.TBEmpleado.Text, this.TBDocumento.Text, this.TBTelefono.Text,
                                this.TBMovil.Text, this.TBEmail.Text, this.TBDireccion.Text, 1
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
                if (Guardar == "Si")
                {
                    // Se procede habilitar los campos de textos
                    this.Limpiar();
                    this.Habilitar();

                    //Se Habilita el Boton Guardar para realizar los nuevos Registros
                    //Los demas botones solo se habilitan al realizar la consulta
                    //Y se tenga el permiso para editar, eliminar y consultar

                    this.btnGuardar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnEditar.Enabled = false;

                    // Se hace enfasis (Focus) Al Iniciar el Evento Click 
                    // sobre el Campo Con Nombre Proveedor

                    this.TBEmpleado.Focus();
                    this.IsNuevo = true;
                    this.IsEditar = false;
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
            try
            {
                if (Eliminar != "No")
                {

                    DialogResult Opcion;
                    string Respuesta = "";

                    Opcion = MessageBox.Show("Desea Eliminar el Registro Seleccionado", "Leal Enterprise", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (Opcion == DialogResult.OK)
                    {
                        if (DGResultadoss.SelectedRows.Count > 0)
                        {
                            Eliminacion = DGResultadoss.CurrentRow.Cells["Codigo"].Value.ToString();
                            Respuesta = CapaNegocio.fGestionHumana_Empleados.Eliminar_DatosBasicos(Convert.ToInt32(Eliminacion));
                        }

                        if (Respuesta.Equals("OK"))
                        {
                            this.MensajeOk("Registro Eliminado Correctamente");
                        }
                        else
                        {
                            this.MensajeError(Respuesta);
                        }
                    }
                }
                else if (Eliminacion == "No")
                {
                    MessageBox.Show("Acceso Denegado Para Realizar Eliminaciones en el Sistema", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

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
                if (Consultar != "No")
                {
                    //Se realiza una consulta General de los datos Registrados
                    //La cual se produce en la tabla Historico.Bodega
                    //Y el procedimiento Almacenado Produccion.Buscar_Bodega


                    if (this.TBBuscar.Text != "")
                    {
                        this.DGResultadoss.DataSource = fGestionHumana_Empleados.Buscar_Empleado(this.TBBuscar.Text);
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

        private void DGResultadoss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (Editar != "No")
                {
                    //Cuando IsEditar o la Varible que se establezca en este caso IsEditar
                    //Contenga el simbolo ! su valor es igual al False
                    //Inicialmente esta Variable se esta Iniciando de Forma False en una variable de tipo Booleano

                    if (!IsEditar)
                    {
                        this.TBIdempleado.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Codigo"].Value);
                        this.TBEmpleado.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Empleado"].Value);
                        this.TBDocumento.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Documento"].Value);
                        this.TBMovil.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Movil"].Value);
                        this.TBTelefono.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Telefono"].Value);
                        this.TBEmail.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Correo"].Value);
                        this.TBDireccion.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Direccion"].Value);

                        //Se procede Habilitar los campos de Textos y Botones

                        this.Habilitar();
                        this.IsNuevo = false;
                        this.IsEditar = true;

                        //Botones Comunes
                        this.btnEditar.Enabled = true;
                        this.btnEliminar.Enabled = false;
                        this.btnGuardar.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Acceso Denegado Para Actualizar Registros", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultadoss_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (Editar != "No")
                    {
                        //Cuando IsEditar o la Varible que se establezca en este caso IsEditar
                        //Contenga el simbolo ! su valor es igual al False
                        //Inicialmente esta Variable se esta Iniciando de Forma False en una variable de tipo Booleano

                        if (!IsEditar)
                        {
                            this.TBIdempleado.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Codigo"].Value);
                            this.TBEmpleado.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Empleado"].Value);
                            this.TBDocumento.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Documento"].Value);
                            this.TBMovil.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Movil"].Value);
                            this.TBTelefono.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Telefono"].Value);
                            this.TBEmail.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Correo"].Value);
                            this.TBDireccion.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Direccion"].Value);

                            //Se procede Habilitar los campos de Textos y Botones

                            this.Habilitar();
                            this.IsNuevo = false;
                            this.IsEditar = true;

                            //Botones Comunes
                            this.btnEditar.Enabled = true;
                            this.btnEliminar.Enabled = false;
                            this.btnGuardar.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Acceso Denegado Para Actualizar Registros", "Leal Enterprise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.TBDocumento.Focus();
            }
        }

        private void TBDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.TBTelefono.Focus();
            }
        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.TBMovil.Focus();
            }
        }

        private void TBMovil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.TBEmail.Focus();
            }
        }

        private void TBEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.TBDireccion.Focus();
            }
        }

        private void TBDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (IsNuevo)
                {
                    DialogResult result = MessageBox.Show("¿Desea Guardar los Datos Digitados?", "Servi Lavado Las Brisas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        this.Guardar_SQL();
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBDireccion.Focus();
                    }
                }

                else if (IsEditar)
                {
                    DialogResult result = MessageBox.Show("¿Desea Actualizar los Datos Registrados?", "Servi Lavado Las Brisas", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        this.Guardar_SQL();
                    }
                    else if (result == DialogResult.No)
                    {
                        this.TBDireccion.Focus();
                    }
                }
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
                this.TBBuscar.Focus();
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
    }
}
