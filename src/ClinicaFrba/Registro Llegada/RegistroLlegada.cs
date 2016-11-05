using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ClinicaFrba.Registro_Llegada
{
    public partial class RegistroLlegada : Form
    {
        public RegistroLlegada()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
            dgvLlegada.DataSource = null;
            cmbProfesional.Text = null;
            cmbEspecialidad.Text = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Apellido = cmbProfesional.Text;
            string descripcion = cmbEspecialidad.Text;
            DateTime fechaHoy = funciones.ObtenerFecha();
            String diaS = FormProvider.ProfesionalTurno.dayOfWeek(fechaHoy);
            Int32 dia = funciones.numeroDiaSemana(diaS);
            dgvLlegada.DataSource = Conexion.obtenerTablaProcedure("RANDOM.FILTRAR_MEDICO", Conexion.generarArgumentos("@Descripcion", "@Apellido", "@Fecha", "@DiaNumero"), descripcion, Apellido, fechaHoy, dia);
            dgvLlegada.Columns[2].Visible = false;
            dgvLlegada.Columns[4].Visible = false;
            dgvLlegada.Columns[5].Visible = false;
            dgvLlegada.Columns[6].Visible = false;
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegLlegada_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = dgvLlegada.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                DataGridViewRow d = dgvLlegada.SelectedRows[0];
                string IdMedicoS = d.Cells[2].Value.ToString();
                Int32 IdMedico = Convert.ToInt32(IdMedicoS);
                DateTime fechaHoy = funciones.ObtenerFecha();
                string IdEspecialidadS = d.Cells[4].Value.ToString();
                Int32 IdEspecialidad = Convert.ToInt32(IdEspecialidadS);
                FormProvider.TurnoProf.dgvTurnoProfesional.DataSource = Conexion.obtenerTablaProcedure("RANDOM.TRAER_TURNOS_MEDICO", Conexion.generarArgumentos("@IdMedico", "@FechaHoy", "@IdEspecialidad"), IdMedico, fechaHoy, IdEspecialidad);
                FormProvider.TurnoProf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Elegir un profesional", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }


        private void RegistroLlegada_Load(object sender, EventArgs e)
        {
            Conexion.establecerConexionBD();

            cmbEspecialidad.ValueMember = "IdEspecialidad";
            cmbEspecialidad.DisplayMember = "Descripcion";
            cmbEspecialidad.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_ESPECIALIDAD");

            cmbProfesional.ValueMember = "IdPersona";
            cmbProfesional.DisplayMember = "Apellido";
            cmbProfesional.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_MEDICOS");

            this.cmbEspecialidad.SelectedIndex = -1;
            this.cmbProfesional.SelectedIndex = -1;
        }




        private void dgvLlegada_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvLlegada.DataSource = null;
            cmbProfesional.Text = null;
            cmbEspecialidad.Text = null;
        }

        private void dgvLlegada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}