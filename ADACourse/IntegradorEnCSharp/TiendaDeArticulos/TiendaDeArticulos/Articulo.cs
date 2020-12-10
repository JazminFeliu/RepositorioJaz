using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeArticulos
{
    public class Articulo : IArticulo
    {
        public string Nombre { get; set; }

        public abstract void DefinirArticulo();
        public abstract void IngresarArticulo();
        public abstract void VerArticulo();
        public abstract void ActualizarArticulo();
        public abstract void VerInventario();
    }
}
