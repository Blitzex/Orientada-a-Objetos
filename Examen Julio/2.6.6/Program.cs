using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el ancho: ");
            int ancho = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el alto: ");
            int alto = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < alto; i++)
            {
                Console.Write("*");
                for (int j = 0; j < ancho - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
