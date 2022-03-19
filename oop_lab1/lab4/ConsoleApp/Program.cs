using String;
using System;
using System.Text;

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
            StringBuilder[] array;
            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();
            StringWithNumbers Text = new StringWithNumbers(text);
            Console.WriteLine($"{Text.CharacterSearch(text)}");
            Console.WriteLine("\nВведите текст: ");
            string new_text;
            new_text = Console.ReadLine();
            array = Text.NumberOfLetters(new_text);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write('\n');
            }
            Console.ReadKey();
        }
    }
}