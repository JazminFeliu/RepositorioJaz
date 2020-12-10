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

            int stock = tienda.DefinirStock();

            for (int cont = 1; cont <= stock; cont++)
            {
                int opcionElegida = tienda.IniciarTienda();

                switch (opcionElegida)
                {
                    case 0:
                        tienda.DefinirArticulo();
                        tienda.IngresarArticulo();
                        break;
                    case 1:
                        tienda.VerArticulo();
                        break;
                    case 2:
                        tienda.VerInventario();
                        break;
                    case 3:
                        tienda.ActualizarArticulo();
                        break;
                    case 4:
                        Console.WriteLine("Gracias por utilizar la Tienda de Articulos");
                        cont = stock;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion correcta");
                        cont = cont - 1;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
