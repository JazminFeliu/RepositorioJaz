using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion2
{
    class Escuela
    {
        private string nombre;
        private Aula[] aulas = new Aula[3];

        public Escuela(string pnombre)
        {
            nombre = pnombre;
        }

        public void ColocaAula()
        {
            int n = 0;
            string dato = "";
            string nombre = "";
            int cantidad = 0;

            for (n  = 0; n<aulas.Length; n++)
            {
                Console.WriteLine("Da")
            }
        }
    }
}
