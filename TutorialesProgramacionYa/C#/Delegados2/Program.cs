using System;

namespace Delegados2
{
    delegate int Operar(int x1, int x2);

    class Program
    {
        public int Sumar (int val1, int val2)
        {
            return val1 + val2;
        }

        public int Restar (int val1, int val2)
        {
            return val1 - val2;
        }

        public void Operacion(Operar d, int x, int y)
        {
            Console.WriteLine(d(7, 5));
        }
        static void Main(string[] args)
        {
            var p = new Program();

            Console.WriteLine("Suma y resta de 7 y 5");
            p.Operacion(p.Sumar, 7,5);
            p.Operacion(p.Restar, 7, 5);

            Console.ReadKey();
           
        }
    }
}
