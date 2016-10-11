namespace ClinicaFrba.Registro_Resultado
{
    partial class Diagnostico
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
            this.lblTurno = new System.Windows.Forms.Label();
            this.cckTurno = new System.Windows.Forms.CheckBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.lblEnfermedad = new System.Windows.Forms.Label();
            this.txtSintomas = new System.Windows.Forms.TextBox();
            this.txtEnfermedad = new System.Windows.Forms.TextBox();
            this.lblInfoSintomas = new System.Windows.Forms.Label();
            this.btnAgregarSintoma = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(27, 27);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(229, 18);
            this.lblTurno.TabIndex = 0;
            this.lblTurno.Text = "Marque si el turno fue concretado";
            // 
            // cckTurno
            // 
            this.cckTurno.AutoSize = true;
            this.cckTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cckTurno.Location = new System.Drawing.Point(281, 25);
            this.cckTurno.Name = "cckTurno";
            this.cckTurno.Size = new System.Drawing.Size(135, 20);
            this.cckTurno.TabIndex = 1;
            this.cckTurno.Text = "Turno Concretado";
            this.cckTurno.UseVisualStyleBackColor = true;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(104, 79);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 18);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Checked = false;
            this.dtpFecha.Location = new System.Drawing.Point(181, 79);
            this.dtpFecha.MaxDate = new System.DateTime(3000, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1999, 12, 27, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(270, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSintomas.Location = new System.Drawing.Point(90, 213);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(67, 18);
            this.lblSintomas.TabIndex = 4;
            this.lblSintomas.Text = "Sintoma:";
            // 
            // lblEnfermedad
            // 
            this.lblEnfermedad.AutoSize = true;
            this.lblEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermedad.Location = new System.Drawing.Point(65, 272);
            this.lblEnfermedad.Name = "lblEnfermedad";
            this.lblEnfermedad.Size = new System.Drawing.Size(92, 18);
            this.lblEnfermedad.TabIndex = 5;
            this.lblEnfermedad.Text = "Enfermedad:";
            // 
            // txtSintomas
            // 
            this.txtSintomas.Location = new System.Drawing.Point(181, 214);
            this.txtSintomas.Name = "txtSintomas";
            this.txtSintomas.Size = new System.Drawing.Size(244, 20);
            this.txtSintomas.TabIndex = 6;
            // 
            // txtEnfermedad
            // 
            this.txtEnfermedad.Location = new System.Drawing.Point(181, 273);
            this.txtEnfermedad.Name = "txtEnfermedad";
            this.txtEnfermedad.Size = new System.Drawing.Size(244, 20);
            this.txtEnfermedad.TabIndex = 7;
            // 
            // lblInfoSintomas
            // 
            this.lblInfoSintomas.AutoSize = true;
            this.lblInfoSintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSintomas.Location = new System.Drawing.Point(12, 164);
            this.lblInfoSintomas.Name = "lblInfoSintomas";
            this.lblInfoSintomas.Size = new System.Drawing.Size(314, 20);
            this.lblInfoSintomas.TabIndex = 11;
            this.lblInfoSintomas.Text = "Ingrese de a UNO los sintomas y agregelos";
            // 
            // btnAgregarSintoma
            // 
            this.btnAgregarSintoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSintoma.Image = global::ClinicaFrba.Properties.Resources.add;
            this.btnAgregarSintoma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarSintoma.Location = new System.Drawing.Point(453, 204);
            this.btnAgregarSintoma.Name = "btnAgregarSintoma";
            this.btnAgregarSintoma.Size = new System.Drawing.Size(152, 36);
            this.btnAgregarSintoma.TabIndex = 12;
            this.btnAgregarSintoma.Text = "Agregar Sintoma";
            this.btnAgregarSintoma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarSintoma.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Image = global::ClinicaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(374, 413);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 36);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Green;
            this.btnGuardar.Image = global::ClinicaFrba.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(212, 413);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 36);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Diagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.Controls.Add(this.btnAgregarSintoma);
            this.Controls.Add(this.lblInfoSintomas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEnfermedad);
            this.Controls.Add(this.txtSintomas);
            this.Controls.Add(this.lblEnfermedad);
            this.Controls.Add(this.lblSintomas);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cckTurno);
            this.Controls.Add(this.lblTurno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Diagnostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnóstico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.CheckBox cckTurno;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblSintomas;
        private System.Windows.Forms.Label lblEnfermedad;
        private System.Windows.Forms.TextBox txtSintomas;
        private System.Windows.Forms.TextBox txtEnfermedad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblInfoSintomas;
        private System.Windows.Forms.Button btnAgregarSintoma;
    }
}