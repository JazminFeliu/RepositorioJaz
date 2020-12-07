using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClase6
{
    class Operaciones
    {
        private int _valor1;
        private int _valor2;

        static void Main(string[] args)
        {
            Operaciones operaciones = new Operaciones();
            operaciones.IngresarValores();
            operaciones.Sumar();
            operaciones.Restar();
            operaciones.Multiplicar();
            operaciones.Dividir();
        }
        
        public void IngresarValores()
        {
            Console.Write("Ingrese el primer valor entero: ");
            string linea = Console.ReadLine();
            _valor1 = int.Parse(linea);

            Console.Write("Ingrese el segundo valor entero: ");
            linea = Console.ReadLine();
            _valor2 = int.Parse(linea);
        }

        public void Sumar()
        {
            int suma = _valor1 + _valor2;
            Console.WriteLine($"La suma de {_valor1} y {_valor2} dá como resultado: {suma}");

            Console.ReadKey();
        }

        public void Restar()
        {
            int resta = _valor1 - _valor2;
            Console.WriteLine($"La diferencia entre {_valor1} y {_valor2} es de {resta}");

            Console.ReadKey();
        }

        public void Multiplicar()
        {
            int multi = _valor1 * _valor2;
            Console.WriteLine($"Si multiplicás {_valor1} por {_valor2} el resultado es: {multi}");

            Console.ReadKey();
        }

        public void Dividir()
        {
            int divi = _valor1 / _valor2;
            Console.WriteLine($"{divi} es el resultado de dividir {_valor1} por {_valor2}");

            Console.ReadKey();
        }
    }
}
