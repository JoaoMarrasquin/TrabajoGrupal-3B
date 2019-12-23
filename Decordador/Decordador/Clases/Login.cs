using Decordador.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decordador.Clases
{
    public class Login: Decoradorweb
    {
        public Login(IPaginaweb paginaweb) : base(paginaweb)
        {
        }
        public override string obtenerDescripcion()
        {
            return this.paginaweb.obtenerDescripcion() + "- Login\n";
        }
    }
}
