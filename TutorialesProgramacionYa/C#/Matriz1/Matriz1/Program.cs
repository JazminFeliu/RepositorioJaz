using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            var matriz = new Matriz();

            matriz.CargarMatriz();
            matriz.Imprimir();

            Console.ReadKey();
        }
    }
}
