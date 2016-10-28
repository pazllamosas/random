using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            switch (rol)
            {
                case "Administrador":
                    btnCancelarturno.Visible = true;
                    btnPlan.Visible = true;
                    btnCompraBonos.Visible = true;
                    btnRegLlegada.Visible = true;
                    btnRegAgenda.Visible = true;
                    btnVerEspec.Visible = true;
                    btnVerProfesional.Visible = true;
                    btnVerAfiliado.Visible = true;
                    btnVerRol.Visible = true;
                    break;
                case "Afiliado":
                    btnTop5.Visible = true;
                    btnTurno.Visible = true;
                    break;
                case "Profesional":
                    btnTop5.Visible = true;
                    btnRegResultado.Visible = true;
                    break;
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
            FormProvider.Turno.Show();
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
    }
}
