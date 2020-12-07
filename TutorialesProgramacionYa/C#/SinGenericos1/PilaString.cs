namespace SinGenericos1
{
    class PilaString
    {
        private string[] _vec = new string[5];
        private int _tope = 0;

        public void Insertar(string x)
        {
            _vec[_tope] = x;
            _tope++;
        }

        public string Extraer()
        {
            _tope--;
            return _vec[_tope];
        }
    }
}
