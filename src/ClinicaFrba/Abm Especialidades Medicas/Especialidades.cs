using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Especialidades_Medicas
{
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
            dgvEspecialidades.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_ESPECIALIDAD");
            dgvEspecialidades.Columns[0].Visible = false;
            dgvEspecialidades.Columns[3].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void dgvEspecialidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
