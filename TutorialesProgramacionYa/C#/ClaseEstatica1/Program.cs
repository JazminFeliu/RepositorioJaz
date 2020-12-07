using System;

namespace ClaseEstatica1
{
    static class Operaciones
    {
        public static int Sumar(int val1, int val2)
        {
            return  val1 + val2;
        }

        public static int Restar(int val1, int val2)
        {
            return val1 - val2;
        }

        public static int Multiplicar(int val1, int val2)
        {
            return val1 * val2;
        }

        public static int Dividir(int val1, int val2)
        {
            return val1 / val2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("18+9 es: " + Operaciones.Sumar(18, 9));
            Console.WriteLine("18-9 es: " + Operaciones.Restar(18, 9));
            Console.WriteLine("18*9 es: " + Operaciones.Multiplicar(18, 9));
            Console.WriteLine("18/9 es: " + Operaciones.Dividir(18, 9));

            Console.ReadKey();
        }
    }
}
