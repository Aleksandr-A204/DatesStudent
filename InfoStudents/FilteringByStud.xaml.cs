using StudentInfo;
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
using WorkWithFilesInfo;

namespace InfoStudentsWPF
{
    /// <summary>
    /// Логика взаимодействия для FilteringByStud.xaml
    /// </summary>
    public partial class FilteringByStud : Window
    {
        public FilteringByStud()
        {
            InitializeComponent();

            userList.ItemsSource = WorkWithFilesAndSerialization.ReadFromFile();
        }
        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_ClickFiltr(object sender, RoutedEventArgs e)
        {

        }

        private void ListStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
    }
}
