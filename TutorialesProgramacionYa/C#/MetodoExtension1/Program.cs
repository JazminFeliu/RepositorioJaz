using System;

namespace MetodoExtension1
{
    public static class Extension
    {
        public static string MitadPrimera(this string cadena)
        {
            return cadena.Substring(0, cadena.Length / 2);
        }

        public static string MitadSegunda(this string cadena)
        {
            return cadena.Substring(cadena.Length / 2, cadena.Length / 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = "Un mundo dividido por el mismo Dios. Nacho Cano ";

            Console.WriteLine(cadena1.MitadPrimera());
            Console.WriteLine(cadena1.MitadSegunda());

            Console.ReadKey();
        }
    }
}
