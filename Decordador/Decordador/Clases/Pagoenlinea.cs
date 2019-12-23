using Decordador.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decordador.Clases
{
    public class Pagoenlinea: Decoradorweb
    {
        public Pagoenlinea(IPaginaweb paginaweb) : base(paginaweb)
        {
        }
        public override string obtenerDescripcion()
        {
            return this.paginaweb.obtenerDescripcion() + "- Pago en línea\n";
        }
    }
}
