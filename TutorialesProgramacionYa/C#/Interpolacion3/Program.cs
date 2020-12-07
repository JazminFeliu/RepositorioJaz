using System;

namespace Interpolacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alumnos = { "Santy", "Seba", "Lucia", "Estrella", "Jazmin", "Marina" };
            int[] notas = { 10, 10, 8, 8, 10, 8 };
            for (int f=0; f<alumnos.Length; f++)
            {
                Console.WriteLine($"{alumnos[f], -20} {notas[f], 2}");
            }

            Console.ReadKey();
        }
    }
}
