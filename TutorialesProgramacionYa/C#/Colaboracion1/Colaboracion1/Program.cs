using System;

namespace Colaboracion1
{
    class Program
    {
        static void Main(string[] args)
        {
            var banco = new Banco();

            banco.Operar();
            banco.ImprimirSaldosPorCuenta();
            banco.CalcularDepositosTotales();

            Console.ReadKey();
        }
    }
}
