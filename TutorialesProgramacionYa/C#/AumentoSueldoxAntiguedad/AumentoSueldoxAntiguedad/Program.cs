using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoSueldoxAntiguedad
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo, sueldoconaumento, antig;
            string nombre, linea;

            Console.Write("Ingrese el nombre del Operario: ");
            nombre = Console.ReadLine();

            Console.Write($"Ingrese el sueldo que actualmente cobra {nombre}: $ ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);

            Console.Write($"Ahora por favor ingrese cuantos años hace que {nombre} trabaja en esta compañía: ");
            linea = Console.ReadLine();
            antig = float.Parse(linea);

            if (sueldo < 500 && antig >= 10)
            {
                sueldoconaumento = ((sueldo * 20) / 100) + sueldo;
                Console.WriteLine($"A partir de este mes, el sueldo de {nombre} será de $ {sueldoconaumento} ");
            }
            else if (sueldo < 500 && antig < 10)
            {
                sueldoconaumento = ((sueldo * 10) / 100) + sueldo;
                Console.WriteLine($"A partir de este mes, el sueldo de {nombre} será de $ {sueldoconaumento} ");
            }
            else
            {
                sueldoconaumento = ((sueldo * 5) / 100) + sueldo;
                Console.WriteLine($"A partir de este mes, el sueldo de {nombre} será de $ {sueldoconaumento} ");
            }
                
            Console.ReadKey();
        }
    }
}
