using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problema.Interface;
namespace Problema.Clases
{
    public abstract class DecoradorVehiculo: IVehiculo
    {
        protected IVehiculo vehiculo1;

        public abstract string Descripcion();

        public DecoradorVehiculo(IVehiculo vehiculo)
        {
            this.vehiculo1 = vehiculo;
        }
    }
}
