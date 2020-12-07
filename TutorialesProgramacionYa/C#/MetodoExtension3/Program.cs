using System;

namespace MetodoExtension3
{
    public static class Extension
    {
        public static void ImprimirHasta(this int valor, int fin)
        {
            for(var inicio = 0; inicio<+fin; inicio++)
            {
                Console.Write("{0} ", inicio);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            31.ImprimirHasta(30);
            Console.WriteLine();

            int va = 100;
            va.ImprimirHasta(150);

            Console.ReadKey();
        }
    }
}
