using RecepitLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepitLibrary.LINQ
{
    /// <summary>
    /// Servicez
    /// </summary>
    /// <seealso cref="RecepitLibrary.DAO.IServicez" />
    public class Servicez : IServicez
    {
        /// <summary>
        /// The database
        /// </summary>
        private DataContext _database;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="connectionString">Строка подключения</param>
        public Servicez(string connectionString)
        {
            _database = new DataContext(connectionString);
        }

        /// <summary>
        /// Метод, возращающий все записи операций
        /// </summary>
        /// <returns>
        /// Массив записей
        /// </returns>
        public ServicezDAO[] GetAllServicez()
        {
            var list= from elements in _database.GetTable<ServicezDAO>() select elements;
            List<ServicezDAO> servicezs = new List<ServicezDAO>();
            foreach (ServicezDAO servicez in list)
            {
                servicezs.Add(servicez);
            }
            return servicezs.ToArray();
        }

        /// <summary>
        /// Метод, возращающий запись операции
        /// </summary>
        /// <param name="id">Индефикатор записи</param>
        /// <returns>
        /// Запись
        /// </returns>
        public ServicezDAO GetServicez(int id)
        {
            var list = from elements in _database.GetTable<ServicezDAO>() where elements.ServiceId == id select elements;
            return list.First();
        }
        /// <summary>
        /// Метод, возращающий запись операции
        /// </summary>
        /// <param name="servicez">Объект записи</param>
        /// <returns>
        /// Запись
        /// </returns>
        public ServicezDAO GetServicez(ServicezDAO servicez)
        {
            return GetServicez(servicez.ServiceId);
        }
        /// <summary>
        /// Inserts the specified add service.
        /// </summary>
        /// <param name="addService">The add service.</param>
        /// <returns></returns>
        public bool Insert(ServicezDAO addService)
        {
            _database.GetTable<ServicezDAO>().InsertOnSubmit(addService);
            _database.SubmitChanges();
            var servicezs = GetAllServicez();
            addService.ServiceId = servicezs[servicezs.Length - 1].ServiceId;
            return true;
        }

        /// <summary>
        /// Updates the specified edit service.
        /// </summary>
        /// <param name="editService">The edit service.</param>
        /// <param name="newService">The new service.</param>
        /// <returns></returns>
        public bool Update(ServicezDAO editService, ServicezDAO newService)
        {
            _database.GetTable<ServicezDAO>().DeleteOnSubmit(editService);
            _database.GetTable<ServicezDAO>().InsertOnSubmit(newService);
            _database.SubmitChanges();
            var breeds = GetAllServicez();
            newService.ServiceId = breeds[breeds.Length - 1].ServiceId;
            return true;
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="deleteServicez">Объект для удаления</param>
        /// <returns>
        /// Реакци. на добавление
        /// </returns>
        public bool Delete(ServicezDAO deleteServicez)
        {
            _database.GetTable<ServicezDAO>().DeleteOnSubmit(deleteServicez);
            _database.SubmitChanges();
            return true;
        }
    }
}

