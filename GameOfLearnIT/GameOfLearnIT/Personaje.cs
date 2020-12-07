namespace GameOfLearnIT
{
    public abstract class Personaje : IPersonaje
    {         
        public string Nombre { get; set; }

        public abstract void DefinirPersonaje();
        public abstract void OtorgarNivelInicialPersonaje();
        public abstract void MostrarPersonaje();
        
    }
    
}






