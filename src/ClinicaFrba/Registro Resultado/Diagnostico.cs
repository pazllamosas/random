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

namespace ClinicaFrba.Registro_Resultado
{
    public partial class Diagnostico : Form
    {
        public Diagnostico()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Today;
            CargarTurnosDelDia(DateTime.Today);
        }

        public void CargarTurnosDelDia(DateTime turnoFecha)
        {
            dgvTurnos.Rows.Clear();
            string query = "SELECT T.IdTurno, P.Nombre, P.Apellido, D.Descripcion, P.Dni, T.FechaYHoraTurno ";
            query = query + "FROM RANDOM.TURNO T, RANDOM.AFILIADO A, RANDOM.PERSONA P, RANDOM.TIPOS_DOCUMENTOS D ";
            query = query + "WHERE A.NumeroAfiliadoRaiz = T.IdAfiliado AND P.IdPersona = A.IdPersona AND ";
            query = query + "D.IdTipoDocumento = P.IdTipoDocumento AND DAY(T.FechaYHoraTurno) = " + turnoFecha.Day.ToString();
            query = query + " AND MONTH(T.FechaYHoraTurno) = " + turnoFecha.Month.ToString() + " AND YEAR(T.FechaYHoraTurno) = ";
            query = query + turnoFecha.Year.ToString() + " AND T.Habilitado = 0";
            
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvTurnos.Rows.Add(reader["IdTurno"], reader["Nombre"], reader["Apellido"], reader["Descripcion"], reader["Dni"], reader["FechaYHoraTurno"]);
            }
            reader.Close();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarTurnosDelDia(dtpFecha.Value.Date);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvTurnos.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                if (cckTurno.Checked)
                {
                    if (txtSintomas.Text.Length > 0 && txtEnfermedad.Text.Length > 0)
                    {
                        DataGridViewRow d = dgvTurnos.SelectedRows[0];
                        string turno = d.Cells[0].Value.ToString();
                        string sintomas = txtSintomas.Text;
                        string enfermedad = txtEnfermedad.Text;
                        bool resultado = Conexion.executeProcedure("RANDOM.TURNO_CONCRETADO", Conexion.generarArgumentos("@TURNO", "@SINTOMAS", "@ENFERMEDAD"), turno, sintomas, enfermedad);
                        if (resultado)
                        {
                            MessageBox.Show("El diagnóstico finalizó correctamente");
                        }
                        this.Hide();
                        FormProvider.MainMenu.Show();
                    }
                    else
                    {
                        string mensaje = "";
                        if (txtSintomas.Text.Length == 0)
                        {
                            mensaje += "Debe ingresar un texto en el campo de Síntomas";
                        }
                        if (txtEnfermedad.Text.Length == 0)
                        {
                            if (txtSintomas.Text.Length == 0)
                            {
                                mensaje += " y otro en el de Enfermedad";
                            }
                            else
                            {
                                mensaje += "Debe ingresar un texto en el campo de Enfermedad";
                            }
                        }
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    DataGridViewRow d = dgvTurnos.SelectedRows[0];
                    string turno = d.Cells[0].Value.ToString();
                    bool resultado = Conexion.executeProcedure("RANDOM.TURNO_SIN_CONCRETAR", Conexion.generarArgumentos("@TURNO"), turno);
                    if (resultado)
                    {
                        MessageBox.Show("El diagnóstico se finalizó sin concretar");
                    }
                    this.Hide();
                    FormProvider.MainMenu.Show();
                }
            }
            else
            {
                if (selectedRowCount == 0)
                {
                    MessageBox.Show("Debe seleccionar un turno antes");
                }
                else
                {
                    MessageBox.Show("Solo podrá procesar un turno a la vez");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }
    }
}
