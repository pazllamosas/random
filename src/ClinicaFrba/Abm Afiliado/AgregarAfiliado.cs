﻿using System;
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
            FormProvider.CambioPlanAfiliado.cargaDatos(PlanViejo, nroAfiliadoRaiz);
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
            string estadoCivil = cmbEstadoCivil.Text;
            string cantACargo = txtFamACargo.Text;

            FormProvider.AgregarFamiliarAfiliado.recepcionDatos(nroAfiliadoRaiz, estadoCivil, cantACargo);
            FormProvider.AgregarFamiliarAfiliado.Show();
        }

        public void EditarAfiliado(string idAfiliado, string apellido, string nombre, string nroDocumento, string telefono, string direccion, string fechaNacimiento, string sexo, string tipoDocumento, string plan, string estadoCivil, string cantACargo, string mail, string nroAfiliadoRaiz, string nroAfiliadoExt)
        {
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
            cmbEstadoCivil.SelectedValue = Convert.ToInt32(estadoCivil);
            cmbPlanMedico.SelectedValue = plan;
            cmbTipoDoc.SelectedValue = tipoDocumento;

            //cmbSexo.Items.Add("Femenino");
            //cmbSexo.Items.Add("Masculino");

            editando = true;
            btnGuardar.Text = "Guardar";

            this.cargaDeAgregarFamiliar();

        }

        public void LimpiarCampos()
        {
            this.cmbPlanMedico.SelectedIndex = -1;
            this.cmbSexo.SelectedIndex = -1;
            this.cmbEstadoCivil.SelectedIndex = -1;
            this.cmbTipoDoc.SelectedIndex = -1;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!editando)
            {


                if (validacion())
                {
                    Conexion.executeProcedure("RANDOM.CREAR_AFILIADO",
                        Conexion.generarArgumentos("@NOMBRE", "@APELLIDO", "@SEXO", "@IDTIPODOC", "@DOCUMENTO", "@DIRECCION", "@TELEFONO", "@MAIL", "@FECHANAC", "@IDESTADOCIVIL", "@FAMILIARESACARGO", "@IDPLAN"),
                            txtNombre.Text, txtApellido.Text, cmbSexo.Text, Convert.ToInt32(cmbTipoDoc.SelectedValue), txtNroDoc.Text, txtDomicilio.Text, txtTelefono.Text, txtMail.Text, dtpFechaNac.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(cmbEstadoCivil.SelectedValue), txtFamACargo.Text, Convert.ToInt32(cmbPlanMedico.SelectedValue));
                    MessageBox.Show("Afiliado Principal Creado");

                   

                    this.cargaDeAgregarFamiliar();
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
            if (dtpFechaNac.Checked == false)
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
            string EstadoCivil = cmbEstadoCivil.Text;
            if (EstadoCivil == "Casado" || EstadoCivil == "Concubinato")
            {
                btnAgregarFamiliar.Enabled = true;
            }
            else
            {
                btnAgregarFamiliar.Enabled = false;
            }
            if (Convert.ToInt32(txtFamACargo.Text) > 0)
            {
                btnAgregarFamiliar.Enabled = true;
            }
            else
            {
                btnAgregarFamiliar.Enabled = false;
            }

        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
