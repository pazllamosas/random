namespace ClinicaFrba.Registro_Llegada
{
    partial class TurnoProfesional
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
            this.dgvTurnoProfesional = new System.Windows.Forms.DataGridView();
            this.ColumnHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSeleccTurno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnoProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnoProfesional
            // 
            this.dgvTurnoProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnoProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHorario});
            this.dgvTurnoProfesional.Location = new System.Drawing.Point(22, 80);
            this.dgvTurnoProfesional.Name = "dgvTurnoProfesional";
            this.dgvTurnoProfesional.Size = new System.Drawing.Size(602, 221);
            this.dgvTurnoProfesional.TabIndex = 0;
            // 
            // ColumnHorario
            // 
            this.ColumnHorario.HeaderText = "Turnos del dia";
            this.ColumnHorario.Name = "ColumnHorario";
            this.ColumnHorario.ReadOnly = true;
            this.ColumnHorario.Width = 200;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(78, 32);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnSeleccTurno
            // 
            this.btnSeleccTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccTurno.Image = global::ClinicaFrba.Properties.Resources.select;
            this.btnSeleccTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccTurno.Location = new System.Drawing.Point(222, 345);
            this.btnSeleccTurno.Name = "btnSeleccTurno";
            this.btnSeleccTurno.Size = new System.Drawing.Size(164, 59);
            this.btnSeleccTurno.TabIndex = 9;
            this.btnSeleccTurno.Text = "Seleccionar Turno";
            this.btnSeleccTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccTurno.UseVisualStyleBackColor = true;
            this.btnSeleccTurno.Click += new System.EventHandler(this.btnSeleccTurno_Click);
            // 
            // TurnoProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 476);
            this.Controls.Add(this.btnSeleccTurno);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvTurnoProfesional);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TurnoProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turno";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnoProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHorario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSeleccTurno;
        public System.Windows.Forms.DataGridView dgvTurnoProfesional;
    }
}