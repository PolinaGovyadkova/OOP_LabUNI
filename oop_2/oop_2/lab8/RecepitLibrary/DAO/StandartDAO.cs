using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace RecepitLibrary.DAO
{
    /// <summary>
    /// StandartDAO
    /// </summary>
    /// <seealso cref="System.IComparable{RecepitLibrary.DAO.StandartDAO}" />
    [Table(Name = "Standarts")]
    public class StandartDAO : IComparable<StandartDAO>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true, DbType = "int")]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the receipt date.
        /// </summary>
        /// <value>
        /// The receipt date.
        /// </value>
        [Column(Name = "ReceiptDate", DbType = "varchar(50)")]
        public string ReceiptDate { get; set; }

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        /// <value>
        /// The summary.
        /// </value>
        [Column(Name = "Summary", DbType = "float")]
        public float Summary { get; set; }
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
        public int CompareTo(StandartDAO other)
        {
            return Id.CompareTo(other.Id);
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
            return obj is StandartDAO dAO &&
                   Id == dAO.Id &&
                   ReceiptDate == dAO.ReceiptDate &&
                   Summary == dAO.Summary;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            var hashCode = 1384016374;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReceiptDate);
            hashCode = hashCode * -1521134295 + Summary.GetHashCode();
            return hashCode;
        }
    }
}
