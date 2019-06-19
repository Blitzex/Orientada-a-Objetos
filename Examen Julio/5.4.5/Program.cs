using System;

namespace _5._4._5
{
    class Program
    {
        static string UltimaLetra(string x)
        {
            return x.Substring(x.Length - 1, 1);
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Introduce una palabra: ");
                string palabra = Console.ReadLine();
                string resultado = UltimaLetra(palabra);
                Console.Write("La última letra es: {0}", resultado); 
            }
            catch (Exception errorEncontrado)
            {
                Console.WriteLine("Se ha producido un error: {0}", errorEncontrado.Message);
            }
            Console.ReadLine();
        }
    }
}
