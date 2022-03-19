using System;
using System.Diagnostics;

namespace InConsoleApplication
{
    /// <summary>
    ///   <br />
    /// </summary>
    internal class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            double x0, x1, x2, x3, x4, y0, y1, y2, y3, y4;

            Console.WriteLine("    B(x2,y2) ________________________________ C(x3,y3)");
            Console.WriteLine("           /                                /");
            Console.WriteLine("          /                                /");
            Console.WriteLine("         /                                /");
            Console.WriteLine("        /                                /");
            Console.WriteLine("A(x1,y1)______________________________  D(x4,y4)\n");

            Console.WriteLine("Enter coordinates (x1,y1)");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Enter coordinates (x2,y2)");
                x2 = Convert.ToDouble(Console.ReadLine());
                y2 = Convert.ToDouble(Console.ReadLine());
            } while (y1 >= y2);

            Console.WriteLine("Enter coordinates (x3,y3)");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Enter coordinates (x4,y4)");
                x4 = Convert.ToDouble(Console.ReadLine());
                y4 = Convert.ToDouble(Console.ReadLine());
            } while (y4 >= y3);

            Console.WriteLine("Enter coordinates of the point (x0,y0)");
            x0 = Convert.ToDouble(Console.ReadLine());
            y0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIs it a parallelogram?");
            if (Figure.IsParallelogram(x1, x2, x3, x4, y1, y2, y3, y4) == true)
            {
                Console.WriteLine("Yes\n");
            }
            else
            {
                Console.WriteLine("No\n");
                Console.ReadKey();
                Process.GetCurrentProcess().Kill();
            }

            Figure Parallelogram = new Figure(x1, x2, x3, x4, y1, y2, y3, y4);
            Console.WriteLine($"Side AB: { Parallelogram.LeftSide}");
            Console.WriteLine($"Side BC: { Parallelogram.UpperSide}");
            Console.WriteLine($"Side CD: { Parallelogram.RightSide}");
            Console.WriteLine($"Side DA: { Parallelogram.UnderSide}");
            Console.WriteLine($"Perimeter: { Parallelogram.Perimeter} = 2*({ Parallelogram.LeftSide} + { Parallelogram.UpperSide})");
            Console.WriteLine($"Square: { Parallelogram.Square} = { Parallelogram.Height} *{ Parallelogram.UnderSide} ");

            if (Figure.IsBelong(x0, y0, x1, x2, x3, x4, y1, y2, y3, y4) == true)
            {
                Console.WriteLine("Point belongs to the parallelogram\n");
            }
            else
                Console.WriteLine("Point dosen't belong to the parallelogram\n");

            Console.WriteLine("Bye:)");
            Console.ReadKey();
        }
    }
}