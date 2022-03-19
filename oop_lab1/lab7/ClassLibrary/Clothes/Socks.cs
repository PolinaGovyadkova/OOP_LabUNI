namespace Products
{
    /// <summary>
    /// Socks
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Socks : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Socks"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Socks(string name, double cost, Dicount disc) : base("Носки", cost, disc) { }
    }
}