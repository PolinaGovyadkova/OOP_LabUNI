using System;

namespace InConsoleApplication
{
    /// <summary>
    ///   <br />
    /// </summary>
    public class Figure
    {
        private double _x1, _x2, _x3, _x4, _y1, _y2, _y3, _y4;

        /// <summary>Initializes a new instance of the <a onclick="return false;" href="Figure" originaltag="see">Figure</a> class.</summary>
        /// <param name="x1">The x1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="x3">The x3.</param>
        /// <param name="x4">The x4.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="y2">The y2.</param>
        /// <param name="y3">The y3.</param>
        /// <param name="y4">The y4.</param>
        public Figure(double x1, double x2, double x3, double x4, double y1, double y2, double y3, double y4)
        {
            _x1 = x1;
            _x2 = x2;
            _x3 = x3;
            _x4 = x4;
            _y1 = y1;
            _y2 = y2;
            _y3 = y3;
            _y4 = y4;
        }

        /// <summary>Gets the height of the parallelogram.</summary>
        /// <value>The height.</value>
        public double Height
        {
            get
            {
                return (_y2 - _y1);
            }
        }

        /// <summary>Gets the left side of the parallelogram.</summary>
        /// <value>The left side.</value>
        public double LeftSide
        {
            get
            {
                return Math.Round(Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(Height, 2)), 3);
            }
        }

        /// <summary>Gets the sin alpha of the parallelogram.</summary>
        /// <value>The sin alpha.</value>
        public double SinAlpha
        {
            get
            {
                return Math.Sin(Height / LeftSide);
            }
        }

        /// <summary>Gets the upper side of the parallelogram.</summary>
        /// <value>The upper side.</value>
        public double UpperSide
        {
            get
            {
                return Math.Round((_x3 - _x2), 3);
            }
        }

        /// <summary>Gets the right side of the parallelogram.</summary>
        /// <value>The right side.</value>
        public double RightSide
        {
            get
            {
                return Math.Round(Math.Sqrt(Math.Pow(_x3 - _x4, 2) + Math.Pow(Height, 2)), 3);
            }
        }

        /// <summary>Gets the cos betta of the parallelogram.</summary>
        /// <value>The cos betta.</value>
        public double CosBetta
        {
            get
            {
                return Math.Cos(Math.PI - SinAlpha);
            }
        }

        /// <summary>Gets the first diagonal of the parallelogram.</summary>
        /// <value>The first diagonal.</value>
        public double FirstDiagonal
        {
            get
            {
                return (Math.Sqrt(Math.Pow(LeftSide, 2) + Math.Pow(UpperSide, 2) - 2 * LeftSide * UpperSide * CosBetta));
            }
        }

        /// <summary>Gets the second diagonal of the parallelogram.</summary>
        /// <value>The second diagonal.</value>
        public double SecondDiagonal
        {
            get
            {
                return (Math.Sqrt(Math.Pow(LeftSide, 2) + Math.Pow(UpperSide, 2) + 2 * LeftSide * UpperSide * CosBetta));
            }
        }

        /// <summary>Gets the under side of the parallelogram.</summary>
        /// <value>The under side.</value>
        public double UnderSide
        {
            get
            {
                return Math.Round(Math.Sqrt((Math.Pow(FirstDiagonal, 2) + Math.Pow(SecondDiagonal, 2) - 2 * LeftSide * LeftSide) / 2), 3);
            }
        }

        /// <summary>Gets the perimeter of the parallelogram.</summary>
        /// <value>The perimeter.</value>
        public double Perimeter
        {
            get
            {
                return (2 * (LeftSide + UpperSide));
            }
        }

        /// <summary>Gets the square of the parallelogram.</summary>
        /// <value>The square.</value>
        public double Square
        {
            get
            {
                return (Height * UnderSide);
            }
        }

        /// <summary>Determines whether the specified figure is parallelogram.</summary>
        /// <param name="x1">The x1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="x3">The x3.</param>
        /// <param name="x4">The x4.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="y2">The y2.</param>
        /// <param name="y3">The y3.</param>
        /// <param name="y4">The y4.</param>
        /// <returns>
        ///   <c>true</c> if the specified figure is parallelogram; otherwise, <c>false</c>.</returns>
        public static bool IsParallelogram(double x1, double x2, double x3, double x4, double y1, double y2, double y3, double y4)
        {
            double coefficient_for_LeftSide = (y2 - y1) / (x2 - x1);
            double coefficient_for_RightSide = (y4 - y3) / (x4 - x3);
            double coefficient_for_UpperSide = (y3 - y2) / (x3 - x2);
            double coefficient_for_UnderSide = (y4 - y1) / (x4 - x1);
            return ((coefficient_for_LeftSide == coefficient_for_RightSide && coefficient_for_UpperSide == coefficient_for_UnderSide) && coefficient_for_LeftSide != coefficient_for_UpperSide);
        }

        /// <summary>Determines whether the specified (x0,y0) is belong.</summary>
        /// <param name="x0">The x0.</param>
        /// <param name="y0">The y0.</param>
        /// <param name="x1">The x1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="x3">The x3.</param>
        /// <param name="x4">The x4.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="y2">The y2.</param>
        /// <param name="y3">The y3.</param>
        /// <param name="y4">The y4.</param>
        /// <returns>
        ///   <c>true</c> if the specified (x0,y0) is belong; otherwise, <c>false</c>.</returns>
        public static bool IsBelong(double x0, double y0, double x1, double x2, double x3, double x4, double y1, double y2, double y3, double y4)
        {
            bool Flag;
            double point_for_LeftSide = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
            double point_for_UpperSide = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
            double point_for_RightSide = (x3 - x0) * (y4 - y3) - (x4 - x3) * (y3 - y0);
            double point_for_UnderSide = (x4 - x0) * (y1 - y4) - (x1 - x4) * (y4 - y0);
            if (point_for_LeftSide <= 0 && point_for_UpperSide <= 0 && point_for_RightSide <= 0 && point_for_UnderSide <= 0)
            {
                Flag = true;
            }
            else
            {
                Flag = false;
            }
            return Flag;
        }
    }
}