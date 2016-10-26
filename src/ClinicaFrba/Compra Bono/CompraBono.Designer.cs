namespace ClinicaFrba.Compra_Bono
{
    partial class CompraBono
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
            this.lblNroAfiliado = new System.Windows.Forms.Label();
            this.txtNroAfiliado = new System.Windows.Forms.TextBox();
            this.lblCantBonos = new System.Windows.Forms.Label();
            this.txtCantBonos = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNroAfiliado
            // 
            this.lblNroAfiliado.AutoSize = true;
            this.lblNroAfiliado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroAfiliado.Location = new System.Drawing.Point(146, 71);
            this.lblNroAfiliado.Name = "lblNroAfiliado";
            this.lblNroAfiliado.Size = new System.Drawing.Size(181, 18);
            this.lblNroAfiliado.TabIndex = 0;
            this.lblNroAfiliado.Text = "Ingrese número de afiliado";
            this.lblNroAfiliado.Click += new System.EventHandler(this.lblNroAfiliado_Click);
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.Location = new System.Drawing.Point(342, 69);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(119, 20);
            this.txtNroAfiliado.TabIndex = 13;
            // 
            // lblCantBonos
            // 
            this.lblCantBonos.AutoSize = true;
            this.lblCantBonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantBonos.Location = new System.Drawing.Point(59, 147);
            this.lblCantBonos.Name = "lblCantBonos";
            this.lblCantBonos.Size = new System.Drawing.Size(268, 18);
            this.lblCantBonos.TabIndex = 14;
            this.lblCantBonos.Text = "Ingrese la cantidad de bonos a comprar";
            this.lblCantBonos.Click += new System.EventHandler(this.lblCantBonos_Click);
            // 
            // txtCantBonos
            // 
            this.txtCantBonos.Location = new System.Drawing.Point(342, 148);
            this.txtCantBonos.Name = "txtCantBonos";
            this.txtCantBonos.Size = new System.Drawing.Size(119, 20);
            this.txtCantBonos.TabIndex = 15;
            this.txtCantBonos.TextChanged += new System.EventHandler(this.txtCantBonos_TextChanged);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMonto.Location = new System.Drawing.Point(118, 279);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(218, 37);
            this.lblMonto.TabIndex = 16;
            this.lblMonto.Text = "Monto Total: ";
            this.lblMonto.Click += new System.EventHandler(this.lblMonto_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.Blue;
            this.txtMonto.Location = new System.Drawing.Point(351, 276);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMonto.Size = new System.Drawing.Size(91, 40);
            this.txtMonto.TabIndex = 17;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Image = global::ClinicaFrba.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(351, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 43);
            this.btnCancelar.TabIndex = 12;
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
            this.btnGuardar.Location = new System.Drawing.Point(205, 389);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 43);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Comprar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calcular monto total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calculoMonto_Click);
            // 
            // CompraBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtCantBonos);
            this.Controls.Add(this.lblCantBonos);
            this.Controls.Add(this.txtNroAfiliado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNroAfiliado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompraBono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra Bono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroAfiliado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNroAfiliado;
        private System.Windows.Forms.Label lblCantBonos;
        private System.Windows.Forms.TextBox txtCantBonos;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button button1;
    }
}