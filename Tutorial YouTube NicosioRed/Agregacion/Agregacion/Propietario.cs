using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Propietario
    {
        private string _nombre;
        private Edificio propiedad = null;

        public Propietario(string pNombre)
        {
            _nombre = pNombre;
        }

        public void MostrarPropiedad()
        {
            if(propiedad != null)
            {
                Console.WriteLine("{0} tiene propiedad.", _nombre);
                propiedad.Muestra();
            }
            else
            {
                Console.WriteLine("{0} aun no tiene propiedades.", _nombre);
            }
        }

        //este es el metodo por el cual logro la Agregacion

        public void AdicionarPropiedad(Edificio pEdificio)
        {
            if(pEdificio != null)
            {
                propiedad = pEdificio;
            }
        }

    }
}
