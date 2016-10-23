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
            this.Hide();
            FormProvider.Agafiliado.Show();
        }
    }
}
