using System;

namespace PruebaConstructor3
{
    class Empleado
    {
        private string[] _nombre;
        private float[] _sueldo;

        public Empleado()
        {
            Console.Write("Ingrese la cantidad de empleados que se cargarán: ");
            string linea = Console.ReadLine();
            int cant = int.Parse(linea);

            _nombre = new string[cant];
            _sueldo = new float[cant];

            for(int f=0; f<cant; f++)
            {
                Console.Write($"Ingrese el nombre del empleado: ");
                _nombre[f] = Console.ReadLine();

                Console.Write($"Ingrese el sueldo de {_nombre[f]}: ");
                linea = Console.ReadLine();
                _sueldo[f] = float.Parse(linea);                
            }
        }

        public void ImprimirEmpleados()
        {
            for(int f=0; f<_sueldo.Length; f++)
            {
                Console.WriteLine($"El sueldo de {_nombre[f]} es de ${_sueldo[f]}. ");
            }
        }

        public void PagarImpuestos()
        {
            for(int f=0; f<_sueldo.Length; f++)
            {
                if (_sueldo[f] > 3000)
                {
                    Console.WriteLine($"{_nombre[f]} debe pagar impuestos ya que su sueldo de $ {_sueldo[f]} supera los $ 3000");                   
                }
            }

            Console.ReadKey();
        }
            
    }
}