using Exeption;
using System;

namespace Integral
{
    /// <summary>
    /// MainIntegral
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
        /// Converts the cos.
        /// </summary>
        /// <param name="new_lower_limit">The new lower limit.</param>
        /// <param name="new_upper_limit">The new upper limit.</param>
        /// <returns></returns>
        /// <exception cref="IntegralExeption">Ошибка</exception>
        public static MainIntegral ConvertCos(string new_lower_limit, string new_upper_limit)
        {
            double up;
            double low;
            try
            {
                low = Convert.ToDouble(new_lower_limit);
                up = Convert.ToDouble(new_upper_limit);
            }
            catch
            {
                throw new IntegralExeption("Ошибка");
            }
            MainIntegral result = new IntegralCos(low, up);
            return result;
        }

        /// <summary>
        /// Converts the log.
        /// </summary>
        /// <param name="new_lower_limit">The new lower limit.</param>
        /// <param name="new_upper_limit">The new upper limit.</param>
        /// <returns></returns>
        /// <exception cref="IntegralExeption">Ошибка</exception>
        public static MainIntegral ConvertLog(string new_lower_limit, string new_upper_limit)
        {
            double up;
            double low;
            try
            {
                low = Convert.ToDouble(new_lower_limit);
                up = Convert.ToDouble(new_upper_limit);
            }
            catch
            {
                throw new IntegralExeption("Ошибка");
            }
            MainIntegral result = new IntegralLog(low, up);
            return result;
        }

        /// <summary>
        /// Converts the quad.
        /// </summary>
        /// <param name="new_lower_limit">The new lower limit.</param>
        /// <param name="new_upper_limit">The new upper limit.</param>
        /// <returns></returns>
        /// <exception cref="IntegralExeption">Ошибка</exception>
        public static MainIntegral ConvertQuad(string new_lower_limit, string new_upper_limit)
        {
            double up;
            double low;
            try
            {
                low = Convert.ToDouble(new_lower_limit);
                up = Convert.ToDouble(new_upper_limit);
            }
            catch
            {
                throw new IntegralExeption("Ошибка");
            }
            MainIntegral result = new IntegralQuad(low, up);
            return result;
        }

        /// <summary>
        /// Functions the specified x.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        public virtual double Func(double x)
        {
            return x;
        }

        /// <summary>
        /// Solves this instance.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Implements the operator +.
        /// </summary>
        /// <param name="integral">The integral.</param>
        /// <param name="integral1">The integral1.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static double operator +(MainIntegral integral, MainIntegral integral1)
        {
            return integral.Solve() + integral1.Solve();
        }

        /// <summary>
        /// Implements the operator *.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="integral">The integral.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static double operator *(double number, MainIntegral integral)
        {
            return number * integral.Solve();
        }

        public static string Result(string upper, string lower, string upper1, string lower1, string integral, string integral1)
        {
            if (integral == "lg(x)" && integral1 == "cos(x)")
            {
                MainIntegral integralLog = MainIntegral.ConvertLog(lower, upper);
                MainIntegral integralCos = MainIntegral.ConvertCos(lower1, upper1);
                return Convert.ToString(integralCos + integralLog);
            }
            else if (integral == "cos(x)" && integral1 == "lg(x)")
            {
                MainIntegral integralLog = MainIntegral.ConvertLog(lower1, upper1);
                MainIntegral integralCos = MainIntegral.ConvertCos(lower, upper);
                return Convert.ToString(integralCos + integralLog);
            }
            else if (integral == "x^2" && integral1 == "cos(x)")
            {
                MainIntegral integralQuad = MainIntegral.ConvertQuad(lower, upper);
                MainIntegral integralCos = MainIntegral.ConvertCos(lower1, upper1);
                return Convert.ToString(integralCos + integralQuad);
            }
            else if (integral == "cos(x)" && integral1 == "x^2")
            {
                MainIntegral integralQuad = MainIntegral.ConvertQuad(lower1, upper1);
                MainIntegral integralCos = MainIntegral.ConvertCos(lower, upper);
                return Convert.ToString(integralCos + integralQuad);
            }
            else if (integral == "cos(x)" && integral1 == "cos(x)")
            {
                MainIntegral integralCos = MainIntegral.ConvertCos(lower, upper);
                MainIntegral integralCos1 = MainIntegral.ConvertCos(lower1, upper1);
                return Convert.ToString(integralCos + integralCos1);
            }
            else if (integral == "x^2" && integral1 == "x^2")
            {
                MainIntegral integralQuad = MainIntegral.ConvertQuad(lower, upper);
                MainIntegral integralQuad1 = MainIntegral.ConvertQuad(lower1, upper1);
                return Convert.ToString(integralQuad1 + integralQuad);
            }
            else if (integral == "lg(x)" && integral1 == "x^2")
            {
                MainIntegral integralQuad = MainIntegral.ConvertQuad(lower1, upper1);
                MainIntegral integralLog = MainIntegral.ConvertLog(lower, upper);
                return Convert.ToString(integralLog + integralQuad);
            }
            else if (integral == "x^2" && integral1 == "lg(x)")
            {
                MainIntegral integralQuad = MainIntegral.ConvertQuad(lower, upper);
                MainIntegral integralLog = MainIntegral.ConvertLog(lower1, upper1);
                return Convert.ToString(integralQuad + integralLog);
            }
            else if (integral == "lg(x)" && integral1 == "lg(x)")
            {
                MainIntegral integralLog = MainIntegral.ConvertLog(lower, upper);
                MainIntegral integralLog1 = MainIntegral.ConvertLog(lower1, upper1);
                return Convert.ToString(integralLog1 + integralLog);
            }
            else throw new IntegralExeption("Укажите функцию");
        }
    }
}