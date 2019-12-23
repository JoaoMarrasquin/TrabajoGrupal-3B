using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno.Interfaces;

namespace PuntoUno.Clases
{
    public class Puerto: IOracle
    {
        public string GetDetalles()
        {
            return "Oracle \n " +
                "Conectada al puerto \n " +
                "Alta disponibilidad \n " +
                "Reducción de costos\n";
        }
    }
}
