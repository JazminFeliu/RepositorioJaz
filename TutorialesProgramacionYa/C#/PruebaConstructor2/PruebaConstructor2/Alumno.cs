using System;

namespace PruebaConstructor2
{
    public class Alumno
    {
        private string _nombre;
        private int _edad;

        public Alumno()
        {
            Console.Write("Ingrese el nombre del alumno: ");
            _nombre = Console.ReadLine();

            Console.Write($"Ingrese la edad de {_nombre}: ");
            string linea = Console.ReadLine();
            _edad = int.Parse(linea);
        }

        public void EsMayorEdad()
        {
            if(_edad > 17)
            {
                Console.WriteLine($"{_nombre} es mayor de edad. Tiene {_edad} años.");
            }
            else
            {
                Console.WriteLine($"{_nombre} no es mayor de edad. Tiene {_edad} años.");
            }
            Console.ReadKey();
        }             

    }
}
