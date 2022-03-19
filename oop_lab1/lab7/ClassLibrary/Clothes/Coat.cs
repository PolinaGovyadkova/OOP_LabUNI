namespace Products
{
    /// <summary>
    /// Coat
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Coat : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coat"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Coat(string name, double cost, Dicount disc) : base("Пальто", cost, disc) { }
    }
}