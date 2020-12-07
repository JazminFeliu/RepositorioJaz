using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarTresNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;

            Console.Write("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("Ingrese el tercer valor: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 > num2 && num1 > num3)
            {
                if (num2 > num3)
                    Console.WriteLine($"Los valores de mayor a menor son: {num1}, {num2},{num3}");
                else
                    Console.WriteLine($"Los valores de mayor a menor son: {num1}, {num3},{num2}");
            }
            else if (num2 > num3 && num2 > num1)
            {
                if (num1 > num3)
                    Console.WriteLine($"Los valores de mayor a menor son: {num2}, {num1},{num3}");
                else
                    Console.WriteLine($"Los valores de mayor a menor son: {num2}, {num3},{num1}");
            }
            if (num3 > num2 && num3 > num1)
            {
                if (num2 > num1)
                    Console.WriteLine($"Los valores de mayor a menor son: {num3}, {num2},{num1}");
                else
                    Console.WriteLine($"Los valores de mayor a menor son: {num3}, {num1},{num2}");
            }
            Console.ReadKey();
        }
            
        
    }
}
