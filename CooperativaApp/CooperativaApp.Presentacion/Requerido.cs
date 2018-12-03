using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CooperativaApp.Presentacion
{
    public abstract class Requerido
    {
        public static bool EsEnteroValido(string texto, int cantidadEsperada = 0)
        {
            bool resultado;
            Int64 numero;
            if (cantidadEsperada == 0)
            {

                resultado = (Int64.TryParse(texto, out numero));
                if (!resultado)
                {
                    Console.WriteLine("No es entero valido:" + texto);
                }
            }
            else
            {
                resultado = Int64.TryParse(texto, out numero) && EsLongitudValida(texto, cantidadEsperada);
                if (!resultado)
                {
                    Console.WriteLine("No es entero valido:" + texto);
                }
            }
            return resultado;
        }

        public static bool EsEnteroValido(string texto, int [] LongitudesValidas)
        {
            for (int i = 0; i < LongitudesValidas.Length; i++)
            {
                if (Requerido.EsEnteroValido(texto, LongitudesValidas[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool EsDecimal(string NumeroDecimal)
        {
            decimal price;
            bool EsDecimal = decimal.TryParse(NumeroDecimal, out price);
            if (!EsDecimal) { Console.WriteLine("No es Decimal Valido:["+NumeroDecimal+"]"); }
            return EsDecimal;

        }

        public static bool EsLongitudValida(string texto, int cantidadEsperada)
        {
            int cantidadReal = texto.Length;
            return cantidadEsperada == cantidadReal;
        }

        public static bool EsAlfabeticoValido(string texto)
        {
            bool permitido = false;
            if (texto.Contains(" "))
            {
                string[] campos = texto.Split(' ');
                for (int i = 0; i < campos.Length; i++)
                {
                    if (!Regex.IsMatch(campos[i], @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Alfabetico Campo No valido : " + campos[i]);
                        return false;
                    }
                }
                return true;
            }
            else
            {
                permitido = Regex.IsMatch(texto, @"^[a-zA-Z]+$");
                if (!permitido)
                {
                    Console.WriteLine("Alfabetico No valido : " + texto);
                }
            }
            return permitido;
        }

        public static bool MostrarMensaje(bool Estado, string Mensaje)
        {
            if (!Estado)
            {
                MessageBox.Show(Mensaje);
            }
            return Estado;
        }

    }
}
