using System;

namespace _4._3._1._1
{
    class Program
    {
        struct cancion
        {
            public string artista;
            public string titulo;
            public int duracion;
            public int tamanofichero;
        }
        static void Main(string[] args)
        {
            cancion datos;
            Console.WriteLine("Introduce la información de la canción:");
            Console.Write("Artista: ");
            datos.artista = Console.ReadLine();
            Console.Write("Título: ");
            datos.titulo = Console.ReadLine();
            Console.Write("Duración(segundos): ");
            datos.duracion = Convert.ToInt32(Console.ReadLine());
            Console.Write("Tamaño del fichero(kb): ");
            datos.tamanofichero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Datos de la canción: {0} by {1}, {2}s. {3}kb.", datos.titulo, datos.artista, datos.duracion, datos.tamanofichero);
            Console.ReadLine();
        }
    }
}
