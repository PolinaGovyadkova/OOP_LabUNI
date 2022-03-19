using System;

namespace People
{
    /// <summary>
    /// Student
    /// </summary>
    /// <seealso cref="System.IComparable" />
    /// <seealso cref="People.Person" />
    public class StudentAndPupil : Person, IComparable
    {
        /// <summary>
        /// Gets or sets the marks array.
        /// </summary>
        /// <value>
        /// The marks array.
        /// </value>
        public double[] MarksArray { get; set; }

        /// <summary>
        /// Gets or sets the educational institution.
        /// </summary>
        /// <value>
        /// The educational institution.
        /// </value>
        public string EducationalInstitution { get; set; }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        public string Group { get; set; }

        /// <summary>
        /// Informations this instance.
        /// </summary>
        /// <returns></returns>
        public override double Info()
        {
            double sum = 0;
            int count = 0;
            foreach (int value in MarksArray)
            {
                count++;
                sum += value;
            }
            return Math.Round(sum / count, 2);
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        /// <returns></returns>
        public override string Display()
        {
            return base.Display();
        }

        /// <summary>
        /// Сравнивает текущий экземпляр с другим объектом того же типа и возвращает целое число, которое показывает, расположен ли текущий экземпляр перед, после или на той же позиции в порядке сортировки, что и другой объект.
        /// </summary>
        /// <param name="obj">Объект для сравнения с данным экземпляром.</param>
        /// <exception cref="ArgumentException">Object is not a StudentAndPupil</exception>
        int IComparable.CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is StudentAndPupil studentAndPupil)
                return this.Surname.CompareTo(studentAndPupil.Surname);
            else
                throw new ArgumentException("Object is not a StudentAndPupil");
        }
    }
}