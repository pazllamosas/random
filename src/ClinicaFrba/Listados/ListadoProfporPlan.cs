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
        public ListadoProfporPlan()
        {
            InitializeComponent();
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

        }
    }
}
