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
        //algoritmo de SHA256
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
                if (!Regex.IsMatch(s, @"^[a-zA-ZáéíóúÑñ]+$"))
                    return false;
            }
            return true;
        }

        //obtener la fecha del archivo config
        internal static DateTime ObtenerFecha()
        {
            string fecha;
            fecha = System.Configuration.ConfigurationManager.AppSettings["fecha"];
            DateTime fechaHoy = Convert.ToDateTime(fecha);
            return fechaHoy;
        }

        //obtener el número de día del string del día
        internal static Int32 numeroDiaSemana(string dia)
        {
            if (dia == "domingo") { return 1; }
            if (dia == "lunes") { return 2; }
            if (dia == "martes") { return 3; }
            if (dia == "miércoles") { return 4; }
            if (dia == "jueves") { return 5; }
            if (dia == "viernes") { return 6; }
            else { return 7; }
        }

    }
}
