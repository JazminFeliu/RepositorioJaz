using System;

namespace TiposDatosPrimitivos1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte v1 = 200;
            Console.WriteLine("Valor almacenado en la variable de tipo BYTE: " + v1);

            sbyte v2 = -100;
            Console.WriteLine("Valor almacenado en la variable de tipo SBYTE: " + v2);

            short v3 = 3000;
            Console.WriteLine("Valor almacenado en la variable de tipo SHORT: " + v3);

            ushort v4 = 6000;
            Console.WriteLine("Valor almacenado en la variable de tipo USHORT: " + v4);

            int v5 = -2000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo INT: " + v5);

            uint v6 = 2000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo UINT: " + v6);

            long v7 = -1000000000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo LONG: " + v7);

            ulong v8 = 1000000000000000000;
            Console.WriteLine("Valor almacenado en la variable de tipo ULONG: " + v8);

            Console.ReadKey();
        }
    }
}
