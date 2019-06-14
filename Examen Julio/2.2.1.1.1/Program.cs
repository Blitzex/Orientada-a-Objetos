using System;

namespace _2._2._1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce la contraseña: ");
            int contra = Convert.ToInt32(Console.ReadLine());

            while(contra != 1111)
            {
                Console.Write("Contraseña incorrecta, vuelve a intentarlo: ");
                contra = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Contraseña Correcta");

            Console.ReadLine();
        }
    }
}
