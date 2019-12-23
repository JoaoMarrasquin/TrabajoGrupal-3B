using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno.Clases;
using PuntoUno.Interfaces;


namespace PuntoUno
{
    class Program
    {
        static void Main(string[] args)
        {
            IBasededatos conectarbasedatos = new Conectar();
            Paginaweb conectarpaginas = new Paginaweb(conectarbasedatos);

            Console.WriteLine("---------  CONECTAR PAGINAS WEB ---------");
            Console.WriteLine(conectarpaginas.MostrarOracle());
            Console.WriteLine(conectarpaginas.MostrarSQL());
            Console.WriteLine(conectarpaginas.MostrarPostgreSql());

            IBasededatos ejecutarbasedatos = new Ejecutar();
            Paginaweb ejecutarpaginas = new Paginaweb(ejecutarbasedatos);

            Console.WriteLine("---------  EJECUTAR PAGINAS WEB ---------");
            Console.WriteLine(ejecutarpaginas.MostrarOracle());
            Console.WriteLine(ejecutarpaginas.MostrarSQL());
            Console.WriteLine(ejecutarpaginas.MostrarPostgreSql());

            Console.ReadKey();
        }
    }
}
