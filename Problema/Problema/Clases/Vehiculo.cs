using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problema.Interface;
namespace Problema.Clases
{
   public class Vehiculo: IVehiculo
    {
        public string Descripcion()
        {
            return "Marca\n" +
                "Precio\n";
        }
    }
}
