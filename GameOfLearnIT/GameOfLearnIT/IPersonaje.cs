namespace GameOfLearnIT
{
    public interface IPersonaje
    {
        string Nombre { get; set; }
        void DefinirPersonaje();
        void OtorgarNivelInicialPersonaje();
        void MostrarPersonaje();
    }
}
