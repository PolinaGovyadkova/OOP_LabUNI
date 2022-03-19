using RecepitLibrary;
using RecepitLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    internal enum ViewMode
    {
        Receipt,
        Servicez
    }

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string PATH_CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=Recepits;Integrated Security=True";
        private UnifyingRecepit accounting;
        private bool IsDbLoaded = false;
        private ViewMode viewMode;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RecepitViewer(object sender, RoutedEventArgs e)
        {
        }

        private void ShowAllRecords()
        {
            if (!IsDbLoaded) return;
            ViewOfRecords.Items.Clear();
            switch (viewMode)
            {
                case ViewMode.Receipt:
                    List<Record> records = accounting.GetAllRecords();
                    foreach (Record record in records)
                    {
                        ViewOfRecords.Items.Add(record);
                    }
                    break;

                case ViewMode.Servicez:
                    List<RecordServicez> recordServicezs = accounting.GetAllServicez();
                    foreach (RecordServicez record in recordServicezs)
                    {
                        ViewOfRecords.Items.Add(record);
                    }
                    break;
            }
        }

        private void ConnectToDatabase(object sender, RoutedEventArgs e)
        {
            FactoryDAO factory = FactoryDAO.GetFactory(PATH_CONNECTION_STRING);
            accounting = new UnifyingRecepit(factory);

            accounting.RecepitInterface.GetAllRecepits();

            IsDbLoaded = true;

            ShowAllRecords();
            LoadBreeds();

            OutputTextBox.Text += "Интерфейс подключен к базе данных." + Environment.NewLine;
        }

        private void Recepit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void ViewOfRecords_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void LoadBreeds()
        {
            if (!IsDbLoaded) return;
            RecepitComboBox.Items.Clear();
            var servicezs = accounting.ServicezInterface.GetAllServicez();
            foreach (var servicez in servicezs)
            {
                RecepitComboBox.Items.Add(servicez);
            }

            RecepitComboBox.SelectedIndex = 0;
        }

        private void AddRecord(object sender, RoutedEventArgs e)
        {
            if (!IsDbLoaded)
            {
                MessageBox.Show("База данных не загружена");
                return;
            }

            if (viewMode != ViewMode.Receipt)
            {
                MessageBox.Show("Индекс принадлежит представлению опрерации");
                return;
            }

            if (NameInputTextBox.Text == "" || DateInputTextBox.Text == "")
            {
                MessageBox.Show("Неверные данные");
                return;
            }

            RecepitDAO recepit = new RecepitDAO()
            {
                ReceiptNumber = Convert.ToInt32(NameInputTextBox.Text),
                ServiceId = (RecepitComboBox.SelectedItem as ServicezDAO).ServiceId,
            };
            accounting.RecepitInterface.Insert(recepit);

            ShowAllRecords();

            OutputTextBox.Text += "Запись добавлена." + Environment.NewLine;
        }

        private void EditRecord(object sender, RoutedEventArgs e)
        {
            if (!IsDbLoaded)
            {
                MessageBox.Show("База данных не загружена");
                return;
            }

            if (viewMode != ViewMode.Receipt)
            {
                MessageBox.Show("Индекс принадлежит представлениию квитанции");
                return;
            }

            if (NameInputTextBox.Text == "" || DateInputTextBox.Text == "")
            {
                MessageBox.Show("Неверные данные.");
                return;
            }

            if (ViewOfRecords.SelectedValue == null)
            {
                MessageBox.Show("Объект для изменения не выбран.");
                return;
            }

            RecepitDAO newReceipt = new RecepitDAO()
            {
                ReceiptNumber = Convert.ToInt32(NameInputTextBox.Text),
                ServiceId = (RecepitComboBox.SelectedItem as ServicezDAO).ServiceId,
            };

            RecepitDAO oldReceipt  = accounting.RecepitInterface.GetRecepit((ViewOfRecords.SelectedValue as Record).ReceiptId);

            accounting.RecepitInterface.Update(oldReceipt, newReceipt);

            ShowAllRecords();

            OutputTextBox.Text += "Запись отредактирована." + Environment.NewLine;
        }

        private void DeleteRecord(object sender, RoutedEventArgs e)
        {
            if (!IsDbLoaded)
            {
                MessageBox.Show("База данных не загружена");
                return;
            }

            if (viewMode != ViewMode.Receipt)
            {
                MessageBox.Show("Индекс принадлежит представления операции");
                return;
            }

            if (ViewOfRecords.SelectedValue == null)
            {
                MessageBox.Show("Объект для изменения не выбран.");
                return;
            }

            RecepitDAO recepit = accounting.RecepitInterface.GetRecepit((ViewOfRecords.SelectedValue as Record).ReceiptId);

            accounting.RecepitInterface.Delete(recepit);

            ShowAllRecords();

            OutputTextBox.Text += "Запись удалена." + Environment.NewLine;
        }

        private void SummaryTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void AddServiceRecord(object sender, RoutedEventArgs e)
        {
            if (!IsDbLoaded)
            {
                MessageBox.Show("База данных не загружена!");
                return;
            }

            if (viewMode != ViewMode.Servicez)
            {
                MessageBox.Show("Индекс принадлежит представлению операции");
                return;
            }

            if (NameTextBox.Text == "")
            {
                MessageBox.Show("Неверные или пустые данные. Проверьте поля ввода.");
                return;
            }

            StandartDAO standart = new StandartDAO()
            {
                Summary = (float)Convert.ToDouble(SummaryTextBox.Text),
                ReceiptDate = DateInputTextBox.Text,
            };

            accounting.StandartsInterface.Insert(standart);

            int standartId = accounting.StandartsInterface.GetStandart(standart).Id;

            ServicezDAO servicez = new ServicezDAO()
            {
                ServicezName = NameTextBox.Text,
                StandartId = standartId,
            };

            accounting.ServicezInterface.Insert(servicez);

            ShowAllRecords();
            LoadBreeds();

            OutputTextBox.Text += "Запись добавлена." + Environment.NewLine;
        }

        private void ChangeViewRecepits(object sender, RoutedEventArgs e)
        {
            viewMode = ViewMode.Receipt;
            ShowAllRecords();
        }

        private void ChangeViewServicez(object sender, RoutedEventArgs e)
        {
            viewMode = ViewMode.Servicez;
            ShowAllRecords();
        }

        private void EditServiceRecord(object sender, RoutedEventArgs e)
        {
            if (!IsDbLoaded)
            {
                MessageBox.Show("База данных не загружена!");
                return;
            }

            if (viewMode != ViewMode.Servicez)
            {
                MessageBox.Show("Индекс принадлежит представления квитанции");
                return;
            }

            if (NameTextBox.Text == "" || DateInputTextBox.Text == "")
            {
                MessageBox.Show("Неверные данные. Проверьте поля ввода.");
                return;
            }

            if (ViewOfRecords.SelectedValue == null)
            {
                MessageBox.Show("Объект для изменения не выбран.");
                return;
            }

            StandartDAO newStandart = new StandartDAO()
            {
                Summary = (float)Convert.ToDouble(SummaryTextBox.Text),
                ReceiptDate = DateInputTextBox.Text,
            };

            StandartDAO standart = accounting.StandartsInterface.GetStandart((ViewOfRecords.SelectedValue as RecordServicez).StandartId);

            accounting.StandartsInterface.Update(standart, newStandart);

            int standartId = accounting.StandartsInterface.GetStandart(newStandart).Id;

            ServicezDAO newServicez = new ServicezDAO()
            {
                ServicezName = NameTextBox.Text,
                StandartId = standartId,
            };

            ServicezDAO oldServicez = accounting.ServicezInterface.GetServicez((ViewOfRecords.SelectedValue as RecordServicez).ServiceId);

            accounting.ServicezInterface.Update(oldServicez, newServicez);

            ShowAllRecords();
            LoadBreeds();

            OutputTextBox.Text += "Запись изменена." + Environment.NewLine;
        }

        private void DeleteServiceRecord(object sender, RoutedEventArgs e)
        {
            if (!IsDbLoaded)
            {
                MessageBox.Show("База данных не загружена");
                return;
            }

            if (viewMode != ViewMode.Servicez)
            {
                MessageBox.Show("Индекс принадлежит представления квитанции");
                return;
            }

            if (ViewOfRecords.SelectedValue == null)
            {
                MessageBox.Show("Объект для изменения не выбран.");
                return;
            }

            ServicezDAO servicez = accounting.ServicezInterface.GetServicez((ViewOfRecords.SelectedValue as RecordServicez).ServiceId);

            accounting.ServicezInterface.Delete(servicez);

            accounting.StandartsInterface.Delete(accounting.StandartsInterface.GetStandart(servicez.StandartId));

            ShowAllRecords();
            LoadBreeds();

            OutputTextBox.Text += "Запись удалена." + Environment.NewLine;
        }
    }
}