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
            dgvProfesionales.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_PROFESIONALES");
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }
    }
}
