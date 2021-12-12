using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON.Entidades
{
   public class producto:BaseDTO
    {
        public int idProducto { get; set; }
        public string Nombre { get; set; }
        public decimal Costo { get; set; }
    }
}

