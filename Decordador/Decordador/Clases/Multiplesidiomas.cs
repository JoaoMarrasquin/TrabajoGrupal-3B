using Decordador.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decordador.Clases
{
    public class Multiplesidiomas: Decoradorweb
    {
        public Multiplesidiomas(IPaginaweb paginaweb) : base(paginaweb)
        {
        }
        public override string obtenerDescripcion()
        {
            return this.paginaweb.obtenerDescripcion() + "\n-------TIPOS DE IDIOMAS-------\n- " +
            "Español\n- Ruso\n- Italiano\n- Japones\n- Frànces\n";
        }
    }
}
