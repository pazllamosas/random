using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            DateTime fechaActual = funciones.ObtenerFecha();
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            DateTime fechaElegida = Convert.ToDateTime(textFecha.Text);
            if (selectedRowCount == 1)//primero que si o si elija uno
            {
                DataGridViewRow d = dataGridView1.SelectedRows[0];
                string fechaQueAtiendeS = d.Cells[0].Value.ToString();
                DateTime fechaQueAtiende = Convert.ToDateTime(fechaQueAtiendeS);

                if (fechaActual.Year == fechaElegida.Year && fechaActual.Month == fechaElegida.Month && fechaActual.Day == fechaElegida.Day)
                {
                    //si es en el mismo dia




                    if (fechaActual.Hour < fechaQueAtiende.Hour || fechaActual.Hour == fechaQueAtiende.Hour && fechaActual.Minute < fechaQueAtiende.Minute)
                    //chequeo no sea antes de hora actual
                    {

                        Int32 x = validarAfiliadoTurno(Convert.ToInt32(textAfiliado.Text), fechaQueAtiende.Year, fechaQueAtiende.Month, fechaQueAtiende.Day, fechaQueAtiende.Hour, fechaQueAtiende.Minute);
                        if (x == 1)
                        {
                            MessageBox.Show("Confirme el turno");
                            confirmarTurno.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("El afiliado ya tiene un turno asignado en ese mismo dia y horario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No puede elegir para antes de hora actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                if (fechaActual != fechaElegida)
                {

                    Int32 x = validarAfiliadoTurno(Convert.ToInt32(textAfiliado.Text), fechaQueAtiende.Year, fechaQueAtiende.Month, fechaQueAtiende.Day, fechaQueAtiende.Hour, fechaQueAtiende.Minute);
                    if (x == 1)
                    {
                        MessageBox.Show("Confirme el turno");
                        confirmarTurno.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("El afiliado ya tiene un turno asignado en ese mismo dia y horario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Elegir un turno", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

            }
        }

        public Int32 validarAfiliadoTurno(Int32 afiliado, Int32 Año, Int32 Mes, Int32 Dia, Int32 Hora, Int32 Minutos)
        {
            string query =
                "SELECT RANDOM.VALIDACION_TURNOS_POR_AFILIADO ('" + afiliado + "', '" + Año + "' ,'" + Mes + "', '" + Dia + "' ,'" + Hora + "', '" + Minutos + "' ) AS id";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            Int32 validacion = int.Parse(reader["id"].ToString());
            reader.Close();
            return validacion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
            FormProvider.ProfesionalTurno.dgvHorariosDisp.DataSource = null;
            FormProvider.ProfesionalTurno.cmbProfesional.Text = null;
            FormProvider.ProfesionalTurno.cmbEspecialidad.Text = null;
            DateTime fechaHoy = funciones.ObtenerFecha();
            FormProvider.ProfesionalTurno.dtpTurnoPosible.Value = fechaHoy;
            FormProvider.ProfesionalTurno.textAfiliado.Text = null;
            confirmarTurno.Visible = false;
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
            textProfesional.ReadOnly = true;
            textEspecialidad.ReadOnly = true;
            textAfiliado.ReadOnly = true;
            textFecha.ReadOnly = true;
        }

        private void textFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //limpieza - eventos
            this.Hide();
            FormProvider.ProfesionalTurno.Show();
            confirmarTurno.Visible = false;

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
            Int32 profesional = Convert.ToInt32(ProfesionalS);
            string especialidad = textEspecialidad.Text;

            String diaS = FormProvider.ProfesionalTurno.dayOfWeek(fechaHoraTurnoElegida);
            Int32 Dia = funciones.numeroDiaSemana(diaS);

            bool resultado = Conexion.executeProcedure("RANDOM.RESERVO_FECHA_TURNO", Conexion.generarArgumentos("@FechaElegida", "@Afiliado", "@Profesional", "@Dia", "@especialidad"), fechaHoraTurnoElegida, afiliado, profesional, Dia, especialidad);
            if (resultado)
            {
                MessageBox.Show("Turno asignado con exito");
                confirmarTurno.Visible = false;
            }
            else
            {
                MessageBox.Show("El turno no fue asignado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Hide();
            FormProvider.MainMenu.Show();
            FormProvider.ProfesionalTurno.dgvHorariosDisp.DataSource = null;
            FormProvider.ProfesionalTurno.cmbProfesional.Text = null;
            FormProvider.ProfesionalTurno.cmbEspecialidad.Text = null;
            DateTime fechaHoy = funciones.ObtenerFecha();
            FormProvider.ProfesionalTurno.dtpTurnoPosible.Value = fechaHoy;
            FormProvider.ProfesionalTurno.textAfiliado.Text = null;

        }

    }

}
