namespace ClinicaFrba.Abm_Afiliado
{
    partial class VerAfiliado
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
            this.lblDni = new System.Windows.Forms.Label();
            this.txtBusqDni = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditarAf = new System.Windows.Forms.Button();
            this.btnBajaAf = new System.Windows.Forms.Button();
            this.btnCrearAf = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(13, 28);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(102, 16);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Ingrese su DNI: ";
            // 
            // txtBusqDni
            // 
            this.txtBusqDni.Location = new System.Drawing.Point(121, 27);
            this.txtBusqDni.Name = "txtBusqDni";
            this.txtBusqDni.Size = new System.Drawing.Size(124, 20);
            this.txtBusqDni.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Green;
            this.btnBuscar.Location = new System.Drawing.Point(275, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 36);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 171);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnEditarAf
            // 
            this.btnEditarAf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAf.Image = global::ClinicaFrba.Properties.Resources.modify;
            this.btnEditarAf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAf.Location = new System.Drawing.Point(435, 269);
            this.btnEditarAf.Name = "btnEditarAf";
            this.btnEditarAf.Size = new System.Drawing.Size(76, 32);
            this.btnEditarAf.TabIndex = 4;
            this.btnEditarAf.Text = "Editar";
            this.btnEditarAf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAf.UseVisualStyleBackColor = true;
            // 
            // btnBajaAf
            // 
            this.btnBajaAf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaAf.Image = global::ClinicaFrba.Properties.Resources.cancel;
            this.btnBajaAf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaAf.Location = new System.Drawing.Point(310, 269);
            this.btnBajaAf.Name = "btnBajaAf";
            this.btnBajaAf.Size = new System.Drawing.Size(101, 32);
            this.btnBajaAf.TabIndex = 5;
            this.btnBajaAf.Text = "Dar de Baja";
            this.btnBajaAf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaAf.UseVisualStyleBackColor = true;
            // 
            // btnCrearAf
            // 
            this.btnCrearAf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAf.Image = global::ClinicaFrba.Properties.Resources.add;
            this.btnCrearAf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearAf.Location = new System.Drawing.Point(180, 269);
            this.btnCrearAf.Name = "btnCrearAf";
            this.btnCrearAf.Size = new System.Drawing.Size(110, 32);
            this.btnCrearAf.TabIndex = 6;
            this.btnCrearAf.Text = "Nuevo Afiliado";
            this.btnCrearAf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearAf.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(16, 269);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(70, 32);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // VerAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 313);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCrearAf);
            this.Controls.Add(this.btnBajaAf);
            this.Controls.Add(this.btnEditarAf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqDni);
            this.Controls.Add(this.lblDni);
            this.Name = "VerAfiliado";
            this.Text = "Afiliado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        internal System.Windows.Forms.TextBox txtBusqDni;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditarAf;
        private System.Windows.Forms.Button btnBajaAf;
        private System.Windows.Forms.Button btnCrearAf;
        private System.Windows.Forms.Button btnVolver;
    }
}