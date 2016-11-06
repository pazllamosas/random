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
        Int32 estadoCivilAfiliado;
        Int32 cantACargoAfiliado;
        Int32 planMedico;

        public AgregarFamiliar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.Hide();
            FormProvider.Agafiliado.Show();
        }

        public void recepcionDatos(string nroAfiliadoRaiz, Int32 estadoCivil, Int32 cantACargo, Int32 idPlan)
        {
            txtNroAf.Text = nroAfiliadoRaiz;
            estadoCivilAfiliado = estadoCivil;
            cantACargoAfiliado = cantACargo;
            planMedico = idPlan;

            if (estadoCivilAfiliado == 1 || estadoCivilAfiliado == 4)
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

            this.cmbTipoDoc.SelectedIndex = -1;

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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (validacion())
            {

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string sexo = cmbSexo.Text;
                Int32 idTipoDocumento = Convert.ToInt32(cmbTipoDoc.SelectedValue);
                Int32 documento = Convert.ToInt32(txtNroDoc.Text);
                string direccion = txtDomicilio.Text;
                string telefono = txtTelefono.Text;
                string mail = txtMail.Text;
                string fechaNacimiento = dtpFechaNac.Value.ToString("yyyy-MM-dd");
                string nroAfiliadoRaiz = txtNroAf.Text;
                Int32 idEstadoCivil = estadoCivilAfiliado;
                Int32 idPlan = planMedico;
                Int32 cantidadACargo = cantACargoAfiliado;

                //if (Conexion.executeProcedure("RANDOM.CREAR_FAMILIAR",
                //     Conexion.generarArgumentos("NOMBRE", "APELLIDO", "SEXO", "IDTIPODOC", "DOCUMENTO", "DIRECCION", "TELEFONO", "MAIL", "FECHANAC", "IDPLAN", "IDESTADOCIVIL", "NRO_AFILIADO_RAIZ"),
                //     nombre, apellido, sexo, idTipoDocumento, documento, direccion, telefono, mail, fechaNacimiento, idPlan, idEstadoCivil, nroAfiliadoRaiz))

                    if (cmbFamiliar.Text == "Pareja")
                    {
                        if (Conexion.executeProcedure("RANDOM.CREAR_CONYUGE",
                    Conexion.generarArgumentos("NOMBRE", "APELLIDO", "SEXO", "IDTIPODOC", "DOCUMENTO", "DIRECCION", "TELEFONO", "MAIL", "FECHANAC", "IDPLAN", "IDESTADOCIVIL", "NRO_AFILIADO_RAIZ"),
                    nombre, apellido, sexo, idTipoDocumento, documento, direccion, telefono, mail, fechaNacimiento, idPlan, idEstadoCivil, nroAfiliadoRaiz))
                        {
                            Conexion.executeProcedure("RANDOM.NRO_AFILIADO_CONYUGE",
                            Conexion.generarArgumentos("NROAFILIADORAIZ", "DOCUMENTO"),
                            nroAfiliadoRaiz, documento);
                            MessageBox.Show("Conyuge creado");
                            this.LimpiarCampos();
                            this.Hide();
                        }
                        else
                        {
                            this.LimpiarCampos();
                            this.Hide();
                        }
                    }
                    else
                    {
                        if (Conexion.executeProcedure("RANDOM.CREAR_FAMILIAR",
                     Conexion.generarArgumentos("NOMBRE", "APELLIDO", "SEXO", "IDTIPODOC", "DOCUMENTO", "DIRECCION", "TELEFONO", "MAIL", "FECHANAC", "IDPLAN", "IDESTADOCIVIL", "NRO_AFILIADO_RAIZ"),
                     nombre, apellido, sexo, idTipoDocumento, documento, direccion, telefono, mail, fechaNacimiento, idPlan, idEstadoCivil, nroAfiliadoRaiz))
                        {
                            Conexion.executeProcedure("RANDOM.NRO_AFILIADO_FAMILIARES",
                            Conexion.generarArgumentos("NROAFILIADORAIZ", "DOCUMENTO", "CANTIDAD_A_CARGO"),
                            nroAfiliadoRaiz, documento, cantidadACargo);
                            MessageBox.Show("Familiar a cargo creado");
                            this.LimpiarCampos();
                            this.Hide();
                        }
                        else
                        {
                            this.LimpiarCampos();
                            this.Hide();
                        }
                    }
            }
            else
            {
                MessageBox.Show("Hay campos sin completar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   

        }

        public void LimpiarCampos()
        {
            this.cmbSexo.SelectedIndex = -1;
            this.cmbTipoDoc.SelectedIndex = -1;
            this.txtApellido.Clear();
            this.txtNombre.Clear();
            dtpFechaNac.Checked = false;
            dtpFechaNac.Value = DateTime.Today;
            this.txtTelefono.Clear();
            this.txtDomicilio.Clear();
            this.txtMail.Clear();
            this.txtNroDoc.Clear();
            this.cmbFamiliar.SelectedIndex = -1;
            this.cmbFamiliar.Items.Remove("Pareja");
            this.cmbFamiliar.Items.Remove("Familiar a cargo");
         }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteLetras(txtApellido.Text))
            {
                MessageBox.Show("Solo se permiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Clear();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteLetras(txtNombre.Text))
            {
                MessageBox.Show("Solo se permiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Clear();
            }
        }



    }
}