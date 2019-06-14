using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.Write("Introduce una frase: ");
            string frase = Console.ReadLine();
            foreach (char a in frase)
            {
                if (a == 'a')
                {
                    suma += 1;
                }
            }
            Console.WriteLine("Hay {0} aes", suma);
            Console.ReadLine();
        }
    }
}
