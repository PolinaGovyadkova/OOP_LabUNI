using System;

namespace Integral
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Integral.MainIntegral" />
    public class IntegralLog : MainIntegral
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegralLog"/> class.
        /// </summary>
        /// <param name="lower_limit">The lower limit.</param>
        /// <param name="upper_limit">The upper limit.</param>
        public IntegralLog(double lower_limit, double upper_limit) : base(lower_limit, upper_limit)
        {
        }

        /// <summary>
        /// Functions the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns>
        /// Returns a log function
        /// </returns>
        public override double Func(double x)
        {
            return Math.Log10(x);
        }
    }
}