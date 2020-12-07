using System;

namespace ListaOrdenada1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lo = new ListaOrdenada();
            lo.Insertar(10);
            lo.Insertar(5);
            lo.Insertar(7);
            lo.Insertar(50);

            lo.Imprimir();

            Console.ReadKey();
        }
    }
}
