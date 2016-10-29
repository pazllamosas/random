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

            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Masculino");

            cmbTipoDoc.ValueMember = "IdTipoDocumento";
            cmbTipoDoc.DisplayMember = "Descripcion";
            cmbTipoDoc.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_TIPO_DOCUMENTO");

            //if (estadoCivilAfiliado == "Casado" || estadoCivilAfiliado == "Concubinato")
            //    cmbFamiliar.Items.Add("Pareja");
            //if (Convert.ToInt32(cantACargoAfiliado) > 0)
            //    cmbFamiliar.Items.Add("Familiar a cargo");
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtTelefono.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Clear();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string sexo = cmbSexo.Text;
                Int32 idTipoDocumento = Convert.ToInt32(cmbTipoDoc.SelectedValue);
                string documento = txtNroDoc.Text;
                string direccion = txtDomicilio.Text;
                string telefono = txtTelefono.Text;
                string mail = txtMail.Text;
                string fechaNacimiento = dtpFechaNac.Value.ToString("yyyy-MM-dd");
                string nroAfiliadoRaiz = txtNroAf.Text;

                Conexion.executeProcedure("RANDOM.CREAR_FAMILIAR",
                    Conexion.generarArgumentos("NOMBRE", "APELLIDO", "SEXO", "IDTIPODOC", "DOCUMENTO", "DIRECCION", "TELEFONO", "MAIL", "FECHANAC", "NRO_AFILIADO_RAIZ"),
                    nombre, apellido, sexo, idTipoDocumento, documento, direccion, telefono, mail, fechaNacimiento, nroAfiliadoRaiz);
                if (cmbFamiliar.Text == "Pareja")
                {
                    Conexion.executeProcedure("RANDOM.NRO_AFILIADO_CONYUGE",
                        Conexion.generarArgumentos("NROAFILIADORAIZ"),
                        nroAfiliadoRaiz);
                }
                else
                {
                    Conexion.executeProcedure("RANDOM.NRO_AFILIADO_FAMILIARES",
                        Conexion.generarArgumentos("NROAFILIADORAIZ"),
                        nroAfiliadoRaiz);
                }
            }

        }

        private bool validacion()
        {
            if (this.cmbFamiliar.Text.Trim() == "")
                return false;
            if (this.txtNombre.Text.Trim() == "")
                return false;
            if (this.txtApellido.Text.Trim() == "")
                return false;
            if (this.txtTelefono.Text.Trim() == "")
                return false;
            if (this.txtDomicilio.Text.Trim() == "")
                return false;
            if (this.txtNroDoc.Text.Trim() == "")
                return false;
            if (this.txtMail.Text.Trim() == "")
                return false;
            if (cmbSexo.Text.Trim() == "")
                return false;
            if (cmbTipoDoc.SelectedIndex == -1)
                return false;
            if (dtpFechaNac.Checked == false)
                return false;

            return true;
        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtNroDoc.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Clear();
            }

        }



    }
}