using System;

namespace _5._9._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 5;
            Random aleatorio = new Random();
            int numeroAzar = aleatorio.Next(1, 101);
            do
            {
                Console.Write("Introduce un número entre el 1 y el 100: ");
                int numeroUsuario = Convert.ToInt32(Console.ReadLine());
                if (contador == 0)
                {
                    Console.Write("Lo siento, has fallado. El número es: {0}", numeroAzar);
                }
                else
                {
                    if (numeroUsuario < numeroAzar)
                    {
                        Console.Write("El número que tienes que adivinar es mayor. Te quedan {0} oportunidades.", contador);
                    }
                    else
                    {
                        if (numeroUsuario > numeroAzar)
                        {
                            Console.Write("El número que tienes que adivinar es menor. Te quedan {0} oportunidades.", contador);
                        }
                        else
                        {
                            Console.Write("Enhorabuena, has acertado.");
                        }
                    }
                }
                contador--;
            }
            while (contador >= 0);
            Console.ReadLine();
        }
    }
}
