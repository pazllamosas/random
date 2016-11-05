using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dgvProfesional.DataSource = null;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
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
                comboBox1.Items.Add("15");

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


                comboBox2.Items.Add("07");
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

        }

        private void btnGuardarAgenda_Click(object sender, EventArgs e)
        
        {
            
                Int32 selectedRowCount = dgvProfesional.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount == 1)
                {
                    string FechaDesde = comboBox1.Text;
                    string FechaHasta = comboBox2.Text;
                    string dia = cmbDias.Text;

                    if (FechaDesde != "" && FechaHasta != "" && FechaDesde != "")
                    {
                    
                    Int32 FechaDesdeInt = Convert.ToInt32(FechaDesde);
                    
                    Int32 FechaHastaInt = Convert.ToInt32(FechaHasta);

                    if (FechaDesdeInt < FechaHastaInt)
                        {

                        DataGridViewRow d = dgvProfesional.SelectedRows[0];
                        string IdProfesionalS = d.Cells[2].Value.ToString();
                        Int32 IdProfesional = Convert.ToInt32(IdProfesionalS);
                        string IdEspecialidadS = d.Cells[4].Value.ToString();
                        Int32 IdEspecialidad = Convert.ToInt32(IdEspecialidadS);
                        string diaS = cmbDias.Text;
                        Int32 Dia = funciones.numeroDiaSemana(diaS);

                        Conexion.executeProcedure("RANDOM.CARGA_AGENDA", Conexion.generarArgumentos("@IdProfesional", "@IdEspecialidad", "@HoraDesde", "@HoraHasta", "@Dia"), IdProfesional, IdEspecialidad, FechaDesde, FechaHasta, Dia);
                        MessageBox.Show("Agenda asignada correctamente");
                        dgvProfesional.DataSource = null;
                        txtDNI.Text = null;
                        cmbDias.Text = null;
                        comboBox1.Items.Clear();
                        comboBox2.Items.Clear();
                        comboBox1.Text = null;
                        comboBox2.Text = null;
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
                    MessageBox.Show("Seleccione un Profesional", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
            }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dniS = txtDNI.Text;
            if (dniS != "")
            {
            
            Int32 dni = Convert.ToInt32(dniS);
            dgvProfesional.DataSource = Conexion.obtenerTablaProcedure("RANDOM.TRAER_PROFESIONAL_CON_DNI", Conexion.generarArgumentos("@DNI"), dni);
            dgvProfesional.Columns[2].Visible = false;
            dgvProfesional.Columns[4].Visible = false;
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
        }
    }
}
