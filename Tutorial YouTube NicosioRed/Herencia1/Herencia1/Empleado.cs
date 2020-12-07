using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia1
{
    sealed class Empleado : Persona
    {
        private string _puesto;
        private double _salario;

        public Empleado(string pNombre, int pEdad, string pPuesto, double pSalario)
            : base (pNombre, pEdad)
        {
            Console.WriteLine("Constructor Empleado");
            _puesto = pPuesto;
            _salario = pSalario;
        }
        public string Puesto
        {
            get
            {
                return _puesto;
            }
            set
            {
                _puesto = value;
            }
        }


        public double Salario
        {
            get
            {
                return _salario;
            }
            set
            {
                _salario = value;
            }
        }
         
        public void PonerDatos(string pnombre, int pedad, string ppuesto, double psalario)
        {
            _puesto = ppuesto;
            _salario = psalario;
                        
            nombre = pnombre;
            edad = pedad;
        }

        public void EmpleadoMuestra()
        {
            Muestra();
            Console.WriteLine("Trabaja de {0} con sueldo de $ {1}", _puesto, _salario);
        }

    }
}
