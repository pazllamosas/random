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

namespace ClinicaFrba.Registrar_Agenta_Medico
{
    public partial class RegistrarAgenda : Form
    {
        public RegistrarAgenda()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            dgvProfesional.DataSource = null;
            txtDNI.Text = null;
            cmbDias.Text = null;
            comboBox1.Text = null;
            comboBox2.Text = null;
            dgvNuevaAgenda.DataSource = null;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            cmbMes.Text = null;
            cmbMes.Items.Clear();
            txtAnio.Text = null;
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarAgenda_Load(object sender, EventArgs e)
        {
            cmbDias.Items.Add("lunes");
            cmbDias.Items.Add("martes");
            cmbDias.Items.Add("miércoles");
            cmbDias.Items.Add("jueves");
            cmbDias.Items.Add("viernes");
            cmbDias.Items.Add("sabado");
            this.cmbDias.SelectedIndex = -1;
            this.comboBox1.SelectedIndex = -1;
            this.comboBox2.SelectedIndex = -1;
            DateTime fechaHoy = funciones.ObtenerFecha();

            cmbMes.Items.Add("Enero");
            cmbMes.Items.Add("Febrero");
            cmbMes.Items.Add("Marzo");
            cmbMes.Items.Add("Abril");
            cmbMes.Items.Add("Mayo");
            cmbMes.Items.Add("Junio");
            cmbMes.Items.Add("julio");
            cmbMes.Items.Add("Agosto");
            cmbMes.Items.Add("Septiembre");
            cmbMes.Items.Add("Octubre");
            cmbMes.Items.Add("Noviembre");
            cmbMes.Items.Add("Diciembre");
            this.cmbMes.SelectedIndex = -1;



        }


        private void cmbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            string dia = cmbDias.Text;
            Int32 x = funciones.numeroDiaSemana(dia);
            diasDiponibles(x);
        }

        public void diasDiponibles(Int32 x)
        {
            if (x == 7) //sabado 7
            {
                comboBox1.Items.Add("10");
                comboBox1.Items.Add("11");
                comboBox1.Items.Add("12");
                comboBox1.Items.Add("13");
                comboBox1.Items.Add("14");

                comboBox2.Items.Add("11");
                comboBox2.Items.Add("12");
                comboBox2.Items.Add("13");
                comboBox2.Items.Add("14");
                comboBox2.Items.Add("15");
            }
            else
            {
                comboBox1.Items.Add("07");
                comboBox1.Items.Add("08");
                comboBox1.Items.Add("09");
                comboBox1.Items.Add("10");
                comboBox1.Items.Add("11");
                comboBox1.Items.Add("12");
                comboBox1.Items.Add("13");
                comboBox1.Items.Add("14");
                comboBox1.Items.Add("15");
                comboBox1.Items.Add("16");
                comboBox1.Items.Add("17");
                comboBox1.Items.Add("18");
                comboBox1.Items.Add("19");

                comboBox2.Items.Add("08");
                comboBox2.Items.Add("09");
                comboBox2.Items.Add("10");
                comboBox2.Items.Add("11");
                comboBox2.Items.Add("12");
                comboBox2.Items.Add("13");
                comboBox2.Items.Add("14");
                comboBox2.Items.Add("15");
                comboBox2.Items.Add("16");
                comboBox2.Items.Add("17");
                comboBox2.Items.Add("18");
                comboBox2.Items.Add("19");
                comboBox2.Items.Add("20");

            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtDNI.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDNI.Clear();
            }
        }

