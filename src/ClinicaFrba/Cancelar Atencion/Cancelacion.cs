using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class Cancelacion : Form
    {
        public Cancelacion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void btnCancelacionMedico_Click(object sender, EventArgs e)
        {
            FormProvider.CancelacionMedico.Show();
        }

        private void btnCancelacionAfiliado_Click(object sender, EventArgs e)
        {
            FormProvider.CancelacionAfiliado.Show();
        }
    }
}
