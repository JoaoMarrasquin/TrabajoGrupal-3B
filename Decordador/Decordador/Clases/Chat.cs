using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decordador.Interface;

namespace Decordador.Clases
{
    public class Chat: Decoradorweb
    {
        public Chat(IPaginaweb paginaweb) : base(paginaweb)
        {
        }
        public override string obtenerDescripcion()
        {
            return this.paginaweb.obtenerDescripcion() + "- Chat\n";
        }
    }
}
