using System;

namespace Propiedades1
{
    class Cuadrado
    {
        public int Lado { get; set; }

        public int RetornarSuperficie()
        {
            return Lado * Lado;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var cuadrado1 = new Cuadrado();

            Console.Write("Ingrese el valor del lado del cuadrado: ");

            cuadrado1.Lado = int.Parse(Console.ReadLine());

            Console.WriteLine("La superficie de cuadrado es: " + cuadrado1.RetornarSuperficie());

            Console.ReadKey();
        }
    }
}
;
