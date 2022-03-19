using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RecepitLibrary.DAO
{
    /// <summary>
    /// ServicezDAO
    /// </summary>
    /// <seealso cref="System.IComparable{RecepitLibrary.DAO.ServicezDAO}" />
    [Table(Name = "Servicez")]
    public class ServicezDAO : IComparable<ServicezDAO>
    {
        /// <summary>
        /// Gets or sets the service identifier.
        /// </summary>
        /// <value>
        /// The service identifier.
        /// </value>
        [Column(Name = "ServiceId", IsPrimaryKey = true, IsDbGenerated = true, DbType = "int")]
        public int ServiceId { get; set; }

        /// <summary>
        /// Gets or sets the name of the servicez.
        /// </summary>
        /// <value>
        /// The name of the servicez.
        /// </value>
        [Column(Name = "ServicezName", DbType = "varchar(50)")]
        public string ServicezName { get; set; }

        /// <summary>
        /// Gets or sets the standart identifier.
        /// </summary>
        /// <value>
        /// The standart identifier.
        /// </value>
        [Column(Name = "StandartId", DbType = "int")]
        public int StandartId { get; set; }

        /// <summary>
        /// Сравнивает текущий экземпляр с другим объектом того же типа и возвращает целое число, которое показывает, расположен ли текущий экземпляр перед, после или на той же позиции в порядке сортировки, что и другой объект.
        /// </summary>
        /// <param name="other">Объект для сравнения с данным экземпляром.</param>
        /// <returns>
        /// Значение, указывающее, каков относительный порядок сравниваемых объектов.
        /// Возвращаемые значения представляют следующие результаты сравнения.
        /// Значение
        /// Значение
        /// Меньше нуля
        /// Данный экземпляр предшествует параметру <paramref name="other" /> в порядке сортировки.
        /// Нуль
        /// В той же позиции в порядке сортировки, что происходит этот экземпляр <paramref name="other" />.
        /// Больше нуля
        /// Данный экземпляр следует за параметром <paramref name="other" /> в порядке сортировки.
        /// </returns>
        public int CompareTo(ServicezDAO other)
        {
            return ServiceId.CompareTo(other.ServiceId);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            return obj is ServicezDAO dAO &&
                   ServiceId == dAO.ServiceId &&
                   ServicezName == dAO.ServicezName &&
                   StandartId == dAO.StandartId;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            var hashCode = 153695222;
            hashCode = hashCode * -1521134295 + ServiceId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServicezName);
            hashCode = hashCode * -1521134295 + StandartId.GetHashCode();
            return hashCode;
        }
    }
}