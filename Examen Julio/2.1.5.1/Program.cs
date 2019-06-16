using System;

namespace _2._1._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Introduce un número: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if ((num % 2 == 0) || (num % 3 == 0))
                {
                    Console.WriteLine("El número es múltiplo de 2 o 3");
                }
                else
                {
                    Console.WriteLine("El número no es múltiplo de 2 o 3");
                }
            }
            catch (Exception errorEncontrado)
            {
                Console.WriteLine("Se ha producido un error: {0}", errorEncontrado.Message);
            }
            Console.ReadLine();
        }
    }
}
