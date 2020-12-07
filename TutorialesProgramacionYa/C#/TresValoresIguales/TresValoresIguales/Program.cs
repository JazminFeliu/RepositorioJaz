using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresValoresIguales
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, total;
            string valor;

            Console.Write("Ingrese el primer valor por teclado: ");
            valor = Console.ReadLine();
            num1 = int.Parse(valor);

            Console.Write("Ingrese el segurndo valor por teclado: ");
            valor = Console.ReadLine();
            num2 = int.Parse(valor);

            Console.Write("Ingrese el tercer valor por teclado: ");
            valor = Console.ReadLine();
            num3 = int.Parse(valor);

            if (num1 == num2 && num2 == num3)
            {
                total = (num1 + num2) * num3;
                Console.WriteLine($"El resultado de (num1+num2)*num3 es {total}");
            }
            Console.ReadKey();
        }
    }
}
