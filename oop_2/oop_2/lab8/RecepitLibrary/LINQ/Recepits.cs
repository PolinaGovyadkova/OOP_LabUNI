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
    /// Recepits
    /// </summary>
    /// <seealso cref="RecepitLibrary.DAO.IRecepit" />
    public class Recepits : IRecepit
    {
        /// <summary>
        /// The database
        /// </summary>
        private DataContext _database;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="connectionString">Строка подключения</param>
        public Recepits(string connectionString)
        {
            _database = new DataContext(connectionString);
        }

        /// <summary>
        /// Метод, возращающий все записи рецептов
        /// </summary>
        /// <returns>
        /// Массив записей
        /// </returns>
        public RecepitDAO[] GetAllRecepits()
        {
            var list = from element in _database.GetTable<RecepitDAO>() select element;
            List<RecepitDAO> recepits = new List<RecepitDAO>();
            foreach (RecepitDAO recepit in list)
            {
                recepits.Add(recepit);
            }
            return recepits.ToArray();
        }
        /// <summary>
        /// Метод, возращающий запись рецепта
        /// </summary>
        /// <param name="id">Индефикатор записи</param>
        /// <returns>
        /// Запись
        /// </returns>
        public RecepitDAO GetRecepit(int id)
        {
            var list = from element in _database.GetTable<RecepitDAO>() where element.ReceiptId == id select element;
            return list.First();
        }
        /// <summary>
        /// Gets the recepit.
        /// </summary>
        /// <param name="recepit">The recepit.</param>
        /// <returns></returns>
        public RecepitDAO GetRecepit(RecepitDAO recepit)
        {
            return GetRecepit(recepit.ReceiptId);
        }
        /// <summary>
        /// Inserts the specified add receipt.
        /// </summary>
        /// <param name="addReceipt">The add receipt.</param>
        /// <returns></returns>
        public bool Insert(RecepitDAO addReceipt)
        {
            _database.GetTable<RecepitDAO>().InsertOnSubmit(addReceipt);
            _database.SubmitChanges();
            var recepits = GetAllRecepits();
            addReceipt.ReceiptId = recepits[recepits.Length - 1].ReceiptId;
            return true;
        }

        /// <summary>
        /// Updates the specified edit recepit.
        /// </summary>
        /// <param name="editRecepit">The edit recepit.</param>
        /// <param name="newRecepit">The new recepit.</param>
        /// <returns></returns>
        public bool Update(RecepitDAO editRecepit, RecepitDAO newRecepit)
        {
            _database.GetTable<RecepitDAO>().DeleteOnSubmit(editRecepit);
            _database.GetTable<RecepitDAO>().InsertOnSubmit(newRecepit);
            _database.SubmitChanges();
            var recepits = GetAllRecepits();
            newRecepit.ReceiptId = recepits[recepits.Length - 1].ReceiptId;
            return true;
        }

        /// <summary>
        /// Deletes the specified delete recepit.
        /// </summary>
        /// <param name="deleteRecepit">The delete recepit.</param>
        /// <returns></returns>
        public bool Delete(RecepitDAO deleteRecepit)
        {
            _database.GetTable<RecepitDAO>().DeleteOnSubmit(deleteRecepit);
            _database.SubmitChanges();
            return true;
        }
    }
}
