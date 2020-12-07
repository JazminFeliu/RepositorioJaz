using System;

namespace PruebaExcepcion11
{
    public class TemperaturaFueradeRangoException : Exception
    {
        public TemperaturaFueradeRangoException(string mensaje) : base(mensaje)
        { 
        }
    }

    public class Termometro
    {
        private float temperatura;
        public float Temperatura
        {
            get
            {
                return temperatura;
            }
            set
            {
                if (value< -192 || value > 100)
                {
                    throw new TemperaturaFueradeRangoException($"La temperatura {value} está fuera de rango [-192,100]");                    
                }
                temperatura = value;
            }
        }
        
        public Termometro(float temperatura)
        {
            Temperatura = temperatura;
        }
        public void Imprimir()
        {
            Console.WriteLine("La temperatura actual del termómetro es de: " + temperatura);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var termo1 = new Termometro(30);
                termo1.Imprimir();
                termo1.Temperatura = -200;
                termo1.Imprimir();
            }
            catch (TemperaturaFueradeRangoException ex)
                {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
