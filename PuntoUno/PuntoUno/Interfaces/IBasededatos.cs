using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoUno.Interfaces
{
    public interface IBasededatos
    {
        IOracle GetOracle();
        IPostgreSQL GetPostgreSQL();
        ISqlServer GetSqlServer();
    }
}
