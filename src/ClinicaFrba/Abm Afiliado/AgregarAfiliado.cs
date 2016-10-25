using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AgregarAfiliado : Form
    {
        public AgregarAfiliado()
        {
            InitializeComponent();
        }

        private void AgregarAfiliado_Load(object sender, EventArgs e)
        {
            cmbPlanMedico.ValueMember = "IdPlan";
            cmbPlanMedico.DisplayMember = "Nombre";
            cmbPlanMedico.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_PLANES");

            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Masculino");

            cmbEstadoCivil.ValueMember = "IdEstadoCivil";
            cmbEstadoCivil.DisplayMember = "Descripcion";
            cmbEstadoCivil.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_ESTADO_CIVIL");

            cmbTipoDoc.ValueMember = "IdTipoDocumento";
            cmbTipoDoc.DisplayMember = "Descripcion";
            cmbTipoDoc.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_TIPO_DOCUMENTO");

            this.cmbPlanMedico.SelectedIndex = -1;
            this.cmbSexo.SelectedIndex = -1;
            this.cmbEstadoCivil.SelectedIndex = -1;
            this.cmbTipoDoc.SelectedIndex = -1;





           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Afiliado.Show(); 
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFamACargo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCambiarPlan_Click(object sender, EventArgs e)
        {
            FormProvider.CambioPlanAfiliado.Show();
        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarFamiliar_Click(object sender, EventArgs e)
        {
            FormProvider.AgregarFamiliarAfiliado.Show();
        }
    }
}
