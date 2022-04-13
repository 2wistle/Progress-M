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
    /// Логика взаимодействия для AddButton.xaml
    /// </summary>
    public partial class AddButton : Window
    {
        ProgressMEntities context;
        public AddButton(ProgressMEntities context, Учёт newзаказ)
        {
            
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }
}
