namespace ClinicaFrba.Abm_Afiliado
{
    partial class AgregarAfiliado
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEstCivil = new System.Windows.Forms.Label();
            this.lblFamACarg = new System.Windows.Forms.Label();
            this.lblPlanMed = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbPlanMedico = new System.Windows.Forms.ComboBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtFamACargo = new System.Windows.Forms.TextBox();
            this.txtNroAf = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCambiarPlan = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarFamiliar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblApellido.Location = new System.Drawing.Point(47, 52);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(77, 21);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido: ";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNombre.Location = new System.Drawing.Point(48, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTipoDoc.Location = new System.Drawing.Point(350, 51);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(133, 21);
            this.lblTipoDoc.TabIndex = 2;
            this.lblTipoDoc.Text = "Tipo Documento: ";
            this.lblTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNroDoc.Location = new System.Drawing.Point(350, 105);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(133, 21);
            this.lblNroDoc.TabIndex = 3;
            this.lblNroDoc.Text = "Nro Documento: ";
            this.lblNroDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDomicilio.Location = new System.Drawing.Point(11, 340);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(114, 21);
            this.lblDomicilio.TabIndex = 4;
            this.lblDomicilio.Text = "Domicilio: ";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDomicilio.Click += new System.EventHandler(this.lblDomicilio_Click);
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTel.Location = new System.Drawing.Point(10, 293);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(114, 21);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Teléfono: ";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTel.Click += new System.EventHandler(this.lblTel_Click);
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMail.Location = new System.Drawing.Point(369, 166);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(114, 21);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Mail: ";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMail.Click += new System.EventHandler(this.lblMail_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFechaNac.Location = new System.Drawing.Point(13, 219);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(112, 44);
            this.lblFechaNac.TabIndex = 7;
            this.lblFechaNac.Text = "Fecha Nacimiento: ";
            this.lblFechaNac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSexo.Location = new System.Drawing.Point(58, 164);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(66, 21);
            this.lblSexo.TabIndex = 8;
            this.lblSexo.Text = "Sexo: ";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEstCivil
            // 
            this.lblEstCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstCivil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEstCivil.Location = new System.Drawing.Point(392, 290);
            this.lblEstCivil.Name = "lblEstCivil";
            this.lblEstCivil.Size = new System.Drawing.Size(91, 21);
            this.lblEstCivil.TabIndex = 9;
            this.lblEstCivil.Text = "Estado Civil: ";
            this.lblEstCivil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFamACarg
            // 
            this.lblFamACarg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamACarg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFamACarg.Location = new System.Drawing.Point(329, 340);
            this.lblFamACarg.Name = "lblFamACarg";
            this.lblFamACarg.Size = new System.Drawing.Size(165, 21);
            this.lblFamACarg.TabIndex = 10;
            this.lblFamACarg.Text = "Familiares a Cargo: ";
            this.lblFamACarg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlanMed
            // 
            this.lblPlanMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanMed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPlanMed.Location = new System.Drawing.Point(374, 213);
            this.lblPlanMed.Name = "lblPlanMed";
            this.lblPlanMed.Size = new System.Drawing.Size(109, 21);
            this.lblPlanMed.TabIndex = 11;
            this.lblPlanMed.Text = "Plan Médico: ";
            this.lblPlanMed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(130, 53);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(182, 20);
            this.txtApellido.TabIndex = 12;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(489, 105);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(153, 20);
            this.txtNroDoc.TabIndex = 14;
            this.txtNroDoc.TextChanged += new System.EventHandler(this.txtNroDoc_TextChanged);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(130, 342);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(182, 20);
            this.txtDomicilio.TabIndex = 15;
            this.txtDomicilio.TextChanged += new System.EventHandler(this.txtDomicilio_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(489, 164);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(153, 20);
            this.txtMail.TabIndex = 16;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(130, 164);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(180, 21);
            this.cmbSexo.TabIndex = 17;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(489, 51);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoDoc.TabIndex = 18;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(130, 293);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(182, 20);
            this.txtTelefono.TabIndex = 19;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // cmbPlanMedico
            // 
            this.cmbPlanMedico.FormattingEnabled = true;
            this.cmbPlanMedico.Location = new System.Drawing.Point(489, 214);
            this.cmbPlanMedico.Name = "cmbPlanMedico";
            this.cmbPlanMedico.Size = new System.Drawing.Size(153, 21);
            this.cmbPlanMedico.TabIndex = 22;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(489, 292);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(153, 21);
            this.cmbEstadoCivil.TabIndex = 23;
            // 
            // txtFamACargo
            // 
            this.txtFamACargo.Location = new System.Drawing.Point(489, 342);
            this.txtFamACargo.Name = "txtFamACargo";
            this.txtFamACargo.Size = new System.Drawing.Size(153, 20);
            this.txtFamACargo.TabIndex = 24;
            this.txtFamACargo.TextChanged += new System.EventHandler(this.txtFamACargo_TextChanged);
            // 
            // txtNroAf
            // 
            this.txtNroAf.Location = new System.Drawing.Point(515, 12);
            this.txtNroAf.Name = "txtNroAf";
            this.txtNroAf.ReadOnly = true;
            this.txtNroAf.Size = new System.Drawing.Size(144, 20);
            this.txtNroAf.TabIndex = 27;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Checked = false;
            this.dtpFechaNac.Location = new System.Drawing.Point(130, 240);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(218, 20);
            this.dtpFechaNac.TabIndex = 29;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::ClinicaFrba.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(239, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(187, 37);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Crear Afiliado Principal";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCambiarPlan
            // 
            this.btnCambiarPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarPlan.Image = global::ClinicaFrba.Properties.Resources.modify;
            this.btnCambiarPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCambiarPlan.Location = new System.Drawing.Point(500, 241);
            this.btnCambiarPlan.Name = "btnCambiarPlan";
            this.btnCambiarPlan.Size = new System.Drawing.Size(120, 33);
            this.btnCambiarPlan.TabIndex = 30;
            this.btnCambiarPlan.Text = "Cambiar Plan";
            this.btnCambiarPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambiarPlan.UseVisualStyleBackColor = true;
            this.btnCambiarPlan.Click += new System.EventHandler(this.btnCambiarPlan_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(130, 424);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(76, 37);
            this.btnVolver.TabIndex = 28;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarFamiliar
            // 
            this.btnAgregarFamiliar.Enabled = false;
            this.btnAgregarFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFamiliar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarFamiliar.Image = global::ClinicaFrba.Properties.Resources.add;
            this.btnAgregarFamiliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarFamiliar.Location = new System.Drawing.Point(462, 424);
            this.btnAgregarFamiliar.Name = "btnAgregarFamiliar";
            this.btnAgregarFamiliar.Size = new System.Drawing.Size(140, 37);
            this.btnAgregarFamiliar.TabIndex = 32;
            this.btnAgregarFamiliar.Text = "Agregar Familiar";
            this.btnAgregarFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarFamiliar.UseVisualStyleBackColor = true;
            this.btnAgregarFamiliar.Click += new System.EventHandler(this.btnAgregarFamiliar_Click);
            // 
            // AgregarAfiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.Controls.Add(this.btnAgregarFamiliar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCambiarPlan);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtNroAf);
            this.Controls.Add(this.txtFamACargo);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.cmbPlanMedico);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblPlanMed);
            this.Controls.Add(this.lblFamACarg);
            this.Controls.Add(this.lblEstCivil);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarAfiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afiliado";
            this.Load += new System.EventHandler(this.AgregarAfiliado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEstCivil;
        private System.Windows.Forms.Label lblFamACarg;
        private System.Windows.Forms.Label lblPlanMed;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbPlanMedico;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.TextBox txtFamACargo;
        private System.Windows.Forms.TextBox txtNroAf;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Button btnCambiarPlan;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregarFamiliar;
    }
}