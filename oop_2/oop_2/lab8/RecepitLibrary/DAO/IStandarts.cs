using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepitLibrary.DAO
{
    public interface IStandarts
    {
        /// <summary>
        /// Метод, возращающий все записи стандартов
        /// </summary>
        /// <returns>Массив записей</returns>
        StandartDAO[] GetAllStandarts();
        /// <summary>
        /// Метод, возращающий запись стандарта
        /// </summary>
        /// <param name="id">Индефикатор записи</param>
        /// <returns>Запись</returns>
        StandartDAO GetStandart(int id);
        /// <summary>
        /// Метод, возращающий запись стандарта
        /// </summary>
        /// <param name="standart">Объект записи</param>
        /// <returns>Запись</returns>
        StandartDAO GetStandart(StandartDAO standart);
        /// <summary>
        /// Вставка записи
        /// </summary>
        /// <param name="addStandart">Объект для добавления записи</param>
        /// <returns>Реакци. на добавление</returns>
        bool Insert(StandartDAO addStandart);
        /// <summary>
        /// Обновление записи
        /// </summary>
        /// <param name="editStandart">Редактируемый объект</param>
        /// <param name="newStandart">Новый объект</param>
        /// <returns>Реакци. на добавление</returns>
        bool Update(StandartDAO editStandart, StandartDAO newStandart);
        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="deleteStandart">Объект для удаления</param>
        /// <returns>Реакци. на добавление</returns>
        bool Delete(StandartDAO deleteStandart);
    }
}
