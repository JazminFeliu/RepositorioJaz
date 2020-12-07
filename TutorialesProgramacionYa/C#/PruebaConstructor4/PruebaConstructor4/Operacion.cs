using System;

namespace PruebaConstructor4
{
    class Operacion
    {
        private float _numero1;
        private float _numero2;
        private float _suma;
        private float _resta;
        private float _multi;
        private float _divi;

        public float Resultado { get; set; }

        public Operacion(int numero1, int numero2)
        {
            _numero1 = numero1;
            _numero2 = numero2;
        }

        public float SumarOpe()
        {
            float s = _numero1 + _numero2;
            _suma = s;

            Resultado = s;

            return s;
        }

        public float RestarOpe()
        {
            float r = _numero1 - _numero2;
            _resta = r;

            Resultado = r;

            return r;
        }

        public float MultiplicarOpe()
        {
            float m = _numero1 * _numero2;
            _multi = m;

            Resultado = m;

            return m;
        }

        public float DividirOpe()
        {
            float d = (float)_numero1 / _numero2;
            _divi = d;

            Resultado = d;

            return d;
        }

        public void Imprimir()
        {
            Console.WriteLine($"El resultado de sumar los dos valores es {_suma}");
            Console.WriteLine($"El resultado de restar los dos enteros ingresados es {_resta}");
            Console.WriteLine($"El resultado de multiplicar ambos valores es {_multi}");
            Console.WriteLine($"Finalmente, si los dividimos su resultado es {_divi}");
        }
    }
}
