using RecepitLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepitLibrary
{
    /// <summary>
    /// UnifyingRecepit
    /// </summary>
    public class UnifyingRecepit
    {
        /// <summary>
        /// Gets the standarts interface.
        /// </summary>
        /// <value>
        /// The standarts interface.
        /// </value>
        public IStandarts StandartsInterface { get; private set; }
        /// <summary>
        /// Gets the recepit interface.
        /// </summary>
        /// <value>
        /// The recepit interface.
        /// </value>
        public IRecepit RecepitInterface { get; private set; }
        /// <summary>
        /// Gets the servicez interface.
        /// </summary>
        /// <value>
        /// The servicez interface.
        /// </value>
        public IServicez ServicezInterface { get; private set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnifyingRecepit"/> class.
        /// </summary>
        /// <param name="factory">The factory.</param>
        public UnifyingRecepit(FactoryDAO factory)
        {
            RecepitInterface = factory.GetRecepits();
            ServicezInterface = factory.GetServicez();
            StandartsInterface = factory.GetStandarts();
        }
        /// <summary>
        /// Gets all records.
        /// </summary>
        /// <returns></returns>
        public List<Record> GetAllRecords()
        {
            List<Record> records = new List<Record>();
            var recepits = RecepitInterface.GetAllRecepits();
            foreach (var recepit in recepits)
            {
                var  servicez = ServicezInterface.GetServicez(recepit.ServiceId);
                var standart = StandartsInterface.GetStandart(servicez.StandartId);
                records.Add(new Record(recepit, servicez, standart));
            }

            return records;
        }
        /// <summary>
        /// Gets all servicez.
        /// </summary>
        /// <returns></returns>
        public List<RecordServicez> GetAllServicez()
        {
            List<RecordServicez> records = new List<RecordServicez>();
            var servicezs = ServicezInterface.GetAllServicez();
            foreach (var servicez in servicezs)
            {
                var standart = StandartsInterface.GetStandart(servicez.StandartId);
                records.Add(new RecordServicez(servicez, standart));
            }
            return records;
        }
    }
}

