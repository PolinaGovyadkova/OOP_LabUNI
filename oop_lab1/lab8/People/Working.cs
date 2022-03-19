using System.Linq;

namespace People
{
    /// <summary>
    /// Working
    /// </summary>
    /// <seealso cref="People.Person" />
    public class Working : Person
    {
        /// <summary>
        /// Gets or sets the place of work.
        /// </summary>
        /// <value>
        /// The place of work.
        /// </value>
        public string PlaceOfWork { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        public double[] Salary { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Working"/> class.
        /// </summary>
        /// <param name="surname">The surname.</param>
        /// <param name="date">The date.</param>
        /// <param name="status">The status.</param>
        /// <param name="plase">The plase.</param>
        /// <param name="salary">The salary.</param>
        public Working(string surname, int date, string status, string plase, double[] salary)
        {
            Surname = surname;
            PlaceOfWork = plase;
            Position = status;
            Date = date;
            Salary = salary;
        }

        /// <summary>
        /// Informations this instance.
        /// </summary>
        /// <returns></returns>
        public override double Info()
        {
            double max_salary = Salary.Max();
            return max_salary;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        /// <returns></returns>
        public override string Display()
        {
            string info = "Фамилия: " + Surname + ", Место работы: " + PlaceOfWork + ", Статус: " + Position + ", Доп. информация: " + Info() + ", Дата рождения: " + Date.ToString();
            return info;
        }
    }
}