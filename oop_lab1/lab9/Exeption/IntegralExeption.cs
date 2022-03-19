using System;

namespace Exeption
{
    /// <summary>
    /// IntegralExeption
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class IntegralExeption : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegralExeption"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public IntegralExeption(string text) : base(text)
        {
        }
    }
}