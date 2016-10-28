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
    public partial class CambioPlanes : Form
    {
        public CambioPlanes()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Agafiliado.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {

                string nroAfiliado = txtNroAfiliado.Text;
                Int32 idPlan = cmbNuevoPlan.SelectedIndex;
                string motivo = txtMotivo.Text;

                Conexion.executeProcedure("RANDOM.CAMBIO_PLAN",
                    Conexion.generarArgumentos("@NRO_AFILIADO_RAIZ", "@IDPLAN", "@MOTIVO"),
                        nroAfiliado, idPlan, motivo);
                MessageBox.Show("Plan cambiado");
                this.Hide();
                FormProvider.Agafiliado.Show();
            }
            else
            {
                MessageBox.Show("Faltan cargar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       

        public void cargaDatos(string PlanViejo, string nroAfiliadoRaiz)
        {
            txtPlanActual.Text = PlanViejo;
            txtNroAfiliado.Text = nroAfiliadoRaiz;
        }

        private bool validacion()
        {
            if (txtMotivo.Text.Trim() == "")
                return false;
            if (cmbNuevoPlan.SelectedIndex == -1)
                return false;
            return true;
        }

        private void CambioPlanes_Load(object sender, EventArgs e)
        {
            txtNroAfiliado.Visible = false;
            cmbNuevoPlan.ValueMember = "IdPlan";
            cmbNuevoPlan.DisplayMember = "Nombre";
            cmbNuevoPlan.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_PLANES");
            cmbNuevoPlan.SelectedIndex = -1;
            this.cargaDatos(txtPlanActual.Text, txtNroAfiliado.Text);
        }
    }
}
