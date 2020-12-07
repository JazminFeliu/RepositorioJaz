using System;

namespace ListaGenerica1
{
    class ListaGenerica
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo _raiz;

        public ListaGenerica()
        {
            _raiz = null;
        }

        public void Insertar(int pos, int x)
        {
            if (pos <= Cantidad() + 1)
            {
                var nuevo = new Nodo();
                nuevo.info = x;
                
                if(pos == 1)
                {
                    nuevo.sig = _raiz;
                    _raiz = nuevo;
                }
                else
                {
                    if (pos == Cantidad() + 1)
                    {
                        Nodo reco = _raiz;
                        while(reco.sig !=null)
                        {
                            reco = reco.sig;
                        }
                        reco.sig = nuevo;
                        nuevo.sig = null;
                    }
                    else
                    {
                        Nodo reco = _raiz;
                        
                        for (int f = 1; f <= pos - 2; f++)
                        {
                            reco = reco.sig;
                        }
                        Nodo siguiente = reco.sig;
                        reco.sig = nuevo;
                        nuevo.sig = siguiente;
                    }
                }
            }
        }

        public int Extraer (int pos)
        {
            if(pos <= Cantidad())
            {
                int informacion;
                
                if (pos == 1)
                {
                    informacion = _raiz.info;
                    _raiz = _raiz.sig;
                }
                else
                {
                    Nodo reco;
                    reco = _raiz;

                    for (int f = 1; f <= pos -2; f++)
                    {
                        reco = reco.sig;
                    }

                    Nodo prox = reco.sig;
                    reco.sig = prox.sig;
                    informacion = prox.info;
                }
                return informacion;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public void Borrar (int pos)
        {
            if (pos <= Cantidad())
            {
                if (pos == 1)
                {
                    _raiz = _raiz.sig;
                }
                else
                {
                    Nodo reco;
                    reco = _raiz;
                    for (int f = 1; f<= pos - 2; f++)
                    {
                        reco.sig = reco;
                    }

                    Nodo prox = reco.sig;
                    reco.sig = prox.sig;
                }
            }
        }

        public void Intercambiar(int pos1, int pos2)
        {
            if (pos1 <= Cantidad() && pos2 <= Cantidad())
            {
                Nodo reco1 = _raiz;
                
                for (int f=1; f< pos1; f++)
                {
                    reco1 = reco1.sig;
                }

                Nodo reco2 = _raiz;

                for (int f=1; f< pos2; f++)
                {
                    reco2 = reco2.sig;
                }

                int aux = reco1.info;
                reco1.info = reco2.info;
                reco2.info = aux;
            }
        }

        public int Mayor()
        {
            if (!Vacia())
            {
                int may = _raiz.info;

                Nodo reco = _raiz.sig;

                while (reco != null)
                {
                    if (reco.info > may)
                    {
                        may = reco.info;
                    }
                    reco = reco.sig;
                }
                return may;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public int PosMayor()
        {
            if(!Vacia())
            {
                int may = _raiz.info;
                int x = 1;
                int pos = 1;

                Nodo reco = _raiz.sig;

                while (reco != null)
                {
                    if (reco.info > may)
                    {
                        may = reco.info;
                        pos = x+1;                        
                    }
                    reco = reco.sig;
                    x++;
                }
                return pos;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public int Cantidad()
        {
            int cant = 0;
            Nodo reco = _raiz;

            while(reco != null)
            {
                reco = reco.sig;
                cant++;
            }
            return cant;
        }

        public bool Ordenada()
        {
            if (Cantidad() > 1)
            {
                Nodo reco1 = _raiz;
                Nodo reco2 = _raiz.sig;

                while(reco2 != null)
                {
                    if (reco2.info < reco1.info)
                    {
                        return false;
                    }
                    reco2 = reco2.sig;
                    reco1 = reco1.sig;  
                }               
            }
            return true;
        }

        public bool Existe(int x)
        {
            Nodo reco = _raiz;

            while(reco != null)
            {
                if (reco.info == x)
                {
                    return true;
                }
                reco = reco.sig;
            }
            return false;
        }

        public bool Vacia()
        {
            if (_raiz == null)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

        public void Imprimir()
        {
            Nodo reco = _raiz;

            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig;
            }
            Console.WriteLine();
        }
    }
}
