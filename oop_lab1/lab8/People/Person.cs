namespace People
{
    /// <summary>
    /// Person
    /// </summary>
    public abstract class Person
    {
        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        /// <value>
        /// The surname.
        /// </value>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public int Date { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }

        /// <summary>
        /// Informations this instance.
        /// </summary>
        /// <returns></returns>
        public abstract double Info();

        /// <summary>
        /// Displays this instance.
        /// </summary>
        /// <returns></returns>
        public virtual string Display()
        {
            string info = "Фамилия: " + Surname + ", Статус: " + Status + ", Дата рождения: " + Date.ToString() + ", Дата рождения: " + Info();
            return info;
        }
    }
}