using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepitLibrary.DAO
{
    public interface IServicez
    {
        /// <summary>
        /// Метод, возращающий все записи операций
        /// </summary>
        /// <returns>Массив записей</returns>
        ServicezDAO[] GetAllServicez();
        /// <summary>
        /// Метод, возращающий запись операции
        /// </summary>
        /// <param name="id">Индефикатор записи</param>
        /// <returns>Запись</returns>
        ServicezDAO GetServicez(int id);
        /// <summary>
        /// Метод, возращающий запись породы
        /// </summary>
        /// <param name="servicez">Объект записи</param>
        /// <returns>Запись</returns>
        ServicezDAO GetServicez(ServicezDAO servicez);
        /// <summary>
        /// Вставка записи
        /// </summary>
        /// <param name="addServicez">Объект для добавления записи</param>
        /// <returns>Реакци. на добавление</returns>
        bool Insert(ServicezDAO addServicez);
        /// <summary>
        /// Обновление записи
        /// </summary>
        /// <param name="editServicez">Редактируемый объект</param>
        /// <param name="newServicez">Новый объект</param>
        /// <returns>Реакци. на добавление</returns>
        bool Update(ServicezDAO editServicez, ServicezDAO newServicez);
        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="deleteServicez">Объект для удаления</param>
        /// <returns>Реакци. на добавление</returns>
        bool Delete(ServicezDAO deleteServicez);
    }
}
