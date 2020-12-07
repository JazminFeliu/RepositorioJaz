using System;

namespace Interpolacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int suma = valor1 + valor2;

            Console.WriteLine($"La suma de {valor1} y {valor2} da como resultado {suma}.");

            Console.ReadKey();


        }
    }
}
