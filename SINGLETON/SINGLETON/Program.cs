using System;
using SINGLETON.Clases;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINGLETON
{
    class Program
    {
        static void Main(string[] args)
        {
            Basededatos dato = new Basededatos("SQL SERVER");
            Basededatos dato1 = new Basededatos("ORACLE");
            Basededatos dato2 = new Basededatos("POST SQL");

            Singleton.Instancia.Basedatos = new List<Basededatos>();

            Singleton.Instancia.Basedatos.Add(dato);
            Singleton.Instancia.Basedatos.Add(dato1);
            Singleton.Instancia.Basedatos.Add(dato2);

            foreach (Basededatos item in Singleton.Instancia.Basedatos)
            {
                Console.WriteLine(item.Mostrar());
            }
            Console.ReadKey();
        }
    }
}
