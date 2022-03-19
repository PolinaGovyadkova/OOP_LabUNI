using String;
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
            int number = 0;
            Console.WriteLine("Введите количество пользователей:");
            number = Convert.ToInt32(Console.ReadLine());
            string[] nickname = new string[number];
            string[] email = new string[number];
            string[] phone = new string[number];
            string[] text = new string[number];
            CheckNumber Info = new CheckNumber();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i + 1 + " пользватель");
                Console.WriteLine("Ник-нейм");
                nickname[i] = Convert.ToString(Console.ReadLine());
                //nickname[i] = "ник ник";
                while (true)
                {
                    if (Info.IsInfo(nickname[i]) == true)
                    {
                        Console.WriteLine("Ник-нейм подтвержден");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ник-нейм");
                        Console.WriteLine("Введите ник-нейм");
                        nickname[i] = Convert.ToString(Console.ReadLine());
                    }
                }
                Console.WriteLine("E-mail");
                email[i] = Convert.ToString(Console.ReadLine());
                //email[i] = "niknik821@gmail.com";
                while (true)
                {
                    if (Info.IsInfo(email[i]) == true)
                    {
                        Console.WriteLine("Email подтвержден");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный email");
                        Console.WriteLine("Введите E-mail");
                        email[i] = Convert.ToString(Console.ReadLine());
                    }
                }
                Console.WriteLine("Номер телефона (мобильный)");
                phone[i] = Convert.ToString(Console.ReadLine());
                //phone[i] = "+075445337922";
                while (true)
                {
                    if (Info.IsInfo(phone[i]) == true)
                    {
                        Console.WriteLine("Номер подтвержден");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Некорректный номер телефона");
                        Console.WriteLine("Введите номер телефона (мобильный)");
                        phone[i] = Convert.ToString(Console.ReadLine());
                    }
                }
                Console.WriteLine("Обращение к администарции");
                text[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("\n");
            }
            for (int i = 0; i < number; i++)
            {
                CheckNumber Number = new CheckNumber(phone[i]);
                Console.WriteLine(nickname[i] + ": " + Number.PhoneNumber(phone[i]));
            }
            Console.ReadKey();
        }
    }
}