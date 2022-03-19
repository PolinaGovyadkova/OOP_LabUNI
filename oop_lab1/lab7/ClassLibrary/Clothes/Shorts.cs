namespace Products
{
    /// <summary>
    /// Shorts
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Shorts : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shorts"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Shorts(string name, double cost, Dicount disc) : base("Шорты", cost, disc) { }
    }
}