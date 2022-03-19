using Products;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class Edit : Window
    {
        /// <summary>
        /// The main window
        /// </summary>
        private MainWindow mainWindow;

        /// <summary>
        /// Initializes a new instance of the <see cref="Edit"/> class.
        /// </summary>
        /// <param name="mainWindow">The main window.</param>
        public Edit(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            Initializer();
        }

        private void Initializer()
        {
            try
            {
                if (mainWindow.Table.SelectedItem == null)
                {
                    MessageBox.Show("Укажите продукт");
                }
                else
                {
                    Purchases purchases = mainWindow.Table.SelectedItem as Purchases;
                    products1.Text = purchases.Name;
                    discount1.Text = Convert.ToString(purchases.Percent);
                    price.Text = Convert.ToString(purchases.Cost);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
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
        /// Handles the 1 event of the ComboBox_SelectionChanged control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs"/> instance containing the event data.</param>
        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the price control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void price_TextChanged(object sender, TextChangedEventArgs e)
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
                if (mainWindow.Table.SelectedItem == null)
                {
                    MessageBox.Show("Укажите продукт");
                }
                else if (Convert.ToDouble(price.Text) <= 0)
                {
                    MessageBox.Show("Цена не может быть отрицательной или равной 0");
                }
                else if (Convert.ToDouble(discount1.Text) < 0 || Convert.ToDouble(discount1.Text) > 99)
                {
                    MessageBox.Show("Некорректная скидка");
                }
                else
                {
                    Dicount disc = mainWindow.listOfPurchases.SelectedDiscount(discount1.Text);
                    string product = products1.Text;
                    double price1 = Convert.ToDouble(price.Text);
                    mainWindow.listOfPurchases.Edit(product, price1, disc, mainWindow.Table.SelectedIndex);
                    mainWindow.Update();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Заполните все ячейки корректно");
            }
        }
    }
}