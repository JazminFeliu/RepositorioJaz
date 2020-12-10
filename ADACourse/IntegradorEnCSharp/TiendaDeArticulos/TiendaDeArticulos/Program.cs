using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeArticulos
{
    class Program
    {
        static void Main(string[] args)
        {
            var tienda = new Tienda();
            string op = "S";

            while (op == "S")
            {
                tienda.IniciarTienda();
                tienda.DefinirArticulo();
                tienda.IngresarArticulo();
                tienda.VerArticulo();
                tienda.ActualizarArticulo();
                tienda.VerInventario();

                Console.Write("Desea continuar?(S/N)");
                op = Console.ReadLine();

            }
        }
    }
}
