namespace Products
{
    /// <summary>
    /// Boots
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Boots : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boots"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Boots(string name, double cost, Dicount disc) : base("Ботинки", cost, disc) { }
    }
}