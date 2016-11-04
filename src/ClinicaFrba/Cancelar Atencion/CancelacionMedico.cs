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

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelacionMedico : Form
    {
        public CancelacionMedico()
        {
            InitializeComponent();
            cmbProfesional.ValueMember = "IdPersona";
            cmbProfesional.DisplayMember = "Apellido";
            cmbProfesional.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_MEDICOS");
            this.cmbProfesional.SelectedIndex = -1;
            
            cmbTipoCancelacion.ValueMember = "IdTipoCancelacion";
            cmbTipoCancelacion.DisplayMember = "Descripcion";
            cmbTipoCancelacion.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_TIPOS_CANCELACION");
            this.cmbTipoCancelacion.SelectedIndex = -1;
        }

        private void btnGuardarCanc_Click(object sender, EventArgs e)
        {
            if (cmbProfesional.SelectedIndex >= 0)
            {
                if (dtpDesde.Value.Date <= dtpHasta.Value.Date)
                {
                    if (cmbTipoCancelacion.SelectedIndex >= 0 && txtMotivoCancelacion.Text.Length > 0)
                    {
                        string profesional = cmbProfesional.SelectedValue.ToString();
                        string fechaDesde = dtpDesde.Value.Date.ToString();
                        string fechaHasta = dtpHasta.Value.Date.ToString();
                        string tipo = cmbTipoCancelacion.SelectedValue.ToString();
                        string motivo = txtMotivoCancelacion.Text;
                        bool resultado = Conexion.executeProcedure("RANDOM.CANCELAR_TURNO_PROFESIONAL", Conexion.generarArgumentos("@PROFESIONAL", "@FECHADESDE", "@FECHAHASTA", "@TIPO", "@MOTIVO"), profesional, fechaDesde, fechaHasta, tipo, motivo);
                        if (resultado)
                        {
                            MessageBox.Show("Turno(s) cancelado(s) satisfactoriamente");
                        }
                    }
                    else
                    {
                        string mensaje = "";
                        if (cmbTipoCancelacion.SelectedIndex < 0)
                        {
                            mensaje += "Debe seleccionar un item del tipo de cancelación";
                        }
                        if (txtMotivoCancelacion.Text.Length == 0)
                        {
                            if (cmbTipoCancelacion.SelectedIndex < 0)
                            {
                                mensaje += " e ingresar un motivo";
                            }
                            else
                            {
                                mensaje += "Debe ingresar un motivo de cancelación";
                            }
                        }
                        MessageBox.Show(mensaje);
                    }
                }
                else
                {
                    MessageBox.Show("Controle el rango de fechas y vuelva a intentarlo");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un profesional de la lista");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.Cancelacion.Show();
        }
    }
}
