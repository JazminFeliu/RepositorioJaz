using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicion2
{
    class Aula
    {
        private string nombreAula;
        private int cantAlumnos;

        public Aula(string pnombre, int pcant)
        {
            nombreAula = pnombre;
            cantAlumnos = pcant;
        }

        public override string ToString()
        {
            string mensaje = string.Format("El aula {0} tiene {1} alumnos", nombreAula, cantAlumnos);
            return mensaje;
        }
    }
}
