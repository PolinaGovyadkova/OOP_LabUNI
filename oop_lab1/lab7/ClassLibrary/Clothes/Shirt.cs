namespace Products
{
    /// <summary>
    /// Shirt
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Shirt : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Shirt"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Shirt(string name, double cost, Dicount disc) : base("Рубашка", cost, disc) { }
    }
}