using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Edificio
    {
        private string _direccion;
        private int _cantDeptos;
        private int _depRentados;

        public Edificio(string pdireccion, int pcantDeptos, int pdepRentados)
        {
            _direccion = pdireccion;
            _cantDeptos = pcantDeptos;
            _depRentados = pdepRentados;
        }
       

        public void Muestra()
        {
            Console.WriteLine("Edificio en {0} con {1} departamentos, {2} rentados", _direccion, _cantDeptos, _depRentados);

            
        }
    }
}
