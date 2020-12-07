using System;

namespace Interpolacion2
{
    class Program
    {
        public static int Mayor(int val1, int val2)
        {
            if(val1 > val2)
            {
                return val1;
            }
            else
            {
                return val2;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer valor:");
            int v1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor:");
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El mayor entre {v1} y {v2} es {Mayor(v1, v2)}");

            Console.ReadKey();
        }
    }
}
