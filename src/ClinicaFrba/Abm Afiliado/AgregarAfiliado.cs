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
    public partial class AgregarAfiliado : Form
    {
        private static bool editando = false;
        public AgregarAfiliado()
        {
            InitializeComponent();
        }

        private void AgregarAfiliado_Load(object sender, EventArgs e)
        {
            //cmbPlanMedico.ValueMember = "IdPlan";
            //cmbPlanMedico.DisplayMember = "Nombre";
            //cmbPlanMedico.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_PLANES");

            //cmbSexo.Items.Add("Femenino");
            //cmbSexo.Items.Add("Masculino");

            //cmbEstadoCivil.ValueMember = "IdEstadoCivil";
            //cmbEstadoCivil.DisplayMember = "Descripcion";
            //cmbEstadoCivil.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_ESTADO_CIVIL");

            //cmbTipoDoc.ValueMember = "IdTipoDocumento";
            //cmbTipoDoc.DisplayMember = "Descripcion";
            //cmbTipoDoc.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_TIPO_DOCUMENTO");

           

            //this.cmbPlanMedico.SelectedIndex = -1;
            //this.cmbSexo.SelectedIndex = -1;
            //this.cmbEstadoCivil.SelectedIndex = -1;
            //this.cmbTipoDoc.SelectedIndex = -1;


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.Hide();
            FormProvider.Afiliado.Show();
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFamACargo_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtFamACargo.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFamACargo.Clear();
            }

        }

        private void btnCambiarPlan_Click(object sender, EventArgs e)
        {
            string PlanViejo = cmbPlanMedico.Text;
            string nroAfiliadoRaiz = txtNroAf.Text;
            string documento = txtNroAf.Text;
            FormProvider.CambioPlanAfiliado.cargaDatos(PlanViejo, documento);
            FormProvider.CambioPlanAfiliado.Show();
        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtTelefono.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Clear();
            }

        }

        private void lblDomicilio_Click(object sender, EventArgs e)
        {

        }

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarFamiliar_Click(object sender, EventArgs e)
        {
            string nroAfiliadoRaiz = txtNroAf.Text;
            Int32 estadoCivil = cmbEstadoCivil.SelectedIndex;
            Int32 cantACargo = Convert.ToInt32(txtFamACargo.Text);
            Int32 planMedico = Convert.ToInt32(cmbPlanMedico.SelectedValue);

            FormProvider.AgregarFamiliarAfiliado.recepcionDatos(nroAfiliadoRaiz, estadoCivil, cantACargo, planMedico);
            FormProvider.AgregarFamiliarAfiliado.Show();
        }

        public void EditarAfiliado(string idAfiliado, string apellido, string nombre, string nroDocumento, string telefono, string direccion, string fechaNacimiento, string sexo, string tipoDocumento, string plan, string estadoCivil, string cantACargo, string mail, string nroAfiliadoRaiz, string nroAfiliadoExt)
        {
            this.cargaCombos();
            txtApellido.Text = apellido;
            txtNombre.Text = nombre;
            txtNroDoc.Text = nroDocumento;
            txtTelefono.Text = telefono;
            txtDomicilio.Text = direccion;
            dtpFechaNac.Text = fechaNacimiento;
            cmbSexo.Text = sexo;
            txtFamACargo.Text = cantACargo;
            txtMail.Text = mail;
            txtNroAf.Text = nroAfiliadoRaiz;
            cmbEstadoCivil.SelectedValue= estadoCivil;
            cmbPlanMedico.SelectedValue = plan;
            cmbTipoDoc.SelectedValue = tipoDocumento;

            //cmbSexo.Items.Add("Femenino");
            //cmbSexo.Items.Add("Masculino");

            editando = true;
            btnGuardar.Text = "Guardar";

            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            cmbTipoDoc.Enabled = false;
            txtNroDoc.ReadOnly = true;
            dtpFechaNac.Enabled = false;
            //cmbPlanMedico.Enabled = false;
            //btnCambiarPlan.Visible = true;

            this.cargaDeAgregarFamiliar();

            if (!(nroAfiliadoExt == "01"))
            {
                cmbPlanMedico.Enabled = false;
                btnCambiarPlan.Visible = false;
                cmbEstadoCivil.Enabled = false;
                txtFamACargo.Enabled = false;

            }
            else
            {
                cmbPlanMedico.Enabled = false;
                btnCambiarPlan.Visible = true;

            }

        }

        public void agregarNuevoAfiliado()
        {
            this.LimpiarCampos();
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            cmbTipoDoc.Enabled = true;
            txtNroDoc.ReadOnly = false;
            dtpFechaNac.Enabled = true;
            cmbPlanMedico.Enabled = true;
            btnCambiarPlan.Visible = false;
            cmbEstadoCivil.Enabled = true;
            txtFamACargo.Enabled = true;

        }



        public void LimpiarCampos()
        {
            this.cmbPlanMedico.SelectedIndex = -1;
            this.cmbSexo.SelectedIndex = -1;
            this.cmbEstadoCivil.SelectedIndex = -1;
            this.cmbTipoDoc.SelectedIndex = -1;
            this.txtApellido.Clear();
            this.txtDomicilio.Clear();
            this.txtFamACargo.Clear();
            this.txtMail.Clear();
            this.txtNombre.Clear();
            this.txtNroAf.Clear();
            this.txtNroDoc.Clear();
            this.txtTelefono.Clear();
            dtpFechaNac.Checked = false;
            dtpFechaNac.Value = DateTime.Today;
            
        }

        public void cargaCombos()
        {
            cmbPlanMedico.ValueMember = "IdPlan";
            cmbPlanMedico.DisplayMember = "Nombre";
            cmbPlanMedico.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_PLANES");

            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Masculino");

            cmbEstadoCivil.ValueMember = "IdEstadoCivil";
            cmbEstadoCivil.DisplayMember = "Descripcion";
            cmbEstadoCivil.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_ESTADO_CIVIL");

            cmbTipoDoc.ValueMember = "IdTipoDocumento";
            cmbTipoDoc.DisplayMember = "Descripcion";
            cmbTipoDoc.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_TIPO_DOCUMENTO");

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {


                if (validacion())
                {
                    if(!existeDni(txtNroDoc.Text))
                    {
                    Conexion.executeProcedure("RANDOM.CREAR_AFILIADO",
                        Conexion.generarArgumentos("@NOMBRE", "@APELLIDO", "@SEXO", "@IDTIPODOC", "@DOCUMENTO", "@DIRECCION", "@TELEFONO", "@MAIL", "@FECHANAC", "@IDESTADOCIVIL", "@FAMILIARESACARGO", "@IDPLAN"),
                            txtNombre.Text, txtApellido.Text, cmbSexo.Text, Convert.ToInt32(cmbTipoDoc.SelectedValue), txtNroDoc.Text, txtDomicilio.Text, txtTelefono.Text, txtMail.Text, dtpFechaNac.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(cmbEstadoCivil.SelectedValue), txtFamACargo.Text, Convert.ToInt32(cmbPlanMedico.SelectedValue));
                    MessageBox.Show("Afiliado Principal Creado");

                        this.cargaDeAgregarFamiliar();

                        string query = "SELECT RANDOM.GET_NRO_AFILIADO_RAIZ ('" + txtNroDoc.Text + "') AS id";
                        SqlDataReader reader = Conexion.ejecutarQuery(query);
                        reader.Read();
                        string respuesta = (reader["id"].ToString());
                        reader.Close();
                        txtNroAf.Text =  respuesta;

                    }

                }
                else
                {
                    MessageBox.Show("Faltan cargar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (validacion())
                {
                    string dni = txtNroDoc.Text;
                    string query = "SELECT RANDOM.GET_ID_PERSONA ('" + dni + "' ) AS id";

                    SqlDataReader reader = Conexion.ejecutarQuery(query);
                    reader.Read();
                    int idPersona = int.Parse(reader["id"].ToString());
                    reader.Close();

                    Conexion.executeProcedure("RANDOM.MODIFICAR_AFILIADO",
                        Conexion.generarArgumentos("IDPERSONA", "NOMBRE", "APELLIDO", "SEXO", "IDTIPODOC", "DOCUMENTO", "DIRECCION", "TELEFONO", "MAIL", "FECHANAC", "IDESTADOCIVIL", "FAMILIARESACARGO", "IDPLAN"),
                        idPersona, txtNombre.Text, txtApellido.Text, cmbSexo.Text, Convert.ToInt32(cmbTipoDoc.SelectedValue), txtNroDoc.Text, txtDomicilio.Text, txtTelefono.Text, txtMail.Text, dtpFechaNac.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(cmbEstadoCivil.SelectedValue), txtFamACargo.Text, Convert.ToInt32(cmbPlanMedico.SelectedValue));
                    MessageBox.Show("Afiliado Principal Modificado");
                    this.cargaDeAgregarFamiliar();
                }
                else
                {
                    MessageBox.Show("Faltan cargar datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private bool validacion()
        {
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
            if (this.txtFamACargo.Text.Trim() == "")
                return false;
            if (this.txtMail.Text.Trim() == "")
                return false;
            if (cmbSexo.Text.Trim() == "")
                return false;
            if (cmbTipoDoc.SelectedIndex == -1)
                return false;
            if (cmbPlanMedico.SelectedIndex == -1)
                return false;
            if (cmbEstadoCivil.SelectedIndex == -1)
                return false;
            if (dtpFechaNac.Text.Length < 0)
                 return false;

            

            return true;
        }

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaNac.Value > DateTime.Today)
            {
                MessageBox.Show("Fecha de nacimiento superior a la fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNac.Checked = false;
                dtpFechaNac.Format = DateTimePickerFormat.Custom;
                dtpFechaNac.CustomFormat = " ";
           }
            else
            {
                dtpFechaNac.Format = DateTimePickerFormat.Short;
            }
        }

        private void txtNroDoc_TextChanged(object sender, EventArgs e)
        {
            if (!funciones.permiteNumeros(txtNroDoc.Text))
            {
                MessageBox.Show("Solo se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNroDoc.Clear();            
            }
        }



        private void cargaDeAgregarFamiliar()
        {
            Int32 EstadoCivil = cmbEstadoCivil.SelectedIndex;
            if ((EstadoCivil == 1 || EstadoCivil == 4) || (Convert.ToInt32(txtFamACargo.Text) > 0) )
            {
                btnAgregarFamiliar.Enabled = true;
            }
            else
            {
                btnAgregarFamiliar.Enabled = false;
            }
            //if (Convert.ToInt32(txtFamACargo.Text) > 0)
            //{
            //    btnAgregarFamiliar.Enabled = true;
            //}
            //else
            //{
            //    btnAgregarFamiliar.Enabled = false;
            //}

        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        public Boolean existeDni(string dni)
        {
            string query = "SELECT RANDOM.EXISTE_AFILIADO ('" + dni + "' ) AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta >= 1)
            {
                MessageBox.Show("El Dni ya esta ingresado en la base", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;

             }
            else
            {
                return false;
            }
        }

        public void cargaNuevoPlan(string nuevoPlan)
        {
            cmbPlanMedico.Text = nuevoPlan;

        }


    }
}
