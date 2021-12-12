using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON.Entidades
{
   public class venta:BaseDTO
    {
        public int IdVenta { get; set; }
        public DateTime FechaHora { get; set; }
        public string NomUsuario { get; set; }
        public string cliente { get; set; }
    }
}
