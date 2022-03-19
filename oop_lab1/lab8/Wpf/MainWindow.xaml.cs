using People;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
        /// The list of people
        /// </summary>
        public ListOfPeople listOfPeople;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            listOfPeople = new ListOfPeople();
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {
            Box.Items.Clear();
            Box.ItemsSource = null;
            int i = 0;
            for (i = 0; i < listOfPeople.personsList.Count; i++)
            {
                System.Windows.Media.Color color;
                if (2020 - listOfPeople.personsList[i].Date >= 12 && listOfPeople.personsList[i].Status == "ученик")
                {
                    color = System.Windows.Media.Color.FromArgb(255, 255, 255, 0);
                    Box.Items.Add(new ListBoxItem { Content = listOfPeople.personsList[i].Display(), Background = new SolidColorBrush(color) });
                    //File.AppendAllText("H:\\new_file2.txt", listOfPeople.person[i].Display() + "\n");
                }
                else Box.Items.Add(new ListBoxItem { Content = listOfPeople.personsList[i].Display() });
            }
            Box.Items.Refresh();
        }

        /// <summary>
        /// Updates for pupils.
        /// </summary>
        public void UpdateForPupils()
        {
            Box_Losers.Items.Clear();
            string name = Text.Text;
            Box_Losers.ItemsSource = null;
            int i = 0;
            List<Person> pupils = listOfPeople.personsList.FindAll(x => x.Status == "ученик").ToList();
            List<StudentAndPupil> list = pupils.Cast<StudentAndPupil>().ToList();
            list.Sort();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Info() <= 2 && list[i].EducationalInstitution == name)
                {
                    Box_Losers.Items.Add(new ListBoxItem { Content = list[i].Display() });
                    //File.AppendAllText("H:\\new_file1.txt", listOfPeople.pupils[i].Display() + "\n");
                }
            }
            Box_Losers.Items.Refresh();
        }

        /// <summary>
        /// Updates for students.
        /// </summary>
        public void UpdateForStudents()
        {
            Box_Scholarship.Items.Clear();
            Box_Scholarship.ItemsSource = null;
            int i = 0;
            List<Person> students = listOfPeople.personsList.FindAll(x => x.Status == "студент").ToList();
            List<StudentAndPupil> list = students.Cast<StudentAndPupil>().ToList();
            list.Sort();
            for (i = 0; i < list.Count; i++)
            {
                if (list[i].Info() >= 9)
                {
                    Box_Scholarship.Items.Add(new ListBoxItem { Content = list[i].Display() });
                    //File.AppendAllText("H:\\new_file.txt", listOfPeople.student[i].Display() + "\n");
                }
            }
            Box_Scholarship.Items.Refresh();
        }

        /// <summary>
        /// Handles the Click event of the ReadFromFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void ReadFromFile_Click(object sender, RoutedEventArgs e)
        {
            listOfPeople = new ListOfPeople();
            listOfPeople.Add();
            Update();
        }

        /// <summary>
        /// Handles the SelectionChanged event of the Box control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs" /> instance containing the event data.</param>
        private void Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the TextChanged event of the TextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs" /> instance containing the event data.</param>
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the Button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listOfPeople = new ListOfPeople();
            listOfPeople.Add();
            UpdateForPupils();
        }

        /// <summary>
        /// Handles the 2 event of the Box_SelectionChanged control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs" /> instance containing the event data.</param>
        private void Box_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the 1 event of the Box_SelectionChanged control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="SelectionChangedEventArgs" /> instance containing the event data.</param>
        private void Box_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        }

        /// <summary>
        /// Handles the 1 event of the Button_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listOfPeople = new ListOfPeople();
            listOfPeople.Add();
            UpdateForStudents();
        }

        /// <summary>
        /// Handles the 2 event of the Button_Click control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddPupilOrStudent add = new AddPupilOrStudent(this);
            add.Show();
        }

        /// <summary>
        /// Handles the TextChanged event of the place control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void place_TextChanged(object sender, TextChangedEventArgs e)
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddWorking add = new AddWorking(this);
            add.Show();
        }
    }
}