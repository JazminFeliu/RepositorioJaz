using System;

namespace GameOfLearnIT
{
    public class Hechicera : Personaje
    {
        private int _force;
        private int _spell;
        private int _health;
        private int _levelHechicera;

        public Hechicera(string nombre)
        {
            Nombre = nombre;
        }

        public override void DefinirPersonaje()
        {
            Console.WriteLine($"{Nombre} será Hechicera.");
        }

        public override void OtorgarNivelInicialPersonaje()
        {
            _force = 6;
            _spell = 10;
            _health = 8;
            _levelHechicera = 1;
        }

        public override void MostrarPersonaje()
        {
            Console.WriteLine($"La Hechicera {Nombre} ha subido al nivel {_levelHechicera}");
            Console.WriteLine($"Su hechizo es de {_spell}, cuenta con una fuerza de {_force} y su salud es {_health}");
            Console.WriteLine("Felicitaciones!!!");
        }
    }
}
