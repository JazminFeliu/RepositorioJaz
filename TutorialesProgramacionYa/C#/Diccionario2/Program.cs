using System;
using System.Collections.Generic;

namespace Diccionario2
{
    class Producto
    {
        public String Descripcion { get; set; }
        public float Precio { get; set; }
    }
    class Program
    {              
        static void Main(string[] args)
        {
            var articulos = new Dictionary<int, Producto>();
            articulos[1] = new Producto { Descripcion = "Papas", Precio = 15.4f };
            articulos[2] = new Producto { Descripcion = "Manzanas", Precio = 142f };
            articulos[3] = new Producto { Descripcion = "Naranjas", Precio = 155f };

            foreach ( KeyValuePair<int, Producto> art in articulos )
            {
                Console.WriteLine(art.Key + " " + art.Value.Descripcion + " " + art.Value.Precio);
            }

            Console.WriteLine("Ingrese el codigo de producto a consultar: ");
            int codigo = int.Parse(Console.ReadLine());
            if (articulos.ContainsKey(codigo))
            {
                Console.WriteLine(articulos[codigo].Descripcion + " " + articulos[codigo].Precio);
            }
            else
            {
                Console.WriteLine("No existe un artículo con el código ingresado");
            }
            Console.ReadKey();
        }
    }
}
