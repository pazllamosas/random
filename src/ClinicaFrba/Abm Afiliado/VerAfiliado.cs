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
    public partial class VerAfiliado : Form
    {
        public VerAfiliado()
        {
            InitializeComponent();
        }

        private void btnCrearAf_Click(object sender, EventArgs e)
        {
            FormProvider.Agafiliado.Show();
        }

        private void btnEditarAf_Click(object sender, EventArgs e)
        {
            FormProvider.Agafiliado.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void VerAfiliado_Load(object sender, EventArgs e)
        {
            dgvAfiliados.Rows.Clear();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBusqDni.Text;
            dgvAfiliados.DataSource = Conexion.obtenerTablaProcedure("RANDOM.GET_AFILIADOS", Conexion.generarArgumentos("@DNI"), dni);
            

        }
    }
}
