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
            this.BonosDisponibles = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.seleccionarBono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnoProfesional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BonosDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurnoProfesional
            // 
            this.dgvTurnoProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTurnoProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnoProfesional.Location = new System.Drawing.Point(25, 50);
            this.dgvTurnoProfesional.Name = "dgvTurnoProfesional";
            this.dgvTurnoProfesional.Size = new System.Drawing.Size(667, 174);
            this.dgvTurnoProfesional.TabIndex = 0;
            this.dgvTurnoProfesional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurnoProfesional_CellContentClick_1);
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
            this.btnSeleccTurno.Location = new System.Drawing.Point(301, 242);
            this.btnSeleccTurno.Name = "btnSeleccTurno";
            this.btnSeleccTurno.Size = new System.Drawing.Size(160, 33);
            this.btnSeleccTurno.TabIndex = 9;
            this.btnSeleccTurno.Text = "Seleccionar Turno";
            this.btnSeleccTurno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccTurno.UseVisualStyleBackColor = true;
            this.btnSeleccTurno.Click += new System.EventHandler(this.btnSeleccTurno_Click);
            // 
            // BonosDisponibles
            // 
            this.BonosDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BonosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BonosDisponibles.Location = new System.Drawing.Point(25, 299);
            this.BonosDisponibles.Name = "BonosDisponibles";
            this.BonosDisponibles.Size = new System.Drawing.Size(667, 168);
            this.BonosDisponibles.TabIndex = 16;
            this.BonosDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BonosDisponibles_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Image = global::ClinicaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(456, 490);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 48);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // seleccionarBono
            // 
            this.seleccionarBono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionarBono.ForeColor = System.Drawing.Color.Green;
            this.seleccionarBono.Image = global::ClinicaFrba.Properties.Resources.save;
            this.seleccionarBono.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.seleccionarBono.Location = new System.Drawing.Point(156, 490);
            this.seleccionarBono.Name = "seleccionarBono";
            this.seleccionarBono.Size = new System.Drawing.Size(196, 48);
            this.seleccionarBono.TabIndex = 18;
            this.seleccionarBono.Text = "Registrar llegada";
            this.seleccionarBono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.seleccionarBono.UseVisualStyleBackColor = true;
            this.seleccionarBono.Click += new System.EventHandler(this.seleccionarBono_Click);
            // 
            // TurnoProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 550);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.seleccionarBono);
            this.Controls.Add(this.BonosDisponibles);
            this.Controls.Add(this.btnSeleccTurno);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvTurnoProfesional);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TurnoProfesional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.TurnoProfesional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnoProfesional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BonosDisponibles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnSeleccTurno;
        public System.Windows.Forms.DataGridView dgvTurnoProfesional;
        public System.Windows.Forms.DataGridView BonosDisponibles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button seleccionarBono;
    }
}