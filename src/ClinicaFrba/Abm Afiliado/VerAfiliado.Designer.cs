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
            this.dgvAfiliados = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCrearAf = new System.Windows.Forms.Button();
            this.btnBajaAf = new System.Windows.Forms.Button();
            this.btnEditarAf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(159, 57);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(144, 24);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Ingrese su DNI: ";
            // 
            // txtBusqDni
            // 
            this.txtBusqDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqDni.Location = new System.Drawing.Point(309, 57);
            this.txtBusqDni.Name = "txtBusqDni";
            this.txtBusqDni.Size = new System.Drawing.Size(158, 24);
            this.txtBusqDni.TabIndex = 1;
            this.txtBusqDni.TextChanged += new System.EventHandler(this.txtBusqDni_TextChanged);
            // 
            // dgvAfiliados
            // 
            this.dgvAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfiliados.Location = new System.Drawing.Point(16, 174);
            this.dgvAfiliados.Name = "dgvAfiliados";
            this.dgvAfiliados.Size = new System.Drawing.Size(647, 171);
            this.dgvAfiliados.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::ClinicaFrba.Properties.Resources.delete;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(333, 114);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 42);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::ClinicaFrba.Properties.Resources.busqueda;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(218, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 42);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 32);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCrearAf
            // 
            this.btnCrearAf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAf.Image = global::ClinicaFrba.Properties.Resources.add;
            this.btnCrearAf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearAf.Location = new System.Drawing.Point(151, 408);
            this.btnCrearAf.Name = "btnCrearAf";
            this.btnCrearAf.Size = new System.Drawing.Size(130, 40);
            this.btnCrearAf.TabIndex = 6;
            this.btnCrearAf.Text = "Nuevo Afiliado";
            this.btnCrearAf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearAf.UseVisualStyleBackColor = true;
            this.btnCrearAf.Click += new System.EventHandler(this.btnCrearAf_Click);
            // 
            // btnBajaAf
            // 
            this.btnBajaAf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaAf.Image = global::ClinicaFrba.Properties.Resources.cancel;
            this.btnBajaAf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBajaAf.Location = new System.Drawing.Point(302, 408);
            this.btnBajaAf.Name = "btnBajaAf";
            this.btnBajaAf.Size = new System.Drawing.Size(116, 40);
            this.btnBajaAf.TabIndex = 5;
            this.btnBajaAf.Text = "Dar de Baja";
            this.btnBajaAf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBajaAf.UseVisualStyleBackColor = true;
            this.btnBajaAf.Click += new System.EventHandler(this.btnBajaAf_Click);
            // 
            // btnEditarAf
            // 
            this.btnEditarAf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAf.Image = global::ClinicaFrba.Properties.Resources.modify;
            this.btnEditarAf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarAf.Location = new System.Drawing.Point(439, 408);
            this.btnEditarAf.Name = "btnEditarAf";
            this.btnEditarAf.Size = new System.Drawing.Size(76, 40);
            this.btnEditarAf.TabIndex = 4;
            this.btnEditarAf.Text = "Editar";
            this.btnEditarAf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarAf.UseVisualStyleBackColor = true;
            this.btnEditarAf.Click += new System.EventHandler(this.btnEditarAf_Click);
            // 
            // VerAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCrearAf);
            this.Controls.Add(this.btnBajaAf);
            this.Controls.Add(this.btnEditarAf);
            this.Controls.Add(this.dgvAfiliados);
            this.Controls.Add(this.txtBusqDni);
            this.Controls.Add(this.lblDni);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afiliado";
            this.Load += new System.EventHandler(this.VerAfiliado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfiliados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        internal System.Windows.Forms.TextBox txtBusqDni;
        private System.Windows.Forms.DataGridView dgvAfiliados;
        private System.Windows.Forms.Button btnEditarAf;
        private System.Windows.Forms.Button btnBajaAf;
        private System.Windows.Forms.Button btnCrearAf;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
    }
}