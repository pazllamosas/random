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
            //      dgvTurnoProfesional.DataSource = null;
        }

        public void btnSeleccTurno_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = dgvTurnoProfesional.SelectedRows[0];
            
            string afiliadoS = d.Cells[1].Value.ToString();
            Int32 afiliado = Convert.ToInt32(afiliadoS);
            
            string fechaHoraTurnoS = d.Cells[0].Value.ToString();
            DateTime fechaHoraTurno = Convert.ToDateTime(fechaHoraTurnoS);

            string fecha = System.Configuration.ConfigurationManager.AppSettings["fecha"];
            DateTime fechaHoy = Convert.ToDateTime(fecha);

   /*         string query = "SELECT RANDOM.BONOS_DISPONIBLES ('" + afiliado + "') AS id";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            Int32 CantidadDisponibleBonos = int.Parse(reader["id"].ToString());
            txtBonos.Text = Convert.ToString(CantidadDisponibleBonos);
            reader.Close();*/

  //          if (CantidadDisponibleBonos > 0)
          
  //       {
            if ((fechaHoraTurno.Hour < fechaHoy.Hour) || ((fechaHoraTurno.Hour == fechaHoy.Hour) && (fechaHoraTurno.Minute >= fechaHoy.Minute)))
                {
                bool resultado = Conexion.executeProcedure("RANDOM.REGISTRO_LLEGADA", Conexion.generarArgumentos("@IdAfiliado"), afiliado);
                if (resultado)
                {
                    MessageBox.Show("Se registro la llegada con exito");
                }
                else
                {
                    MessageBox.Show("No se registro la llegada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }}else{
                    MessageBox.Show("El turno esta pasado de hora/fecha");}
            }
     //       else
     //       {
      //          MessageBox.Show("El afiliado no tiene bonos disponibles");
      //      }
            
      //  }

        public void dgvTurnoProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBonos_Click(object sender, EventArgs e)
        {

        }

        private void txtBonos_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.RegistroLlegada.Show();
            //dgvTurnoProfesional.DataSource = null;
        }

        private void dgvTurnoProfesional_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}