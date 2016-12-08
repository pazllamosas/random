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
            dtpFecha.Value = funciones.ObtenerFecha();
            CargarTurnosDelDia(dtpFecha.Value.Date);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarTurnosDelDia(dtpFecha.Value.Date);
        }

        public void CargarTurnosDelDia(DateTime turnoFecha)
        {
            dgvTurnos.Rows.Clear();
            string query = "SELECT T.IdTurno, CONVERT(nvarchar(18), A.NumeroAfiliadoRaiz) + '-' + A.NumeroAfiliadoExt AS 'Afiliado', P.Nombre, P.Apellido, T.FechaYHoraTurno ";
            query = query + "FROM RANDOM.TURNO T, RANDOM.AFILIADO A, RANDOM.PERSONA P ";
            query = query + "WHERE A.IdPersona = T.IdAfiliado AND P.IdPersona = A.IdPersona AND DAY(T.FechaYHoraTurno) = ";
            query = query + turnoFecha.Day.ToString() + " AND MONTH(T.FechaYHoraTurno) = " + turnoFecha.Month.ToString();
            query = query + " AND YEAR(T.FechaYHoraTurno) = " + turnoFecha.Year.ToString() + " AND T.Habilitado = 0";
            
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvTurnos.Rows.Add(reader["IdTurno"], reader["Afiliado"], reader["Nombre"], reader["Apellido"], reader["FechaYHoraTurno"]);
            }
            reader.Close();
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
                        bool resultado = Conexion.executeProcedure("RANDOM.TURNO_CONCRETADO", Conexion.generarArgumentos("@TURNO", "@FECHA", "@SINTOMAS", "@ENFERMEDAD"), turno, funciones.ObtenerFecha(), sintomas, enfermedad);
                        if (resultado)
                        {
                            MessageBox.Show("El diagnóstico finalizó correctamente");
                            this.limpiarCampos();
                        }
                        CargarTurnosDelDia(dtpFecha.Value.Date);
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
                    bool resultado = Conexion.executeProcedure("RANDOM.TURNO_SIN_CONCRETAR", Conexion.generarArgumentos("@TURNO", "@FECHA"), turno, funciones.ObtenerFecha());
                    if (resultado)
                    {
                        MessageBox.Show("El diagnóstico se finalizó sin concretar");
                        this.limpiarCampos();
                    }
                    CargarTurnosDelDia(dtpFecha.Value.Date);
                }
            }
            else
            {
                if (selectedRowCount == 0)
                {
                    MessageBox.Show("Primero debe seleccionar un turno");
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

        public void limpiarCampos()
        {
            txtSintomas.Clear();
            txtEnfermedad.Clear();
            cckTurno.Checked = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniS = txtDNI.Text;
            if (dniS != "" && dniS.Length <= 18)
            {

                Int32 dni = Convert.ToInt32(dniS);
                Int32 rta = validarDNI(dni);
                if (rta == 1)
                {
                    cckTurno.Enabled = true;
                    dtpFecha.Enabled = true;
                    dgvTurnos.Enabled = true;
                    txtEnfermedad.Enabled = true;
                    txtSintomas.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Seleccione un DNI valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Complete un DNI de un Profesional", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public Int32 validarDNI(Int32 dni)
        {
            String query = "SELECT RANDOM.VALIDAR_DNI ('" + dni + "') AS id";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();
            if (respuesta == 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();

        }
    }
}
