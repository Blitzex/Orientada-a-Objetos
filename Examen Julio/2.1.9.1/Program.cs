using System;

namespace _2._1._9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número del 1 al 5: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case '1': Console.WriteLine("Uno");
                    break;
                case '2': Console.WriteLine("Dos");
                    break;
                case '3': Console.WriteLine("Tres");
                    break;
                case '4': Console.WriteLine("Cuatro");
                    break;
                case '5':Console.WriteLine("Cinco");
                    break;
                default: Console.WriteLine("El número no está entre el 1 y el 5");
                    break;
            }
            Console.ReadLine();
        }
    }
}
