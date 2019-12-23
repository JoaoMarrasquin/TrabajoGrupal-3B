using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno.Interfaces;
namespace PuntoUno.Clases
{
    public class Psql: IPostgreSQL
    {
        public string GetDetalles()
        {
            return "POSGRESQL \n " +
                "Al conectar realiza transacciones eventuales consistentes y tendra un mayor rendimiento \n";
        }
    }
}
