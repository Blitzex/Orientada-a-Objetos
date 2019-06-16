using System;

namespace _4._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int i;
            for(i = 0; i < 4; i++)
            {
                Console.Write("Introduce un número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            int suma = numeros[0] + numeros[1] + numeros[2] + numeros[3];
            int media = suma / 4;
            Console.WriteLine(media);
            Console.ReadLine();
        }
    }
}
