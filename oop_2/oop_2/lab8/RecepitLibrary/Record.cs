using RecepitLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepitLibrary
{
    /// <summary>
    /// Record
    /// </summary>
    /// <seealso cref="System.IComparable{RecepitLibrary.Record}" />
    public class Record : IComparable<Record>
    {
        /// <summary>
        /// Gets the receipt identifier.
        /// </summary>
        /// <value>
        /// The receipt identifier.
        /// </value>
        public int ReceiptId { get; private set; }
        /// <summary>
        /// Gets the name of the servicez.
        /// </summary>
        /// <value>
        /// The name of the servicez.
        /// </value>
        public string ServicezName { get; private set; }
        /// <summary>
        /// Gets the service identifier.
        /// </summary>
        /// <value>
        /// The service identifier.
        /// </value>
        public int ServiceId { get; private set; }
        /// <summary>
        /// Gets the standart identifier.
        /// </summary>
        /// <value>
        /// The standart identifier.
        /// </value>
        public int StandartId { get; private set; }
        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; private set; }
        /// <summary>
        /// Gets the receipt date.
        /// </summary>
        /// <value>
        /// The receipt date.
        /// </value>
        public string ReceiptDate { get; private set; }
        /// <summary>
        /// Gets the summary.
        /// </summary>
        /// <value>
        /// The summary.
        /// </value>
        public float Summary { get; private set; }
        /// <summary>
        /// Gets the receipt number.
        /// </summary>
        /// <value>
        /// The receipt number.
        /// </value>
        public int ReceiptNumber { get; private set; }
        /// <summary>
        /// Gets the information.
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        public string Info { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Record"/> class.
        /// </summary>
        /// <param name="receipt">The receipt.</param>
        /// <param name="service">The service.</param>
        /// <param name="standart">The standart.</param>
        public Record(RecepitDAO receipt, ServicezDAO service, StandartDAO standart)
        {
            ReceiptId = receipt.ReceiptId;
            ReceiptNumber = receipt.ReceiptNumber;
            ServiceId = receipt.ServiceId;
            ServicezName = service.ServicezName;
            StandartId = service.StandartId;
            Summary = standart.Summary;
            ReceiptDate = standart.ReceiptDate;

            Info = $"№{ReceiptNumber}, Операция: {ServicezName}, Дата: {ReceiptDate}, Сумма: {Summary}.";
        }

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
        public int CompareTo(Record other)
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
            return obj is Record record &&
                   ReceiptId == record.ReceiptId &&
                   ReceiptNumber == record.ReceiptNumber &&
                   ServicezName == record.ServicezName &&
                   ReceiptDate == record.ReceiptDate &&
                   Id == record.Id &&
                   ServiceId == record.ServiceId &&
                   Summary == record.Summary;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            var hashCode = -2130739023;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + ServiceId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ServicezName);
            hashCode = hashCode * -1521134295 + Summary.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReceiptDate);
            hashCode = hashCode * -1521134295 + ReceiptNumber.GetHashCode();
            hashCode = hashCode * -1521134295 + ReceiptId.GetHashCode();
            return hashCode;
        }
    }
}
