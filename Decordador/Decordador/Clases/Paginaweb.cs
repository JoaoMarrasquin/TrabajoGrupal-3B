using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decordador.Interface;

namespace Decordador.Clases
{
    public class Paginaweb : IPaginaweb
    {
        public string obtenerDescripcion()
        {
            return
                "> Color de fondo negro\n" +
                "> Link\n" +
                "> Publicidad\n" +
                "> Tipo de Letra normal\n" +
                "> Tamaño de letras 10\n";
        }
        internal static bool ObtenerDescripcion()
        {
            throw new NotImplementedException();
        }
    }
}
