using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaVectorParalelo
{
    class VectorParalelo
    {
        private int[] _edad;
        private string[] _nombre;
            
        static void Main(string[] args)
        {
            VectorParalelo vp = new VectorParalelo();
            vp.Cargar();
            vp.MayorEdad();

            Console.ReadKey();
        }

        public void Cargar()

        {
            _nombre = new string[5];
            _edad = new int[5];
            
            for (int f=0; f<5; f++)
            {
                Console.Write($"Ingrese el nombre nro. {f+1}: ");

                _nombre[f] = Console.ReadLine();

                Console.Write($"Ingrese la edad de {_nombre[f]}: ");
                string linea = Console.ReadLine();
                _edad[f] = int.Parse(linea);
            }
        }

        public void MayorEdad()
        {
            for(int f = 0; f< 5; f++)
            {
                if (_edad[f] >= 18)
                    Console.WriteLine($"{_nombre[f]} es mayor de edad.");
            }
        }
  
    }
}
