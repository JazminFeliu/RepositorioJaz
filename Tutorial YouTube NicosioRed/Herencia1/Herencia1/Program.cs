using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            var uno = new Persona(" Jazmin ",43);
            

            uno.Muestra();
            Console.WriteLine("------------------");

            var dos = new Empleado("Sebastián", 44, "Desarrollador de Software", 200000.50);
           

            dos.EmpleadoMuestra();

            dos.Muestra();
            Console.WriteLine("------------------");

            var tres = new Empleado("Susana", 25, "Programadora", 150000.60);

            tres.EmpleadoMuestra();

            tres.PonerDatos("Susana", 23, "Programadora Senior", 189000);

            tres.EmpleadoMuestra();

            Console.ReadKey();
        }
    }
}
