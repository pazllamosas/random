using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listados
{
    public partial class ListadoProfporPlan : Form
    {
        string mesInicio;
        string mesFin;
        string anio;
        public ListadoProfporPlan()
        {
            InitializeComponent();
            dgvResultado.Rows.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            dgvResultado.Columns.Clear();
            txtAnioAConsultar.Clear();
            this.cmbSemestre.SelectedIndex = -1;
            this.cmbPlan.SelectedIndex = -1; 
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }

        private void lblSemestre_Click(object sender, EventArgs e)
        {

        }

        private void cmbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSemestre.SelectedIndex == 0)
            {
                mesInicio = "01";
                mesFin = "06";
            }
            else if (cmbSemestre.SelectedIndex == 1)
            {
                mesInicio = "07";
                mesFin = "12";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvResultado.Columns.Clear();
            txtAnioAConsultar.Clear();
            this.cmbSemestre.SelectedIndex = -1;
            this.cmbPlan.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvResultado.Columns.Clear();
            anio = txtAnioAConsultar.Text;
            if (cmbSemestre.SelectedIndex != -1 && anio != "" && cmbPlan.SelectedIndex != -1)
            {
                List<string> lista = new List<string>();
                lista.Add("@fechaFrom");
                lista.Add("@fechaTo");
                lista.Add("@numeroPlan");

                DataTable dt = null;

                if (mesFin == "12")
                {
                    dt = Conexion.obtenerTablaProcedure("RANDOM.top5ProfesionalesMasConsultadosPorPlan",
                    lista, (anio + mesInicio + "01"), (anio + mesFin + "31"), cmbPlan.SelectedValue);
                }
                else
                {
                    dt = Conexion.obtenerTablaProcedure("RANDOM.top5ProfesionalesMasConsultadosPorPlan",
                    lista, (anio + mesInicio + "01"), (anio + mesFin + "30"), cmbPlan.SelectedValue);
                }

                if (dt == null)
                {
                    MessageBox.Show("Se produjo un error durante la ejecución de la consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No se han encontrado registros para ese peridodo de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.dgvResultado.DataSource = dt;
                    dgvResultado.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar una opcion en cada campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoProfporPlan_Load(object sender, EventArgs e)
        {
            cmbPlan.ValueMember = "Abono";
            cmbPlan.DisplayMember = "Abono";
            cmbPlan.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_PLANES");
            this.cmbSemestre.SelectedIndex = -1;
            this.cmbPlan.SelectedIndex = -1;
        }

        private void txtAnioAConsultar_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtAnioAConsultar.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAnioAConsultar_TextChanged_1(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtAnioAConsultar.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}