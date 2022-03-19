namespace Products
{
    /// <summary>
    /// Hoodie
    /// </summary>
    /// <seealso cref="Products.Purchases" />
    public class Hoodie : Purchases
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hoodie"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="percent">The percent.</param>
        public Hoodie(string name, double cost, Dicount disc) : base("Худи", cost, disc) { }
    }
}