namespace Integral
{
    /// <summary>
    ///
    /// </summary>
    public class Function
    {
        /// <summary>
        /// The x
        /// </summary>
        private double _x, _x1, _x2, _lower_limit, _upper_limit, _a, _b, _c, _number;

        /// <summary>
        /// Initializes a new instance of the <see cref="Function"/> class.
        /// </summary>
        /// <param name="lower_limit">The lower limit.</param>
        /// <param name="upper_limit">The upper limit.</param>
        public Function(double lower_limit, double upper_limit)
        {
            _lower_limit = lower_limit;
            _upper_limit = upper_limit;
        }

        /// <summary>
        /// Multiplications for cos.
        /// </summary>
        /// <param name="_numder">The numder.</param>
        /// <param name="lower_limit">The lower limit.</param>
        /// <param name="upper_limit">The upper limit.</param>
        /// <returns>The product of the cosine function by the number</returns>
        public double MultiplicationForCos(double _numder, double lower_limit, double upper_limit)
        {
            MainIntegral IntegralCos = new IntegralCos(lower_limit, upper_limit);
            return _numder * IntegralCos.Solve();
        }

        /// <summary>
        /// Multiplications the forl quad.
        /// </summary>
        /// <param name="_numder">The numder.</param>
        /// <param name="_lower_limit">The lower limit.</param>
        /// <param name="upper_limit">The upper limit.</param>
        /// <returns>The product of the quadratic function  function by the number</returns>
        public double MultiplicationForlQuad(double _numder, double _lower_limit, double upper_limit)
        {
            MainIntegral IntegralQuad = new IntegralQuad(_lower_limit, upper_limit);
            return _numder * IntegralQuad.Solve();
        }

        /// <summary>
        /// Multiplications for log.
        /// </summary>
        /// <param name="_numder">The numder.</param>
        /// <param name="lower_limit">The lower limit.</param>
        /// <param name="upper_limit">The upper limit.</param>
        /// <returns>The product of a logarithmic function by a number</returns>
        public double MultiplicationForLog(double _numder, double lower_limit, double upper_limit)
        {
            MainIntegral IntegralLog = new IntegralLog(lower_limit, upper_limit);
            return _numder * IntegralLog.Solve();
        }

        /// <summary>
        /// Sums for cos and log.
        /// </summary>
        /// <param name="lower_limit">The lower limit.</param>
        /// <param name="upper_limit">The upper limit.</param>
        /// <returns>The sum of the cosine and logarithm functions</returns>
        public double SumForCosAndLog(double lower_limit, double upper_limit)
        {
            MainIntegral IntegralLog = new IntegralLog(lower_limit, upper_limit);
            MainIntegral IntegralCos = new IntegralCos(lower_limit, upper_limit);
            return IntegralCos.Solve() + IntegralLog.Solve();
        }

        /// <summary>
        /// Sums for cos and quad.
        /// </summary>
        /// <param name="lower_limit">The lower limit.</param>
        /// <param name="upper_limit">The upper limit.</param>
        /// <returns>The sum of the cosine and quadratic functions</returns>
        public double SumForCosAndQuad(double lower_limit, double upper_limit)
        {
            MainIntegral IntegralQuad = new IntegralQuad(lower_limit, upper_limit);
            MainIntegral IntegralCos = new IntegralCos(lower_limit, upper_limit);
            return IntegralCos.Solve() + IntegralQuad.Solve();
        }

        /// <summary>
        /// Sums for log and quad.
        /// </summary>
        /// <param name="lower_limit">The lower limit.</param>
        /// <param name="upper_limit">The upper limit.</param>
        /// <returns>The sum of the logarithm and quadratic functions</returns>
        public double SumForLogAndQuad(double lower_limit, double upper_limit)
        {
            MainIntegral IntegralQuad = new IntegralQuad(lower_limit, upper_limit);
            MainIntegral IntegralLog = new IntegralLog(lower_limit, upper_limit);
            return IntegralLog.Solve() + IntegralQuad.Solve();
        }
    }
}