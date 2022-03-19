using Exeption;
using Integral;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для Multiplication.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class Multiplication : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Multiplication"/> class.
        /// </summary>
        public Multiplication()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string upper = Upper.Text;
                string lower = Lower.Text;
                string upper1 = Upper1.Text;
                string lower1 = Lower1.Text;

                if (upper == "" && lower == "" && upper1 == "" && lower1 == "") throw new IntegralExeption("Введите данные");
                else
                {
                    if (Convert.ToDouble(lower) > Convert.ToDouble(upper) || (Convert.ToDouble(lower1) > Convert.ToDouble(upper1)))
                    {
                        Upper.Text = "";
                        Lower.Text = "";
                        Upper1.Text = "";
                        Lower1.Text = "";
                        throw new IntegralExeption("Верхний предел должен быть больше нижнего");
                    }
                    else
                    {
                        string integral = List.Text;
                        string integral1 = List1.Text;
                        MessageBox.Show(MainIntegral.Result(Upper.Text, Lower.Text, Upper1.Text, Lower1.Text, List.Text, List1.Text));
                    }
                }
            }
            catch (IntegralExeption ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Handles the SelectionChanged event of the ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the 1 event of the TextBox_TextChanged control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the TextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}