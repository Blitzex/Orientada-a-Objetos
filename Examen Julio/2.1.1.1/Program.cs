﻿using System;

namespace _2._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("El {0} es par", numero);
            }
            else
            {
                Console.WriteLine("El {0} es impar", numero);
            }
            Console.ReadLine();
        }
    }
}