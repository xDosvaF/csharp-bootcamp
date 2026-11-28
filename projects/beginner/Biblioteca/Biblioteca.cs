using System;

namespace Biblioteca
{
    public class Biblioteca
    {
        public static List<Libro> ListaLibro {get;set;} =  new List<Libro>();

        public static void AddLibro(Libro libro)
        {
            ListaLibro.Add(libro);
            Console.WriteLine("\nSe ha añadido correctametne!\n");
        }

        public static void PrestarLibro(int index)
        {
            if(index > (ListaLibro.Count - 1))
            {
                Console.WriteLine("\nÍndice no válido\n");
                return;
            }

            ListaLibro[index].Prestar();
        }

        public static void DevolverLibro(int index)
        {
            if(index > (ListaLibro.Count - 1))
            {
                Console.WriteLine("\nÍndice no válido\n");
                return;
            }

            ListaLibro[index].Devolver();
        }

        public static void ListarLibro()
        {
            foreach(var libro in ListaLibro)
            {
                libro.MostrarInformacion();
            }
        }

    }
}