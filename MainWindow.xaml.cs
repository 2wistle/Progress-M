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

namespace Cint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ProgressMEntities context;
        public MainWindow()
        {
            InitializeComponent();
            context = new ProgressMEntities();
            ShowTable();
        }

        private void ShowTable()
        {
            DataGridRental.ItemsSource = context.Учёт.ToList();
        }

        private void BtnAddData_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnDeleteData_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnEditData_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnDeleteClientS_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnDeleteClie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDele_Click(object sender, RoutedEventArgs e)
        {
            var RentalSelect = new KlientForm();
            RentalSelect.ShowDialog();
        }
    }
}
