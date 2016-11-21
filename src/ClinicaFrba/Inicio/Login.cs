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

namespace ClinicaFrba.Inicio
{
    public partial class Login : Form
    {

        private string password = "";

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Conexion.establecerConexionBD();
            cmbRol.ValueMember = "IdRol";
            cmbRol.DisplayMember = "Descripcion";
            cmbRol.DataSource = Conexion.cargarTablaConsulta("RANDOM.GET_ROLES");
            this.cmbRol.SelectedIndex = -1;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            string contrasenia = funciones.SHA256Encripta(this.password);
            if (cmbRol.SelectedIndex != -1)
            {
               //verifica que sea un usuario válido
                if (usuarioValido(usuario))
                {
                    //verifica que sea la contraseña correcta
                    if (passwordValida(usuario, password))
                        //verifica que sea el rol adecuado para el usuario
                        if (rolValido(usuario, cmbRol.Text))
                        {
                            {
                                loginCorrecto(usuario);

                                this.Hide();
                                FormProvider.MainMenu.Show();
                                FormProvider.MainMenu.habilitarFuncionalidadesPorRol(cmbRol.Text);
                            }
                        }
                }
            }
            else
            {
                MessageBox.Show("debe seleccionar una opcion del combo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean rolValido(string usuario, string rol)
        {
            string query = "SELECT RANDOM.ROL_CORRECTO ('" + usuario + "' , '" + rol + "') AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta >= 1)
            {

                return true;
            }
            else
            {
                MessageBox.Show("El rol es invalido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        public Boolean usuarioValido(string usuario)
        {
            string query = "SELECT RANDOM.EXISTE_USUARIO ('" + usuario + "' ) AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta >= 1)
            {

                return true;
            }
            else
            {
                MessageBox.Show("El usuario es invalido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        
        public Boolean passwordValida(string usuario, string password)
        {

            string contrasenia = funciones.SHA256Encripta(password);
            string query = "SELECT RANDOM.PASSWORD_CORRECTA ('" + usuario + "', '" + contrasenia + "') AS id";

            SqlDataReader reader = Conexion.ejecutarQuery(query);
            reader.Read();
            int respuesta = int.Parse(reader["id"].ToString());
            reader.Close();

            if (respuesta >= 1)
            {

                return true;
            }
            else
            {
                MessageBox.Show("La contraseña es invalida", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                loginIncorrecto(usuario);
                txtPassword.Clear();

                return false;
            }
        }

        private static void loginCorrecto(string usuario)
        {
            intentos(usuario, 1);
        }

        private static void loginIncorrecto(string usuario)
        {
            intentos(usuario, 0);
        }

        //Método para contabilizar los intentos del usuario al login
        private static void intentos(string usuario, int acceso)
        {
            Conexion.executeProcedure("RANDOM.INTENTO_LOGIN", Conexion.generarArgumentos("@usuario", "@acceso"), usuario, acceso);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsuario.Text))
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsuario.Text))
            {
                btnIngresar.Enabled = true;
            }
            else
            {
                btnIngresar.Enabled = false;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

        }
        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

