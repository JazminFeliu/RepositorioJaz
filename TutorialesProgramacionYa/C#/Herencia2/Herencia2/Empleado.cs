using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    public class Empleado : Persona
    {
        protected float sueldo;
        
        public float Sueldo
        {
            get
            {
                return sueldo;
            }
            set
            {
                sueldo = value;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("El sueldo es de $ " + sueldo);
        }

    }
}
