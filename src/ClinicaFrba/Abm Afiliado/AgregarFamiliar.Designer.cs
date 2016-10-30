namespace ClinicaFrba.Abm_Afiliado
{
    partial class AgregarFamiliar
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
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbTipoDoc = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.cmbFamiliar = new System.Windows.Forms.ComboBox();
            this.lblFamiliar = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarFamiliar = new System.Windows.Forms.Button();
            this.txtNroAf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(143, 284);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(180, 20);
            this.dtpFechaNac.TabIndex = 47;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(144, 342);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(182, 20);
            this.txtTelefono.TabIndex = 46;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(473, 223);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.Size = new System.Drawing.Size(178, 21);
            this.cmbTipoDoc.TabIndex = 45;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(143, 225);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(180, 21);
            this.cmbSexo.TabIndex = 44;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(473, 168);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(178, 20);
            this.txtMail.TabIndex = 43;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(473, 116);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(178, 20);
            this.txtDomicilio.TabIndex = 42;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(473, 273);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(178, 20);
            this.txtNroDoc.TabIndex = 41;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 168);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(182, 20);
            this.txtNombre.TabIndex = 40;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(143, 114);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(182, 20);
            this.txtApellido.TabIndex = 39;
            // 
            // lblSexo
            // 
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSexo.Location = new System.Drawing.Point(71, 225);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(66, 21);
            this.lblSexo.TabIndex = 38;
            this.lblSexo.Text = "Sexo: ";
            this.lblSexo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFechaNac.Location = new System.Drawing.Point(1, 283);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(136, 21);
            this.lblFechaNac.TabIndex = 37;
            this.lblFechaNac.Text = "Fecha Nacimiento: ";
            this.lblFechaNac.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMail
            // 
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMail.Location = new System.Drawing.Point(354, 168);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(114, 21);
            this.lblMail.TabIndex = 36;
            this.lblMail.Text = "Mail: ";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTel.Location = new System.Drawing.Point(24, 342);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(114, 21);
            this.lblTel.TabIndex = 35;
            this.lblTel.Text = "Teléfono: ";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDomicilio.Location = new System.Drawing.Point(354, 114);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(114, 21);
            this.lblDomicilio.TabIndex = 34;
            this.lblDomicilio.Text = "Domicilio: ";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNroDoc.Location = new System.Drawing.Point(335, 273);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(133, 21);
            this.lblNroDoc.TabIndex = 33;
            this.lblNroDoc.Text = "Nro Documento: ";
            this.lblNroDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTipoDoc.Location = new System.Drawing.Point(335, 223);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(133, 21);
            this.lblTipoDoc.TabIndex = 32;
            this.lblTipoDoc.Text = "Tipo Documento: ";
            this.lblTipoDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNombre.Location = new System.Drawing.Point(61, 168);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 21);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre: ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblApellido
            // 
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblApellido.Location = new System.Drawing.Point(60, 113);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(77, 21);
            this.lblApellido.TabIndex = 30;
            this.lblApellido.Text = "Apellido: ";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbFamiliar
            // 
            this.cmbFamiliar.FormattingEnabled = true;
            this.cmbFamiliar.Location = new System.Drawing.Point(314, 35);
            this.cmbFamiliar.Name = "cmbFamiliar";
            this.cmbFamiliar.Size = new System.Drawing.Size(184, 21);
            this.cmbFamiliar.TabIndex = 48;
            // 
            // lblFamiliar
            // 
            this.lblFamiliar.AutoSize = true;
            this.lblFamiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamiliar.Location = new System.Drawing.Point(112, 38);
            this.lblFamiliar.Name = "lblFamiliar";
            this.lblFamiliar.Size = new System.Drawing.Size(196, 18);
            this.lblFamiliar.TabIndex = 49;
            this.lblFamiliar.Text = "Seleccione familiar a asignar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::ClinicaFrba.Properties.Resources.save;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(305, 427);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 37);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(197, 427);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(76, 37);
            this.btnVolver.TabIndex = 50;
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
            this.btnAgregarFamiliar.Location = new System.Drawing.Point(422, 427);
            this.btnAgregarFamiliar.Name = "btnAgregarFamiliar";
            this.btnAgregarFamiliar.Size = new System.Drawing.Size(140, 37);
            this.btnAgregarFamiliar.TabIndex = 52;
            this.btnAgregarFamiliar.Text = "Agregar Familiar";
            this.btnAgregarFamiliar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarFamiliar.UseVisualStyleBackColor = true;
            // 
            // txtNroAf
            // 
            this.txtNroAf.Location = new System.Drawing.Point(515, 12);
            this.txtNroAf.Name = "txtNroAf";
            this.txtNroAf.ReadOnly = true;
            this.txtNroAf.Size = new System.Drawing.Size(144, 20);
            this.txtNroAf.TabIndex = 53;
            // 
            // AgregarFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 476);
            this.Controls.Add(this.txtNroAf);
            this.Controls.Add(this.btnAgregarFamiliar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblFamiliar);
            this.Controls.Add(this.cmbFamiliar);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
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
            this.Name = "AgregarFamiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Familiar";
            this.Load += new System.EventHandler(this.AgregarFamiliar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbTipoDoc;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.ComboBox cmbFamiliar;
        private System.Windows.Forms.Label lblFamiliar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarFamiliar;
        private System.Windows.Forms.TextBox txtNroAf;
    }
}