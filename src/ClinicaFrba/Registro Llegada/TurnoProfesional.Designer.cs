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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnSeleccTurno = new System.Windows.Forms.Button();
            this.lblBonos = new System.Windows.Forms.Label();
            this.txtBonos = new System.Windows.Forms.TextBox();
            this.Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnoProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnoProfesional
            // 
            this.dgvTurnoProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnoProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnoProfesional.Location = new System.Drawing.Point(22, 80);
            this.dgvTurnoProfesional.Name = "dgvTurnoProfesional";
            this.dgvTurnoProfesional.Size = new System.Drawing.Size(602, 221);
            this.dgvTurnoProfesional.TabIndex = 0;
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
            this.btnSeleccTurno.Location = new System.Drawing.Point(259, 323);
            this.btnSeleccTurno.Name = "btnSeleccTurno";
            this.btnSeleccTurno.Size = new System.Drawing.Size(160, 33);
            this.btnSeleccTurno.TabIndex = 9;
            this.btnSeleccTurno.Text = "Seleccionar Turno";
            this.btnSeleccTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccTurno.UseVisualStyleBackColor = true;
            this.btnSeleccTurno.Click += new System.EventHandler(this.btnSeleccTurno_Click);
            // 
            // lblBonos
            // 
            this.lblBonos.AutoSize = true;
            this.lblBonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonos.Location = new System.Drawing.Point(41, 383);
            this.lblBonos.Name = "lblBonos";
            this.lblBonos.Size = new System.Drawing.Size(308, 18);
            this.lblBonos.TabIndex = 10;
            this.lblBonos.Text = "Cantidad de bonos disponibles para el afiliado";
            this.lblBonos.Click += new System.EventHandler(this.lblBonos_Click);
            // 
            // txtBonos
            // 
            this.txtBonos.Location = new System.Drawing.Point(408, 381);
            this.txtBonos.Name = "txtBonos";
            this.txtBonos.Size = new System.Drawing.Size(107, 20);
            this.txtBonos.TabIndex = 14;
            this.txtBonos.TextChanged += new System.EventHandler(this.txtBonos_TextChanged);
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Volver.ForeColor = System.Drawing.Color.Blue;
            this.Volver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.Volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Volver.Location = new System.Drawing.Point(274, 421);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(122, 43);
            this.Volver.TabIndex = 15;
            this.Volver.Text = "Volver";
            this.Volver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // TurnoProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 476);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.txtBonos);
            this.Controls.Add(this.lblBonos);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSeleccTurno;
        public System.Windows.Forms.DataGridView dgvTurnoProfesional;
        private System.Windows.Forms.Label lblBonos;
        private System.Windows.Forms.TextBox txtBonos;
        private System.Windows.Forms.Button Volver;
    }
}