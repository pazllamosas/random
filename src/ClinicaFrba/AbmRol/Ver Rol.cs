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

namespace ClinicaFrba.AbmRol
{
    public partial class verRol : Form
    {
        public verRol()
        {
            InitializeComponent();
        }


        public void CargarRoles()
        {
            dgvRol.Rows.Clear();
            string query = "SELECT IdRol, Descripcion FROM RANDOM.ROL order by IdRol";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvRol.Rows.Add(reader["IdRol"], reader["Descripcion"]);
            }
            reader.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormProvider.AgRol.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProvider.AgRol.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }
    }
}
