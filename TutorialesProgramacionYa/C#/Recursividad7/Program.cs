using System;

namespace Recursividad7
{
    class Program
    {
        static void Main(string[] args)
        {
            var re = new Recursividad();
            re.InsertarPrimero(10);
            re.InsertarPrimero(4);
            re.InsertarPrimero(5);
            re.ImprimirInversa();

            Console.ReadKey();
        }
    }
}
