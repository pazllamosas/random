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

            if (montoTotal != -1)
            {
                string fecha = System.Configuration.ConfigurationManager.AppSettings["fecha"];
                DateTime fechaHoy = Convert.ToDateTime(fecha);
                bool resultado = Conexion.executeProcedure("RANDOM.COMPRA_DE_BONO", Conexion.generarArgumentos("@IdAfiliado", "@Cantidad", "@MontoTotal", "@Fecha"), afiliado, cantidadBonos, montoTotal, fechaHoy);
                if (resultado)
                {
                    MessageBox.Show("Bono comprado con exito");
                }
                else
                {
                    MessageBox.Show("El bono no fue comprado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No existe el afiliado o esta dado de baja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtNroAfiliado.Text = null;
            txtCantBonos.Text = null;
            txtMonto.Text = null;
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNroAfiliado.Text = null;
            txtCantBonos.Text = null;
            txtMonto.Text = null;
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
            if (montoTotal != -1)
            {
                txtMonto.Text = Convert.ToString(montoTotal);
            }
            else
            {
                MessageBox.Show("No existe el afiliado o esta dado de baja", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private Int32 calculoMontoTotal(Int32 afiliado, Int32 cantidadBonos)
        {
            String query = "SELECT RANDOM.VALIDAR_AFILIADO ('" + afiliado + "') AS id";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            Int32 afiliadoValidacion = int.Parse(reader["id"].ToString());
            reader.Close();
            if (afiliadoValidacion != -1)
            {
                string query2 = "SELECT RANDOM.CALCULO_MONTO ('" + afiliado + "', '" + cantidadBonos + "' ) AS id2";
                SqlDataReader reader2 = Conexion.ejecutarQuery(query2);
                reader2.Read();
                Int32 montoTotal = int.Parse(reader2["id2"].ToString());
                reader2.Close();
                return montoTotal;
            }
            else { return -1; }
        }

    }
}