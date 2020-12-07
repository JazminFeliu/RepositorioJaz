using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion
{
    class Edificio
    {
        private string _direccion;
        private int _cantDptos;
        private int _dptosRentados;

        public Edificio(string pdireccion, int pcantDptos, int dptosRentados)
        {
            _direccion = pdireccion;
            _cantDptos = pcantDptos;
            _dptosRentados = dptosRentados;
        }

        public void Mostrar()
        {
            Console.WriteLine("En la dirección {0} hay un edificio, que tiene {1} departamentos y {2} estan rentados.", _direccion, _cantDptos, _dptosRentados);
        }
    }
}
