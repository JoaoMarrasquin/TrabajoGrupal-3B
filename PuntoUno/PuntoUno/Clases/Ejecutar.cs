using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno.Interfaces;
namespace PuntoUno.Clases
{
    public class Ejecutar: IBasededatos
    {
        public IOracle GetOracle()
        {
            return new ComandoOracle();
        }
        public ISqlServer GetSqlServer()
        {
            return new TransactSql();
        }
        public IPostgreSQL GetPostgreSQL()
        {
            return new Servidor();

        }
    }
}
