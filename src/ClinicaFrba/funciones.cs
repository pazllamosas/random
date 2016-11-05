using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClinicaFrba
{
    class funciones
    {
        internal static string SHA256Encripta(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());
            return output.ToString();
        }

        //textBox solo permita numeros
        internal static bool permiteNumeros(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        //textBox solo permita letras
        internal static bool permiteLetras(string s)
        {

            foreach (char c in s)
            {
                if (!Regex.IsMatch(s, @"^[a-zA-Záéíóú]+$"))
                    return false;
            }
            return true;
        }
        internal static DateTime ObtenerFecha()
        {
            string fecha;
            fecha = System.Configuration.ConfigurationManager.AppSettings["fecha"];
            DateTime fechaHoy = Convert.ToDateTime(fecha);
            return fechaHoy;
        }

    }
}
