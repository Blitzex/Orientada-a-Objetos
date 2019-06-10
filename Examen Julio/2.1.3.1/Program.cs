using System;

namespace _2._1._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            if (num1 != 0)
            {
                Console.Write("Introduce otro número: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0}x{1} = {2}", num1, num2, num1 * num2);
            }
            else
            {
                Console.WriteLine("El producto de 0 por cualquier número es 0");
            }
            Console.ReadLine();
        }
    }
}
