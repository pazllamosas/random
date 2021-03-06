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

        //Recibe los datos del afiliado principal y agrega las personas a cargar
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
            if (this.txtTelefono.Text.Trim() == "")
                return false;
            if (this.txtNroDoc.Text.Trim() == "")
                return false;

            return true;
        }

        private bool validacionLongitud()
        {
            if (txtTelefono.Text.Length >= 18)
            {
                MessageBox.Show("Verifique la longitud del teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                
            if (txtNroDoc.Text.Length >= 18)
            {
                MessageBox.Show("Verifique la longitud del nro de documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMail.Text.Length >= 70)
            {
                MessageBox.Show("Verifique la longitud del mail", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtNombre.Text.Length >= 58)
            {
                MessageBox.Show("Verifique la longitud del nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtApellido.Text.Length >= 58)
            {
                MessageBox.Show("Verifique la longitud del apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
            
                
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
            //valida que todos los campos esten completos
            if (validacion())
            {
                //valida la longitud de los campos
                if (validacionLongitud())
                {
                    //verifica que no exista el numero de documento en la base
                    if (!existeDni(txtNroDoc.Text))
                    {
                        string nombre = txtNombre.Text;
                        string apellido = txtApellido.Text;
                        string sexo = cmbSexo.Text;
                        Int32 idTipoDocumento = Convert.ToInt32(cmbTipoDoc.SelectedValue);
                        Int32 documento = Convert.ToInt32(txtNroDoc.Text);
                        string direccion = txtDomicilio.Text;
                        string telefono = txtTelefono.Text;
                        string mail = txtMail.Text;
                        DateTime fechaNacimiento = dtpFechaNac.Value;
                        string nroAfiliadoRaiz = txtNroAf.Text;
                        Int32 idEstadoCivil = estadoCivilAfiliado;
                        Int32 idPlan = planMedico;
                        Int32 cantidadACargo = cantACargoAfiliado;

                        DateTime fechaHoy = funciones.ObtenerFecha();
                        if (dtpFechaNac.Value >= fechaHoy)
                        {
                            MessageBox.Show("Fecha de nacimiento superior a la fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dtpFechaNac.Checked = false;
                            dtpFechaNac.Format = DateTimePickerFormat.Custom;
                            dtpFechaNac.CustomFormat = " ";
                        }
                        else
                        {
                          
                        //si agrega a la pareja entonces se ejecuta el procedure de agregar el cónyuge
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
                                //si agrega a un familiar entonces se ejecuta el procedure de agregar el familiar
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

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            //DateTime fechaHoy = funciones.ObtenerFecha();
            //if (dtpFechaNac.Value >= fechaHoy)
            //{
            //    MessageBox.Show("Fecha de nacimiento superior a la fecha actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    dtpFechaNac.Checked = false;
            //    dtpFechaNac.Format = DateTimePickerFormat.Custom;
            //    dtpFechaNac.CustomFormat = " ";
            //}
            //else
            //{
            //    dtpFechaNac.Format = DateTimePickerFormat.Short;
            //}
        }


    }
}