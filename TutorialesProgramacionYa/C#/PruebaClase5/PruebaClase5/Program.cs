using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaClase5
{
    class Empleado

    {
        private string nombre;
        private float sueldo;

        public void Inicializar()
        {
            string linea;
            Console.Write("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.Write($"Ingrese el sueldo de {nombre}: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);                    

        }

        public void Imprimir()
        {
            Console.WriteLine($"El empleado {nombre} persive un sueldo de ${sueldo}.");
           
            Console.ReadKey();
        }

        public void PagarImpuestos()
        {
            if (sueldo > 3000)
                Console.WriteLine($"{nombre} debe pagar impuestos.");
            else
                Console.WriteLine($"{nombre} no debe pagar impuestos");
        }


        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.Inicializar();
            empleado.Imprimir();
            empleado.PagarImpuestos();

            Console.ReadKey();
        }
    }
}
