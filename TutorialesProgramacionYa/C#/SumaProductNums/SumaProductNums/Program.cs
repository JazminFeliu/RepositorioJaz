using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaProductNums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicios de capitulo 5- Estructura de Programacion secuencial, TutorialesYa C#

            int num1, num2, num3, num4, suma, producto, perimetro, promedio, cantidad;
            float precio, total;
            string linea;
            
            Console.Write("Ingrese primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            suma = num1 + num2;
            producto = num1 * num2;

            Console.WriteLine($"La suma de los dos numeros es de {suma} y su producto es {producto}");

            // Calculamos la suma y la multiplicacion de dos numeros enteros ingresados por teclado.

            Console.ReadKey();

            Console.Write("Ingrese el lado de un cuadrado: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            perimetro = num1 * 4;

            Console.WriteLine($"El perímetro del cuadrado es {perimetro}");

            // Calculamos el perímetro de un cuadrado, tomando el lado por teclado.

            Console.ReadKey();

            Console.WriteLine("Ingrese el primer valor: ");
            linea = Console.ReadLine();

            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese es segundo valor: ");
            linea = Console.ReadLine();

            num2 = int.Parse(linea);

            Console.WriteLine("Ingrese el tercer valor: ");
            linea = Console.ReadLine();

            num3 = int.Parse(linea);

            Console.WriteLine("Ingrese el cuarto valor: ");
            linea = Console.ReadLine();

            num4 = int.Parse(linea);

            suma = num1 + num2;
            producto = num3 * num4;

            Console.WriteLine($"La suma de los valores 1 y 2 es de {suma} y el producto de los valores 3 y 4 es de {producto}");

            // Se ingresan cuatro valores por teclado y se calcula la suma de los dos primeros y el producto de los otros dos.

            Console.ReadKey();

            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;

            Console.WriteLine($"La suma de los cuatro valores ingresados es de {suma} y su promedio {promedio}");

            // Se realiza la suma y el promedio de los cuatro valores ingresados.

            Console.ReadKey();

            Console.WriteLine("Ingrese el precio del producto que quiere llevar: ");
            linea = Console.ReadLine();
            precio = float.Parse(linea);

            Console.WriteLine("Ingrese la cantidad de productos que desea llevar: ");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            total = precio * cantidad;

            Console.WriteLine($"El total que debe abonar es de {total} ");

            // Se ingresa por teclado precio y cantidad de un articulo a comprar y se informa el precio total a abonar.

            Console.ReadKey();





            


        }
    }
}
