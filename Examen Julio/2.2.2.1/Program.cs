using System;

namespace _2._2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;
            do
            {
                Console.Write("Introduce un número: ");
                numero = Convert.ToInt32(Console.ReadLine());
      
                suma += numero;
                Console.WriteLine(suma);
            }
            while (numero > 0);
            Console.WriteLine("Operación terminada");
            Console.ReadLine();
        }
    }
}
