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
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }

        private void lblSemestre_Click(object sender, EventArgs e)
        {

        }

        private void cmbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbSemestre.SelectedIndex != -1) & (cmbPlan.SelectedIndex != -1))
            {
                mesInicio = "1";
                mesFin = "6";
            }
            else if (cmbSemestre.SelectedIndex == 1)
            {
                mesInicio = "7";
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
            anio = txtAnioAConsultar.Text;
            if (cmbSemestre.SelectedIndex != -1 && anio != "" && cmbPlan.SelectedIndex != -1)
            {
                List<string> lista = new List<string>();
                lista.Add("@fechaFrom");
                lista.Add("@fechaTo");

                switch (cmbPlan.SelectedIndex)
                {
                    case 0:
                        DataTable dt = Conexion.obtenerTablaProcedure("RANDOM.top5AfiliadosConMayorCantBonosComprados",
                        lista, (anio + "/" + mesInicio + "/01"), (anio + "/" + mesFin + "/31"), "1");
                        if (dt == null)
                        {
                            MessageBox.Show("No se han encontrado registros para ese peridodo de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.dgvResultado.DataSource = dt;
                            dgvResultado.Enabled = false;
                        }
                        break;
                    case 1:
                        DataTable dt1 = Conexion.obtenerTablaProcedure("RANDOM.top5AfiliadosConMayorCantBonosComprados",
                        lista, (anio + "/" + mesInicio + "/01"), (anio + "/" + mesFin + "/31"), "5");
                        if (dt1 == null)
                        {
                            MessageBox.Show("No se han encontrado registros para ese peridodo de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.dgvResultado.DataSource = dt1;
                            dgvResultado.Enabled = false;
                        }
                        break;
                    case 2:
                        DataTable dt2 = Conexion.obtenerTablaProcedure("RANDOM.top5AfiliadosConMayorCantBonosComprados",
                        lista, (anio + "/" + mesInicio + "/01"), (anio + "/" + mesFin + "/31"), "3");
                        if (dt2 == null)
                        {
                            MessageBox.Show("No se han encontrado registros para ese peridodo de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.dgvResultado.DataSource = dt2;
                            dgvResultado.Enabled = false;
                        }
                        break;
                    case 3:
                        DataTable dt3 = Conexion.obtenerTablaProcedure("RANDOM.top5AfiliadosConMayorCantBonosComprados",
                        lista, (anio + "/" + mesInicio + "/01"), (anio + "/" + mesFin + "/31"), "4");
                        if (dt3 == null)
                        {
                            MessageBox.Show("No se han encontrado registros para ese peridodo de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.dgvResultado.DataSource = dt3;
                            dgvResultado.Enabled = false;
                        }
                        break;
                    case 4:
                        DataTable dt4 = Conexion.obtenerTablaProcedure("RANDOM.top5AfiliadosConMayorCantBonosComprados",
                        lista, (anio + "/" + mesInicio + "/01"), (anio + "/" + mesFin + "/31"), "2");
                        if (dt4 == null)
                        {
                            MessageBox.Show("No se han encontrado registros para ese peridodo de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.dgvResultado.DataSource = dt4;
                            dgvResultado.Enabled = false;
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar una opcion en cada campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoProfporPlan_Load(object sender, EventArgs e)
        {
            this.cmbSemestre.SelectedIndex = -1;
        }

        private void txtAnioAConsultar_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtAnioAConsultar.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}