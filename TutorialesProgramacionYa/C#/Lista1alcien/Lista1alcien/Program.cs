using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1alcien
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            

            num = 1;

            while (num <=100)
            {
                Console.Write(num);
                Console.Write("-");
                num++;
            }

            Console.ReadKey();
        }
    }
}
