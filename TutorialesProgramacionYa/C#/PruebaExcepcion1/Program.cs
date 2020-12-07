using System;

namespace PruebaExcepcion1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continua;
            do
            {
                try
                {
                    continua = false;
                    Console.Write("Ingrese un valor: ");
                    string linea = Console.ReadLine();
                    var num = int.Parse(linea);
                    var cuadrado = num * num;

                    Console.WriteLine($"El cuadrado de {num} es {cuadrado}");
                }
                catch (FormatException e)
                {
                    Console.Write("Debe ingresar obligatoriamente un número. ");
                    continua = true;
                }
            } while (continua);
            
            Console.ReadKey();
        }
    }
}
