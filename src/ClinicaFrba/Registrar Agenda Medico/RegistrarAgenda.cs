using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class RegistrarAgenda : Form
    {
        public RegistrarAgenda()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarAgenda_Load(object sender, EventArgs e)
        {
            Conexion.establecerConexionBD();

            cmbProfesional.ValueMember = "IdPersona";
            cmbProfesional.DisplayMember = "Apellido";
            cmbProfesional.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_MEDICOS");

            this.cmbProfesional.SelectedIndex = -1;

            List<string> listaDias = new List<string>();
            listaDias.Add("Lunes");
            listaDias.Add("Martes");
            listaDias.Add("Miercoles");
            listaDias.Add("Jueves");
            listaDias.Add("Viernes");
            listaDias.Add("Sabado");
            cmbDias.DataSource = listaDias;
            this.cmbDias.SelectedIndex = -1;
            this.comboBox1.SelectedIndex = -1;
            this.comboBox2.SelectedIndex = -1;
            
        }


        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> listaDesde = new List<string>();
            List<string> listaHasta = new List<string>();

            if (cmbDias.Text == "Sabado")
            {
                listaDesde.Add("10:00");
                listaDesde.Add("10:30");
                listaDesde.Add("11:00");
                listaDesde.Add("11:30");
                listaDesde.Add("12:00");
                listaDesde.Add("12:30");
                listaDesde.Add("13:00");
                listaDesde.Add("13:30");
                listaDesde.Add("14:00");
                listaDesde.Add("14:30");

                listaHasta.Add("10:30");
                listaHasta.Add("11:00");
                listaHasta.Add("11:30");
                listaHasta.Add("12:00");
                listaHasta.Add("12:30");
                listaHasta.Add("13:00");
                listaHasta.Add("13:30");
                listaHasta.Add("14:00");
                listaHasta.Add("14:30");
                listaHasta.Add("15:00");
            }
            else
            {
                listaHasta.Add("07:00");
                listaHasta.Add("07:30");
                listaHasta.Add("08:00");
                listaHasta.Add("08:30");
                listaHasta.Add("09:00");
                listaHasta.Add("09:30");
                listaHasta.Add("10:00");
                listaHasta.Add("10:30");
                listaHasta.Add("11:00");
                listaHasta.Add("11:30");
                listaHasta.Add("12:00");
                listaHasta.Add("12:30");
                listaHasta.Add("13:00");
                listaHasta.Add("13:30");
                listaHasta.Add("14:00");
                listaHasta.Add("14:30");
                listaHasta.Add("15:00");
                listaHasta.Add("15:30");
                listaHasta.Add("16:00");
                listaHasta.Add("16:30");
                listaHasta.Add("17:00");
                listaHasta.Add("17:30");
                listaHasta.Add("18:00");
                listaHasta.Add("18:30");
                listaHasta.Add("19:00");
                listaHasta.Add("19:30");

                listaDesde.Add("07:00");
                listaDesde.Add("07:30");
                listaDesde.Add("08:00");
                listaDesde.Add("08:30");
                listaDesde.Add("09:00");
                listaDesde.Add("09:30");
                listaDesde.Add("10:00");
                listaDesde.Add("10:30");
                listaDesde.Add("11:00");
                listaDesde.Add("11:30");
                listaDesde.Add("12:00");
                listaDesde.Add("12:30");
                listaDesde.Add("13:00");
                listaDesde.Add("13:30");
                listaDesde.Add("14:00");
                listaDesde.Add("14:30");
                listaDesde.Add("15:00");
                listaDesde.Add("15:30");
                listaDesde.Add("16:00");
                listaDesde.Add("16:30");
                listaDesde.Add("17:00");
                listaDesde.Add("17:30");
                listaDesde.Add("18:00");
                listaDesde.Add("18:30");
                listaDesde.Add("19:00");
                listaDesde.Add("19:30");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
