namespace ClinicaFrba.Listados
{
    partial class ListadoAfiliadoMasBonos
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
            this.txtAnioAConsultar = new System.Windows.Forms.TextBox();
            this.lblAnioConsultar = new System.Windows.Forms.Label();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.ColumnAfiliado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrupoFamiliar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblAfiliadoBonos = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnioAConsultar
            // 
            this.txtAnioAConsultar.Location = new System.Drawing.Point(523, 100);
            this.txtAnioAConsultar.Name = "txtAnioAConsultar";
            this.txtAnioAConsultar.Size = new System.Drawing.Size(100, 20);
            this.txtAnioAConsultar.TabIndex = 38;
            // 
            // lblAnioConsultar
            // 
            this.lblAnioConsultar.AutoSize = true;
            this.lblAnioConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioConsultar.Location = new System.Drawing.Point(351, 100);
            this.lblAnioConsultar.Name = "lblAnioConsultar";
            this.lblAnioConsultar.Size = new System.Drawing.Size(166, 18);
            this.lblAnioConsultar.TabIndex = 37;
            this.lblAnioConsultar.Text = "Ingrese año a consultar:";
            this.lblAnioConsultar.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Location = new System.Drawing.Point(205, 100);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(121, 21);
            this.cmbSemestre.TabIndex = 36;
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestre.Location = new System.Drawing.Point(19, 103);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(171, 18);
            this.lblSemestre.TabIndex = 35;
            this.lblSemestre.Text = "Seleccione un semestre:";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAfiliado,
            this.ColumnCant,
            this.ColumnGrupoFamiliar});
            this.dgvResultado.Location = new System.Drawing.Point(12, 237);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(647, 205);
            this.dgvResultado.TabIndex = 39;
            // 
            // ColumnAfiliado
            // 
            this.ColumnAfiliado.HeaderText = "Afiliado";
            this.ColumnAfiliado.Name = "ColumnAfiliado";
            this.ColumnAfiliado.ReadOnly = true;
            this.ColumnAfiliado.Width = 200;
            // 
            // ColumnCant
            // 
            this.ColumnCant.HeaderText = "Cantidad";
            this.ColumnCant.Name = "ColumnCant";
            this.ColumnCant.ReadOnly = true;
            this.ColumnCant.Width = 150;
            // 
            // ColumnGrupoFamiliar
            // 
            this.ColumnGrupoFamiliar.HeaderText = "Pertenece a grupo familiar";
            this.ColumnGrupoFamiliar.Name = "ColumnGrupoFamiliar";
            this.ColumnGrupoFamiliar.ReadOnly = true;
            this.ColumnGrupoFamiliar.Width = 150;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::ClinicaFrba.Properties.Resources.delete;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(331, 174);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(95, 35);
            this.btnLimpiar.TabIndex = 41;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::ClinicaFrba.Properties.Resources.busqueda;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(219, 174);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 35);
            this.btnBuscar.TabIndex = 40;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 9);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(73, 30);
            this.btnVolver.TabIndex = 42;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblAfiliadoBonos
            // 
            this.lblAfiliadoBonos.AutoSize = true;
            this.lblAfiliadoBonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfiliadoBonos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAfiliadoBonos.Location = new System.Drawing.Point(153, 14);
            this.lblAfiliadoBonos.Name = "lblAfiliadoBonos";
            this.lblAfiliadoBonos.Size = new System.Drawing.Size(364, 20);
            this.lblAfiliadoBonos.TabIndex = 43;
            this.lblAfiliadoBonos.Text = "Afiliados con mayor cantidad de bonos comprados";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ClinicaFrba.Properties.Resources.busqueda;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(219, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 40;
            this.button1.Text = "Buscar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::ClinicaFrba.Properties.Resources.delete;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(331, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 35);
            this.button2.TabIndex = 41;
            this.button2.Text = "Limpiar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ListadoAfiliadoMasBonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.Controls.Add(this.lblAfiliadoBonos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.txtAnioAConsultar);
            this.Controls.Add(this.lblAnioConsultar);
            this.Controls.Add(this.cmbSemestre);
            this.Controls.Add(this.lblSemestre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListadoAfiliadoMasBonos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOP 5";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnioAConsultar;
        private System.Windows.Forms.Label lblAnioConsultar;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAfiliado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrupoFamiliar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblAfiliadoBonos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}