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
            this.SuspendLayout();
            // 
            // txtMotivoCancelacion
            // 
            this.txtMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoCancelacion.Location = new System.Drawing.Point(197, 201);
            this.txtMotivoCancelacion.Name = "txtMotivoCancelacion";
            this.txtMotivoCancelacion.Size = new System.Drawing.Size(380, 21);
            this.txtMotivoCancelacion.TabIndex = 13;
            // 
            // lblMotivoCancelacion
            // 
            this.lblMotivoCancelacion.AutoSize = true;
            this.lblMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoCancelacion.Location = new System.Drawing.Point(45, 201);
            this.lblMotivoCancelacion.Name = "lblMotivoCancelacion";
            this.lblMotivoCancelacion.Size = new System.Drawing.Size(129, 15);
            this.lblMotivoCancelacion.TabIndex = 12;
            this.lblMotivoCancelacion.Text = "Motivo de cancelación";
            // 
            // cmbTipoCancelacion
            // 
            this.cmbTipoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCancelacion.FormattingEnabled = true;
            this.cmbTipoCancelacion.Location = new System.Drawing.Point(257, 140);
            this.cmbTipoCancelacion.Name = "cmbTipoCancelacion";
            this.cmbTipoCancelacion.Size = new System.Drawing.Size(151, 23);
            this.cmbTipoCancelacion.TabIndex = 11;
            // 
            // lblTipoCancelacion
            // 
            this.lblTipoCancelacion.AutoSize = true;
            this.lblTipoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCancelacion.Location = new System.Drawing.Point(45, 143);
            this.lblTipoCancelacion.Name = "lblTipoCancelacion";
            this.lblTipoCancelacion.Size = new System.Drawing.Size(194, 15);
            this.lblTipoCancelacion.TabIndex = 10;
            this.lblTipoCancelacion.Text = "Seleccione un tipo de cancelación";
            // 
            // btnGuardarCanc
            // 
            this.btnGuardarCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCanc.Image = global::ClinicaFrba.Properties.Resources.save;
            this.btnGuardarCanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCanc.Location = new System.Drawing.Point(352, 278);
            this.btnGuardarCanc.Name = "btnGuardarCanc";
            this.btnGuardarCanc.Size = new System.Drawing.Size(169, 25);
            this.btnGuardarCanc.TabIndex = 15;
            this.btnGuardarCanc.Text = "Guardar Cancelación";
            this.btnGuardarCanc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCanc.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(215, 278);
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
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(57, 70);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(43, 15);
            this.lblDesde.TabIndex = 16;
            this.lblDesde.Text = "Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(115, 70);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 18;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(407, 70);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 19;
            // 
            // CancelacionMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 314);
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
            this.Name = "CancelacionMedico";
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
    }
}