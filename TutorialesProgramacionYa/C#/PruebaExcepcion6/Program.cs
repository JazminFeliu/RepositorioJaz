using System;
using System.IO;

namespace PruebaExcepcion6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter txt = null;
            try
            {
                txt = new StreamWriter("datos.txt");
                txt.WriteLine("Linea 1");
                txt.WriteLine("Linea 2");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (txt !=null)
                {
                    txt.Close();
                }
            }

            StreamReader txtleer = null;
            try
            {
                txtleer = new StreamReader("datos.txt");
                string linea = txtleer.ReadLine();
                while(linea != null)
                {
                    Console.WriteLine(linea);
                    linea = txtleer.ReadLine();
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (txtleer != null)
                {
                    txtleer.Close();
                }
            }
            Console.ReadKey();
        }
    }
}
