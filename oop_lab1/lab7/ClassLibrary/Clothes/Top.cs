namespace Products
{
    /// <summary>
    /// Top
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Top : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Top"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Top(string name, double cost, Dicount disc) : base("Топ", cost, disc) { }
    }
}