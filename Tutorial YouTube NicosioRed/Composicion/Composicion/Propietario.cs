using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    class Propietario
    {
        private string _nombre;
        private Edificio _edificio = null;

        public Propietario(string pnombre)
        {
            _nombre = pnombre;

            _edificio = new Edificio("Galicia 670", 15, 9); 
        }

        public void MostrarPropiedad()
        {
            if (_edificio != null)
            {
                Console.WriteLine("{0} tiene propiedades.", _nombre);
                _edificio.Mostrar();

            }
            else
            {
                Console.WriteLine("{0} no tiene aun propiedades.", _nombre);

            }
        }




    }
}
