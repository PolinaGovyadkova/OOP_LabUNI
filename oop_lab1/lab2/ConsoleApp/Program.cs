using Integral;
using System;

namespace ConsoleApp
{
    /// <summary>
    ///   <br />
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            double y, number, lower_limit, upper_limit;
            Console.WriteLine("Enter lower limit:");
            lower_limit = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.WriteLine("Enter upper_limit:");
                upper_limit = Convert.ToDouble(Console.ReadLine());
            } while (upper_limit < lower_limit);

            Console.WriteLine("Enter upper limit:");
            Function Integral = new Function(lower_limit, upper_limit);
            MainIntegral IntegralCos = new IntegralCos(lower_limit, upper_limit);
            MainIntegral IntegralLog = new IntegralLog(lower_limit, upper_limit);
            MainIntegral IntegralQuad = new IntegralQuad(lower_limit, upper_limit);

            var resultCos = IntegralCos.Solve();
            var resultLog = IntegralLog.Solve();
            var resultQuad = IntegralQuad.Solve();
            Console.WriteLine("Select the function:");
            Console.WriteLine("1) y = cos(x)");
            Console.WriteLine("2) y = x^2");
            Console.WriteLine("3) y = log10x");
            y = Convert.ToInt64(Console.ReadLine());

            switch (y)
            {
                case 1:
                    {
                        Console.WriteLine($"∫cos(x)dx = {resultCos}");
                        Console.WriteLine("Enter a number to find the product of the integral and the number:");
                        number = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Result: {Integral.MultiplicationForCos(number, lower_limit, upper_limit)}");
                        Console.WriteLine("Enter the function that you would like to use to find the sum:");
                        Console.WriteLine("1) y = x^2");
                        Console.WriteLine("2) y = log10x");
                        y = Convert.ToInt64(Console.ReadLine());

                        switch (y)
                        {
                            case 1:
                                {
                                    Console.WriteLine($"∫(x^2)dx = {resultQuad}");
                                    Console.WriteLine($"Result: { Integral.SumForCosAndQuad(lower_limit, upper_limit)} ");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine($"∫log10x dx = {resultLog}");
                                    Console.WriteLine($"Result: { Integral.SumForCosAndLog(lower_limit, upper_limit)} ");
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"∫(x^2)dx = {resultQuad}");

                        Console.WriteLine("Enter a number to find the product of the integral and the number:");
                        number = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Result: {Integral.MultiplicationForlQuad(number, lower_limit, upper_limit)}");
                        Console.WriteLine("Enter the function that you would like to use to find the sum:");
                        Console.WriteLine("1) y = cos(x)");
                        Console.WriteLine("2) y = log10x");
                        y = Convert.ToInt64(Console.ReadLine());

                        switch (y)
                        {
                            case 1:
                                {
                                    Console.WriteLine($"∫cos(x)dx = {resultCos}");
                                    Console.WriteLine($"Result: { Integral.SumForCosAndQuad(lower_limit, upper_limit)}");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine($"∫log10x dx = {resultLog}");
                                    Console.WriteLine($"Result: { Integral.SumForLogAndQuad(lower_limit, upper_limit)} ");
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"∫log10x dx = {resultLog}");
                        Console.WriteLine("Enter a number to find the product of the integral and the number:");
                        number = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Result: {Integral.MultiplicationForLog(number, lower_limit, upper_limit)}");
                        Console.WriteLine("Enter the function that you would like to use to find the sum:");
                        Console.WriteLine("1) y = x^2");
                        Console.WriteLine("2) y = cos(x)");
                        y = Convert.ToInt64(Console.ReadLine());

                        switch (y)
                        {
                            case 1:
                                {
                                    Console.WriteLine($"∫(x^2)dx = {resultQuad}");
                                    Console.WriteLine($"Result: { Integral.SumForLogAndQuad(lower_limit, upper_limit)} ");
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine($"∫cos(x) dx = {resultCos}");
                                    Console.WriteLine($"Result: { Integral.SumForCosAndLog(lower_limit, upper_limit)} ");
                                    break;
                                }
                        }
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}