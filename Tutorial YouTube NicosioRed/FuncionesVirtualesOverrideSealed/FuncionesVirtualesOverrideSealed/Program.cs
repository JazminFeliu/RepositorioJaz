using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesVirtualesOverrideSealed
{
    class Program
    {
        static void Main(string[] args)
        {
            var uno = new Producto("Bicicleta nacional", 50526.32);

            uno.CalcularPrecio();
            uno.MostrarVenta();

            Console.WriteLine("-------------------------------------");



            var dos = new ProductoImportado("Tesla Roster", 1568253.12, 0.15);

            dos.CalcularPrecio();
            dos.MostrarVenta();

            Console.WriteLine("-------------------------------------");

            var tres = new ProductoEnAduanaDetenido("Jeep Renegade", 1800000.60, 0.13, 114.10);

            tres.CalcularPrecio();
            tres.MostrarVenta();

            Console.WriteLine("-------------------------------------");

            var miProducto = new ProductoImportado("Inmueble Uruguay en dolares", 450000.30, 0.20);

            miProducto.CalcularPrecio();
            miProducto.MostrarVenta();

            Console.WriteLine("-------------------------------------");
            var p1 = new Producto("TV Smart Samsung", 10500);

            p1.CalcularPrecio();
            p1.MostrarVenta();

            Console.WriteLine("-------------------------------------");

            var  p3 = new ProductoImportado("Bicicleta", 2200, 0.20);

            p3.CalcularPrecio();
            p3.MostrarVenta();

            Console.WriteLine("-------------------------------------");


            Console.ReadKey();
        }
        
    }
}
