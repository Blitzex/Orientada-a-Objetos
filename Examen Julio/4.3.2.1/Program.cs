using System;

namespace _4._4._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un nombre: ");
            string nombre = Console.ReadLine();

            for(int i = 1; i <= nombre.Length; i++)
            {
                string subcadena = nombre.Substring(0, i);

                Console.WriteLine(subcadena);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

