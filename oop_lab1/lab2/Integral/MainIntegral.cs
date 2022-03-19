namespace Integral
{
    /// <summary>
    ///
    /// </summary>
    public class MainIntegral
    {
        /// <summary>
        /// The lower limit
        /// </summary>
        private double _lower_limit;

        /// <summary>
        /// The upper limit
        /// </summary>
        private double _upper_limit;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainIntegral"/> class.
        /// </summary>
        /// <param name="lower_limit">The lower limit.</param>
        /// <param name="upper_limit">The upper limit.</param>
        public MainIntegral(double lower_limit, double upper_limit)
        {
            _lower_limit = lower_limit;
            _upper_limit = upper_limit;
        }

        /// <summary>
        /// Functions the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns> Returns a linear function</returns>
        public virtual double Func(double x)
        {
            return x;
        }

        /// <summary>
        /// Solves this instance.
        /// </summary>
        /// <returns>Returns the result of evaluating an integral</returns>
        public double Solve()
        {
            double sum = 0;
            double h = (_upper_limit - _lower_limit) / 1000;
            for (int i = 0; i < 1000; ++i)
            {
                double x = _lower_limit + i * h;
                sum += Func(x);
            }
            double result = h * sum;
            return result;
        }
    }
}