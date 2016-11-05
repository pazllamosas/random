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
            this.limpiarCampos();
            this.Hide();
            FormProvider.Agafiliado.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {

                //string documento = txtDocumento.Text;
                string numeroAfiliado = txtDocumento.Text;
                Int32 idPlan = cmbNuevoPlan.SelectedIndex;
                string motivo = txtMotivo.Text;

                Conexion.executeProcedure("RANDOM.CAMBIO_PLAN",
                    Conexion.generarArgumentos("@NUMERO_AFILIADO_RAIZ", "@IDPLAN", "@MOTIVO"),
                        numeroAfiliado, idPlan, motivo);
                MessageBox.Show("Plan cambiado");
                this.Hide();
                FormProvider.Agafiliado.Show();
            }
            else
            {
                MessageBox.Show("Faltan cargar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

       

        public void cargaDatos(string PlanViejo, string documento)
        {
            txtPlanActual.Text = PlanViejo;
            txtDocumento.Text = documento;
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
            txtDocumento.Visible = false;
            cmbNuevoPlan.ValueMember = "IdPlan";
            cmbNuevoPlan.DisplayMember = "Nombre";
            cmbNuevoPlan.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_PLANES");
            this.cargaDatos(txtPlanActual.Text, txtDocumento.Text);
            cmbNuevoPlan.SelectedIndex = -1;

        }

        public void limpiarCampos()
        {
            cmbNuevoPlan.SelectedIndex = -1;
            txtMotivo.Clear();
        }

    }
}
