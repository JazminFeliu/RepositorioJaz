using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    class Becario : Persona
    {
        private int horasBeca;

        public Becario(string pnombre, int pedad, int phoras)
            :base(pnombre, pedad)
        {
            horasBeca = phoras;
        }

        public int HorasBeca
        {
            get
            {
                return horasBeca;
            }
            set
            {
                horasBeca = value;
            }
        }

        public void MuestraBecario()
        {
            Console.WriteLine("Cantidad de horas: {0}", horasBeca);
        }
    }
}
