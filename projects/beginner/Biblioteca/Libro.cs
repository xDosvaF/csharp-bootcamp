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
                Console.WriteLine("Prestado con éxito!");
                return;
            }
            Console.WriteLine("No se puede prestar");
        }

        public void Devolver()
        {
            if(_State == false)
            {
                _State = true;
                Console.WriteLine("Devuelto con éxito!");
                return;
            }
            Console.WriteLine("No se puede devolver porque no seha prestado");
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Título: "+_Titulo);
            Console.WriteLine("Autor: "+_Autor);
            Console.WriteLine("Publicacion: "+_Publication);
            Console.WriteLine("Estado: "+_State ? "Activo" : "Prestado");
        }

    }
}