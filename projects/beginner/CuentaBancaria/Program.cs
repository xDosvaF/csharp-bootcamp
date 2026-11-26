using System;

namespace CuentaBancaria
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Titular: ");
            string? titular = Console.ReadLine();
            var newCuenta = new CuentaBancaria(titular);
            Console.WriteLine("");
            while (true)
            {
                try
                {
                    Console.WriteLine("1.- Depositar");
                    Console.WriteLine("2.- Retirar");
                    Console.WriteLine("3.- Saldo Actual");
                    Console.WriteLine("4.- Salir\n");

                    Console.Write("Opcion: ");
                    int Opcion = Convert.ToInt32(Console.ReadLine());

                    switch (Opcion)
                    {
                        case 1:
                            Console.Write("Depósito: ");
                            decimal depositar = Convert.ToDecimal(Console.ReadLine());
                            newCuenta.Depositar(depositar);
                            break;

                        case 2:
                            Console.Write("Retiro: ");
                            decimal retirar = Convert.ToDecimal(Console.ReadLine());
                            newCuenta.Retirar(retirar);
                            break;

                        case 3:
                            Console.WriteLine("Saldo actual: " + newCuenta.ConsultarSaldo() + "\n");
                            break;

                        case 4:
                            return;

                        default:
                            Console.WriteLine("ELige una opción válida");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }

            }
        }
    }
}