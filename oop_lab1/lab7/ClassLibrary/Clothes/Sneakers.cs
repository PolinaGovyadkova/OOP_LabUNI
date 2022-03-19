namespace Products
{
    /// <summary>
    /// Sneakers
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Sneakers : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sneakers"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Sneakers(string name, double cost, Dicount disc) : base("Кроссовки", cost, disc) { }
    }
}