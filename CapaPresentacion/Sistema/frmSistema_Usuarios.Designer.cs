namespace CapaPresentacion
{
    partial class frmSistema_Usuarios
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TPDatosBasicos = new System.Windows.Forms.TabPage();
            this.TBIdempleado = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.TBDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TPPermisos = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CBVentas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBSistema = new System.Windows.Forms.ComboBox();
            this.CBReporte = new System.Windows.Forms.ComboBox();
            this.CBRemision = new System.Windows.Forms.ComboBox();
            this.CBGestionHumana = new System.Windows.Forms.ComboBox();
            this.CBProductos = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CBAlmacen = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CBConsulta = new System.Windows.Forms.ComboBox();
            this.CBEditar = new System.Windows.Forms.ComboBox();
            this.CBEliminar = new System.Windows.Forms.ComboBox();
            this.CBGuardar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TPConsultas = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.DGResultados = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.TBBuscar = new System.Windows.Forms.TextBox();
            this.TBIdusuario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TPDatosBasicos.SuspendLayout();
            this.TPPermisos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.TPConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 323);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.BV_Eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(277, 291);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 26);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.btnEliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnEliminar_MouseDown);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.BtnEliminar_MouseLeave);
            this.btnEliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnEliminar_MouseMove);
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = global::CapaPresentacion.Properties.Resources.BV_Editar;
            this.btnEditar.Location = new System.Drawing.Point(195, 291);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(76, 26);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            this.btnEditar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnEditar_MouseDown);
            this.btnEditar.MouseLeave += new System.EventHandler(this.BtnEditar_MouseLeave);
            this.btnEditar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnEditar_MouseMove);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.BV_Guardar;
            this.btnGuardar.Location = new System.Drawing.Point(88, 291);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(76, 26);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            this.btnGuardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnGuardar_MouseDown);
            this.btnGuardar.MouseLeave += new System.EventHandler(this.BtnGuardar_MouseLeave);
            this.btnGuardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnGuardar_MouseMove);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.BV_Nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(6, 291);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 26);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            this.btnNuevo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnNuevo_MouseDown);
            this.btnNuevo.MouseLeave += new System.EventHandler(this.BtnNuevo_MouseLeave);
            this.btnNuevo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnNuevo_MouseMove);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TPDatosBasicos);
            this.tabControl1.Controls.Add(this.TPPermisos);
            this.tabControl1.Controls.Add(this.TPConsultas);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 265);
            this.tabControl1.TabIndex = 0;
            // 
            // TPDatosBasicos
            // 
            this.TPDatosBasicos.Controls.Add(this.TBIdusuario);
            this.TPDatosBasicos.Controls.Add(this.TBIdempleado);
            this.TPDatosBasicos.Controls.Add(this.btnExaminar);
            this.TPDatosBasicos.Controls.Add(this.TBDescripcion);
            this.TPDatosBasicos.Controls.Add(this.label7);
            this.TPDatosBasicos.Controls.Add(this.TBContraseña);
            this.TPDatosBasicos.Controls.Add(this.TBUsuario);
            this.TPDatosBasicos.Controls.Add(this.TBEmpleado);
            this.TPDatosBasicos.Controls.Add(this.label4);
            this.TPDatosBasicos.Controls.Add(this.label3);
            this.TPDatosBasicos.Controls.Add(this.label1);
            this.TPDatosBasicos.Location = new System.Drawing.Point(4, 24);
            this.TPDatosBasicos.Name = "TPDatosBasicos";
            this.TPDatosBasicos.Padding = new System.Windows.Forms.Padding(3);
            this.TPDatosBasicos.Size = new System.Drawing.Size(339, 237);
            this.TPDatosBasicos.TabIndex = 0;
            this.TPDatosBasicos.Text = "Datos Basicos";
            this.TPDatosBasicos.UseVisualStyleBackColor = true;
            // 
            // TBIdempleado
            // 
            this.TBIdempleado.Location = new System.Drawing.Point(9, 105);
            this.TBIdempleado.Name = "TBIdempleado";
            this.TBIdempleado.Size = new System.Drawing.Size(47, 21);
            this.TBIdempleado.TabIndex = 22;
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackgroundImage = global::CapaPresentacion.Properties.Resources.btnExaminar;
            this.btnExaminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExaminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Location = new System.Drawing.Point(309, 6);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(23, 21);
            this.btnExaminar.TabIndex = 21;
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.BtnExaminar_Click);
            // 
            // TBDescripcion
            // 
            this.TBDescripcion.Location = new System.Drawing.Point(82, 87);
            this.TBDescripcion.Multiline = true;
            this.TBDescripcion.Name = "TBDescripcion";
            this.TBDescripcion.Size = new System.Drawing.Size(250, 144);
            this.TBDescripcion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Descripcion";
            // 
            // TBContraseña
            // 
            this.TBContraseña.Location = new System.Drawing.Point(82, 60);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.Size = new System.Drawing.Size(250, 21);
            this.TBContraseña.TabIndex = 7;
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(82, 33);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(250, 21);
            this.TBUsuario.TabIndex = 6;
            // 
            // TBEmpleado
            // 
            this.TBEmpleado.Location = new System.Drawing.Point(82, 6);
            this.TBEmpleado.Name = "TBEmpleado";
            this.TBEmpleado.Size = new System.Drawing.Size(221, 21);
            this.TBEmpleado.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleado";
            // 
            // TPPermisos
            // 
            this.TPPermisos.Controls.Add(this.groupBox3);
            this.TPPermisos.Controls.Add(this.groupBox2);
            this.TPPermisos.Location = new System.Drawing.Point(4, 24);
            this.TPPermisos.Name = "TPPermisos";
            this.TPPermisos.Padding = new System.Windows.Forms.Padding(3);
            this.TPPermisos.Size = new System.Drawing.Size(339, 237);
            this.TPPermisos.TabIndex = 1;
            this.TPPermisos.Text = "Permisos - Niveles";
            this.TPPermisos.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBVentas);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CBSistema);
            this.groupBox3.Controls.Add(this.CBReporte);
            this.groupBox3.Controls.Add(this.CBRemision);
            this.groupBox3.Controls.Add(this.CBGestionHumana);
            this.groupBox3.Controls.Add(this.CBProductos);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.CBAlmacen);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(6, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 140);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permiso de Navegacion - Menu Principal";
            // 
            // CBVentas
            // 
            this.CBVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBVentas.FormattingEnabled = true;
            this.CBVentas.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBVentas.Location = new System.Drawing.Point(74, 107);
            this.CBVentas.Name = "CBVentas";
            this.CBVentas.Size = new System.Drawing.Size(80, 23);
            this.CBVentas.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ventas";
            // 
            // CBSistema
            // 
            this.CBSistema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBSistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSistema.FormattingEnabled = true;
            this.CBSistema.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBSistema.Location = new System.Drawing.Point(241, 78);
            this.CBSistema.Name = "CBSistema";
            this.CBSistema.Size = new System.Drawing.Size(80, 23);
            this.CBSistema.TabIndex = 18;
            // 
            // CBReporte
            // 
            this.CBReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBReporte.FormattingEnabled = true;
            this.CBReporte.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBReporte.Location = new System.Drawing.Point(74, 78);
            this.CBReporte.Name = "CBReporte";
            this.CBReporte.Size = new System.Drawing.Size(80, 23);
            this.CBReporte.TabIndex = 17;
            // 
            // CBRemision
            // 
            this.CBRemision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBRemision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRemision.FormattingEnabled = true;
            this.CBRemision.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBRemision.Location = new System.Drawing.Point(241, 49);
            this.CBRemision.Name = "CBRemision";
            this.CBRemision.Size = new System.Drawing.Size(80, 23);
            this.CBRemision.TabIndex = 16;
            // 
            // CBGestionHumana
            // 
            this.CBGestionHumana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBGestionHumana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGestionHumana.FormattingEnabled = true;
            this.CBGestionHumana.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBGestionHumana.Location = new System.Drawing.Point(241, 20);
            this.CBGestionHumana.Name = "CBGestionHumana";
            this.CBGestionHumana.Size = new System.Drawing.Size(80, 23);
            this.CBGestionHumana.TabIndex = 15;
            // 
            // CBProductos
            // 
            this.CBProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBProductos.FormattingEnabled = true;
            this.CBProductos.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBProductos.Location = new System.Drawing.Point(74, 49);
            this.CBProductos.Name = "CBProductos";
            this.CBProductos.Size = new System.Drawing.Size(80, 23);
            this.CBProductos.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(166, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 15);
            this.label17.TabIndex = 11;
            this.label17.Text = "Sistema";
            // 
            // CBAlmacen
            // 
            this.CBAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAlmacen.FormattingEnabled = true;
            this.CBAlmacen.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBAlmacen.Location = new System.Drawing.Point(74, 20);
            this.CBAlmacen.Name = "CBAlmacen";
            this.CBAlmacen.Size = new System.Drawing.Size(80, 23);
            this.CBAlmacen.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(166, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 15);
            this.label16.TabIndex = 10;
            this.label16.Text = "Remision";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(166, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 15);
            this.label15.TabIndex = 9;
            this.label15.Text = "Ges. Hum.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Reporte";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "Productos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Almacen";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CBConsulta);
            this.groupBox2.Controls.Add(this.CBEditar);
            this.groupBox2.Controls.Add(this.CBEliminar);
            this.groupBox2.Controls.Add(this.CBGuardar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 79);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos de Operacion";
            // 
            // CBConsulta
            // 
            this.CBConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBConsulta.FormattingEnabled = true;
            this.CBConsulta.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBConsulta.Location = new System.Drawing.Point(241, 49);
            this.CBConsulta.Name = "CBConsulta";
            this.CBConsulta.Size = new System.Drawing.Size(80, 23);
            this.CBConsulta.TabIndex = 12;
            // 
            // CBEditar
            // 
            this.CBEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEditar.FormattingEnabled = true;
            this.CBEditar.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBEditar.Location = new System.Drawing.Point(241, 20);
            this.CBEditar.Name = "CBEditar";
            this.CBEditar.Size = new System.Drawing.Size(80, 23);
            this.CBEditar.TabIndex = 11;
            // 
            // CBEliminar
            // 
            this.CBEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEliminar.FormattingEnabled = true;
            this.CBEliminar.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBEliminar.Location = new System.Drawing.Point(64, 49);
            this.CBEliminar.Name = "CBEliminar";
            this.CBEliminar.Size = new System.Drawing.Size(80, 23);
            this.CBEliminar.TabIndex = 10;
            // 
            // CBGuardar
            // 
            this.CBGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBGuardar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBGuardar.FormattingEnabled = true;
            this.CBGuardar.Items.AddRange(new object[] {
            "-",
            "Si",
            "No"});
            this.CBGuardar.Location = new System.Drawing.Point(64, 20);
            this.CBGuardar.Name = "CBGuardar";
            this.CBGuardar.Size = new System.Drawing.Size(80, 23);
            this.CBGuardar.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Guardar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Eliminar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Consulta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Editar";
            // 
            // TPConsultas
            // 
            this.TPConsultas.Controls.Add(this.lblTotal);
            this.TPConsultas.Controls.Add(this.DGResultados);
            this.TPConsultas.Controls.Add(this.label5);
            this.TPConsultas.Controls.Add(this.TBBuscar);
            this.TPConsultas.Location = new System.Drawing.Point(4, 24);
            this.TPConsultas.Name = "TPConsultas";
            this.TPConsultas.Size = new System.Drawing.Size(339, 237);
            this.TPConsultas.TabIndex = 2;
            this.TPConsultas.Text = "Consultas";
            this.TPConsultas.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(3, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 15);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "----------";
            // 
            // DGResultados
            // 
            this.DGResultados.AllowUserToAddRows = false;
            this.DGResultados.AllowUserToDeleteRows = false;
            this.DGResultados.BackgroundColor = System.Drawing.Color.White;
            this.DGResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGResultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGResultados.Location = new System.Drawing.Point(6, 48);
            this.DGResultados.Name = "DGResultados";
            this.DGResultados.ReadOnly = true;
            this.DGResultados.Size = new System.Drawing.Size(330, 186);
            this.DGResultados.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuario a Consultar";
            // 
            // TBBuscar
            // 
            this.TBBuscar.Location = new System.Drawing.Point(124, 6);
            this.TBBuscar.Name = "TBBuscar";
            this.TBBuscar.Size = new System.Drawing.Size(212, 21);
            this.TBBuscar.TabIndex = 0;
            this.TBBuscar.TextChanged += new System.EventHandler(this.TBBuscar_TextChanged);
            // 
            // TBIdusuario
            // 
            this.TBIdusuario.Location = new System.Drawing.Point(9, 132);
            this.TBIdusuario.Name = "TBIdusuario";
            this.TBIdusuario.Size = new System.Drawing.Size(47, 21);
            this.TBIdusuario.TabIndex = 23;
            // 
            // frmSistema_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 346);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmSistema_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSistema_Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSistema_Usuarios_FormClosing);
            this.Load += new System.EventHandler(this.FrmSistema_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TPDatosBasicos.ResumeLayout(false);
            this.TPDatosBasicos.PerformLayout();
            this.TPPermisos.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TPConsultas.ResumeLayout(false);
            this.TPConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGResultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TPDatosBasicos;
        private System.Windows.Forms.TextBox TBIdempleado;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox TBDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage TPPermisos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CBSistema;
        private System.Windows.Forms.ComboBox CBReporte;
        private System.Windows.Forms.ComboBox CBRemision;
        private System.Windows.Forms.ComboBox CBGestionHumana;
        private System.Windows.Forms.ComboBox CBProductos;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CBAlmacen;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CBConsulta;
        private System.Windows.Forms.ComboBox CBEditar;
        private System.Windows.Forms.ComboBox CBEliminar;
        private System.Windows.Forms.ComboBox CBGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage TPConsultas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView DGResultados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBBuscar;
        private System.Windows.Forms.ComboBox CBVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBIdusuario;
    }
}