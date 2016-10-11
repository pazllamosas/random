namespace ClinicaFrba.Cancelar_Atencion
{
    partial class Cancelacion
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
            this.btnCancelacionMedico = new System.Windows.Forms.Button();
            this.btnCancelacionAfiliado = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancelacionMedico
            // 
            this.btnCancelacionMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancelacionMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelacionMedico.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelacionMedico.Location = new System.Drawing.Point(65, 171);
            this.btnCancelacionMedico.Name = "btnCancelacionMedico";
            this.btnCancelacionMedico.Size = new System.Drawing.Size(247, 117);
            this.btnCancelacionMedico.TabIndex = 0;
            this.btnCancelacionMedico.Text = "Médico";
            this.btnCancelacionMedico.UseVisualStyleBackColor = false;
            this.btnCancelacionMedico.Click += new System.EventHandler(this.btnCancelacionMedico_Click);
            // 
            // btnCancelacionAfiliado
            // 
            this.btnCancelacionAfiliado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelacionAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelacionAfiliado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelacionAfiliado.Location = new System.Drawing.Point(358, 171);
            this.btnCancelacionAfiliado.Name = "btnCancelacionAfiliado";
            this.btnCancelacionAfiliado.Size = new System.Drawing.Size(247, 117);
            this.btnCancelacionAfiliado.TabIndex = 1;
            this.btnCancelacionAfiliado.Text = "Afiliado";
            this.btnCancelacionAfiliado.UseVisualStyleBackColor = false;
            this.btnCancelacionAfiliado.Click += new System.EventHandler(this.btnCancelacionAfiliado_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(73, 32);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Cancelacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelacionAfiliado);
            this.Controls.Add(this.btnCancelacionMedico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cancelacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelacionMedico;
        private System.Windows.Forms.Button btnCancelacionAfiliado;
        private System.Windows.Forms.Button btnVolver;
    }
}