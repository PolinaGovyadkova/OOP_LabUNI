namespace Products
{
    /// <summary>
    /// NewProducts
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class NewProducts : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewProducts"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public NewProducts(string name, double cost, Dicount disc) : base(name, cost, disc)
        {
        }
    }
}