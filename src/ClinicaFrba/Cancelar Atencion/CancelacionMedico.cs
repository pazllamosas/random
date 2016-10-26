using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelacionMedico : Form
    {
        public CancelacionMedico()
        {
            InitializeComponent();
            cmbTipoCancelacion.ValueMember = "IdTipoCancelacion";
            cmbTipoCancelacion.DisplayMember = "Descripcion";
            cmbTipoCancelacion.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_TIPOS_CANCELACION");
            this.cmbTipoCancelacion.SelectedIndex = -1;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Cancelacion.Show();
        }

        private void btnGuardarCanc_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Cancelacion.Show();
        }
    }
}
