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
using ThirdLab.CircusDataSetTableAdapters;

namespace ThirdLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CircusEntities context = new CircusEntities();

        TicketsTableAdapter ticket = new TicketsTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            EFTable.ItemsSource = context.Tickets.ToList();

            DataSetTable.ItemsSource = ticket.GetFullInfo();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataSetTable.Columns[1].Visibility = Visibility.Collapsed;
            DataSetTable.Columns[2].Visibility = Visibility.Collapsed;
        }
    }
}
