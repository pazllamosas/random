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

namespace ClinicaFrba.Pedir_Turno
{
    public partial class ProfesionalTurno : Form
    {
        public ProfesionalTurno()
        {
            InitializeComponent();
        }

        private void textAfiliado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textAfiliado.Text = null;
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProfesionalTurno_Load(object sender, EventArgs e)
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
            DateTime fechaHoy = funciones.ObtenerFecha();
            dtpTurnoPosible.Value = fechaHoy;
        }

        private void dtpTurnoPosible_ValueChanged(object sender, EventArgs e)
        {

        }

        //busqueda de los turnos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = funciones.ObtenerFecha();
            string fechaHoraTurnoS = dtpTurnoPosible.Text;
            DateTime fechaHora = Convert.ToDateTime(fechaHoraTurnoS);
            int comparacion = DateTime.Compare(fechaHoy, fechaHora);

            //verifica que la fecha sea la correcta
            if (comparacion < 0 || (fechaHoy.Year == fechaHora.Year && fechaHoy.Day == fechaHora.Day && fechaHoy.Month == fechaHora.Month))
            {
                String dia = dayOfWeek(fechaHora);
                string Apellido = cmbProfesional.Text;
                string descripcion = cmbEspecialidad.Text;
                Int32 DiaNumero = funciones.numeroDiaSemana(dia);

                //verifica la seleccion del profesional
                if (Apellido == "" && descripcion == "")
                {
                    MessageBox.Show("Seleccione un medico y/o una especialidad", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
                else
                {
                    dgvHorariosDisp.DataSource = Conexion.obtenerTablaProcedure("RANDOM.FILTRAR_MEDICO", Conexion.generarArgumentos("@Descripcion", "@Apellido", "@DiaNumero", "@Fecha"), descripcion, Apellido, DiaNumero, fechaHora);
                    dgvHorariosDisp.Columns[2].Visible = false;
                    dgvHorariosDisp.Columns[4].Visible = false;
                    dgvHorariosDisp.Columns[5].Visible = false;
                    dgvHorariosDisp.Columns[6].Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fecha valida, posterior a la fecha de hoy", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }

        public String dayOfWeek(DateTime? date)
        {
            return date.Value.ToString("dddd");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvHorariosDisp.DataSource = null;
            cmbProfesional.Text = null;
            cmbEspecialidad.Text = null;
            DateTime fechaHoy = funciones.ObtenerFecha();
            dtpTurnoPosible.Value = fechaHoy;
        }

        private void dgvHorariosDisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionarProfesional_Click(object sender, EventArgs e)
        {

            bool afiliadoEnNumeros = funciones.permiteNumeros(textAfiliado.Text);
            
            //valida el afiliado
            if (afiliadoEnNumeros == true && textAfiliado.Text != "" && textAfiliado.Text.Length <= 10)
                {
                    string query = "SELECT RANDOM.VALIDAR_AFILIADO ('" + textAfiliado.Text + "') AS id";
                    SqlDataReader reader = Conexion.ejecutarQuery(query);
                    reader.Read();
                    Int32 afiliadoValidacion = int.Parse(reader["id"].ToString());
                    reader.Close();



                    if (afiliadoValidacion != -1)
                    {

                        Int32 selectedRowCount = dgvHorariosDisp.Rows.GetRowCount(DataGridViewElementStates.Selected);
                        if (selectedRowCount == 1)
                        {

                            string fechaHoraTurnoSssss = dtpTurnoPosible.Text;
                            DateTime fechaHora = Convert.ToDateTime(fechaHoraTurnoSssss);
                            String dia = dayOfWeek(fechaHora);
                            Int32 DiaNumero = funciones.numeroDiaSemana(dia);
                            DataGridViewRow d = dgvHorariosDisp.SelectedRows[0];
                            string desdeS = d.Cells[5].Value.ToString();
                            Int32 desde = Convert.ToInt32(desdeS);
                            string hastaS = d.Cells[6].Value.ToString();
                            Int32 hasta = Convert.ToInt32(hastaS);
                            string fechaHoraTurnoS = dtpTurnoPosible.Text;
                            DateTime fecha = Convert.ToDateTime(fechaHoraTurnoS);
                            DateTime HoraDesde = new DateTime(fecha.Year, fecha.Month, fecha.Day, desde, 0, 0);
                            DateTime HoraHasta = new DateTime(fecha.Year, fecha.Month, fecha.Day, hasta, 0, 0);
                            string IdProfesionalS = d.Cells[2].Value.ToString();
                            Int32 IdProfesional = Convert.ToInt32(IdProfesionalS);
                            string IdEspecialidadS = d.Cells[4].Value.ToString();
                            Int32 IdEspecialidad = Convert.ToInt32(IdEspecialidadS);
                            FormProvider.Turno.dataGridView1.DataSource = Conexion.obtenerTablaProcedure("RANDOM.PEDIDO_DE_TURNO_HORARIOS_DISPONIBLES", Conexion.generarArgumentos("@Desde", "@Hasta", "@IdProfesional", "@Dia", "@IdEspecialidad"), HoraDesde, HoraHasta, IdProfesional, DiaNumero, IdEspecialidad);
                            string Apellido = d.Cells[0].Value.ToString();
                            FormProvider.Turno.textProfesional.Text = Apellido;
                            string Especialidad = d.Cells[3].Value.ToString();
                            FormProvider.Turno.textEspecialidad.Text = Especialidad;
                            string Afiliado = textAfiliado.Text;
                            FormProvider.Turno.textAfiliado.Text = Afiliado;
                            string FechaMando = dtpTurnoPosible.Text;
                            FormProvider.Turno.textFecha.Text = FechaMando;
                            //limpieza - eventos
                            FormProvider.Turno.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Elegir un profesional", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un afiliado valido", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                    }
                }

                else
                {
                MessageBox.Show("El afiliado deben ser numeros y una longitud valida", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {

            //limpieza - eventos
            this.Hide();
            FormProvider.MainMenu.Show();
            dgvHorariosDisp.DataSource = null;
            cmbProfesional.Text = null;
            cmbEspecialidad.Text = null;
            DateTime fechaHoy = funciones.ObtenerFecha();
            dtpTurnoPosible.Value = fechaHoy;
            textAfiliado.Text = null;
        }
    }
}