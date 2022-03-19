
using RecepitLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepitLibrary.LINQ
{
    /// <summary>
    /// Factory
    /// </summary>
    /// <seealso cref="RecepitLibrary.DAO.FactoryDAO" />
    public class Factory : FactoryDAO
    {
        /// <summary>
        /// The connection string
        /// </summary>
        private string _connectionString;
        /// <summary>
        /// Initializes a new instance of the <see cref="Factory"/> class.
        /// </summary>
        /// <param name="_connectionString">The connection string.</param>
        public Factory(string _connectionString)
        {
            this._connectionString = _connectionString;
        }

        /// <summary>
        /// Gets the standarts.
        /// </summary>
        /// <returns></returns>
        public override IStandarts GetStandarts()
        {
            return new Standart(_connectionString);
        }

        /// <summary>
        /// Gets the servicez.
        /// </summary>
        /// <returns></returns>
        public override IServicez GetServicez()
        {
            return new Servicez(_connectionString);
        }

        /// <summary>
        /// Gets the recepits.
        /// </summary>
        /// <returns></returns>
        public override IRecepit GetRecepits()
        {
            return new Recepits(_connectionString);
        }
    }
}
