using System;

namespace POO
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Perro = new Animal("Perro",12.5m);
            var massage = Perro.getInfo();

            Console.WriteLine(massage);
        }
    }

    class Animal
    {
        public string Nombre {get;set;}
        public decimal Peso {get;set;}

        public Animal(string _Nombre, decimal _Peso)
        {
            Nombre = _Nombre;
            Peso = _Peso;
        }

        public string getInfo()
        {
            return "Soy un "+Nombre+" y peso "+Peso+" kg";
        }
    }
}