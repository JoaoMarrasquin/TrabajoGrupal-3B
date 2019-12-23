using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno.Interfaces;
namespace PuntoUno.Clases
{
    public class ComandoOracle: IOracle
    {
        public string GetDetalles()
        {
            return "ORACLE \n Para ejecutar debe introducir el bloque SQL o PL/ SQL en el editor de comandos \n " +
                "Se pueden ejecutar comandos tanto de lenguaje de manipulación de bases de datos (DML)\n";
        }
    }
}
