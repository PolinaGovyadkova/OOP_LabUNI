
using RecepitLibrary.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepitLibrary.DAO
{
    public abstract class FactoryDAO
    {
        public static FactoryDAO GetFactory(string connectionString)
        {

             return new Factory(connectionString);

        }
        public abstract IStandarts GetStandarts();
        public abstract IServicez GetServicez();
        public abstract IRecepit GetRecepits();
    }
    
}
