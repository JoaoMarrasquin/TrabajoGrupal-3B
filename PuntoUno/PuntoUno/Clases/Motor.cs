using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno.Interfaces;
namespace PuntoUno.Clases
{
    public class Motor: ISqlServer
    {
        public string GetDetalles()
        {
            return "SERVER SQL \n Conectada permite habilitar protocolos de servidor \n " +
                "Configura opciones de protocolo por ejemplo los puertos TCP\n";
        }
    }
}
