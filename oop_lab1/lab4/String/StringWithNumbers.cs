using System;
using System.Text;
using System.Text.RegularExpressions;

namespace String
{
    /// <summary>
    /// StringWithNumbers
    /// </summary>
    public class StringWithNumbers
    {
        /// <summary>
        /// The text
        /// </summary>
        private string _text;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringWithNumbers"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public StringWithNumbers(string text)
        {
            this._text = text;
        }

        /// <summary>
        /// Search for characters in a string.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>Arithmetic expressions</returns>
        public string CharacterSearch(string text)
        {
            text = text.Replace(" ", "");
            var separators = Regex.Matches(text, @"(\d+)([+\-*/])(\d+)");
            var new_text = new StringBuilder();
            var result = 0;
            foreach (Match i in separators)
            {
                new_text.Append(i + "=");
                switch (i.Groups[2].ToString())
                {
                    case "*":
                        {
                            result = int.Parse(i.Groups[1].ToString()) * int.Parse(i.Groups[3].ToString());
                            break;
                        }
                    case "/":
                        {
                            result = int.Parse(i.Groups[1].ToString()) / int.Parse(i.Groups[3].ToString());
                            break;
                        }
                    case "+":
                        {
                            result = int.Parse(i.Groups[1].ToString()) + int.Parse(i.Groups[3].ToString());
                            break;
                        }
                    case "-":
                        {
                            result = int.Parse(i.Groups[1].ToString()) - int.Parse(i.Groups[3].ToString());
                            break;
                        }
                }
                new_text.Append(result + "\n");
            }
            return new_text.ToString();
        }

        /// <summary>
        /// Numbers of the letters.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>Numbers of the letters in rhe string</returns>
        public StringBuilder[] NumberOfLetters(string text)
        {
            char[] alphabet = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            text = text.Replace(" ", "").ToLower();
            int[] count = new int[33];

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (text[i] == alphabet[j])
                    {
                        count[j]++;
                    }
                }
            }
            StringBuilder[] array = new StringBuilder[alphabet.Length];
            for (int j = 0, i = 0; j < alphabet.Length; j++, i++)
            {
                if (alphabet[j] == 'а' || alphabet[j] == 'о' || alphabet[j] == 'у' || alphabet[j] == 'ы' || alphabet[j] == 'э' || alphabet[j] == 'я' || alphabet[j] == 'ё' || alphabet[j] == 'е' || alphabet[j] == 'ю' || alphabet[j] == 'и')
                {
                    array[i] = new StringBuilder("Гласная буква " + alphabet[j] + " встречается " + Convert.ToString(count[j]) + " раз(а) ");
                }
                else array[i] = new StringBuilder("Согласная буква " + alphabet[j] + " встречается " + Convert.ToString(count[j]) + " раз(а) ");
            }
            return array;
        }
    }
}