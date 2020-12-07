using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaNavidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una fecha en el siguiente formato y con las barras de división dd/mm/aaaa :");
            string fechaIngresada = Console.ReadLine();
            
            bool fechaOK = DateTime.TryParseExact(
                fechaIngresada,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, 
                out DateTime fecha);

            if (fechaOK)
            {
                Console.WriteLine(fecha);
                if ((fecha.Day == 25) && (fecha.Month == 12))
                    Console.WriteLine("La fecha ingresada es Navidad");
                else
                    Console.WriteLine("La fecha ingresada no es Navidad");
            }              

            else
                Console.WriteLine("Escribi bien la fecha puto");

            

            Console.ReadKey();

        }
    }
}
