using System;

namespace CuentaBancaria
{
    public class CuentaBancaria
    {
        private string? _Titular {get;set;}
        private decimal _Saldo {get;set;}

        public CuentaBancaria(string Titular)
        {
            _Titular = Titular;
            _Saldo = 0;
        }

        public void Depositar(decimal depositar)
        {
            if(depositar < 1)
            {
                Console.WriteLine("Ingresa un depósito válido \n");
                return;
            }
            _Saldo += depositar;
        }

        public void Retirar(decimal retirar)
        {
            if(retirar < 1)
            {
                Console.WriteLine("Retire un monto válido");    
                return;
            }

            if(_Saldo < retirar)
            {
                Console.WriteLine("Dinero insuficiente \n");
                return;
            }
            _Saldo -= retirar;
        }

        public decimal ConsultarSaldo()
        {
            return _Saldo;
        }
    }
}