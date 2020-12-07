using System;

namespace Propiedades3
{
    class Club
    {
        private Socio _socio1;
        private Socio _socio2;
        private Socio _socio3;

        public Club()
        {
            _socio1 = new Socio();
            _socio2 = new Socio();
            _socio3 = new Socio();

            Console.Write("Ingrese el nombre del socio:");
            _socio1.Nombre = Console.ReadLine();

            Console.Write("Ingrese su antiguedad en la institucion: ");
            string linea = Console.ReadLine();
            _socio1.Antiguedad = int.Parse(linea);

            Console.Write("Ingrese el nombre del socio:");
            _socio2.Nombre = Console.ReadLine();

            Console.Write("Ingrese su antiguedad en la institucion: ");
            linea = Console.ReadLine();
            _socio2.Antiguedad = int.Parse(linea);

            Console.Write("Ingrese el nombre del socio:");
            _socio3.Nombre = Console.ReadLine();

            Console.Write("Ingrese su antiguedad en la institucion: ");
            linea = Console.ReadLine();
            _socio3.Antiguedad = int.Parse(linea);

        }

        public void CalcularMayorAntiguedad()
        {
            if (_socio1.Antiguedad > _socio2.Antiguedad && _socio1.Antiguedad > _socio3.Antiguedad )
            {
                Console.WriteLine($"{_socio1.Nombre} es el socio con mayor antiguedad. " +
                    $"Sus {_socio1.Antiguedad} años en el Club lo habilitan para ser SOCIO VITALICIO");
            }
            else if (_socio2.Antiguedad > _socio3.Antiguedad)
            {
                Console.WriteLine($"{_socio2.Nombre} es el socio con mayor antiguedad. " +
                    $"Sus {_socio2.Antiguedad} años en el Club lo habilitan para ser SOCIO VITALICIO");
            }
            else
            {
                Console.WriteLine($"{_socio3.Nombre} es el socio con mayor antiguedad. " +
                    $"Sus {_socio3.Antiguedad} años en el Club lo habilitan para ser SOCIO VITALICIO");
            }

            _socio1.Imprimir();
            _socio2.Imprimir();
            _socio3.Imprimir();
        }

        
    }
}
