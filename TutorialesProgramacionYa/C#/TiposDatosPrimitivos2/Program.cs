using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDatosPrimitivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor máximo y mínimo para tipo de dato BYTE");
            Console.WriteLine("Mínimo: " + byte.MinValue);
            Console.WriteLine("Máximo: " + byte.MaxValue);

            Console.WriteLine("Valor máximo y mínimo para tipo de dato SBYTE");
            Console.WriteLine("Mínimo: " + sbyte.MinValue);
            Console.WriteLine("Máximo: " + sbyte.MaxValue);

            Console.WriteLine("Valor máximo y mínimo para tipo de dato SHORT");
            Console.WriteLine("Mínimo: " + short.MinValue);
            Console.WriteLine("Máximo: " + short.MaxValue);

            Console.WriteLine("Valor máximo y mínimo para tipo de dato USHORT");
            Console.WriteLine("Mínimo: " + ushort.MinValue);
            Console.WriteLine("Máximo: " + ushort.MaxValue);

            Console.WriteLine("Valor máximo y mínimo para tipo de dato INT");
            Console.WriteLine("Mínimo: " + int.MinValue);
            Console.WriteLine("Máximo: " + int.MaxValue);

            Console.WriteLine("Valor máximo y mínimo para tipo de dato UINT");
            Console.WriteLine("Mínimo: " + uint.MinValue);
            Console.WriteLine("Máximo: " + uint.MaxValue);

            Console.WriteLine("Valor máximo y mínimo para tipo de dato LONG");
            Console.WriteLine("Mínimo: " + long.MinValue);
            Console.WriteLine("Máximo: " + long.MaxValue);

            Console.WriteLine("Valor máximo y mínimo para tipo de dato ULONG");
            Console.WriteLine("Mínimo: " + ulong.MinValue);
            Console.WriteLine("Máximo: " + ulong.MaxValue);

            Console.WriteLine("Valor máximo y mínimo para tipo de dato FLOAT");
            Console.WriteLine("Mínimo: " + float.MinValue);
            Console.WriteLine("Máximo: " + float.MaxValue);

            Console.WriteLine("Valor máximo y mínimo para tipo de dato DOUBLE");
            Console.WriteLine("Mínimo: " + double.MinValue);
            Console.WriteLine("Máximo: " + double.MaxValue);

            Console.WriteLine("Valor máximo y mínimo para tipo de dato DECIMAL");
            Console.WriteLine("Mínimo: " + decimal.MinValue);
            Console.WriteLine("Máximo: " + decimal.MaxValue);

            Console.WriteLine("Bytes reservados para el tipo de dato BYTE: " + sizeof(byte));
            Console.WriteLine("Bytes reservados para el tipo de dato SBYTE: " + sizeof(sbyte));
            Console.WriteLine("Bytes reservados para el tipo de dato SHORT: " + sizeof(short));
            Console.WriteLine("Bytes reservados para el tipo de dato USHORT: " + sizeof(ushort));
            Console.WriteLine("Bytes reservados para el tipo de dato INT: " + sizeof(int));
            Console.WriteLine("Bytes reservados para el tipo de dato UINT: " + sizeof(uint));
            Console.WriteLine("Bytes reservados para el tipo de dato LONG " + sizeof(long));
            Console.WriteLine("Bytes reservados para el tipo de dato ULONG: " + sizeof(ulong));
            Console.WriteLine("Bytes reservados para el tipo de dato FLOAT: " + sizeof(float));
            Console.WriteLine("Bytes reservados para el tipo de dato DOUBLE: " + sizeof(double));
            Console.WriteLine("Bytes reservados para el tipo de dato DECIMAL: " + sizeof(decimal));
            Console.WriteLine("Bytes reservados para el tipo de dato CHAR: " + sizeof(char));
            Console.WriteLine("Bytes reservados para el tipo de dato BOOLEAN: " + sizeof(bool));

            Console.ReadKey();
        }
    }
}
