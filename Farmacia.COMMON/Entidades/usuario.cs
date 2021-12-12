using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacia.COMMON.Entidades
{
  public  class usuario:BaseDTO
    {
        public string NomUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Password { get; set; }
    }
}
