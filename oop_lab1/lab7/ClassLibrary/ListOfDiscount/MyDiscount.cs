namespace Products.Discount
{
    /// <summary>
    /// MyDiscount
    /// </summary>
    /// <seealso cref="Products.Dicount" />
    public class MyDiscount : Dicount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyDiscount"/> class.
        /// </summary>
        /// <param name="i">The i.</param>
        public MyDiscount(int i)
        {
            SetDicount(i);
        }
    }
}