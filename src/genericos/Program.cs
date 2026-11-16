using System;

namespace Genericos
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Lista de números enteros
            var numbers = new MyList<int>(6);
            numbers.Add(5);
            numbers.Add(11);
            numbers.Add(2);
            numbers.Add(67);
            numbers.Add(9);
            numbers.Add(34);
            numbers.Add(17); // No se agregará a la lista

            // Lista de objetos Persona
            var persona = new MyList<Persona>(3);
            persona.Add(new Persona("Esteban",67.67m));
            persona.Add(new Persona("Anyela",50.42m));
            persona.Add(new Persona("Kevin",84.97m));
            persona.Add(new Persona("Esteban",67.67m));
            persona.Add(new Persona("Esteban2",76.76m));

            //Imprimir en consola
            Console.WriteLine(numbers.GetItem());
            Console.WriteLine(persona.GetItem());
        }
    }

    public class MyList<T>
    {
        private List<T> _list {get;set;}
        private int _limit {get;set;}

        public MyList(int limit)
        {
            _limit = limit;
            _list = new List<T>();
        }

        public void Add(T obj)
        {
            if(_list.Count < _limit)
            {
                _list.Add(obj); 
            }
            else
            {
                Console.WriteLine("Lista llena!");
            }  
        } 
        
        public string GetItem()
        {
            string content = "";

            foreach(var item in _list)
            {
                content += item+" | ";
            }

            return content; 
        }
    }

    public class Persona 
    {
        private string _nombre {get;set;}
        private decimal _peso {get;set;}

        public Persona(string nombre, decimal peso)
        {
            _nombre = nombre;
            _peso = peso;
        }

        public override string ToString()
        {
            return $"soy {_nombre} y peso {_peso} kg";
        }
    }
}