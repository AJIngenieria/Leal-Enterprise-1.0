namespace CapaPresentacion
{
    partial class frmAlmacen_Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBIdcliente = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TCPrincipal = new System.Windows.Forms.TabControl();
            this.TPDatosBasicos = new System.Windows.Forms.TabPage();
            this.TBDepartamento = new System.Windows.Forms.TextBox();
            this.TBCiudad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBPais = new System.Windows.Forms.TextBox();
            this.TBCorreo = new System.Windows.Forms.TextBox();
            this.TBMovil = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBDocumento = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TPDatosDeEnvio = new System.Windows.Forms.TabPage();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TBReceptor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TBCiudad_01 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TBPais_01 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TBDireccion02 = new System.Windows.Forms.TextBox();
            this.TBDireccion01 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TBDireccionPrincipal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TPDatosFinancieros = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.TBCreditoMora = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.TBCreditoTotal = new System.Windows.Forms.TextBox();
            this.TBUltimoCredito = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.TBCreditoMaximo = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.TBCreditoMinimo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.TBCuenta02 = new System.Windows.Forms.TextBox();
            this.TBCuenta01 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TBBancoAuxiliar = new System.Windows.Forms.TextBox();
            this.TBBancoPrincipal = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.TCPrincipal.SuspendLayout();
            this.TPDatosBasicos.SuspendLayout();
            this.TPDatosDeEnvio.SuspendLayout();
            this.TPDatosFinancieros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBIdcliente);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.TCPrincipal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Enterprise - Registro de Clientes";
            // 
            // TBIdcliente
            // 
            this.TBIdcliente.Location = new System.Drawing.Point(111, 306);
            this.TBIdcliente.Name = "TBIdcliente";
            this.TBIdcliente.Size = new System.Drawing.Size(100, 21);
            this.TBIdcliente.TabIndex = 3;
            this.TBIdcliente.TextChanged += new System.EventHandler(this.TBIdcliente_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.BV_Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(279, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 26);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseDown);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseMove);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(10, 303);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseDown);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.btnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardar_MouseMove);
            // 
            // TCPrincipal
            // 
            this.TCPrincipal.Controls.Add(this.TPDatosBasicos);
            this.TCPrincipal.Controls.Add(this.TPDatosDeEnvio);
            this.TCPrincipal.Controls.Add(this.TPDatosFinancieros);
            this.TCPrincipal.Location = new System.Drawing.Point(6, 20);
            this.TCPrincipal.Name = "TCPrincipal";
            this.TCPrincipal.SelectedIndex = 0;
            this.TCPrincipal.Size = new System.Drawing.Size(353, 277);
            this.TCPrincipal.TabIndex = 0;
            // 
            // TPDatosBasicos
            // 
            this.TPDatosBasicos.Controls.Add(this.TBDepartamento);
            this.TPDatosBasicos.Controls.Add(this.TBCiudad);
            this.TPDatosBasicos.Controls.Add(this.label9);
            this.TPDatosBasicos.Controls.Add(this.label8);
            this.TPDatosBasicos.Controls.Add(this.TBPais);
            this.TPDatosBasicos.Controls.Add(this.TBCorreo);
            this.TPDatosBasicos.Controls.Add(this.TBMovil);
            this.TPDatosBasicos.Controls.Add(this.TBTelefono);
            this.TPDatosBasicos.Controls.Add(this.TBDocumento);
            this.TPDatosBasicos.Controls.Add(this.TBNombre);
            this.TPDatosBasicos.Controls.Add(this.TBCodigo);
            this.TPDatosBasicos.Controls.Add(this.label7);
            this.TPDatosBasicos.Controls.Add(this.label6);
            this.TPDatosBasicos.Controls.Add(this.label5);
            this.TPDatosBasicos.Controls.Add(this.label4);
            this.TPDatosBasicos.Controls.Add(this.label3);
            this.TPDatosBasicos.Controls.Add(this.label2);
            this.TPDatosBasicos.Controls.Add(this.label1);
            this.TPDatosBasicos.Location = new System.Drawing.Point(4, 24);
            this.TPDatosBasicos.Name = "TPDatosBasicos";
            this.TPDatosBasicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosBasicos.Size = new System.Drawing.Size(345, 249);
            this.TPDatosBasicos.TabIndex = 0;
            this.TPDatosBasicos.Text = "Datos Basicos";
            this.TPDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // TBDepartamento
            // 
            this.TBDepartamento.Location = new System.Drawing.Point(89, 224);
            this.TBDepartamento.Name = "TBDepartamento";
            this.TBDepartamento.Size = new System.Drawing.Size(250, 21);
            this.TBDepartamento.TabIndex = 19;
            this.TBDepartamento.Enter += new System.EventHandler(this.TBDepartamento_Enter);
            this.TBDepartamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDepartamento_KeyUp);
            this.TBDepartamento.Leave += new System.EventHandler(this.TBDepartamento_Leave);
            // 
            // TBCiudad
            // 
            this.TBCiudad.Location = new System.Drawing.Point(89, 197);
            this.TBCiudad.Name = "TBCiudad";
            this.TBCiudad.Size = new System.Drawing.Size(250, 21);
            this.TBCiudad.TabIndex = 18;
            this.TBCiudad.Enter += new System.EventHandler(this.TBCiudad_Enter);
            this.TBCiudad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCiudad_KeyUp);
            this.TBCiudad.Leave += new System.EventHandler(this.TBCiudad_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Departam.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ciudad";
            // 
            // TBPais
            // 
            this.TBPais.Location = new System.Drawing.Point(89, 170);
            this.TBPais.Name = "TBPais";
            this.TBPais.Size = new System.Drawing.Size(250, 21);
            this.TBPais.TabIndex = 13;
            this.TBPais.Enter += new System.EventHandler(this.TBPais_Enter);
            this.TBPais.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBPais_KeyUp);
            this.TBPais.Leave += new System.EventHandler(this.TBPais_Leave);
            // 
            // TBCorreo
            // 
            this.TBCorreo.Location = new System.Drawing.Point(89, 143);
            this.TBCorreo.Name = "TBCorreo";
            this.TBCorreo.Size = new System.Drawing.Size(250, 21);
            this.TBCorreo.TabIndex = 12;
            this.TBCorreo.Enter += new System.EventHandler(this.TBCorreo_Enter);
            this.TBCorreo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCorreo_KeyUp);
            this.TBCorreo.Leave += new System.EventHandler(this.TBCorreo_Leave);
            // 
            // TBMovil
            // 
            this.TBMovil.Location = new System.Drawing.Point(89, 116);
            this.TBMovil.Name = "TBMovil";
            this.TBMovil.Size = new System.Drawing.Size(250, 21);
            this.TBMovil.TabIndex = 11;
            this.TBMovil.Enter += new System.EventHandler(this.TBMovil_Enter);
            this.TBMovil.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBMovil_KeyUp);
            this.TBMovil.Leave += new System.EventHandler(this.TBMovil_Leave);
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(89, 89);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(250, 21);
            this.TBTelefono.TabIndex = 10;
            this.TBTelefono.Enter += new System.EventHandler(this.TBTelefono_Enter);
            this.TBTelefono.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBTelefono_KeyUp);
            this.TBTelefono.Leave += new System.EventHandler(this.TBTelefono_Leave);
            // 
            // TBDocumento
            // 
            this.TBDocumento.Location = new System.Drawing.Point(89, 62);
            this.TBDocumento.Name = "TBDocumento";
            this.TBDocumento.Size = new System.Drawing.Size(250, 21);
            this.TBDocumento.TabIndex = 9;
            this.TBDocumento.Enter += new System.EventHandler(this.TBDocumento_Enter);
            this.TBDocumento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDocumento_KeyUp);
            this.TBDocumento.Leave += new System.EventHandler(this.TBDocumento_Leave);
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(89, 35);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(250, 21);
            this.TBNombre.TabIndex = 8;
            this.TBNombre.Enter += new System.EventHandler(this.TBNombre_Enter);
            this.TBNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBNombre_KeyUp);
            this.TBNombre.Leave += new System.EventHandler(this.TBNombre_Leave);
            // 
            // TBCodigo
            // 
            this.TBCodigo.Location = new System.Drawing.Point(89, 6);
            this.TBCodigo.Name = "TBCodigo";
            this.TBCodigo.Size = new System.Drawing.Size(250, 21);
            this.TBCodigo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Movil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // TPDatosDeEnvio
            // 
            this.TPDatosDeEnvio.Controls.Add(this.TBDescripcion);
            this.TPDatosDeEnvio.Controls.Add(this.label18);
            this.TPDatosDeEnvio.Controls.Add(this.TBReceptor);
            this.TPDatosDeEnvio.Controls.Add(this.label17);
            this.TPDatosDeEnvio.Controls.Add(this.TBCiudad_01);
            this.TPDatosDeEnvio.Controls.Add(this.label16);
            this.TPDatosDeEnvio.Controls.Add(this.TBPais_01);
            this.TPDatosDeEnvio.Controls.Add(this.label15);
            this.TPDatosDeEnvio.Controls.Add(this.TBDireccion02);
            this.TPDatosDeEnvio.Controls.Add(this.TBDireccion01);
            this.TPDatosDeEnvio.Controls.Add(this.label14);
            this.TPDatosDeEnvio.Controls.Add(this.TBDireccionPrincipal);
            this.TPDatosDeEnvio.Controls.Add(this.label13);
            this.TPDatosDeEnvio.Controls.Add(this.label11);
            this.TPDatosDeEnvio.Location = new System.Drawing.Point(4, 24);
            this.TPDatosDeEnvio.Name = "TPDatosDeEnvio";
            this.TPDatosDeEnvio.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosDeEnvio.Size = new System.Drawing.Size(345, 249);
            this.TPDatosDeEnvio.TabIndex = 1;
            this.TPDatosDeEnvio.Text = "Datos De Envio";
            this.TPDatosDeEnvio.UseVisualStyleBackColor = true;
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(89, 168);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(250, 75);
            this.TBDescripcion.TabIndex = 13;
            this.TBDescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDescripcion_KeyUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 168);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 15);
            this.label18.TabIndex = 12;
            this.label18.Text = "Descripcion";
            // 
            // TBReceptor
            // 
            this.TBReceptor.Location = new System.Drawing.Point(89, 141);
            this.TBReceptor.Name = "TBReceptor";
            this.TBReceptor.Size = new System.Drawing.Size(250, 21);
            this.TBReceptor.TabIndex = 11;
            this.TBReceptor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBReceptor_KeyUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "Receptor";
            // 
            // TBCiudad_01
            // 
            this.TBCiudad_01.Location = new System.Drawing.Point(89, 33);
            this.TBCiudad_01.Name = "TBCiudad_01";
            this.TBCiudad_01.Size = new System.Drawing.Size(250, 21);
            this.TBCiudad_01.TabIndex = 9;
            this.TBCiudad_01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCiudad_01_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 15);
            this.label16.TabIndex = 8;
            this.label16.Text = "Pais";
            // 
            // TBPais_01
            // 
            this.TBPais_01.Location = new System.Drawing.Point(89, 6);
            this.TBPais_01.Name = "TBPais_01";
            this.TBPais_01.Size = new System.Drawing.Size(250, 21);
            this.TBPais_01.TabIndex = 7;
            this.TBPais_01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBPais_01_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 6;
            this.label15.Text = "Ciudad";
            // 
            // TBDireccion02
            // 
            this.TBDireccion02.Location = new System.Drawing.Point(89, 114);
            this.TBDireccion02.Name = "TBDireccion02";
            this.TBDireccion02.Size = new System.Drawing.Size(250, 21);
            this.TBDireccion02.TabIndex = 5;
            this.TBDireccion02.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDireccion02_KeyUp);
            // 
            // TBDireccion01
            // 
            this.TBDireccion01.Location = new System.Drawing.Point(89, 87);
            this.TBDireccion01.Name = "TBDireccion01";
            this.TBDireccion01.Size = new System.Drawing.Size(250, 21);
            this.TBDireccion01.TabIndex = 4;
            this.TBDireccion01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDireccion01_KeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Direccion 02";
            // 
            // TBDireccionPrincipal
            // 
            this.TBDireccionPrincipal.Location = new System.Drawing.Point(89, 60);
            this.TBDireccionPrincipal.Name = "TBDireccionPrincipal";
            this.TBDireccionPrincipal.Size = new System.Drawing.Size(250, 21);
            this.TBDireccionPrincipal.TabIndex = 2;
            this.TBDireccionPrincipal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBDireccionPrincipal_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "Direccion 01";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Direccion P.";
            // 
            // TPDatosFinancieros
            // 
            this.TPDatosFinancieros.Controls.Add(this.label27);
            this.TPDatosFinancieros.Controls.Add(this.TBCreditoMora);
            this.TPDatosFinancieros.Controls.Add(this.label26);
            this.TPDatosFinancieros.Controls.Add(this.TBCreditoTotal);
            this.TPDatosFinancieros.Controls.Add(this.TBUltimoCredito);
            this.TPDatosFinancieros.Controls.Add(this.label25);
            this.TPDatosFinancieros.Controls.Add(this.TBCreditoMaximo);
            this.TPDatosFinancieros.Controls.Add(this.label24);
            this.TPDatosFinancieros.Controls.Add(this.TBCreditoMinimo);
            this.TPDatosFinancieros.Controls.Add(this.label23);
            this.TPDatosFinancieros.Controls.Add(this.TBCuenta02);
            this.TPDatosFinancieros.Controls.Add(this.TBCuenta01);
            this.TPDatosFinancieros.Controls.Add(this.label22);
            this.TPDatosFinancieros.Controls.Add(this.label21);
            this.TPDatosFinancieros.Controls.Add(this.label20);
            this.TPDatosFinancieros.Controls.Add(this.label19);
            this.TPDatosFinancieros.Controls.Add(this.TBBancoAuxiliar);
            this.TPDatosFinancieros.Controls.Add(this.TBBancoPrincipal);
            this.TPDatosFinancieros.Location = new System.Drawing.Point(4, 24);
            this.TPDatosFinancieros.Name = "TPDatosFinancieros";
            this.TPDatosFinancieros.Size = new System.Drawing.Size(345, 249);
            this.TPDatosFinancieros.TabIndex = 3;
            this.TPDatosFinancieros.Text = "Datos Financieros";
            this.TPDatosFinancieros.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 195);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 15);
            this.label27.TabIndex = 17;
            this.label27.Text = "Credito en Mora";
            // 
            // TBCreditoMora
            // 
            this.TBCreditoMora.Location = new System.Drawing.Point(145, 195);
            this.TBCreditoMora.Name = "TBCreditoMora";
            this.TBCreditoMora.Size = new System.Drawing.Size(197, 21);
            this.TBCreditoMora.TabIndex = 16;
            this.TBCreditoMora.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCreditoMora_KeyUp);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 222);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(127, 15);
            this.label26.TabIndex = 15;
            this.label26.Text = "Valor Total del Credito";
            // 
            // TBCreditoTotal
            // 
            this.TBCreditoTotal.Location = new System.Drawing.Point(145, 222);
            this.TBCreditoTotal.Name = "TBCreditoTotal";
            this.TBCreditoTotal.Size = new System.Drawing.Size(197, 21);
            this.TBCreditoTotal.TabIndex = 14;
            this.TBCreditoTotal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCreditoTotal_KeyUp);
            // 
            // TBUltimoCredito
            // 
            this.TBUltimoCredito.Location = new System.Drawing.Point(145, 168);
            this.TBUltimoCredito.Name = "TBUltimoCredito";
            this.TBUltimoCredito.Size = new System.Drawing.Size(197, 21);
            this.TBUltimoCredito.TabIndex = 13;
            this.TBUltimoCredito.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBUltimoCredito_KeyUp);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 168);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(136, 15);
            this.label25.TabIndex = 12;
            this.label25.Text = "Valor del Ultimo Credito";
            // 
            // TBCreditoMaximo
            // 
            this.TBCreditoMaximo.Location = new System.Drawing.Point(102, 141);
            this.TBCreditoMaximo.Name = "TBCreditoMaximo";
            this.TBCreditoMaximo.Size = new System.Drawing.Size(240, 21);
            this.TBCreditoMaximo.TabIndex = 11;
            this.TBCreditoMaximo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCreditoMaximo_KeyUp);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 141);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 15);
            this.label24.TabIndex = 10;
            this.label24.Text = "Credito Maximo";
            // 
            // TBCreditoMinimo
            // 
            this.TBCreditoMinimo.Location = new System.Drawing.Point(102, 114);
            this.TBCreditoMinimo.Name = "TBCreditoMinimo";
            this.TBCreditoMinimo.Size = new System.Drawing.Size(240, 21);
            this.TBCreditoMinimo.TabIndex = 9;
            this.TBCreditoMinimo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCreditoMinimo_KeyUp);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 15);
            this.label23.TabIndex = 8;
            this.label23.Text = "Credito Minimo";
            // 
            // TBCuenta02
            // 
            this.TBCuenta02.Location = new System.Drawing.Point(102, 87);
            this.TBCuenta02.Name = "TBCuenta02";
            this.TBCuenta02.Size = new System.Drawing.Size(240, 21);
            this.TBCuenta02.TabIndex = 7;
            this.TBCuenta02.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCuenta02_KeyUp);
            // 
            // TBCuenta01
            // 
            this.TBCuenta01.Location = new System.Drawing.Point(102, 33);
            this.TBCuenta01.Name = "TBCuenta01";
            this.TBCuenta01.Size = new System.Drawing.Size(240, 21);
            this.TBCuenta01.TabIndex = 6;
            this.TBCuenta01.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBCuenta01_KeyUp);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 15);
            this.label22.TabIndex = 5;
            this.label22.Text = "Nu. Cuenta 02";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 15);
            this.label21.TabIndex = 4;
            this.label21.Text = "Nu. Cuenta 01";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 15);
            this.label20.TabIndex = 3;
            this.label20.Text = "Banco Auxiliar";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 15);
            this.label19.TabIndex = 2;
            this.label19.Text = "Banco Principal";
            // 
            // TBBancoAuxiliar
            // 
            this.TBBancoAuxiliar.Location = new System.Drawing.Point(102, 60);
            this.TBBancoAuxiliar.Name = "TBBancoAuxiliar";
            this.TBBancoAuxiliar.Size = new System.Drawing.Size(240, 21);
            this.TBBancoAuxiliar.TabIndex = 1;
            this.TBBancoAuxiliar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBancoAuxiliar_KeyUp);
            // 
            // TBBancoPrincipal
            // 
            this.TBBancoPrincipal.Location = new System.Drawing.Point(102, 6);
            this.TBBancoPrincipal.Name = "TBBancoPrincipal";
            this.TBBancoPrincipal.Size = new System.Drawing.Size(240, 21);
            this.TBBancoPrincipal.TabIndex = 0;
            this.TBBancoPrincipal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TBBancoPrincipal_KeyUp);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.BV_Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(350, 303);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseDown);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            this.btnEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminar_MouseMove);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = global::CapaPresentacion.Properties.Resources.BV_Imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(432, 303);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(76, 26);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            this.btnImprimir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnImprimir_MouseDown);
            this.btnImprimir.MouseLeave += new System.EventHandler(this.btnImprimir_MouseLeave);
            this.btnImprimir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnImprimir_MouseMove);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TBBuscar);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.btnImprimir);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.DGResultados);
            this.groupBox2.Location = new System.Drawing.Point(383, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 337);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leal Enterprise - Consulta de Clientes Registrados";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(125, 20);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(381, 21);
            this.TBBuscar.TabIndex = 7;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Consulta de Cliente";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(6, 303);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "------";
            // 
            // DGResultados
            // 
            this.DGResultados.AllowUserToAddRows = false;
            this.DGResultados.AllowUserToDeleteRows = false;
            this.DGResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGResultados.BackgroundColor = System.Drawing.Color.White;
            this.DGResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultados.Location = new System.Drawing.Point(6, 47);
            this.DGResultados.Name = "DGResultados";
            this.DGResultados.ReadOnly = true;
            this.DGResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGResultados.Size = new System.Drawing.Size(500, 253);
            this.DGResultados.TabIndex = 0;
            this.DGResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGResultados_CellDoubleClick);
            this.DGResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGResultados_KeyPress);
            // 
            // frmAlmacen_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmAlmacen_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Almacen - Cliente";
            this.Load += new System.EventHandler(this.frmAlmacen_Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TCPrincipal.ResumeLayout(false);
            this.TPDatosBasicos.ResumeLayout(false);
            this.TPDatosBasicos.PerformLayout();
            this.TPDatosDeEnvio.ResumeLayout(false);
            this.TPDatosDeEnvio.PerformLayout();
            this.TPDatosFinancieros.ResumeLayout(false);
            this.TPDatosFinancieros.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl TCPrincipal;
        private System.Windows.Forms.TabPage TPDatosBasicos;
        private System.Windows.Forms.TabPage TPDatosDeEnvio;
        private System.Windows.Forms.TabPage TPDatosFinancieros;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox TBPais;
        private System.Windows.Forms.TextBox TBCorreo;
        private System.Windows.Forms.TextBox TBMovil;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBDocumento;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBDepartamento;
        private System.Windows.Forms.TextBox TBCiudad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox TBDireccion02;
        private System.Windows.Forms.TextBox TBDireccion01;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TBDireccionPrincipal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TBPais_01;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TBCiudad_01;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TBReceptor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TBBancoAuxiliar;
        private System.Windows.Forms.TextBox TBBancoPrincipal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TBCuenta02;
        private System.Windows.Forms.TextBox TBCuenta01;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox TBCreditoMinimo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox TBCreditoMaximo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox TBCreditoMora;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox TBCreditoTotal;
        private System.Windows.Forms.TextBox TBUltimoCredito;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox TBIdcliente;
    }
}