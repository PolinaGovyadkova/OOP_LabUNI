using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepitLibrary.DAO
{
    public interface IRecepit
    {
        /// <summary>
        /// Метод, возращающий все записи рецептов
        /// </summary>
        /// <returns>Массив записей</returns>
        RecepitDAO[] GetAllRecepits();
        /// <summary>
        /// Метод, возращающий запись рецепта
        /// </summary>
        /// <param name="id">Индефикатор записи</param>
        /// <returns>Запись</returns>
        RecepitDAO GetRecepit(int id);
        /// <summary>
        /// Метод, возращающий запись рецепта
        /// </summary>
        /// <param name="receipt">Объект записи</param>
        /// <returns>Запись</returns>
        RecepitDAO GetRecepit(RecepitDAO receipt);
        /// <summary>
        /// Вставка записи
        /// </summary>
        /// <param name="addStandart">Объект для добавления записи</param>
        /// <returns>Реакци. на добавление</returns>
        bool Insert(RecepitDAO addStandart);
        /// <summary>
        /// Обновление записи
        /// </summary>
        /// <param name="editReceipt">Редактируемый объект</param>
        /// <param name="newReceipt">Новый объект</param>
        /// <returns>Реакци. на добавление</returns>
        bool Update(RecepitDAO editReceipt, RecepitDAO newReceipt);
        /// <summary>
        /// Удаление рецепта
        /// </summary>
        /// <param name="deleteReceipt">Объект для удаления</param>
        /// <returns>Реакци. на добавление</returns>
        bool Delete(RecepitDAO deleteReceipt);
    }
}
