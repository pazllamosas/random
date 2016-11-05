namespace ClinicaFrba.Registrar_Agenta_Medico
{
    partial class RegistrarAgenda
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbProfesional = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(64, 32);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbProfesional
            // 
            this.cmbProfesional.FormattingEnabled = true;
            this.cmbProfesional.Location = new System.Drawing.Point(343, 51);
            this.cmbProfesional.Name = "cmbProfesional";
            this.cmbProfesional.Size = new System.Drawing.Size(227, 21);
            this.cmbProfesional.TabIndex = 35;
            this.cmbProfesional.SelectedIndexChanged += new System.EventHandler(this.cmbProfesional_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Selecione el dia";
            // 
            // cmbDias
            // 
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(319, 283);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(227, 21);
            this.cmbDias.TabIndex = 38;
            this.cmbDias.SelectedIndexChanged += new System.EventHandler(this.cmbDias_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Seleccione Medico";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Hora desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Hora hasta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 343);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(473, 339);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2.TabIndex = 44;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 151);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(571, 99);
            this.dataGridView1.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Seleccione Especialidad";
            // 
            // RegistrarAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDias);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProfesional);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrarAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Profesional";
            this.Load += new System.EventHandler(this.RegistrarAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.ComboBox cmbProfesional;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}