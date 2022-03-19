using Array;
using System;

namespace ConsoleApp
{
    /// <summary>
    /// Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            int item, size_A, size_B, size_C;
            OneDimensionalArray ArrayA = new OneDimensionalArray("A");
            OneDimensionalArray ArrayB = new OneDimensionalArray("B");
            OneDimensionalArray ArrayC = new OneDimensionalArray("C");
            OneDimensionalArray MultiplicatoinAandC = new OneDimensionalArray("A*C");
            OneDimensionalArray MultiplicatoinAandB = new OneDimensionalArray("A*B");
            Console.WriteLine("Output and input of 3 arrays A, B, C");
            Console.Write("Array dimension A :\n");
            size_A = int.Parse(Console.ReadLine());
            ArrayA.GetDimensionalArray(size_A);
            Console.Write("\nOutput of array elements: \n");
            for (int i = 0; i < ArrayA.GetLength(); i++)
            {
                Console.WriteLine(ArrayA.array[i]);
            }
            Console.WriteLine("Calculating the number of negative elements in array A,next after the element with the given number; ");
            Console.WriteLine("Enter the item numder:");
            item = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\nNegative elements: {ArrayA.NegativElements(item)}\n");
            Console.Write("Array dimension B :\n");
            size_B = int.Parse(Console.ReadLine());
            ArrayB.GetDimensionalArray(size_B);
            Console.Write("\nOutput of array elements: \n");
            for (int i = 0; i < ArrayB.GetLength(); i++)
            {
                Console.WriteLine(ArrayB.array[i]);
            }
            Console.Write("Array dimension C :\n");
            size_C = int.Parse(Console.ReadLine());
            ArrayC.GetDimensionalArray(size_C);
            Console.Write("\nOutput of array elements: \n");
            for (int i = 0; i < ArrayC.GetLength(); i++)
            {
                Console.WriteLine(ArrayC.array[i]);
            }
            Console.WriteLine("Calculating the number of negative elements in array C,next after the element with the given number; ");
            Console.WriteLine("Enter the item numder:");
            item = Convert.ToInt32(Console.ReadLine());
            Console.Write($"\nNegative elements: {ArrayC.NegativElements(item)}\n");
            MultiplicatoinAandC = ArrayA * ArrayC;
            MultiplicatoinAandB = ArrayA * ArrayB;
            Console.WriteLine("\n1)Calculation of the number of negative elements of the array A * C;");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Write("Array dimension AC :\n");
            if (MultiplicatoinAandC.GetLength() == 0)
            {
                Console.WriteLine("\nIMPOSSIBLE");
            }
            else
            {
                for (int i = 0; i < MultiplicatoinAandC.GetLength(); i++)
                {
                    Console.WriteLine(MultiplicatoinAandC.array[i]);
                }
                Console.Write($"\nNegative elements: {MultiplicatoinAandC.NegativElements()}\n");
            }
            Console.WriteLine("2) Veli in the A * B array there are negative elements greater than -5.3,");
            Console.WriteLine("form an array of 500 elements, in where all ");
            Console.WriteLine("elements with numbers divisible by 10 are equal to 0, and the rest are equal");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Write("\nArray dimension AB :\n");
            if (MultiplicatoinAandB.GetLength() == 0)
            {
                Console.WriteLine("\nIMPOSSIBLE");
            }
            else
            {
                for (int i = 0; i < MultiplicatoinAandB.GetLength(); i++)
                {
                    Console.WriteLine(MultiplicatoinAandB.array[i]);
                }
                double[] array = MultiplicatoinAandB.ArrayAB();
                for (int i = 0; i <= 500; i++)
                {
                    Console.Write(i + " = " + array[i]);
                    Console.Write('\n');
                }
            }
            Console.ReadKey();
        }
    }
}