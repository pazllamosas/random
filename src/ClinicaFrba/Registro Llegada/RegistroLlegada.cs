﻿using System;
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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Apellido = cmbProfesional.Text;
            string descripcion = cmbEspecialidad.Text;
            dgvLlegada.DataSource = Conexion.obtenerTablaProcedure("RANDOM.BUSCAR_MEDICO", Conexion.generarArgumentos("@Descripcion", "@Apellido"), descripcion, Apellido);
            dgvLlegada.Columns[2].Visible = false;
            dgvLlegada.Columns[4].Visible = false;
        }

        private void cmbProfesional_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegLlegada_Click(object sender, EventArgs e)
        {
            DataGridViewRow d = dgvLlegada.SelectedRows[0];
            string IdMedicoS = d.Cells[2].Value.ToString();
            Int32 IdMedico = Convert.ToInt32(IdMedicoS);
            string IdEspecialidadS = d.Cells[4].Value.ToString();
            Int32 IdEspecialidad = Convert.ToInt32(IdEspecialidadS);
            string fecha = System.Configuration.ConfigurationManager.AppSettings["fecha"];
            DateTime fechaHoy = Convert.ToDateTime(fecha);
            FormProvider.TurnoProf.dgvTurnoProfesional.DataSource = Conexion.obtenerTablaProcedure("RANDOM.TRAER_TURNOS_MEDICO", Conexion.generarArgumentos("@IdMedico", "@IdEspecialidad", "@FechaHoy"), IdMedico, IdEspecialidad, fechaHoy);
            FormProvider.TurnoProf.Show();
            this.Hide();
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
