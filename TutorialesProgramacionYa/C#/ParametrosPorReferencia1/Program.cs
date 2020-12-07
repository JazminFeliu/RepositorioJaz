using System;

namespace ParametrosPorReferencia1
{
    class Program
    {
        public void Intercambiar( ref int valor1, ref int valor2 )
        {
            int aux = valor1;
            valor1 = valor2;
            valor2 = aux;
            
        }

        static void Main(string[] args)
        {
            var p = new Program();
            int v1 = 45;
            int v2 = 78;

            Console.WriteLine($"Los valores ingresados son: {v1} y {v2}.");
            p.Intercambiar(ref v1, ref v2);

            Console.WriteLine($"Los valores intercambiados quedaron así: {v1} y {v2}");

            Console.ReadKey();
        }
    }
}
