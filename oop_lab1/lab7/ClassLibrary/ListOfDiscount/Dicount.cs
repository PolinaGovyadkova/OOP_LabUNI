namespace Products
{
    /// <summary>
    /// Dicount
    /// </summary>
    public class Dicount
    {
        /// <summary>
        /// Gets the percent.
        /// </summary>
        /// <value>
        /// The percent.
        /// </value>
        public int Percent { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dicount" /> class.
        /// </summary>
        public Dicount()
        {
            Percent = 0;
        }

        /// <summary>
        /// Sets the dicount.
        /// </summary>
        /// <param name="i">The i.</param>
        public void SetDicount(int i)
        {
            Percent = i;
        }
    }
}