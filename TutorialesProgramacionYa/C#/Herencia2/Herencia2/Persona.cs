using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    public class Persona
    {
        protected string _nombre;
        protected int _edad;

        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return _edad;
            }
            set
            {
                _edad = value;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"{_nombre} tiene {_edad} años");
        }
    }
}
