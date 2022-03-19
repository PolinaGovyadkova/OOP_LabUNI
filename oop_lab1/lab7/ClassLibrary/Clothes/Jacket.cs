namespace Products
{
    /// <summary>
    /// Jacket
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Jacket : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jacket"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Jacket(string name, double cost, Dicount disc) : base("Куртка", cost, disc) { }
    }
}