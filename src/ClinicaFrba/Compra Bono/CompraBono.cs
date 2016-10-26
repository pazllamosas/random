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

namespace ClinicaFrba.Compra_Bono
{
    public partial class CompraBono : Form
    {
        public CompraBono()
        {
            InitializeComponent();
        }

        private void lblNroAfiliado_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 afiliado = Convert.ToInt32(txtNroAfiliado.Text);
            Int32 cantidadBonos = Convert.ToInt32(txtCantBonos.Text);
            Int32 montoTotal = calculoMontoTotal(afiliado, cantidadBonos);

            bool resultado = Conexion.executeProcedure("RANDOM.COMPRA_DE_BONO", Conexion.generarArgumentos("@IdAfiliado", "@Cantidad", "@MontoTotal"), afiliado, cantidadBonos, montoTotal);
            if (resultado)
            {
                MessageBox.Show("Bono comprado con exito");
            }
            else
            {
                MessageBox.Show("El bono no fue comprado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.txtNroAfiliado.Clear();
            this.txtCantBonos.Clear();
            this.txtMonto.Clear();
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.txtNroAfiliado.Clear();
            this.txtCantBonos.Clear();
            this.txtMonto.Clear();
            this.Hide();
            FormProvider.MainMenu.Show();

        }

        private void lblMonto_Click(object sender, EventArgs e)
        {

        }

        private void lblCantBonos_Click(object sender, EventArgs e)
        {

        }

        private void txtCantBonos_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNroAfiliado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculoMonto_Click(object sender, EventArgs e)
        {
            Int32 afiliado = Convert.ToInt32(txtNroAfiliado.Text);
            Int32 cantidadBonos = Convert.ToInt32(txtCantBonos.Text);
            Int32 montoTotal = calculoMontoTotal(afiliado, cantidadBonos);
            txtMonto.Text = Convert.ToString(montoTotal);
        }

        private Int32 calculoMontoTotal(Int32 afiliado, Int32 cantidadBonos)
        {
            string query = "SELECT RANDOM.CALCULO_MONTO ('" + afiliado + "', '" + cantidadBonos + "' ) AS id";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            Int32 montoTotal = int.Parse(reader["id"].ToString());
            reader.Close();
            return montoTotal;
        }

    }
}