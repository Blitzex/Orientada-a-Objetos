using System;

namespace _5._10._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce una palabra: ");
            string palabra = Console.ReadLine();

            Console.Write("La palabra {0} al revés es {1}", palabra, Reves(palabra));
            Console.ReadLine();
        }

        static string Reves(string palabra2)
        {
            string subcadena;

            if (palabra2.Length == 1)
            {
                return palabra2;
            }
            else
            {
                subcadena = palabra2.Substring(palabra2.Length - 1, 1);
            }
            return subcadena + Reves(palabra2.Remove(palabra2.Length - 1, 1));
        }
    }
}
