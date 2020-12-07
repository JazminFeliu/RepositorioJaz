using System;

namespace Propiedades3
{
    class Socio
    {
        private string _nombre;
        private int _antiguedad;

        public string Nombre
        {
            set
            {
                _nombre = value;
            }
            get
            {
                return _nombre;
            }
        }

        public int Antiguedad
        {
            set
            {
                if (value > 0)
                {
                    _antiguedad = value;
                }
                else
                {
                    Console.WriteLine("La antiguedad no puede ser negativa. Se asignará un valor 0 por defecto");
                    _antiguedad = 0;
                }
                
            }
            get
            {
                return _antiguedad;
            }
        }
        
        public void Imprimir()
        {
            Console.WriteLine($"El socio {Nombre} tiene una antiguedad de {Antiguedad} años en el Club.");
        }

    }
}
