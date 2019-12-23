using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problema.Interface;
namespace Problema.Clases
{
    public class ModeloVehiculo: DecoradorVehiculo
    {
        public ModeloVehiculo(IVehiculo vehiculo) : base(vehiculo)
        {

        }
        public override string Descripcion()
        {
            return this.vehiculo1.Descripcion() + "Modelo del vehículo";
        }
    }
}
