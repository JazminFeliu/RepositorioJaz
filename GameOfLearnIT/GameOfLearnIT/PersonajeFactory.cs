namespace GameOfLearnIT
{
    public class PersonajeFactory
    {
        private static Aprendiz _aprendiz;
        private static Hechicera _hechicera;
        private static Mago _mago;

        public static IPersonaje CrearPersonaje(TipoDePersonaje personaje, string nombre)
        {
            IPersonaje obj = null;

            switch (personaje)
            {
                case TipoDePersonaje.Aprendiz:
                    if (_aprendiz == null)
                        _aprendiz = new Aprendiz(nombre);
                    

                    obj = _aprendiz;
                    break;

                case TipoDePersonaje.Hechicera:
                    if (_hechicera == null)
                        _hechicera = new Hechicera(nombre);
                    

                    obj = _hechicera;
                    break;

                case TipoDePersonaje.Mago:
                    if (_mago == null)
                        _mago = new Mago(nombre);
                    

                    obj = _mago;
                    break;

            }
            return obj;
        }
    }
}
