﻿namespace Pear_Inc
{
    partial class frmAgregarCargosSADM
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
            this.cmbVacante = new System.Windows.Forms.ComboBox();
            this.txtsalcar = new System.Windows.Forms.TextBox();
            this.txtnomcar = new System.Windows.Forms.TextBox();
            this.txtcodcar = new System.Windows.Forms.TextBox();
            this.lblvaccar = new System.Windows.Forms.Label();
            this.lblsalcar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcodcar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.pctEmpleados = new System.Windows.Forms.PictureBox();
            this.pctAdministradores = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdministradores)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVacante
            // 
            this.cmbVacante.BackColor = System.Drawing.Color.White;
            this.cmbVacante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVacante.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbVacante.ForeColor = System.Drawing.Color.Black;
            this.cmbVacante.FormattingEnabled = true;
            this.cmbVacante.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbVacante.Location = new System.Drawing.Point(889, 417);
            this.cmbVacante.Name = "cmbVacante";
            this.cmbVacante.Size = new System.Drawing.Size(170, 33);
            this.cmbVacante.TabIndex = 23;
            // 
            // txtsalcar
            // 
            this.txtsalcar.BackColor = System.Drawing.Color.White;
            this.txtsalcar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsalcar.ForeColor = System.Drawing.Color.Black;
            this.txtsalcar.Location = new System.Drawing.Point(889, 350);
            this.txtsalcar.Name = "txtsalcar";
            this.txtsalcar.Size = new System.Drawing.Size(170, 33);
            this.txtsalcar.TabIndex = 22;
            this.txtsalcar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsalcar_KeyPress);
            // 
            // txtnomcar
            // 
            this.txtnomcar.BackColor = System.Drawing.Color.White;
            this.txtnomcar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomcar.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomcar.ForeColor = System.Drawing.Color.Black;
            this.txtnomcar.Location = new System.Drawing.Point(889, 242);
            this.txtnomcar.Name = "txtnomcar";
            this.txtnomcar.Size = new System.Drawing.Size(378, 71);
            this.txtnomcar.TabIndex = 21;
            this.txtnomcar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomcar_KeyPress);
            // 
            // txtcodcar
            // 
            this.txtcodcar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcodcar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodcar.Enabled = false;
            this.txtcodcar.ForeColor = System.Drawing.Color.Black;
            this.txtcodcar.Location = new System.Drawing.Point(889, 175);
            this.txtcodcar.Name = "txtcodcar";
            this.txtcodcar.Size = new System.Drawing.Size(170, 33);
            this.txtcodcar.TabIndex = 20;
            // 
            // lblvaccar
            // 
            this.lblvaccar.AutoSize = true;
            this.lblvaccar.BackColor = System.Drawing.Color.Transparent;
            this.lblvaccar.ForeColor = System.Drawing.Color.Black;
            this.lblvaccar.Location = new System.Drawing.Point(713, 425);
            this.lblvaccar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblvaccar.Name = "lblvaccar";
            this.lblvaccar.Size = new System.Drawing.Size(168, 25);
            this.lblvaccar.TabIndex = 19;
            this.lblvaccar.Text = "Vacantes del Cargo:";
            // 
            // lblsalcar
            // 
            this.lblsalcar.AutoSize = true;
            this.lblsalcar.BackColor = System.Drawing.Color.Transparent;
            this.lblsalcar.ForeColor = System.Drawing.Color.Black;
            this.lblsalcar.Location = new System.Drawing.Point(705, 351);
            this.lblsalcar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblsalcar.Name = "lblsalcar";
            this.lblsalcar.Size = new System.Drawing.Size(187, 25);
            this.lblsalcar.TabIndex = 18;
            this.lblsalcar.Text = "Salario del Cargo:     $";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(714, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre del Cargo:";
            // 
            // lblcodcar
            // 
            this.lblcodcar.AutoSize = true;
            this.lblcodcar.BackColor = System.Drawing.Color.Transparent;
            this.lblcodcar.ForeColor = System.Drawing.Color.Black;
            this.lblcodcar.Location = new System.Drawing.Point(721, 175);
            this.lblcodcar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcodcar.Name = "lblcodcar";
            this.lblcodcar.Size = new System.Drawing.Size(160, 25);
            this.lblcodcar.TabIndex = 16;
            this.lblcodcar.Text = "Codigo del Cargo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(1184, 509);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 66);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(1210, 695);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(138, 31);
            this.btnAtras.TabIndex = 25;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // pctEmpleados
            // 
            this.pctEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.pctEmpleados.Location = new System.Drawing.Point(0, 131);
            this.pctEmpleados.Name = "pctEmpleados";
            this.pctEmpleados.Size = new System.Drawing.Size(599, 60);
            this.pctEmpleados.TabIndex = 26;
            this.pctEmpleados.TabStop = false;
            this.pctEmpleados.Click += new System.EventHandler(this.pctEmpleados_Click);
            // 
            // pctAdministradores
            // 
            this.pctAdministradores.BackColor = System.Drawing.Color.Transparent;
            this.pctAdministradores.Location = new System.Drawing.Point(0, 245);
            this.pctAdministradores.Name = "pctAdministradores";
            this.pctAdministradores.Size = new System.Drawing.Size(599, 60);
            this.pctAdministradores.TabIndex = 27;
            this.pctAdministradores.TabStop = false;
            this.pctAdministradores.Click += new System.EventHandler(this.pctAdministradores_Click);
            // 
            // frmAgregarCargosSADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pear_Inc.Properties.Resources.frmAgregarCargos1;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.pctAdministradores);
            this.Controls.Add(this.pctEmpleados);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbVacante);
            this.Controls.Add(this.txtsalcar);
            this.Controls.Add(this.txtnomcar);
            this.Controls.Add(this.txtcodcar);
            this.Controls.Add(this.lblvaccar);
            this.Controls.Add(this.lblsalcar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcodcar);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmAgregarCargosSADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAgregarCargosSADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdministradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVacante;
        private System.Windows.Forms.TextBox txtsalcar;
        private System.Windows.Forms.TextBox txtnomcar;
        private System.Windows.Forms.TextBox txtcodcar;
        private System.Windows.Forms.Label lblvaccar;
        private System.Windows.Forms.Label lblsalcar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcodcar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.PictureBox pctEmpleados;
        private System.Windows.Forms.PictureBox pctAdministradores;
    }
}