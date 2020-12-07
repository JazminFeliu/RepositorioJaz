using System;

namespace ClaseParcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rec = new Rectangulo();
            rec.Lado1 = 15;
            rec.Lado2 = 12;

            Console.WriteLine($"{rec.Lado1} es el primer lado y {rec.Lado2} es el segundo lado del rectángulo.");
            Console.WriteLine($"El perimetro del rectangulo es" +
                $" {rec.RetornarPerimetro()} y su superficie {rec.RetornarSuperficie()}");

            Console.ReadKey();
        }
    }
}
