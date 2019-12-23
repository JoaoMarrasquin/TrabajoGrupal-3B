using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decordador.Clases;
using Decordador.Interface;

namespace Decordador
{
    class Program
    {
        static void Main(string[] args)
        {
            Paginaweb paginapersonalizada = new Paginaweb();
            Chat comunicacion = new Chat(paginapersonalizada);
            Pagoenlinea transferencias = new Pagoenlinea(comunicacion);
            Login Cargando = new Login(transferencias);
            Multiplesidiomas idiomas = new Multiplesidiomas(transferencias);

            Console.WriteLine("\nLa página tiene las siguientes funcionalidades:\n");
            Console.WriteLine(idiomas.obtenerDescripcion());

            Console.ReadKey();
        }
    }
}
