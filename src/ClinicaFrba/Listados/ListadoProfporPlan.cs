using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Listados
{
    public partial class ListadoProfporPlan : Form
    {
        public ListadoProfporPlan()
        {
            InitializeComponent();

            dgvResultado.Rows.Clear();
            pickerAño.Format = DateTimePickerFormat.Custom;
            pickerAño.CustomFormat = "yyyy";
            pickerAño.ShowUpDown = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.ListadoEstadistico.Show();
        }

        private void lblSemestre_Click(object sender, EventArgs e)
        {

        }

        private void cmbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvResultado.Columns.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 mesInicio;
            Int32 mesFin;
            if (cmbSemestre.SelectedIndex == 0)
            {
                mesInicio = 1;
                mesFin = 6;
            }
            else
            {
                mesInicio = 7;
                mesFin = 12;
            }
            //Creo las fechas de inicio y fin dependiendo del año y el semestre elegido
            DateTime fechaInicio = new DateTime(Int32.Parse(pickerAño.Text), mesInicio, 1);
            DateTime fechaFin = new DateTime(Int32.Parse(pickerAño.Text), mesFin, 1);
            List<string> lista = new List<string>();
            lista.Add("@fechaFrom");
            lista.Add("@fechaTo");
            lista.Add("@idPlan");

        
            switch (cmbPlan.SelectedIndex){
                case 0:
                    DataTable dt0 = Conexion.obtenerTablaProcedure("RANDOM.top5ProfesionalesMasConsultadosPorPlan",
                    lista, String.Format("{0:yyyyMMdd HH:mm:ss}", fechaInicio), String.Format("{0:yyyyMMdd HH:mm:ss}", fechaFin),1);
                    this.dgvResultado.DataSource = dt0;
                    dgvResultado.Enabled = false;
                    break;
                case 1:
                    DataTable dt1 = Conexion.obtenerTablaProcedure("RANDOM.top5ProfesionalesMasConsultadosPorPlan",
                    lista, String.Format("{0:yyyyMMdd HH:mm:ss}", fechaInicio), String.Format("{0:yyyyMMdd HH:mm:ss}", fechaFin),5);
                    this.dgvResultado.DataSource = dt1;
                    dgvResultado.Enabled = false;
                    break;
                case 2:
                    DataTable dt2 = Conexion.obtenerTablaProcedure("RANDOM.top5ProfesionalesMasConsultadosPorPlan",
                    lista, String.Format("{0:yyyyMMdd HH:mm:ss}", fechaInicio), String.Format("{0:yyyyMMdd HH:mm:ss}", fechaFin),3);
                    this.dgvResultado.DataSource = dt2;
                    dgvResultado.Enabled = false;
                    break;
                case 3:
                    DataTable dt3 = Conexion.obtenerTablaProcedure("RANDOM.top5ProfesionalesMasConsultadosPorPlan",
                    lista, String.Format("{0:yyyyMMdd HH:mm:ss}", fechaInicio), String.Format("{0:yyyyMMdd HH:mm:ss}", fechaFin),4);
                    this.dgvResultado.DataSource = dt3;
                    dgvResultado.Enabled = false;
                    break;
                case 4:
                    DataTable dt4 = Conexion.obtenerTablaProcedure("RANDOM.top5ProfesionalesMasConsultadosPorPlan",
                    lista, String.Format("{0:yyyyMMdd HH:mm:ss}", fechaInicio), String.Format("{0:yyyyMMdd HH:mm:ss}", fechaFin),2);
                    this.dgvResultado.DataSource = dt4;
                    dgvResultado.Enabled = false;
                    break;
            
             }

        
        }
    }
}