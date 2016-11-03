namespace ClinicaFrba.Pedir_Turno
{
    partial class ProfesionalTurno
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
            this.textAfiliado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHorariosDisp = new System.Windows.Forms.DataGridView();
            this.dtpTurnoPosible = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.lblProfesional = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionarProfesional = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariosDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // textAfiliado
            // 
            this.textAfiliado.Location = new System.Drawing.Point(184, 75);
            this.textAfiliado.Name = "textAfiliado";
            this.textAfiliado.Size = new System.Drawing.Size(154, 20);
            this.textAfiliado.TabIndex = 17;
            this.textAfiliado.TextChanged += new System.EventHandler(this.textAfiliado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingrese Afiliado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvHorariosDisp
            // 
            this.dgvHorariosDisp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorariosDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorariosDisp.Location = new System.Drawing.Point(32, 262);
            this.dgvHorariosDisp.MultiSelect = false;
            this.dgvHorariosDisp.Name = "dgvHorariosDisp";
            this.dgvHorariosDisp.Size = new System.Drawing.Size(638, 165);
            this.dgvHorariosDisp.TabIndex = 27;
            this.dgvHorariosDisp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorariosDisp_CellContentClick);
            // 
            // dtpTurnoPosible
            // 
            this.dtpTurnoPosible.Location = new System.Drawing.Point(358, 174);
            this.dtpTurnoPosible.Name = "dtpTurnoPosible";
            this.dtpTurnoPosible.Size = new System.Drawing.Size(200, 20);
            this.dtpTurnoPosible.TabIndex = 24;
            this.dtpTurnoPosible.ValueChanged += new System.EventHandler(this.dtpTurnoPosible_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Seleccione una fecha posible";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(559, 133);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.cmbEspecialidad.TabIndex = 22;
            this.cmbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidad_SelectedIndexChanged);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(362, 133);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(181, 18);
            this.lblEspecialidad.TabIndex = 21;
            this.lblEspecialidad.Text = "Seleccione la especialidad";
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(205, 133);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(121, 21);
            this.cmbProfesional.TabIndex = 20;
            this.cmbProfesional.SelectedIndexChanged += new System.EventHandler(this.cmbProfesional_SelectedIndexChanged);
            // 
            // lblProfesional
            // 
            this.lblProfesional.AutoSize = true;
            this.lblProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesional.Location = new System.Drawing.Point(12, 133);
            this.lblProfesional.Name = "lblProfesional";
            this.lblProfesional.Size = new System.Drawing.Size(173, 18);
            this.lblProfesional.TabIndex = 19;
            this.lblProfesional.Text = "Seleccione el profesional";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::ClinicaFrba.Properties.Resources.delete;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(443, 210);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(93, 32);
            this.btnLimpiar.TabIndex = 26;
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
            this.btnBuscar.Location = new System.Drawing.Point(196, 210);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 32);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionarProfesional
            // 
            this.btnSeleccionarProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarProfesional.Image = global::ClinicaFrba.Properties.Resources.select;
            this.btnSeleccionarProfesional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarProfesional.Location = new System.Drawing.Point(241, 441);
            this.btnSeleccionarProfesional.Name = "btnSeleccionarProfesional";
            this.btnSeleccionarProfesional.Size = new System.Drawing.Size(218, 40);
            this.btnSeleccionarProfesional.TabIndex = 28;
            this.btnSeleccionarProfesional.Text = "Seleccionar Profesional";
            this.btnSeleccionarProfesional.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionarProfesional.UseVisualStyleBackColor = true;
            this.btnSeleccionarProfesional.Click += new System.EventHandler(this.btnSeleccionarProfesional_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::ClinicaFrba.Properties.Resources.delete;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(410, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 32);
            this.button1.TabIndex = 29;
            this.button1.Text = "Limpiar Afiliado";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(15, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(79, 30);
            this.btnVolver.TabIndex = 30;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ProfesionalTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 493);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSeleccionarProfesional);
            this.Controls.Add(this.dgvHorariosDisp);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpTurnoPosible);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.lblEspecialidad);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.lblProfesional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textAfiliado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfesionalTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfesionalTurno";
            this.Load += new System.EventHandler(this.ProfesionalTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorariosDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblProfesional;
        private System.Windows.Forms.Button btnSeleccionarProfesional;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dgvHorariosDisp;
        public System.Windows.Forms.ComboBox cmbProfesional;
        public System.Windows.Forms.TextBox textAfiliado;
        private System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.ComboBox cmbEspecialidad;
        public System.Windows.Forms.DateTimePicker dtpTurnoPosible;
    }
}