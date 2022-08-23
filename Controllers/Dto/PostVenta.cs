using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prefinalentrega1.Dto
{
    public class PostVenta
    {
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public string Status { get; set; }
    }
}
