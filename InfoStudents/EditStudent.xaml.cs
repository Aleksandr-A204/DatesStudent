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
    /// Логика взаимодействия для EditStutend.xaml
    /// </summary>
    public partial class EditStudent : Window
    {
        List<Student> listStudents = WorkWithFilesAndSerialization.ReadFromFile();
        public EditStudent()
        {
            InitializeComponent();

            userList.ItemsSource = listStudents;
        }
        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Button_ClickEdit(object sender, RoutedEventArgs e) 
        {

            Close();
        }

        private void ListStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
