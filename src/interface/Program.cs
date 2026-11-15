using System;

namespace Interfaces
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Whis method do you choose?");
            Console.WriteLine("1. Debit card");
            Console.WriteLine("2. Pay Pal");

            Console.Write("Opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    var pago1 = new TarjetaDeCredito();
                    Comprar(pago1);
                    break;
                
                case 2:
                    var pago2 = new PayPal();
                    Comprar(pago2);
                    break;
            }
        }

        public static void Comprar(IMetodoDePago Metodo)
        {
            Console.Write("Amount to be paid: ");
            decimal Monto = Convert.ToDecimal(Console.ReadLine());
            Metodo.ProcesarPago(Monto);
        }
    }

    interface IMetodoDePago
    {
        public void ProcesarPago(decimal _Monto);
    }

    public class TarjetaDeCredito : IMetodoDePago
    {
        private decimal Monto {get;set;}

        public TarjetaDeCredito()
        {
            Monto = 0;
        }

        public void ProcesarPago(decimal _Monto)
        {
            Monto = _Monto;
            Console.WriteLine($"¡Pago exitoso de: ${Monto} con tarjeta de crédito!");
        }
    }

    public class PayPal : IMetodoDePago
    {
        private decimal Monto {get;set;}

        public PayPal()
        {
            Monto = 0;
        }

        public void ProcesarPago(decimal _Monto)
        {
            Monto = _Monto;
            Console.WriteLine($"¡Pago exitoso de: ${Monto} con Pay Pal!");
        }
    }
}