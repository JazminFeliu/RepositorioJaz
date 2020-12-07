using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorHasta100
{
    class ContadorFor
    {
        static void Main(string[] args)
        {  
            for (int f = 1; f < 101; f++)
            {
                Console.Write($"{f}-");
            }
            Console.ReadKey();
        }

    }
}
