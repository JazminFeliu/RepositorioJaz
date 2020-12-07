using System;

namespace ParametrosPorReferencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            var refi = new Referencia();
            Console.Write("Ingrese el primer valor: ");
            string linea = Console.ReadLine();
            int val1 = int.Parse(linea);

            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            int val2 = int.Parse(linea);

            Console.Write("Ingrese el tercer valor:");
            linea = Console.ReadLine();
            int val3 = int.Parse(linea);

            Console.WriteLine($"Los valores ingresados son {val1} - {val2} - {val3}");

            refi.OrdenarMenMay(ref val1, ref val2, ref val3);

            Console.WriteLine($"Los valores ordenados de menor a mayor quedaron asi: {val1} - {val2} - {val3} ");

            Console.ReadKey();
        }
    }
}
