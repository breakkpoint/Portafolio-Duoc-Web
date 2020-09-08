using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibliotecas.Negocio;

namespace PruebasConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario us = new Usuario();
            Peaje pe = new Peaje();
            Viaje ve = new Viaje();

            DateTime fe = DateTime.Now;

            string texto = "acw";

            if (ValidarString(texto))
            {
                Console.WriteLine("yes");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No");
                Console.ReadKey();
            }

          





        }

        public static Boolean ValidarString(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                string var = texto[i].ToString();
                switch (texto[i].ToString())
                {
                    case "1":
                        return false;
                        break;
                    case "2":
                        return false;
                        break;
                    case "3":
                        return false;
                        break;
                    case "4":
                        return false;
                        break;
                    case "5":
                        return false;
                        break;
                    case "6":
                        return false;
                        break;
                    case "7":
                        return false;
                        break;
                    case "8":
                        return false;
                        break;
                    case "9":
                        return false;
                        break;
                    case "0":
                        return false;


                        break;
                }
            }
            return true;
        }
    }
}
