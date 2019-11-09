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

using System.IO;
using System.Management;
using System.Configuration;

namespace CapaPresentacion
{
    public partial class frmSistema_Equipos : Form
    {
        // Variable con la cual se define si el procecimiento 
        // A realizar es Editar, Guardar, Buscar,Eliminar
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public bool Filtro = true;

        //Variable para Capturar el Nombre de la Empresa desde la Base de Datos
        public string Empresa = "";

        //Variable para Metodo Eliminar
        private string Eliminacion = null;
        public frmSistema_Equipos()
        {
            InitializeComponent();
        }

        private void FrmSistema_Equipos_Load(object sender, EventArgs e)
        {
            //Inicio de Clase y Botones
            this.DesHabilitar();

            //Ocultacion de Texbox ID
            this.TBIdequipo.Visible = false;

            //Color para Texboxt Buscar
            this.TBBuscar.BackColor = Color.FromArgb(32, 178, 170);

            
        }

        private void Habilitar()
        {
            //Panel - Datos Basicos
            // Los Campos de Textos se Habilitaran 
            this.TBEquipo.ReadOnly = false;
            this.TBEquipo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBDiscoDuro.ReadOnly = false;
            this.TBDiscoDuro.BackColor = Color.FromArgb(32, 178, 170);
            this.CBTipo.Enabled = true;
            this.CBTipo.BackColor = Color.FromArgb(32, 178, 170);
            this.TBMacseguridad.ReadOnly = false;
            this.TBMacseguridad.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void DesHabilitar()
        {
            //Panel - Datos Basicos
            this.TBEquipo.ReadOnly = true;
            this.TBEquipo.BackColor = Color.FromArgb(187, 222, 251);
            this.TBDiscoDuro.ReadOnly = true;
            this.TBDiscoDuro.BackColor = Color.FromArgb(187, 222, 251);
            this.CBTipo.Enabled = false;
            this.CBTipo.BackColor = Color.FromArgb(187, 222, 251);
            this.TBMacseguridad.ReadOnly = true;
            this.TBMacseguridad.BackColor = Color.FromArgb(187, 222, 251);
            
            //Desabilitacion de Botones
            this.btnNuevo.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnGuardar.Enabled = false;
            this.btnEliminar.Enabled = false;

        }

        private void Limpiar()
        {
            //Panel - Datos Basicos
            this.TBIdequipo.Clear();
            this.TBEquipo.Clear();
            this.TBDiscoDuro.Clear();
            this.CBTipo.SelectedItem = 0;
            this.TBMacseguridad.Clear();
        }

        private void Guardar_SQL()
        {
            try
            {
                string rptaDatosBasicos = "";

                //Datos Basicos
                if (this.TBEquipo.Text == string.Empty)
                {
                    MensajeError("Por Favor Ingrese el Nombre del Equipo a Registrar");
                    TBEquipo.BackColor = Color.FromArgb(250, 235, 215);
                }
                else if (this.CBTipo.SelectedIndex == 0)
                {
                    MensajeError("Por Favor Seleccione el Tipo de Equipo a Registrar");
                    CBTipo.BackColor = Color.FromArgb(250, 235, 215);
                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rptaDatosBasicos = fSistema_Equipos.Guardar_DatosBasicos

                            (
                                //Panel de Datos Basicos
                                this.TBEquipo.Text, this.TBDiscoDuro.Text, this.CBTipo.Text, this.TBMacseguridad.Text, 1, 1
                            );
                    }

                    else if (this.IsEditar)
                    {
                        rptaDatosBasicos = fSistema_Equipos.Editar_DatosBasicos

                            (
                                //Panel de Datos Basicos
                                Convert.ToInt32(this.TBIdequipo.Text), this.TBEquipo.Text, this.TBDiscoDuro.Text, this.CBTipo.Text, this.TBMacseguridad.Text, 1, 2
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

        public static String Serial_HDD()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
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

                this.TBEquipo.Focus();
                this.IsNuevo = true;

                //Se capturan los valores del computador donde esta iniciado
                this.TBDiscoDuro.Text = Informacion_Computer.Serial_HDD();
                this.TBMacseguridad.Text = Informacion_Computer.MAC_Address();
                this.TBEquipo.Text = Informacion_Computer.Nombre_PC();

                //this.TBSerialProcesador.Text = Informacion_Computer.Serial_Procesador();
                //this.TBCodigoDeSeguridad.Text = Informacion_Computer.SO_Informacion();

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
                DialogResult Opcion;
                string Respuesta = "";

                Opcion = MessageBox.Show("Desea Eliminar el Registro Seleccionado", "Leal Enterprise", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    if (DGResultadoss.SelectedRows.Count > 0)
                    {
                        Eliminacion = DGResultadoss.CurrentRow.Cells["Codigo"].Value.ToString();
                        Respuesta = CapaNegocio.fSistema_Equipos.Eliminar_DatosBasicos(Convert.ToInt32(Eliminacion));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Se realiza una consulta General de los datos Registrados
                //La cual se produce en la tabla Historico.Bodega
                //Y el procedimiento Almacenado Produccion.Buscar_Bodega


                if (this.TBBuscar.Text != "")
                {
                    this.DGResultadoss.DataSource = fSistema_Equipos.Buscar_Equipos(this.TBBuscar.Text);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGResultadoss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Cuando IsEditar o la Varible que se establezca en este caso IsEditar
                //Contenga el simbolo ! su valor es igual al False
                //Inicialmente esta Variable se esta Iniciando de Forma False en una variable de tipo Booleano

                if (!IsEditar)
                {
                    this.TBIdequipo.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Codigo"].Value);
                    this.TBEquipo.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Equipo"].Value);
                    this.CBTipo.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Tipo"].Value);
                    this.TBDiscoDuro.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Disco Duro"].Value);
                    this.TBMacseguridad.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Mac Seguridad"].Value);

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
                    //Cuando IsEditar o la Varible que se establezca en este caso IsEditar
                    //Contenga el simbolo ! su valor es igual al False
                    //Inicialmente esta Variable se esta Iniciando de Forma False en una variable de tipo Booleano

                    if (!IsEditar)
                    {
                        this.TBIdequipo.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Codigo"].Value);
                        this.TBEquipo.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Equipo"].Value);
                        this.CBTipo.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Tipo"].Value);
                        this.TBDiscoDuro.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Disco Duro"].Value);
                        this.TBMacseguridad.Text = Convert.ToString(this.DGResultadoss.CurrentRow.Cells["Mac Seguridad"].Value);

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TBEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.TBDiscoDuro.Focus();
            }
        }

        private void TBDiscoDuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.TBMacseguridad.Focus();
            }
        }

        private void TBMacseguridad_KeyPress(object sender, KeyPressEventArgs e)
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
                        this.TBMacseguridad.Focus();
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
                        this.TBEquipo.Focus();
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
