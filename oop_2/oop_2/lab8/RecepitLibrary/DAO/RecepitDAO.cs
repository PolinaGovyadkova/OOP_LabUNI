using System;
using System.Data.Linq.Mapping;

namespace RecepitLibrary.DAO
{
    /// <summary>
    /// RecepitDAO
    /// </summary>
    /// <seealso cref="System.IComparable{RecepitLibrary.DAO.RecepitDAO}" />
    [Table(Name = "Receipt")]
    public class RecepitDAO : IComparable<RecepitDAO>
    {
        /// <summary>
        /// Gets or sets the receipt identifier.
        /// </summary>
        /// <value>
        /// The receipt identifier.
        /// </value>
        [Column(Name = "ReceiptId", IsPrimaryKey = true, IsDbGenerated = true, DbType = "int")]
        public int ReceiptId { get; set; }

        /// <summary>
        /// Gets or sets the receipt number.
        /// </summary>
        /// <value>
        /// The receipt number.
        /// </value>
        [Column(Name = "ReceiptNumber", DbType = "int")]
        public int ReceiptNumber { get; set; }

        /// <summary>
        /// Gets or sets the service identifier.
        /// </summary>
        /// <value>
        /// The service identifier.
        /// </value>
        [Column(Name = "ServiceId", DbType = "int")]
        public int ServiceId { get; set; }

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
        public int CompareTo(RecepitDAO other)
        {
            return ReceiptId.CompareTo(other.ReceiptId);
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
            return obj is RecepitDAO dAO &&
                   ReceiptId == dAO.ReceiptId &&
                   ReceiptNumber == dAO.ReceiptNumber &&
                   ServiceId == dAO.ServiceId;
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
            hashCode = hashCode * -1521134295 + ReceiptId.GetHashCode();
            hashCode = hashCode * -1521134295 + ReceiptNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + ServiceId.GetHashCode();
            return hashCode;
        }
    }
}


