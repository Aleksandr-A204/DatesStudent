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
        List<Student> listDataStud = new List<Student>();
        public AddDelStudent()
        {
            InitializeComponent();

            ReadDataStud();
        }

        public void ReadDataStud()
        {
            listDataStud = WorkWithFilesAndSerialization.ReadFromFile();
            listView_StudData.ItemsSource = listDataStud;
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_ClickAddStud(object sender, RoutedEventArgs e)
        {
            AddStud newStudent = new AddStud(new Student("", new Curriculum("", "", "", ""), new Address("","",""), new Contact("","")));

            if (newStudent.ShowDialog() == true)
            {
                listDataStud.Add(newStudent.NewStudent);
                WorkWithFilesAndSerialization.WriteToFile(listDataStud);

                ReadDataStud();
            }
        }

        private void Button_ClickDelStud(object sender, RoutedEventArgs e)
        {
            Student? selectedStudent = listView_StudData.SelectedItem as Student;

            if (selectedStudent is null)
            {
                MessageBox.Show("Выбирайте студента, которого вы хотите удалять!");
                return;
            }

            listDataStud.Remove(selectedStudent);
            WorkWithFilesAndSerialization.WriteToFile(listDataStud);

            ReadDataStud();
        }
    }
}
