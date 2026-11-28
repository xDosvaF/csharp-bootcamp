using System;

namespace Biblioteca
{
    public class Program
    {
        public static  int index {get;set;}
        public static void Main(string[] args)
        {
            CrearLibro();
            while (true)
            {
                Console.WriteLine("1.- Crear");
                Console.WriteLine("2.- Prestar libro");
                Console.WriteLine("3.- Devolver libro");
                Console.WriteLine("4.- Lista de libros");
                Console.WriteLine("5.- Salir\n");

                Console.Write("Opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        CrearLibro();
                        break;
                    case 2:
                        Console.Write("\nIndice: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Biblioteca.PrestarLibro(index);
                        break;
                    case 3:
                        Console.Write("\nIndice: ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Biblioteca.DevolverLibro(index);
                        break;
                    case 4:
                        Biblioteca.ListarLibro();
                        break;
                    case 5:
                        Console.WriteLine("\nSesión finalizada");
                        return;
                    default:
                        Console.WriteLine("\nEscribe una opción válida\n");
                        break;
                }
            }
        }

        public static void CrearLibro()
        {
            Console.Write("Titulo: ");
            string? titulo = Console.ReadLine();
            Console.Write("Autor: ");
            string? autor = Console.ReadLine();
            Console.Write("Fecha (MM/DD/AA): ");
            string? entrada = Console.ReadLine();
            DateTime fecha;
            while (!DateTime.TryParse(entrada, out fecha))
            {
                Console.Write("Error! Intenta de nuevo (MM/DD/AA): ");
                entrada = Console.ReadLine();
            }

            var newLibro = new Libro(titulo, autor, fecha);
            Biblioteca.AddLibro(newLibro);
        }
    }
}