using System;

namespace _6._2._1
{
    class PruebaPersona
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona();

            persona1.SetNombre("Javier");
            persona2.SetNombre("Miguel");

            persona1.Saludar();
            persona2.Saludar();

            Console.ReadLine();
        }
    }
    class Persona
    {
        string nombre;
        public void SetNombre(string name)
        {
            nombre = name;
        }
        public void Saludar()
        {
            Console.WriteLine("Hola, soy {0}", nombre);
        }
    }
}
