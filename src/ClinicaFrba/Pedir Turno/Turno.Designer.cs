namespace ClinicaFrba.Pedir_Turno
{
    partial class Turno
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSeleccionarTurno = new System.Windows.Forms.Button();
            this.Profesional = new System.Windows.Forms.Label();
            this.textProfesional = new System.Windows.Forms.TextBox();
            this.Especialidad = new System.Windows.Forms.Label();
            this.textEspecialidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textAfiliado = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 284);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Image = global::ClinicaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(545, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 48);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSeleccionarTurno
            // 
            this.btnSeleccionarTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarTurno.ForeColor = System.Drawing.Color.Green;
            this.btnSeleccionarTurno.Image = global::ClinicaFrba.Properties.Resources.save;
            this.btnSeleccionarTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionarTurno.Location = new System.Drawing.Point(99, 458);
            this.btnSeleccionarTurno.Name = "btnSeleccionarTurno";
            this.btnSeleccionarTurno.Size = new System.Drawing.Size(196, 48);
            this.btnSeleccionarTurno.TabIndex = 11;
            this.btnSeleccionarTurno.Text = "Seleccionar Turno";
            this.btnSeleccionarTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionarTurno.UseVisualStyleBackColor = true;
            this.btnSeleccionarTurno.Click += new System.EventHandler(this.btnSeleccionarTurno_Click);
            // 
            // Profesional
            // 
            this.Profesional.AutoSize = true;
            this.Profesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profesional.Location = new System.Drawing.Point(96, 52);
            this.Profesional.Name = "Profesional";
            this.Profesional.Size = new System.Drawing.Size(83, 18);
            this.Profesional.TabIndex = 19;
            this.Profesional.Text = "Profesional";
            this.Profesional.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textProfesional
            // 
            this.textProfesional.Location = new System.Drawing.Point(202, 50);
            this.textProfesional.Name = "textProfesional";
            this.textProfesional.Size = new System.Drawing.Size(154, 20);
            this.textProfesional.TabIndex = 20;
            this.textProfesional.TextChanged += new System.EventHandler(this.textProfesional_TextChanged);
            // 
            // Especialidad
            // 
            this.Especialidad.AutoSize = true;
            this.Especialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Especialidad.Location = new System.Drawing.Point(410, 52);
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.Size = new System.Drawing.Size(91, 18);
            this.Especialidad.TabIndex = 21;
            this.Especialidad.Text = "Especialidad";
            this.Especialidad.Click += new System.EventHandler(this.Especialidad_Click);
            // 
            // textEspecialidad
            // 
            this.textEspecialidad.Location = new System.Drawing.Point(526, 50);
            this.textEspecialidad.Name = "textEspecialidad";
            this.textEspecialidad.Size = new System.Drawing.Size(182, 20);
            this.textEspecialidad.TabIndex = 22;
            this.textEspecialidad.TextChanged += new System.EventHandler(this.textEspecialidad_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Afiliado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textAfiliado
            // 
            this.textAfiliado.Location = new System.Drawing.Point(202, 104);
            this.textAfiliado.Name = "textAfiliado";
            this.textAfiliado.Size = new System.Drawing.Size(154, 20);
            this.textAfiliado.TabIndex = 23;
            this.textAfiliado.TextChanged += new System.EventHandler(this.textAfiliado_TextChanged);
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(452, 104);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(49, 18);
            this.Fecha.TabIndex = 25;
            this.Fecha.Text = "Fecha";
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(526, 104);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(182, 20);
            this.textFecha.TabIndex = 26;
            this.textFecha.TextChanged += new System.EventHandler(this.textFecha_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(79, 30);
            this.btnVolver.TabIndex = 31;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 518);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAfiliado);
            this.Controls.Add(this.textEspecialidad);
            this.Controls.Add(this.Especialidad);
            this.Controls.Add(this.textProfesional);
            this.Controls.Add(this.Profesional);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionarTurno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Turno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.Turno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleccionarTurno;
        private System.Windows.Forms.Label Profesional;
        private System.Windows.Forms.Label Especialidad;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textProfesional;
        public System.Windows.Forms.TextBox textEspecialidad;
        public System.Windows.Forms.TextBox textAfiliado;
        private System.Windows.Forms.Label Fecha;
        public System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Button btnVolver;
    }
}