using System;

namespace _5._2._2
{
    class Program
    {
        static void DibujarCuadrado3x3()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            DibujarCuadrado3x3();
            Console.ReadLine();
        }
    }
}
