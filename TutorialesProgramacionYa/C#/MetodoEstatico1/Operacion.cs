using System;

namespace MetodoEstatico1
{
    class Operacion
    {
        public static int Sumar(int val1, int val2)
        {
            int s = val1 + val2;
            return s;
        }

        public static int Restar (int val1, int val2)
        {
            int r = val1 - val2;
            return r;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("La suma de 2+8 es: " + Operacion.Sumar(2, 8));
            Console.WriteLine("La resta de 89-7 es:" + Operacion.Restar(89, 7));

            Console.ReadKey();
        }
    }
}
