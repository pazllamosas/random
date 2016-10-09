namespace ClinicaFrba.Cancelar_Atencion
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
            this.clbTurnosCancelar = new System.Windows.Forms.CheckedListBox();
            this.lblTurnosACancelar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarCanc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTipoCancelacion
            // 
            this.lblTipoCancelacion.AutoSize = true;
            this.lblTipoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCancelacion.Location = new System.Drawing.Point(26, 148);
            this.lblTipoCancelacion.Name = "lblTipoCancelacion";
            this.lblTipoCancelacion.Size = new System.Drawing.Size(194, 15);
            this.lblTipoCancelacion.TabIndex = 0;
            this.lblTipoCancelacion.Text = "Seleccione un tipo de cancelación";
            // 
            // cmbTipoCancelacion
            // 
            this.cmbTipoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCancelacion.FormattingEnabled = true;
            this.cmbTipoCancelacion.Location = new System.Drawing.Point(238, 145);
            this.cmbTipoCancelacion.Name = "cmbTipoCancelacion";
            this.cmbTipoCancelacion.Size = new System.Drawing.Size(151, 23);
            this.cmbTipoCancelacion.TabIndex = 1;
            // 
            // lblMotivoCancelacion
            // 
            this.lblMotivoCancelacion.AutoSize = true;
            this.lblMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivoCancelacion.Location = new System.Drawing.Point(26, 200);
            this.lblMotivoCancelacion.Name = "lblMotivoCancelacion";
            this.lblMotivoCancelacion.Size = new System.Drawing.Size(129, 15);
            this.lblMotivoCancelacion.TabIndex = 2;
            this.lblMotivoCancelacion.Text = "Motivo de cancelación";
            // 
            // txtMotivoCancelacion
            // 
            this.txtMotivoCancelacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoCancelacion.Location = new System.Drawing.Point(178, 200);
            this.txtMotivoCancelacion.Name = "txtMotivoCancelacion";
            this.txtMotivoCancelacion.Size = new System.Drawing.Size(380, 21);
            this.txtMotivoCancelacion.TabIndex = 3;
            // 
            // clbTurnosCancelar
            // 
            this.clbTurnosCancelar.FormattingEnabled = true;
            this.clbTurnosCancelar.Location = new System.Drawing.Point(220, 19);
            this.clbTurnosCancelar.Name = "clbTurnosCancelar";
            this.clbTurnosCancelar.Size = new System.Drawing.Size(151, 94);
            this.clbTurnosCancelar.TabIndex = 4;
            // 
            // lblTurnosACancelar
            // 
            this.lblTurnosACancelar.AutoSize = true;
            this.lblTurnosACancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnosACancelar.Location = new System.Drawing.Point(35, 19);
            this.lblTurnosACancelar.Name = "lblTurnosACancelar";
            this.lblTurnosACancelar.Size = new System.Drawing.Size(168, 15);
            this.lblTurnosACancelar.TabIndex = 5;
            this.lblTurnosACancelar.Text = "Seleccione turno/s a cancelar";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(196, 277);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 25);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarCanc
            // 
            this.btnGuardarCanc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCanc.Image = global::ClinicaFrba.Properties.Resources.save;
            this.btnGuardarCanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCanc.Location = new System.Drawing.Point(333, 277);
            this.btnGuardarCanc.Name = "btnGuardarCanc";
            this.btnGuardarCanc.Size = new System.Drawing.Size(169, 25);
            this.btnGuardarCanc.TabIndex = 9;
            this.btnGuardarCanc.Text = "Guardar Cancelación";
            this.btnGuardarCanc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCanc.UseVisualStyleBackColor = true;
            // 
            // CancelacionAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 314);
            this.Controls.Add(this.btnGuardarCanc);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTurnosACancelar);
            this.Controls.Add(this.clbTurnosCancelar);
            this.Controls.Add(this.txtMotivoCancelacion);
            this.Controls.Add(this.lblMotivoCancelacion);
            this.Controls.Add(this.cmbTipoCancelacion);
            this.Controls.Add(this.lblTipoCancelacion);
            this.Name = "CancelacionAfiliado";
            this.Text = "Cancelación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoCancelacion;
        private System.Windows.Forms.ComboBox cmbTipoCancelacion;
        private System.Windows.Forms.Label lblMotivoCancelacion;
        private System.Windows.Forms.TextBox txtMotivoCancelacion;
        private System.Windows.Forms.CheckedListBox clbTurnosCancelar;
        private System.Windows.Forms.Label lblTurnosACancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardarCanc;
    }
}