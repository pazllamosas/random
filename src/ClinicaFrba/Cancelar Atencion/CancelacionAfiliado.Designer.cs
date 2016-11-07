﻿namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelacionAfiliado
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
            this.lblTipoCancelacion = new System.Windows.Forms.Label();
            this.cmbTipoCancelacion = new System.Windows.Forms.ComboBox();
            this.lblMotivoCancelacion = new System.Windows.Forms.Label();
            this.txtMotivoCancelacion = new System.Windows.Forms.TextBox();
            this.lblTurnosACancelar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarCanc = new System.Windows.Forms.Button();
            this.txtAfiliado = new System.Windows.Forms.TextBox();
            this.lblAfiliado = new System.Windows.Forms.Label();
            this.btnBuscarTurno = new System.Windows.Forms.Button();
            this.dgvTurnosCancelar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosCancelar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipoCancelacion
            // 
            this.lblTipoCancelacion.AutoSize = true;
            this.lblTipoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCancelacion.Location = new System.Drawing.Point(77, 293);
            this.lblTipoCancelacion.Name = "lblTipoCancelacion";
            this.lblTipoCancelacion.Size = new System.Drawing.Size(249, 20);
            this.lblTipoCancelacion.TabIndex = 0;
            this.lblTipoCancelacion.Text = "Seleccione un tipo de cancelación";
            // 
            // cmbTipoCancelacion
            // 
            this.cmbTipoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCancelacion.FormattingEnabled = true;
            this.cmbTipoCancelacion.Location = new System.Drawing.Point(350, 293);
            this.cmbTipoCancelacion.Name = "cmbTipoCancelacion";
            this.cmbTipoCancelacion.Size = new System.Drawing.Size(172, 23);
            this.cmbTipoCancelacion.TabIndex = 1;
            // 
            // lblMotivoCancelacion
            // 
            this.lblMotivoCancelacion.AutoSize = true;
            this.lblMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoCancelacion.Location = new System.Drawing.Point(56, 354);
            this.lblMotivoCancelacion.Name = "lblMotivoCancelacion";
            this.lblMotivoCancelacion.Size = new System.Drawing.Size(165, 20);
            this.lblMotivoCancelacion.TabIndex = 2;
            this.lblMotivoCancelacion.Text = "Motivo de cancelación";
            // 
            // txtMotivoCancelacion
            // 
            this.txtMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoCancelacion.Location = new System.Drawing.Point(227, 354);
            this.txtMotivoCancelacion.Name = "txtMotivoCancelacion";
            this.txtMotivoCancelacion.Size = new System.Drawing.Size(380, 24);
            this.txtMotivoCancelacion.TabIndex = 3;
            // 
            // lblTurnosACancelar
            // 
            this.lblTurnosACancelar.AutoSize = true;
            this.lblTurnosACancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnosACancelar.Location = new System.Drawing.Point(108, 130);
            this.lblTurnosACancelar.Name = "lblTurnosACancelar";
            this.lblTurnosACancelar.Size = new System.Drawing.Size(217, 20);
            this.lblTurnosACancelar.TabIndex = 5;
            this.lblTurnosACancelar.Text = "Seleccione turno/s a cancelar";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 25);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarCanc
            // 
            this.btnGuardarCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCanc.Image = global::ClinicaFrba.Properties.Resources.save;
            this.btnGuardarCanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCanc.Location = new System.Drawing.Point(238, 420);
            this.btnGuardarCanc.Name = "btnGuardarCanc";
            this.btnGuardarCanc.Size = new System.Drawing.Size(194, 44);
            this.btnGuardarCanc.TabIndex = 9;
            this.btnGuardarCanc.Text = "Guardar Cancelación";
            this.btnGuardarCanc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCanc.UseVisualStyleBackColor = true;
            this.btnGuardarCanc.Click += new System.EventHandler(this.btnGuardarCanc_Click);
            // 
            // txtAfiliado
            // 
            this.txtAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAfiliado.Location = new System.Drawing.Point(280, 59);
            this.txtAfiliado.Name = "txtAfiliado";
            this.txtAfiliado.Size = new System.Drawing.Size(163, 24);
            this.txtAfiliado.TabIndex = 11;
            this.txtAfiliado.TextChanged += new System.EventHandler(this.txtAfiliado_TextChanged);
            // 
            // lblAfiliado
            // 
            this.lblAfiliado.AutoSize = true;
            this.lblAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfiliado.Location = new System.Drawing.Point(77, 61);
            this.lblAfiliado.Name = "lblAfiliado";
            this.lblAfiliado.Size = new System.Drawing.Size(197, 20);
            this.lblAfiliado.TabIndex = 10;
            this.lblAfiliado.Text = "Ingrese número de afiliado";
            // 
            // btnBuscarTurno
            // 
            this.btnBuscarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTurno.Image = global::ClinicaFrba.Properties.Resources.busqueda;
            this.btnBuscarTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarTurno.Location = new System.Drawing.Point(449, 55);
            this.btnBuscarTurno.Name = "btnBuscarTurno";
            this.btnBuscarTurno.Size = new System.Drawing.Size(131, 32);
            this.btnBuscarTurno.TabIndex = 12;
            this.btnBuscarTurno.Text = "Buscar Turnos";
            this.btnBuscarTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarTurno.UseVisualStyleBackColor = true;
            this.btnBuscarTurno.Click += new System.EventHandler(this.btnBuscarTurno_Click);
            // 
            // dgvTurnosCancelar
            // 
            this.dgvTurnosCancelar.AllowUserToAddRows = false;
            this.dgvTurnosCancelar.AllowUserToDeleteRows = false;
            this.dgvTurnosCancelar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnosCancelar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnosCancelar.Location = new System.Drawing.Point(331, 93);
            this.dgvTurnosCancelar.Name = "dgvTurnosCancelar";
            this.dgvTurnosCancelar.ReadOnly = true;
            this.dgvTurnosCancelar.Size = new System.Drawing.Size(288, 164);
            this.dgvTurnosCancelar.TabIndex = 28;
            // 
            // CancelacionAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.ControlBox = false;
            this.Controls.Add(this.dgvTurnosCancelar);
            this.Controls.Add(this.btnBuscarTurno);
            this.Controls.Add(this.txtAfiliado);
            this.Controls.Add(this.lblAfiliado);
            this.Controls.Add(this.btnGuardarCanc);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTurnosACancelar);
            this.Controls.Add(this.txtMotivoCancelacion);
            this.Controls.Add(this.lblMotivoCancelacion);
            this.Controls.Add(this.cmbTipoCancelacion);
            this.Controls.Add(this.lblTipoCancelacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelacionAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelación";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnosCancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCancelacion;
        private System.Windows.Forms.ComboBox cmbTipoCancelacion;
        private System.Windows.Forms.Label lblMotivoCancelacion;
        private System.Windows.Forms.TextBox txtMotivoCancelacion;
        private System.Windows.Forms.Label lblTurnosACancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarCanc;
        private System.Windows.Forms.TextBox txtAfiliado;
        private System.Windows.Forms.Label lblAfiliado;
        private System.Windows.Forms.Button btnBuscarTurno;
        public System.Windows.Forms.DataGridView dgvTurnosCancelar;
    }
}