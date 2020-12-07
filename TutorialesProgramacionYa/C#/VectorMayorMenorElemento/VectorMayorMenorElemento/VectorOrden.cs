using System;

namespace VectorMayorMenorElemento
{
    class VectorOrden
    {
        private string[] _nombre;
        private float[] _sueldo;

        static void Main(string[] args)
        {
            VectorOrden vo = new VectorOrden();
            vo.CargarVector();
            vo.OrdenarMayor();

            Console.ReadKey();

        }

        public void CargarVector()
        {
            _nombre = new string[5];
            _sueldo = new float[5];

            for(int f=0; f<_nombre.Length; f++)
            {
                Console.Write($"Ingrese el nombre nro. {f +1}: ");
                _nombre[f] = Console.ReadLine();

                Console.Write($"Ingrese el sueldo de {_nombre[f]}: ");
                string linea = Console.ReadLine();
                _sueldo[f] = float.Parse(linea);
            }
        }

        public void OrdenarMayor()
        {
            float sueldoMayor;
            sueldoMayor = _sueldo[0];

            
            int pos = 0;

            for (int f = 0; f< _sueldo.Length; f++)
            {
                if (_sueldo[f] > sueldoMayor)
                {
                    sueldoMayor = _sueldo[f];
                    pos = f;                   
                }                    
            }

            Console.WriteLine($"El empleado {_nombre[pos]} percibe el sueldo mayor que es de {sueldoMayor}");
        }
    }
}
