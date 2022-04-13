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
using System.Windows.Shapes;

namespace Cint
{
    /// <summary>
    /// Логика взаимодействия для KlientForm.xaml
    /// </summary>
    public partial class KlientForm : Window
    {
        ProgressMEntities context;
        string currentLetter = "";
        public KlientForm()
        {
            InitializeComponent();
            context = new ProgressMEntities();
            ShowTable();

            ShowLetters();

        }

        private void ShowLetters()
        {
            for (char i = 'А'; i <= 'Я'; i++)
            {
                TextBlock letter = new TextBlock
                {
                    Text = i.ToString(),
                    FontWeight = FontWeights.Bold,
                    Foreground = Brushes.Black,
                    Margin = new Thickness(10, 1, 5, 1)
                };
                letter.MouseLeftButtonDown += TextBlock_MouseLeftButtonDown;
                StackLetters.Children.Add(letter);
            }
        }

        private void ShowTable()
        {
            if (TxtEmail.Text == null && TxtPhone.Text == null)
                return;
            List<Водители> listClient = context.Водители.ToList();
            listClient = listClient.Where(x => x.Фамилия.ToLower().Contains(TxtEmail.Text.ToLower())).ToList();
            listClient = listClient.Where(x => x.Имя.ToLower().Contains(TxtPhone.Text.ToLower())).ToList();
            if (currentLetter.Count() == 1)
            {
                listClient = listClient.Where(x => x.Фамилия.Contains(currentLetter)).ToList();
            }
            DataGridClient.ItemsSource = listClient.OrderBy(x => x.Фамилия).ToList();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var label = (TextBlock)sender;
            currentLetter = label.Text;
            foreach (TextBlock letter in StackLetters.Children)
            {
                letter.Foreground = Brushes.Black;
            }
            label.Foreground = Brushes.Red;
            ShowTable();
        }

        private void TxtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowTable();
        }

        private void TxtPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowTable();
        }

        private void DataGridClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void TextBlock_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
