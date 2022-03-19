using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace String
{
    /// <summary>
    /// UserInfo
    /// </summary>
    public class CheckNumber
    {
        /// <summary>
        /// The number
        /// </summary>
        private string _number;

        /// <summary>
        /// Initializes a new instance of the <see cref="Number"/> class.
        /// </summary>
        /// <param name="number">The number.</param>
        public CheckNumber(string number)
        {
            this._number = number;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Number"/> class.
        /// </summary>
        public CheckNumber()
        {
        }

        /// <summary>
        /// Phones the number.
        /// </summary>
        /// <param name="phone">The phone.</param>
        /// <returns>Array with codes and countries</returns>
        public string PhoneNumber(string phone)
        {
            Dictionary Info = new Dictionary();
            StringBuilder new_text = new StringBuilder();
            string result = "";
            string phone_whith_code_1 = phone.Substring(0, phone.Length - 11);
            string phone_whith_code_2 = phone.Substring(0, phone.Length - 10);
            string phone_whith_code_3 = phone.Substring(0, phone.Length - 9);
            string phone_whith_code_4 = phone.Substring(0, phone.Length - 8);
            Dictionary<string, string> array = Info.CountriesWithCodes();
            foreach (KeyValuePair<string, string> keyValue in array)
            {
                try
                {
                    if (keyValue.Key == phone_whith_code_1 || keyValue.Key == phone_whith_code_2 || keyValue.Key == phone_whith_code_3 || keyValue.Key == phone_whith_code_4) result = phone + " - " + keyValue.Value;
                }
                catch
                {
                    result = "";
                }
            }
            new_text.Append(result);
            return new_text.ToString();
        }

        /// <summary>
        /// Determines whether the specified text is information.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>
        ///   <c>true</c> if the specified text is information; otherwise, <c>false</c>.
        /// </returns>
        public bool IsInfo(string text)
        {
            bool result = false;

            string pattern_for_email = @"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})";
            string pattern_for_nickname = @"([А-Я]{1}[а-я]{1,})";
            string pattern_for_phone = @"\d{1,3}[\-|\s]?\d{2}[\-|\s]?\d{3}[\-|\s]?\d{2}[\-|\s]?\d{2}";
            if (Regex.IsMatch(text, pattern_for_email, RegexOptions.IgnoreCase) || Regex.IsMatch(text, pattern_for_nickname, RegexOptions.IgnoreCase) || Regex.IsMatch(text, pattern_for_phone, RegexOptions.IgnoreCase)) result = true;
            else result = false;
            return result;
        }
    }
}