using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba
{
    class conexion
    {

        public static SqlConnection conexionMaestra;

        public static SqlDataReader ejecutarQuery(string query)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = conexionMaestra;
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        public static int ejecutarNonQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, conexionMaestra);
            int rowCount = command.ExecuteNonQuery();
            return rowCount;
        }

        internal static void establecerConexionBD()
        {


            string datosConexion = "Data Source=localHost\\SQLSERVER2012;Initial Catalog= ;Persist Security Info=True;User ID= gd;Password= gd2016; MultipleActiveResultSets=True";
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = datosConexion;
            SqlCommand command;

            conexion.Open();
            conexionMaestra = conexion;
            command = new SqlCommand("select 1 from gd_esquema.Maestra", conexion);
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();


        }

        internal static SqlConnection getSqlInstanceConnection()
        {
            return conexionMaestra;
        }


        public SqlConnection conectar()
        {
            try
            {
                conexionMaestra.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return conexionMaestra;

        }

        private static bool _validateArgumentsAndParameters(List<string> args, params object[] values)
        {
            if (args != null && values != null)
            {
                if (args.Count != values.Length)
                {
                    throw new ApplicationException();
                }
                return true;
            }
            return false;
        }

        private static void _loadSqlCommand(List<string> args, SqlCommand cm, params object[] values)
        {
            for (int i = 0; i < args.Count; i++)
            {
                cm.Parameters.AddWithValue(args[i], values[i]);
            }
        }

        public static bool executeProcedure(string procedure, List<string> args, params object[] values)
        {
            try
            {
                SqlDataReader dr;
                SqlConnection cn = getSqlInstanceConnection();
                SqlCommand cm = new SqlCommand(procedure, cn);
                cm.CommandTimeout = 2000;
                cm.CommandType = CommandType.StoredProcedure;
                if (_validateArgumentsAndParameters(args, values))
                {
                    _loadSqlCommand(args, cm, values);
                }
                dr = cm.ExecuteReader();
                dr.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }


}

