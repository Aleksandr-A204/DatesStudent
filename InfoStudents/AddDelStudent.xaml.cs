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
    /// Логика взаимодействия для AddDelStudent.xaml
    /// </summary>
    public partial class AddDelStudent : Window
    {
        List<Student> getInfoStud = new List<Student>();
        public AddDelStudent()
        {
            InitializeComponent();

            ReadDataStud();
        }

        public void ReadDataStud()
        {
            getInfoStud = WorkWithFilesAndSerialization.ReadFromFile();
            userList.ItemsSource = getInfoStud;
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_ClickAddStud(object sender, RoutedEventArgs e)
        {
            AddStud addStud = new AddStud();
            addStud.Show();

            ReadDataStud();
        }

        private void Button_ClickDelStud(object sender, RoutedEventArgs e)
        {
            Student? selectedStudent = userList.SelectedItem as Student;

            if (selectedStudent is null)
            {
                MessageBox.Show("Выбирайте студента!");
                return;
            }

            getInfoStud.Remove(selectedStudent);
            WorkWithFilesAndSerialization.WriteToFile(getInfoStud);

            //MessageBox.Show("Студент успешно удален!");

            ReadDataStud();
        }
    }
}
