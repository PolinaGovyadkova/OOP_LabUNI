namespace Products
{
    /// <summary>
    /// Hat
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Hat : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hat"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Hat(string name, double cost, Dicount disc) : base("Шапка", cost, disc) { }
    }
}