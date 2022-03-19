namespace People
{
    /// <summary>
    /// Pupils
    /// </summary>
    /// <seealso cref="People.StudentAndPupil" />
    public class Pupil : StudentAndPupil
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pupil"/> class.
        /// </summary>
        /// <param name="surname">The surname.</param>
        /// <param name="date">The date.</param>
        /// <param name="status">The status.</param>
        /// <param name="plase">The plase.</param>
        /// <param name="group">The group.</param>
        /// <param name="salary">The salary.</param>
        public Pupil(string surname, int date, string status, string plase, string group, double[] salary)
        {
            Surname = surname;
            EducationalInstitution = plase;
            Group = group;
            Status = status;
            Date = date;
            MarksArray = salary;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        /// <returns></returns>
        public override string Display()
        {
            string info = "Фамилия: " + Surname + ", Школа: " + EducationalInstitution + ", Класс: " + Group + ", Статус: " + Status + ", Доп. информация: " + Info() + ", Дата рождения: " + Date.ToString();
            return info;
        }
    }
}