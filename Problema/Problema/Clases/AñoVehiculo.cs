using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problema.Interface;

namespace Problema.Clases
{
    public class AñoVehiculo: DecoradorVehiculo
    {
        public AñoVehiculo(IVehiculo vehiculo): base(vehiculo)
        {

        }
        public override string Descripcion()
        {
            return this.vehiculo1.Descripcion() + "Año del vehículo\n";
        }
    }
}
