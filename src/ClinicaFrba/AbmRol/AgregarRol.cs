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

namespace ClinicaFrba.AbmRol
{
    public partial class AgregarRol : Form
    {

        private static bool editando = false;
        public AgregarRol()
        {
            InitializeComponent();

            dgvFuncionalidades.Rows.Clear();
            string query = "SELECT * FROM RANDOM.FUNCIONALIDADES order by IdFuncionalidad";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            while (reader.Read())
                {
                    dgvFuncionalidades.Rows.Add(reader["IdFuncionalidad"], reader["DescripcionFunc"]);
                }
            reader.Close();
           editando = false;
           
         }
        
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            this.txtNombre.Clear();
            this.txtIdRol.Clear();
            this.cmbUsuario.SelectedIndex = -1;
            this.Hide();
            FormProvider.Rol.CargarRoles();
            FormProvider.Rol.Show();
        }

        private void btnCrearRol_Click(object sender, EventArgs e)
        {
           if (!editando)
            {
                string nombre = txtNombre.Text;

                if (validacion())
                {
                    bool resultado = Conexion.executeProcedure("RANDOM.CREAR_ROL", Conexion.generarArgumentos("@NOMBRE"), nombre);
                    if (resultado)
                    {
                        string query = "SELECT RANDOM.GET_ID_ROL ('" + nombre + "' ) AS id";
                        SqlDataReader reader = Conexion.ejecutarQuery(query);
                        reader.Read();
                        string respuesta = (reader["id"].ToString());
                        reader.Close();
                        txtIdRol.Text = respuesta;
                        MessageBox.Show("Rol creado");
                        dgvFuncionalidades.ReadOnly = false;
                        btnAgregarFunc.Enabled = true;
                        btnEliminarFunc.Enabled = true;
                        cmbUsuario.Enabled = true;
                        btnAsignarUsuario.Enabled = true;
                    }
                } else
                    MessageBox.Show("Falta agregar funcionalidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            } else
            {
                if (editando)
                {
                    string nombre = txtNombre.Text;
                    string idRol = txtIdRol.Text;
                    bool resultado = Conexion.executeProcedure("RANDOM.MODIFICAR_NOMBRE_ROL", Conexion.generarArgumentos("@NOMBRE", "@ROL "), nombre, idRol);
                    if (resultado)
                    {
                        MessageBox.Show("Rol modificado");
                    }
                }
            }
        }

        private void btnEditarNombre_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
        }

        public void EditarRol(string rol, string rolDesc) 
        {
            txtIdRol.Text = rol;
            txtNombre.Text = rolDesc;
            txtNombre.ReadOnly = true;
            editando = true;
            btnCrearRol.Enabled = false;
            btnCrearRol.Text = "Guardar Rol";
            dgvFuncionalidades.ReadOnly = false;
            btnAgregarFunc.Enabled = true;
            btnEliminarFunc.Enabled = true;
            cmbUsuario.Enabled = true;
            btnAsignarUsuario.Enabled = true;

        }

       private void btnAgregarFunc_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvFuncionalidades.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvFuncionalidades.SelectedRows[0];
                Int32 funcionalidad = Convert.ToInt32(d.Cells[0].Value);
                string funcDesc = d.Cells[1].Value.ToString();
                Int32 idRol = Convert.ToInt32(txtIdRol.Text);

                if (existeFuncionalidad(funcionalidad, idRol))
                {
                    bool resultado = Conexion.executeProcedure("RANDOM.ASIGNAR_FUNCIONALIDAD", Conexion.generarArgumentos("@FUNCIONALIDAD", "@ROL"), funcionalidad, idRol);
                    if (resultado)
                    {
                        MessageBox.Show("Funcionalidad Asignada");
                    }
                } else
                    {
                    MessageBox.Show("Esa funcionalidad ya esta asignada al rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
            } else
                {
                MessageBox.Show("Elegir una y solo una funcionalidad para agregar", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
       }
        
        public Boolean existeFuncionalidad(Int32 funcionalidad, Int32 rol)
        {
            string query = "SELECT RANDOM.EXISTE_FUNCIONALIDAD_ROL ('" + funcionalidad + "', '" + rol + "' ) AS id";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();
            if (respuesta == 0)
                {
                return true;
                } else
                    {
                    return false;
                    }
         }

        public Boolean existeRol(string nombre)
        {
            string query = "SELECT RANDOM.EXISTE_ROL ('" + nombre + "' ) AS id";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();
            if (respuesta == 0)
                {
                return true;
                } else
                {
                return false;
                }
        }

        private bool validacion()
        {
            if (this.txtNombre.Text.Trim() == "")
                return false;
           
            return true;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            btnCrearRol.Enabled = true;
        }

        private void btnEliminarFunc_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvFuncionalidades.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvFuncionalidades.SelectedRows[0];
                Int32 funcionalidad = Convert.ToInt32(d.Cells[0].Value);
                string funcDesc = d.Cells[1].Value.ToString();
                Int32 idRol = Convert.ToInt32(txtIdRol.Text);
                if (!existeFuncionalidad(funcionalidad, idRol))
                {
                    bool resultado = Conexion.executeProcedure("RANDOM.ELIMINAR_FUNCIONALIDAD_DEL_ROL", Conexion.generarArgumentos("@FUNCIONALIDAD", "@ROL"), funcionalidad, idRol);
                    if (resultado)
                        {
                        MessageBox.Show("Funcionalidad Eliminada");
                        }
                } else
                    {
                    MessageBox.Show("Esa funcionalidad no esta asignada al rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
            } else
                {
                MessageBox.Show("Elegir una y solo una funcionalidad para eliminar", "Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
        }

        private void btnAsignarUsuario_Click(object sender, EventArgs e)
        {
            Int32 idRol = Convert.ToInt32(txtIdRol.Text);
            Int32 usuario = Convert.ToInt32(cmbUsuario.SelectedValue);

            if (!(this.cmbUsuario.SelectedIndex == -1))
            {
                if (existeUsuarioEnRol(usuario, idRol))
                {
                    string query = "SELECT RANDOM.GET_ID_USUARIO ('" + cmbUsuario.Text + "') AS id";

                    SqlDataReader reader = Conexion.ejecutarQuery(query);
                    reader.Read();
                    string idUsuario = reader["id"].ToString();
                    reader.Close();
                    bool resultado = Conexion.executeProcedure("RANDOM.ASIGNAR_ROL", Conexion.generarArgumentos("@USUARIO", "@ROL"), idUsuario, idRol);
                    if (resultado)
                        {
                        MessageBox.Show("Rol asignado");
                        }
                 } else
                    {
                     MessageBox.Show("El usuario ya esta asignado al rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
           } else
                {
                MessageBox.Show("Seleccionar un usuario","Atención", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                }
        }

        public Boolean existeUsuarioEnRol(Int32 usuario, Int32 rol)
        {
            string query = "SELECT RANDOM.EXISTE_USUARIO_ROL ('" + usuario + "', '" + rol + "' ) AS id";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();
            if (respuesta == 0)
            {
                return true;
            } else
                {
                return false;
                }
        }

        private void AgregarRol_Load_1(object sender, EventArgs e)
        {
            cmbUsuario.ValueMember = "IdUsuario";
            cmbUsuario.DisplayMember = "Username";
            cmbUsuario.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_USUARIOS");
            this.txtNombre.Clear();
            this.txtIdRol.Clear();
            this.cmbUsuario.SelectedIndex = -1;

        }

        private void btnHabilitarRol_Click(object sender, EventArgs e)
        {
            string rolDesc = txtNombre.Text;

            if (!rolHabilitado(rolDesc))
                {
                    bool resultado = Conexion.executeProcedure("RANDOM.ACTIVAR_ROL", Conexion.generarArgumentos("@NOMBRE"), rolDesc);
                 if (resultado)
                    {
                    MessageBox.Show("Rol Habilitado");
                    }
                } else
                    {
                    MessageBox.Show("El rol ya esta habilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
            }
        
        public Boolean rolHabilitado(string rol)
        {
            string query = "SELECT RANDOM.ROL_HABILITADO ('" + rol + "') AS id";
            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();
            if (respuesta == 1)
            {
                return true;
            } else
                {
                return false;
                }
        }

        private void dgvFuncionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        }
    }

