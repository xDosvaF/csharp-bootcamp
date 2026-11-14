using System;

namespace POO
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Pepe = new Perro("Perro",12.5m, "Rojo");
            var massage = Pepe.getInfo();

            Console.WriteLine(massage);
        }
    }

    class Perro : Animal
    {
        public string ColorPelo {get;set;}

        public Perro(string _Nombre, decimal _Peso, string _ColorPelo) : base(_Nombre, _Peso)
        {
            ColorPelo = _ColorPelo;
        }

        public override string getInfo()
        {
             return "Soy un "+Nombre+" y peso "+Peso+" kg"+ " y tengo el pelo de color "+ColorPelo;
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

        public virtual string getInfo()
        {
            return "Soy un "+Nombre+" y peso "+Peso+" kg";
        }
    }
}