using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico2
{
    internal class Articulo
    {
        public int Id { get; set; }
        public string CodArt { get; set; }
        public string Nombre { get; set; }
        public string  Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public int IdImagen { get; set; }
        public float Precio { get; set; }
    }
}

