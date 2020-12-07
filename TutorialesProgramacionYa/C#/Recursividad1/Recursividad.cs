using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad1
{
    public class Recursividad
    {
        public void Imprimir(int x)
        {
            if(x>-10)
            {
                Imprimir(x - 1);
                Console.WriteLine(x);
            }
                  
        }
    }
}
