namespace ClaseParcial1
{
    partial class Rectangulo
    {
        public int RetornarSuperficie()
        {
            int superficie = Lado1 * Lado2;
            return superficie;
        }
        public int RetornarPerimetro()
        {
            int perimetro = (Lado1 * 2) + (Lado2 * 2);
            return perimetro;
        }
    }
}
