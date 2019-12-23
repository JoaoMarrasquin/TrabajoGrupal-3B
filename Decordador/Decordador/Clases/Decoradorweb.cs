using Decordador.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decordador.Clases
{
    public abstract class Decoradorweb: Paginaweb
    {
            protected IPaginaweb paginaweb;
            public Decoradorweb(IPaginaweb paginaweb) { this.paginaweb = paginaweb; }
            public abstract string obtenerDescripcion();       
    }
}
