namespace ClinicaFrba.AbmRol
{
    partial class AgregarRol
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
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.lblNombreRol = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFuncionalidades = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnAsignarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarFunc = new System.Windows.Forms.Button();
            this.btnAgregarFunc = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.btnEditarNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdRol
            // 
            this.txtIdRol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtIdRol.Location = new System.Drawing.Point(16, 23);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(36, 20);
            this.txtIdRol.TabIndex = 0;
            // 
            // lblNombreRol
            // 
            this.lblNombreRol.AutoSize = true;
            this.lblNombreRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRol.Location = new System.Drawing.Point(101, 22);
            this.lblNombreRol.Name = "lblNombreRol";
            this.lblNombreRol.Size = new System.Drawing.Size(78, 18);
            this.lblNombreRol.TabIndex = 1;
            this.lblNombreRol.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(198, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.funcionalidad});
            this.dataGridView1.Location = new System.Drawing.Point(16, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 80);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblFuncionalidades
            // 
            this.lblFuncionalidades.AutoSize = true;
            this.lblFuncionalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionalidades.Location = new System.Drawing.Point(12, 67);
            this.lblFuncionalidades.Name = "lblFuncionalidades";
            this.lblFuncionalidades.Size = new System.Drawing.Size(315, 16);
            this.lblFuncionalidades.TabIndex = 8;
            this.lblFuncionalidades.Text = "Seleccione de a una las funcionalidades a asignar: ";
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // funcionalidad
            // 
            this.funcionalidad.HeaderText = "Funcionalidad";
            this.funcionalidad.Name = "funcionalidad";
            this.funcionalidad.ReadOnly = true;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(256, 219);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(157, 21);
            this.cmbUsuario.TabIndex = 11;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(13, 219);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(225, 16);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Seleccione un usuario para asignar: ";
            // 
            // btnAsignarUsuario
            // 
            this.btnAsignarUsuario.Image = global::ClinicaFrba.Properties.Resources.select;
            this.btnAsignarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarUsuario.Location = new System.Drawing.Point(454, 216);
            this.btnAsignarUsuario.Name = "btnAsignarUsuario";
            this.btnAsignarUsuario.Size = new System.Drawing.Size(121, 23);
            this.btnAsignarUsuario.TabIndex = 13;
            this.btnAsignarUsuario.Text = "Asignar Usuario";
            this.btnAsignarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarFunc
            // 
            this.btnEliminarFunc.Image = global::ClinicaFrba.Properties.Resources.delete;
            this.btnEliminarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarFunc.Location = new System.Drawing.Point(358, 172);
            this.btnEliminarFunc.Name = "btnEliminarFunc";
            this.btnEliminarFunc.Size = new System.Drawing.Size(137, 26);
            this.btnEliminarFunc.TabIndex = 10;
            this.btnEliminarFunc.Text = "Eliminar Funcionalidad";
            this.btnEliminarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarFunc.UseVisualStyleBackColor = true;
            // 
            // btnAgregarFunc
            // 
            this.btnAgregarFunc.Image = global::ClinicaFrba.Properties.Resources.add1;
            this.btnAgregarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarFunc.Location = new System.Drawing.Point(198, 172);
            this.btnAgregarFunc.Name = "btnAgregarFunc";
            this.btnAgregarFunc.Size = new System.Drawing.Size(141, 26);
            this.btnAgregarFunc.TabIndex = 9;
            this.btnAgregarFunc.Text = "Agregar Funcionalidad";
            this.btnAgregarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarFunc.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.AutoSize = true;
            this.btnVolver.Image = global::ClinicaFrba.Properties.Resources.back;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(198, 272);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(71, 29);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.Image = global::ClinicaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(410, 272);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.AutoSize = true;
            this.btnCrearRol.Image = global::ClinicaFrba.Properties.Resources.save;
            this.btnCrearRol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearRol.Location = new System.Drawing.Point(292, 272);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(92, 29);
            this.btnCrearRol.TabIndex = 4;
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearRol.UseVisualStyleBackColor = true;
            // 
            // btnEditarNombre
            // 
            this.btnEditarNombre.AutoSize = true;
            this.btnEditarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarNombre.Image = global::ClinicaFrba.Properties.Resources.modify;
            this.btnEditarNombre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarNombre.Location = new System.Drawing.Point(464, 15);
            this.btnEditarNombre.Name = "btnEditarNombre";
            this.btnEditarNombre.Size = new System.Drawing.Size(125, 25);
            this.btnEditarNombre.TabIndex = 3;
            this.btnEditarNombre.Text = "Editar Nombre";
            this.btnEditarNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarNombre.UseVisualStyleBackColor = true;
            // 
            // AgregarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 313);
            this.Controls.Add(this.btnAsignarUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.btnEliminarFunc);
            this.Controls.Add(this.btnAgregarFunc);
            this.Controls.Add(this.lblFuncionalidades);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.btnEditarNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreRol);
            this.Controls.Add(this.txtIdRol);
            this.Name = "AgregarRol";
            this.Text = "Rol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdRol;
        private System.Windows.Forms.Label lblNombreRol;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnEditarNombre;
        private System.Windows.Forms.Button btnCrearRol;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionalidad;
        private System.Windows.Forms.Label lblFuncionalidades;
        private System.Windows.Forms.Button btnAgregarFunc;
        private System.Windows.Forms.Button btnEliminarFunc;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAsignarUsuario;
    }
}