using System;

namespace Hello
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));      //convierte un int en string
            Console.WriteLine(Convert.ToDouble(myInt));     //convierte un int en double
            Console.WriteLine(Convert.ToInt32(myDouble));   //convierte un double en int
            Console.WriteLine(Convert.ToString(myBool));    //convierte un bool en string


        }

        // metodo para castear tipos de variable

       
    }
}
