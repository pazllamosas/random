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
    public partial class ConsultaHistorial : Form
    {
        string numeroAfiliadoRaiz;

        public ConsultaHistorial()
        {
            InitializeComponent();
        }

        public void cargaDatos(string nroAfiliadoRaiz)
        {
            numeroAfiliadoRaiz = nroAfiliadoRaiz;
            dgvHistorial.DataSource = Conexion.obtenerTablaProcedure("RANDOM.GET_HISTORIAL",
                Conexion.generarArgumentos("@NUMERO_AFILIADO_RAIZ"), numeroAfiliadoRaiz);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }
    }
}

