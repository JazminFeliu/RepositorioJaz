using System;

namespace EstructuraForeach
{
    class SueldoEmpleados
    {
        private int[] _sueldos;

        public void Cargar()
        {
            _sueldos = new int[5];

            for(int f=0; f<_sueldos.Length; f++)
            {
                Console.WriteLine("Ingrese el valor de la componente: ");
                string linea = Console.ReadLine();
                _sueldos[f] = int.Parse(linea);
            }
        }
        public void Imprimir()
        {
            foreach(int s in _sueldos)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}
