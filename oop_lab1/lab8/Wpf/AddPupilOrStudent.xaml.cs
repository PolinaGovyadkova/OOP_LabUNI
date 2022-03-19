using System;
using System.Windows;
using System.Windows.Controls;

namespace Wpf
{
    /// <summary>
    /// Логика взаимодействия для AddPupilorStudent.xaml
    /// </summary>
    /// <seealso cref="System.Windows.Window" />
    /// <seealso cref="System.Windows.Markup.IComponentConnector" />
    public partial class AddPupilOrStudent : Window
    {
        /// <summary>The main window</summary>
        private MainWindow mainWindow;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddPupilorStudent"/> class.
        /// </summary>
        /// <param name="mainWindow">The main window.</param>
        public AddPupilOrStudent(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the TextChanged event of the surname control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void surname_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the 2 event of the Button_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (mainWindow.listOfPeople.IsInfo(surname.Text, data.Text, status.Text, place.Text, group.Text) == false) MessageBox.Show("Некорректные данные");
                else if (mainWindow.listOfPeople.IsArray(array.Text) == false) MessageBox.Show("Некорректные числа");
                else
                {
                    mainWindow.listOfPeople.NewPerson(surname.Text, Convert.ToInt32(data.Text), status.Text, place.Text, group.Text, array.Text);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the group control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void group_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the array control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void array_TextChanged(object sender, TextChangedEventArgs e)
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
        /// Handles the TextChanged event of the data control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void data_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the place control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void place_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}