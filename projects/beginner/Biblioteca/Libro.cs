using System;

namespace Biblioteca
{
    public class Libro
    {
        private string? _Titulo {get;set;}
        private string? _Autor {get;set;}
        private DateTime _Publication {get;set;} = new DateTime();
        private bool _State {get;set;}

        public Libro(string Titulo, string Autor, DateTime Publication)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Publication = Publication;
            _State = true;
        }

        public void Prestar()
        {
            if(_State == true)
            {
                _State = false;
                Console.WriteLine("\nPrestado con éxito!\n");
                return;
            }
            Console.WriteLine("\nNo se puede prestar\n");
        }

        public void Devolver()
        {
            if(_State == false)
            {
                _State = true;
                Console.WriteLine("\nDevuelto con éxito!\n");
                return;
            }
            Console.WriteLine("\nNo se puede devolver porque no seha prestado\n");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("\nTítulo: "+_Titulo);
            Console.WriteLine("Autor: "+_Autor);
            Console.WriteLine("Publicacion: "+_Publication);
            Console.WriteLine("Estado: "+(_State ? "Activo" : "Prestado")+"\n");
        }

    }
}