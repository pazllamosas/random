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
    public partial class ListadoEspecBono : Form
    {
        string mesInicio;
        string mesFin;
        string anio;
        public ListadoEspecBono()
        {
            InitializeComponent();
            dgvResultado.Rows.Clear();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            dgvResultado.Columns.Clear();
            txtAnioAConsultar.Clear();
            this.cmbSemestre.SelectedIndex = -1; 
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvResultado.Columns.Clear();
            txtAnioAConsultar.Clear();
            this.cmbSemestre.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvResultado.Columns.Clear();
            anio = txtAnioAConsultar.Text;
            if (cmbSemestre.SelectedIndex != -1 && anio != "")
            {
                List<string> lista = new List<string>();
                lista.Add("@fechaFrom");
                lista.Add("@fechaTo");

                if (mesFin == "12")
                {
                    DataTable dt = Conexion.obtenerTablaProcedure("RANDOM.top5EspecialidadesConMasConsultasUtilizadas",
                    lista, (anio + "/" + mesInicio + "/01"), (anio + "/" + mesFin + "/31"));
                    if (dt == null)
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
                    DataTable dt = Conexion.obtenerTablaProcedure("RANDOM.top5EspecialidadesConMasConsultasUtilizadas",
                    lista, (anio + "/" + mesInicio + "/01"), (anio + "/" + mesFin + "/30"));
                    if (dt == null)
                    {
                        MessageBox.Show("No se han encontrado registros para ese peridodo de fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.dgvResultado.DataSource = dt;
                        dgvResultado.Enabled = false;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Debe ingresar una opcion en cada campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoEspecBono_Load(object sender, EventArgs e)
        {
            this.cmbSemestre.SelectedIndex = -1;
        }

        private void cmbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAnioAConsultar_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtAnioAConsultar.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSemestre_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSemestre.SelectedIndex == 0)
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

        private void txtAnioAConsultar_TextChanged_1(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtAnioAConsultar.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
