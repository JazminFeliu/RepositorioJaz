using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class Persona
    {
            
        public Persona (string pNombre, int pEdad)
        {
            Console.WriteLine("Constructor de persona");
            nombre = pNombre;
            edad = pEdad;
        }
        protected string nombre;
        protected int edad;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value >= 18)

                    edad = value;
                else
                {
                    edad = -1;
                    Console.WriteLine("Edad no permitida");
                }
            }
        }

        public void Muestra()
        {
            Console.WriteLine("{0} tiene {1} años", nombre, edad);
        }
    }
}
