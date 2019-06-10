using System;

namespace _2._1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce otro número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                Console.WriteLine("El {0} es mayor que el {1}", num2, num1);
            }
            else
            {
                Console.WriteLine("El {0} es mayor que el {1}", num1, num2);
            }
            Console.ReadLine();
        }
    }
}
