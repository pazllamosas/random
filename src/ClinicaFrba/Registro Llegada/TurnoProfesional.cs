﻿using System;
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
            seleccionarBono.Visible = false;
            BonosDisponibles.DataSource = null;
        }

        private void TurnoProfesional_Load(object sender, EventArgs e)
        {
            seleccionarBono.Visible = false;
        }

        public void btnSeleccTurno_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = dgvTurnoProfesional.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                DataGridViewRow d = dgvTurnoProfesional.SelectedRows[0];
                string fechaHoraTurnoS = d.Cells[0].Value.ToString();
                DateTime fechaHoraTurno = Convert.ToDateTime(fechaHoraTurnoS);

                DateTime fechaHoy = funciones.ObtenerFecha();

                if ((fechaHoraTurno.Hour > fechaHoy.Hour) || ((fechaHoraTurno.Hour == fechaHoy.Hour) && (fechaHoraTurno.Minute >= fechaHoy.Minute)))
                {
                    string afiliadoS = d.Cells[1].Value.ToString();
                    Int32 afiliado = Convert.ToInt32(afiliadoS);

                    BonosDisponibles.DataSource = Conexion.obtenerTablaProcedure("RANDOM.BONOS_DISPONIBLES", Conexion.generarArgumentos("@IdAfiliado"), afiliado);
                    seleccionarBono.Visible = true;
                }
                else
                {
                    MessageBox.Show("Esta pasada la hora del turno", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Elegir un turno", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }


        public void dgvTurnoProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblBonos_Click(object sender, EventArgs e)
        {

        }

        private void txtBonos_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTurnoProfesional_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BonosDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void seleccionarBono_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = BonosDisponibles.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                DataGridViewRow d = BonosDisponibles.SelectedRows[0];
                string IdBonoS = d.Cells[1].Value.ToString();
                Int32 IdBono = Convert.ToInt32(IdBonoS);
                DataGridViewRow d2 = dgvTurnoProfesional.SelectedRows[0];
                string fechaS = d2.Cells[0].Value.ToString();
                DateTime fecha = Convert.ToDateTime(fechaS);
                string afiliadoS = d2.Cells[1].Value.ToString();
                Int32 afiliado = Convert.ToInt32(afiliadoS);
                bool resultado = Conexion.executeProcedure("RANDOM.REGISTRO_LLEGADA", Conexion.generarArgumentos("@IdAfiliado", "IdBono", "@FechaHoy"), afiliado, IdBono, fecha);
                if (resultado)
                {
                    MessageBox.Show("Se registro la llegada con exito");
                }
                else
                {
                    MessageBox.Show("No se registro la llegada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                this.Hide();
                FormProvider.MainMenu.Show();
                FormProvider.RegistroLlegada.dgvLlegada.DataSource = null;
                FormProvider.RegistroLlegada.cmbProfesional.Text = null;
                FormProvider.RegistroLlegada.Text = null;
                BonosDisponibles.DataSource = null;
                seleccionarBono.Visible = false;
            }
            else
            {
                MessageBox.Show("Elegir un bono", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
            FormProvider.RegistroLlegada.dgvLlegada.DataSource = null;
            FormProvider.RegistroLlegada.cmbProfesional.Text = null;
            FormProvider.RegistroLlegada.Text = null;
            BonosDisponibles.DataSource = null;
        }
    }
}