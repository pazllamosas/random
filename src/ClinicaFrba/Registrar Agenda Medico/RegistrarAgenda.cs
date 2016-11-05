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
            dgvProfesional.DataSource = null;
            txtDNI.Text = null;
            cmbDias.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarAgenda_Load(object sender, EventArgs e)
        {
            cmbDias.Items.Add("Lunes");
            cmbDias.Items.Add("Martes");
            cmbDias.Items.Add("Miercoles");
            cmbDias.Items.Add("Jueves");
            cmbDias.Items.Add("Viernes");
            cmbDias.Items.Add("Sabado");
            this.cmbDias.SelectedIndex = -1;
            this.comboBox1.SelectedIndex = -1;
            this.comboBox2.SelectedIndex = -1;
            
        }


        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dia = cmbDias.Text;
            Int32 x = funciones.numeroDiaSemana(dia);
            diasDiponibles(x);
        }

        public void diasDiponibles(Int32 x)
        {
            if (x == 6)
            {
                comboBox1.Items.Add("10:00");
                comboBox1.Items.Add("11:00");
                comboBox1.Items.Add("12:00");
                comboBox1.Items.Add("13:00");
                comboBox1.Items.Add("14:00");
                comboBox1.Items.Add("15:00");

                comboBox2.Items.Add("11:00");
                comboBox2.Items.Add("12:00");
                comboBox2.Items.Add("13:00");
                comboBox2.Items.Add("14:00");
                comboBox2.Items.Add("15:00");
            }
            else
            {
                comboBox1.Items.Add("07:00");
                comboBox1.Items.Add("08:00");
                comboBox1.Items.Add("09:00");
                comboBox1.Items.Add("10:00");
                comboBox1.Items.Add("11:00");
                comboBox1.Items.Add("12:00");
                comboBox1.Items.Add("13:00");
                comboBox1.Items.Add("14:00");
                comboBox1.Items.Add("15:00");
                comboBox1.Items.Add("16:00");
                comboBox1.Items.Add("17:00");
                comboBox1.Items.Add("18:00");
                comboBox1.Items.Add("19:00");


                comboBox2.Items.Add("07:00");
                comboBox2.Items.Add("08:00");
                comboBox2.Items.Add("09:00");
                comboBox2.Items.Add("10:00");
                comboBox2.Items.Add("11:00");
                comboBox2.Items.Add("12:00");
                comboBox2.Items.Add("13:00");
                comboBox2.Items.Add("14:00");
                comboBox2.Items.Add("15:00");
                comboBox2.Items.Add("16:00");
                comboBox2.Items.Add("17:00");
                comboBox2.Items.Add("18:00");
                comboBox2.Items.Add("19:00");
                comboBox2.Items.Add("20:00");

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

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarAgenda_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = dgvProfesional.SelectedRows[0];
            string IdProfesionalS = d.Cells[2].Value.ToString();
            Int32 IdProfesional = Convert.ToInt32(IdProfesionalS);
            string IdEspecialidadS = d.Cells[4].Value.ToString();
            Int32 IdEspecialidad = Convert.ToInt32(IdEspecialidadS);
            string diaS = cmbDias.Text;
            Int32 Dia = funciones.numeroDiaSemana(diaS);
            string FechaDesde = comboBox1.Text;
            Int32 FechaDesdeInt = Convert.ToInt32(FechaDesde);
            string FechaHasta = comboBox2.Text;
            Int32 FechaHastaInt = Convert.ToInt32(FechaHasta);
           // if()
       //     bool resultado = Conexion.executeProcedure("RANDOM.CARGA_AGENDA", Conexion.generarArgumentos("@IdProfesional", "@IdEspecialidad", "@HoraDesde", "@HoraHasta", "@Dia"), IdProfesional, IdEspecialidad, HoraDesde, HoraHasta, Dia);
      //      if (resultado)
        //    {
          //      MessageBox.Show("Agenda asignada correctamente");
            //}
            //else
            //{
              //  MessageBox.Show("La agenda no se asigno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           // }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniS = txtDNI.Text;
            Int32 dni = Convert.ToInt32(dniS);
            dgvProfesional.DataSource = Conexion.obtenerTablaProcedure("RANDOM.TRAER_PROFESIONAL_CON_DNI", Conexion.generarArgumentos("@DNI"), dni);
            
        }

        private void dgvProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvProfesional.DataSource = null;
            txtDNI.Text = null;
            cmbDias.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
        }
    }
}



/*CREATE PROCEDURE RANDOM.TRAER_PROFESIONAL_CON_DNI(@DNI INT) AS
BEGIN
	SELECT A.Apellido, A.Nombre, A.IdPersona, B.Descripcion, B.IdEspecialidad
	FROM RANDOM.PERSONA A, RANDOM.ESPECIALIDAD B, RANDOM.ESPECIALIDAD_POR_PROFESIONAL C
	WHERE A.Documento = @DNI AND A.IdPersona = C.IdProfesional AND C.IdEspecialidad = B.IdEspecialidad
	ORDER BY B.Descripcion
END
SELECT * FROM RANDOM.PERSONA*/
