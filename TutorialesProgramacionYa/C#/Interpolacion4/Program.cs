using System;

namespace Interpolacion4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;

            Console.WriteLine($"La fecha y hora actual es  {fecha:dd MM yyyy HH:mm:ss}");

            double precio = 10.252;

            Console.WriteLine($"La variable precio {precio:.##} con dos decimales.");

            Console.WriteLine($"La variable precio {precio:E} con formato exponencial.");

            byte color = 255;

            Console.WriteLine($"La variable color {color:X} con formato exadecimal");

            Console.ReadKey();
        }
    }
}