        private void btnGuardarAgenda_Click(object sender, EventArgs e)
        {

            Int32 selectedRowCount = dgvProfesional.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount == 1)
            {
                if (txtAnio.Text != "" && cmbMes.Text != "" && txtAnio.Text.Length < 5)
                {
                    string HoraDesde = comboBox1.Text;
                    string HoraHasta = comboBox2.Text;
                    string dia = cmbDias.Text;
                    string mes = cmbMes.Text;
                    string Anio = txtAnio.Text;
                    Int32 anio = Convert.ToInt32(Anio);
                    Int32 DiaFinal = UltimoDiaMes(anio, mes);
                    Int32 Mes = mesEnInt(mes);
                    DateTime FechaDesde = new DateTime(anio, Mes, 1, 0, 0, 0);
                    DateTime fechaHasta = new DateTime(anio, Mes, DiaFinal, 0, 0, 0);
                    DateTime fechaHoy = funciones.ObtenerFecha();

                    string fechaDesde = FechaDesde.ToString("yyyy-MM-dd 00:00:00.000");
                    string FechaHasta = fechaHasta.ToString("yyyy-MM-dd 00:00:00.000");

                    if (HoraDesde != "" && HoraHasta != "" && Anio != "" && mes != "")
                    {

                        Int32 FechaDesdeInt = Convert.ToInt32(HoraDesde);

                        Int32 FechaHastaInt = Convert.ToInt32(HoraHasta);

                        if (FechaDesdeInt < FechaHastaInt)
                        {
                            if (FechaDesde >= fechaHoy)
                            {
                                DataGridViewRow d = dgvProfesional.SelectedRows[0];
                                string IdProfesionalS = d.Cells[2].Value.ToString();
                                Int32 IdProfesional = Convert.ToInt32(IdProfesionalS);
                                string IdEspecialidadS = d.Cells[4].Value.ToString();
                                Int32 IdEspecialidad = Convert.ToInt32(IdEspecialidadS);
                                string diaS = cmbDias.Text;
                                Int32 Dia = funciones.numeroDiaSemana(diaS);

                                String query = "SELECT RANDOM.CHEQUEAR_AGENDA ('" + IdProfesional + "', '" + IdEspecialidad + "', '" + Dia + "', '" + FechaDesde.Year + "', '" + FechaDesde.Month + "', '" + fechaHasta.Year + "', '" + fechaHasta.Month + "') AS id";
                                SqlDataReader reader = Conexion.ejecutarQuery(query);
                                reader.Read();
                                Int32 resultado = int.Parse(reader["id"].ToString());
                                reader.Close();
                                if (resultado == 1)
                                {
                                    if (Conexion.executeProcedure("RANDOM.CARGA_AGENDA", Conexion.generarArgumentos("@IdProfesional", "@IdEspecialidad", "@HoraDesde", "@HoraHasta", "@Dia", "@FechaDesde", "@FechaHasta"), IdProfesional, IdEspecialidad, HoraDesde, HoraHasta, Dia, FechaDesde, fechaHasta))
                                    
                                    {
                                        MessageBox.Show("Agenda asignada correctamente");
                                        this.cargaAgenda();
                                        this.limpiarCampos();
                                    }
                                    else
                                    {
                                        this.limpiarCampos();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Ese día ya fue cargado", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El año ingresado no puede ser menor al actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtAnio.Clear();
                            }

                        }
                        else
                        {
                            MessageBox.Show("No puede ser la Hora Desde menor o igual a la Hora Hasta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Llene todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Profesional", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }

        
        public Int32 UltimoDiaMes(Int32 Anio, string Mes)
        {
            if (Mes == "Enero")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 1);
                return dia;
            }
            if (Mes == "Febrero")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 2);
                return dia;
            }
            if (Mes == "Marzo")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 3);
                return dia;
            }
            if (Mes == "Abril")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 4);
                return dia;
            }
            if (Mes == "mayo")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 5);
                return dia;
            }
            if (Mes == "Junio")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 6);
                return dia;
            }
            if (Mes == "Julio")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 7);
                return dia;
            }
            if (Mes == "Agosto")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 8);
                return dia;
            }
            if (Mes == "Septiembre")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 9);
                return dia;
            }
            if (Mes == "octubre")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 10);
                return dia;
            }
            if (Mes == "Noviembre")
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 11);
                return dia;
            }
            else 
            {
                Int32 dia = System.DateTime.DaysInMonth(Anio, 12);
                return dia;
            }

        }

        public Int32 mesEnInt(string Mes)
        {
            if (Mes == "Enero")
            {
                Int32 Numero = 1;
                return Numero;
            }
            if (Mes == "Febrero")
            {
                Int32 Numero = 2;
                return Numero;
            }
            if (Mes == "Marzo")
            {
                Int32 Numero = 3;
                return Numero;
            }
            if (Mes == "Abril")
            {
                Int32 Numero = 4;
                return Numero;
            }
            if (Mes == "Mayo")
            {
                Int32 Numero = 5;
                return Numero;
            }
            if (Mes == "Junio")
            {
                Int32 Numero = 6;
                return Numero;
            }
            if (Mes == "Julio")
            {
                Int32 Numero = 7;
                return Numero;
            }
            if (Mes == "Agosto")
            {
                Int32 Numero = 8;
                return Numero;
            }
            if (Mes == "Septiembre")
            {
                Int32 Numero = 9;
                return Numero;
            }
            if (Mes == "Noviembre")
            {
                Int32 Numero = 10;
                return Numero;
            }
            else
            {
                Int32 Numero = 12;
                return Numero;
            }



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvNuevaAgenda.DataSource = null;
            string dniS = txtDNI.Text;
            if (dniS != "" && dniS.Length <= 18)
            {

                Int32 dni = Convert.ToInt32(dniS);
                Int32 rta = validarDNI(dni);
                if (rta == 1) 
                {
                    dgvProfesional.DataSource = Conexion.obtenerTablaProcedure("RANDOM.TRAER_PROFESIONAL_CON_DNI", Conexion.generarArgumentos("@DNI"), dni);
                    dgvProfesional.Columns[2].Visible = false;
                    dgvProfesional.Columns[4].Visible = false;
                }
                else
                {
                    MessageBox.Show("Seleccione un DNI valido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un DNI de un Profesional", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvProfesional.DataSource = null;
            txtDNI.Text = null;
            cmbDias.Text = null;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Text = null;
            comboBox2.Text = null;
            DateTime fechaHoy = funciones.ObtenerFecha();
            cmbMes.Text = null;
            txtAnio.Text = null;
            dgvNuevaAgenda.DataSource = null;
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

        public void limpiarCampos()
        {
            cmbDias.Text = null;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox1.Text = null;
            comboBox2.Text = null;
            cmbMes.Text = null;
            txtAnio.Text = null;
        }

        public void cargaAgenda()
        {
            DataGridViewRow d = dgvProfesional.SelectedRows[0];
            Int32 IdProfesional = Convert.ToInt32(d.Cells[2].Value);

            dgvNuevaAgenda.DataSource = Conexion.obtenerTablaProcedure("RANDOM.GET_AGENDA",
                Conexion.generarArgumentos("@IdProfesional"), IdProfesional);
        }

        private void dtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAnio_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtAnio.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnio.Clear();
            }

        }
    }
}