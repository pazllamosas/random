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
        private static bool editando = false;
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

        public void EditarAfiliado(string idAfiliado, string apellido, string nombre, string nroDocumento, string telefono, string direccion, string fechaNacimiento, string sexo, string tipoDocumento, string plan,string estadoCivil, string cantACargo, string mail, string nroAfiliadoRaiz, string nroAfiliadoExt)
        {
            txtApellido.Text = apellido;
            txtNombre.Text = nombre;
            txtNroDoc.Text = nroDocumento;
            txtTelefono.Text = telefono;
            txtDomicilio.Text = direccion;
            dtpFechaNac.Text = fechaNacimiento;
            cmbSexo.Text = sexo;
            txtFamACargo.Text = cantACargo;
            txtMail.Text = mail;
            txtNroAf.Text = (nroAfiliadoRaiz + " " + nroAfiliadoExt);
            cmbEstadoCivil.SelectedValue = Convert.ToInt32(estadoCivil);
            cmbPlanMedico.Text = plan;
            cmbTipoDoc.Text = tipoDocumento;

            


            editando = true;

            btnGuardar.Text = "Guardar";


            
            

        }
    }
}
