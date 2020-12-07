using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVector2
{
    class Alturas
    {
        private float[] _alturas;
        private float _promedio;

        static void Main(string[] args)
        {
            Alturas altura = new Alturas();
            
            altura.CargarAlturas();
            altura.CalcularPromedio();
            altura.CalcularAltasBajas();

            Console.ReadKey();
        }

        public void CargarAlturas()
        {
            _alturas = new float[5];
            string linea;
            

            for (int f = 0; f<5; f++)
            {
                Console.WriteLine($"Ingrese la altura nro. {f + 1}: ");
                linea = Console.ReadLine();
                _alturas[f] = float.Parse(linea);                                
            }
            
        }

        public void CalcularPromedio()
        {
            
            float suma = 0;
            
            for (int f = 0; f < 5; f++)
            {
                suma = suma + _alturas[f];                            
            
            }
            _promedio = suma / 5;
            Console.WriteLine("El promedio de alturas es de: " + _promedio);

        }

        public void CalcularAltasBajas()
        {
            int cantAltas = 0;
            int cantBajas = 0;
            
            for (int f = 0; f < 5; f++)
            {
                if (_alturas[f] > _promedio)
                    cantAltas++;
                else
                    cantBajas++;
            }

            Console.WriteLine($"{cantAltas} son alturas mas altas que el promedio y {cantBajas} son más bajas que él");
        }

    }
}
