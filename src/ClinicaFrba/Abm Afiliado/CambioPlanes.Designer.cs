namespace ClinicaFrba.Abm_Afiliado
{
    partial class CambioPlanes
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
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.txtPlanActual = new System.Windows.Forms.TextBox();
            this.cmbNuevoPlan = new System.Windows.Forms.ComboBox();
            this.lblNuevoPlan = new System.Windows.Forms.Label();
            this.lblPlanActual = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMotivo
            // 
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(15, 289);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(644, 22);
            this.txtMotivo.TabIndex = 13;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(13, 258);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(249, 18);
            this.lblMotivo.TabIndex = 12;
            this.lblMotivo.Text = "Escriba el motivo del cambio de plan";
            // 
            // txtPlanActual
            // 
            this.txtPlanActual.Location = new System.Drawing.Point(108, 42);
            this.txtPlanActual.Name = "txtPlanActual";
            this.txtPlanActual.Size = new System.Drawing.Size(200, 20);
            this.txtPlanActual.TabIndex = 11;
            // 
            // cmbNuevoPlan
            // 
            this.cmbNuevoPlan.FormattingEnabled = true;
            this.cmbNuevoPlan.Location = new System.Drawing.Point(110, 150);
            this.cmbNuevoPlan.Name = "cmbNuevoPlan";
            this.cmbNuevoPlan.Size = new System.Drawing.Size(198, 21);
            this.cmbNuevoPlan.TabIndex = 10;
            // 
            // lblNuevoPlan
            // 
            this.lblNuevoPlan.AutoSize = true;
            this.lblNuevoPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoPlan.Location = new System.Drawing.Point(12, 150);
            this.lblNuevoPlan.Name = "lblNuevoPlan";
            this.lblNuevoPlan.Size = new System.Drawing.Size(92, 18);
            this.lblNuevoPlan.TabIndex = 9;
            this.lblNuevoPlan.Text = "Nuevo Plan: ";
            // 
            // lblPlanActual
            // 
            this.lblPlanActual.AutoSize = true;
            this.lblPlanActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanActual.Location = new System.Drawing.Point(13, 45);
            this.lblPlanActual.Name = "lblPlanActual";
            this.lblPlanActual.Size = new System.Drawing.Size(88, 18);
            this.lblPlanActual.TabIndex = 8;
            this.lblPlanActual.Text = "Plan actual: ";
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(243, 385);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(85, 50);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::ClinicaFrba.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(359, 385);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 50);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(545, 13);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(100, 20);
            this.txtNroAfiliado.TabIndex = 16;
            // 
            // CambioPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.Controls.Add(this.txtNroAfiliado);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtPlanActual);
            this.Controls.Add(this.cmbNuevoPlan);
            this.Controls.Add(this.lblNuevoPlan);
            this.Controls.Add(this.lblPlanActual);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambioPlanes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambioPlanes";
            this.Load += new System.EventHandler(this.CambioPlanes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.TextBox txtPlanActual;
        private System.Windows.Forms.ComboBox cmbNuevoPlan;
        private System.Windows.Forms.Label lblNuevoPlan;
        private System.Windows.Forms.Label lblPlanActual;
        private System.Windows.Forms.TextBox txtNroAfiliado;
    }
}