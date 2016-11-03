using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Pedir_Turno
{
    public partial class Turno : Form
    {
        public Turno()
        {
            InitializeComponent();
        }

        private void btnSeleccionarTurno_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = dataGridView1.SelectedRows[0];
            string ocupado = d.Cells[1].Value.ToString();

            if (ocupado == "")
            {
                MessageBox.Show("Confirme el turno");
                confirmarTurno.Visible = true;
            }
            else
            {
                MessageBox.Show("El turno esta ocupado, seleccionar un turno disponible", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }


        private void dgvHorariosDisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbEspecialidad_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        public void textProfesional_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAfiliado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Especialidad_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Turno_Load(object sender, EventArgs e)
        {
            confirmarTurno.Visible = false;
        }

        private void textFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //limpieza - eventos
            this.Hide();
            FormProvider.ProfesionalTurno.Show();
        }

        private void confirmarTurno_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = dataGridView1.SelectedRows[0];
            string turnoS = d.Cells[0].Value.ToString();
            DateTime fechaHoraTurnoElegida = Convert.ToDateTime(turnoS);
            string afiliadoS = textAfiliado.Text;
            Int32 afiliado = Convert.ToInt32(afiliadoS);
            DataGridViewRow d2 = FormProvider.ProfesionalTurno.dgvHorariosDisp.SelectedRows[0];
            string ProfesionalS = d2.Cells[2].Value.ToString();
            //ME ESTA ROMPIENDO ACA NOSE PORQUE!
            Int32 profesional = Convert.ToInt32(ProfesionalS);
            string especialidad = textEspecialidad.Text;

            String diaS = FormProvider.ProfesionalTurno.dayOfWeek(fechaHoraTurnoElegida);
            Int32 Dia = FormProvider.ProfesionalTurno.numeroDiaSemana(diaS);

            bool resultado = Conexion.executeProcedure("RANDOM.RESERVO_FECHA_TURNO", Conexion.generarArgumentos("@FechaElegida", "@Afiliado", "@Profesional", "@Dia", "@especialidad"), fechaHoraTurnoElegida, afiliado, profesional, Dia, especialidad);
            if (resultado)
            {
                MessageBox.Show("Turno asignado con exito");
            }
            else
            {
                MessageBox.Show("El turno no fue asignado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Hide();
            FormProvider.MainMenu.Show();
        }

    }

}