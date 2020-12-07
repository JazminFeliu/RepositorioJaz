using System;

namespace GameOfLearnIT
{

    public class Aprendiz : Personaje
    {
        private int _force;
        private int _spell;
        private int _health;
        private int _levelAprendiz;


        public Aprendiz(string nombre)
        {
            Nombre = nombre;

        }
        public override void DefinirPersonaje()
        {
            Console.WriteLine($"{Nombre} será Aprendiz. Felicitaciones, aprendera ambos skills.");
        }

        public override void OtorgarNivelInicialPersonaje()
        {
            _force = 1;
            _spell = 0;
            _health = 1;
            _levelAprendiz = 1;
        }


        public override void MostrarPersonaje()
        {
            Console.WriteLine($"El Aprendiz {Nombre} ha subido al nivel {_levelAprendiz}");
            Console.WriteLine($"Su hechizo es de {_spell}, cuenta con una fuerza de {_force} y su salud es {_health}");
            Console.WriteLine("Felicitaciones!!!");
        }

    }
}
