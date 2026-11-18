using System;

namespace Students
{
    public class Students
    {
        public string Nombre {get;set;}
        public int Carnet {get;set;}
        private decimal _Nota {get;set;}

        public Students(string _Nombre, int _Carnet)
        {
            Nombre = _Nombre;
            Carnet = _Carnet;
        }

        public int SetNota(decimal newNota)
        {
            if(newNota < 0 || newNota > 100)
            {
                Console.WriteLine("Nota inválida");
                return 0;
            }
            _Nota = newNota;
            Console.WriteLine("Nota ingresada correctamente");
            return 1;
        }

        public decimal GetNota()
        {
            return this._Nota;
        } 
    }
}