using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno.Interfaces;
namespace PuntoUno.Clases
{
    public class Paginaweb
    {
        IOracle Ioracle;
        ISqlServer Iseversql;
        IPostgreSQL Ipostgresql;
        public Paginaweb(IBasededatos factory)
        {
            Ioracle = factory.GetOracle();
            Iseversql = factory.GetSqlServer();
            Ipostgresql = factory.GetPostgreSQL();
        }
        public string MostrarOracle()
        {
            return Ioracle.GetDetalles();
        }
        public string MostrarSQL()
        {
            return Iseversql.GetDetalles();
        }
        public string MostrarPostgreSql()
        {
            return Ipostgresql.GetDetalles();
        }
    }
}
