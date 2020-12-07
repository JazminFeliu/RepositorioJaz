namespace SinGenericos1
{
    class PilaEnteros
    {
        private int[] _vec = new int[5];
        private int _tope = 0;

        public void Insertar(int x)
        {
            _vec[_tope] = x;
            _tope++;
        }

        public int Extraer()
        {
            _tope--;
            return _vec[_tope];
        }
    }
}
