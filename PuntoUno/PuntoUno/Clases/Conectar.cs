using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PuntoUno.Interfaces;

namespace PuntoUno.Clases
{
    public class Conectar : IBasededatos
    {
        public IOracle GetOracle()
        {
            return new Puerto();
        }
        public ISqlServer GetSqlServer()
        {
            return new Motor();
        }
        public IPostgreSQL GetPostgreSQL()
        {
            return new Psql();

        }
    }  
 }

