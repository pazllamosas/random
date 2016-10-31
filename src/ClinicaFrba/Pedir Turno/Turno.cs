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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Turno_Load(object sender, EventArgs e)
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

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpTurnoPosible_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvHorariosDisp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbEspecialidad_SelectedIndexChanged_1(object sender, EventArgs e)
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

            }else{
            MessageBox.Show("Seleccione una fecha valida, posterior a la fecha de hoy");}
        }
    
        private String dayOfWeek(DateTime? date){  
        return  date.Value.ToString("dddd");
        }
        private Int32 numeroDiaSemana(string dia)
        {
            if(dia == "domingo"){ return 1; }
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
            dataGridView1.DataSource = null;

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionarProfesional_Click(object sender, EventArgs e)
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
            dataGridView1.DataSource = Conexion.obtenerTablaProcedure("RANDOM.PEDIDO_DE_TURNO_HORARIOS_DISPONIBLES", Conexion.generarArgumentos("@Desde", "@Hasta", "@IdProfesional"), HoraDesde, HoraHasta, IdProfesional);
        }

        private void btnSeleccionarTurno_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = dgvHorariosDisp.SelectedRows[0];
            string turnoS = d.Cells[0].Value.ToString();
            string fechaHoraTurnoS = dtpTurnoPosible.Text;
            DateTime fechaHoraTurnoElegida = Convert.ToDateTime(fechaHoraTurnoS);
            Int32 afiliado = 101; //hardcodeado!!!
            bool resultado = Conexion.executeProcedure("RANDOM.RESERVO_FECHA_TURNO", Conexion.generarArgumentos("@FechaElegida", "@Afiliado"), fechaHoraTurnoElegida, afiliado);
            if (resultado)
            {
               MessageBox.Show("Turno asignado con exito");
           }
           else
           {
              MessageBox.Show("El turno no fue asignado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           }
        }

    }

}