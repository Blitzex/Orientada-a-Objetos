using System;

namespace _4._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 10];
            for(int i=0; i < 2; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Console.Write("Introduce el {0}º número del {1}º array: ", j + 1, i + 1);
                    numeros[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int mayor1 = 0;
            int mayor2 = 0;
            int mayortotal = 0;

            for(int i = 0; i < 10; i++)
            {
                if (numeros[0, i] > mayor1)
                {
                    mayor1 = numeros[0, i];
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (numeros[1, i] > mayor2)
                {
                    mayor2 = numeros[1, i];
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (numeros[i,j] > mayortotal)
                    {
                        mayortotal = numeros[i,j];
                    }
                }
            }
            Console.WriteLine("El mayor del primer array es {0}, el del segundo {1} y el mayor de ambos es {2}", mayor1, mayor2, mayortotal);
            Console.ReadLine();
        }
    }
}
