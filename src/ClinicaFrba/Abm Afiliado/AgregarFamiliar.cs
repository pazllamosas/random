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
    public partial class AgregarFamiliar : Form
    {
        string estadoCivilAfiliado;
        string cantACargoAfiliado;

        public AgregarFamiliar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Agafiliado.Show();
        }

        public void recepcionDatos(string nroAfiliadoRaiz, string estadoCivil, string cantACargo)
        {
            txtNroAf.Text = nroAfiliadoRaiz;
            string estadoCivilAfiliado = estadoCivil;
            string cantACargoAfiliado = cantACargo;

            if (estadoCivilAfiliado == "Casado" || estadoCivilAfiliado == "Concubinato")
                cmbFamiliar.Items.Add("Pareja");
            if (Convert.ToInt32(cantACargoAfiliado) > 0)
                cmbFamiliar.Items.Add("Familiar a cargo");

        }

        private void AgregarFamiliar_Load(object sender, EventArgs e)
        {
            txtNroAf.Visible = false;
            
            //if (estadoCivilAfiliado == "Casado" || estadoCivilAfiliado == "Concubinato")
            //    cmbFamiliar.Items.Add("Pareja");
            //if (Convert.ToInt32(cantACargoAfiliado) > 0)
            //    cmbFamiliar.Items.Add("Familiar a cargo");
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtTelefono.Clear();
        }

        
       
    }
}
