﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Planes
{
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            dgvPlanes.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_PLANES");
            dgvPlanes.Columns[0].Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }
    }
}
