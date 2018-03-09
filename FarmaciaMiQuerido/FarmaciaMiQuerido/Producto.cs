using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaMiQuerido
{
     public class Producto
    {
        public string Mercancia { get; set; }
        public string Categoria { get; set; }
        public string Descripcion { get; set; }
        public string PrecioV { get; set; }
        public string PrecioC { get; set; }
        public string ProductoE { get; set; }
        public override string ToString()
        {
            return string.Format("{0} ({1}) {2}", Mercancia, Categoria, Descripcion);
        }

    }
}
