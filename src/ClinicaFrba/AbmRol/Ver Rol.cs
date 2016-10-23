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
    public partial class verRol : Form
    {
        public verRol()
        {
            InitializeComponent();
        }


        public void CargarRoles()
        {
            dgvRol.Rows.Clear();
            string query = "SELECT IdRol, Descripcion FROM RANDOM.ROL order by IdRol";
            SqlDataReader reader = Conexion.ejecutarQuery(query);

            while (reader.Read())
            {
                dgvRol.Rows.Add(reader["IdRol"], reader["Descripcion"]);
            }
            reader.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.AgRol.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Int32 selectedRowCount = dgvRol.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvRol.SelectedRows[0];
                string rol = d.Cells[0].Value.ToString();
                string rolDesc = d.Cells[1].Value.ToString();
               // FormProvider.AgRol.Show(); 
                FormProvider.AgRol.EditarRol(rol, rolDesc);
                FormProvider.AgRol.Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("No podés editar si no elegís un rol y sólo un rol", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProvider.MainMenu.Show();
        }

        private void btnBajaRol_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgvRol.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount < 2)
            {
                DataGridViewRow d = dgvRol.SelectedRows[0];
                string rol = d.Cells[0].Value.ToString();
                string rolDesc = d.Cells[1].Value.ToString();
                if (rolHabilitado(rolDesc))
                {
                    bool resultado = Conexion.executeProcedure("RANDOM.BAJA_ROL", Conexion.generarArgumentos("@ROL"), rol);
                    if (resultado)
                    {
                        MessageBox.Show("Rol Inhabilitado");
                    }
                }
                else
                {
                    MessageBox.Show("El rol ya esta inhabilitado", "Advertencia", MessageBoxButtons.OK , MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No podés inhabilitar si no elegís un rol y sólo un rol");
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
            }
            else
            {
                return false;
            }
        }

        private void dgvRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
