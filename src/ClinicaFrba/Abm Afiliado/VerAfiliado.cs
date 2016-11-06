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

namespace ClinicaFrba.Abm_Afiliado
{
    public partial class VerAfiliado : Form
    {
        public VerAfiliado()
        {
            InitializeComponent();
        }

        private void btnCrearAf_Click(object sender, EventArgs e)
        {
            
            FormProvider.Agafiliado.cargaCombos();
            FormProvider.Agafiliado.agregarNuevoAfiliado();
            FormProvider.Agafiliado.Show();
            
        }

        private void btnEditarAf_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvAfiliados.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRowCount == 1)
            {
                DataGridViewRow d = dgvAfiliados.SelectedRows[0];
                string idAfiliado = d.Cells[0].Value.ToString();
                string apellido = d.Cells[1].Value.ToString();
                string nombre = d.Cells[2].Value.ToString();
                string nroDocumento = d.Cells[3].Value.ToString();
                string telefono = d.Cells[4].Value.ToString();
                string direccion = d.Cells[5].Value.ToString();
                string fechaNacimiento = d.Cells[6].Value.ToString();
                string sexo = d.Cells[7].Value.ToString();
                string tipoDocumento = d.Cells[8].Value.ToString();
                string plan = d.Cells[9].Value.ToString();
                string estadoCivil = d.Cells[10].Value.ToString();
                string cantACargo = d.Cells[11].Value.ToString();
                string mail = d.Cells[12].Value.ToString();
                string nroAfiliadoRaiz = d.Cells[13].Value.ToString();
                string nroAfiliadoExt = d.Cells[14].Value.ToString();
                
                FormProvider.Agafiliado.EditarAfiliado(idAfiliado, apellido, nombre, nroDocumento, telefono, direccion, fechaNacimiento, sexo, tipoDocumento, plan, estadoCivil, cantACargo, mail, nroAfiliadoRaiz, nroAfiliadoExt);
                FormProvider.Agafiliado.Show();
                this.txtBusqDni.Clear();
                this.Hide();
            } else
                {
                MessageBox.Show("No podés editar si no elegís un afiliado y sólo un afiliado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
 }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void VerAfiliado_Load(object sender, EventArgs e)
        {
            dgvAfiliados.Rows.Clear();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtBusqDni.Text;

            if (!(dni == ""))
            {
                if (afiliadoValido(dni))
                {
                    dgvAfiliados.DataSource = Conexion.obtenerTablaProcedure("RANDOM.GET_AFILIADOS", Conexion.generarArgumentos("@DNI"), dni);
                    dgvAfiliados.Columns[0].Visible = false;
                    dgvAfiliados.Columns[7].Visible = false;
                    dgvAfiliados.Columns[8].Visible = false;
                    dgvAfiliados.Columns[9].Visible = false;
                    dgvAfiliados.Columns[10].Visible = false;
                    dgvAfiliados.Columns[11].Visible = false;
                    dgvAfiliados.Columns[12].Visible = false;
                    dgvAfiliados.Columns[13].Visible = false;
                    dgvAfiliados.Columns[14].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un Número de Documento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtBusqDni_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtBusqDni.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBusqDni.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBusqDni.Clear();
            dgvAfiliados.Columns.Clear();
            
        }

        public Boolean afiliadoValido(string dni)
        {
            string query = "SELECT RANDOM.EXISTE_AFILIADO ('" + dni + "' ) AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta >= 1)
            {

                return true;
            }
            else
            {
                MessageBox.Show("El afiliado no existe en la base", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private void btnBajaAf_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvAfiliados.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                DataGridViewRow d = dgvAfiliados.SelectedRows[0];
                string idAfiliado = d.Cells[0].Value.ToString();

                Conexion.executeProcedure("RANDOM.BAJA_AFILIADO",
                    Conexion.generarArgumentos("IDPERSONA"),
                    idAfiliado);
                Conexion.executeProcedure("RANDOM.BAJA_AFILIADO_ASIGNACION",
                    Conexion.generarArgumentos("IDPERSONA"),
                    idAfiliado);

                MessageBox.Show("Afiliado dado de baja", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No podés dar de baja si no elegís un afiliado y sólo un afiliado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvAfiliados.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                DataGridViewRow d = dgvAfiliados.SelectedRows[0];
                string nroAfiliadoRaiz = d.Cells[13].Value.ToString();
                FormProvider.ConsultaHistorial.cargaDatos(nroAfiliadoRaiz);
                FormProvider.ConsultaHistorial.Show();
            }
            else
            {
                MessageBox.Show("No podés consultar si no elegís un afiliado y sólo un afiliado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
