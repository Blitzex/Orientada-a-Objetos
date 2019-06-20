using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3._7
{
    class PruebaCoche
    {
        public static void Main(string[] args)
        {
            Coche coche = new Coche();

            Console.Write("Introduce la marca del coche: ");
            string marca = Console.ReadLine();
            Console.Write("Introduce el modelo del coche: ");
            string modelo = Console.ReadLine();
            Console.Write("Introduce la cilindrada del coche: ");
            int cilindrada = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce la potencia del coche: ");
            float potencia = Convert.ToSingle(Console.ReadLine());

            coche.SetMarca(marca);
            coche.SetModelo(modelo);
            coche.SetCilindrada(cilindrada);
            coche.SetPotencia(potencia);

            Console.Write("Marca: {0}; Modelo: {1}; Cilindrada: {2}; Potencia: {3}", coche.GetMarca(), coche.GetModelo(), coche.GetCilindrada(), coche.GetPotencia());
            Console.ReadLine();
        }
    }

    class Coche
    {
        private string marca;
        private string modelo;
        private int cilindrada;
        private float potencia;

        public string GetMarca()
        {
            return marca;
        }
        public void SetMarca(string nuevaMarca)
        {
            marca = nuevaMarca;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public void SetModelo(string nuevoModelo)
        {
            modelo = nuevoModelo;
        }
        public int GetCilindrada()
        {
            return cilindrada;
        }
        public void SetCilindrada(int nuevaCilindrada)
        {
            cilindrada = nuevaCilindrada;
        }
        public float GetPotencia()
        {
            return potencia;
        }
        public void SetPotencia(float nuevaPotencia)
        {
            potencia = nuevaPotencia;
        }
    }
}
