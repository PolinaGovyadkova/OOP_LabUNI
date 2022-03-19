using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace People
{
    /// <summary>
    /// List of people
    /// </summary>
    public class ListOfPeople
    {
        /// <summary>
        /// The persons list
        /// </summary>
        public List<Person> personsList;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListOfPeople"/> class.
        /// </summary>
        public ListOfPeople()
        {
            personsList = new List<Person>();
        }

        /// <summary>
        /// Add new persons.
        /// </summary>
        public void Add()
        {
            int j = 0;
            string line;
            using (StreamReader sr = new StreamReader(@"..\..\bin\Debug\input.txt", Encoding.UTF8))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] word = line.Split(' ');
                    if (word[2] == "студент")
                    {
                        List<string> strMarks = new List<string>();
                        for (int i = 5; i < word.Length; i++)
                        {
                            strMarks.Add(word[i]);
                        }
                        List<double> marks = new List<double>();

                        foreach (string mark in strMarks)
                        {
                            marks.Add(Convert.ToDouble(mark));
                        }
                        personsList.Add(new Student(word[0], Convert.ToInt32(word[1]), word[2], word[3], word[4], marks.ToArray()));
                    }
                    else if (word[2] == "ученик")
                    {
                        List<string> strMarks = new List<string>();
                        for (int i = 5; i < word.Length; i++)
                        {
                            strMarks.Add(word[i]);
                        }
                        List<double> marks = new List<double>();
                        foreach (string mark in strMarks)
                        {
                            marks.Add(Convert.ToDouble(mark));
                        }
                        personsList.Add(new Pupil(word[0], Convert.ToInt32(word[1]), word[2], word[3], word[4], marks.ToArray()));
                    }
                    else
                    {
                        List<string> strMarks = new List<string>();
                        for (int i = 4; i < word.Length; i++)
                        {
                            strMarks.Add(word[i]);
                        }
                        List<double> marks = new List<double>();
                        foreach (string mark in strMarks)
                        {
                            marks.Add(Convert.ToDouble(mark));
                        }
                        personsList.Add(new Working(word[0], Convert.ToInt32(word[1]), word[2], word[3], marks.ToArray()));
                    }
                    j++;
                }
            }
        }

        /// <summary>
        /// Creates new person.
        /// </summary>
        /// <param name="surname">The surname.</param>
        /// <param name="data">The data.</param>
        /// <param name="status">The status.</param>
        /// <param name="place">The place.</param>
        /// <param name="group">The group.</param>
        /// <param name="array">The array.</param>
        public void NewPerson(string surname, int data, string status, string place, string group, string array)
        {
            StreamWriter writer = new StreamWriter(@"..\..\bin\Debug\input.txt", true, Encoding.UTF8);
            if (group == "")
            {
                writer.WriteLine(surname + " " + data + " " + status + " " + place + " " + array);
                writer.Close();
            }
            else
            {
                writer.WriteLine(surname + " " + data + " " + status + " " + place + " " + group + " " + array);
                writer.Close();
            }
        }

        /// <summary>Determines whether the specified text is information.</summary>
        /// <param name="surname"></param>
        /// <param name="data"></param>
        /// <param name="satatus"></param>
        /// <param name="plase"></param>
        /// <param name="group"></param>
        /// <returns>
        ///   <c>true</c> if the specified text is information; otherwise, <c>false</c>.</returns>
        public bool IsInfo(string surname, string data, string satatus, string plase, string group)
        {
            bool result;
            string pattern_for_status = @"[а-я]";
            string pattern_for_surname = @"^[А-Я][а-я]+(-[А-Я][а-я]+)?$";
            string pattern_for_data = @"\d+";
            if (Regex.IsMatch(satatus, pattern_for_status, RegexOptions.IgnoreCase))
            {
                if (satatus == "ученик")
                {
                    string pattern_for_plase = @"\S+";
                    string pattern_for_class = @"^\d{2}[A-ЯЁ]";
                    if (Regex.IsMatch(plase, pattern_for_plase, RegexOptions.IgnoreCase) && Regex.IsMatch(surname, pattern_for_surname, RegexOptions.IgnoreCase) && Regex.IsMatch(data, pattern_for_data, RegexOptions.IgnoreCase) &&
                        Regex.IsMatch(group, pattern_for_class, RegexOptions.IgnoreCase) && (Convert.ToDouble(data) <= 2020 && Convert.ToDouble(data) >= 1950)) result = true;
                    else result = false;
                    return result;
                }
                else if (satatus == "студент")
                {
                    string pattern_for_plase = @"\S+";
                    string pattern_for_class = @"^[A-ЯЁ]{1,}\-\d{2}$";
                    if (Regex.IsMatch(plase, pattern_for_plase, RegexOptions.IgnoreCase) && Regex.IsMatch(surname, pattern_for_surname, RegexOptions.IgnoreCase) && Regex.IsMatch(data, pattern_for_data, RegexOptions.IgnoreCase) &&
                        Regex.IsMatch(group, pattern_for_class, RegexOptions.IgnoreCase) && (Convert.ToDouble(data) <= 2020 && Convert.ToDouble(data) >= 1950)) result = true;
                    else result = false;
                    return result;
                }
                else
                {
                    string pattern_for_plase = @"\S+";
                    if (Regex.IsMatch(plase, pattern_for_plase, RegexOptions.IgnoreCase) && Regex.IsMatch(surname, pattern_for_surname, RegexOptions.IgnoreCase) && Regex.IsMatch(data, pattern_for_data, RegexOptions.IgnoreCase) &&
                        (Convert.ToDouble(data) <= 2020 && Convert.ToDouble(data) >= 1950)) result = true;
                    else result = false;
                    return result;
                }
            }
            else result = false;
            return result;
        }

        /// <summary>Determines whether the specified text is array.</summary>
        /// <param name="text">The text.</param>
        /// <returns>
        ///   <c>true</c> if the specified text is array; otherwise, <c>false</c>.</returns>
        public bool IsArray(string text)
        {
            bool result = false;
            string pattern_for_number = @"(\d{1,})";
            foreach (string element in text.Split(' '))
            {
                if (Regex.IsMatch(element, pattern_for_number, RegexOptions.IgnoreCase) == true) result = true;
                else result = false;
                return result;
            }
            return result;
        }
    }
}