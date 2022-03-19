using RecepitLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepitLibrary.LINQ
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="RecepitLibrary.DAO.IStandarts" />
    public class Standart : IStandarts
    {
        /// <summary>
        /// The database
        /// </summary>
        private DataContext _database;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="connectionString">Строка подключеняия</param>
        public Standart(string connectionString)
        {
            _database = new DataContext(connectionString);
        }

        /// <summary>
        /// Метод, возращающий все записи стандартов
        /// </summary>
        /// <returns>
        /// Массив записей
        /// </returns>
        public StandartDAO[] GetAllStandarts()
        {
            Table<StandartDAO> dao = _database.GetTable<StandartDAO>();
            var list = from elements in dao select elements;
            List<StandartDAO> standarts = new List<StandartDAO>();
            foreach (StandartDAO standart in list)
            {
                standarts.Add(standart);
            }
            return standarts.ToArray();
        }

        /// <summary>
        /// Метод, возращающий запись стандарта
        /// </summary>
        /// <param name="id">Индефикатор записи</param>
        /// <returns>
        /// Запись
        /// </returns>
        public StandartDAO GetStandart(int id)
        {
            var list = from elements in _database.GetTable<StandartDAO>() where elements.Id == id select elements;
            return list.First();
        }

        /// <summary>
        /// Метод, возращающий запись стандарта
        /// </summary>
        /// <param name="standart">Объект записи</param>
        /// <returns>
        /// Запись
        /// </returns>
        public StandartDAO GetStandart(StandartDAO standart)
        {
            return GetStandart(standart.Id);
        }

        /// <summary>
        /// Вставка записи
        /// </summary>
        /// <param name="addStandart">Объект для добавления записи</param>
        /// <returns>
        /// Реакци. на добавление
        /// </returns>
        public bool Insert(StandartDAO addStandart)
        {
            _database.GetTable<StandartDAO>().InsertOnSubmit(addStandart);
            _database.SubmitChanges();
            var standarts = GetAllStandarts();
            addStandart.Id = standarts[standarts.Length - 1].Id;
            return true;
        }

        /// <summary>
        /// Обновление записи
        /// </summary>
        /// <param name="editStandart">Редактируемый объект</param>
        /// <param name="newStandart">Новый объект</param>
        /// <returns>
        /// Реакци. на добавление
        /// </returns>
        public bool Update(StandartDAO editStandart, StandartDAO newStandart)
        {
            _database.GetTable<StandartDAO>().DeleteOnSubmit(editStandart);
            _database.GetTable<StandartDAO>().InsertOnSubmit(newStandart);
            _database.SubmitChanges();
            var standarts = GetAllStandarts();
            newStandart.Id = standarts[standarts.Length - 1].Id;
            return true;
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="deleteStandart">Объект для удаления</param>
        /// <returns>
        /// Реакци. на добавление
        /// </returns>
        public bool Delete(StandartDAO deleteStandart)
        {
            _database.GetTable<StandartDAO>().DeleteOnSubmit(deleteStandart);
            _database.SubmitChanges();
            return true;
        }
    }
}

