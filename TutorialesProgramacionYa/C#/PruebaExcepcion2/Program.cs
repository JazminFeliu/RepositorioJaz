using System;

namespace PruebaExcepcion2
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.Write("Ingrese el primer valor: ");
                var num1 = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo valor: ");
                var num2 = int.Parse(Console.ReadLine());
                var resu = num1 / num2;

                Console.WriteLine($"La división de {num1} y {num2} es {resu} ");
            }
            catch(FormatException e)
            {
                Console.Write("Debe ingresar obligatoriamente números enteros. ");
            }
            catch(DivideByZeroException e)
            {
                Console.Write("El segundo valor no puede ser cero");
            }
            Console.ReadKey();
        }
    }
}
