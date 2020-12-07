using System;

namespace Herencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Suma();
            var r = new Resta();

            Console.Write("Ingrese el primer valor: ");
            string linea = Console.ReadLine();
            s.Valor1 = int.Parse(linea);

            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            s.Valor2 = int.Parse(linea);

            s.Operar();

            Console.WriteLine("La suma de " + s.Valor1 + " y " + s.Valor2 + " es " + s.Resultado);

            Console.Write("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            r.Valor1 = int.Parse(linea);

            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            r.Valor2 = int.Parse(linea);

            r.Operar();

            Console.WriteLine("La resta de " + r.Valor1 + " y " + r.Valor2 + " es " + r.Resultado);

            Console.ReadKey();
        }
    }
}
