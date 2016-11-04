using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelacionAfiliado : Form
    {
        public CancelacionAfiliado()
        {
            InitializeComponent();
            cmbTipoCancelacion.ValueMember = "IdTipoCancelacion";
            cmbTipoCancelacion.DisplayMember = "Descripcion";
            cmbTipoCancelacion.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_TIPOS_CANCELACION");
            this.cmbTipoCancelacion.SelectedIndex = -1;
        }

        private void CargarTurnos()
        {
            dgvTurnosCancelar.Rows.Clear();
            string query = "SELECT IdTurno, FechaYHoraTurno ";
            query = query + "FROM RANDOM.TURNO T ";
            query = query + "WHERE T.IdAfiliado = " + txtAfiliado.Text + " AND T.FechaYHoraTurno > '" + DateTime.Today.ToString() + "' AND T.Habilitado = 0 ";
            query = query + "ORDER BY 2";

            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvTurnosCancelar.Rows.Add(reader["IdTurno"], reader["FechaYHoraTurno"]);
            }
            reader.Close();
        }

        private void btnBuscarTurno_Click(object sender, EventArgs e)
        {
            if (txtAfiliado.Text.Length > 0 && IsNumber(txtAfiliado.Text))
            {
                CargarTurnos();
            }
            else
            {
                MessageBox.Show("Debe ingresar un número de afiliado válido");
            }
        }

        private void btnGuardarCanc_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvTurnosCancelar.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                if (cmbTipoCancelacion.SelectedIndex >= 0 && txtMotivoCancelacion.Text.Length > 0)
                {
                    bool resultado = true;
                    for (int i = 0; i < dgvTurnosCancelar.SelectedRows.Count; i++)
                    {
                        DataGridViewRow d = dgvTurnosCancelar.SelectedRows[i];
                        string turno = d.Cells[0].Value.ToString();
                        string tipo = cmbTipoCancelacion.SelectedValue.ToString();
                        string motivo = txtMotivoCancelacion.Text;
                        resultado = resultado && Conexion.executeProcedure("RANDOM.CANCELAR_TURNO_AFILIADO", Conexion.generarArgumentos("@TURNO", "@TIPO", "@MOTIVO"), turno, tipo, motivo);
                    }
                    if (resultado)
                    {
                        MessageBox.Show("Turno(s) cancelado(s) satisfactoriamente");
                    }
                    CargarTurnos();
                }
                else
                {
                    string mensaje = "";
                    if (cmbTipoCancelacion.SelectedIndex < 0)
                    {
                        mensaje += "Debe seleccionar un item del tipo de cancelación";
                    }
                    if (txtMotivoCancelacion.Text.Length == 0)
                    {
                        if (cmbTipoCancelacion.SelectedIndex < 0)
                        {
                            mensaje += " e ingresar un motivo";
                        }
                        else
                        {
                            mensaje += "Debe ingresar un motivo de cancelación";
                        }
                    }
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar uno o más turnos");
            }
        }

        private bool IsNumber(string inputvalue)
        {
            Regex isnumber = new Regex("[^0-9]");
            return !isnumber.IsMatch(inputvalue);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Cancelacion.Show();
        }
    }
}
