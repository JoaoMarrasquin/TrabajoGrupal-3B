using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno.Interfaces;
namespace PuntoUno.Clases
{
    public class TransactSql: ISqlServer
    {
        public string GetDetalles()
        {
            return "SERVER SQL \n Ejecutado para manipular y recuperar datos \n Incluye " +
                "interfaces de acceso para varias plataformas de desarrollo \n ";
        }
    }
}
