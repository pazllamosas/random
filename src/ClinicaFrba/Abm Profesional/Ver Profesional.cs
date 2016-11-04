using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Profesional
{
    public partial class Profesional : Form
    {
        public Profesional()
        {
            InitializeComponent();
            dgvProfesionales.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_MEDICOS");
            dgvProfesionales.Columns[0].Visible = false;
            dgvProfesionales.Columns[3].Visible = false;
            dgvProfesionales.Columns[4].Visible = false;
            dgvProfesionales.Columns[10].Visible = false;
            dgvProfesionales.Columns[11].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }
    }
}
