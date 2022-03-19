namespace Products
{
    /// <summary>
    /// Jeans
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Jeans : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jeans"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Jeans(string name, double cost, Dicount disc) : base("Джинсы", cost, disc) { }
    }
}