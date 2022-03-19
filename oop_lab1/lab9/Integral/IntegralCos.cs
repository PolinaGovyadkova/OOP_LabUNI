using System;

namespace Integral
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Integral.MainIntegral" />
    public class IntegralCos : MainIntegral
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegralCos"/> class.
        /// </summary>
        /// <param name="lower_limit">The lower limit.</param>
        /// <param name="upper_limit">The upper limit.</param>
        public IntegralCos(double lower_limit, double upper_limit) : base(lower_limit, upper_limit)
        {
        }

        /// <summary>
        /// Functions the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns>
        /// Returns a cos function
        /// </returns>
        public override double Func(double x)
        {
            return Math.Cos(x);
        }
    }
}