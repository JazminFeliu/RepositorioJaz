using System;

namespace ParametrosPorReferencia4
{
    class Program
    {
        public void DosValoresAleatorios(out int v1, out int v2)
        {
            var r = new Random();
            v1 = r.Next(1, 101);
            v2 = r.Next(1, 101);

        }

        static void Main(string[] args)
        {
            int ale1, ale2;
            var p = new Program();

            p.DosValoresAleatorios(out ale1, out ale2);

            Console.WriteLine("Primer valor aleatorio: " + ale1);
            Console.WriteLine("Segundo valor aleatorio: " + ale2);

            Console.ReadKey();

        }
    }
}
