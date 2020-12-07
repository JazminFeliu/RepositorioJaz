namespace ParametrosPorReferencia2
{
    class Referencia
    {
        public void OrdenarMenMay(ref int v1, ref int v2, ref int v3)
        {
            int menor;
            int intermedio;
            int mayor;

            if (v1<=v2 && v1<= v3)
            {
                menor = v1;

                if (v2<= v3)
                {
                    intermedio = v2;
                    mayor = v3;
                }
                else
                {
                    intermedio = v3;
                    mayor = v2;
                }
            }
            else if (v2 <= v3)
            {
                menor = v2;
                
                if(v1<v3)
                {
                    intermedio = v1;
                    mayor = v3;
                }
                else
                {
                    intermedio = v3;
                    mayor = v1;
                }
            }
            else
            {
                menor = v3;

                if (v1<v2)
                {
                    intermedio = v1;
                    mayor = v2;
                }
                else
                {
                    intermedio = v2;
                    mayor = v1;
                }
            }

            v1 = menor;
            v2 = intermedio;
            v3 = mayor;
        }
    }
}
