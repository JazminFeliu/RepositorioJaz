using System;

namespace Propiedades2
{
    class Triangulo
    {
        public int Lado1 { get; set; } = 5;
        public int Lado2 { get; set; } = 5;
        public int Lado3 { get; set; } = 5;

        public Triangulo(string titulo)
        {
            Console.Write(titulo);
            Lado1 = 1;
            Lado2 = 1;
            Lado3 = 1;
        }

        public int RetornarPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var tri1 = new Triangulo ("Perímetro triangulo 1: "){ Lado1 = 10, Lado2 = 20, Lado3 = 30 };
            
            Console.WriteLine(tri1.RetornarPerimetro());

            var tri2 = new Triangulo ("Perímetro triangulo 2: "){ Lado3 = 30 };

            Console.WriteLine(tri2.RetornarPerimetro());

            Console.ReadKey();
        }
    }
}
