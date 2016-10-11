using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class AgregarAfiliado : Form
    {
        public AgregarAfiliado()
        {
            InitializeComponent();
        }

        private void AgregarAfiliado_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Afiliado.Show(); 
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFamACargo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
