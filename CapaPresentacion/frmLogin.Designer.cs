﻿namespace CapaPresentacion
{
    partial class frmLogin
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
            this.TBInicioDeSesion = new System.Windows.Forms.TextBox();
            this.TBCopyrigth = new System.Windows.Forms.TextBox();
            this.TBDesarrollo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBInicioDeSesion);
            this.groupBox1.Controls.Add(this.TBCopyrigth);
            this.groupBox1.Controls.Add(this.TBDesarrollo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TBContraseña);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leal Enterprise - Login de Acceso";
            // 
            // TBInicioDeSesion
            // 
            this.TBInicioDeSesion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBInicioDeSesion.Location = new System.Drawing.Point(6, 74);
            this.TBInicioDeSesion.Multiline = true;
            this.TBInicioDeSesion.Name = "TBInicioDeSesion";
            this.TBInicioDeSesion.Size = new System.Drawing.Size(279, 20);
            this.TBInicioDeSesion.TabIndex = 10;
            this.TBInicioDeSesion.Text = "Inicio de Sesion...";
            this.TBInicioDeSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBCopyrigth
            // 
            this.TBCopyrigth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCopyrigth.Location = new System.Drawing.Point(6, 100);
            this.TBCopyrigth.Multiline = true;
            this.TBCopyrigth.Name = "TBCopyrigth";
            this.TBCopyrigth.Size = new System.Drawing.Size(279, 20);
            this.TBCopyrigth.TabIndex = 9;
            this.TBCopyrigth.Text = "Copyrigth 2019 - Leal Enterprise v1.0";
            this.TBCopyrigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBDesarrollo
            // 
            this.TBDesarrollo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBDesarrollo.Location = new System.Drawing.Point(6, 126);
            this.TBDesarrollo.Multiline = true;
            this.TBDesarrollo.Name = "TBDesarrollo";
            this.TBDesarrollo.Size = new System.Drawing.Size(279, 20);
            this.TBDesarrollo.TabIndex = 8;
            this.TBDesarrollo.Text = "Desarrollado por Leal Ingenieria";
            this.TBDesarrollo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(291, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 126);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TBContraseña
            // 
            this.TBContraseña.Location = new System.Drawing.Point(85, 47);
            this.TBContraseña.Name = "TBContraseña";
            this.TBContraseña.PasswordChar = '*';
            this.TBContraseña.Size = new System.Drawing.Size(200, 21);
            this.TBContraseña.TabIndex = 3;
            this.TBContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBContraseña.Enter += new System.EventHandler(this.TBContraseña_Enter);
            this.TBContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBContraseña_KeyPress);
            this.TBContraseña.Leave += new System.EventHandler(this.TBContraseña_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(85, 20);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(200, 21);
            this.TBUsuario.TabIndex = 0;
            this.TBUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBUsuario.Enter += new System.EventHandler(this.TBUsuario_Enter);
            this.TBUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBUsuario_KeyPress);
            this.TBUsuario.Leave += new System.EventHandler(this.TBUsuario_Leave);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 173);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBInicioDeSesion;
        private System.Windows.Forms.TextBox TBCopyrigth;
        private System.Windows.Forms.TextBox TBDesarrollo;
    }
}