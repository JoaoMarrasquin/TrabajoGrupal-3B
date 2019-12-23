using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno.Interfaces;
namespace PuntoUno.Clases
{
    public class Servidor: IPostgreSQL
    {
        public string GetDetalles()
        {
            return " POSTGRES \n Al ejecutarse pueden ser escritos en varios lenguajes con la potencia que cada uno de ellos da\n " +
               " desde las operaciones básicas de programación hasta las complejidades de la programación orientada a objetos ";

        }
    }
}
