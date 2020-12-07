using System;

namespace Delegados1
{
    delegate int Operar(int x1, int x2);
       
    class Program
    {
        public int Sumar(int x, int y)
        {
            return x + y;
        }

        public int Restar(int x, int y)
        {
            return x - y;
        }
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine("Suma y resta de dos valores llamando directamente los métodos: ");
            Console.WriteLine(p.Sumar(15, 5));
            Console.WriteLine(p.Restar(25, 6));

            Operar delegado = p.Sumar;

            Console.WriteLine("Suma y resta de dos valores llamando los métodos a través de delegados");
            Console.WriteLine(delegado(45, 8));

            delegado = p.Restar;
            Console.WriteLine(delegado(78, 9));

            Console.ReadKey(); 
        }
    }
}
