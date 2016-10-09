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
    public partial class ListadoEstadistico : Form
    {
        public ListadoEstadistico()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void btnEspecialidadesCancelaciones_Click(object sender, EventArgs e)
        {
            FormProvider.ListadoEspCancelaciones.Show();
        }

        private void btnProfesionalesPlan_Click(object sender, EventArgs e)
        {
            FormProvider.ListadoProfPlan.Show();
        }

        private void btnProfesionalesMenosHoras_Click(object sender, EventArgs e)
        {
            FormProvider.ListadoProfHoras.Show();

        }

        private void btnAfiliadosBonosComp_Click(object sender, EventArgs e)
        {
            FormProvider.ListadoAfiliadosBonos.Show();
        }

        private void btnEspecialidadesBonos_Click(object sender, EventArgs e)
        {
            FormProvider.ListadoEspBonos.Show();
        }
    }
}
