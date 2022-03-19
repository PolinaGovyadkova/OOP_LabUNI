using Exeption;
using Integral;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the TextChanged event of the TextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
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
        /// Handles the SelectionChanged event of the ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
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

                if (upper == "" && lower == "") throw new IntegralExeption("Введите данные");
                else
                {
                    if (Convert.ToDouble(Lower.Text) > Convert.ToDouble(Upper.Text))
                    {
                        Upper.Text = "";
                        Lower.Text = "";
                        throw new IntegralExeption("Верхний предел должен быть больше нижнего");
                    }
                    else
                    {
                        string integral = List.Text;
                        double number = Convert.ToDouble(Number.Text);
                        if (integral == "lg(x)")
                        {
                            MainIntegral integralLog = MainIntegral.ConvertLog(lower, upper);
                            MessageBox.Show(Convert.ToString(number * integralLog));
                        }
                        else if (integral == "cos(x)")
                        {
                            MainIntegral integralCos = MainIntegral.ConvertCos(lower, upper);
                            MessageBox.Show(Convert.ToString(number * integralCos));
                        }
                        else if (integral == "x^2")
                        {
                            MainIntegral integralQuad = MainIntegral.ConvertQuad(lower, upper);
                            MessageBox.Show(Convert.ToString(number * integralQuad));
                        }
                        else throw new IntegralExeption("Укажите функцию");
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
        /// Handles the 1 event of the Button_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Multiplication multiplication = new Multiplication();
            multiplication.Show();
        }
    }
}