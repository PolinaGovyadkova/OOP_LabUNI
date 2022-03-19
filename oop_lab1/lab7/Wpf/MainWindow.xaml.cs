using Products;
using System;
using System.Collections.Generic;
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
        /// The array products
        /// </summary>
        public ListOfPurchases listOfPurchases;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            listOfPurchases = new ListOfPurchases();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the DataGrid control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs" /> instance containing the event data.</param>
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the SelectionChanged event of the ComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs" /> instance containing the event data.</param>
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add add = new Add(this);
            add.Show();
        }

        /// <summary>
        /// Handles the 1 event of the Button_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listOfPurchases.TotalCost() == "Цена без скидки: 0\nЦена со скидкой: 0")
                {
                    MessageBox.Show("Заполните список покупок");
                }
                else MessageBox.Show(listOfPurchases.TotalCost());
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        /// <summary>
        /// Handles the 2 event of the Button_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listOfPurchases.AllCostByType(List.Text) == "Цена без скидки: 0\nЦена со скидкой: 0")
                {
                    MessageBox.Show("Нет товара");
                }
                else MessageBox.Show(listOfPurchases.AllCostByType(List.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        /// <summary>
        /// Handles the 3 event of the Button_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listOfPurchases.SubmittedUnits() == "0")
                {
                    MessageBox.Show("Нет покупок со скидками");
                }
                else MessageBox.Show(listOfPurchases.SubmittedUnits());
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {
            List<Purchases> list = new List<Purchases>();
            for (int i = 0; i < listOfPurchases.Length; i++)
            {
                list.Add(new Purchases()
                {
                    Name = listOfPurchases.purchases[i].Name,
                    Cost = listOfPurchases.purchases[i].Cost,
                    dicount = listOfPurchases.purchases[i].dicount,
                });
            }
            Table.Items.Refresh();
            Table.AutoGenerateColumns = false;
            Table.ItemsSource = list;
        }

        /// <summary>
        /// Handles the 4 event of the Button_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                if (listOfPurchases.AllCountByType(List.Text) == "0")
                {
                    MessageBox.Show("Нет товара");
                }
                else MessageBox.Show(listOfPurchases.AllCountByType(List.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        /// <summary>
        /// Handles the 5 event of the Button_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Edit edit = new Edit(this);
            edit.Show();
        }
    }
}