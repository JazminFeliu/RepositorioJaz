using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeArticulos
{
    public interface IArticulo
    {
        string Nombre { get; set; }
        void DefinirArticulo();
        void IngresarArticulo();
        void VerArticulo();
        void ActualizarArticulo();
        void VerInventario();
    }
}
