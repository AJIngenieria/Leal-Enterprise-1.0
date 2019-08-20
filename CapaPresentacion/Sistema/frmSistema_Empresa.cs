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
    public partial class frmSistema_Empresa : Form
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

        //Variable para Capturar el Nombre de la Empresa desde la Base de Datos
        public string Empresa = "";

        //Variable para Metodo Eliminar
        private string Eliminacion = null;

        public frmSistema_Empresa()
        {
            InitializeComponent();
        }

        private void FrmSistema_Empresa_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.DesHabilitar();

            //Ocultacion de Texbox ID
            this.TBIdempresa.Visible = false;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos
            // Los Campos de Textos se Habilitaran 
            this.TBEmpresa.ReadOnly = false;
            this.TBEmpresa.BackColor = Color.FromArgb(32, 178, 170);
            this.TBEslogan.ReadOnly = false;
            this.TBEslogan.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDocumento.ReadOnly = false;
            this.TBDocumento.BackColor = Color.FromArgb(32, 178, 170);
            this.TBTelefono.ReadOnly = false;
            this.TBTelefono.BackColor = Color.FromArgb(32, 178, 170);
            this.TBMovil.ReadOnly = false;
            this.TBMovil.BackColor = Color.FromArgb(32, 178, 170);
            this.TBCorreo.ReadOnly = false;
            this.TBCorreo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDireccion.ReadOnly = false;
            this.TBDireccion.BackColor = Color.FromArgb(32, 178, 170);

        }

        private void DesHabilitar()
        {
            //Panel - Datos Basicos
            this.TBEmpresa.ReadOnly = true;
            this.TBEmpresa.BackColor = Color.FromArgb(187, 222, 251);
            this.TBEslogan.ReadOnly = true;
            this.TBEslogan.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDocumento.ReadOnly = true;
            this.TBDocumento.BackColor = Color.FromArgb(187, 222, 251);
            this.TBTelefono.ReadOnly = true;
            this.TBTelefono.BackColor = Color.FromArgb(187, 222, 251);
            this.TBMovil.ReadOnly = true;
            this.TBMovil.BackColor = Color.FromArgb(187, 222, 251);
            this.TBCorreo.ReadOnly = true;
            this.TBCorreo.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDireccion.ReadOnly = true;
            this.TBDireccion.BackColor = Color.FromArgb(187, 222, 251);

            //Desabilitacion de Botones
            this.btnNuevo.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;

        }

        private void Limpiar()
        {
            //Panel - Datos Basicos
            this.TBIdempresa.Clear();
            this.TBEmpresa.Clear();
            this.TBEslogan.Clear();
            this.TBDocumento.Clear();
            this.TBTelefono.Clear();
            this.TBMovil.Clear();
            this.TBCorreo.Clear();
            this.TBDireccion.Clear();
        }

        private void Guardar_SQL()
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBEmpresa.Text == string.Empty)
                {
                    MensajeError("Por Favor Ingrese el Nombre de la Empresa");
                    TBEmpresa.BackColor = Color.FromArgb(250, 235, 215);
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
                        rptaDatosBasicos = fSistema_Empresa.Guardar_DatosBasicos

                            (
                                //Panel de Datos Basicos
                                this.TBEmpresa.Text, this.TBEslogan.Text,this.TBDocumento.Text, this.TBDireccion.Text,
                                this.TBMovil.Text, this.TBTelefono.Text, this.TBCorreo.Text, 1
                            );
                    }

                    else if (this.IsEditar)
                    {
                        rptaDatosBasicos = fSistema_Empresa.Editar_DatosBasicos

                            (
                                //Panel de Datos Basicos
                                Convert.ToInt32(this.TBIdempresa.Text), this.TBEmpresa.Text, this.TBEslogan.Text, this.TBDocumento.Text, this.TBDireccion.Text,
                                this.TBMovil.Text, this.TBTelefono.Text, this.TBCorreo.Text, 2
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
                    this.Habilitar();
                    this.Limpiar();

                    // Se procede habilitar los Botones Basicos
                    // Los Campos de Textos y Botones de Examinar

                    this.btnNuevo.Enabled = false;
                    this.btnGuardar.Enabled = true;
                    this.btnEliminar.Enabled = false;
                    this.btnEditar.Enabled = false;

                    // Se hace enfasis (Focus) Al Iniciar el Evento Click 
                    // sobre el Campo Con Nombre Proveedor

                    this.TBEmpresa.Focus();
                    this.IsNuevo = true;
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
                        if (DGResultados.SelectedRows.Count > 0)
                        {
                            Eliminacion = DGResultados.CurrentRow.Cells["Codigo"].Value.ToString();
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
                        this.DGResultados.DataSource = fSistema_Empresa.Buscar_Empresa(this.TBBuscar.Text);
                        //this.DGResultado.Columns[0].Visible = false;
                        this.lblTotal.Text = "Datos Registrados: " + Convert.ToString(DGResultados.Rows.Count);


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
                        this.DGResultados.DataSource = null;
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

        private void DGResultados_KeyPress(object sender, KeyPressEventArgs e)
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
                            this.TBIdempresa.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                            this.TBEmpresa.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Empresa"].Value);
                            this.TBDocumento.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Documento"].Value);
                            this.TBEslogan.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Eslogan"].Value);
                            this.TBMovil.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Movil"].Value);
                            this.TBTelefono.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Telefono"].Value);
                            this.TBCorreo.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Correo"].Value);
                            this.TBDireccion.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Direccion"].Value);

                            //Se procede Habilitar los campos de Textos y Botones

                            this.Habilitar();
                            this.IsNuevo = false;
                            this.IsEditar = true;

                            //Botones Comunes
                            this.btnNuevo.Enabled = true;
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

        private void DGResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                        this.TBIdempresa.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Codigo"].Value);
                        this.TBEmpresa.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Empresa"].Value);
                        this.TBDocumento.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Documento"].Value);
                        this.TBEslogan.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Eslogan"].Value);
                        this.TBMovil.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Movil"].Value);
                        this.TBTelefono.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Telefono"].Value);
                        this.TBCorreo.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Correo"].Value);
                        this.TBDireccion.Text = Convert.ToString(this.DGResultados.CurrentRow.Cells["Direccion"].Value);

                        //Se procede Habilitar los campos de Textos y Botones

                        this.Habilitar();
                        this.IsNuevo = false;
                        this.IsEditar = true;

                        //Botones Comunes
                        this.btnNuevo.Enabled = true;
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

        private void TBEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.TBEslogan.Focus();
            }
        }

        private void TBEslogan_KeyPress(object sender, KeyPressEventArgs e)
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
                this.TBDireccion.Focus();
            }
        }

        private void TBDireccion_KeyPress(object sender, KeyPressEventArgs e)
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
                this.TBTelefono.Focus();
            }
        }

        private void TBTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.TBCorreo.Focus();
            }
        }

        private void TBCorreo_KeyPress(object sender, KeyPressEventArgs e)
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
                        this.TBCorreo.Focus();
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
                        this.TBCorreo.Focus();
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
