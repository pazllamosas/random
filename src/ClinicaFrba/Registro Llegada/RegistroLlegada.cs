using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class RegistroLlegada : Form
    {
        public RegistroLlegada()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormProvider.TurnoProf.Show();
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegLlegada_Click(object sender, EventArgs e)
        {

        }
    }
}
