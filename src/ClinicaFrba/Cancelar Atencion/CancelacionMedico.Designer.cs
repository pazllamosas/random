namespace ClinicaFrba.Cancelar_Atencion
{
    partial class CancelacionMedico
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
            this.txtMotivoCancelacion = new System.Windows.Forms.TextBox();
            this.lblMotivoCancelacion = new System.Windows.Forms.Label();
            this.cmbTipoCancelacion = new System.Windows.Forms.ComboBox();
            this.lblTipoCancelacion = new System.Windows.Forms.Label();
            this.btnGuardarCanc = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMotivoCancelacion
            // 
            this.txtMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoCancelacion.Location = new System.Drawing.Point(243, 317);
            this.txtMotivoCancelacion.Name = "txtMotivoCancelacion";
            this.txtMotivoCancelacion.Size = new System.Drawing.Size(354, 21);
            this.txtMotivoCancelacion.TabIndex = 13;
            // 
            // lblMotivoCancelacion
            // 
            this.lblMotivoCancelacion.AutoSize = true;
            this.lblMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoCancelacion.Location = new System.Drawing.Point(72, 318);
            this.lblMotivoCancelacion.Name = "lblMotivoCancelacion";
            this.lblMotivoCancelacion.Size = new System.Drawing.Size(165, 20);
            this.lblMotivoCancelacion.TabIndex = 12;
            this.lblMotivoCancelacion.Text = "Motivo de cancelación";
            // 
            // cmbTipoCancelacion
            // 
            this.cmbTipoCancelacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCancelacion.FormattingEnabled = true;
            this.cmbTipoCancelacion.Location = new System.Drawing.Point(366, 241);
            this.cmbTipoCancelacion.Name = "cmbTipoCancelacion";
            this.cmbTipoCancelacion.Size = new System.Drawing.Size(183, 23);
            this.cmbTipoCancelacion.TabIndex = 11;
            // 
            // lblTipoCancelacion
            // 
            this.lblTipoCancelacion.AutoSize = true;
            this.lblTipoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCancelacion.Location = new System.Drawing.Point(111, 241);
            this.lblTipoCancelacion.Name = "lblTipoCancelacion";
            this.lblTipoCancelacion.Size = new System.Drawing.Size(249, 20);
            this.lblTipoCancelacion.TabIndex = 10;
            this.lblTipoCancelacion.Text = "Seleccione un tipo de cancelación";
            // 
            // btnGuardarCanc
            // 
            this.btnGuardarCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCanc.Image = global::ClinicaFrba.Properties.Resources.save;
            this.btnGuardarCanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCanc.Location = new System.Drawing.Point(224, 416);
            this.btnGuardarCanc.Name = "btnGuardarCanc";
            this.btnGuardarCanc.Size = new System.Drawing.Size(211, 36);
            this.btnGuardarCanc.TabIndex = 15;
            this.btnGuardarCanc.Text = "Guardar Cancelación";
            this.btnGuardarCanc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCanc.UseVisualStyleBackColor = true;
            this.btnGuardarCanc.Click += new System.EventHandler(this.btnGuardarCanc_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 25);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(40, 141);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(56, 20);
            this.lblDesde.TabIndex = 16;
            this.lblDesde.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(108, 141);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(208, 20);
            this.dtpDesde.TabIndex = 18;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(422, 141);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 19;
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(368, 69);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesional.TabIndex = 22;
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(175, 69);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(185, 20);
            this.lblProfesional.TabIndex = 21;
            this.lblProfesional.Text = "Seleccione el profesional";
            // 
            // CancelacionMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.ControlBox = false;
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.btnGuardarCanc);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtMotivoCancelacion);
            this.Controls.Add(this.lblMotivoCancelacion);
            this.Controls.Add(this.cmbTipoCancelacion);
            this.Controls.Add(this.lblTipoCancelacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CancelacionMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarCanc;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtMotivoCancelacion;
        private System.Windows.Forms.Label lblMotivoCancelacion;
        private System.Windows.Forms.ComboBox cmbTipoCancelacion;
        private System.Windows.Forms.Label lblTipoCancelacion;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        public System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Label lblProfesional;
    }
}