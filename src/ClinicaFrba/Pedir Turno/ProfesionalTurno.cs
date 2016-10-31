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
        }

        private void dtpTurnoPosible_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string fecha = System.Configuration.ConfigurationManager.AppSettings["fecha"];
            DateTime fechaHoy = Convert.ToDateTime(fecha);
            string fechaHoraTurnoS = dtpTurnoPosible.Text;
            DateTime fechaHora = Convert.ToDateTime(fechaHoraTurnoS);
            int comparacion = DateTime.Compare(fechaHoy, fechaHora);
            if (comparacion <= 0)
            {
                String dia = dayOfWeek(fechaHora);
                string Apellido = cmbProfesional.Text;
                string descripcion = cmbEspecialidad.Text;
                Int32 DiaNumero = numeroDiaSemana(dia);
                dgvHorariosDisp.DataSource = Conexion.obtenerTablaProcedure("RANDOM.PEDIDO_DE_TURNO", Conexion.generarArgumentos("@Descripcion", "@Apellido", "@Fecha", "@DiaNumero"), descripcion, Apellido, fechaHora, DiaNumero);
                dgvHorariosDisp.Columns[2].Visible = false;
                dgvHorariosDisp.Columns[4].Visible = false;
                dgvHorariosDisp.Columns[5].Visible = false;
                dgvHorariosDisp.Columns[6].Visible = false;
                dgvHorariosDisp.Columns[7].Visible = false;

            }
            else
            {
                MessageBox.Show("Seleccione una fecha valida, posterior a la fecha de hoy");
            }
        }

        private String dayOfWeek(DateTime? date)
        {
            return date.Value.ToString("dddd");
        }
        private Int32 numeroDiaSemana(string dia)
        {
            if (dia == "domingo") { return 1; }
            if (dia == "lunes") { return 2; }
            if (dia == "martes") { return 3; }
            if (dia == "miércoles") { return 4; }
            if (dia == "jueves") { return 5; }
            if (dia == "viernes") { return 6; }
            else { return 7; }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvHorariosDisp.DataSource = null;
            cmbProfesional.Text = null;
            cmbEspecialidad.Text = null;
        }

        private void dgvHorariosDisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionarProfesional_Click(object sender, EventArgs e)
        {
            string query = "SELECT RANDOM.VALIDAR_AFILIADO ('" + textAfiliado.Text + "') AS id";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            Int32 afiliadoValidacion = int.Parse(reader["id"].ToString());
            reader.Close();

            if (textAfiliado.Text != "" && afiliadoValidacion != -1)
            {
            DataGridViewRow d = dgvHorariosDisp.SelectedRows[0];
            string desdeS = d.Cells[6].Value.ToString();
            Int32 desde = Convert.ToInt32(desdeS);
            string hastaS = d.Cells[7].Value.ToString();
            Int32 hasta = Convert.ToInt32(hastaS);
            string fechaHoraTurnoS = dtpTurnoPosible.Text;
            DateTime fecha = Convert.ToDateTime(fechaHoraTurnoS);
            DateTime HoraDesde = new DateTime(fecha.Year, fecha.Month, fecha.Day, desde, 0, 0);
            DateTime HoraHasta = new DateTime(fecha.Year, fecha.Month, fecha.Day, hasta, 0, 0);
            string IdProfesionalS = d.Cells[2].Value.ToString();
            Int32 IdProfesional = Convert.ToInt32(IdProfesionalS);
            FormProvider.Turno.dataGridView1.DataSource = Conexion.obtenerTablaProcedure("RANDOM.PEDIDO_DE_TURNO_HORARIOS_DISPONIBLES", Conexion.generarArgumentos("@Desde", "@Hasta", "@IdProfesional"), HoraDesde, HoraHasta, IdProfesional);
            string Apellido = d.Cells[0].Value.ToString();
            FormProvider.Turno.textProfesional.Text = Apellido;
            string Especialidad = d.Cells[3].Value.ToString();
            FormProvider.Turno.textEspecialidad.Text = Especialidad;
            string Afiliado = textAfiliado.Text;
            FormProvider.Turno.textAfiliado.Text = Afiliado;
            string FechaMando = dtpTurnoPosible.Text;
            FormProvider.Turno.textFecha.Text = FechaMando;
            FormProvider.Turno.Show();
            this.Hide();  
            }else{
            MessageBox.Show("Ingrese un afiliado valido");}

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }
        }
   }

