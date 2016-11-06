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

namespace ClinicaFrba.Inicio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void habilitarFuncionalidadesPorRol(string rol)
        {
            btnTop5.Visible = false;
            btnTurno.Visible = false;
            btnCancelarturno.Visible = false;
            btnPlan.Visible = false;
            btnCompraBonos.Visible = false;
            btnRegLlegada.Visible = false;
            btnRegAgenda.Visible = false;
            btnVerEspec.Visible = false;
            btnVerProfesional.Visible = false;
            btnVerAfiliado.Visible = false;
            btnVerRol.Visible = false;
            btnRegResultado.Visible = false;

            string query = "SELECT RF.IdFuncionalidad FROM RANDOM.ROL R JOIN RANDOM.ROL_POR_FUNCIONALIDADES RF ON RF.IdRol = R.IdRol WHERE R.Descripcion = '" + rol + "' and R.Estado = 1 and rf.Habilitada = 1";
            SqlDataReader reader = Conexion.ejecutarQuery(query);


            List<int> listaRoles = new List<int>();
            while (reader.Read())
            {
                int I = 0;
                listaRoles.Add(Convert.ToInt32(reader[I]));
                I = I + 1;
            }
            reader.Close();

            for (int i = 0; i < listaRoles.Count; i++)
            {
                habilitarFuncionalidad(listaRoles[i]);
            }
        }

        public void habilitarFuncionalidad(int funcionalidad)
        {
            if (funcionalidad == 0)
            {
                btnVerAfiliado.Visible = true;
            }
            if (funcionalidad == 1)
            {
                btnVerAfiliado.Visible = true;
            }
            if (funcionalidad == 2)
            {
                btnVerAfiliado.Visible = true;
            }
            if (funcionalidad == 3)
            {
                btnVerProfesional.Visible = true;
            }
            if (funcionalidad == 4)
            {
                btnVerProfesional.Visible = true;
            }
            if (funcionalidad == 5)
            {
                btnVerProfesional.Visible = true;
            }
            if (funcionalidad == 6)
            {
                btnRegAgenda.Visible = true;
            }
            if (funcionalidad == 7)
            {
                btnCompraBonos.Visible = true;
            }
            if (funcionalidad == 8)
            {
                btnRegLlegada.Visible = true;
            }
            if (funcionalidad == 9)
            {
                btnTurno.Visible = true;
            }
            if (funcionalidad == 10)
            {
                btnCancelarturno.Visible = true;
            }
            if (funcionalidad == 11)
            {
                btnRegLlegada.Visible = true;
            }
            if (funcionalidad == 12)
            {
                btnTop5.Visible = true;
            }
            if (funcionalidad == 13)
            {
                btnVerRol.Visible = true;
            }
            if (funcionalidad == 14)
            {
                btnVerEspec.Visible = true;
            }
            if (funcionalidad == 15)
            {
                btnPlan.Visible = true;
            }

        }




        private void btnCompraBonos_Click(object sender, EventArgs e)
        {
            FormProvider.CompraBono.Show();
        }

        private void btnVerRol_Click(object sender, EventArgs e)
        {
            FormProvider.Rol.Show();
            FormProvider.Rol.CargarRoles();
        }

        private void btnRegAgenda_Click(object sender, EventArgs e)
        {
            FormProvider.Agenda.Show();
        }

        private void btnRegLlegada_Click(object sender, EventArgs e)
        {
            FormProvider.RegistroLlegada.Show();
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            FormProvider.ProfesionalTurno.Show();
        }

        private void btnRegResultado_Click(object sender, EventArgs e)
        {
            FormProvider.Diagnostico.Show();
        }

        private void btnCancelarturno_Click(object sender, EventArgs e)
        {
            FormProvider.Cancelacion.Show();
        }

        private void btnTop5_Click(object sender, EventArgs e)
        {
            FormProvider.ListadoEstadistico.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Login.Show();
        }

        private void btnVerAfiliado_Click(object sender, EventArgs e)
        {
            FormProvider.Afiliado.Show();
        }

        private void btnVerProfesional_Click(object sender, EventArgs e)
        {
            FormProvider.Profesional.Show();
        }

        private void btnVerEspec_Click(object sender, EventArgs e)
        {
            FormProvider.Especialidades.Show();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            FormProvider.Planes.Show();
        }
    }
}
