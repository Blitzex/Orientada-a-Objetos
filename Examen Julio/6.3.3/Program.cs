﻿using System;

namespace _6._3._3
{
    class PruebaLibro
    {
        public static void Main()
        {
            Libro l1 = new Libro();

            l1.SetAutor("Reki Kawahara");
            l1.SetTitulo("Accel World");
            l1.SetUbicacion("Sección Novelas Ligeras");

            Console.Write("El libro: {0} del autor {1}, se encuentra en la {2}", l1.GetTitulo(), l1.GetAutor(), l1.GetUbicacion());
            Console.ReadLine();
        }
    }
    class Libro
    {
        string autor, titulo, ubicacion;

        public string GetAutor()
        {
            return autor;
        }
        public void SetAutor(string nuevoAutor)
        {
            autor = nuevoAutor;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public void SetTitulo(string nuevoTitulo)
        {
            titulo = nuevoTitulo;
        }
        public string GetUbicacion()
        {
            return ubicacion;
        }
        public void SetUbicacion(string nuevaUbicacion)
        {
            ubicacion = nuevaUbicacion;
        }
    }
}