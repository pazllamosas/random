using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class TurnoProfesional : Form
    {
        public TurnoProfesional()
        {
            InitializeComponent();
        }

        public void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.RegistroLlegada.Show();
        }

        private void TurnoProfesional_Load(object sender, EventArgs e)
        {
            seleccionarBono.Visible = false;
        }

        public void btnSeleccTurno_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = dgvTurnoProfesional.SelectedRows[0];
            string fechaHoraTurnoS = d.Cells[0].Value.ToString();
            DateTime fechaHoraTurno = Convert.ToDateTime(fechaHoraTurnoS);

            string fecha = System.Configuration.ConfigurationManager.AppSettings["fecha"];
            DateTime fechaHoy = Convert.ToDateTime(fecha);

            if ((fechaHoraTurno.Hour > fechaHoy.Hour) || ((fechaHoraTurno.Hour == fechaHoy.Hour) && (fechaHoraTurno.Minute >= fechaHoy.Minute)))
            {
                string afiliadoS = d.Cells[1].Value.ToString();
                Int32 afiliado = Convert.ToInt32(afiliadoS);

                BonosDisponibles.DataSource = Conexion.obtenerTablaProcedure("RANDOM.BONOS_DISPONIBLES", Conexion.generarArgumentos("@IdAfiliado"), afiliado);
                seleccionarBono.Visible = true;
            }
            else
            {
                MessageBox.Show("Esta pasada la hora del turno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        public void dgvTurnoProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBonos_Click(object sender, EventArgs e)
        {

        }

        private void txtBonos_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTurnoProfesional_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BonosDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    

        private void seleccionarBono_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = BonosDisponibles.SelectedRows[0];
            string afiliadoS = d.Cells[0].Value.ToString();
            Int32 afiliado = Convert.ToInt32(afiliadoS);
            string IdBonoS = d.Cells[1].Value.ToString();
            Int32 IdBono = Convert.ToInt32(IdBonoS);
            bool resultado = Conexion.executeProcedure("RANDOM.REGISTRO_LLEGADA", Conexion.generarArgumentos("@IdAfiliado", "IdBono"), afiliado, IdBono);
            if (resultado)
            {
                MessageBox.Show("Se registro la llegada con exito");
            }
            else
            {
                MessageBox.Show("No se registro la llegada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.Hide();
            FormProvider.RegistroLlegada.Show();
            FormProvider.RegistroLlegada.dgvLlegada.DataSource = null;
            FormProvider.RegistroLlegada.cmbProfesional.Text = null;
            FormProvider.RegistroLlegada.Text = null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
            FormProvider.RegistroLlegada.dgvLlegada.DataSource = null;
            FormProvider.RegistroLlegada.cmbProfesional.Text = null;
            FormProvider.RegistroLlegada.Text = null;
        }
    }
}