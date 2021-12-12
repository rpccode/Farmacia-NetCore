using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON.Entidades
{
   public class productoVendido:BaseDTO
    {
        public int IdProductoVendido { get; set; }
        public int idVenta { get; set; }
        public int idProducto { get; set; }
        public decimal Costo { get; set; }
        public int Cantidad { get; set; }
    }
}
